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

            //Instanciation d'auteurs avec la méthode NouvelAuteur
            Console.WriteLine("================================================================================");
            Auteur flandin = new Auteur("Flandin", "Français", 29);
            Auteur jones = new Auteur("Jones", "Gallois", 42);
            Auteur smith = new Auteur("Smith", "Américain", 34);
            Auteur ra = new Auteur("Randriananjakotoramanana", "Malgache", 33);
            List<Auteur> auteurs = new List<Auteur> { flandin, jones, smith, ra };
            Console.WriteLine("================================================================================");
            
            //Instanciation de livres avec la méthode NouveauLivre
            Livre livre1 = new Livre("La vie rêvée des codeurs", "Randriananjakotoramanana", 345, 555, 4);
            Livre livre2 = new Livre("Coders gotta code", "Jones", 356, 444, 1);
            Livre livre3 = new Livre("The time of our coding", "Smith", 9654, 666, 42);
            Livre livre4 = new Livre("Je ne suis pas un codeur", "Flandin", 6789, 456, 20);
            Livre livre5 = new Livre("Coders are ordinary people", "Smith", 454, 741, 2);
            Livre livre6 = new Livre("C'est beau un codeur qui code", "Flandin", 684, 365, 8);
            List<Livre> livres = new List<Livre> { livre1, livre2, livre3, livre4, livre5, livre6 };

            //Nouveau SortedDictionnary avec comme clé un string (le titre du livre) et comme value un livre
            SortedDictionary<string, Livre> sdCatalogue = new SortedDictionary<string, Livre>();

            //Appel de la méthode AfficherLivres pour afficher les livres présents dans la liste livres
            Affichage.AfficherLivres(livres);
            Console.WriteLine();

            //isbn initialisé à 10000, qui sera incrémenté en cas de création de livre
            int isbn = 10000;
            char creation = 'N';
            string strCreation = "incorrect";
            Console.WriteLine();
            Console.WriteLine("================================================================================");
            Console.WriteLine("Voulez-vous créer un nouveau livre, un nouvel auteur? (O/N)");
            do
            {
                
                try
                {
                    while (strCreation.Length != 1)
                    {
                        strCreation = Console.ReadLine();
                        throw new SaisieIncorrecteException();
                    }
                    creation = Convert.ToChar(strCreation);
                }
                catch (SaisieIncorrecteException sie)
                {
                    Console.WriteLine(sie);
                }
                
            } while (creation != 'O' && creation != 'N');


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
                        Affichage.AfficherLivres(livres);
                        string titre = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("Rentrez un auteur parmi la liste suivante : ");
                        Console.WriteLine();
                        Affichage.AfficherNomAuteurs(auteurs);
                        string nomAuteur = Console.ReadLine();
                        try
                        {
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
                            isbn++;
                            Random rndPages = new Random();
                            int pages = rndPages.Next(100, 1000);
                            Random rndDispo = new Random();
                            int dispo = rndDispo.Next(50);
                            Livre nouvLivre = new Livre(titre, nomAuteur, isbn, pages, dispo);
                            livres.Add(nouvLivre);
                        }
                        catch (AuteurInconnuException aie)
                        {
                            Console.WriteLine(aie); ;
                        }
                        break;
                    case ("auteur"):
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("Rentrez un nom d'auteur, une nationalité et un âge :");
                        try
                        {
                            string[] strNvelAuteur = Console.ReadLine().Split();
                            Auteur nvelAuteur = new Auteur(strNvelAuteur[0], strNvelAuteur[1], Convert.ToInt32(strNvelAuteur[2]));
                            bool auteurExiste = false;
                            for (int i = 0; i < auteurs.Count; i++)
                            {
                                if (nvelAuteur.CompareTo(auteurs[i]) == true)
                                {
                                    auteurExiste = true;
                                }
                            }
                            if (auteurExiste == true)
                            {
                                Console.WriteLine("================================================================================");
                                Console.WriteLine("L'auteur rentré existe déjà, annulation de la création de l'auteur.");
                                nvelAuteur = null;
                            }
                            else
                            {
                                auteurs.Add(nvelAuteur);
                            }
                        }
                        catch (SaisieIncorrecteException sie)
                        {
                            Console.WriteLine(sie);
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
                Console.WriteLine("Quel livre voulez-vous commander? Veuillez rentrer son titre en choisissant parmi la liste ci-dessous : ");
                Affichage.AfficherCatalogue(sdCatalogue);
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
                        Console.WriteLine("================================================================================");
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
    }
}
