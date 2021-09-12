
using Entity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
   public interface IEmployeesRepo
    {
    
       bool InsertEmployee(Employees emp);
       bool UpdateEmployee(Employees emp);
       bool DeleteEmployee(Employees emp);
      Employees GetEmployee(string empId);
       List<Employees> GetAllEmployees();
    }
}
