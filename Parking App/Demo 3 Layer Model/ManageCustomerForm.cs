using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3_Layer_Model
{
    public partial class ManageCustomerForm : Form
    {
        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBUS.Instance.GetAllCustomers();
            dataGridView1.Columns["customerId"].HeaderText = "Mã KH";
            dataGridView1.Columns["fullName"].HeaderText = "Họ và Tên";
            dataGridView1.Columns["phoneNumber"].HeaderText = "SĐT";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["identityCard"].HeaderText = "CMND/CCCD";
            dataGridView1.Columns["dateOfBirth"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["gender"].HeaderText = "Giới tính";
        }

        private void bt_AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32((textBoxCustomerID.Text.Trim()));
                string fullName = textBoxFullName.Text.Trim();
                string phoneNumber = textBoxPhoneNumber.Text.Trim();
                string email = textBoxEmail.Text.Trim();
                string address = textBoxAddress.Text.Trim();
                string identityCard = textBoxIdentityNumber.Text.Trim();
                DateTime dateOfBirth = dateTimePicker1.Value;
                string gender = radioButtonMale.Checked ? "Nam" : (radioButtonFemale.Checked ? "Nữ" : null);


                bool result = CustomerBUS.Instance.AddCustomer(customerId ,fullName, phoneNumber, email, address, identityCard, dateOfBirth, gender);

                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    dataGridView1.DataSource = CustomerBUS.Instance.GetAllCustomers();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_EditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32(textBoxCustomerID.Text.Trim());
                string fullName = textBoxFullName.Text.Trim();
                string phoneNumber = textBoxPhoneNumber.Text.Trim();
                string email = textBoxEmail.Text.Trim();
                string address = textBoxAddress.Text.Trim();
                string identityCard = textBoxIdentityNumber.Text.Trim();
                DateTime dateOfBirth = dateTimePicker1.Value;
                string gender = radioButtonMale.Checked ? "Nam" : (radioButtonFemale.Checked ? "Nữ" : null);

                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại.");
                    return;
                }

                bool result = CustomerBUS.Instance.UpdateCustomer(customerId, fullName, phoneNumber, email, address, identityCard, dateOfBirth, gender);

                if (result)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    dataGridView1.DataSource = CustomerBUS.Instance.GetAllCustomers();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_RemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCustomerID.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xoá.");
                    return;
                }

                int customerId = Convert.ToInt32(textBoxCustomerID.Text.Trim());

                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xoá khách hàng này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    bool result = CustomerBUS.Instance.DeleteCustomer(customerId);

                    if (result)
                    {
                        MessageBox.Show("Xoá khách hàng thành công!");
                        dataGridView1.DataSource = CustomerBUS.Instance.GetAllCustomers();
                        ClearInputFields(); // Nếu bạn có hàm này để xóa nội dung trên các TextBox
                    }
                    else
                    {
                        MessageBox.Show("Xoá khách hàng thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ClearInputFields()
        {
            textBoxCustomerID.Clear();
            textBoxFullName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();
            textBoxIdentityNumber.Clear();

            dateTimePicker1.Value = DateTime.Now;

            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxCustomerID.Text = row.Cells["customerId"].Value?.ToString();
                textBoxFullName.Text = row.Cells["fullName"].Value?.ToString();
                textBoxPhoneNumber.Text = row.Cells["phoneNumber"].Value?.ToString();
                textBoxEmail.Text = row.Cells["email"].Value?.ToString();
                textBoxAddress.Text = row.Cells["address"].Value?.ToString();
                textBoxIdentityNumber.Text = row.Cells["identityCard"].Value?.ToString();

                if (row.Cells["dateOfBirth"].Value != DBNull.Value)
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells["dateOfBirth"].Value);

                string gender = row.Cells["gender"].Value?.ToString().Trim();
                if (gender == "Nam")
                    radioButtonMale.Checked = true;
                else if (gender == "Nữ")
                    radioButtonFemale.Checked = true;
                else
                {
                    radioButtonMale.Checked = false;
                    radioButtonFemale.Checked = false;
                }

                //Vo hieu hoa txtID
                textBoxCustomerID.Enabled = false;
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ClearInputFields();

            //Enable txtID
            textBoxCustomerID.Enabled = true;
        }

        private void bt_AddCarForRent_Click(object sender, EventArgs e)
        {
            //// Thu thập dữ liệu từ các TextBox
            int customerId = Convert.ToInt32(textBoxCustomerID.Text.Trim());
            string fullName = textBoxFullName.Text.Trim();
            string phoneNumber = textBoxPhoneNumber.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string identityCard = textBoxIdentityNumber.Text.Trim();
            DateTime dateOfBirth = dateTimePicker1.Value;
            string gender = radioButtonMale.Checked ? "Nam" : (radioButtonFemale.Checked ? "Nữ" : null);
            // Kiểm tra dữ liệu đầu vào nếu cần
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber)
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address)
                || string.IsNullOrEmpty(identityCard) || string.IsNullOrEmpty(gender)
                || string.IsNullOrEmpty(textBoxCustomerID.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa thêm đầy đủ thông tin khách hàng!");
                return;
            }
            else
            {
                LoadFormIntoPanel(new AddUnusedCarForm(customerId, fullName, dateOfBirth, identityCard, phoneNumber, email, address, gender));

            }
        }
        private void LoadFormIntoPanel(Form childForm)
        {
            panel1.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;

            childForm.Show();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBUS.Instance.GetAllCustomers();
        }
    }
}
