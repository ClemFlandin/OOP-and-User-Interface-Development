using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_Encap_TP1
{
    class Salarie
    {
        public int matricule;
        public int categorie;
        public int service;
        public string nom;
        public double salaire;

        public Salarie (string unNom, double unSalaire)
        {
            this.nom = unNom;
            this.salaire = unSalaire;
        }
        public string CalculerSalaire()
        {
            return "Le salaire de : " + nom + "est de : " + salaire + "euros!";
        }
    }
}
