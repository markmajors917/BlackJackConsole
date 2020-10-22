using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp

{
     class Program
     {
        static void Main(string[] args)
        {
            //SWAPIHelper swapiHelper = new SWAPIHelper();

            //string lukesName = swapiHelper.GetPersonNameByIDAsync(1).Result;
            //Console.WriteLine(lukesName);
            //Console.ReadKey();
            //// Get people and starships by ID
            ///

            PokeAPIHelper pokeAPIHelper = new POKEHelper();

            PokeAPIPokemon emploeon = pokeAPIHelper.GetPokemonByNameAsync("empoleon").Result;

            Console.WriteLine(("Name: " + emploeon.Name);
            Console.WriteLine("Height: " + emploeon.Height);
            Console.WriteLine("Weight: " + emploeon.Weight);
            Console.ReadKey();
                       
        }
     }
}