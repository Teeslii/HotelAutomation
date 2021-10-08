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
        int SaveCustomer(CustomerDto customerDto);

        List<CustomerDto> MapperShowInfo();
        List<Customer> GetCustomersInfo();

        List<CustomerDto> GetCustomersInfo(string _nameSurname);
        List<CustomerDto> MapperResultSearch(List<Customer> customers);

        void UpdateCustomer(CustomerDto customerDto);

    }
}
