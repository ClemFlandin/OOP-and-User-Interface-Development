using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_15_Heritage_TP4
{
    public class Commercial : Salarie
    {
        /// <summary>
        /// Attributs propres à la classe Commercial
        /// </summary>
        private double chiffreAffaire;
        private int commission;

        /// <summary>
        /// Accesseurs des attributs de Commercial
        /// </summary>
        public double ChiffreAffaire
        {
            get
            {
                return this.chiffreAffaire;
            }
            set
            {
                this.chiffreAffaire = value;
            }
        }
        public int Commission
        {
            get
            {
                return this.commission;
            }
            set
            {
                this.commission = value;
            }
        }

        /************************************
        ******** Constructeurs***************
        ************************************/
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Commercial()
        {

        }

        /// <summary>
        /// Constructeur générique
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="categorie"></param>
        /// <param name="service"></param>
        /// <param name="nom"></param>
        /// <param name="salaire"></param>
        /// <param name="chiffreAffaire"></param>
        /// <param name="commission"></param>
        public Commercial(int matricule, int categorie, int service, string nom, double salaire, double chiffreAffaire, int commission)
        {
            Console.WriteLine("Nouveau commercial.");
            this.Matricule = matricule;
            this.Categorie = categorie;
            this.Service = service;
            this.Nom = nom;
            this.Salaire = salaire;
            this.ChiffreAffaire = chiffreAffaire;
            this.Commission = commission;
            if (categorie < 1 || categorie > 3)
            {
                CategorieSalarieException cse = new CategorieSalarieException(this);
                throw cse;
            }
            if (salaire <= 0)
            {
                SalaireSalarieException sse = new SalaireSalarieException(this);
                throw sse;
            }
            Compte++;
            
        }
        /**************************
        **Réécritures de méthodes**
        **************************/
        /// <summary>
        /// Recalcule le salaire en fonction du CA et de la commission
        /// </summary>
        /// <returns></returns>
        public override string CalculSalaire()
        {
            double salaireReel = salaire + chiffreAffaire * commission / 100;
            return "Le salaire réel de " + Nom + " est de : " + salaireReel;
        }
        /// <summary>
        /// Renvoie "true" si les deux commerciaux comparés sont semblables
        /// </summary>
        /// <param name="comm"></param>
        /// <returns></returns>
        public override bool Equals(object comm)
        {
            return base.Equals(comm) ;
        }

        public override string ToString()
        {
            return base.ToString() + ',' + ChiffreAffaire + ',' + Commission;
        }
        /********************
        **  Destructeur    **
        ********************/
        ~Commercial()
        {
            Console.WriteLine("Destruction du commercial");
        }
    }
}
