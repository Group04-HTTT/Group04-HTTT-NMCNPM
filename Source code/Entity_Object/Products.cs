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
        public Products(int Prod_id, string Prod_name, Nullable<decimal> Prod_price, string Prod_supply,
            Nullable<int> Stock_instore, Nullable<int> Stock_inwarehouse, Nullable<int> Prodtype_id)
        {
            prod_id = Prod_id;
            prod_name = Prod_name;
            prod_price = Prod_price;
            prod_supply = Prod_supply;
            stock_instore = Stock_instore;
            stock_inwarehouse = Stock_inwarehouse;
            prodtype_id = Prodtype_id;

        }
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public Nullable<decimal> prod_price { get; set; }
        public string prod_supply { get; set; }
        public Nullable<int> stock_instore { get; set; }
        public Nullable<int> stock_inwarehouse { get; set; }
        public Nullable<int> prodtype_id { get; set; }
    }
}
