using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
    {
        public void Configure(EntityTypeBuilder<TrainerSalon> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("trainersalon");

            builder.HasKey(e => e.IdPersonaFk);
            builder.Property(e => e.IdPersonaFk)
            .HasMaxLength(50);

            builder.Property(e => e.IdSalonFk)
            .HasMaxLength(50);

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.TrainerSalones)
            .HasForeignKey(p => p.IdPersonaFk);

            builder.HasOne(p => p.Salon)
            .WithMany(p => p.TrainerSalones)
            .HasForeignKey(p => p.IdSalonFk);
        }
    }
}