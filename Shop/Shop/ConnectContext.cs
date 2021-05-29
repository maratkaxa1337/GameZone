using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
     public static class ConnectContext
    {
       public static dbBaseEntities db = new dbBaseEntities();
    }
}
