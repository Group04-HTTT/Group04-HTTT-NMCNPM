using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_search
{
    public class DTO
    {
        public int product_id { get; set; }
        public int product_type_id { get; set; }
        public string product_name { get; set; }
        public double product_price { get; set; }
        public DTO() { }
        //public DTO(int id, int type_id, string name, double price)
        //{
        //    this.product_id = id;
        //    this.product_type_id = type_id;
        //    this.product_name = name;
        //    this.product_price = price;
        //}
    }
}
