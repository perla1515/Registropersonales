using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registropersonales.domain
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public long Cedula { get; set; }

        public int Edad { get; set; }

        public string Sexo { get; set; }

        public Empleado() { }

        public Empleado(string nombre, string apellido, long cedula, int edad, string sexo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Edad = edad;
            this.Sexo = sexo;
        }

        public static void RemoveAt(int indice)
        {
            throw new NotImplementedException();
        }
    }
}


