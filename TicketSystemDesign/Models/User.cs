﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemDesign.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Role { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

    }
}
