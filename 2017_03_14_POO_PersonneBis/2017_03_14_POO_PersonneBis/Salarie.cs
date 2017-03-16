using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_POO_PersonneBis
{
    public class Salarie : Personne
    {
        private string societe;
        
        /// <summary>
        /// Accesseur en modification
        /// </summary>
        public string Societe
        {
            set
            {
                this.societe = value.ToUpper();
            }
        }
        /// <summary>
        /// Constructeur de salarié
        /// </summary>
        /// <param name="uneSociete"></param>
        public Salarie (string nom, string uneSociete) : base (nom, 0)
        {
            this.Societe = uneSociete;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Je travaille chez " + this.societe);
        }

        public void ChangerAgeSalarie (int unAge)
        {
            
        }
    }
}
