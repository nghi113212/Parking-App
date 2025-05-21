using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return instance;
            }
        }

        private CustomerBUS() { }

        public DataTable GetAllCustomers()
        {
            return CustomerDAO.Instance.GetAllCustomers();
        }

        public bool AddCustomer(int customerId, string fullName, string phoneNumber, string email, string address, string identityCard, DateTime dateOfBirth, string gender)
        {
            // 0. Kiểm tra ID đã tồn tại
            if (CustomerDAO.Instance.ExistsCustomerId(customerId))
            {
                MessageBox.Show("Customer ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 1. Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(identityCard) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            Customer customer = new Customer
            {
                customerId = customerId,
                fullName = fullName,
                phoneNumber = phoneNumber,
                email = email,
                address = address,
                identityCard = identityCard,
                dateOfBirth = dateOfBirth,
                gender = gender
            };

            return CustomerDAO.Instance.InsertCustomer(customer);
        }

        public bool UpdateCustomer(int customerId, string fullName, string phoneNumber, string email, string address, string identityCard, DateTime dateOfBirth, string gender)
        {
            Customer customer = new Customer
            {
                customerId = customerId,
                fullName= fullName,
                phoneNumber = phoneNumber,
                email = email,
                address = address,
                identityCard = identityCard,
                dateOfBirth = dateOfBirth,
                gender = gender
            };

            return CustomerDAO.Instance.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return CustomerDAO.Instance.DeleteCustomer(id);
        }

        public bool ExistsCustomerId(int customerId)
        {
            return CustomerDAO.Instance.ExistsCustomerId(customerId);
        }

        public DataTable GetCustomerById(int customerId)
        {
            return CustomerDAO.Instance.GetCustomerById(customerId);
        }

        public int GetCustomerCount()
        {
            return CustomerDAO.Instance.CountCustomers();
        }
    }
}
