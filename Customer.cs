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
        private int _howManyDay;
        private int _dailyPrice;

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
        public  string LastName
        {

            get
            {
                return _lastName;
            }
            set
            {
                value =_lastName ;
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
        public int Price
        {

            get
            {
                return _price;
            }
            set
            {
                value = _price;
            }
        }
        public DateTime LoginDate
        {

            get
            {
                return _loginDate;
            }
            set
            {
                value = _loginDate ;
            }
        }
        public DateTime ExitDate
        {

            get
            {
                return _exitDate;
            }
            set
            {
                value = _exitDate;
            }
        }
        public string ReservationType
        {

            get
            {
                return _reservationType;
            }
            set
            {
                value = _reservationType;
            }
        }
        public int HowManyDay
        {

            get
            {
                return _howManyDay;
            }
            set
            {
                value = _howManyDay;
            }
        }
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

           _howManyDay = Convert.ToInt32(result.TotalDays);
            _price = _howManyDay * _dailyPrice;
            return _price.ToString();
        }
    }
}
