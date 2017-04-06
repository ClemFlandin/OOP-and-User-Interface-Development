using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public static class Affichage
    {
        public static void AfficherLivres(List<Livre> livres)
        {
            foreach (Livre livre in livres)
            {
                Console.WriteLine(livre.StrTitre);
                Console.WriteLine();
            }
        }
        public static void AfficherNomAuteurs(List<Auteur> auteurs)
        {
            foreach (Auteur auteur in auteurs)
            {
                Console.WriteLine(auteur.StrNomAuteur);
                Console.WriteLine();
            }
        }

        public static void AfficherCatalogue(SortedDictionary<string, Livre> sdCatalogue)
        {
            foreach (KeyValuePair<string, Livre> livre in sdCatalogue)
            {
                if (livre.Value.NExemplairesDisponibles > 0)
                {
                    Console.WriteLine(livre.Value.StrTitre);
                    Console.WriteLine();
                }
            }
        }
    }
}