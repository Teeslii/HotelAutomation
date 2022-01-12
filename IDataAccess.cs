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
        int SaveCustomer(Customer  customer);

        
        List<Customer> GetCustomersInfo(string _nameSurname);
        

        void UpdateCustomer(Customer customer);

    }
}
