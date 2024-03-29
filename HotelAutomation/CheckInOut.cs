﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hotel
{
    public partial class CheckInOut : Form
    {
        private readonly IPayment _payment;
        public CheckInOut()
        {
            InitializeComponent();
            _payment = (IPayment)Program.ServiceProviderPayment.GetService(typeof(IPayment));
        }
        

        public void TransferId(int SaveCustomerId)
        {
            booking.CustomerId = SaveCustomerId;
        }


        Booking booking = new Booking();

        public Booking GetDate()
        {
            booking.CheckIn = CalendarCheckOut.SelectionStart;
            booking.CheckOut = CalendarCheckOut.SelectionEnd;

            return booking;
        }

        public void CheckOutRoomEvent(int _roomNo)
        {
             
            Invoice invoice = new Invoice(_payment);
            invoice.Show();
            invoice.WriteSumAmount(RoomControlService.GetBasePrice(_roomNo, GetDate()));
            this.Hide();
        }
     
        public void StartSelectionDate()
        {
            CalendarCheckOut.SelectionStart = CalendarCheckIn.SelectionStart;
            CalendarCheckOut.SelectionEnd = CalendarCheckIn.SelectionRange.Start.AddDays(6);

            roomControlCheck.ColorTransition(GetDate());
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void CheckInOut_Load(object sender, EventArgs e)
        {
            StartSelectionDate();
        }

        private void CalendarCheckOut_DateSelected(object sender, DateRangeEventArgs e)
        {
            CalendarCheckOut.SelectionStart = CalendarCheckIn.SelectionStart;

            roomControlCheck.ColorTransition(GetDate());
        }
    }
}
