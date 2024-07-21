namespace PlataformaAmenazas.API.Controllers.DTO
{
    public class AmenazasDTO
    {
        public string amenaza { get; set; }
        public int cantidad { get; set; }
    }

    public class VulnerabilidadesDTO
    {
        public string vulnerabilidad { get; set; }
        public int cantidad { get; set; }
    }

    public class IntrusionesDTO
    {
        public string intrusion { get; set; }
        public int cantidad { get; set; }
    }

    public class AtaquesDTO
    {
        public string ataque { get; set; }
        public int cantidad { get; set; }
    }
}
