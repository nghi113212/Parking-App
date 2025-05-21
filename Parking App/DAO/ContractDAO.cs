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
    public class ContractDAO
    {
        private static ContractDAO instance;
        public static ContractDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ContractDAO();
                return instance;
            }
        }

        public bool InsertContract(Contract contract)
        {
            string query = "INSERT INTO Contract (contractType, vehicleId, customerId, startDate, endDate, price, staffId, status) " +
                           "VALUES (@contractType, @vehicleId, @customerId, @startDate, @endDate, @price, @staffId, @status)";
            SqlParameter[] parameters = {
                new SqlParameter("@contractType", contract.ContractType),
                new SqlParameter("@vehicleId", contract.VehicleId),
                new SqlParameter("@customerId", contract.CustomerId),
                new SqlParameter("@startDate", contract.StartDate),
                new SqlParameter("@endDate", contract.EndDate),
                new SqlParameter("@price", contract.Price),
                new SqlParameter("@staffId", contract.StaffId),
                new SqlParameter("@status", contract.Status)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
            
        }

        public bool UpdateContract(Contract contract)
        {
            string query = "UPDATE Contract SET contractType = @contractType, vehicleId = @vehicleId, customerId = @customerId, " +
                           "startDate = @startDate, endDate = @endDate, price = @price, staffId = @staffId, status = @status " +
                           "WHERE contractId = @contractId";

            SqlParameter[] parameters = {
                new SqlParameter("@contractType", contract.ContractType),
                new SqlParameter("@vehicleId", contract.VehicleId),
                new SqlParameter("@customerId", contract.CustomerId),
                new SqlParameter("@startDate", contract.StartDate),
                new SqlParameter("@endDate", contract.EndDate),
                new SqlParameter("@price", contract.Price),
                new SqlParameter("@staffId", contract.StaffId),
                new SqlParameter("@status", contract.Status),
                new SqlParameter("@contractId", contract.ContractId)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllContracts()
        {
            string query = "SELECT * FROM Contract";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetContractsByStatus(string status)
        {
            // Câu truy vấn để lấy các hợp đồng có trạng thái nhất định
            string query = "SELECT * FROM Contract WHERE status = @1";

            // Tạo mảng tham số để truyền vào ExecuteQuery
            object[] parameters = { status };

            // Gọi ExecuteQuery để lấy dữ liệu từ database
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);

            return dt;
        }

        public bool DeleteContract(int contractId)
        {
            string query = "DELETE FROM Contract WHERE contractId = @contractId";
            SqlParameter[] parameters = {
                new SqlParameter("@contractId", contractId)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsVehicleCurrentlyRented(int vehicleId)
        {
            string query = "SELECT COUNT(*) FROM Contract WHERE vehicleId = @vehicleId AND contractType = N'Cho thuê' AND status = N'Đang hiệu lực' AND endDate > GETDATE()";
            object[] parameters = { vehicleId };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;

            return count > 0;
        }

        public void UpdateExpiredContracts()
        {
            string query = "UPDATE Contract SET status = N'Đã hết hạn' WHERE status = N'Đang hiệu lực' AND endDate < GETDATE()";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetContractById(int contractId)
        {
            string query = "SELECT * FROM Contract WHERE contractId = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { contractId });
        }

        public DataTable GetContractsByLicensePlate(string licensePlate)
        {
            string query = @"
            SELECT c.*
            FROM Contract c
            JOIN Vehicle v ON c.vehicleId = v.vehicleId
            WHERE v.licensePlate LIKE @licensePlate";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + licensePlate + "%" });
        }

        public int CountRentedVehicles()
        {
            string query = "SELECT COUNT(DISTINCT vehicleId) FROM Contract WHERE contractType = 'Cho thuê' AND status = 'Đang hiệu lực' ";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
