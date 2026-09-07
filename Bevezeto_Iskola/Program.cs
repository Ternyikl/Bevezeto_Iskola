using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevezeto_Iskola
{
    internal class Program
    {
        static Random rnd = new Random();
        static void F01()
        {
            string nev = "Ben Dover";

            int eletkor = 24;

            long magassag = 182;

            double ev_vegi_atlag = 4.9;

            bool sikeres_vizsga = true;

            Console.WriteLine($"{nev}, {eletkor} éve, {magassag} magas, {ev_vegi_atlag} az év végi átlaga, {(sikeres_vizsga ? "sikeres lett a vizsgája" : "sikertelen vizsga")}");

            Console.Write("Adja meg a nevet:");
            nev = Console.ReadLine();
            Console.Write("Adja meg az életkort: ");
            eletkor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a magasságát: ");
            magassag = Convert.ToInt64(Console.ReadLine());
            Console.Write("Adja meg az átlagát: ");
            ev_vegi_atlag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a vizsga sikerességét: ");
            sikeres_vizsga = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"{nev}, {eletkor} éve, {magassag} magas, {ev_vegi_atlag} az év végi átlaga, {(sikeres_vizsga ? "sikeres lett a vizsgája" : "sikertelen vizsga")}");
        }

        static void F03()
        {
            int pontszam = -1;

            do
            {
                Console.Write("Adja meg a dolgozat eredményét: ");
                pontszam = Convert.ToInt32(Console.ReadLine());
            } while (pontszam < 0 || pontszam > 100);

            if(pontszam > 85)
            {
                Console.WriteLine($"5 (jeles)");
            }
            else if (pontszam > 70)
            {
                Console.WriteLine($"4 (jó)");
            }
            else if (pontszam > 55)
            {
                Console.WriteLine($"3 (közepes)");
            }
            else if (pontszam > 40)
            {
                Console.WriteLine($"2 (elégséges)");
            }
            else if (pontszam <= 39)
            {
                Console.WriteLine($"1 (elégtelen)");
            }

        }

        static void F04()
        {
            Console.Write("Adjon meg egy pozíív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            int osszeg = 0;

            string ki = "";

            int szamlalo = 0;

            int legnagyobb = 0;

            for (int i = 2; i < szam; i+=2)
            {
                osszeg += i;
                ki += $"{i}, ";
                szamlalo++;
                legnagyobb = i;
            }

            Console.WriteLine($"{ki}\n összeg: {osszeg},\n összes használt szám: {szamlalo},\n Legnagyobb páros szám: {legnagyobb}");

            osszeg = 0;

            ki = "";

            szamlalo = 0;

            legnagyobb = 0;

            int seged = 2;

            while(szam > seged)
            {
                osszeg += seged;
                ki += $"{seged}";
                szamlalo++;
                legnagyobb = seged;
                seged += 2;

                if (seged < szam)
                {
                    ki += ", ";
                }
            }

            Console.WriteLine($"{ki},\n összeg: {osszeg},\n összes használt szám: {szamlalo},\n Legnagyobb páros szám: {legnagyobb}");
        }

        static void F05()
        {
            int szam = rnd.Next(1, 101);

            int tipp;

            List<int> list = new List<int>();

            Console.WriteLine("A program gondolt egy számra 1 és 100 között,");
            //Console.WriteLine(szam);

            do 
            {
                Console.Write("Tippeljen: ");
                tipp = Convert.ToInt32(Console.ReadLine());

                if(list.Contains(tipp))
                {
                    Console.WriteLine("Ezt már egyszer probáltad!");
                }
                else
                {
                    if (tipp < szam)
                    {
                        Console.WriteLine($"A kereset szám nagyobb mint {tipp}.");
                    }
                    else if(tipp > szam)
                    {
                        Console.WriteLine($"A kereset szám kisebb mint {tipp}.");
                    }
                    else
                    {
                        Console.WriteLine($"Gratulálunk a kereset szám {tipp} volt!");
                    }
                }
                list.Add(tipp);
            } while (szam != tipp);
        }

        static void F06()
        {
            int[] szamok = new int[15];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(-100, 101);
            }

            string ki = "";

            for (int i = 0; i < 15; i++)
            {
                ki += szamok[i];
                if(i < szamok.Length -1)
                {
                    ki += ", ";
                }
            }

            Console.WriteLine(ki);

            Console.WriteLine($"Számok összeg: {szamok.Sum()}");
            Console.WriteLine($"Számok átlaga: {szamok.Average()}");
            Console.WriteLine($"Legkisebb szám: {szamok.Min()}");
            Console.WriteLine($"Legnagyobb szám: {szamok.Max()}");

            int osszespoz = 0;

            foreach (int i in szamok)
            {
                if (i > 0) 
                {
                    osszespoz++;
                }
            }
            Console.WriteLine($"Összes pozítiv szám: {osszespoz}");

            int osszesneg = 0;

            foreach (int i in szamok)
            {
                if (i < 0)
                {
                    osszesneg++;
                }
            }
            Console.WriteLine($"Összes negatív szám: {osszesneg}");

            int osszespar = 0;

            foreach (int i in szamok)
            {
                if (i %2 == 0)
                {
                    osszespar++;
                }
            }
            Console.WriteLine($"Összes páros szám: {osszespar}");

            //Rendező algoritmus

            //közvetlen kiválasztás
            //for (int i = 0; i < szamok.Length-1; i++)
            //{
            //    for (int j = i+1; j < szamok.Length; j++)
            //    {
            //        if (szamok[j] < szamok[i])
            //        {
            //            int seged = szamok[i];
            //            szamok[i] = szamok[j];
            //            szamok[j] = seged;
            //        }
            //    }
            //}

            //buborékos
            for (int i = 0; i < szamok.Length - 1; i++)
            {
                for (int j = szamok.Length-1; j > i; j--)
                {
                    if (szamok[j] < szamok[j -1])
                    {
                        if (szamok[j] < szamok[j - 1])
                        {
                            int seged = szamok[j];
                            szamok[j] = szamok[j - 1];
                            szamok[j - 1] = seged;
                        }
                    }
                }
            }


            foreach (int i in szamok)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }

        static void SW01(List<string> tanulok, string nev)
        {
            Console.Write("Adja meg az új tanuló nevét: ");
            nev = Console.ReadLine();

            if (!tanulok.Contains(nev))
            {
                tanulok.Add(nev);
                Console.WriteLine($"{nev} hozzá lett addva a tanulók listájához!");
            }
            else
            {
                Console.WriteLine("Ez a tanuló már szerepel a listában!");
            }
        }

        static void SW02(List<string> tanulok, string nev)
        {
            Console.Write("Adja meg a törölni kivánt tanuló nevét: ");
            nev = Console.ReadLine();

            if (tanulok.Contains(nev))
            {
                tanulok.Remove(nev);
                Console.WriteLine($"{nev} törölve lett a tanulók listájáből!");
            }
            else
            {
                Console.WriteLine("Ez a tanuló már nem szerepel a listában!");
            }
        }

        static void SW03(List<string> tanulok, string nev)
        {
            Console.Write("Adja meg a kereset tanuló nevét: ");
            nev = Console.ReadLine();

            if (tanulok.Contains(nev))
            {
                Console.WriteLine($"{nev} szerepel tanulók listájában!");
            }
            else
            {
                Console.WriteLine($"{nev} nem szerepel tanulók listájában!");
            }
        }
        static void SW06(List<string> tanulok, string nev)
        {
            foreach (var item in tanulok)
            {
                Console.Write($"{item}\n");
            }
        }

        static void F07()
        {
            List<string> tanulok = new List<string>();
            bool kilep = false;

            do
            {
                Console.WriteLine("Tanulok listája,\n1. Új tanuló hozzá adása\n2. Tanuló törlése\n3. Szereppel-e a tanuló a listában\n4.Tanulók száma\n5. Tanulók ABC sorrenbe rendezése\n6. Tanulok kilistázása\n7. Kilépés\n");
                Console.Write("Bemenet: ");
                string be = Console.ReadLine().First().ToString();
                Console.WriteLine();

                string nev = "";

                switch (be)
                {
                    case "1":
                        SW01(tanulok, nev);
                        break;

                    case "2":
                        SW02(tanulok, nev);
                        break;
                        
                    case "3":
                        SW03(tanulok, nev);
                        break;
                        
                    case "4":
                        Console.WriteLine($"{tanulok.Count} tanuló van a tanulók listában");
                        break;
                        
                    case "5":
                        tanulok.Sort();
                        Console.WriteLine("A tanulók névsorba lettek rendezve!");
                        break;
                        
                    case "6":
                        SW06(tanulok, nev);
                        break;

                    case "7":
                        Console.WriteLine("Kilépés...");
                        kilep = true;
                        break;

                    default:
                        Console.WriteLine("Az értelmezett bemenetek a lista sorszámai!");
                        break;
                }
                Console.WriteLine();

            }while (!kilep);
        }

        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();

            tanulok.Add(new Tanulo("Anna", 2001, 4.5, "14/b"));
            tanulok.Add(new Tanulo("Bea", 2003, 3.5, "12/c"));
            tanulok.Add(new Tanulo("Claire", 2005, 4.7, "11/a"));
            tanulok.Add(new Tanulo("Sarah", 2002, 2.5, "13/e"));
            tanulok.Add(new Tanulo("Jess", 2004, 4.5, "10/b"));


            foreach (Tanulo t in tanulok)
            {
                Console.WriteLine(t);
            }
        }
    }
}
