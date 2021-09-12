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
   public class DrinksRepo
    {
       DatabaseConnectionClass dcc;
       public DrinksRepo()
       {
           dcc = new DatabaseConnectionClass();
       }

       public List<Drinks> GetAllData()
       {
           List<Drinks> listOfDrink = new List<Drinks>();

           string query = "SELECT * from Drinks";

           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               Drinks di = new Drinks();
               di.Did = sdr["Did"].ToString();
               di.Dname = sdr["Dname"].ToString();
               
               di.Dsell = Convert.ToInt32(sdr["Dsell"].ToString());
              // emp.PhnNumber = sdr["PhnNumber"].ToStrings();
             //  emp.Dsell = sdr["Dsell"].ToString();
             //  emp.Designation = sdr["Designation"].ToString();

               listOfDrink.Add(di);
           }

           dcc.CloseConnection();

           return listOfDrink;
       }
    }
}
