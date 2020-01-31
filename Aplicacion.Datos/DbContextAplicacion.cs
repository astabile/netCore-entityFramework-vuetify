using Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Datos
{
    public class DbContextAplicacion : DbContext
    {
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }

        public DbContextAplicacion(DbContextOptions<DbContextAplicacion> options) : base(options) 
        {
            //
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PermisoMap());
            modelBuilder.ApplyConfiguration(new TipoPermisoMap());
        }
    }
}