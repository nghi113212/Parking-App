using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BUS
{
    public enum LoginResult
    {
        Success,
        WrongCredentials,
        NotActivated,
        WrongRole
    }
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        private AccountBUS() { }

        //public LoginResult Login(string username, string password, string requiredRole)
        //{

        //    if (requiredRole == "1" || requiredRole == "2") //Admin or Manager
        //    {
        //        DataRow row = AccountDAO.Instance.GetAccountByUsername(username);

        //        if (row == null)
        //            return LoginResult.WrongCredentials;

        //        string hashedPassword = row["password"].ToString();
        //        if (!BCrypt.Net.BCrypt.Verify(password, hashedPassword))
        //            return LoginResult.WrongCredentials;

        //        bool isActive = Convert.ToBoolean(row["status"]);
        //        if (!isActive)
        //            return LoginResult.NotActivated;

        //        string role = row["roleId"].ToString();
        //        if (role != requiredRole)
        //            return LoginResult.WrongRole;

        //        return LoginResult.Success;
        //    }
        //    else if (requiredRole == "3") //Staff
        //    {
        //        DataRow row = EmployeeBUS.Instance.GetEmployeeAccountByUsername(username);

        //        if (row == null)
        //            return LoginResult.WrongCredentials;

        //        string rawPassword = row["password"].ToString();
        //        if (password != rawPassword)
        //            return LoginResult.WrongCredentials;

        //        string role = row["role"].ToString();
        //        if (role != "Kỹ thuật viên" && role != "Trông xe")
        //            return LoginResult.WrongRole;

        //        // Đăng nhập thành công với Staff
        //        // Lưu dbRole lại để mở đúng form


        //        return LoginResult.Success;

        //    }

        //    return LoginResult.WrongCredentials;
        //}

        public LoginResponse Login(string username, string password, string requiredRole)
        {
            var response = new LoginResponse();

            if (requiredRole == "1" || requiredRole == "2") // Admin or Manager
            {
                DataRow row = AccountDAO.Instance.GetAccountByUsername(username);

                if (row == null)
                {
                    response.Result = LoginResult.WrongCredentials;
                    return response;
                }

                string hashedPassword = row["password"].ToString();
                if (!BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                {
                    response.Result = LoginResult.WrongCredentials;
                    return response;
                }

                bool isActive = Convert.ToBoolean(row["status"]);
                if (!isActive)
                {
                    response.Result = LoginResult.NotActivated;
                    return response;
                }

                string role = row["roleId"].ToString();
                if (role != requiredRole)
                {
                    response.Result = LoginResult.WrongRole;
                    return response;
                }

                response.Result = LoginResult.Success;
                response.Role = role;
                response.Username = username;
                return response;
            }
            else if (requiredRole == "3") // Staff
            {
                DataRow row = EmployeeBUS.Instance.GetEmployeeAccountByUsername(username);

                if (row == null)
                {
                    response.Result = LoginResult.WrongCredentials;
                    return response;
                }

                string rawPassword = row["password"].ToString();
                if (password != rawPassword)
                {
                    response.Result = LoginResult.WrongCredentials;
                    return response;
                }

                string dbRole = row["role"].ToString();
                if (dbRole != "Kỹ thuật viên" && dbRole != "Trông xe" && dbRole != "Tiếp tân")
                {
                    response.Result = LoginResult.WrongRole;
                    return response;
                }

                response.Result = LoginResult.Success;
                response.Role = dbRole; // Lưu lại để form mở đúng
                response.Username = username;
                return response;
            }

            response.Result = LoginResult.WrongCredentials;
            return response;
        }


        public bool InsertAccount(string username, string password, string email)
        {
            if (AccountDAO.Instance.IsUsernameExist(username))
            {
                MessageBox.Show("Username đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string hashedPassword = PasswordHelper.HashPassword(password);
            AccountDAO.Instance.InsertAccount(username, hashedPassword, email);
            return true;
        }

        public bool IsValidInput(string username, string password, string confirmPassword, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; 
            }
            catch
            {
                return false;
            }
        }

        public bool ResetPasswordByEmail(string email, string newPassword, string confirmPassword, out string message)
        {
            message = "";

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                message = "Vui lòng nhập đầy đủ thông tin.";
                return false;
            }

            if (newPassword != confirmPassword)
            {
                message = "Mật khẩu xác nhận không khớp.";
                return false;
            }

            if (!AccountDAO.Instance.IsEmailExist(email))
            {
                message = "Email không tồn tại.";
                return false;
            }

            string hashedPassword = PasswordHelper.HashPassword(newPassword);
            AccountDAO.Instance.UpdatePasswordByEmail(email, hashedPassword);

            message = "Mật khẩu đã được cập nhật thành công!";
            return true;
        }

        private Dictionary<string, string> otpStore = new Dictionary<string, string>(); // key: email, value: otp

        public bool SendOTPToEmail(string email, out string message)
        {
            message = "";

            if (string.IsNullOrEmpty(email))
            {
                message = "Vui lòng nhập email.";
                return false;
            }

            if (!AccountDAO.Instance.IsEmailExist(email))
            {
                message = "Email không tồn tại trong hệ thống.";
                return false;
            }

            // Tạo OTP
            string otp = new Random().Next(100000, 999999).ToString();

            // Lưu tạm OTP vào dictionary
            otpStore[email] = otp;

            // Gửi email
            bool sent = EmailHelper.SendEmail(email, "Mã OTP đặt lại mật khẩu", $"Mã OTP của bạn là: {otp}");

            if (!sent)
            {
                message = "Gửi email thất bại.";
                return false;
            }

            message = "Mã OTP đã được gửi tới email của bạn.";
            return true;
        }

        public DataTable GetAllPendingAccount() 
        { 
            return AccountDAO.Instance.GetAllPendingAccount();
        }

        public DataTable GetAllAccount()
        {
            return AccountDAO.Instance.GetAllAccount();
        }

        public bool ActivateAccount(string username)
        {
            return AccountDAO.Instance.SetAccountStatusTrue(username);
        }

        public bool DeclineAccount(string username)
        {
            return AccountDAO.Instance.DeleteAccount(username);
        }
    }
}
