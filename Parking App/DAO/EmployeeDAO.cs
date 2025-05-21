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
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
        }

        public bool AddEmployee(Employee emp)
        {
            string query = "INSERT INTO Employee (employeeId, name, role, phone, email, address, identityNumber, salary, username, password) " +
                           "VALUES (@id, @name, @role, @phone, @email, @address, @identityNumber, @salary, @username, @password)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", emp.EmployeeId),
                new SqlParameter("@name", emp.Name),
                new SqlParameter("@role", emp.Role),
                new SqlParameter("@phone", emp.Phone),
                new SqlParameter("@email", emp.Email),
                new SqlParameter("@address", emp.Address),
                new SqlParameter("@identityNumber", emp.IdentityNumber),
                new SqlParameter("@salary", emp.Salary),
                new SqlParameter("@username", emp.Username),
                new SqlParameter("@password", emp.Password),
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateEmployee(Employee emp)
        {
            string query = @"UPDATE Employee SET 
                        name = @name,
                        role = @role,
                        phone = @phone,
                        email = @email,
                        address = @address,
                        identityNumber = @identityNumber,
                        salary = @salary,
                        username = @username,
                        password = @password
                     WHERE employeeId = @employeeId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", emp.Name),
                new SqlParameter("@role", emp.Role),
                new SqlParameter("@phone", emp.Phone),
                new SqlParameter("@email", emp.Email),
                new SqlParameter("@address", emp.Address),
                new SqlParameter("@identityNumber", emp.IdentityNumber),
                new SqlParameter("@salary", emp.Salary),
                new SqlParameter("@username", emp.Username),
                new SqlParameter("@password", emp.Password),
                new SqlParameter("@employeeId", emp.EmployeeId),
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employee WHERE employeeId = @employeeId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@employeeId", employeeId)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllEmployees()
        {
            string query = "SELECT * FROM Employee";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetBasicEmployeeInfo()
        {
            string query = "SELECT employeeId, name, role FROM Employee";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string GetRoleById(int employeeId)
        {
            string query = "SELECT role FROM Employee WHERE employeeId = @id";
            object[] parameters = { employeeId };
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return result?.ToString();
        }

        public int CountEmployees()
        {
            string query = "SELECT COUNT(*) FROM Employee";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataRow GetEmployeeAccountByUsername(string username)
        {
            string query = "SELECT password, role FROM Employee WHERE username = @username ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
    }
}
