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
    public partial class Customers : Form
    {
       
        public Customers()
        {
            InitializeComponent();
        }

       //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString);
       
        
        private string ConnectionString = "hotel.Properties.Settings.Setting";
        private void showdata()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectionString].ConnectionString))
            {
                listShowdata.Items.Clear();

                connection.Open();
                SqlCommand command = new SqlCommand("select ID, firstName, lastName, telephone, mail, TC, price, loginDate, exitDate from customer", connection);
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
                connection.Close();
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            showdata();

        }

        private int id = 0;
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
        // to delete the first record -- booking
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectionString].ConnectionString))
            {
                    connection.Open();
                    string DeleteQuery = "delete from customer where ID = @id";
                    SqlCommand sqlCommand = new SqlCommand(DeleteQuery, connection);
                    sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", SqlDbType.Int, 3) { Value = id });
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    showdata();
            }
            
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

            connection.Open();
            SqlCommand command = new SqlCommand("update customer set firstName= @firstName , lastName= @lastName, telephone= @telephone, mail= @mail, TC= @TC, price= @price where ID = @id", connection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", SqlDbType.Int, 3) { Value = id });
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@firstName", SqlDbType.VarChar, 50) { Value = txtFirstName.Text });
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastName", SqlDbType.NVarChar, 50) { Value = txtLastName.Text });
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@telephone", SqlDbType.VarChar, 11) { Value = txtTelephone.Text });
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@mail", SqlDbType.VarChar, 50) { Value = txtMail.Text });
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TC", SqlDbType.VarChar, 11) { Value = ID.Text });
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", SqlDbType.Int , 20) { Value = txtPrice.Text });

            command.ExecuteNonQuery();
            connection.Close();
            showdata();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            listShowdata.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select ID, firstName, lastName, telephone, mail, TC, price, loginDate, exitDate from customer where ID= @researchID", connection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@researchID", SqlDbType.Int, 3) { Value = txtResearchID.Text });
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
            connection.Close();
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
