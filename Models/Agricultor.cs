using System.ComponentModel.DataAnnotations;

namespace AgroTech.Models
{
    public class Agricultor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "El apellido no puede exceder 100 caracteres")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "El usuario es obligatorio")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El usuario debe tener entre 3 y 150 caracteres")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(5, ErrorMessage = "La contraseña debe tener al menos 5 caracteres")]
        public string Contrasena { get; set; } = string.Empty;

        public string Rol { get; set; } = "Usuario";
    }
}