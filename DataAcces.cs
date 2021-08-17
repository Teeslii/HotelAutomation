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

namespace hotel
{
    public class DataAcces : IDataAcces
    {

        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;
        public void SaveCustomer(CustomerDto customerDto)
        {
            using (var ConnectionSave = new SqlConnection(ConnectionString))
            {
                ConnectionSave.Open();

                string insertQuery = "Insert into Customer(NameSurname, Telephone, Mail, Country, Tc, Address) values( @NameSurname, @Telephone, @Mail, @Country, @Tc, @Address)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, ConnectionSave);
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = customerDto.NameSurname });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Telephone", SqlDbType.VarChar, 11) { Value = customerDto.Telephone });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Mail", SqlDbType.NVarChar, 80) { Value = customerDto.Mail });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", SqlDbType.NVarChar, 80) { Value = customerDto.Country });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tc", SqlDbType.VarChar, 11) { Value = customerDto.Tc });
                insertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", SqlDbType.NVarChar, 300) { Value = customerDto.Address });
                insertCommand.ExecuteNonQuery();

                ConnectionSave.Close();
            }
        }
    }
}
