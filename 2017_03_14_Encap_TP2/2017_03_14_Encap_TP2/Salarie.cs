using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_Encap_TP2
{
    class Salarie
    {
        //Instanciation des attributs de la classe "Salarie"
        private string nom;
        private double salaire;

        //Création des méthodes d'accès aux attributs
        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
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
                this.salaire = value;
            }
        }
        /// <summary>
        /// Méthode qui renvoie le salaire du salarie
        /// </summary>
        /// <returns>"Salaire" de "nom"</returns>
        public string CalculSalaire()
        {
            return "Le salaire de " + this.nom + " est de " + this.salaire + "dollars.";
        }
    }
}
