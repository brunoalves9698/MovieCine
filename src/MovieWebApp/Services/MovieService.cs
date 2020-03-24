using EnumsNET;
using MovieWebApp.Enums;
using MovieWebApp.Models;
using MovieWebApp.Models.Shared;
using MovieWebApp.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MovieWebApp.Services
{
    public class MovieService
    {
        private readonly HttpClient _http;

        public MovieService(HttpClient http)
        {
            _http = http;
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.Token);
        }

        public IEnumerable<Movie> GetAll(string endpoint)
        {
            HttpResponseMessage response = _http.GetAsync($"{Settings.API_URL}/{endpoint}").Result;
            string content = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Movie> result = JsonConvert.DeserializeObject<IEnumerable<Movie>>(content);

            return result;
        }

        public IEnumerable<Movie> GetByGenre(string endpoint)
        {
            HttpResponseMessage response = _http.GetAsync($"{Settings.API_URL}/{endpoint}").Result;
            string content = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Movie> result = JsonConvert.DeserializeObject<IEnumerable<Movie>>(content);

            return result;
        }

        public IEnumerable<Movie> GetByReleaseDate(string endpoint)
        {
            HttpResponseMessage response = _http.GetAsync($"{Settings.API_URL}/{endpoint}").Result;
            string content = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Movie> result = JsonConvert.DeserializeObject<IEnumerable<Movie>>(content);

            return result;
        }

        public IEnumerable<Movie> GetByGenreAndReleaseDate(string endpoint)
        {
            HttpResponseMessage response = _http.GetAsync($"{Settings.API_URL}/{endpoint}").Result;
            string content = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Movie> result = JsonConvert.DeserializeObject<IEnumerable<Movie>>(content);

            return result;
        }

        public List<DropdownList> GetDropdownLists()
        {
            var values = Enum.GetValues(typeof(EMovieGenre));
            List<DropdownList> genreList = new List<DropdownList>();
            for (var i = 0; i < values.Length; i++)
            {
                var value = values.GetValue(i);
                genreList.Add(new DropdownList(((int)value).ToString(), ((EMovieGenre)value).AsString(EnumFormat.Description)));
            }
            return genreList;
        }
    }
}
