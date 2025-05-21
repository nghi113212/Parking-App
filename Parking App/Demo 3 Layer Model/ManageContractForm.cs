using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace Demo_3_Layer_Model
{
    public partial class ManageContractForm : Form
    {
        private int? selectedContractId = null;
        public ManageContractForm()
        {
            InitializeComponent();
        }

        private void ManageContractForm_Load(object sender, EventArgs e)
        {
            comboBoxContractType.Items.Add("Cho thuê");
            comboBoxContractType.Items.Add("Ký gửi");
            comboBoxContractType.SelectedIndex = 0; // mặc định chọn "Cho thuê"
            ContractBUS.Instance.UpdateExpiredContracts();
            dataGridView1.DataSource = ContractBUS.Instance.GetAllContracts();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string contractType = comboBoxContractType.SelectedItem.ToString();
                int vehicleId = Convert.ToInt32(textBoxVehicleId.Text.Trim());
                int customerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());
                DateTime dayStart = dateTimePicker1.Value;
                DateTime dayEnd = dateTimePicker2.Value;
                int price = Convert.ToInt32(textBoxPrice.Text.Trim());
                //int staffId = currentStaffId; // bạn lấy ID staff hiện tại (đăng nhập)


                if (ContractBUS.Instance.InsertContract(contractType, vehicleId, customerId,
                    dayStart, dayEnd, price, 1, "Đang hiệu lực")) // giả sử staffId là 1
                {
                    if (contractType == "Ký gửi")
                    {
                        VehicleBUS.Instance.UpdateVehicleOwner(vehicleId, customerId);
                    }

                    MessageBox.Show("Add contract sucessfully!");
                    // Gọi hàm load lại dữ liệu, nếu có
                    dataGridView1.DataSource = ContractBUS.Instance.GetAllContracts();
                }
                else
                {
                    MessageBox.Show("Add contract unsecessfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedContractId = Convert.ToInt32(row.Cells["contractId"].Value);
                // Load lên các textbox
                comboBoxContractType.Text = row.Cells["contractType"].Value?.ToString();
                textBoxVehicleId.Text = row.Cells["vehicleId"].Value?.ToString();
                textBoxCustomerId.Text = row.Cells["customerId"].Value?.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["startDate"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["endDate"].Value);
                textBoxPrice.Text = row.Cells["price"].Value?.ToString();
                // Có thể thêm: staffId, status nếu muốn
                if (row.Cells["status"].Value.ToString() == "Đang xử lý")
                {
                    bt_Add.Enabled = false;
                }
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (selectedContractId == null)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng để sửa!");
                return;
            }

            bool success = ContractBUS.Instance.UpdateContract(
                selectedContractId.Value,
                comboBoxContractType.Text,
                int.Parse(textBoxVehicleId.Text),
                int.Parse(textBoxCustomerId.Text),
                dateTimePicker1.Value,
                dateTimePicker2.Value,
                int.Parse(textBoxPrice.Text)
            );

            if (success)
            {
                MessageBox.Show("Cập nhật thành công!");
                ContractBUS.Instance.UpdateExpiredContracts();
                dataGridView1.DataSource = ContractBUS.Instance.GetAllContracts();
                selectedContractId = null;
                bt_Add.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private void bt_FilterByPending_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ContractBUS.Instance.GetContractsByStatus("Đang xử lí");
        }

        private void bt_FilterByComplete_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ContractBUS.Instance.GetContractsByStatus("Đang hiệu lực");
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                if (rowIndex >= 0)
                {
                    int contractId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["contractId"].Value);
                    string status = dataGridView1.Rows[rowIndex].Cells["status"].Value.ToString();
                    string contractType = dataGridView1.Rows[rowIndex].Cells["contractType"].Value.ToString();
                    int vehicleId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["vehicleId"].Value);
                    decimal price = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["price"].Value);

                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa hợp đồng này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Nếu hợp đồng đã hết hạn → tạo hóa đơn
                        if (status == "Đã hết hạn")
                        {
                            if(contractType == "Cho thuê")
                            {
                                bool billCreated = BillBUS.Instance.CreateBillFromContract(contractId);
                                if (!billCreated)
                                {
                                    MessageBox.Show("Tạo hóa đơn thất bại. Không thể xóa hợp đồng.");
                                    return;
                                }
                            }
                            else if(contractType == "Ký gửi")
                            {
                                bool billCreated = BillBUS.Instance.UpdateBillForConsignContract(contractId, vehicleId, price);
                                if (!billCreated)
                                {
                                    MessageBox.Show("Tạo hóa đơn thất bại. Không thể xóa hợp đồng.");
                                    return;
                                }
                                else
                                {
                                    VehicleBUS.Instance.DeleteVehicle(vehicleId);
                                }
                                
                            }
                            
                        }

                        if(status == "Đang hiệu lực")
                        {
                            MessageBox.Show("Hợp đồng này đang hiệu lực. Không thể xóa.");
                            return;
                        }

                        // Xóa hợp đồng 
                        bool deleted = ContractBUS.Instance.DeleteContract(contractId);
                        if (deleted)
                        {
                            MessageBox.Show("Đã xóa hợp đồng thành công!");
                            dataGridView1.DataSource = ContractBUS.Instance.GetAllContracts();
                            bt_Add.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Xóa hợp đồng thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô bất kỳ trong hợp đồng cần xóa!");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns["status"].Index == e.ColumnIndex)
            {
                string status = e.Value?.ToString();

                if (status == "Đã hết hạn")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (status == "Đang hiệu lực")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
                else if (status == "Đang xử lí" || status == "Đang xử lý")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Orange;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; // Mặc định
                }
            }
        }

        private void bt_AllContract_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ContractBUS.Instance.GetAllContracts();
        }

        private void bt_ExportToWord_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    if(dataGridView1.Rows[rowIndex].Cells["contractType"].Value.ToString() == "Ký gửi")
                    {
                        int contractId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["contractId"].Value);
                        int vehicleId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["vehicleId"].Value);
                        int customerId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["customerId"].Value);


                        DataTable contractTable = ContractBUS.Instance.GetContractById(contractId);
                        if (contractTable.Rows.Count == 0) return;

                        var contractRow = contractTable.Rows[0];
                        DateTime dayStart = Convert.ToDateTime(contractRow["startDate"]);
                        DateTime dayEnd = Convert.ToDateTime(contractRow["endDate"]);
                        int price = Convert.ToInt32(contractRow["price"]);

                        DataTable customerTable = CustomerBUS.Instance.GetCustomerById(customerId);
                        var customerRow = customerTable.Rows[0];
                        string fullName = customerRow["fullName"].ToString();
                        string identityNumber = customerRow["identityCard"].ToString();
                        string phone = customerRow["phoneNumber"].ToString();
                        string address = customerRow["address"].ToString();

                        DataTable vehicleTable = VehicleBUS.Instance.GetVehicleById(vehicleId);
                        var vehicleRow = vehicleTable.Rows[0];
                        string licensePlate = vehicleRow["licensePlate"].ToString();
                        string model = vehicleRow["model"].ToString();

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Word Documents|*.docx";
                        saveFileDialog.FileName = $"HopDongKyGui_{contractId}.docx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            object missing = Missing.Value;
                            Word.Application wordApp = new Word.Application();
                            Word.Document doc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                            wordApp.Selection.Font.Name = "Times New Roman";

                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            wordApp.Selection.Font.Size = 14;
                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n");
                            wordApp.Selection.TypeText("Độc lập - Tự do - Hạnh phúc\n\n");

                            //wordApp.Selection.TypeText($"HỢP ĐỒNG KÝ GỬI XE SỐ: HD{contractId:000}\n\n");
                            // Tiêu đề căn giữa
                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.Font.Size = 14;
                            wordApp.Selection.TypeText("HỢP ĐỒNG KÝ GỬI XE\n");

                            // Dòng mã hợp đồng xuống dòng và căn trái
                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.Font.Size = 12;
                            wordApp.Selection.TypeText($"Mã hợp đồng: HD{contractId:000}\n");

                            // Reset lại định dạng về bình thường cho phần nội dung sau
                            wordApp.Selection.Font.Size = 13;

                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                            wordApp.Selection.TypeText($"Hôm nay, ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}, tại Công ty XYZ, chúng tôi gồm:\n");

                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("BÊN A (Bên gửi xe):\n");
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.TypeText($"Họ tên     : {fullName}\n");
                            wordApp.Selection.TypeText($"CMND/CCCD: {identityNumber}\n");
                            wordApp.Selection.TypeText($"SĐT        : {phone}\n");
                            wordApp.Selection.TypeText($"Địa chỉ    : {address}\n");

                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("BÊN B (Đơn vị nhận ký gửi):\n");
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.TypeText("Tên đơn vị: Công ty TNHH Dịch Vụ Gửi Xe ABC\n");
                            wordApp.Selection.TypeText("Địa chỉ: 123 Đường ABC, Quận XYZ, TP.HCM\n");
                            wordApp.Selection.TypeText("SĐT: 0123 456 789\n\n");

                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("NỘI DUNG HỢP ĐỒNG:\n");
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.TypeText("Chúng tôi cùng thỏa thuận ký kết hợp đồng với các điều khoản sau:\n\n");

                            wordApp.Selection.TypeText("1. Thông tin xe:\n");
                            wordApp.Selection.TypeText($"   - Biển số     : {licensePlate}\n");
                            wordApp.Selection.TypeText($"   - Hãng xe     : {model}\n");

                            wordApp.Selection.TypeText("2. Thời gian gửi:\n");
                            wordApp.Selection.TypeText($"   - Ngày bắt đầu : {dayStart:dd/MM/yyyy}\n");
                            wordApp.Selection.TypeText($"   - Ngày kết thúc: {dayEnd:dd/MM/yyyy}\n");

                            wordApp.Selection.TypeText("3. Chi phí và thanh toán:\n");
                            wordApp.Selection.TypeText($"   - Giá thỏa thuận: {price:N0} VNĐ\n\n");

                            wordApp.Selection.TypeText("Hai bên cam kết thực hiện đúng các điều khoản nêu trên. Hợp đồng được lập thành 02 bản, mỗi bên giữ 01 bản và có hiệu lực từ ngày ký.\n\n");

                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            wordApp.Selection.TypeText($"TP.HCM, ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}\n\n");

                            wordApp.Selection.TypeText("            Đại diện Bên A                                 Đại diện Bên B\n");
                            wordApp.Selection.TypeText("           (Ký và ghi rõ họ tên)                         (Ký và ghi rõ họ tên)\n");

                            doc.SaveAs2(saveFileDialog.FileName);
                            doc.Close();
                            wordApp.Quit();

                            MessageBox.Show("Xuất hợp đồng thành công!");
                        }
                    }
                    else if(dataGridView1.Rows[rowIndex].Cells["contractType"].Value.ToString() == "Cho thuê")
                    {
                        int contractId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["contractId"].Value);
                        int vehicleId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["vehicleId"].Value);
                        int customerId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["customerId"].Value);

                        DataTable contractTable = ContractBUS.Instance.GetContractById(contractId);
                        if (contractTable.Rows.Count == 0) return;

                        var contractRow = contractTable.Rows[0];
                        DateTime dayStart = Convert.ToDateTime(contractRow["startDate"]);
                        DateTime dayEnd = Convert.ToDateTime(contractRow["endDate"]);
                        int price = Convert.ToInt32(contractRow["price"]);

                        DataTable customerTable = CustomerBUS.Instance.GetCustomerById(customerId);
                        var customerRow = customerTable.Rows[0];
                        string fullName = customerRow["fullName"].ToString();
                        string identityNumber = customerRow["identityCard"].ToString();
                        string phone = customerRow["phoneNumber"].ToString();
                        string address = customerRow["address"].ToString();

                        DataTable vehicleTable = VehicleBUS.Instance.GetVehicleById(vehicleId);
                        var vehicleRow = vehicleTable.Rows[0];
                        string licensePlate = vehicleRow["licensePlate"].ToString();
                        string model = vehicleRow["model"].ToString();

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Word Documents|*.docx";
                        saveFileDialog.FileName = $"HopDongThue_{contractId}.docx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            object missing = Missing.Value;
                            Word.Application wordApp = new Word.Application();
                            Word.Document doc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                            wordApp.Selection.Font.Name = "Times New Roman";
                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            wordApp.Selection.Font.Size = 14;
                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n");
                            wordApp.Selection.TypeText("Độc lập - Tự do - Hạnh phúc\n\n");

                            wordApp.Selection.TypeText("HỢP ĐỒNG CHO THUÊ XE\n");

                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.Font.Size = 12;
                            wordApp.Selection.TypeText($"Mã hợp đồng: HD{contractId:000}\n");

                            wordApp.Selection.Font.Size = 13;
                            wordApp.Selection.TypeText($"Hôm nay, ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}, tại Công ty XYZ, chúng tôi gồm:\n");

                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("BÊN A (Bên thuê xe):\n");
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.TypeText($"Họ tên     : {fullName}\n");
                            wordApp.Selection.TypeText($"CMND/CCCD: {identityNumber}\n");
                            wordApp.Selection.TypeText($"SĐT        : {phone}\n");
                            wordApp.Selection.TypeText($"Địa chỉ    : {address}\n");

                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("BÊN B (Bên cho thuê):\n");
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.TypeText("Tên đơn vị: Công ty TNHH Dịch Vụ Cho Thuê Xe ABC\n");
                            wordApp.Selection.TypeText("Địa chỉ: 123 Đường ABC, Quận XYZ, TP.HCM\n");
                            wordApp.Selection.TypeText("SĐT: 0123 456 789\n\n");

                            wordApp.Selection.Font.Bold = 1;
                            wordApp.Selection.TypeText("NỘI DUNG HỢP ĐỒNG:\n");
                            wordApp.Selection.Font.Bold = 0;
                            wordApp.Selection.TypeText("Hai bên thỏa thuận ký hợp đồng cho thuê xe với các điều khoản như sau:\n\n");

                            wordApp.Selection.TypeText("1. Thông tin xe:\n");
                            wordApp.Selection.TypeText($"   - Biển số     : {licensePlate}\n");
                            wordApp.Selection.TypeText($"   - Hãng xe     : {model}\n");

                            wordApp.Selection.TypeText("2. Thời gian thuê:\n");
                            wordApp.Selection.TypeText($"   - Ngày bắt đầu : {dayStart:dd/MM/yyyy}\n");
                            wordApp.Selection.TypeText($"   - Ngày kết thúc: {dayEnd:dd/MM/yyyy}\n");

                            wordApp.Selection.TypeText("3. Chi phí và thanh toán:\n");
                            wordApp.Selection.TypeText($"   - Giá thuê       : {price:N0} VNĐ\n");
                            wordApp.Selection.TypeText("   - Hình thức thanh toán: Tiền mặt hoặc chuyển khoản\n\n");

                            wordApp.Selection.TypeText("4. Trách nhiệm của các bên:\n");
                            wordApp.Selection.TypeText("- Bên B đảm bảo xe an toàn, đầy đủ giấy tờ khi giao xe.\n");
                            wordApp.Selection.TypeText("- Bên A có trách nhiệm sử dụng xe đúng quy định và trả xe đúng hạn.\n\n");

                            wordApp.Selection.TypeText("Hợp đồng được lập thành 02 bản, mỗi bên giữ 01 bản và có giá trị pháp lý như nhau.\n\n");

                            wordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            wordApp.Selection.TypeText($"TP.HCM, ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}\n\n");

                            wordApp.Selection.TypeText("            Đại diện Bên A                                 Đại diện Bên B\n");
                            wordApp.Selection.TypeText("           (Ký và ghi rõ họ tên)                         (Ký và ghi rõ họ tên)\n");

                            doc.SaveAs2(saveFileDialog.FileName);
                            doc.Close();
                            wordApp.Quit();

                            MessageBox.Show("Xuất hợp đồng thuê thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hợp đồng không hợp lệ!");
                        return;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để xuất!");
            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            string licensePlate = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(licensePlate))
            {
                MessageBox.Show("Vui lòng nhập biển số xe.");
                return;
            }

            DataTable result = ContractBUS.Instance.GetContractsByLicensePlate(licensePlate);

            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hợp đồng với biển số này.");
                dataGridView1.DataSource = null;
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            // Reset các TextBox
            textBoxCustomerId.Text = "";
            textBoxVehicleId.Text = "";
            textBoxPrice.Text = "";

            // Reset DateTimePicker
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            // Reset ComboBox nếu có
            if (comboBoxContractType.Items.Count > 0)
                comboBoxContractType.SelectedIndex = 0;

            // Nếu có DataGridView chọn dòng thì bỏ chọn
            dataGridView1.ClearSelection();
            bt_Add.Enabled = true;
        }
    }
}
