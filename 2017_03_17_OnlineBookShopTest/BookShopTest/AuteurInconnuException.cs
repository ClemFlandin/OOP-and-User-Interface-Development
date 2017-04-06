using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    /// <summary>
    /// Implémentation d'une exception interceptant le fait que l'auteur ne soit pas connu
    /// </summary>
    public class AuteurInconnuException : Exception
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public AuteurInconnuException()
        {

        }
        /// <summary>
        /// Override de ToString
        /// </summary>
        /// <returns>Un message indiquant que l'auteur n'existe pas encore</returns>
        public override string ToString()
        {
            return "L'auteur saisi n'existe pas!";
        }
    }
}
