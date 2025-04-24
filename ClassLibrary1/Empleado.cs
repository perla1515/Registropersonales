using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido;
        public string Cedula;

        public string Edad { get; set; }

        public string Sexo;

        public string Celular { get; set; }

        public Empleado() { }

        public Empleado(int id, string nombre, string apellido,string cedula, string edad, string sexo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Edad = edad;
            this.Sexo = sexo;
        }
    }
}


