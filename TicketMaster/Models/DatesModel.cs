using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class DatesModel
    {
        public StartModel Start { get; set; }
        public string timezone { get; set; }
        public StatusModel status { get; set; }
        public bool spanMultipleDays { get; set; }
    }
}
