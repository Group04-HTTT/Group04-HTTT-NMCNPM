using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_search;
using DTO_search;

namespace search
{
    public partial class Form1 : Form
    {
        List<DTO> product = new List<DTO>();
        public Form1()
        {
            InitializeComponent();
        }

        //public static string connectionString = @"Data Source=DESKTOP-DC6275B\SQLEXPRESS;Initial Catalog=convinience_store;Integrated Security=True";

        //public DataTable searchProductName(string query, string name)
        //{
        //    DataTable data = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@product_name", name);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(data);
        //        connection.Close();
        //    }
        //    return data;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            BUS bus = new BUS();
            dataGridView1.DataSource = bus.searchProductName(textBox1.Text);
        }
    }
}
