using Entity1;
using Interface1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository1
{
   public class LoginRepo :ILoginRepo
    {
         DatabaseConnectionClass dcc;

       public LoginRepo()
       {
           dcc = new DatabaseConnectionClass();
       }
       public bool InsertUser(Login el)
       {
           string query= "Insert into Login values ('"+ el.Id +"','"+el.Password +"')";
           try
           {
               dcc.ConnectWithDB();
               int n = dcc.ExecuteSQL(query);
               return true;

           }
           catch (Exception exp)
           {
               return false;
           }
           finally
           {
               dcc.CloseConnection();
           }
 
       }
       public bool DeleteUser(Login el)
       {
           string query = "Delete from Login where Id = '" + el.Id + "'";
           try
           {
               dcc.ConnectWithDB();
               int n = dcc.ExecuteSQL(query);
               dcc.CloseConnection();
               return true;

           }
           catch (Exception exp)
           {
               return false;
           }
       }
          public bool UpdateUser(Login el)
          {
              string query = "Update Login SET Password = '"+el.Password+"' WHERE Id = '"+el.Id+"'";
              try
           {
               dcc.ConnectWithDB();
               int n = dcc.ExecuteSQL(query);
               dcc.CloseConnection();
               return true;

           }
           catch (Exception exp)
           {
               return false;
           }

          }

          public Login GetUser(string id, string password)
          {
              Login el = null;
              string query = "SELECT * from Login WHERE Id = '" + id + "' AND Password = '" + password + "'";
              dcc.ConnectWithDB();
              SqlDataReader sdr = dcc.GetData(query);

              while (sdr.Read())
              {
                  el = new Login();
                  el.Id = sdr["Id"].ToString();
                  el.Password = sdr["Password"].ToString();
                  el.Role = Convert.ToInt32(sdr["Role"]);
              }

              dcc.CloseConnection();

              return el;
          }
    }
}
