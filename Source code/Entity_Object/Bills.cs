using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Bills
    {
        public Bills() { }
        public Bills(int Bill_id, Nullable<DateTime> Bill_createdate, Nullable<int> Total_amt, Nullable<decimal> Total_price, Nullable<decimal> Discount, Nullable<decimal> Total_money, Nullable<int> Mem_id)
        {
            bill_id = Bill_id;
            bill_createdate = Bill_createdate;
            total_amt = Total_amt;
            total_price = Total_price;
            discount = Discount;
            total_money = Total_money;
            mem_id = Mem_id;
        }
        public int bill_id { get; set; }
        public Nullable<DateTime> bill_createdate { get; set; }
        public Nullable<int> total_amt { get; set; } //Tổng số lượng đã mua
        public Nullable<decimal> total_price { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> total_money { get; set; }
        public Nullable<int> mem_id { get; set; }
    }
}
