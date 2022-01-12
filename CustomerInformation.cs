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


namespace hotel
{
    public partial class CustomerInformation : Form
    { 
        private readonly IDataAccess _dataAccess;
        public CustomerInformation(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }

        
        private void AssignShowInfoList()
        {
            listCustomerInformation.Items.Clear();

            List<Customer> customer;
            customer = _dataAccess.GetCustomersInfo(txtSearchNameSurname.Text);

            foreach (Customer getCustomersInfo in customer)
            {
                ListViewItem addItems = new ListViewItem();

                addItems.Text = getCustomersInfo.CustomerId.ToString();
                addItems.SubItems.Add(getCustomersInfo.NameSurname);
                addItems.SubItems.Add(getCustomersInfo.Telephone);
                addItems.SubItems.Add(getCustomersInfo.Mail);
                addItems.SubItems.Add(getCustomersInfo.Country);
                addItems.SubItems.Add(getCustomersInfo.Tc.ToString());
                addItems.SubItems.Add(getCustomersInfo.Address);

                listCustomerInformation.Items.Add(addItems);

            }
        }

         private void btnShowInformation_Click(object sender, EventArgs e)
        {
            txtSearchNameSurname.Text ="";
            AssignShowInfoList();
        }

      
        private void btnClear_Click(object sender, EventArgs e)
        {
         
            txtNameSurname.Clear();
            txtTelephone.Clear();
            txtMail.Clear();
            txtCountry.Clear();
            txtTc.Clear();
            txtAddress.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MapperUpdateCustomer();

            AssignShowInfoList();
        }
         private void MapperUpdateCustomer()
        {

        //    customer.NameSurname = txtNameSurname.Text;

        //    customer.Telephone = txtTelephone.Text;

        //    customer.Mail = txtMail.Text;

        //    customer.Country = txtCountry.Text;

        //    if (!long.TryParse(txtTc.Text, out long Tc))
        //    {
        //        MessageBox.Show("An error occurred while entering TC. Please enter again your TC number.");
        //        return;
        //    }
        //    customer.Tc = Tc;

        //    customer.Address = txtAddress.Text;

        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDto>());
        //    var mapper = new Mapper(config);
        //    var customerDto = mapper.Map<CustomerDto>(customer);

        //    _dataAccess.UpdateCustomer(customerDto);


         }
        Customer customer = new Customer();

        private void listCustomerInformation_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            customer.CustomerId = int.Parse(listCustomerInformation.Items[e.Index].SubItems[0].Text);
            txtNameSurname.Text = listCustomerInformation.Items[e.Index].SubItems[1].Text;
            txtTelephone.Text = listCustomerInformation.Items[e.Index].SubItems[2].Text;
            txtMail.Text = listCustomerInformation.Items[e.Index].SubItems[3].Text;
            txtCountry.Text = listCustomerInformation.Items[e.Index].SubItems[4].Text;
            txtTc.Text = listCustomerInformation.Items[e.Index].SubItems[5].Text;
            txtAddress.Text = listCustomerInformation.Items[e.Index].SubItems[6].Text;
        }

        

        private void AssignResultSearchList()
        {
            listCustomerInformation.Items.Clear();

            List<Customer> customer;
            customer = _dataAccess.GetCustomersInfo(txtSearchNameSurname.Text);

            foreach (Customer getCustomersInfo in customer)
            {
                ListViewItem addItems = new ListViewItem();

                addItems.Text = getCustomersInfo.CustomerId.ToString();
                addItems.SubItems.Add(getCustomersInfo.NameSurname);
                addItems.SubItems.Add(getCustomersInfo.Telephone);
                addItems.SubItems.Add(getCustomersInfo.Mail);
                addItems.SubItems.Add(getCustomersInfo.Country);
                addItems.SubItems.Add(getCustomersInfo.Tc.ToString());
                addItems.SubItems.Add(getCustomersInfo.Address);

                listCustomerInformation.Items.Add(addItems);

            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            AssignResultSearchList();
        }
           
        
        private void btnHomeBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        
    }
}
