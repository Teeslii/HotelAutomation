using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using hotel.Models;

namespace hotel
{
    public class MapperCustomer 
    {
        private readonly IDataAccess _dataAccess;
      
        public MapperCustomer(IDataAccess _dataAccess)
        {
            this._dataAccess = _dataAccess;
        }

        public List<CustomerDto> MapperResultProfile(string _searchNameSurname)
        {
            List<Customer> customers = _dataAccess.GetCustomersInfo(_searchNameSurname);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDto>());
            var mapper = new Mapper(config);
            List<CustomerDto> customerDto = mapper.Map<List<Customer>, List<CustomerDto>>(customers);
            return customerDto;
        }
    }
}
