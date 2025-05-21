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
    public class VehicleDAO
    {
        private static VehicleDAO instance;
        public static VehicleDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleDAO();
                return instance;
            }
        }

        private VehicleDAO() { }

        public bool InsertVehicle(Vehicle vehicle)
        {
            string query = "INSERT INTO Vehicle (vehicleId, licensePlate, model, time_in, vehicle_typeId, img_plate_bike, img_owner_carModel, ownerName, ownerPhone, serviceId, slotId, parkingCard_code, problem_desc, parkingType, customerId) " +
               "VALUES (@vehicleId, @licensePlate, @model, @time_in, @vehicle_typeId, @img_plate_bike, @img_owner_carModel, @ownerName, @ownerPhone, @serviceId, @slotId, @parkingCard_code, @problem_desc, @parkingType, @customerId)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@vehicleId", vehicle.VehicleId),
                new SqlParameter("@licensePlate", vehicle.LicensePlate ?? (object)DBNull.Value),
                new SqlParameter("@model", vehicle.Model ?? (object)DBNull.Value),
                new SqlParameter("@time_in", vehicle.TimeIn),
                new SqlParameter("@vehicle_typeId", vehicle.VehicleTypeId),
                new SqlParameter("@img_plate_bike", vehicle.ImgPlateBike ?? (object)DBNull.Value),
                new SqlParameter("@img_owner_carModel", vehicle.ImgOwnerCarModel ?? (object)DBNull.Value),
                new SqlParameter("@ownerName", vehicle.OwnerName ?? (object)DBNull.Value),
                new SqlParameter("@ownerPhone", vehicle.OwnerPhone ?? (object)DBNull.Value),
                new SqlParameter("@serviceId", (object)vehicle.ServiceId ?? DBNull.Value),
                new SqlParameter("@slotId", (object)vehicle.SlotId ?? DBNull.Value),
                new SqlParameter("@parkingCard_code", vehicle.ParkingCardCode ?? (object)DBNull.Value),
                new SqlParameter("@problem_desc", vehicle.ProblemDesc ?? (object)DBNull.Value),
                new SqlParameter("@parkingType", vehicle.ParkingType ?? (object)DBNull.Value),
                new SqlParameter("@customerId", (object)vehicle.CustomerId ?? (object)DBNull.Value)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllVehicles()
        {
            string query = "SELECT * FROM Vehicle";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateVehicle(Vehicle vehicle)
        {
            string query = @"
                UPDATE Vehicle
                SET
                    licensePlate = @licensePlate,
                    model = @model,
                    time_in = @timeIn,
                    vehicle_typeId = @vehicle_typeId,
                    img_plate_bike = @img_plate_bike,
                    img_owner_carModel = @img_owner_carModel,
                    ownerName = @ownerName,
                    ownerPhone = @ownerPhone,
                    serviceId = @serviceId,
                    slotId = @slotId,
                    parkingCard_code = @parkingCardCode,
                    problem_desc = @problemDesc,
                    parkingType = @parkingType  
                WHERE vehicleId = @vehicleId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@vehicleId", vehicle.VehicleId),
                new SqlParameter("@licensePlate", vehicle.LicensePlate ?? (object)DBNull.Value),
                new SqlParameter("@model", vehicle.Model ?? (object)DBNull.Value),
                new SqlParameter("@timeIn", vehicle.TimeIn),
                new SqlParameter("@vehicle_typeId", vehicle.VehicleTypeId),
                new SqlParameter("@img_plate_bike", vehicle.ImgPlateBike ?? (object)DBNull.Value),
                new SqlParameter("@img_owner_carModel", vehicle.ImgOwnerCarModel ?? (object)DBNull.Value),
                new SqlParameter("@ownerName", vehicle.OwnerName ?? (object)DBNull.Value),
                new SqlParameter("@ownerPhone", vehicle.OwnerPhone ?? (object)DBNull.Value),
                new SqlParameter("@serviceId", vehicle.ServiceId ?? (object)DBNull.Value),
                new SqlParameter("@slotId", vehicle.SlotId ?? (object)DBNull.Value),
                new SqlParameter("@parkingCardCode", vehicle.ParkingCardCode ?? (object)DBNull.Value),
                new SqlParameter("@problemDesc", vehicle.ProblemDesc ?? (object)DBNull.Value),
                new SqlParameter("@parkingType", vehicle.ParkingType ?? (object)DBNull.Value)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool ExistsVehicleId(int vehicleId)
        {
            string query = "SELECT COUNT(*) FROM Vehicle WHERE vehicleId = @vehicleId";
            object[] parameter = new object[] { vehicleId };
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query,parameter));

            return count > 0;
        }

        public Vehicle GetVehicleBySlotId(int slotId)
        {
            string query = "SELECT * FROM Vehicle WHERE SlotId = @slotId";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { slotId });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                return new Vehicle
                {
                    VehicleId = Convert.ToInt32(row["vehicleId"]),
                    LicensePlate = row["licensePlate"].ToString(),
                    Model = row["model"].ToString(),
                    TimeIn = Convert.ToDateTime(row["time_in"]),
                    VehicleTypeId = Convert.ToInt32(row["vehicle_typeId"]),
                    ImgPlateBike = row["img_plate_bike"] == DBNull.Value ? null : (byte[])row["img_plate_bike"],
                    ImgOwnerCarModel = row["img_owner_carModel"] == DBNull.Value ? null : (byte[])row["img_owner_carModel"],
                    OwnerName = row["ownerName"].ToString(),
                    OwnerPhone = row["ownerPhone"].ToString(),
                    ServiceId = row["serviceId"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["serviceId"]),
                    SlotId = row["slotId"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["slotId"]),
                    ParkingCardCode = row["parkingCard_code"].ToString(),
                    ProblemDesc = row["problem_desc"].ToString()
                };
            }

            return null;
        }

        public int GetVehicleTypeId(int vehicleId)
        {
            string query = "SELECT vehicle_typeId FROM Vehicle WHERE vehicleId = @vehicleId";
            object[] parameters = { vehicleId };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public bool DeleteVehicle(int vehicleId)
        {
            string query = "DELETE FROM Vehicle WHERE vehicleId = @vehicleId";
            SqlParameter[] parameters = {new SqlParameter("@vehicleId", vehicleId)};

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateVehicleOwner(int vehicleId, int customerId)
        {
            string query = "UPDATE Vehicle SET customerId = @customerId WHERE vehicleId = @vehicleId";
            SqlParameter[] parameters = {
                new SqlParameter("@customerId", customerId),
                new SqlParameter("@vehicleId", vehicleId)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetVehicleById(int vehicleId)
        {
            string query = "SELECT * FROM Vehicle WHERE vehicleId = @vehicleId";
            object[] parameters = new object[] { vehicleId };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetVehiclesWithServiceIdAndZeroCost()
        {
            string query = @"
                SELECT 
                    v.vehicleId, 
                    v.licensePlate, 
                    CASE 
                        WHEN v.serviceId = 2 THEN N'Rửa xe'
                        WHEN v.serviceId = 3 THEN N'Sửa xe'
                        ELSE N'Khác'
                    END AS serviceName, --v.serviceId, 
                    v.ownerName, 
                    v.ownerPhone, 
                    v.problem_desc,  -- nếu có
                    b.cost
                FROM Vehicle v
                JOIN Bill b ON v.vehicleId = b.vehicle_id
                WHERE (v.serviceId = 2 OR v.serviceId = 3)
                  AND b.cost = 0.00
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int CountVehicleParking()
        {
            string query = "SELECT COUNT(*) FROM Vehicle WHERE slotId IS NOT NULL";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
