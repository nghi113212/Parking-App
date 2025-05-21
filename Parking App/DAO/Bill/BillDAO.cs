using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }
        }

        private BillDAO() { }

        public string GetCurrentBillIdByVehicleAndService(int vehicleId, int serviceId)
        {
            string query = "SELECT TOP 1 Id FROM Bill WHERE vehicle_id = @vehicleId AND serviceId = @serviceId AND cost = 0.00";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { vehicleId, serviceId });

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Id"].ToString();
            }

            return null;
        }

        public string GetServiceNameById(int serviceId)
        {
            string query = "SELECT serviceName FROM Services WHERE serviceId = @serviceId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { serviceId });

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["serviceName"].ToString();
            }

            return null;
        }

        public string GetOwnerNameByVehicleId(int vehicleId)
        {
            string query = "SELECT ownerName FROM Vehicle WHERE vehicleId = @vehicleId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { vehicleId });

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["ownerName"].ToString();
            }

            return null;
        }

        public bool UpdateBillOnPaid(string billId, decimal cost, decimal fine)
        {
            string query = @"
            UPDATE Bill
            SET 
                cost = @cost,
                fine = @fine,
                day_print = GETDATE()
            WHERE Id = @billId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@cost", cost),
                new SqlParameter("@fine", fine),
                new SqlParameter("@billId", billId)
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        public bool CreateBillFromContract(int contractId)
        {
            // Lấy thông tin hợp đồng
            string getQuery = "SELECT vehicleId, price FROM Contract WHERE contractId = @id AND status = N'Đã hết hạn'";
            object[] getParams = { contractId };
            DataTable dt = DataProvider.Instance.ExecuteQuery(getQuery, getParams);

            if (dt.Rows.Count == 0) return false;

            int vehicleId = Convert.ToInt32(dt.Rows[0]["vehicleId"]);
            int price = Convert.ToInt32(dt.Rows[0]["price"]);

            // Tạo billId không trùng
            string getMaxIdQuery = "SELECT TOP 1 Id FROM Bill ORDER BY CAST(SUBSTRING(Id, 3, LEN(Id) - 2) AS INT) DESC";
            object result = DataProvider.Instance.ExecuteScalar(getMaxIdQuery);

            int newIdNumber = 1;
            if (result != null)
            {
                string lastId = result.ToString(); // "HD00004"
                newIdNumber = int.Parse(lastId.Substring(2)) + 1;
            }

            string billId = "HD" + newIdNumber.ToString("D5"); // HD00005

            // Chèn hóa đơn
            string insertQuery = @"
            INSERT INTO Bill (Id, vehicle_id, serviceId, cost, fine, note, day_print)
            VALUES (@id, @vehicleId, @serviceId, @cost, 0.00, @note, GETDATE())";

            SqlParameter[] insertParams = {
                new SqlParameter("@id", billId),
                new SqlParameter("@vehicleId", vehicleId),
                new SqlParameter("@serviceId", 4),
                new SqlParameter("@cost", price),
                new SqlParameter("@note", $"Thanh toán hợp đồng cho thuê mã: {contractId}")
            };

            return DataProvider.Instance.ExecuteNonQuery(insertQuery, insertParams) > 0;
        }

        public bool UpdateBillForConsignContract(int vehicleId, decimal price, int contractId)
        {
            string updateQuery = @"
            UPDATE Bill
            SET cost = @cost,
                note = @note,
                day_print = GETDATE()
            WHERE vehicle_id = @vehicleId
              AND serviceId = 4
              AND cost = 0";

            SqlParameter[] updateParams = {
                new SqlParameter("@cost", price),
                new SqlParameter("@note", $"Trả tiền cho người ký gửi hợp đồng mã: {contractId}"),
                new SqlParameter("@vehicleId", vehicleId)
            };

            return DataProvider.Instance.ExecuteNonQuery(updateQuery, updateParams) > 0;
        }

        public bool UpdateBillCostAndNote(int vehicleId, double cost, string note)
        {
            string query = @"
            UPDATE Bill
            SET cost = @cost,
                note = @note
            WHERE vehicle_id = @vehicleId AND cost = 0.00";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@cost", cost),
                new SqlParameter("@note", note),
                new SqlParameter("@vehicleId", vehicleId)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public decimal GetBillCost(int vehicleId, int serviceId)
        {
            string query = "SELECT cost FROM Bill WHERE vehicle_id = @vehicleId AND serviceId = @serviceId";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { vehicleId, serviceId });
            return result != null && result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }

        public string GetBillNote(int vehicleId, int serviceId)
        {
            string query = "SELECT note FROM Bill WHERE vehicle_id = @vehicleId AND serviceId = @serviceId";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { vehicleId, serviceId });
            return result?.ToString() ?? "";
        }

        public string GetCurrentBillIdByVehicleAndService2(int vehicleId, int serviceId)
        {
            string query = "SELECT TOP 1 Id FROM Bill WHERE vehicle_id = @vehicleId AND serviceId = @serviceId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { vehicleId, serviceId });

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Id"].ToString();
            }

            return null;
        }

        public bool UpdateBillOnPaid2(string billId)
        {
            string query = @"
            UPDATE Bill
            SET 
                day_print = GETDATE()
            WHERE Id = @billId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@billId", billId)
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        public DataTable GetRevenue(DateTime from, DateTime to)
        {
            string query = @"
                SELECT b.Id, b.vehicle_Id, s.serviceName, b.cost, b.day_print
                FROM Bill b
                JOIN Services s ON b.serviceId = s.serviceId
                WHERE b.cost <> 0.00 
                    AND b.day_print BETWEEN @from AND @to
            ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
            return dt;
        }
    }
}
