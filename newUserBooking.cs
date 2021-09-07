using System;
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
using AutoMapper;
using hotel.Models;

namespace hotel
{
    public partial class NewUserBooking : Form
    {
        public IDataAcces dataAcces;
        public NewUserBooking(IDataAcces dataAcces)
        {
            InitializeComponent();
            this.dataAcces = dataAcces;
        }

        Customer customer = new Customer();


        private void MapperCustomerDto()
        {
            customer.NameSurname = txtNameSurname.Text;
           
            customer.Telephone = txtTelephone.Text;
            
            customer.Mail = txtMail.Text;

            customer.Country = txtCountry.Text;

           if(!long.TryParse(txtTc.Text, out long Tc))
            {
                MessageBox.Show("An error occurred while entering TC. Please enter again your TC number.");
                return;
            }
            customer.Tc = Tc;

            customer.Address = txtAddress.Text;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer,CustomerDto>());
            var mapper = new Mapper(config);
            var customerDto = mapper.Map<CustomerDto>(customer);
            dataAcces.SaveCustomer(customerDto);

        }

        private void txtExitDate_ValueChanged(object sender, EventArgs e)
        {
       
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MapperCustomerDto();
        }
       

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void cBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void newUserBooking_Load(object sender, EventArgs e)
        {
            roomControlBooking.ColorTransition();
        }

        
    }
}

