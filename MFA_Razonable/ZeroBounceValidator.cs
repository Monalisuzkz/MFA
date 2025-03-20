using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MFA_Razonable
{
    internal class ZeroBounceValidator
    {
        private string apiKey = "d5bdcd68fcc34085bd66f9f777bf0b5f";

        public async Task<bool> ValidateEmailAsync(string email)
        {
            string apiUrl = $"https://api.zerobounce.net/v2/validate?api_key={apiKey}&email={email}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<ZeroBounceResponse>(responseBody);

                    if (result.Status == "valid")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error validating email: " + ex.Message);
                    return false;
                }
            }
        }

        public class ZeroBounceResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }
        }
    }
}
