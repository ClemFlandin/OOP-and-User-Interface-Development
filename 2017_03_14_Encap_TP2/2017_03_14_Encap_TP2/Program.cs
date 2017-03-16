using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_Encap_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie salarie = new Salarie();
            salarie.Nom = "Sarkozy";
            salarie.Salaire = 29000;
            Console.WriteLine(salarie.CalculSalaire());

        }
    }
}
