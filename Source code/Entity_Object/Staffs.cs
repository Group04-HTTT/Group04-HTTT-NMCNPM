using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Staffs
    {
        public Staffs() { }
        public Staffs(int Staff_id, string Staff_name, string Staff_phone, string Staff_addr, DateTime Staff_dob, int Staff_type_id, string Staff_socialid, int Staff_gender)
        {
            staff_id = Staff_id;
            staff_name = Staff_name;
            staff_phone = Staff_phone;
//            staff_addr = Staff_addr;
            staff_dob = Staff_dob;
            staff_type_id = Staff_type_id;
            staff_socialid = Staff_socialid;
            staff_gender = Staff_gender;       
        }
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public string staff_phone { get; set; }
//       public string staff_addr { get; set; }
        public DateTime staff_dob { get; set; }
        public int staff_type_id { get; set; }
        public string staff_socialid { get; set; }
        public int staff_gender { get; set; }  // 0: Male 1: Female, 2: Other
    }
}
