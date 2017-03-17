using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public abstract class Oeuvre
    {
        /// <summary>
        /// Variables privées titre et 
        /// </summary>
        abstract public string StrTitre();
        abstract public string StrAuteur();
        /// <summary>
        /// Accesseurs
        /// </summary>
        
        /// <summary>
        /// Constructeur pour nouvelle oeuvre à partir du titre
        /// </summary>
        /// <param name="strTitre"></param>
        public Oeuvre(string strTitre, string strAuteur)
        {
            Console.Write("Nouvelle oeuvre créée par {0} : ", strAuteur);
            Console.WriteLine(strTitre);
        }

        public Oeuvre()
        {

        }
    }
}
