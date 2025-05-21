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

namespace Demo_3_Layer_Model
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxVertifyEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxVertifyEmail.Text == "Your Email")
            {
                textBoxVertifyEmail.Text = string.Empty;
                textBoxVertifyEmail.ForeColor = Color.Black;
                textBoxVertifyEmail.Font = new Font(textBoxVertifyEmail.Font.FontFamily, 10);

            }
        }

        private void textBoxVertifyEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxVertifyEmail.Text == string.Empty)
            {
                textBoxVertifyEmail.ForeColor = Color.DarkGray;
                textBoxVertifyEmail.Font = new Font(textBoxVertifyEmail.Font.FontFamily, 18);
                textBoxVertifyEmail.Text = "Your Email";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.Text = string.Empty;
                textBoxPassword.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.ForeColor = Color.DarkGray;
                textBoxPassword.Text = "Password";
            }
        }

        private void textBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == "Confirm Password")
            {
                textBoxConfirmPassword.PasswordChar = '*';
                textBoxConfirmPassword.Text = string.Empty;
                textBoxConfirmPassword.ForeColor = Color.Black;

            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == string.Empty)
            {
                textBoxConfirmPassword.PasswordChar = '\0';
                textBoxConfirmPassword.ForeColor = Color.DarkGray;
                textBoxConfirmPassword.Text = "Confirm Password";
            }
        }

        private void textBoxOTP_Enter(object sender, EventArgs e)
        {
            if (textBoxOTP.Text == "Enter OTP")
            {
                textBoxOTP.Text = string.Empty;
                textBoxOTP.ForeColor = Color.Black;

            }
        }

        private void textBoxOTP_Leave(object sender, EventArgs e)
        {
            if (textBoxOTP.Text == string.Empty)
            {
                textBoxOTP.ForeColor = Color.DarkGray;
                textBoxOTP.Text = "Enter OTP";
            }
        }

        private void bt_ResetPassword_Click(object sender, EventArgs e)
        {
            string email = textBoxVertifyEmail.Text.Trim();
            string newPassword = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();

            string message;
            bool success = AccountBUS.Instance.ResetPasswordByEmail(email, newPassword, confirmPassword, out message);

            if (success)
            {
                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_SendOTP_Click(object sender, EventArgs e)
        {
            string email = textBoxVertifyEmail.Text.Trim();

            string message;
            bool success = AccountBUS.Instance.SendOTPToEmail(email, out message);

            if (success)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
