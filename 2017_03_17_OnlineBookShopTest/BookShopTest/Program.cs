using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Auteur a1 = new Auteur("Flandin", "Français", 29);
            Auteur a2 = new Auteur("Jones", "Gallois", 42);
            Auteur a3 = new Auteur("Wright", "Américain", 34);
            string strTitre = "Je ne suis pas un codeur";
            int nbPages = 0;
            Oeuvre o1 = new Oeuvre(strTitre, a1.StrNomAuteur);
            Livre l1 = new Livre("La vie rêvée des codeurs", "Flandin", 12345, 555, 4);
            Livre l2 = new Livre("Do AFPA interns dream of C#?", "Jones", 12356, 444, 1);
            Livre l3 = new Livre("The time of our coding", "Wright", 987654, 666, 42);
            Livre l4 = new Livre(strTitre, a1.StrNomAuteur, 456789, 456, 20);
            Livre l5 = new Livre("Coding people are ordinary people", "Wright", 65454, 741, 2);
            Livre l6 = new Livre("C'est beau un codeur qui code", "Flandin", 54684, 365, 8);
            List<Livre> livres = new List<Livre> { l1, l2, l3, l4, l5, l6 };

            foreach (var livre in livres)
            {
                Console.WriteLine(livre.StrTitre);
            }

            string finCommande = "O";

            do
            {
                Console.WriteLine("Quel livre voulez-vous commander? Veuillez rentrer son titre en choisissant parmi la liste ci-dessus:");
                string titreLivre = Console.ReadLine();
                foreach (var livre in livres)
                {
                    if (String.Compare(titreLivre, livre.StrTitre) == 0)
                    {
                        try
                        {
                            livre.Commander(livre);
                            nbPages += livre.NNombrePages;
                        }
                        catch (OeuvreIndisponibleException oie)
                        {
                            Console.WriteLine(oie);
                            Console.WriteLine("Veuillez rentrer un autre titre de livre"); ;
                        }
                    }
                }
                Console.WriteLine("Voulez-vous commander un autre livre (O/N)?");
                finCommande = Console.ReadLine();
            } while (finCommande != "N");

            Console.WriteLine("Merci pour l'intérêt que vous nous portez. Revenez après avoir lu les {0} pages qui vous attendent ! ;)", nbPages);

        }
    }
}
