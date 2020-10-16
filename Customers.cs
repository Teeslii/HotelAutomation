using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace hotel
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        SqlConnection connectn = new SqlConnection("Data Source=LAPTOP-VBIOM4D2;Initial Catalog=Octopus;Integrated Security=True");
      
        private void showdata()
        {
            listShowdata.Items.Clear();
            connectn.Open();
            SqlCommand command = new SqlCommand("select * from customer", connectn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["ID"].ToString();
                add.SubItems.Add(reader["firstName"].ToString());
                add.SubItems.Add(reader["lastName"].ToString());
                add.SubItems.Add(reader["telephone"].ToString());
                add.SubItems.Add(reader["mail"].ToString());
                
                add.SubItems.Add(reader["TC"].ToString());
                add.SubItems.Add(reader["price"].ToString());
                add.SubItems.Add(reader["loginDate"].ToString());
                add.SubItems.Add(reader["exitDate"].ToString());
                


                listShowdata.Items.Add(add);
            }
            reader.Close();
            connectn.Close();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            showdata();

        }

        int id = 0;
        private void listShowdata_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listShowdata.SelectedItems[0].SubItems[0].Text);
            txtFirstName.Text = listShowdata.SelectedItems[0].SubItems[1].Text;
            txtLastName.Text  = listShowdata.SelectedItems[0].SubItems[2].Text;
            txtTelephone.Text = listShowdata.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listShowdata.SelectedItems[0].SubItems[4].Text;
            txtID.Text = listShowdata.SelectedItems[0].SubItems[5].Text;
            txtPrice.Text = listShowdata.SelectedItems[0].SubItems[6].Text;
            txtLoginDate.Text = listShowdata.SelectedItems[0].SubItems[7].Text;
            txtExitDate.Text = listShowdata.SelectedItems[0].SubItems[8].Text;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connectn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from customer join  Room  on customer.ID = Room.ID  where ID = (" + id + ")", connectn);
            sqlCommand.ExecuteNonQuery();
            connectn.Close();
            showdata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTelephone.Clear();
            txtMail.Clear();
           
            txtID.Clear();
            txtPrice.Clear();
            txtLoginDate.Text= "";
            txtExitDate.Text= "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectn.Open();
            SqlCommand command = new SqlCommand("update customer set firstName='"+txtFirstName.Text+ "', lastName='" +txtLastName.Text+ "', telephone='"+txtTelephone.Text+ "', mail='" +txtMail.Text+ "', TC='" +ID.Text+ "', price='" +txtPrice.Text+ "' where ID = (" + id + ")",connectn);
            command.ExecuteNonQuery();
            connectn.Close();
            showdata();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            int convertID;
            convertID = Convert.ToInt32(txtResearchID.Text);
            listShowdata.Items.Clear();
            connectn.Open();
            SqlCommand command = new SqlCommand("select * from customer where ID=(" + convertID + ")", connectn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["ID"].ToString();
                add.SubItems.Add(reader["firstName"].ToString());
                add.SubItems.Add(reader["lastName"].ToString());
                add.SubItems.Add(reader["telephone"].ToString());
                add.SubItems.Add(reader["mail"].ToString());
                 
                add.SubItems.Add(reader["TC"].ToString());
                add.SubItems.Add(reader["price"].ToString());
                add.SubItems.Add(reader["loginDate"].ToString());
                add.SubItems.Add(reader["exitDate"].ToString());



                listShowdata.Items.Add(add);
            }
            reader.Close();
            connectn.Close();
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
