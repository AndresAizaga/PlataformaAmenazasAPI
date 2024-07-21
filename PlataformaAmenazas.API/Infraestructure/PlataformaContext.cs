using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System.Numerics;
using PlataformaAmenazas.API.Domain.Entities;
using PlataformaAmenazas.API.Infraestructure.Config;

namespace PlataformaAmenazas.API.Infraestructure
{
    public class PlataformaContext : DbContext
    {
        public PlataformaContext(DbContextOptions<PlataformaContext> options) : base(options) { }
        public DbSet<Amenazas> Amenazas { get; set; }
        public DbSet<Ataques> Ataques { get; set; }
        public DbSet<Intrusiones> Intrusiones { get; set; }
        public DbSet<Vulnerabilidades> Vulnerabilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AmenazasConfig());
            modelBuilder.ApplyConfiguration(new AtaquesConfig());
            modelBuilder.ApplyConfiguration(new IntrusionesConfig());
            modelBuilder.ApplyConfiguration(new VulnerabilidadesConfig());
        }
    }
}
