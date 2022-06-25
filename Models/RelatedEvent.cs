using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class RelatedEvent
    {
        public int Id { set; get; }
        public int EventId { set; get; }
        public int RelatedEventId { set; get; }
        public Event Event {set; get; }
    }
}
