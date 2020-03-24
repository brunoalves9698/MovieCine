using MovieWebApp.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Movie
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Duração")]
        public TimeSpan Duration { get; set; }

        [Display(Name = "Classificação")]
        public EMovieRating Rating { get; set; }

        [Display(Name = "Gênero")]
        public EMovieGenre Genre { get; set; }

        [Display(Name = "Nacionalidade")]
        public EMovieNationality Nationality { get; set; }

        [Display(Name = "Distribuidor")]
        public string Distributor { get; set; }

        [Display(Name = "Diretor")]
        public string Director { get; set; }

        [Display(Name = "Elenco")]
        public string Cast { get; set; }

        [Display(Name = "Sinopse")]
        public string Sinopse { get; set; }

        [Display(Name = "Trailer")]
        public string Trailer { get; set; }

        [Display(Name = "Poster")]
        public string PortraitImage { get; set; }

        [Display(Name = "Banner")]
        public string LandscapeImage { get; set; }

        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }
    }
}
