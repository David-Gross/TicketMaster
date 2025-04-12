using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class Root
    {
        public string keyword { get; set; }
        public AttractionModel attraction;
        public EmbeddedModel _embedded { get; set; }
        //public Links _links { get; set; }
        public PageModel page { get; set; }

        public Root()
        {
            keyword = "Phish";
            attraction = new AttractionModel();
        }
    }
}
