using Entity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
   public interface ILoginRepo
    {
        bool InsertUser(Login el);
        bool UpdateUser(Login el);
        bool DeleteUser(Login el);
        Login GetUser(string id, string password);
    }
}
