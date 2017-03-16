using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_Encap_TP3
{
    public class Salarie 
    {
        private static int Compte = 0;
        private string nom;
        private double salaire;

        public string Nom { get; set; }

        public double Salaire { get; set; }

        public Salarie(string nom)
        {
            Console.WriteLine("Instanciation d'un nouveau salarie");
            this.Nom = nom;
            this.Salaire = salaire;
            Compte++;
            
        }
        public static int GetCompte()
        {
            return Salarie.Compte;
        }
        public static int NombreSalaries
        {
            get { return Salarie.Compte; }
        }

        ~Salarie()
        {
            Console.WriteLine("Destruction de l''objet' salarie");
            
            Salarie.Compte--;
            Console.WriteLine("L'entreprise compte désormais {0} salarie", Compte);
        }
    }
}
