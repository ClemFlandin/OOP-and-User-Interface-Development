using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_POO_Personne
{
    class Program
    {

        static void Main(string[] args)
        {
            Personne p1 = new Personne("Clement NALDINF");
            p1.IntegrerSociete("AFPA");
            p1.Afficher();
            Personne p2 = new Personne("Nadia ALTESSE");
            p2.IntegrerSociete("Femme au foyer SARL");
            p2.Afficher();
            p2.ChangerDeSociete("Aide aux devoirs SARL");
            p2.Afficher();

        }
    }
}
