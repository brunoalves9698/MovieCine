using MovieWebApp.Models;
using MovieWebApp.Models.Shared;
using MovieWebApp.Shared;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MovieWebApp.Services
{
    public class UserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public User Get(string endpoint)
        {
            HttpResponseMessage response = _http.GetAsync($"{Settings.API_URL}/{endpoint}").Result;
            string content = response.Content.ReadAsStringAsync().Result;
            User result = JsonConvert.DeserializeObject<User>(content);

            return result;
        }

        public GenericCommandResult Signup(string endpoint, User user)
        {
            HttpResponseMessage response = _http.PostAsync($"{Settings.API_URL}/{endpoint}", new StringContent(
                        JsonConvert.SerializeObject(new
                        {
                            email = user.Email,
                            password = user.Password,
                            FistName = user.Password,
                            lastName = user.LastName,
                            document = user.Document.Replace(".", "").Replace("-", ""), 
                            gender = user.Gender,
                            birthDate = user.BirthDate,
                            phone = user.Phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""),
                            street = user.Street,
                            number = user.Number,
                            neighborhood = user.Neighborhood,
                            city = user.City,
                            state = user.Street,
                            country = user.Country,
                            zipCode = user.ZipCode.Replace(".", "").Replace("-", ""),
        }), Encoding.UTF8, "application/json")).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            GenericCommandResult result = JsonConvert.DeserializeObject<GenericCommandResult>(content);

            return result;
        }
    }
}
