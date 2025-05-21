using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string ContractType { get; set; } // 1: Cho thuê, 2: Ký gửi
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Price { get; set; }
        public int StaffId { get; set; }
        public string Status { get; set; }
    }
}
