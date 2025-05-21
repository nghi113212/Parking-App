using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class SlotBUS
    {
        private static SlotBUS instance;
        public static SlotBUS Instance
        {
            get
            {
                if (instance == null) instance = new SlotBUS();
                return instance;
            }
        }

        private SlotBUS() { }

        //public List<object> GetAvailableSlots(int vehicleTypeId)
        //{
        //    var slotList = SlotDAO.Instance.GetAvailableSlotsByVehicleType(vehicleTypeId);

        //    // Trả về dạng object ẩn DTO
        //    var result = slotList.Select(s => new
        //    {
        //        slotId = s.slotId,
        //        slotNumber = s.slotNumber.Trim() // loại bỏ khoảng trắng nếu có
        //    }).Cast<object>().ToList();

        //    return result;
        //}

        public List<object> GetAvailableSlots(int vehicleTypeId, int? currentSlotId = null)
        {
            var slotList = SlotDAO.Instance.GetAvailableSlotsByVehicleType(vehicleTypeId);

            // Nếu có slot hiện tại (slot đang bị chiếm), thì thêm vào danh sách nếu chưa có
            if (currentSlotId.HasValue)
            {
                var currentSlot = SlotDAO.Instance.GetSlotById(currentSlotId.Value);
                if (currentSlot != null && !slotList.Any(s => s.slotId == currentSlot.slotId))
                {
                    slotList.Add(currentSlot);
                }
            }

            // Trả về dạng object ẩn DTO
            var result = slotList.Select(s => new
            {
                slotId = s.slotId,
                slotNumber = s.slotNumber.Trim()
            }).Cast<object>().ToList();

            return result;
        }

        public DataTable GetAllSlots()
        {
            return SlotDAO.Instance.GetAllSlots();
        }

        public bool InsertSlot(int slotId, string slotNumber, int vehicle_typeId)
        {
            slotNumber = slotNumber.Trim().ToUpper();

            // Xác định tiền tố hợp lệ dựa trên vehicle_typeId
            char expectedPrefix;
            if (vehicle_typeId == 1)
                expectedPrefix = 'A'; // Ô tô
            else if (vehicle_typeId == 2)
                expectedPrefix = 'B'; // Xe máy
            else if (vehicle_typeId == 3)
                expectedPrefix = 'C'; // Xe đạp
            else
                expectedPrefix = '\0';

            if (string.IsNullOrWhiteSpace(slotNumber) || slotNumber[0] != expectedPrefix)
            {
                MessageBox.Show($"SlotNumber phải bắt đầu bằng '{expectedPrefix}' cho loại xe này!",
                                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra trùng slotNumber
            DataTable existingSlots = SlotDAO.Instance.GetAllSlots();
            bool isDuplicate = false;
            foreach (DataRow row in existingSlots.Rows)
            {
                if (row["slotNumber"].ToString().Trim().Equals(slotNumber, StringComparison.OrdinalIgnoreCase))
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                MessageBox.Show("SlotNumber đã tồn tại trong hệ thống!",
                                "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            Slot slot = new Slot
            {
                slotId = slotId,
                slotNumber = slotNumber,
                is_occpied = false,
                vehicle_typeId =  vehicle_typeId
            };

            return SlotDAO.Instance.InsertSlot(slot);
        }

        public bool UpdateSlot(int slotId, string slotNumber, int vehicle_typeId)
        {
            slotNumber = slotNumber.Trim().ToUpper();

            // Xác định tiền tố hợp lệ dựa trên vehicle_typeId
            char expectedPrefix;
            if (vehicle_typeId == 1)
                expectedPrefix = 'A'; // Ô tô
            else if (vehicle_typeId == 2)
                expectedPrefix = 'B'; // Xe máy
            else if (vehicle_typeId == 3)
                expectedPrefix = 'C'; // Xe đạp
            else
                expectedPrefix = '\0';

            if (string.IsNullOrWhiteSpace(slotNumber) || slotNumber[0] != expectedPrefix)
            {
                MessageBox.Show($"SlotNumber phải bắt đầu bằng '{expectedPrefix}' cho loại xe này!",
                                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Slot slot = new Slot
            {
                slotId = slotId,
                slotNumber = slotNumber,
                is_occpied = false,
                vehicle_typeId = vehicle_typeId
            };

            return SlotDAO.Instance.UpdateSlot(slot);
        }

        public bool DeleteSlot(int slotId)
        {
            return SlotDAO.Instance.DeleteSlot(slotId);
        }

        public int GetAvailableSlotCount()
        {
            return SlotDAO.Instance.CountAvailableSlots();
        }
    }
}
