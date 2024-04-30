using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Levesek;
using Newtonsoft.Json;

namespace Levesek
{
    internal class Program
    {
    public static int[] t = new int [0];
        static async Task Main(string[] args)
        {
            await LevesAdatok();
            Console.Title = "Ugyfelek";


        }
        private static async Task LevesAdatok()
        {            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://localhost/Levesek-feladat/backend/index.php?levesek");
            if (responseMessage.IsSuccessStatusCode)
            {
                string jsonString = await responseMessage.Content.ReadAsStringAsync();
                var etelek = Etelek.FromJson(jsonString);
               //1. feladat
               Console.WriteLine($"1.feladat\n{etelek.Length} féle leves van\n");
                //2.feladat
                // Ha vannak elemek
                if (etelek != null && etelek.Length > 0)
                {
                    // Legnagyobb kalóriatartalmú elem keresése
                    var maxCalorieItem = etelek.OrderByDescending(x => x.Kaloria).First();

                    // Eredmény kiíratása
                    Console.WriteLine($"A legnagyobb kalóriatartalmú étel: {maxCalorieItem.Megnevezes} - {maxCalorieItem.Kaloria} kalória");
                }
                else
                {
                    Console.WriteLine("Nincsenek elemek a JSON fájlban.");
                }

                Console.ReadLine();
            }
        }
    }
    
}
