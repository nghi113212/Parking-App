using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class VehicleTypeBUS
    {
        private static VehicleTypeBUS instance;

        public static VehicleTypeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleTypeBUS();
                return instance;
            }
        }

        private VehicleTypeBUS() { }

        public List<dynamic> GetAllVehicleTypes()
        {
            var types = VehicleTypeDAO.Instance.GetAllVehicleTypes();
            return types.Select(r => new { vehicle_typeId = r.VehicleTypeId, vehicle_typeName = r.TypeName }).ToList<dynamic>();
        }

        public DataTable GetAllVehicleTypeAndPrice()
        {
            return VehicleTypeDAO.Instance.GetAllVehicleTypeAndPrice();
        }

        public bool UpdateVehicleTypePrice(int typeId, int newPrice)
        {
            return VehicleTypeDAO.Instance.UpdatePrice(typeId, newPrice);
        }
    }
}
