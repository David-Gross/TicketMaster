using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class EmbeddedModel
    {
        public List<EventModel> events { get; set; }
        public List<VenueModel> venues { get; set; }
        public List<AttractionModel> attractions { get; set; }

        public EmbeddedModel()
        {
            events = new List<EventModel>();
            venues = new List<VenueModel>();
            attractions = new List<AttractionModel>();
        }
    }

}
