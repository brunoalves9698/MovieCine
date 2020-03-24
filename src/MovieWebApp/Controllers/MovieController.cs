using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services;
using System;

namespace MovieWebApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index([FromServices] MovieService service)
        {
            ViewBag.DropDownLists = service.GetDropdownLists();
            return View(service.GetAll("v1/movies"));
        }

        [HttpPost]
        public IActionResult Index(int genre, DateTime? releaseDate, [FromServices] MovieService service)
        {
            ViewBag.DropDownLists = service.GetDropdownLists();
                
            var release = releaseDate?.ToString().Replace("/", "-").Substring(0, 10);

            if (genre == 0 && releaseDate == null)
                return View(service.GetAll("v1/movies"));// todos
            else if(genre != 0 && releaseDate == null)
                return View(service.GetByGenre($"v1/movies/genre/{genre}")); // por genero
            else if (genre == 0 && releaseDate != null)
                return View(service.GetByReleaseDate($"v1/movies/releasedate/{release}"));
            else
                return View(service.GetByGenreAndReleaseDate($"v1/movies/genre/{genre}/releasedate/{release}"));
        }
    }
}