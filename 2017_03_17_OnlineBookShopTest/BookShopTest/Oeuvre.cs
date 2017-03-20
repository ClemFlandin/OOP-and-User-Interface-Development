using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class Oeuvre
    {
        /// <summary>
        /// Variables privées titre et nom auteur
        /// </summary>
        private string strTitre;
        private string strAuteur;
        /// <summary>
        /// Accesseurs
        /// </summary>
        public string StrTitre
        {
            get
            {
                return this.strTitre;
            }
            set
            {
                this.strTitre = value;
            }
        }
        public string StrAuteur
        {
            get
            {
                return this.strAuteur;
            }
            set
            {
                this.strAuteur = value;
            }
        }
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
