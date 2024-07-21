﻿namespace PlataformaAmenazas.API.Domain.Entities
{
    public class Vulnerabilidades
    {
        public int id { get; set; }
        public string? vulnerabilidad { get; set; }
        public string? descripcion { get; set; }
        public string? fecha { get; set; }
        public string? nivel_gravedad { get; set; }
        public string? vectores_ataque { get; set; }
        public string? componentes { get; set; }
        public string? mitigacion { get; set; }
        public int cantidad { get; set; }
    }
}
