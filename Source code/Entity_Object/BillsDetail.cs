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
        public BillsDetail(int Bill_id, int Product_id, Nullable<int> Qty, Nullable<decimal> Unit_price)
        {
            bill_id = Bill_id;
            product_id = Product_id;
            qty = Qty;
            unit_price = Unit_price;
        }
        public int bill_id { get; set; }
        public int product_id { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<decimal> unit_price { get; set; }
    }
}
