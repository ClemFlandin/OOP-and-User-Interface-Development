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
            bool identiques = a1.CompareTo(a2);
            Console.WriteLine(identiques);
            try
            {
                Livre l1 = new Livre("La vie rêvée des ornithorynques", "Flandin", 12345, 555, 4);
                Livre l2 = new Livre("Do AFPA interns dream of C#?", "Jones", 12356, 444, 1);
                Livre l3 = new Livre("The time of our coding", "Wright", 987654, 666, 42);
            }
            catch (OeuvreIndisponibleException oie)
            {

                Console.WriteLine(oie); ;
            }
            finally
            {
                Console.WriteLine("Merci pour l'intérêt que vous nous portez.");
            }

        }
    }
}
