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
                Salarie s1 = new Salarie(1, 2, 8, "Bill", 54652);
                Salarie s2 = new Salarie(2, 1, 2, "Bill", 24200);
                Salarie s3 = new Salarie(3, 2, 7, "Simon", 36540);
                Salarie s4 = new Salarie(4, 1, 2, "Georges", 54000);
                Salarie s5 = new Salarie(5, 1, 2, "Jean", 36541);
                Commercial c1 = new Commercial(6, 1, 7, "John", 563496, 5857, 20);
                Commercial c2 = new Commercial(7, 1, 3, "John", 68768, 5857, 10);
                Commercial c3 = new Commercial(8, 1, 3, "Mathieu", 36551, 2134, 10);
                Commercial c4 = new Commercial(9, 1, 3, "Stephen", 68000, 2400, 15);
                Commercial c5 = new Commercial(10, 1, 3, "Rodolph", 68000, 2400, 15);
                Console.WriteLine(s1.Equals(s2));
                Salarie[] salariesTab = new Salarie[] { s1, s2, s3, s4, s5, c1, c2, c3, c4, c5};
                foreach (Salarie salarie in salariesTab)
                {
                    Console.WriteLine("Salarié : {0}, matricule : {1}", salarie.Nom, salarie.Matricule);
                }

                List<Salarie> salariesList = new List<Salarie>() { s1, s2, s3, s4, s5, c1, c2, c3, c4, c5 };
                foreach (Salarie salarie in salariesList)
                {
                    Console.WriteLine($"{salarie.Nom}, matricule : {salarie.Matricule}");
                }

                SortedDictionary<int, Salarie> salariesSD = new SortedDictionary<int, Salarie>()
                    { { s1.Matricule, s1 }, { s2.Matricule, s2 }, { s3.Matricule, s3 }, { s4.Matricule, s4 }, { s5.Matricule, s5 }, { c1.Matricule, c1 },
                        { c2.Matricule, c2 }, { c3.Matricule, c3 }, { c4.Matricule, c4 }, { c5.Matricule, c5 }};
                foreach (KeyValuePair<int ,Salarie> salarie in salariesSD)
                {
                    Console.WriteLine("{0}, {1}", salarie.Key, salarie.Value.Nom);
                }
                salariesSD.Remove(3);
                salariesSD.Remove(7);
                foreach (KeyValuePair<int, Salarie> salarie in salariesSD)
                {
                    Console.WriteLine("{0}, {1}", salarie.Key, salarie.Value.Nom);
                }

                salariesSD.Clear();
                foreach (KeyValuePair<int, Salarie> salarie in salariesSD)
                {
                    Console.WriteLine("{0}, {1}", salarie.Key, salarie.Value.Nom);
                }
                
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
