using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Slot
    {
        public int slotId { get; set; }
        public string slotNumber { get; set; }

        public int vehicle_typeId { get; set; }
        public bool is_occpied { get; set; }

    }

}
