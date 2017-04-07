using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    /// <summary>
    /// Classe implémentant une exception interceptant le fait que la saisie est incorrecte
    /// </summary>
    public class SaisieIncorrecteException : FormatException
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public SaisieIncorrecteException()
        {
        }
        /// <summary>
        /// Override de tostring
        /// </summary>
        /// <returns>Un message indiquant que la saisie est incorrecte</returns>
        public override string ToString()
        {
            return "Votre saisie est incorrecte, veuillez effectuer une saisie correcte.";
        }
    }
}
