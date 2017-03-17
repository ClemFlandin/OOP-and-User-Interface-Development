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
            Auteur a3 = new Auteur("Lee", "Coréen", 34);
            bool identiques = a1.CompareTo(a2);
            Console.WriteLine(identiques);
            try
            {
                Livre l1 = new Livre("La vie rêvée des ornithorynques", "Flandin", 12345, 555, 1);
            }
            catch (OeuvreIndisponibleException oie)
            {

                Console.WriteLine(oie); ;
            }
            finally
            {
                Console.WriteLine("Merci pour l'intérêt que vous nous portez.");
            }
            //Livre l2 = new Livre();
            //Livre l3 = new Livre();
            //Livre l4 = new Livre();
            //Livre l5 = new Livre();
            //Livre l6 = new Livre();
            //Livre l7 = new Livre();
            //Livre l8 = new Livre();
            //Livre l9 = new Livre();
        }
    }
}
