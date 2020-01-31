using Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aplicacion.Datos
{
    public class PermisoMap : IEntityTypeConfiguration<Permiso>
    {
        public void Configure(EntityTypeBuilder<Permiso> builder)
        {
            builder.ToTable("permiso").HasKey(p => p.id);
            builder.HasOne(p => p.TipoPermiso).WithMany(p => p.Permiso).HasForeignKey(p => p.id_tipo_permiso);
            builder.Property(p => p.nombre_empleado).HasMaxLength(30);
            builder.Property(p => p.apellidos_empleado).HasMaxLength(50);
        }
    }
}