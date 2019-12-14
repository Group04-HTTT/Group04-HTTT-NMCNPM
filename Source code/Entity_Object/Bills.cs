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
        public Bills(int Bill_id, DateTime Modified_date, decimal Total_amt, decimal Total_price, decimal Discount, decimal Total_money, int Staff_id)
        {
            bill_id = Bill_id;
            modified_date = Modified_date;
            total_amt = Total_amt;
            total_price = Total_price;
            discount = Discount;
            total_money = Total_money;
            staff_id = Staff_id;
        }
        public int bill_id { get; set; }
        public DateTime modified_date { get; set; }
        public decimal total_amt { get; set; } //Tổng số lượng đã mua
        public decimal total_price { get; set; }
        public decimal discount { get; set; }
        public decimal total_money { get; set; }
        public int staff_id { get; set; }
    }
}
