using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class POKEAPIHelper
    {
        HttpClient http = new HttpClient();

        HttpResponseMessage pokemonByNameReq = await HttpResponseMessage.GetAsync("https://pokeapi.co/api/v2/pokemon/" + name);
        if (pokemonByNameReq.IsSucsesStatusCode)
            {
            string resBody = await pokemonByNameReq.Content.ReadAsStringAsync();
        PokemonAPI
    }
}
