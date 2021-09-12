using Entity1;
using Interface1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository2
{
   public class SnacksRepo
    {
       DatabaseConnectionClass dcc;
       public SnacksRepo()
       {
           dcc = new DatabaseConnectionClass();
       }
       public List<Snacks> GetAllData()
       {
           List<Snacks> listOfSnacks = new List<Snacks>();

           string query = "SELECT * from Snacks";

           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               Snacks sk = new Snacks();
               sk.Sid = sdr["Sid"].ToString();
               sk.Sname = sdr["Sname"].ToString();

               sk.Ssell = Convert.ToInt32(sdr["Ssell"].ToString());
               // emp.PhnNumber = sdr["PhnNumber"].ToStrings();
               //  emp.Dsell = sdr["Dsell"].ToString();
               //  emp.Designation = sdr["Designation"].ToString();

               listOfSnacks.Add(sk);
           }

           dcc.CloseConnection();

           return listOfSnacks;
       }
    }
}
