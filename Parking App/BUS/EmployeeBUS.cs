using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;  

namespace BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;
        public static EmployeeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeBUS();
                return instance;
            }
        }

        public bool AddEmployee(int employeeId, string name, string role, string phone,
                        string email, string address, string identityNumber, string username, string password)
        {
            // Kiểm tra cơ bản
            if (string.IsNullOrWhiteSpace(name) || employeeId <= 0)
                return false;

            // Tạo đối tượng DTO
            Employee emp = new Employee
            {
                EmployeeId = employeeId,
                Name = name,
                Role = role,
                Phone = phone,
                Email = email,
                Address = address,
                IdentityNumber = identityNumber,
                Username = username,
                Password = password
            };

            // Gửi xuống DAO
            return EmployeeDAO.Instance.AddEmployee(emp);
        }


        public bool UpdateEmployee(int employeeId, string name, string role, string phone, string email,
                           string address, string identityNumber, string username, string password)
        {
            Employee emp = new Employee
            {
                EmployeeId = employeeId,
                Name = name,
                Role = role,
                Phone = phone,
                Email = email,
                Address = address,
                IdentityNumber = identityNumber,
                Username = username,
                Password = password
            };

            return EmployeeDAO.Instance.UpdateEmployee(emp);
        }

        public bool DeleteEmployee(int employeeId)
        {
            return EmployeeDAO.Instance.DeleteEmployee(employeeId);
        }

        public DataTable GetAllEmployees()
        {
            return EmployeeDAO.Instance.GetAllEmployees();
        }

        public DataTable GetBasicEmployeeInfo()
        {
            return EmployeeDAO.Instance.GetBasicEmployeeInfo();
        }

        public string GetRoleById(int employeeId)
        {
            return EmployeeDAO.Instance.GetRoleById(employeeId);
        }

        public int GetEmployeeCount()
        {
            return EmployeeDAO.Instance.CountEmployees();
        }

        public DataRow GetEmployeeAccountByUsername(string username)
        {
            return EmployeeDAO.Instance.GetEmployeeAccountByUsername(username);
        }
    }
}
