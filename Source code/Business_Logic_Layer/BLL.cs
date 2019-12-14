using Entity_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class BLL
    {
        public List<Staffs> get_Staff()
        {
            List<Staffs> kq = new List<Staffs>();
            DAL respon = new DAL();
            var Staff_List = respon.GetStaffFrom_Database();
            foreach(var nv in Staff_List)
            {
                kq.Add(nv);
            }
            return kq;
        }    
    }
}
