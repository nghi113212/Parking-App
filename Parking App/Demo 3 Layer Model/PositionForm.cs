using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Demo_3_Layer_Model
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SlotBUS.Instance.GetAllSlots();

            comboBoxPositionFor.DataSource = VehicleTypeBUS.Instance.GetAllVehicleTypes();
            comboBoxPositionFor.DisplayMember = "vehicle_typeName";
            comboBoxPositionFor.ValueMember = "vehicle_typeId";
            // Đặt lại tên cột cho nhìn thân thiện hơn
            dataGridView1.Columns["slotId"].HeaderText = "Mã vị trí";
            dataGridView1.Columns["slotNumber"].HeaderText = "Tên vị trí";
            dataGridView1.Columns["vehicle_typeId"].HeaderText = "Mã loại xe";
            dataGridView1.Columns["is_occpied"].HeaderText = "Đang sử dụng";

            dataGridView2.DataSource = VehicleTypeBUS.Instance.GetAllVehicleTypeAndPrice();
            // Đặt lại tên cột cho nhìn thân thiện hơn 
            dataGridView2.Columns["vehicle_typeId"].HeaderText = "Mã loại xe";
            dataGridView2.Columns["vehicle_typeName"].HeaderText = "Tên loại xe";
            dataGridView2.Columns["parking_fee"].HeaderText = "Giá gửi xe (VND)";
        }

        private void bt_AddPosition_Click(object sender, EventArgs e)
        {
            int slotId = Convert.ToInt32(textBoxPositionID.Text);
            string slotNumber = textBoxPositionNumber.Text.Trim();
            int vehicle_typeId = Convert.ToInt32(comboBoxPositionFor.SelectedValue);

            bool success = SlotBUS.Instance.InsertSlot(slotId, slotNumber, vehicle_typeId);
            if (success) 
            {
                MessageBox.Show("Thêm vị trí thành công!");
                dataGridView1.DataSource = SlotBUS.Instance.GetAllSlots();
            }
            else
            {
                MessageBox.Show("Thêm vị trí thất bại!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPositionID.Enabled = false; // Disable editing of ID field
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán dữ liệu lên TextBox
                textBoxPositionID.Text = row.Cells["slotId"].Value.ToString();
                textBoxPositionNumber.Text = row.Cells["slotNumber"].Value.ToString().Trim();

                // Gán dữ liệu lên ComboBox
                comboBoxPositionFor.SelectedValue = Convert.ToInt32(row.Cells["vehicle_typeId"].Value);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string slotName = dataGridView1.Rows[e.RowIndex].Cells["slotNumber"].Value.ToString();
                int slotId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["slotId"].Value);
                var vehicleInfo = VehicleBUS.Instance.GetVehicleInfoBySlotId(slotId);


                if (vehicleInfo != null)
                {
                    var infoForm = new VehicleInfoForm(
                        slotName,
                        vehicleId: (int)vehicleInfo[0],
                        licensePlate: (string)vehicleInfo[1],
                        model: (string)vehicleInfo[2],
                        timeIn: (DateTime)vehicleInfo[3],
                        vehicle_typeId: (int)vehicleInfo[4],
                        imgPlateBike: (byte[])vehicleInfo[5],
                        imgOwnerCarModel: (byte[])vehicleInfo[6]
                    );
                    infoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có xe ở vị trí này!");
                }
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            textBoxPositionID.Clear();
            textBoxPositionNumber.Clear();
            textBoxPositionID.Enabled = true; // Enable editing of ID field
        }

        private void bt_SavePosition_Click(object sender, EventArgs e)
        {
            int slotId = Convert.ToInt32(textBoxPositionID.Text);
            string slotNumber = textBoxPositionNumber.Text;
            int vehicle_typeId = Convert.ToInt32(comboBoxPositionFor.SelectedValue);

            var vehicleInfo = VehicleBUS.Instance.GetVehicleInfoBySlotId(slotId);
            if (vehicleInfo != null)
            {
                MessageBox.Show("Không thể sủa vị trí này vì đang có xe.");
                return;
            }

            bool result = SlotBUS.Instance.UpdateSlot(slotId, slotNumber, vehicle_typeId);

            if (result)
            {
                MessageBox.Show("Cập nhật vị trí thành công!");
                dataGridView1.DataSource = SlotBUS.Instance.GetAllSlots();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private void bt_RemovePosition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPositionID.Text))
            {
                MessageBox.Show("Vui lòng chọn một vị trí để xóa.");
                return;
            }

            int selectedSlotId = Convert.ToInt32(textBoxPositionID.Text);

            var vehicleInfo = VehicleBUS.Instance.GetVehicleInfoBySlotId(selectedSlotId);
            if (vehicleInfo != null)
            {
                MessageBox.Show("Không thể xóa vị trí này vì đang có xe.");
                return;
            }

            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa vị trí này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialog == DialogResult.Yes)
            {
                bool result = SlotBUS.Instance.DeleteSlot(selectedSlotId);

                if (result)
                {
                    MessageBox.Show("Xóa vị trí thành công!");
                    dataGridView1.DataSource = SlotBUS.Instance.GetAllSlots();
                    textBoxPositionID.Clear();
                    textBoxPositionNumber.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa vị trí thất bại.");
                }
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý khi click vào một dòng (không phải header)
            if (e.RowIndex >= 0)
            {
                var row = dataGridView2.Rows[e.RowIndex];

                // Lấy giá trị cột vehicle_typeId và parking_fee
                textBoxId.Text = row.Cells["vehicle_typeId"].Value?.ToString() ?? "";
                textBoxPrice.Text = row.Cells["parking_fee"].Value?.ToString() ?? "";
            }
        }

        private void bt_ApplyNewPrice_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ TextBox
            if (!int.TryParse(textBoxId.Text, out int typeId))
            {
                MessageBox.Show("Mã loại xe không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxPrice.Text, out int newPrice)) // Dùng int thay vì decimal
            {
                MessageBox.Show("Giá gửi xe phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Gọi BUS để cập nhật
            bool success = VehicleTypeBUS.Instance.UpdateVehicleTypePrice(typeId, newPrice);

            // 3. Thông báo và reload dữ liệu
            if (success)
            {
                MessageBox.Show("Cập nhật giá gửi xe thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload lại DataGridView
                dataGridView2.DataSource = VehicleTypeBUS.Instance.GetAllVehicleTypeAndPrice();

                // (Tùy chọn) Đặt lại tên cột nếu bạn đã customize HeaderText trước đó
                dataGridView2.Columns["vehicle_typeId"].HeaderText = "Mã loại xe";
                dataGridView2.Columns["vehicle_typeName"].HeaderText = "Tên loại xe";
                dataGridView2.Columns["parking_fee"].HeaderText = "Giá gửi xe (VND)";

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
