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
            List<Auteur> auteurs = new List<Auteur>();
            List<Livre> livres = new List<Livre>();

            NouvelAuteur("Flandin", "Français", 29, auteurs);
            NouvelAuteur("Jones", "Gallois", 42, auteurs);
            NouvelAuteur("Wright", "Américain", 34, auteurs);
            
            NouveauLivre("La vie rêvée des codeurs", "Flandin", 12345, 555, 4, livres);
            NouveauLivre("Coders gotta code", "Jones", 12356, 444, 1, livres);
            NouveauLivre("The time of our coding", "Wright", 987654, 666, 42, livres);
            NouveauLivre("Je ne suis pas un codeur", "Flandin", 456789, 456, 20, livres);
            NouveauLivre("Coders are ordinary people", "Wright", 65454, 741, 2, livres);
            NouveauLivre("C'est beau un codeur qui code", "Flandin", 54684, 365, 8, livres);

            SortedDictionary<string, Livre> sdCatalogue = new SortedDictionary<string, Livre>();
            foreach (Livre livre in livres)
            {
                sdCatalogue.Add(livre.StrTitre, livre);
            }
            
            NouvelAuteur("Randrianjadakotoramanana", "Malgache", 33, auteurs);

            AfficherLivres(livres);

            char finCommande = 'O';
            int nbPages = 0;
            do
            {
                Console.WriteLine("Quel livre voulez-vous commander? Veuillez rentrer son titre en choisissant parmi la liste ci-dessous:");
                AfficherCatalogue(sdCatalogue);
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
                finCommande = Convert.ToChar(Console.ReadLine());
            } while (finCommande != 'N');

            Console.WriteLine("Merci pour l'intérêt que vous nous portez. Revenez après avoir lu les {0} pages qui vous attendent ! ;)", nbPages);

        }

        static void NouvelAuteur(string nom, string nationalite, int age, List<Auteur> auteurs)
        {
            Auteur auteur = new Auteur(nom, nationalite, age);
            if (auteurs.Contains(auteur)==false)
            {
                auteurs.Add(auteur);
            }
        }

        static void NouveauLivre(string titre, string auteur, int isbn, int nbrePages, int nExemplairesDisponibles, List<Livre> livres)
        {
            Livre livre = new Livre(titre, auteur, isbn, nbrePages, nExemplairesDisponibles);
            if (livres.Contains(livre)== false)
            {
                livres.Add(livre);
            }
        }

        static void AfficherAuteurs(List<Auteur> auteurs)
        {
            foreach (Auteur auteur in auteurs)
            {
                Console.WriteLine(auteur.StrNomAuteur);
                Console.WriteLine();
            }
        }

        static void AfficherLivres(List<Livre> livres)
        {
            foreach (Livre livre in livres)
            {
                Console.WriteLine(livre.StrTitre);
                Console.WriteLine();
            }
        }

        static void AfficherCatalogue(SortedDictionary<string, Livre> sdCatalogue)
        {
            foreach (KeyValuePair<string, Livre> livre in sdCatalogue)
            {
                if (livre.Value.NExemplairesDisponibles>0)
                {
                    Console.WriteLine(livre.Value.StrTitre);
                    Console.WriteLine();
                }
            }
        }
    }
}
