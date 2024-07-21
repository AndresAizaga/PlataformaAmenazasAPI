using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaAmenazas.API.Domain.Entities;
using System.Reflection.PortableExecutable;

namespace PlataformaAmenazas.API.Infraestructure.Config
{
    public class AmenazasConfig : IEntityTypeConfiguration<Amenazas>
    {
        public void Configure(EntityTypeBuilder<Amenazas> builder)
        {
            builder.ToTable("Amenazas");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.amenaza).HasColumnName("amenaza");
            builder.Property(x => x.descripcion).HasColumnName("descripcion");
            builder.Property(x => x.fecha).HasColumnName("fecha");
            builder.Property(x => x.nivel_gravedad).HasColumnName("nivel_gravedad");
            builder.Property(x => x.vectores_ataque).HasColumnName("vectores_ataque");
            builder.Property(x => x.componentes).HasColumnName("componentes");
            builder.Property(x => x.mitigacion).HasColumnName("mitigacion");
            builder.Property(x => x.cantidad).HasColumnName("cantidad");
        }
    }
}
