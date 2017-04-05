using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class SaisieIncorrecteException : Exception
    {
        public SaisieIncorrecteException()
        {
            
        }

        public override string ToString()
        {
            return "Votre saisie est incorrecte, veuillez effectuer une saisie correcte.";
        }

    }
}

