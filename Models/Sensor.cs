using System.ComponentModel.DataAnnotations;

namespace AgroTech.Models
{
    public class Sensor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del sensor es obligatorio.")]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar un tipo.")]
        public string Tipo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La ubicación es obligatoria.")]
        public string Ubicacion { get; set; } = string.Empty;

        [Range(0, 100)]
        public double ValorCalibracion { get; set; }

        public int? AgricultorId { get; set; }
    }
}