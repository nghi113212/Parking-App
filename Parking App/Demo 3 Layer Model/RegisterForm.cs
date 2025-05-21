using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3_Layer_Model
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_SignIn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxUsername_GotFocus(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black; // Đổi màu chữ về bình thường
            }
        }

        private void textBoxUsername_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.DarkGray; // Đặt màu placeholder
            }
        }

        private void textBoxPassword_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black; // Đổi màu chữ về bình thường
            }
        }

        private void textBoxPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.DarkGray; // Đặt màu placeholder
            }
        }

        private void textBoxConfirmPassword_GotFocus(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == "Confirm Password")
            {
                textBoxConfirmPassword.Text = "";
                textBoxConfirmPassword.PasswordChar = '*';
                textBoxConfirmPassword.ForeColor = Color.Black; // Đổi màu chữ về bình thường
            }
        }

        private void textBoxConfirmPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                textBoxConfirmPassword.PasswordChar = '\0';
                textBoxConfirmPassword.Text = "Confirm Password";
                textBoxConfirmPassword.ForeColor = Color.DarkGray; // Đặt màu placeholder
            }
        }

        private void textBox_VertifyEmail_Enter(object sender, EventArgs e)
        {
            if (textBox_VertifyEmail.Text == "Your Email")
            {
                textBox_VertifyEmail.Text = "";
                textBox_VertifyEmail.ForeColor = Color.Black; // Đổi màu chữ về bình thường
            }
        }

        private void textBox_VertifyEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_VertifyEmail.Text))
            {
                textBox_VertifyEmail.Text = "Your Email";
                textBox_VertifyEmail.ForeColor = Color.DarkGray; // Đặt màu placeholder
            }
        }

        private void bt_SignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();
            string email = textBox_VertifyEmail.Text.Trim();

            if (!AccountBUS.Instance.IsValidInput(username, password, confirmPassword, email))
            {
                return; 
            }

            try
            {
                bool isSuccess = AccountBUS.Instance.InsertAccount(username, password, email);

                if (isSuccess)
                {
                    MessageBox.Show("Tạo tài khoản thành công! Vui lòng chờ kích hoạt từ admin.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxConfirmPassword.Clear();
                    textBox_VertifyEmail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tạo tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
