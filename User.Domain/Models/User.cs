﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Models
{
    public class User
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? company { get; set; }
    }
}
