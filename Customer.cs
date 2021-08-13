using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Customer
    {



        private int _id = 0;
        private string _firstName;
      
        private string _mail;
        private long _telephone;
        private long _TC;
        private int _price;
        
   

        public string FirstName
        {
            get
            { 
                return _firstName;
            }
            set
            {
                value = _firstName;
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
                value = _mail;
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
                value = _telephone;
            }
        }
        public long TC
        {

            get
            {
                return _TC;
            }
            set
            {
                value = _TC ;
            }
        }
       
     
    }
}
