using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Demo_3_Layer_Model
{
    public partial class ManageStaffForm : Form
    {
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.Add("Kỹ thuật viên");
            comboBoxRole.Items.Add("Tiếp tân");
            comboBoxRole.SelectedIndex = 0;

            dataGridView1.DataSource = EmployeeBUS.Instance.GetAllEmployees();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = int.Parse(textBoxEmployeeID.Text.Trim());
                string name = textBoxFullName.Text.Trim();
                string role = comboBoxRole.SelectedItem.ToString();
                string phone = textBoxPhoneNumber.Text.Trim();
                string email = textBoxEmail.Text.Trim();
                string address = textBoxAddress.Text.Trim();
                string identityNumber = textBoxIdentityNumber.Text.Trim();
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                bool result = EmployeeBUS.Instance.AddEmployee(employeeId, name, role, phone,
                                                               email, address, identityNumber,
                                                               username, password);

                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = EmployeeBUS.Instance.GetAllEmployees();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại. Kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Kiểm tra lại các trường số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(textBoxEmployeeID.Text.Trim());
            string name = textBoxFullName.Text.Trim();
            string role = comboBoxRole.SelectedItem.ToString();
            string phone = textBoxPhoneNumber.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string identityNumber = textBoxIdentityNumber.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            bool result = EmployeeBUS.Instance.UpdateEmployee(employeeId, name, role, phone, email, address, identityNumber, username, password);

            if (result)
            {
                MessageBox.Show("Cập nhật nhân viên thành công!");
                dataGridView1.DataSource = EmployeeBUS.Instance.GetAllEmployees();
            }
            else
                MessageBox.Show("Cập nhật thất bại.");
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmployeeID.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã nhân viên cần xóa.");
                return;
            }

            int employeeId = int.Parse(textBoxEmployeeID.Text.Trim());

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool success = EmployeeBUS.Instance.DeleteEmployee(employeeId);

                if (success)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    dataGridView1.DataSource = EmployeeBUS.Instance.GetAllEmployees();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Điền dữ liệu vào các trường thông tin
                textBoxEmployeeID.Text = row.Cells["employeeId"].Value.ToString();
                textBoxFullName.Text = row.Cells["name"].Value.ToString();
                comboBoxRole.SelectedItem = row.Cells["role"].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells["phone"].Value.ToString();
                textBoxEmail.Text = row.Cells["email"].Value.ToString();
                textBoxAddress.Text = row.Cells["address"].Value.ToString();
                textBoxIdentityNumber.Text = row.Cells["identityNumber"].Value.ToString();
                textBoxUsername.Text = row.Cells["username"].Value.ToString();
                textBoxPassword.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            textBoxEmployeeID.Clear();
            textBoxFullName.Clear();
            comboBoxRole.SelectedIndex = -1; // Bỏ chọn vai trò
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();
            textBoxIdentityNumber.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBUS.Instance.GetAllEmployees();
        }
    }
}
