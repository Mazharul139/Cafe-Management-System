﻿using Entity1;
using Interface1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository2
{
    public class LoginRepo : ILoginRepo
    {
        DatabaseConnectionClass dcc;

        public LoginRepo() { dcc = new DatabaseConnectionClass(); }

        public bool InsertUser(Login l)
        {
            string query = "INSERT into Login Values ('" + l.Id + "', '" + l.Password + "', " + l.Role + ")";
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

        public bool DeleteUser(Login l)
        {
            string query = "DELETE from Login WHERE Id = '" + l.Id + "'";

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

        public bool UpdateUser(Login l)
        {
            string query = "Update Login SET Password = '" + l.Password + "', Role = '" + l.Role + "' WHERE Id = '" + l.Id + "'";

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
            Login l = null;
            string query = "SELECT * from Login WHERE Id = '" + id + "' AND Password = '" + password + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                l = new Login();
                l.Id = sdr["Id"].ToString();
                l.Password = sdr["Password"].ToString();
                l.Role = Convert.ToInt32(sdr["Role"]);
            }

            dcc.CloseConnection();

            return l;
        }
    }
}