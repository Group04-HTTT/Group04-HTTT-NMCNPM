using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Products
    {
        public Products() { }
        public Products(int Prod_id, string Prod_name, decimal Prod_price, int Prodtype_id)
        {
            prod_id = Prod_id;
            prod_name = Prod_name;
            prod_price = Prod_price;       
            prodtype_id = Prodtype_id;

        }
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public decimal prod_price { get; set; }   
        public int prodtype_id { get; set; }
    }
}
