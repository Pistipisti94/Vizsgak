using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaVizsga
{
    internal class Program
    {
        static Adatbazis adatbazis = new Adatbazis();
        static List<Futar> futars = new List<Futar>();
        static void Main(string[] args)
        {
            futars = adatbazis.GetAllFutar();
            feladat01();
            feladat02();
            feladat03();
            Console.ReadLine();
        }

        private static void feladat03()
        {
            int sumErtek = futars.Sum(a => a.ertek);
            Console.WriteLine("3.feladat");
            Console.WriteLine($"\t {sumErtek}Ft");
        }

        private static void feladat02()
        {
            int minErtek = futars.Min(a => a.ertek);
            Futar futo = futars.Find(a => a.ertek == minErtek);
            Console.WriteLine("2.feladat");
            Console.WriteLine($"\t{futo.fnev}");

        }

        private static void feladat01()
        {
            Console.WriteLine("1.feladat");
            foreach (var item in futars)
            {
                Console.WriteLine($"\t {item.fazon} {item.fnev} {item.ftel}\t {item.ertek}Ft");

            }
            
        }
    }
}
