using Entity_Object;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL
    {
        public OleDbConnection Connected()
        {
            string path = "set_Connection.txt";
            var reader = new StreamReader(path);
            var query = reader.ReadLine();
            OleDbConnection oldbconnection = new OleDbConnection();
            oldbconnection.ConnectionString = query;
            //filename;
            oldbconnection.Open();
            return oldbconnection;
        }
        public List<Staffs> GetStaffFrom_Database()
        {
            var staff = new List<Staffs>();
            OleDbConnection oldbcn = Connected();
            OleDbCommand oldbcmd = new OleDbCommand();
            oldbcmd.Connection = oldbcn;
            oldbcmd.CommandText = "select * from Staffs";
            var er = oldbcmd.ExecuteReader();
            while (er.Read())
            {
                staff.Add(new Staffs(er.GetInt16(0), er.GetString(1), er.GetString(2), er.GetString(3), er.GetDateTime(4), er.GetInt16(5), er.GetString(6), er.GetInt16(7), er.GetString(8)));
            }
            oldbcn.Close();
            return staff;
        }
    }
}
