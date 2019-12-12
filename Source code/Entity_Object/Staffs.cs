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
        public Staffs(int Staff_id, string Staff_name, string Staff_phone, string Staff_addr, Nullable<DateTime> Staff_dob, Nullable<int> Staff_pos, string Staff_socialid, Nullable<int> Staff_gender, string Staff_pass)
        {
            staff_id = Staff_id;
            staff_name = Staff_name;
            staff_phone = Staff_phone;
            staff_addr = Staff_addr;
            staff_dob = Staff_dob;
            staff_pos = Staff_pos;
            staff_socialid = Staff_socialid;
            staff_gender = Staff_gender;
            staff_pass = Staff_pass;
        }
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public string staff_phone { get; set; }
        public string staff_addr { get; set; }
        public Nullable<DateTime> staff_dob { get; set; }
        public Nullable<int> staff_pos { get; set; }
        public string staff_socialid { get; set; }
        public Nullable<int> staff_gender { get; set; }
        public string staff_pass { get; set; }
    }
}
