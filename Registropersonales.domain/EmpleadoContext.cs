using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registropersonales.domain
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext() : base("name=Empleado") { }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().ToTable("Empleado");
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasColumnName("Nombre");
            modelBuilder.Entity<Empleado>().Property(e => e.Apellido).HasColumnName("Apellido");
            modelBuilder.Entity<Empleado>().Property(e => e.Cedula).HasColumnName("Cedula");
            modelBuilder.Entity<Empleado>().Property(e => e.Edad).HasColumnName("Edad");
            modelBuilder.Entity<Empleado>().Property(e => e.Sexo).HasColumnName("Sexo");
        }
    }
}
