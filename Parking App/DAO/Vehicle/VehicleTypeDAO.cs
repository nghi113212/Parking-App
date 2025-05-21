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
    public class VehicleTypeDAO
    {
        private static VehicleTypeDAO instance;
        public static VehicleTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleTypeDAO();
                return instance;
            }
        }

        public List<VehicleType> GetAllVehicleTypes()
        {
            string query = "SELECT * FROM [Vehicle Type]";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<VehicleType> list = new List<VehicleType>();
            foreach (DataRow row in dt.Rows)
            {
                VehicleType type = new VehicleType()
                {
                    VehicleTypeId = Convert.ToInt32(row["vehicle_typeId"]),
                    TypeName = row["vehicle_typeName"].ToString()
                };
                list.Add(type);
            }
            return list;
        }

        public int GetPriceByTypeId(int typeId)
        {
            string query = "SELECT parking_fee FROM [Vehicle Type] WHERE vehicle_typeId = @id";
            object[] parameters = { typeId };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetAllVehicleTypeAndPrice()
        {
            string query = "SELECT * FROM [Vehicle Type]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdatePrice(int typeId, int newPrice)
        {
            string query = @"
                UPDATE [Vehicle Type]
                SET parking_fee = @newPrice
                WHERE vehicle_typeId = @typeId";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
            new SqlParameter[]
            {
                new SqlParameter("@newPrice", newPrice),
                new SqlParameter("@typeId", typeId)
            });
            return result > 0;
        }
    }
}
