using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_search;
using System.Data;
using System.Data.SqlClient;
using DAL_search;


namespace BUS_search
{
    public class BUS
    {
        public DataTable searchProductName(string name)
        {
            string query = $"exec search_product_with_name @product_name";
            DAL dal = new DAL();
            return dal.ExecuteQueryName(query, name);
        }

        public DataTable searchProductID(int id)
        {
            string query = $"exec search_product_with_id @product_id";
            DAL dal = new DAL();
            return dal.ExecuteQueryID(query, id);
        }
    }
}
