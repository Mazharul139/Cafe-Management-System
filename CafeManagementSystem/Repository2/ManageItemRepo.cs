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
   public class ManageItemRepo : IManageItemRepo
    {
       DatabaseConnectionClass dcc;

       public ManageItemRepo()
       {
           dcc = new DatabaseConnectionClass();
       }
       public bool InsertProduct(ManageItems mi)
       {
           string query = "INSERT INTO ManageItems VALUES ('" + mi.ItemId + "','" + mi.ItemName + "','" + mi.ItemPrice + "')";

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
       public bool DeleteProduct(ManageItems mi)
       
       {
           string query = "DELETE from ManageItems WHERE ItemId ='" + mi.ItemId + "'";
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
       //public bool Load
       public ManageItems GetItem(string itemId)
       {
           ManageItems mi = null;
           string query = "SELECT * from ManageItems WHERE ItemId = '" + itemId + "'";

           dcc.ConnectWithDB();
           SqlDataReader sd = dcc.GetData(query);

           while (sd.Read())
           {
               mi = new ManageItems();
               mi.ItemId = sd["ItemId"].ToString();
               mi.ItemName = sd["ItemName"].ToString();
               //.PhnNumber = sdr["PhnNumber"].ToString();
               mi.ItemPrice = Convert.ToDouble(sd["ItemPrice"].ToString());
               //emp.Salary = Convert.ToDouble(sdr["Salary"].ToString());
              // emp.Designation = sdr["Designation"].ToString();
           }

           dcc.CloseConnection();
           return mi;
       }

       public List<ManageItems> GetAllItems()
       {
           List<ManageItems> listOfItems = new List<ManageItems>();

           string query = "SELECT * from ManageItems";

           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               ManageItems mi = new ManageItems();
               mi.ItemId = sdr["ItemId"].ToString();
               mi.ItemName = sdr["ItemName"].ToString();
              // emp.PhnNumber = sdr["PhnNumber"].ToString();
               mi.ItemPrice = Convert.ToDouble(sdr["ItemPrice"].ToString());
               //emp.Designation = sdr["Designation"].ToString();

               listOfItems.Add(mi);
           }

           dcc.CloseConnection();

           return listOfItems;
       }
    }
}
