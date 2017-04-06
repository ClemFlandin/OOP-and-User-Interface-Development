using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    /// <summary>
    /// Interface publique donnant la base de la méthode CompareTo
    /// </summary>
    public interface IComparables
    {
        bool CompareTo(Object obj);
    }
}
