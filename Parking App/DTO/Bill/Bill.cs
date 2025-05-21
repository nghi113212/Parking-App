using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        public string Id { get; set; }
        public int? VehicleId { get; set; }
        public int? ServiceId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Fine { get; set; }
        public string Note { get; set; }
        public DateTime? DayPrint { get; set; }
    }
}
