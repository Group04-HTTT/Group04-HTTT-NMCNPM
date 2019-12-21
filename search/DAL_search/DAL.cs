using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_search;

namespace DAL_search
{
    public class DAL
    {
        public static string connectionString = @"Data Source=DESKTOP-DC6275B\SQLEXPRESS;Initial Catalog=convinience_store;Integrated Security=True";
        public List<DTO> product =new List<DTO>();

        public DataTable ExecuteQueryName(string query, string name)
        {
            DataTable data = new DataTable();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@product_name", name);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public DataTable ExecuteQueryID(string query, int id)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@product_id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
