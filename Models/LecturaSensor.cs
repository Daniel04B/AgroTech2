namespace AgroTech.Models
{
    public class LecturaSensor
    {
        public int Id { get; set; }
        public string Hora { get; set; } = string.Empty;
        public int Humedad { get; set; }
        public decimal? Temperatura { get; set; }
        public decimal? NivelTanque { get; set; }
        public int? ZonaId { get; set; }
    }
}