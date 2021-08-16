using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Customer
    {

        private string _nameSurname;
        private long _telephone;
        private string _mail;
        private string _country;
        private long _Tc;
        private string _address;


        public string NameSurname
        {
            get
            { 
                return _nameSurname;
            }
            set
            {
                _nameSurname = value;
            }
        }
       
        public string Mail
        {

            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
            }
        }
        public long Telephone
        {

            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public long Tc
        {

            get
            {
                return _Tc;
            }
            set
            {
                _Tc = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }


    }
}
