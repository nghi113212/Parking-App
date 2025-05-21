using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class VehicleBUS
    {

        private static VehicleBUS instance;
        public static VehicleBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleBUS();
                return instance;
            }
        }

        private VehicleBUS() { }

       
        public bool AddVehicle(int vehicleId, string licensePlate, string model, DateTime timeIn, int vehicleTypeId,
                       byte[] imgPlateBike, byte[] imgOwnerCarModel, string ownerName, string ownerPhone,
                       int serviceId, int? slotId, string parkingCardCode, string problemDesc, string parkingType)
        {


            if (VehicleDAO.Instance.ExistsVehicleId(vehicleId))
            {
                MessageBox.Show("Vehicle ID đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (vehicleTypeId != 0 && imgPlateBike == null || vehicleTypeId != 0 && imgOwnerCarModel == null)
            {
                MessageBox.Show("Vui lòng thêm ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Vehicle vehicle = new Vehicle
            {
                VehicleId = vehicleId,
                LicensePlate = licensePlate,
                Model = model,
                TimeIn = timeIn,
                VehicleTypeId = vehicleTypeId,
                ImgPlateBike = imgPlateBike,
                ImgOwnerCarModel = imgOwnerCarModel,
                OwnerName = ownerName,
                OwnerPhone = ownerPhone,
                ServiceId = serviceId,
                SlotId = slotId,
                ParkingCardCode = parkingCardCode,
                ProblemDesc = problemDesc,
                ParkingType = parkingType
            };

            return VehicleDAO.Instance.InsertVehicle(vehicle);
        }

        public bool AddVehicle(int vehicleId, string licensePlate, string model, DateTime timeIn, int vehicleTypeId,
               byte[] imgPlateBike, byte[] imgOwnerCarModel, string ownerName, string ownerPhone,
               int serviceId, int? slotId, string parkingCardCode, string problemDesc, string parkingType,
               int customerId) 
        {
            if (VehicleDAO.Instance.ExistsVehicleId(vehicleId))
            {
                MessageBox.Show("Vehicle ID đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (vehicleTypeId != 0 && imgPlateBike == null || vehicleTypeId != 0 && imgOwnerCarModel == null)
            {
                MessageBox.Show("Vui lòng thêm ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Vehicle vehicle = new Vehicle
            {
                VehicleId = vehicleId,
                LicensePlate = licensePlate,
                Model = model,
                TimeIn = timeIn,
                VehicleTypeId = vehicleTypeId,
                ImgPlateBike = imgPlateBike,
                ImgOwnerCarModel = imgOwnerCarModel,
                OwnerName = ownerName,
                OwnerPhone = ownerPhone,
                ServiceId = serviceId,
                SlotId = slotId,
                ParkingCardCode = parkingCardCode,
                ProblemDesc = problemDesc,
                ParkingType = parkingType,
                CustomerId = customerId // ⬅️ Gán vào đây
            };

            return VehicleDAO.Instance.InsertVehicle(vehicle);
        }

        public DataTable GetAllVehicles()
        {
            return VehicleDAO.Instance.GetAllVehicles();
        }

        public bool UpdateVehicle(int vehicleId, string licensePlate, string model, DateTime timeIn, int vehicleTypeId,
                       byte[] imgPlateBike, byte[] imgOwnerCarModel, string ownerName, string ownerPhone,
                       int serviceId, int? slotId, string parkingCardCode, string problemDesc, string parkingType)
        {
            Vehicle vehicle = new Vehicle
            {
                VehicleId = vehicleId,
                LicensePlate = licensePlate,
                Model = model,
                TimeIn = timeIn,
                VehicleTypeId = vehicleTypeId,
                ImgPlateBike = imgPlateBike,
                ImgOwnerCarModel = imgOwnerCarModel,
                OwnerName = ownerName,
                OwnerPhone = ownerPhone,
                ServiceId = serviceId,
                SlotId = slotId,
                ParkingCardCode = parkingCardCode,
                ProblemDesc = problemDesc,
                ParkingType = parkingType
            };

            return VehicleDAO.Instance.UpdateVehicle(vehicle);
        }

        //public Vehicle GetVehicleBySlotId(int slotId)
        //{
        //    return VehicleDAO.Instance.GetVehicleBySlotId(slotId);
        //}

        public object[] GetVehicleInfoBySlotId(int slotId)
        {
            var vehicle = VehicleDAO.Instance.GetVehicleBySlotId(slotId); // vẫn dùng DTO trong BUS được

            if (vehicle == null)
                return null;

            return new object[]
            {
                vehicle.VehicleId,
                vehicle.LicensePlate,
                vehicle.Model,
                vehicle.TimeIn,
                vehicle.VehicleTypeId,
                vehicle.ImgPlateBike,
                vehicle.ImgOwnerCarModel
            };
        }

        public int GetVehiclePrice(int vehicleId)
        {
            int typeId = VehicleDAO.Instance.GetVehicleTypeId(vehicleId);
            return VehicleTypeDAO.Instance.GetPriceByTypeId(typeId);
        }

        public bool DeleteVehicle(int vehicleId)
        {
            return VehicleDAO.Instance.DeleteVehicle(vehicleId);
        }

        public bool UpdateVehicleOwner(int vehicleId, int customerId)
        {
            return VehicleDAO.Instance.UpdateVehicleOwner(vehicleId, customerId);
        }

        public DataTable GetVehicleById(int vehicleId)
        {
            return VehicleDAO.Instance.GetVehicleById(vehicleId);
        }

        public DataTable GetVehiclesForTechnician()
        {
            return VehicleDAO.Instance.GetVehiclesWithServiceIdAndZeroCost();

        }

        public int GetVehicleParkingCount()
        {
            return VehicleDAO.Instance.CountVehicleParking();
        }
    }
}
