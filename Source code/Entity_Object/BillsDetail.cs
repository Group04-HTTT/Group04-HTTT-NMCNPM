using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class BillsDetail
    {
        public BillsDetail() { }
        public BillsDetail(int Bill_id, int Product_id, int Number_of_products, decimal Unit_price)
        {
            bill_id = Bill_id;
            product_id = Product_id;
            number_of_products = Number_of_products;
            unit_price = Unit_price;
        }
        public int bill_id { get; set; }
        public int product_id { get; set; }
        public int number_of_products { get; set; }
        public decimal unit_price { get; set; }
    }
}
