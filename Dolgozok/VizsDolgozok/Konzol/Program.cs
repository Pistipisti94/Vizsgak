using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozokConsole
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Dolgozok> dolgozoks;
        static void Main(string[] args)
        {
            dolgozoks = db.getAllDolgozo();
            feladat01();
            Console.WriteLine();
            feladat02();
            Console.WriteLine();
            feladat03();
            Console.WriteLine();
            feladat04();
            Console.WriteLine();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladat04()
        {
            Console.WriteLine("4.feladat:");
            foreach (var item in dolgozoks.FindAll(a => a.reszleg == "asztalosműhely"))
            {
                Console.WriteLine($"\t {item.nev}");
            }
        }

        private static void feladat03()
        {
            Console.WriteLine("3.feladat:");
            foreach (var item in dolgozoks.GroupBy(a => a.reszleg).Select(b => new {reszleg = b.Key,letszam = b.Count()}).OrderBy(c => c.reszleg))
            {
                Console.WriteLine($"\t {item.reszleg}: {item.letszam} fő");
            }
        }

        private static void feladat02()
        {
            int maxBer = dolgozoks.Max(a => a.ber);
            Dolgozok dolgozo = dolgozoks.Find(a => a.ber == maxBer);
            Console.WriteLine("2.feladat:");
            Console.WriteLine($"\t{dolgozo.nev} {dolgozo.ber}ft összeget keres");

        }

        private static void feladat01()
        {
            Console.WriteLine("1.feladat:");
            Console.WriteLine($"\t A dolgozók száma: {dolgozoks.Count} fő.\n");
        }
    }
}
