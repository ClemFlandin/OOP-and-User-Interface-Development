using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class Auteur : IComparables
    {
        /// <summary>
        /// Déclaration variables privées
        /// </summary>
        private string _strNomAuteur;
        private string _strNationalite;
        private int _nAge;

        /// <summary>
        /// Accesseurs
        /// </summary>
        public string StrNomAuteur
        {
            get
            {
                return this._strNomAuteur;
            }
            set
            {
                this._strNomAuteur = value;
            }
        }
        public string StrNationalite
        {
            get
            {
                return this._strNationalite;
            }
            set
            {
                this._strNationalite = value;
            }
        }
        public int NAge
        {
            get
            {
                return this._nAge;
            }
            set
            {
                this._nAge = value;
            }
        }
        /// <summary>
        /// Constructeur avec 3 paramètres
        /// </summary>
        /// <param name="strNomAuteur"></param>
        /// <param name="strNationalite"></param>
        /// <param name="nAge"></param>
        public Auteur(string strNomAuteur, string strNationalite, int nAge)
        {
            Console.Write("Instanciation d'un nouvel auteur ");
            this.StrNomAuteur = strNomAuteur;
            this.StrNationalite = strNationalite;
            this.NAge = nAge;
            Console.WriteLine("{0}, de nationalité : {1}, {2} ans", strNomAuteur, strNationalite, nAge);
        }
        /// <summary>
        /// Constructeur vide 
        /// </summary>
        public Auteur()
        {

        }
        /// <summary>
        /// Implémentation de la méthode CompareTo de l'interface IComparables, pour la classe auteur
        /// </summary>
        /// <param name="auteur"></param>
        /// <returns></returns>
        public virtual bool CompareTo(Object auteur)
        {
            return auteur is Auteur && StrNomAuteur == ((Auteur)auteur).StrNomAuteur && NAge == ((Auteur)auteur).NAge;
        }
        
    }
}
