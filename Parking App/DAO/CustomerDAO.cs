using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
        }

        private CustomerDAO() { }

        public bool InsertCustomer(Customer customer)
        {
            //string query = @"INSERT INTO Customer (fullName, phoneNumber, email, address, identityCard, dateOfBirth, gender)
            //         VALUES (@fullName, @phoneNumber, @email, @address, @identityCard, @dateOfBirth, @gender)";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@fullName", customer.fullName),
            //    new SqlParameter("@phoneNumber", customer.phoneNumber),
            //    new SqlParameter("@email", customer.email),
            //    new SqlParameter("@address", customer.address),
            //    new SqlParameter("@identityCard", customer.identityCard),
            //    new SqlParameter("@dateOfBirth", customer.dateOfBirth),
            //    new SqlParameter("@gender", customer.gender)
            //};

            //return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;

            string query = @"
                INSERT INTO Customer 
                    (customerId, fullName, phoneNumber, email, address, identityCard, dateOfBirth, gender)
                VALUES
                    (@id, @fullName, @phoneNumber, @email, @address, @identityCard, @dateOfBirth, @gender)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", customer.customerId),
                new SqlParameter("@fullName", customer.fullName),
                new SqlParameter("@phoneNumber", customer.phoneNumber),
                new SqlParameter("@email", customer.email),
                new SqlParameter("@address", customer.address),
                new SqlParameter("@identityCard", customer.identityCard),
                new SqlParameter("@dateOfBirth", customer.dateOfBirth),
                new SqlParameter("@gender", customer.gender)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateCustomer(Customer customer)
        {
            string query = @"UPDATE Customer 
                     SET fullName = @fullName, phoneNumber = @phoneNumber, email = @email, 
                         address = @address, identityCard = @identityCard, 
                         dateOfBirth = @dateOfBirth, gender = @gender
                     WHERE customerId = @customerId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@fullName", customer.fullName),
                new SqlParameter("@phoneNumber", customer.phoneNumber),
                new SqlParameter("@email", customer.email),
                new SqlParameter("@address", customer.address),
                new SqlParameter("@identityCard", customer.identityCard),
                new SqlParameter("@dateOfBirth", customer.dateOfBirth),
                new SqlParameter("@gender", customer.gender),
                new SqlParameter("@customerId", customer.customerId)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteCustomer(int customerId)
        {
            string query = "DELETE FROM Customer WHERE customerId = @customerId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerId", customerId)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllCustomers()
        {
            string query = "SELECT * FROM Customer";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ExistsCustomerId(int customerId)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE customerId = @id";
            object[] parameters = { customerId };
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            return false;
        }

        public DataTable GetCustomerById(int customerId)
        {
            string query = "SELECT * FROM Customer WHERE customerId = @customerId";
            object[] parameters = new object[] { customerId };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public int CountCustomers()
        {
            string query = "SELECT COUNT(*) FROM Customer";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }
    }
}
