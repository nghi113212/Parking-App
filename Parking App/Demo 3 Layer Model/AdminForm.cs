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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Demo_3_Layer_Model
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccountBUS.Instance.GetAllPendingAccount();
            dataGridView2.DataSource = AccountBUS.Instance.GetAllAccount();
        }

        private void bt_Accept_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            bool success = AccountBUS.Instance.ActivateAccount(username);
            if (success)
            { 
                MessageBox.Show("Tài khoản đã được kích hoạt!");
                dataGridView1.DataSource = AccountBUS.Instance.GetAllPendingAccount();
            }
            else
                MessageBox.Show("Kích hoạt thất bại!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Giả sử các cột có tên: username, password, email
                textBoxUsername.Text = row.Cells["username"].Value?.ToString();
                textBoxPassword.Text = row.Cells["password"].Value?.ToString();
                textBoxEmail.Text = row.Cells["vertify_email"].Value?.ToString();
                if(Convert.ToInt32(row.Cells["roleId"].Value) == 1 )
                {
                    radioButtonAdmin.Checked = true;
                }
                else
                {
                    radioButtonManager.Checked = true;
                }
            }
        }

        private void bt_Decline_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            if (AccountBUS.Instance.DeclineAccount(username))
            {
                MessageBox.Show("Account has been declined and deleted.");
                dataGridView1.DataSource = AccountBUS.Instance.GetAllPendingAccount();
            }
            else
            {
                MessageBox.Show("Failed to delete account.");
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow row = dataGridView2.SelectedRows[0];

                    // Lấy ID từ cột vehicleId (giả sử cột đầu tiên là ID)
                    string username = (row.Cells["username"].Value.ToString());

                    // Gọi BUS để xóa
                    bool success = AccountBUS.Instance.DeclineAccount(username);

                    if (success)
                    {
                        MessageBox.Show("Xóa thành công.");
                        dataGridView2.DataSource = AccountBUS.Instance.GetAllAccount();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }
    }
}
