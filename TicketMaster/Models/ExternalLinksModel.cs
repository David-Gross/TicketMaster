using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class ExternalLinksModel
    {
        public List<TwitterModel> twitter { get; set; }
        public List<FacebookModel> facebook { get; set; }
        public List<WikiModel> wiki { get; set; }
        public List<InstagramModel> instagram { get; set; }
        public List<HomepageModel> homepage { get; set; }
        public List<YoutubeModel> youtube { get; set; }
    }
}
