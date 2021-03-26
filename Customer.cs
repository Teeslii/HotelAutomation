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
        private string _lastName;
        private string _mail;
        private long _telephone;
        private long _TC;
        private int _price;
        private DateTime _loginDate;
        private DateTime _exitDate;
        private string _reservationType;

        public string reservationSelection(int reservationNo)
        {
            string typeMessage="";
            if(reservationNo == 0)
            {
               
            }
            else if(reservationNo == 1)
            {
                
            }
            else if(reservationNo == 2)
            {

            }
            else if (reservationNo == 3)
            {

            }
            return typeMessage;
        }

        public string paymentCalculation(string loginDate, string exitDate)
        {
            _loginDate = Convert.ToDateTime(loginDate);
            _exitDate = Convert.ToDateTime(exitDate);

            TimeSpan result = _exitDate - _loginDate;

            int manyDay = Convert.ToInt32(result.TotalDays);
            _price = manyDay * 50;
            return _price.ToString();
        }
    }
}
