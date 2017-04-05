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
            //Déclaration de deux listes : une d'auteurs, une de livres
            List<Auteur> auteurs = new List<Auteur>();
            List<Livre> livres = new List<Livre>();

            //Instanciation d'auteurs avec la méthode NouvelAuteur
            Console.WriteLine("================================================================================");
            NouvelAuteur("Flandin", "Français", 29, auteurs);
            NouvelAuteur("Jones", "Gallois", 42, auteurs);
            NouvelAuteur("Smith", "Américain", 34, auteurs);
            NouvelAuteur("Randriananjakotoramanana", "Malgache", 33, auteurs);
            Console.WriteLine("================================================================================");
            
            //Instanciation de livres avec la méthode NouveauLivre
            NouveauLivre("La vie rêvée des codeurs", "Flandin", 345, 555, 4, livres);
            NouveauLivre("Coders gotta code", "Jones", 356, 444, 1, livres);
            NouveauLivre("The time of our coding", "Smith", 9654, 666, 42, livres);
            NouveauLivre("Je ne suis pas un codeur", "Flandin", 6789, 456, 20, livres);
            NouveauLivre("Coders are ordinary people", "Smith", 454, 741, 2, livres);
            NouveauLivre("C'est beau un codeur qui code", "Flandin", 684, 365, 8, livres);

            //Nouveau SortedDictionnary avec comme clé un string
            SortedDictionary<string, Livre> sdCatalogue = new SortedDictionary<string, Livre>();

            //Appel de la méthode AfficherLivres pour afficher les livres présents dans la liste livres
            AfficherLivres(livres);
            Console.WriteLine();

            //isbn initialisé à 10000, qui sera incrémenté en cas de création de livre
            int isbn = 10000;
            char creation = 'N';
            Console.WriteLine();
            Console.WriteLine("================================================================================");
            Console.WriteLine("Voulez-vous créer un nouveau livre, un nouvel auteur? (O/N)");
            creation = Convert.ToChar(Console.ReadLine());
            while (creation == 'O')
            {
                Console.WriteLine();
                Console.WriteLine("================================================================================");
                Console.WriteLine("Que voulez-vous créer?('livre', 'auteur')");
                string nouveau = Console.ReadLine();
                switch (nouveau)
                {
                    case ("livre"):
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("Rentrez un titre non existant!");
                        AfficherLivres(livres);
                        string titre = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("Rentrez un auteur parmi la liste suivante : ");
                        foreach (Auteur auteur in auteurs)
                        {
                            Console.WriteLine($"{auteur.StrNomAuteur}");
                        }
                        string nomAuteur = Console.ReadLine();
                        int compte = 0;
                        for (int i = 0; i < auteurs.Count; i++)
                        {
                            if (auteurs[i].StrNomAuteur != nomAuteur)
                            {
                                compte++;
                            }
                        }
                        if (compte == auteurs.Count)
                        {
                            throw new AuteurInconnuException();
                        }
                        else
                        {
                            isbn++;
                            Random rndPages = new Random();
                            int pages = rndPages.Next(100, 1000);
                            Random rndDispo = new Random();
                            int dispo = rndDispo.Next(50);
                            Livre nouvLivre = new Livre(titre, nomAuteur, isbn, pages, dispo);
                            livres.Add(nouvLivre);
                        }
                        break;
                    case ("auteur"):
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("Rentrez un nom d'auteur, une nationalité et un âge :");
                        string[] strNvelAuteur = Console.ReadLine().Split();
                        Auteur nvelAuteur = new Auteur(strNvelAuteur[0], strNvelAuteur[1], Convert.ToInt32(strNvelAuteur[2]));
                        bool auteurExiste = false;
                        for (int i = 0; i < auteurs.Count; i++)
                        {
                            if (nvelAuteur.CompareTo(auteurs[i])==true)
                            {
                                auteurExiste = true;
                            }
                        }
                        if (auteurExiste==true)
                        {
                            Console.WriteLine("================================================================================");
                            Console.WriteLine("Rentrez un nom d'auteur, une nationalité et un âge :");
                            Console.WriteLine("L'auteur rentré existe déjà, annulation de la création de l'auteur.");
                            nvelAuteur = null;
                        }
                        else
                        {
                            auteurs.Add(nvelAuteur);
                        }
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("Veuillez saisir un terme correct");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("================================================================================");
                Console.WriteLine("Voulez-vous créer un nouveau livre, un nouvel auteur? (O/N)");
                creation = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("================================================================================");
            //Remplissage du sdCatalogue à partir de la liste Livres, la clé étant le titre de chaque livre
            foreach (Livre livre in livres)
            {
                sdCatalogue.Add(livre.StrTitre, livre);
            }

            //Déclaration de deux variable : un char indiquant si la commande est finie (N) ou pas (O) 
            //et un int indiquant la somme des pages de tous les livres commandés
            char finCommande = 'O';
            int nbPages = 0;
            string titreLivre=null;
            
            //Boucles do...while : tant que le client n'indique pas la fin de la commande, on rentre dans la boucle
            do
            {
                //On affiche le catalogue DISPONIBLE puis on demande à l'utilisateur de rentrer le titre du livre qu'il souhaite commander
                Console.WriteLine("Quel livre voulez-vous commander? Veuillez rentrer son titre en choisissant parmi la liste ci-dessous:");
                AfficherCatalogue(sdCatalogue);
                do
                {
                    try
                    {
                        titreLivre = Console.ReadLine();
                        int compte = 0;
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
                                    Console.WriteLine();
                                    Console.WriteLine("================================================================================");
                                    Console.WriteLine(oie);
                                    Console.WriteLine("Veuillez rentrer un autre titre de livre");
                                }
                            }
                            else
                            {
                                compte++;
                            }
                        }
                        if (compte==livres.Count)
                        {
                            throw new SaisieIncorrecteException();
                        }
                    }
                    catch (SaisieIncorrecteException sie)
                    {
                        Console.WriteLine();
                        Console.WriteLine("=================================================================================");
                        Console.WriteLine(sie);
                    }
                } while (sdCatalogue.ContainsKey(titreLivre)== false);
                Console.WriteLine();
                Console.WriteLine("================================================================================");
                Console.WriteLine("Voulez-vous commander un autre livre (O/N)?");
                finCommande = Convert.ToChar(Console.ReadLine());
            } while (finCommande != 'N');
            Console.WriteLine();
            Console.WriteLine("================================================================================");
            Console.WriteLine("Merci pour l'intérêt que vous nous portez. Revenez après avoir lu les {0} pages qui vous attendent ! ;)", nbPages);
        }

        /// <summary>
        /// Méthode statique permettant la création d'un nouvel auteur, s'il n'existe pas déjà
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="nationalite"></param>
        /// <param name="age"></param>
        /// <param name="auteurs"></param>
        static void NouvelAuteur(string nom, string nationalite, int age, List<Auteur> auteurs)
        {
            Auteur auteur = new Auteur(nom, nationalite, age);
            if (auteurs.Contains(auteur)==false)
            {
                auteurs.Add(auteur);
            }
        }

        /// <summary>
        /// Méthode statique permettant la création d'un nouveau livre, s'il n'existe pas déjà
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="auteur"></param>
        /// <param name="isbn"></param>
        /// <param name="nbrePages"></param>
        /// <param name="nExemplairesDisponibles"></param>
        /// <param name="livres"></param>
        static void NouveauLivre(string titre, string auteur, int isbn, int nbrePages, int nExemplairesDisponibles, List<Livre> livres)
        {
            Livre livre = new Livre(titre, auteur, isbn, nbrePages, nExemplairesDisponibles);
            if (livres.Contains(livre)== false)
            {
                livres.Add(livre);
            }
        }

        /// <summary>
        /// Méthode permettant l'affichage des auteurs, par nom de famille
        /// </summary>
        /// <param name="auteurs"></param>
        static void AfficherAuteurs(List<Auteur> auteurs)
        {
            foreach (Auteur auteur in auteurs)
            {
                Console.WriteLine(auteur.StrNomAuteur);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Méthode permettant l'affichage des livres, par titre
        /// </summary>
        /// <param name="livres"></param>
        static void AfficherLivres(List<Livre> livres)
        {
            foreach (Livre livre in livres)
            {
                Console.WriteLine(livre.StrTitre);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Méthode permettant l'affichage du catalogue, par titre de livre DISPONIBLE
        /// </summary>
        /// <param name="sdCatalogue"></param>
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
