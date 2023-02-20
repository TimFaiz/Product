using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotov.Models
{
    public partial class Product
    {
       public bool IsSale
        {
            get
            {
                if (Sale >= 15)
                    return true;
                else return false;
            }
        }
    }
}
