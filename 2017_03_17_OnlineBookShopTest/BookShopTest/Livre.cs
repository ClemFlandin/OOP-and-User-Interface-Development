using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class Livre : Oeuvre
    {
        /// <summary>
        /// Déclaration variables
        /// </summary>
        private string strAuteur;
        private string strTitre;
        private int nIsbn;
        private int nNombrePages;
        private int nExemplairesDisponibles;
        private static int nLivresCommandes=0;
        /// <summary>
        /// Accesseurs
        /// </summary>
        public int NIsbn
        {
            get
            {
                return this.nIsbn;
            }
            set
            {
                this.nIsbn = value;
            }
        }
        public int NNombrePages
        {
            get
            {
                return this.nNombrePages;
            }
            set
            {
                this.nNombrePages = value;
            }
        }
        public int NExemplairesDisponibles
        {
            get
            {
                return this.nExemplairesDisponibles;
            }
            set
            {
                this.nExemplairesDisponibles = value;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="strTitre"></param>
        /// <param name="strAuteur"></param>
        /// <param name="nIsbn"></param>
        /// <param name="nNombrePages"></param>
        /// <param name="nExemplairesDisponibles"></param>
        public Livre(string strTitre, string strAuteur, int nIsbn, int nNombrePages, int nExemplairesDisponibles)
        {
            this.NIsbn = nIsbn;
            this.NNombrePages = nNombrePages;
            this.NExemplairesDisponibles = nExemplairesDisponibles;
            if (nExemplairesDisponibles<=0)
            {
                OeuvreIndisponibleException oie = new OeuvreIndisponibleException(this);
                throw oie;
            }
            Console.WriteLine("Vous venez de rajouter au panier : {0} de {1}, merci!", strTitre, strAuteur);
            nLivresCommandes++;
            nExemplairesDisponibles--;
            Console.WriteLine("Il reste {0} exemplaire(s) de ce livre", nExemplairesDisponibles);
        }

        public static int GetNLivresCommandes()
        {
            return Livre.nLivresCommandes;
        }
        public static int NLivresCommandes
        {
            get
            {
                return Livre.nLivresCommandes;
            }
        }
        public override string StrAuteur()
        {
            return strAuteur;
        }
        public override string StrTitre()
        {
            return strTitre;
        }
    }
}
