using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_15_Heritage_TP4
{
    public class Salarie: Personne, IRemunerable, IComparable
    {
        /// <summary>
        /// Attribut de classe
        /// </summary>
        protected static int Compte = 0;

        /// <summary>
        /// Attributs d'instances
        /// </summary>
        protected int matricule;
        protected int categorie;
        protected int service;
        protected double salaire;
        
        /// <summary>
        /// Accesseurs
        /// </summary>
        public int Matricule
        {
            get
            {
                return this.matricule;
            }
            set
            {
                this.matricule = value;
            }
        }

        public int Categorie
        {
            get
            {
                return this.categorie;
            }
            set
            {
                this.categorie = value;
            }
        }

        public int Service
        {
            get
            {
                return this.service;
            }
            set
            {
                this.service = value;
            }
        }

        public double Salaire
        {
            get
            {
                return this.salaire;
            }
            set
            {
                if(value<=0)
                {
                    SalaireSalarieException sse = new SalaireSalarieException(this);
                    throw sse;
                }
                this.salaire = value;
            }
        }

        /// <summary>
        /// Constructeur générique
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="categorie"></param>
        /// <param name="service"></param>
        /// <param name="nom"></param>
        /// <param name="salaire"></param>
        public Salarie(int matricule, int categorie, int service, string nom, double salaire)
        {
            Console.WriteLine("Instanciation d'un nouveau salarie");
            this.Matricule = matricule;
            this.Categorie = categorie;
            this.Service = service;
            this.Nom = nom;
            this.Salaire = salaire;
            if (categorie<1||categorie>3)
            {
                CategorieSalarieException cse = new CategorieSalarieException(this);
                throw cse;
            }
            if (salaire<=0)
            {
                SalaireSalarieException sse = new SalaireSalarieException(this);
                throw sse;
            }
            Compte++;
        }
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Salarie()
        {

        }


        /// <summary>
        /// Méthode de retour de salaire
        /// </summary>
        /// <returns>le salaire</returns>

        public virtual bool CompareTo(Object sal)
        {
            return sal is Salarie && Nom == ((Salarie)sal).Nom && matricule == ((Salarie)sal).matricule
                                  && Categorie == ((Salarie)sal).Categorie && service == ((Salarie)sal).service
                                  && Salaire == ((Salarie)sal).Salaire;
        }

        public virtual string CalculSalaire()
        {
            return "Le salaire de " + Nom + " est de " + this.salaire + "dollars.";
        }
        /// <summary>
        /// Méthode pour compter les salariés
        /// </summary>
        /// <returns>le nombre de salariés</returns>
        public static int GetCompte()
        {
            return Salarie.Compte;
        }
        public static int NombreSalaries
        {
            get { return Salarie.Compte; }
        }

        /// <summary>
        /// Réécriture de la méthode "Equals"
        /// </summary>
        /// <param name="sal"></param>
        /// <returns></returns>
        public override bool Equals(Object sal)
        {
            return sal is Salarie && Nom == ((Salarie)sal).Nom && matricule == ((Salarie)sal).matricule;
        }
        
        /// <summary>
        /// Réécriture de la méthode "ToString"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Matricule + "," + Categorie + "," + Service + "," + Nom + "," + Salaire;
        }
        
        /// <summary>
        /// Destructeur de Salarié
        /// </summary>
        ~Salarie()
        {
            Console.WriteLine("Destruction de l''objet' salarie");
            Compte--;
            if (Compte>0)
            {
                Console.WriteLine("L'entreprise compte désormais {0} salarie", Compte);
            }
            else
            {
                Console.WriteLine("L'entreprise ne compte plus aucun salarié.");
            }
        }
    }
}
