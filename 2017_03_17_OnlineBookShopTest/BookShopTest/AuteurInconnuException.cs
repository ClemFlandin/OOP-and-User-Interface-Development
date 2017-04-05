using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class AuteurInconnuException : Exception
    {
        public AuteurInconnuException()
        {

        }

        public override string ToString()
        {
            return "L'auteur saisi n'existe pas!";
        }
    }
}
