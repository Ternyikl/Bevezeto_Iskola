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



        static void Main(string[] args)
        {
            F05();
        }
    }
}
