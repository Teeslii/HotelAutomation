using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel.Models;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using AutoMapper;

namespace hotel
{
    public class SqlDataAccess : IDataAccess
    {

        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;


        public int SaveCustomer(CustomerDto customerDto)
        {
            using (var ConnectionSave = new SqlConnection(ConnectionString))
            {
                ConnectionSave.Open();

                string insertQuery = "Insert into Customer(NameSurname, Telephone, Mail, Country, Tc, Address) values( @NameSurname, @Telephone, @Mail, @Country, @Tc, @Address)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, ConnectionSave);
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = customerDto.NameSurname });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Telephone", SqlDbType.VarChar, 16) { Value = customerDto.Telephone });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Mail", SqlDbType.NVarChar, 80) { Value = customerDto.Mail });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", SqlDbType.NVarChar, 80) { Value = customerDto.Country });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tc", SqlDbType.VarChar, 11) { Value = customerDto.Tc });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", SqlDbType.NVarChar, 300) { Value = customerDto.Address });
                insertCommand.ExecuteNonQuery();

                var getIdQuery = "select @@IDENTITY";
                var cmd = new SqlCommand(getIdQuery, ConnectionSave);
                var saveCustomerId = cmd.ExecuteScalar();
                if (!int.TryParse(saveCustomerId.ToString(), out int _customerId))
                {
                    System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                }

                ConnectionSave.Close();
                return _customerId;
            }
        }

        

        public List<Customer> GetCustomersInfo(string _nameSurname)
        {
            using (var connectionInfo = new SqlConnection(ConnectionString))
            {
                connectionInfo.Open();
                List<Customer> customer = new List<Customer>();
                string searchQuery;

                if (_nameSurname == "")
                {
                    searchQuery = "select Id, NameSurname, Telephone, Mail, Country, Tc, Address from Customer";
                }
                else
                {
                    searchQuery = "select Id, NameSurname, Telephone, Mail, Country, Tc, Address from Customer where NameSurname Like '%'+ @NameSurname +'%' ";
                }
                var cmd = new SqlCommand(searchQuery, connectionInfo);

              
                if (_nameSurname != "")
                {
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = _nameSurname });
                }
               
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!int.TryParse(reader["Id"].ToString(), out int _customerId))
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                    }
                    if (!long.TryParse(reader["Tc"].ToString(), out long _Tc))
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's TC.");
                    }
                    customer.Add(new Customer() { CustomerId = _customerId, NameSurname = reader["NameSurname"].ToString(), Telephone = reader["Telephone"].ToString(), Mail = reader["Mail"].ToString(), Country = reader["Country"].ToString(), Tc = _Tc, Address = reader["Address"].ToString() });
                }
                 
                connectionInfo.Close();
                return customer;
            }
        }

       

        public void UpdateCustomer(CustomerDto customerDto)
        {
            using (var ConnectionSave = new SqlConnection(ConnectionString))
            {
                ConnectionSave.Open();

                string updateQuery = "Update Customer set NameSurname = @NameSurname, Telephone= @Telephone, Mail = @Mail, Country = @Country, Tc = @Tc, Address = @Address  where Id = @Id";
                SqlCommand cmd = new SqlCommand(updateQuery, ConnectionSave);

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Id", SqlDbType.Int) { Value = customerDto.CustomerId });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = customerDto.NameSurname });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Telephone", SqlDbType.VarChar, 16) { Value = customerDto.Telephone });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Mail", SqlDbType.NVarChar, 80) { Value = customerDto.Mail });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", SqlDbType.NVarChar, 80) { Value = customerDto.Country });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tc", SqlDbType.VarChar, 11) { Value = customerDto.Tc });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", SqlDbType.NVarChar, 300) { Value = customerDto.Address });
                cmd.ExecuteNonQuery();

                ConnectionSave.Close();

            }
        }
    }
}
