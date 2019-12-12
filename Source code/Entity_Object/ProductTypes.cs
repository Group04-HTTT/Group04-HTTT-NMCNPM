using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class ProductTypes
    {
        public ProductTypes() { }
        public ProductTypes(int Prodtype_id, string Prodtype_name)
        {
            prodtype_id = Prodtype_id;
            prodtype_name = Prodtype_name;
        }
        public int prodtype_id { get; set; }
        public string prodtype_name { get; set; }
    }
}
