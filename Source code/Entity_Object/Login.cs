using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Login
    {
        public Login() { }
        public Login(string Username, string Password, int Staff_id)
        {
            username = Username;
            password = Password;
            staff_id = Staff_id;
        }
        public string username { get; set; }
        public string password { get; set; }
        public int staff_id { get; set; }
    }
}
