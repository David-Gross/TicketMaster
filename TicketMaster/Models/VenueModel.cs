using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class VenueModel
    {
        public string href { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public bool test { get; set; }
        public string url { get; set; }
        public string locale { get; set; }
        public List<ImageModel> images { get; set; }
        public string postalCode { get; set; }
        public string timezone { get; set; }
        public CityModel city { get; set; }
        public StateModel state { get; set; }
        //public CountryModel country { get; set; }
        public AddressModel address { get; set; }
        //public LocationModel location { get; set; }
        //public List<MarketModel> markets { get; set; }
        //public List<DmaModel> dmas { get; set; }
        //public BoxOfficeInfoModel boxOfficeInfo { get; set; }
        public string parkingDetail { get; set; }
        public string accessibleSeatingDetail { get; set; }
        //public GeneralInfoModel generalInfo { get; set; }
        //public UpcomingEventsModel upcomingEvents { get; set; }
        //public AdaModel ada { get; set; }
        //public LinksModel _links { get; set; }
        //public SocialModel social { get; set; }

    }
}
