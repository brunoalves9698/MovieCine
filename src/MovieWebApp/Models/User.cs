using MovieWebApp.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class User
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [DataType(DataType.Password)]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Password { get; set; }

        [Display(Name = "Confrimação de Senha")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [DataType(DataType.Password)]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Primeiro Nome")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string FistName { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string LastName { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(14, ErrorMessage = "O campo \"{0}\" deve conter {1} caracteres.")]
        public string Document { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        public EGender Gender { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(15, ErrorMessage = "O campo \"{0}\" deve conter {1} caracteres.")]
        public string Phone { get; set; }

        [Display(Name = "Rua")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Street { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(10, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Number { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(80, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string City { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string State { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Country { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [StringLength(10, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string ZipCode { get; set; }
    }
}
