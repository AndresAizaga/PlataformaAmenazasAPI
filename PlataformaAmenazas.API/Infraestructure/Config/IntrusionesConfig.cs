using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PlataformaAmenazas.API.Domain.Entities;

namespace PlataformaAmenazas.API.Infraestructure.Config
{
    public class IntrusionesConfig : IEntityTypeConfiguration<Intrusiones>
    {
        public void Configure(EntityTypeBuilder<Intrusiones> builder)
        {
            builder.ToTable("Intrusiones");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.intrusion).HasColumnName("intrusion");
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
