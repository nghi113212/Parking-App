using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SlotDAO
    {
        private static SlotDAO instance;
        public static SlotDAO Instance
        {
            get
            {
                if (instance == null) instance = new SlotDAO();
                return instance;
            }
        }

        private SlotDAO() { }

        public List<Slot> GetAvailableSlotsByVehicleType(int vehicleTypeId)
        {
            string query = "SELECT * FROM Slot WHERE is_occpied = 0 AND vehicle_typeId = @vehicle_typeId";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { vehicleTypeId });

            List<Slot> slots = new List<Slot>();
            foreach (DataRow row in dt.Rows)
            {
                slots.Add(new Slot
                {
                    slotId = Convert.ToInt32(row["slotId"]),
                    slotNumber = row["slotNumber"].ToString()
                });
            }
            return slots;
        }

        public DataTable GetAllSlots()
        {
            string query = "SELECT * FROM Slot";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertSlot(Slot slot)
        {
            string query = "INSERT INTO Slot (slotId, slotNumber, is_occpied, vehicle_typeId) " +
                           "VALUES (@slotId, @slotNumber, @is_occpied, @vehicle_typeId)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@slotId", slot.slotId),
                new SqlParameter("@slotNumber", slot.slotNumber),
                new SqlParameter("@is_occpied", slot.is_occpied),
                new SqlParameter("@vehicle_typeId", slot.vehicle_typeId)
            });

            return result > 0;
        }

        public Slot GetSlotById(int slotId)
        {
            string query = "SELECT * FROM Slot WHERE slotId = @slotId";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { slotId });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Slot
                {
                    slotId = Convert.ToInt32(row["slotId"]),
                    slotNumber = row["slotNumber"].ToString(),
                    is_occpied = Convert.ToBoolean(row["is_occpied"]),
                    vehicle_typeId = Convert.ToInt32(row["vehicle_typeId"])
                };
            }

            return null; // không tìm thấy
        }

        public bool UpdateSlot(Slot slot)
        {
            string query = "UPDATE Slot SET slotNumber = @slotNumber, vehicle_typeId = @vehicle_typeId WHERE slotId = @slotId";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                //new object[] { slot.SlotNumber, slot.VehicleTypeId, slot.SlotId });
                new SqlParameter[]
                {
                new SqlParameter("@slotId", slot.slotId),
                new SqlParameter("@slotNumber", slot.slotNumber),
                new SqlParameter("@vehicle_typeId", slot.vehicle_typeId)
                });
            return result > 0;
        }

        public bool DeleteSlot(int slotId)
        {
            string query = "DELETE FROM Slot WHERE slotId = @slotId";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new SqlParameter[] {
            new SqlParameter("@slotId", slotId)
                });
            return result > 0;
        }

        public int CountAvailableSlots()
        {
            string query = "SELECT COUNT(*) FROM Slot WHERE is_occpied = 0";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
