﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class CustomerDto
    {
       
        public string NameSurname { get; set; }
        public long Telephone { get; set; }
        public string Mail { get; set; }
        public string Country { get; set; }
        public long Tc { get; set; }
        public string Address { get; set; }

    }
}
