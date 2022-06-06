using Kumbajah.Domain.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class ViaCepService
    {
        private HttpClient HttpClient { get; }
        private string ViaCepURL { get; } =
            "https://apps.widenet.com.br/busca-cep/api/cep.json?code=";

        public ViaCepService(/*IConfiguration configuration, */HttpClient httpClient)
        {
            //ViaCepURL = configuration.get
            HttpClient = httpClient;
        }

        private async Task<JToken> GetViaCep(string url, string cep)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("Accept", "application/json");
                var result = await HttpClient.SendAsync(request);
                var resultContent = await result.Content.ReadAsStringAsync();
                Address obj = JsonConvert.DeserializeObject<Address>(resultContent);
                Console.WriteLine(obj);
                return JObject.Parse(resultContent);
            }
            catch (Exception)
            {
                string errorMessage = "Não foi possivel encontrar esse CEP";
                return errorMessage;
            }
        }
    }
}
