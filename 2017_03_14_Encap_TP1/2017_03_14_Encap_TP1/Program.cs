using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_14_Encap_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie salarie = new Salarie ("Dupont", 29000);
            Console.WriteLine(salarie.CalculerSalaire());
        }
    }
}
