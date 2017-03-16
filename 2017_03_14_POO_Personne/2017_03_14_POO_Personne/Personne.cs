using System;

namespace _2017_03_14_POO_Personne
{
    class Personne
    {
        //------------------------------------
        // les caractéristiques physiques
        //------------------------------------
        private string nom;
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }    
        }
        private static readonly string pasDeSociete = "?";
        private string societe;
        //---------------------------------------
        // les caractéristiques comportementales
        //---------------------------------------
        // construction d'un objet Personne de société inconnue
        // et de nom correspondant au paramètre nom
        public Personne(string unnom)
        {
            this.nom = unnom.ToUpper();
            this.societe = "?";
        }
        public void IntegrerSociete(string entreprise)
        {
            this.societe = entreprise;
        }
        // permet à Personne de changer de société
        public void ChangerDeSociete(string nouvelleSociete)
        {
            this.societe=nouvelleSociete;
        }      
        
        // affichage des caractéristiques de la personne
        public void Afficher()
        {
            Console.Write("Je m'appelle " + nom);
            if (this.societe.Equals("?"))
            {
                Console.WriteLine(" et je ne suis pas salarié.");
            }
            else
            {
                Console.WriteLine(" et je travaille chez " + this.societe);
            }
            Console.ReadLine(); // pause pour voir le résultat
        }
    }
}