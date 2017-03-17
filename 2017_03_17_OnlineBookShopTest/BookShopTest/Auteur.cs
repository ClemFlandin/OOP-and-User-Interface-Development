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
        private string strNomAuteur;
        private string strNationalite;
        private int nAge;

        /// <summary>
        /// Accesseurs
        /// </summary>
        public string StrNomAuteur
        {
            get
            {
                return this.strNomAuteur;
            }
            set
            {
                this.strNomAuteur = value;
            }
        }
        private string StrNationalite
        {
            get
            {
                return this.strNationalite;
            }
            set
            {
                this.strNationalite = value;
            }
        }
        public int NAge
        {
            get
            {
                return this.nAge;
            }
            set
            {
                this.nAge = value;
            }
        }
        /// <summary>
        /// Constructeur
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
        public virtual bool CompareTo(Object auteur)
        {
            return auteur is Auteur && StrNomAuteur == ((Auteur)auteur).StrNomAuteur && NAge == ((Auteur)auteur).NAge;
        }
        
    }
}
