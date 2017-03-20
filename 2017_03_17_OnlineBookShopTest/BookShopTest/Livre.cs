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
        private int nIsbn;
        private int nNombrePages;
        private int nExemplairesDisponibles;
        private static int nLivresCommandes = 0;
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
            this.StrTitre = strTitre;
            this.StrAuteur = strAuteur;
            this.NIsbn = nIsbn;
            this.NNombrePages = nNombrePages;
            this.NExemplairesDisponibles = nExemplairesDisponibles;
        }
        public int Commander(Livre livre)
        {
            if (livre.NExemplairesDisponibles > 0)
            {
                nLivresCommandes++;
                Console.WriteLine("Vous venez de rajouter au panier : {0} de {1}, merci!", livre.StrTitre, livre.StrAuteur);
                livre.NExemplairesDisponibles--;
                Console.WriteLine("Il reste {0} exemplaire(s) de ce livre", livre.NExemplairesDisponibles);
                Console.WriteLine("Vous avez {0} livres dans le panier", nLivresCommandes);
            }
            else
            {
                OeuvreIndisponibleException oie = new OeuvreIndisponibleException(livre);
                throw oie;
            }
            return nLivresCommandes;
        }
        public static int GetNLivresCommandes()
        {
            return Livre.nLivresCommandes;
        }
        public static int NLivresCommandes
        {
            get { return Livre.NLivresCommandes; }
        }
    }
}
