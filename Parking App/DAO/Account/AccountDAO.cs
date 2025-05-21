using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) 
                    instance = new AccountDAO();
                return instance;
            }
        }

        private AccountDAO() { }

        //public LoginResult Login(string username, string password, string requiredRole)
        //{
        //    //string query = "SELECT a.status, r.roleId FROM Account a JOIN Role r ON a.roleId = r.roleId " +
        //    //               "WHERE a.username = @username";

        //    //DataTable result = new DataProvider().ExecuteQuery(query, new object[] { username, password }); // trc có "password" trg exeQuery nữa 

        //    //if (result.Rows.Count == 0)
        //    //{
        //    //    return LoginResult.WrongCredentials; // Không tìm thấy tài khoản
        //    //}

        //    //DataRow row = result.Rows[0];
        //    //bool isActive = Convert.ToBoolean(row["status"]);

        //    //if (!isActive)
        //    //{
        //    //    return LoginResult.NotActivated; // Tài khoản chưa được kích hoạt
        //    //}

        //    //string role = row["roleId"].ToString();
        //    //if (role != requiredRole)
        //    //{
        //    //    return LoginResult.WrongRole; // Chọn sai vai trò
        //    //}

        //    //return LoginResult.Success; // Đăng nhập thành công
        //}

        public DataRow GetAccountByUsername(string username)
        {
            string query = "SELECT a.password, a.status, r.roleId " +
                           "FROM Account a JOIN Role r ON a.roleId = r.roleId " +
                           "WHERE a.username = @username";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }

        public void InsertAccount(string username, string hashedPassword, string email)
        {
            string query = "INSERT INTO Account ( username, password, vertify_email, roleId, status) VALUES ( @username , @password , @email , @role , 0)";

            //object[] parameters = new object[]
            //{
            //    username,
            //    hashedPassword,
            //    email,
            //    "3",   
            //    0      
            //};

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", hashedPassword),
                new SqlParameter("@email", email),
                new SqlParameter("@role", "2")
            };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }


        public bool IsUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE username = @username";
            object[] parameters = new object[] { username };
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            return count > 0; // Nếu số lượng > 0 thì username đã tồn tại
        }

        public bool IsEmailExist(string email)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE vertify_email = @Email";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { email });
            return Convert.ToInt32(result) > 0;
        }

        public bool UpdatePasswordByEmail(string email, string hashedPassword)
        {
            string query = "UPDATE Account SET password = @Password WHERE vertify_email = @Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Password", hashedPassword),
                new SqlParameter("@Email", email)
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public DataTable GetAllPendingAccount()
        {
            string query = "SELECT * FROM Account WHERE status = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllAccount()
        {
            string query = "SELECT * FROM Account";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool SetAccountStatusTrue(string username)
        {
            string query = "UPDATE Account SET status = 1 WHERE username = @username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", SqlDbType.VarChar) { Value = username }
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool DeleteAccount(string username)
        {
            string query = "DELETE FROM Account WHERE username = @username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", SqlDbType.VarChar) { Value = username }
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
