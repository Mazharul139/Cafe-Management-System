using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository1
{
   public class DatabaseConnectionClass
    {
         private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DatabaseConnectionClass()
        {
            // string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\AIUB Teaching\12. Fall 19\OOP2 Codes\I\SampleManagementSystem\fallsampledb.mdf;Integrated Security=True;Connect Timeout=30";  //paste the connection string between the ""
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\CafeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30";  //paste the connection string between the ""
            myConnection = new SqlConnection(connectionString);
        }

        public void ConnectWithDB()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
            return myCommand.ExecuteReader();
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //int x= myCommand.ExecuteNonQuery();
            //return x;
            return myCommand.ExecuteNonQuery();
        }
    
    
    }
}
