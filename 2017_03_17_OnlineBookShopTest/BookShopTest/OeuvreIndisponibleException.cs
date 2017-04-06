using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    /// <summary>
    /// Classe implémentant une exception si l'oeuvre ne compte aucun livre disponible
    /// </summary>
    public class OeuvreIndisponibleException : Exception
    {
        /// <summary>
        /// Constructeur de l'exception
        /// </summary>
        /// <param name="livre"></param>
        public OeuvreIndisponibleException(Livre livre) : base(livre.ToString())
        {

        }

        /// <summary>
        /// Override de la méthode tostring
        /// </summary>
        /// <returns>Une phrase indiquant que le livre n'est pas en stock</returns>
        public override string ToString()
        {
            return "Le livre demandé ne compte aucun exemplaire en stock";
        }
    }
}
