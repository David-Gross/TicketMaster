using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class UpcomingEventsModule
    {
        public int archtics { get; set; }
        public int ticketmaster { get; set; }
        public int _total { get; set; }
        public int _filtered { get; set; }
        public int? tmr { get; set; }
        public int? universe { get; set; }
    }
}
