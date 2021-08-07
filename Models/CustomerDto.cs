using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class CustomerDto
    {
       
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public long Telephone { get; set; }
        public long TC { get; set; }
        public int Price { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime ExitDate { get; set; }
        public string ReservationType { get; set; }

        public int HowManyDay { get; set; }

    }
}
