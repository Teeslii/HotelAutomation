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
                typeMessage = "The full fee is paid before the last 90 days.\n 75 % of the base price is paid.\n There is no refund. \n Change on the day of reservation takes place with an additional fee.\n The additional fee is 110 % of the base price.";
            }
            else if(reservationNo == 1)
            {
                typeMessage = "We will e - mail 45 days prior to payment.\nPayment is made 15 days before booking.\nIf payment is not made, the reservation will be canceled.\nIt pays 85 % of the base price.\nThere is no refund.\nChange on the day of reservation takes place with an additional fee. \nThe surcharge price is 110 % of the base price.\nIf it is lower than the old wage, the remaining amount is not paid.\n";
            }
            else if(reservationNo == 2)
            {
                typeMessage = "The reservation can be made at any time. \n And it can be changed at any time. \n Payment is made at the end of the stay. \n You must enter your credit card number when booking. \n If there is less than 3 days left, the reservation will be canceled. \n And if you do not arrive on the first day of stay, the penalty the price is deducted from the card.";
            }
            else if (reservationNo == 3)
            {
                typeMessage = "For a reservation made more than 30 days before the start of the stay; If the expected average occupancy is 60 % or less, the price is paid 20 % lower.\nFOR EXAMPLE,\nGet a reservation for 4 nights after 25 days from Sunday to Thursday.\nThe average number of rooms kept for these 4 nights at that time is 22.5, and the expected average job rate is 50 %.\nThe price for 4 nights is 80 % of the base price.\nFee is paid at the end of the stay.\nCancellation and change of days(standard(classic) reservation).";
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
