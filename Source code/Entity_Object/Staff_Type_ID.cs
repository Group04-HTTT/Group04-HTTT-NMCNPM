using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Staff_Type_ID
    {
        public Staff_Type_ID() { }
        public Staff_Type_ID(int Staff_type_id, string Staff_type_name)
        {
            staff_type_id = Staff_type_id;
            staff_type_name = Staff_type_name;
        }
        public int staff_type_id { get; set; }
        public string staff_type_name { get; set; }
    }
}
