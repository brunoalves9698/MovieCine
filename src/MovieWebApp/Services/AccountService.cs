using MovieWebApp.Models;
using MovieWebApp.Models.Shared;
using MovieWebApp.Shared;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MovieWebApp.Services
{
    public class AccountService
    {
        private readonly HttpClient _http;

        public AccountService(HttpClient http)
        {
            _http = http;            
        }

        public GenericCommandResult Login(string endpoint, Account account)
        {
            HttpResponseMessage response = _http.PostAsync($"{Settings.API_URL}/{endpoint}", new StringContent(
                        JsonConvert.SerializeObject(new
                        {
                            username = account.UserName,
                            password = account.Password
                        }), Encoding.UTF8, "application/json")).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            GenericCommandResult result = JsonConvert.DeserializeObject<GenericCommandResult>(content);
            //if (result.Success)
            //    Settings.Token = ((AccountToken)result.Data).Token;

            return result;
        }
    }
}
