using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public DateTime TimeIn { get; set; }
        public int VehicleTypeId { get; set; }
        public byte[] ImgPlateBike { get; set; }
        public byte[] ImgOwnerCarModel { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public int? ServiceId { get; set; }
        public int? SlotId { get; set; }
        public string ParkingCardCode { get; set; }
        public string ProblemDesc { get; set; }
        public string ParkingType { get; set; }
        public int CustomerId { get; set; } // Trạng thái xe (Đang đỗ, Đã trả, Đang thuê)
    }
}
