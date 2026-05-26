namespace AgroTech.Models
{
    public class Zona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? SensorId { get; set; } // Opcional (Coincide con NULL en SQL)
        public string Estado { get; set; } = "Activo";
        public int? Humedad { get; set; }
        public int? AgricultorId { get; set; }
    }
}