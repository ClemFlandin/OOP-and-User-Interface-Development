using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    /// <summary>
    /// Classe publique, fille de Oeuv
    /// </summary>
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
        /// Constructeur de Livre en fonction de 5 paramètres
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
        /// <returns>Nombre de livres actuellement au panier</returns>
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
        /// <summary>
        /// Implémentation de l'accès à l'attribut statique de classe _nLivresCommandes
        /// </summary>
        /// <returns></returns>
        public static int GetNLivresCommandes()
        {
            return Livre._nLivresCommandes;
        }
        public static int NLivresCommandes
        {
            get { return Livre.NLivresCommandes; }
        }
        /// <summary>
        /// Implémentation de la méthode CompareTo pour la classe livre
        /// </summary>
        /// <param name="livre"></param>
        /// <returns></returns>
        public virtual bool CompareTo(Livre livre)
        {
            return livre is Livre && StrTitre == ((Livre)livre).StrTitre;
        }
    }
}
