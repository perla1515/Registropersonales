using Registropersonales.domain;
using System;
using System.Windows.Forms;


namespace Registropersonales
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new EmpleadoContext())
            {
                // Check if the database exists
                if (!context.Database.Exists())
                {
                    // Create the database
                    context.Database.Create();
                    Console.WriteLine("Database 'Empleado' has been created.");
                }
                else
                {
                    Console.WriteLine("Database 'Empleado' already exists.");
                }
            }
            Application.Run(new Form1());
        }
    }
}
