using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class OeuvreIndisponibleException : Exception
    {
        public OeuvreIndisponibleException(Livre livre) : base(livre.ToString())
        {

        }

        public override string ToString()
        {
            return "Le livre demandé ne compte aucun exemplaire en stock";
        }
    }
}
