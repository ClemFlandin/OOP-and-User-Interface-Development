using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_15_Heritage_TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Salarie salarieTest = new Salarie(2, 3, 4, "Joe", 20000);
            //Console.WriteLine(salarieTest.ToString());
            //Salarie salarieTest2 = new Salarie(2, 3, 4, "Joe", 20000);
            //Console.WriteLine(salarieTest.Equals(salarieTest2));
            //Console.WriteLine(salarieTest.CompareTo(salarieTest2));

            //Commercial comm1 = new Commercial(2, 3, 4, "John", 35000, 100000, 20);
            //Console.WriteLine(comm1.CalculSalaire());
            //Console.WriteLine(comm1.ToString());
            //Commercial comm2 = new Commercial(4, 3, 4, "John", 35000, 1000000, 20);
            //Console.WriteLine(comm1.Equals(comm2));

            try
            {
                Salarie s = new Salarie(45, 2, 2, "Bill", 24200);
                Salarie s2 = new Salarie(45, 2, 2, "Bill", 24200);
                Commercial c = new Commercial(8, 1, 7, "John", 563496, 5857, 20);
                Commercial c2 = new Commercial(7, 1, 3, "John", 68768, 5857, 10);
                Console.WriteLine(s.Equals(s2));
                Commercial c3 = new Commercial();
            }
            catch (CategorieSalarieException cse)
            {
                Console.WriteLine(cse); ;
            }
            catch (SalaireSalarieException sse)
            {
                Console.WriteLine(sse);
            }
            catch (SalarieException se)
            {
                Console.WriteLine(se);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
