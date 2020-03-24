using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Account
    {
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string UserName { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatório.")]
        [DataType(DataType.Password)]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string Password { get; set; }
    }
}
