using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemDesign.Models
{
    public class Ticket
    {

        public Ticket()
        {

        }

        public string TicketId { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string Severity { get; set; }

        public string Priority { get; set; }


    }
}
