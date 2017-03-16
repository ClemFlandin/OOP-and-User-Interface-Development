using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_Encap_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie sal = new Salarie("Sarko");
            Salarie sal2 = new Salarie("Fillon");
            Salarie sal3 = new Salarie("Copé");
            Salarie sal4 = new Salarie("Juppé");
            Salarie sal5 = new Salarie("Valls");
            Salarie sal6 = new Salarie("Hamon");
            Salarie sal7 = new Salarie("Macron");
            Salarie sal8 = new Salarie("Poutou");
            Salarie sal9 = new Salarie("Le Pen");
            int salaries = Salarie.NombreSalaries;
            sal = null;
            sal2 = null;
            sal3 = null;
            sal4 = null;
            sal5 = null;
            sal6 = null;
            sal7 = null;
            sal8 = null;
            sal9 = null;

            Console.WriteLine("L'entreprise a : {0} salaries!", salaries);
        }
    }
}
