using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.Models
{
    public class EventModel
    {
        public string name { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public bool test { get; set; }
        public string url { get; set; }
        public string locale { get; set; }
        public List<ImageModel> images { get; set; }
        //public Salesmodel sales { get; set; }
        public DatesModel dates { get; set; }
        //public List<ClassificationModel> classifications { get; set; }
        //public PromoterModel promoter { get; set; }
        //public List<PromoterModel> promoters { get; set; }
        //public List<ProductModel> products { get; set; }
        //public SeatmapModel seatmap { get; set; }
        public AccessibilityModel accessibility { get; set; }
        //public TicketLimitModel ticketLimit { get; set; }
        //public AgeRestrictionsModel ageRestrictions { get; set; }
        //public TicketingModel ticketing { get; set; }
        //public LinksModel _links { get; set; }
        public EmbeddedModel _embedded { get; set; }
        public string info { get; set; }
        public string pleaseNote { get; set; }
        //public List<Outletmodel> outlets { get; set; }

        public string shortName()
        {
            if (name.Length > 25) { return name.Substring(0, 25) + "..."; }
            return name;
        }

    }
}
