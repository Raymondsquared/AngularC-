using System.Net.Http;
using System.Threading.Tasks;

namespace AngularCSharp.Core.Helpers
{
    public static class HttpClientHelper
    {
        public static async Task<string> GetAsync(string URL)
        {
            var finalResult = string.Empty;

            using (var client = new HttpClient())
            {
                var result = client.GetAsync(URL).Result;

                if (result.IsSuccessStatusCode)
                {
                    finalResult = await result.Content.ReadAsStringAsync();
                }
            }

            return finalResult;
        }
    }
}
