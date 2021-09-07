using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel.Models;

namespace hotel
{
     public interface IDataAccess
    {
        void SaveCustomer(CustomerDto customerDto);
    }
}
