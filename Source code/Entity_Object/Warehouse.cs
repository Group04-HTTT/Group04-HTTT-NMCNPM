using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Warehouse
    {
        public Warehouse() { }
        public Warehouse(int Product_id, int Product_type_id, int Product_remaning)
        {
            product_id = Product_id;
            product_type_id = Product_type_id;
            product_remaning = Product_remaning;
        }
        public int product_id { get; set; }
        public int product_type_id { get; set; }
        public int product_remaning { get; set; }
    }
}
