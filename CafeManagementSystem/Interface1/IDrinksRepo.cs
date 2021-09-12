using Entity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public interface IDrinksRepo
    {
        bool ShowData(Drinks d);
        List<Drinks> GetAllData();
        //bool G
    }
}
