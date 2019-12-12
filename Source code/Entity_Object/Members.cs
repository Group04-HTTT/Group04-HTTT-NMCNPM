using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Members
    {
        public Members() { }
        public Members(int Mem_id, string Mem_name, string Mem_phone, string Mem_addr, Nullable<DateTime> Mem_dob, string Mem_socialid, Nullable<int> Mem_point, Nullable<int> Mem_gender)
        {
            mem_id = Mem_id;
            mem_name = Mem_name;
            mem_phone = Mem_phone;
            mem_addr = Mem_addr;
            mem_dob = Mem_dob;
            mem_socialid = Mem_socialid;
            mem_point = Mem_point;
            mem_gender = Mem_gender;
            
        }
        public int mem_id { get; set; }
        public string mem_name { get; set; }
        public string mem_phone { get; set; }
        public string mem_addr { get; set; }
        public Nullable<DateTime> mem_dob { get; set; }
        public string mem_socialid { get; set; }
        public Nullable<int> mem_point { get; set; }
        public Nullable<int> mem_gender { get; set; } // 0:male, 1: female, 2: other
    }
}
