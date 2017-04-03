using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tab = new char[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tab[0, j]= '#';
                    tab[i, 10] = '#';
                }
            }

            for (int j = 10; j < 20; j++)
            {
                tab[10, j] = '#';
            }

            AfficherLettre(tab);
        }

        static void AfficherLettre(char[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
