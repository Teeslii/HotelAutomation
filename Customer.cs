﻿using System;
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
            else if(reservationNo == 1)
            {
                typeMessage = "We will e - mail 45 days prior to payment.\nPayment is made 15 days before booking.\nIf payment is not made, the reservation will be canceled.\nIt pays 85 % of the base price.\nThere is no refund.\nChange on the day of reservation takes place with an additional fee. \nThe surcharge price is 110 % of the base price.\nIf it is lower than the old wage, the remaining amount is not paid.\n";
            }
            return typeMessage;
        }
    }
}
