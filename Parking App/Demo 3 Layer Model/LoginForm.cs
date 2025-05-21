using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;

namespace Demo_3_Layer_Model
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBoxUsername_GotFocus(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }


        //private void bt_Login_Click(object sender, EventArgs e)
        //{
        //    string username = textBoxUsername.Text;
        //    string password = textBoxPassword.Text;
        //    string requiredRole = comboBoxChooseRole.SelectedValue.ToString();

        //    if (AccountBUS.Instance.Login(username, password, requiredRole))
        //    {
        //        this.DialogResult = DialogResult.OK;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public event EventHandler LoginSuccessful;
        //public event Action<string, string> LoginSuccessful;
        public delegate void LoginSuccessHandler(string username, string role);
        public event LoginSuccessHandler LoginSuccessful;

        private void bt_Login_Click(object sender, EventArgs e)
        {
            //string username = textBoxUsername.Text;
            //string password = textBoxPassword.Text;
            //string requiredRole = comboBoxChooseRole.SelectedValue.ToString();

            //LoginResult result = AccountBUS.Instance.Login(username, password, requiredRole);

            //switch (result)
            //{
            //    case LoginResult.Success:
            //        //this.DialogResult = DialogResult.OK;
            //        //LoginSuccessful?.Invoke(this, EventArgs.Empty);
            //        LoginSuccessful?.Invoke(username, requiredRole);
            //        break;

            //    case LoginResult.WrongCredentials:
            //        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;

            //    case LoginResult.NotActivated:
            //        MessageBox.Show("Tài khoản chưa được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        break;

            //    case LoginResult.WrongRole:
            //        MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //}

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string requiredRole = comboBoxChooseRole.SelectedValue.ToString();

            LoginResponse response = AccountBUS.Instance.Login(username, password, requiredRole);

            switch (response.Result)
            {
                case LoginResult.Success:
                    LoginSuccessful?.Invoke(response.Username, response.Role); // Truyền ra vai trò thật
                    break;

                case LoginResult.WrongCredentials:
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case LoginResult.NotActivated:
                    MessageBox.Show("Tài khoản chưa được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case LoginResult.WrongRole:
                    MessageBox.Show("Tài khoản không tồn tại hoặc không đúng vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBoxChooseRole.DataSource = RoleBUS.Instance.GetRoles();
            comboBoxChooseRole.DisplayMember = "RoleName"; // Hiển thị tên Role
            comboBoxChooseRole.ValueMember = "Id"; // Lưu ID Role
        }

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.Show();
        }
    }
}
