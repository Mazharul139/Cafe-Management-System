using Entity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
   public interface IManageItemRepo
    {
       bool InsertProduct(ManageItems mi);
       bool DeleteProduct(ManageItems mi);
       ManageItems GetItem(string itemId);
       List<ManageItems> GetAllItems();
    }
}
