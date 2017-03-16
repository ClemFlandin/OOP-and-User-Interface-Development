using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_POO_PersonneBis
{
    public class Personne
    {
        private string nom; //nom de la personne
        private int age; // son age

        /// <summary>
        /// Accesseur en écriture simple
        /// </summary>
        private int Age
        {
            set
            {
                this.age = value;
            }
        }
        
        /// <summary>
        /// Constructeur avec deux paramètres
        /// </summary>
        /// <param name="unNom"></param>
        /// <param name="unAge"></param>
        public Personne(string unNom, int unAge)
        {
            this.nom = unNom.ToUpper();
            if (age!=0)
            {
                this.Age = unAge;
            }
        }
        
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Personne()
        {
            this.nom = "Nom inconnu";
            this.age = 0;
        }
        /// <summary>
        /// Affiche le nom et l'age de la personne
        /// </summary>
        public virtual void Afficher()
        {
            Console.WriteLine("Je m'appelle " + this.nom);
            if(this.age != 0)
            {
                Console.WriteLine("et j'ai " + this.age + " ans");
            }
        }
    }
}
