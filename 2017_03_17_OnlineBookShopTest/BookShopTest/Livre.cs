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
        /// Déclaration variables privées
        /// </summary>
        private int _nIsbn;
        private int _nNombrePages;
        private int _nExemplairesDisponibles;
        private static int _nLivresCommandes = 0;
        /// <summary>
        /// Accesseurs
        /// </summary>
        public int NIsbn
        {
            get
            {
                return this._nIsbn;
            }
            set
            {
                this._nIsbn = value;
            }
        }
        public int NNombrePages
        {
            get
            {
                return this._nNombrePages;
            }
            set
            {
                this._nNombrePages = value;
            }
        }
        public int NExemplairesDisponibles
        {
            get
            {
                return this._nExemplairesDisponibles;
            }
            set
            {
                this._nExemplairesDisponibles = value;
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
        /// <summary>
        /// Méthode permettant de commander un livre
        /// </summary>
        /// <param name="livre"></param>
        /// <returns></returns>
        public int Commander(Livre livre)
        {
            if (livre.NExemplairesDisponibles > 0)
            {
                _nLivresCommandes++;
                Console.WriteLine("Vous venez de rajouter au panier : {0} de {1}, merci!", livre.StrTitre, livre.StrAuteur);
                livre.NExemplairesDisponibles--;
                Console.WriteLine("Il reste {0} exemplaire(s) de ce livre", livre.NExemplairesDisponibles);
                Console.WriteLine("Vous avez {0} livres dans le panier", _nLivresCommandes);
            }
            else
            {
                OeuvreIndisponibleException oie = new OeuvreIndisponibleException(livre);
                throw oie;
            }
            return _nLivresCommandes;
        }
        public static int GetNLivresCommandes()
        {
            return Livre._nLivresCommandes;
        }
        public static int NLivresCommandes
        {
            get { return Livre.NLivresCommandes; }
        }
    }
}
