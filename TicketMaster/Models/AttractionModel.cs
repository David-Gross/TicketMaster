using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class AttractionModel
    {
        public string href { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public bool test { get; set; }
        public string url { get; set; }
        public string locale { get; set; }
        public ExternalLinksModel externalLinks { get; set; }
        public List<ImageModel> images { get; set; }
        public List<ClassificationModule> classifications { get; set; }
        public UpcomingEventsModule upcomingEvents { get; set; }
        public LinksModule _links { get; set; }
        public List<string> aliases { get; set; }
    }
}
