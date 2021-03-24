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

        private string reservationSelection(int reservationNo)
        {
            string typeMessage="";
            if(reservationNo == 0)
            {
                typeMessage = "The full fee is paid before the last 90 days.\n 75 % of the base price is paid.\n There is no refund. \n Change on the day of reservation takes place with an additional fee.\n The additional fee is 110 % of the base price.";
            }
            return typeMessage;
        }
    }
}
