﻿using Registropersonales;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext() : base("name=Empleado")
        {
        }
        public virtual DbSet<Empleado> Empleados { get; set; }
    }
}
