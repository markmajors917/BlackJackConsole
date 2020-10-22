using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SWAPIHelper
    {
        private const string _baseURL = "https://swapi.dev/api/";
        private HttpClient httpClient = new HttpClient();
        public SWAPIHelper()
        {
            httpClient.BaseAddress = new Uri(_baseURL);
        }
        public async Task<string> GetPersonNameByIDAsync(int id)
        {
            string personsName;
            HttpResponseMessage nameRequest = await httpClient.GetAsync("people/" + id);
            // https://swapi.dev/api/people/:id
            string responseBody = await nameRequest.Content.ReadAsStringAsync();
            SWAPIPerson requestedPerson = JsonConvert.DeserializeObject<SWAPIPerson>(responseBody);
            personsName = requestedPerson.Name;
            return personsName;
        }
        public async Task<string> GetAVehicleNameByIDAsync(string name)
        {
            string vehicleName;
            HttpResponseMessage nameRequest = await httpClient.GetAsync("vehicle/" + id);
            string responseBody = await nameRequest.Content.ReadAsStringAsync();
            SWAPIVehicle requestedvehicle = JsonConvert.DeserializeObject<SWAPIVehicle>(responseBody);
            vehicleName = requestedvehicle.Vehicle;
            return vehicleName;
        }
    }
}
