using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Demo_3_Layer_Model
{
    public partial class ManageVehicleForm : Form
    {
        public ManageVehicleForm()
        {
            InitializeComponent();
        }

        private void ManageVehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carParkingDBDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.carParkingDBDataSet.Vehicle);
            comboBoxChooseAvailablePosition.Enabled = false;
            textBoxPCardCode.Enabled = false;
            textBoxCarOwnerName.Enabled = false;
            textBoxCarOwnerPhone.Enabled = false;
            richTextBoxCarIssueDesc.Enabled = false;
            radioButtonHour.Enabled = false;
            radioButtonDay.Enabled = false;
            radioButtonMonth.Enabled = false;
            radioButtonWeek.Enabled = false;


            comboBoxChooseCarType.DataSource = VehicleTypeBUS.Instance.GetAllVehicleTypes();
            comboBoxChooseCarType.DisplayMember = "vehicle_typeName";
            comboBoxChooseCarType.ValueMember = "vehicle_typeId";

            //DataGridView 
            dataGridView1.DataSource = VehicleBUS.Instance.GetAllVehicles();

            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AllowUserToAddRows = false;


            if (dataGridView1.Columns.Count > 7)
            {
                if (dataGridView1.Columns[5] is DataGridViewImageColumn col1)
                {
                    col1.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }

                if (dataGridView1.Columns[6] is DataGridViewImageColumn col2)
                {
                    col2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
            // Đặt lại tên cột cho nhìn thân thiện hơn
            dataGridView1.Columns["vehicleId"].HeaderText = "Mã xe";
            dataGridView1.Columns["licensePlate"].HeaderText = "Biển số";
            dataGridView1.Columns["model"].HeaderText = "Hiệu xe";
            dataGridView1.Columns["time_in"].HeaderText = "Giờ vào";
            dataGridView1.Columns["vehicle_typeId"].HeaderText = "Loại xe";
            dataGridView1.Columns["img_plate_bike"].HeaderText = "Ảnh biển số";
            dataGridView1.Columns["img_owner_carModel"].HeaderText = "Ảnh chủ xe";
            dataGridView1.Columns["ownerName"].HeaderText = "Tên chủ xe";
            dataGridView1.Columns["ownerPhone"].HeaderText = "SĐT chủ xe";
            dataGridView1.Columns["serviceId"].HeaderText = "Mã dịch vụ";
            dataGridView1.Columns["slotId"].HeaderText = "Vị trí đỗ";
            dataGridView1.Columns["parkingCard_code"].HeaderText = "Mã thẻ giữ xe";
            dataGridView1.Columns["problem_desc"].HeaderText = "Mô tả sự cố";
            dataGridView1.Columns["parkingType"].HeaderText = "Loại gửi";
        }

        private void radioButtonParkingService_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParkingService.Checked)
            {
                // Bật các control cho Parking
                comboBoxChooseAvailablePosition.Enabled = true;
                textBoxPCardCode.Enabled = true;
                radioButtonHour.Enabled = true;
                radioButtonDay.Enabled = true;
                radioButtonMonth.Enabled = true;
                radioButtonWeek.Enabled = true;
                textBoxCarOwnerName.Enabled = true;
                textBoxCarOwnerPhone.Enabled = true;

                // Tắt các control không liên quan

                richTextBoxCarIssueDesc.Enabled = false;


                //Đảm báo các controll khác trống
                textBoxCarOwnerName.Clear();
                textBoxCarOwnerPhone.Clear();
                richTextBoxCarIssueDesc.Clear();
            }
        }

        private void radioButtonWashingService_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWashingService.Checked)
            {
                // Bật các control cho Parking
                textBoxCarOwnerName.Enabled = true;
                textBoxCarOwnerPhone.Enabled = true;

                // Tắt các control không liên quan
                richTextBoxCarIssueDesc.Enabled = false;
                comboBoxChooseAvailablePosition.Enabled = false;
                textBoxPCardCode.Enabled = false;
                radioButtonHour.Enabled = false;
                radioButtonDay.Enabled = false;
                radioButtonMonth.Enabled = false;
                radioButtonWeek.Enabled = false;

                //Đảm báo các controll khác trống
                richTextBoxCarIssueDesc.Clear();
                radioButtonHour.Checked = false;
                radioButtonDay.Checked = false;
                radioButtonMonth.Checked = false;
                radioButtonWeek.Checked = false;
            }
        }

        private void radioButtonFixingService_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFixingService.Checked)
            {
                // Bật các control cho Parking
                textBoxCarOwnerName.Enabled = true;
                textBoxCarOwnerPhone.Enabled = true;
                richTextBoxCarIssueDesc.Enabled = true;

                // Tắt các control không liên quan
                comboBoxChooseAvailablePosition.Enabled = false;
                textBoxPCardCode.Enabled = false;
                radioButtonHour.Enabled = false;
                radioButtonDay.Enabled = false;
                radioButtonMonth.Enabled = false;
                radioButtonWeek.Enabled = false;

                //Đảm báo các controll khác trống
                radioButtonHour.Checked = false;
                radioButtonDay.Checked = false;
                radioButtonMonth.Checked = false;
                radioButtonWeek.Checked = false;
            }
        }

        private void radioButton_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Other.Checked)
            {
                textBoxCarOwnerName.Enabled = false;
                textBoxCarOwnerPhone.Enabled = false;
                richTextBoxCarIssueDesc.Enabled = false;

                comboBoxChooseAvailablePosition.Enabled = false;
                textBoxPCardCode.Enabled = false;
                radioButtonHour.Enabled = false;
                radioButtonDay.Enabled = false;
                radioButtonMonth.Enabled = false;
                radioButtonWeek.Enabled = false;

                radioButtonHour.Checked = false;
                radioButtonDay.Checked = false;
                radioButtonMonth.Checked = false;
                radioButtonWeek.Checked = false;
            }
        }

        private void bt_UploadPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);

                string imagePath = opf.FileName;
                string plate = RunPythonOCR(imagePath);
                textBoxLicensePlate.Text = plate;
                MessageBox.Show("Biển số xe: " + plate);
            }
        }

        private string RunPythonOCR(string imagePath)
        {
            string pythonPath = @"C:\Users\HUU NGHI\AppData\Local\Programs\Python\Python312\python.exe"; // Đường dẫn python.exe
            string scriptPath = @"D:\Visual Studio code\WinForm Project\Demo 3 Layer Model\PlateRecognition\read_plate.py"; // Đường dẫn đến script

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = pythonPath;
            psi.Arguments = $"\"{scriptPath}\" \"{imagePath}\"";
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            try
            {
                using (Process process = Process.Start(psi))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        return result.Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        private void bt_UploadPic2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opf = new OpenFileDialog();
            //opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            //if ((opf.ShowDialog() == DialogResult.OK))
            //{
            //    pictureBox2.Image = Image.FromFile(opf.FileName);
            //}

            string ownerName = textBoxCarOwnerName.Text.Trim(); // Hoặc chỗ bạn nhập tên chủ xe
            if (string.IsNullOrEmpty(ownerName))
            {
                MessageBox.Show("Vui lòng nhập tên chủ xe!");
                return;
            }

            // Gọi hàm chụp ảnh và lưu ảnh mặt
            CaptureFace(ownerName);

            // Hiển thị lại ảnh vừa lưu vào pictureBox2
            string savedImagePath = $"D:\\Visual Studio code\\WinForm Project\\Demo 3 Layer Model\\FaceRecognition\\dataset\\{ownerName}\\face.jpg";
            if (File.Exists(savedImagePath))
            {
                pictureBox2.Image = Image.FromFile(savedImagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh sau khi lưu!");
            }


        }

        private void CaptureFace(string ownerName)
        {
            var p = new Process();
            string scriptPath = @"D:\Visual Studio code\WinForm Project\Demo 3 Layer Model\FaceRecognition\face_register.py";
            p.StartInfo.FileName = @"C:\Users\HUU NGHI\AppData\Local\Programs\Python\Python312\python.exe";
            p.StartInfo.Arguments = $"\"{scriptPath}\" \"{ownerName}\"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            MessageBox.Show("Ảnh đã được lưu cho: " + output);
        }

        private bool VerifyFace(string ownerName)
        {
            var p = new Process();
            string scriptPath = @"D:\Visual Studio code\WinForm Project\Demo 3 Layer Model\FaceRecognition\face_recognize.py";
            p.StartInfo.FileName = @"C:\Users\HUU NGHI\AppData\Local\Programs\Python\Python312\python.exe";
            p.StartInfo.Arguments = $"\"{scriptPath}\" \"{ownerName}\"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string result = p.StandardOutput.ReadToEnd().Trim();
            p.WaitForExit();

            return result == "MATCH";
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void bt_AddVehicle_Click(object sender, EventArgs e)
        {
            int serviceId = 0;

            if (radioButtonParkingService.Checked)
                serviceId = 1;
            else if (radioButtonWashingService.Checked)
                serviceId = 2;
            else if (radioButtonFixingService.Checked)
                serviceId = 3;
            else if (radioButton_Other.Checked)
                serviceId = 4;
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thu thập dữ liệu
            int vehicleId = Convert.ToInt32(textBoxVehicleID.Text);
            string licensePlate = textBoxLicensePlate.Text;
            string model = textBoxCarBrand.Text;
            DateTime timeIn = DateTime.Now;
            int vehicleTypeId = Convert.ToInt32(comboBoxChooseCarType.SelectedValue);
            byte[] imgPlateBike = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imgPlateBike = ms.ToArray();
                }
            }

            byte[] imgOwnerCarModel = null;
            if (pictureBox2.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    imgOwnerCarModel = ms.ToArray();
                }
            }
            string ownerName = textBoxCarOwnerName.Text;
            string ownerPhone = textBoxCarOwnerPhone.Text;
            int? slotId = null;

            if (radioButtonParkingService.Checked)
            {
                slotId = Convert.ToInt32(comboBoxChooseAvailablePosition.SelectedValue);
            }
            string parkingCardCode = textBoxPCardCode.Text;
            string problemDesc = richTextBoxCarIssueDesc.Text;
            string parkingType = radioButtonHour.Checked ? "Hour" :
                radioButtonDay.Checked ? "Day" :
                radioButtonMonth.Checked ? "Month" :
                radioButtonWeek.Checked ? "Week" : "";

            // Gọi BUS
            bool success = VehicleBUS.Instance.AddVehicle(
                vehicleId, licensePlate, model, timeIn, vehicleTypeId,
                imgPlateBike, imgOwnerCarModel, ownerName, ownerPhone,
                serviceId, slotId, parkingCardCode, problemDesc, parkingType
            );

            if (success)
            {
                MessageBox.Show("Thêm xe thành công!");
                dataGridView1.DataSource = VehicleBUS.Instance.GetAllVehicles();
            }
            else
                MessageBox.Show("Thêm xe thất bại!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu không phải click vào hàng dữ liệu thì bỏ qua
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxVehicleID.Text = row.Cells[0].Value?.ToString();
                textBoxLicensePlate.Text = row.Cells[1].Value?.ToString();
                textBoxCarBrand.Text = row.Cells[2].Value?.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells[3].Value;

                // ComboBox chọn loại xe
                comboBoxChooseCarType.SelectedValue = Convert.ToInt32(row.Cells[4].Value);

                // Ảnh biển số xe
                if (row.Cells[5].Value != DBNull.Value && row.Cells[5].Value != null)
                {
                    byte[] imgData1 = (byte[])row.Cells[5].Value;
                    using (MemoryStream ms = new MemoryStream(imgData1))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }

                // Ảnh chủ xe
                if (row.Cells[6].Value != DBNull.Value && row.Cells[6].Value != null)
                {
                    byte[] imgData2 = (byte[])row.Cells[6].Value;
                    using (MemoryStream ms = new MemoryStream(imgData2))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox2.Image = null;
                }

                textBoxCarOwnerName.Text = row.Cells[7].Value?.ToString();
                textBoxCarOwnerPhone.Text = row.Cells[8].Value?.ToString();


                int vehicleTypeId = Convert.ToInt32(row.Cells[4].Value);
                int? currentSlotId = row.Cells[10].Value != DBNull.Value ? Convert.ToInt32(row.Cells[10].Value) : (int?)null;

                comboBoxChooseAvailablePosition.DataSource = SlotBUS.Instance.GetAvailableSlots(vehicleTypeId, currentSlotId);
                comboBoxChooseAvailablePosition.DisplayMember = "slotNumber";
                comboBoxChooseAvailablePosition.ValueMember = "slotId";

                if (row.Cells[10].Value != DBNull.Value && row.Cells[10].Value != null)
                {
                    comboBoxChooseAvailablePosition.SelectedValue = row.Cells[10].Value;
                }
                else
                {
                    comboBoxChooseAvailablePosition.SelectedIndex = -1;
                }


                textBoxPCardCode.Text = row.Cells[11].Value?.ToString();
                richTextBoxCarIssueDesc.Text = row.Cells[12].Value?.ToString();

                // Chọn dịch vụ theo serviceId
                int serviceId = Convert.ToInt32(row.Cells[9].Value);
                switch (serviceId)
                {
                    case 1:
                        radioButtonParkingService.Checked = true;
                        break;
                    case 2:
                        radioButtonWashingService.Checked = true;
                        break;
                    case 3:
                        radioButtonFixingService.Checked = true;
                        break;
                    case 4:
                        radioButton_Other.Checked = true;
                        break;
                    default:
                        radioButtonParkingService.Checked = false;
                        radioButtonWashingService.Checked = false;
                        radioButtonFixingService.Checked = false;
                        break;
                }
                string parkingType = row.Cells[13].Value?.ToString().Trim();
                if (parkingType == "Hour")
                {
                    radioButtonHour.Checked = true;
                }
                else if (parkingType == "Day")
                {
                    radioButtonDay.Checked = true;
                }
                else if (parkingType == "Month")
                {
                    radioButtonMonth.Checked = true;
                }
                else if (parkingType == "Week")
                {
                    radioButtonWeek.Checked = true;
                }
                else
                {
                    radioButtonHour.Checked = false;
                    radioButtonDay.Checked = false;
                    radioButtonMonth.Checked = false;
                    radioButtonWeek.Checked = false;
                }

                if (radioButtonParkingService.Checked)
                {
                    radioButtonParkingService.Enabled = true;
                    radioButtonWashingService.Enabled = false;
                    radioButtonFixingService.Enabled = false;
                    radioButton_Other.Enabled = false;
                }
                else if (radioButtonWashingService.Checked)
                {
                    radioButtonWashingService.Enabled = true;
                    radioButtonParkingService.Enabled = false;
                    radioButtonFixingService.Enabled = false;
                    radioButton_Other.Enabled = false;
                }
                else if (radioButtonFixingService.Checked)
                {
                    radioButtonFixingService.Enabled = true;
                    radioButtonParkingService.Enabled = false;
                    radioButtonWashingService.Enabled = false;
                    radioButton_Other.Enabled = false;
                }
                else if (radioButton_Other.Checked)
                {
                    radioButton_Other.Enabled = true;
                    radioButtonParkingService.Enabled = false;
                    radioButtonWashingService.Enabled = false;
                    radioButtonFixingService.Enabled = false;
                }

                //radioButtonParkingService.Enabled = false;
                //radioButtonWashingService.Enabled = false;
                //radioButtonFixingService.Enabled = false;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            int vehicleId = Convert.ToInt32(textBoxVehicleID.Text);
            string licensePlate = textBoxLicensePlate.Text;
            string model = textBoxCarBrand.Text;
            DateTime timeIn = dateTimePicker1.Value;
            int vehicleTypeId = Convert.ToInt32(comboBoxChooseCarType.SelectedValue);
            int serviceId = radioButtonParkingService.Checked ? 1 :
                            radioButtonWashingService.Checked ? 2 :
                            radioButtonFixingService.Checked ? 3 :
                            radioButton_Other.Checked ? 4 : 0;

            int? slotId = null;
            if (radioButtonParkingService.Checked && comboBoxChooseAvailablePosition.SelectedValue != null)
                slotId = Convert.ToInt32(comboBoxChooseAvailablePosition.SelectedValue);

            string parkingCardCode = textBoxPCardCode.Text;
            string ownerName = textBoxCarOwnerName.Text;
            string ownerPhone = textBoxCarOwnerPhone.Text;
            string problemDesc = richTextBoxCarIssueDesc.Text;
            string parkingType = (radioButtonHour.Checked ? "Hour" :
                radioButtonDay.Checked ? "Day" :
                radioButtonMonth.Checked ? "Month" :
                radioButtonWeek.Checked ? "Week" : "").Trim();


            byte[] imgPlateBike = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    //pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    //imgPlateBike = ms.ToArray();

                    using (Bitmap bmp = new Bitmap(pictureBox1.Image))
                    {
                        bmp.Save(ms, ImageFormat.Jpeg); // hoặc Png, tùy bạn
                    }
                    imgPlateBike = ms.ToArray();
                }
            }

            byte[] imgOwnerCarModel = null;
            if (pictureBox2.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    //pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    //imgOwnerCarModel = ms.ToArray();

                    using (Bitmap bmp = new Bitmap(pictureBox2.Image))
                    {
                        bmp.Save(ms, ImageFormat.Jpeg); // hoặc Png, tùy bạn
                    }
                    imgOwnerCarModel = ms.ToArray();
                }
            }

            // Gọi BUS
            bool success = VehicleBUS.Instance.UpdateVehicle(
                vehicleId, licensePlate, model, timeIn, vehicleTypeId,
                imgPlateBike, imgOwnerCarModel, ownerName, ownerPhone,
                serviceId, slotId, parkingCardCode, problemDesc, parkingType
            );

            if (success)
            {
                MessageBox.Show("Cập nhật xe thành công!");
                dataGridView1.DataSource = VehicleBUS.Instance.GetAllVehicles();
            }
            else
                MessageBox.Show("Cập nhật xe thất bại!");
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VehicleBUS.Instance.GetAllVehicles();
        }

        private void bt_Cancle_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {
            textBoxVehicleID.Clear();
            textBoxLicensePlate.Clear();
            textBoxCarBrand.Clear();
            textBoxCarOwnerName.Clear();
            textBoxCarOwnerPhone.Clear();
            textBoxPCardCode.Clear();
            richTextBoxCarIssueDesc.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            comboBoxChooseAvailablePosition.SelectedIndex = -1;
            comboBoxChooseCarType.SelectedIndex = 0;

            //Phòng khi bị disable bởi datagridView Cell Click
            radioButtonParkingService.Enabled = true;
            radioButtonWashingService.Enabled = true;
            radioButtonFixingService.Enabled = true;
            radioButton_Other.Enabled = true;
        }

        private void LoadAvailableSlots(int vehicleTypeId)
        {
            var slots = SlotBUS.Instance.GetAvailableSlots(vehicleTypeId);
            comboBoxChooseAvailablePosition.DataSource = slots;
            comboBoxChooseAvailablePosition.DisplayMember = "slotNumber";
            comboBoxChooseAvailablePosition.ValueMember = "slotId";
        }


        private void comboBoxChooseCarType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseCarType.SelectedValue != null &&
            int.TryParse(comboBoxChooseCarType.SelectedValue.ToString(), out int vehicleTypeId))
            {
                LoadAvailableSlots(vehicleTypeId);
            }
        }

        private void bt_RemoveVehicle_Click(object sender, EventArgs e)
        {
            string ownerName = textBoxCarOwnerName.Text.Trim();
            if (!VerifyFace(ownerName))
            {
                MessageBox.Show("Xác thực khuôn mặt thất bại. Bạn không phải chủ xe!", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int vehicleId = Convert.ToInt32(textBoxVehicleID.Text.Trim());
            int serviceId = radioButtonParkingService.Checked ? 1 :
                            radioButtonWashingService.Checked ? 2 :
                            radioButtonFixingService.Checked ? 3 :
                            radioButton_Other.Checked ? 4 : 0;
            string parkingType = (radioButtonHour.Checked ? "Hour" :
                radioButtonDay.Checked ? "Day" :
                radioButtonMonth.Checked ? "Month" :
                radioButtonWeek.Checked ? "Week" : "").Trim();
            DateTime time_in = dateTimePicker1.Value;


            if (serviceId == 1)
            {
                BillForm billForm = new BillForm(vehicleId, serviceId, parkingType, time_in);
                billForm.ShowDialog();
            }
            if (serviceId == 2 || serviceId == 3)
            {
                BillForm billForm = new BillForm(vehicleId, serviceId);
                billForm.ShowDialog();
            }
            if (serviceId == 4)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["customerId"].Value);
                    if (customerId != 0)
                    {
                        MessageBox.Show("Chỉ có thể xóa xe này thông qua hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (customerId == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?",
                                                              "Xác nhận",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Xóa xe
                            VehicleBUS.Instance.DeleteVehicle(vehicleId);
                            dataGridView1.DataSource = VehicleBUS.Instance.GetAllVehicles();
                        }
                    }

                }

            }
        }


    }
}
