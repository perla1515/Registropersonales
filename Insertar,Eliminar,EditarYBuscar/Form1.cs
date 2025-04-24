using Registropersonales.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Registropersonales
{
    public partial class Form1: Form
    {
        private EmpleadoContext db;
        private object listaEmpleado;
        private Empleado empleadoTemporario;

        public Form1()
        {
            InitializeComponent();
            db = new EmpleadoContext();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                db.Database.Log = Console.WriteLine;

                // Query the EMPLEADO table using Entity Framework
                var empleados = db.Empleados.ToList();
                //var empleados = db.Empleados.FirstOrDefault();

                // Assuming you have a DataGridView named 'dataGridView1' on your form
                EmpleadoDataGridView.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // DATAGRIDVIEW
        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{

        //}

        
        private void button5_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (EmpleadoDataGridView.SelectedRows.Count > 0)
            {
                // Modificar los valores en la fila seleccionada
                DataGridViewRow fila = EmpleadoDataGridView.SelectedRows[0];

                var idValue = fila.Cells[0].Value;

                var id = Convert.ToInt32(idValue);

                var empleado = db.Empleados.Find(id);

                db.Entry(empleado).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            // Leer valores
            string nombre = NombreTxtBox.Text.Trim();
            string apellido = ApellidoTxtBox.Text.Trim();
            string cedulaText = CedulaTxtBox.Text.Trim();
            string edadTexto = EdadTxtBox.Text.Trim();
            string sexo = SexoTxtBox.Text;

            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(cedulaText) || string.IsNullOrEmpty(edadTexto) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(edadTexto, out int edad) || edad <= 0)
            {
                MessageBox.Show("Edad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(cedulaText, out long cedula))
            {
                MessageBox.Show("Cédula inválida. Solo números sin guiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = new Empleado(nombre, apellido, cedula, edad,sexo);

            // Agregar fila al DataGridView
            db.Empleados.Add(empleado);
            db.SaveChanges();

            LoadDataIntoDataGridView();

            // Limpiar campos
            NombreTxtBox.Clear();
            ApellidoTxtBox.Clear();
            CedulaTxtBox.Clear();
            EdadTxtBox.Clear();
            SexoTxtBox.Clear();
           
        }


        private void ValidarBtn_Click(object sender, EventArgs e)
        {
            // Validar el campo de texto NombreTxtBox
            if (string.IsNullOrWhiteSpace(NombreTxtBox.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Nombre válido: " + NombreTxtBox.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void NombreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (EmpleadoDataGridView.SelectedRows.Count > 0)
            {
                // Validaciones (igual que en Agregar)
                string nombre = NombreTxtBox.Text.Trim();
                string apellido = ApellidoTxtBox.Text.Trim();
                string cedula = CedulaTxtBox.Text.Trim();
                string edadTexto = EdadTxtBox.Text.Trim();
                string sexo = SexoTxtBox.Text;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                    string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(edadTexto) || string.IsNullOrEmpty(sexo))
                {
                    MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(edadTexto, out int edad) || edad <= 0)
                {
                    MessageBox.Show("Edad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(cedula, out long cedulaNumerica))
                {
                    MessageBox.Show("Cédula inválida. Solo números sin guiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Modificar los valores en la fila seleccionada
                DataGridViewRow fila = EmpleadoDataGridView.SelectedRows[0];
                var idValue = fila.Cells[0].Value;

                var id = Convert.ToInt32(idValue);

                var empleado = db.Empleados.Find(id);

                empleado.Nombre = nombre;
                empleado.Apellido = apellido;
                empleado.Cedula = cedulaNumerica;
                empleado.Edad = edad;
                empleado.Sexo = sexo;

                db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                LoadDataIntoDataGridView();

                MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                NombreTxtBox.Clear();
                ApellidoTxtBox.Clear();
                CedulaTxtBox.Clear();
                EdadTxtBox.Clear();
                SexoTxtBox.Clear();
                
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
          printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.EmpleadoDataGridView.Width, this.EmpleadoDataGridView.Height);
            this.EmpleadoDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.EmpleadoDataGridView.Width, this.EmpleadoDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void RecuperarBtn_Click(object sender, EventArgs e)
        {
            if (empleadoTemporario != null)
            {
                // Recuperar el empleadoTemporario que fue eliminado
                db.Empleados.Add(empleadoTemporario);
                db.SaveChanges();

                LoadDataIntoDataGridView();
            }
        }
    }
}