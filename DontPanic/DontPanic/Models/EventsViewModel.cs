using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontPanic.Models
{
    public class EventsViewModel
    {
        public List<Event> Events { get; set; }
    }

    public class Event
    {
        public string Subject { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Categories { get; set; }

        public string ShowAs { get; set; }
    }
}
