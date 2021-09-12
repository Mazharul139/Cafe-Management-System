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
   public class EmployeesRepo: IEmployeesRepo
    {
       DatabaseConnectionClass dcc;

        public EmployeesRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertEmployee(Employees emp)
        {
            string query = "INSERT into Employees VALUES ('"+emp.EmpId+"', '"+emp.Name+"', '"+emp.PhnNumber+"', "+emp.Salary+", '"+emp.Designation+"')";
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

        public bool DeleteEmployee(Employees emp)
        {
            string query = "DELETE from Employees WHERE EmpId = '" + emp.EmpId + "'";
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

        public bool UpdateEmployee(Employees emp)
        {
            string query = "UPDATE Employees SET Name = '"+emp.Name+"', PhnNumber = '"+ emp.PhnNumber+"', Salary = "+emp.Salary+", Designation = '"+emp.Designation+"' WHERE EmpId = '" + emp.EmpId + "'";
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

        public Employees GetEmployee(string empId)
        {
            Employees emp = null;
            string query = "SELECT * from Employees WHERE EmpId = '" + empId + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                emp = new Employees();
                emp.EmpId = sdr["EmpId"].ToString();
                emp.Name = sdr["Name"].ToString();
                emp.PhnNumber = sdr["PhnNumber"].ToString();
               emp.Salary = Convert.ToDouble(sdr["Salary"].ToString());
                //emp.Salary = Convert.ToDouble(sdr["Salary"].ToString());
                emp.Designation = sdr["Designation"].ToString();
            }

            dcc.CloseConnection();
            return emp;
        }

        public List<Employees> GetAllEmployees()
        {
            List<Employees> listOfEmployee = new List<Employees>();

            string query = "SELECT * from Employees";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Employees emp = new Employees();
                emp.EmpId = sdr["EmpId"].ToString();
                emp.Name = sdr["Name"].ToString();
                emp.PhnNumber = sdr["PhnNumber"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"].ToString());
                emp.Designation = sdr["Designation"].ToString();

                listOfEmployee.Add(emp);
            }

            dcc.CloseConnection();

            return listOfEmployee;
    }
}
}
