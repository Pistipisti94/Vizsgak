using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Vizsga_app;

namespace Vizsga_app
{
    internal class Program
    {
         
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("1. Feladat\n\n");
            await UgyfelAdatok();
            Console.WriteLine("2. Feladat\n\n");
            await BefizAdatok();
            Console.Title = "Ugyfelek";


        }
        private static async Task UgyfelAdatok()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://localhost/Vizsga_Backend/index.php?ugyfelek");
            if (responseMessage.IsSuccessStatusCode)
            {
                string jsonString = await responseMessage.Content.ReadAsStringAsync();
                var ugyfelek = Ugyfelek.FromJson(jsonString);
                foreach (var item in ugyfelek)
                {
                    Console.WriteLine($"{item.Nev}");
                    
                }
                
            }
        }private static async Task BefizAdatok()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://localhost/Vizsga_Backend/index.php?befizetes");
            if (responseMessage.IsSuccessStatusCode)
            {
                string jsonString = await responseMessage.Content.ReadAsStringAsync();
                var befizetesek = Befizetesek.FromJson(jsonString);
                List<string> osszeg = new List<string>();
 
                foreach (var item in befizetesek)
                {
                    osszeg.Add(item.Osszeg.ToString());
                
                }
                
                for (int i = 0; i < osszeg.Count; i++)
                {
                    Console.WriteLine(osszeg[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
