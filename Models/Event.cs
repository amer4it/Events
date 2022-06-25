using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class Event
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Location { set; get; }
        public string ArabicTitle { set; get; }
        public string ArabicDescription { set; get; }
        public string ArabicLocation { set; get; }
        public int CoordLongitude { set; get; }
        public int CoordLatitude { set; get; }
        public string ImagePath { set; get; }
        public DateTime StartDate { set; get; }
        public ICollection<RelatedEvent> RelatedEvents { set; get; }
    }
}
