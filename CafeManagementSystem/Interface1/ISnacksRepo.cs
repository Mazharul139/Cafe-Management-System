using Entity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
   public interface ISnacksRepo
    {
       bool ShowData(Snacks sk);
       List<Snacks> GetAllData();
    }
}
