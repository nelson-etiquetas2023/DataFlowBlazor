using Microsoft.AspNetCore.Identity;
using Shared.DataflowBlazorApp.Enum;
using System.ComponentModel.DataAnnotations;

namespace Shared.DataflowBlazorApp.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "Id del Usuario")]
        [MaxLength(10, ErrorMessage = "El campo de id del usuario debe tener un maximo {1} caracteres.")]
        public string UserId { get; set; } = string.Empty;

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener un maximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener un maximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Direccion")]
        [MaxLength(200, ErrorMessage = "el campo {0} debe tener un maximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "Foto")]
        public string? Photo { get; set; }

        [Display(Name = "Tipo de Usuario")]
        public UserType UserType { get; set; }


        [Display(Name = "Usuario")]
        public string FullName => $"{FirstName} {LastName}";







    }
}
