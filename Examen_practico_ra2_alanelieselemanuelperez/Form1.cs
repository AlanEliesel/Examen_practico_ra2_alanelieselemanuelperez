using Examen_practico_ra2_alanelieselemanuelperez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_practico_RA2_DenzelAlvarez
{

    public partial class Form1 : Form
    {

        //inicializamos la clase estudiante:
        Estudiante student = new Estudiante();


        public Form1()
        {
            InitializeComponent();
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Nuevos_Datos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Agregar_Datos();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Guardar_datos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Cerrar_Programa();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar_elemento();
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar_Formulario();
        }



        public void Agregar_Datos()
        {



            student.matricula = Convert.ToInt32(txtMatricula.Text);

            student.nombre = txtNombre.Text;
            student.direccion = txtDireccion.Text;
            student.telefono = txtTelefono.Text;
            student.email = txtEmail.Text;
            student.maestro = txtMaestro.Text;

            student.area_tecnica = cmbAreaTecnica.SelectedItem.ToString();
            student.curso = cmbCurso.SelectedItem.ToString();
            student.seccion = cmbSeccion.SelectedItem.ToString();

            if (rbtnFemenino.Checked)
            {
                student.genero = rbtnFemenino.Text;
            }

            else
            {
                student.genero = rbtnMasculino.Text;
            }

            dgvDatos.Rows.Add(student.matricula, student.nombre, student.direccion, student.telefono, student.genero, student.email, student.curso, student.seccion, student.area_tecnica, student.maestro);

            txtDireccion.Clear();
            txtEmail.Clear();
            txtMaestro.Clear();
            txtMatricula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            cmbAreaTecnica.ResetText();
            cmbCurso.ResetText();
            cmbSeccion.ResetText();

            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
        }

        public void Nuevos_Datos()
        {
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;

            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtMatricula.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtMaestro.Enabled = true;

            cmbAreaTecnica.Enabled = true;
            cmbCurso.Enabled = true;
            cmbSeccion.Enabled = true;

            dgvDatos.Enabled = true;

            rbtnFemenino.Enabled = true;
            rbtnMasculino.Enabled = true;

            btnNuevo.Enabled = false;
        }

        public void Limpiar_Formulario()
        {
            DialogResult eliminar = MessageBox.Show("¿Desea Limpiar este formulario?", "Limpiar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminar == DialogResult.Yes)
            {
                txtDireccion.Clear();
                txtEmail.Clear();
                txtMaestro.Clear();
                txtMatricula.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();

                cmbAreaTecnica.ResetText();
                cmbCurso.ResetText();
                cmbSeccion.ResetText();

                dgvDatos.Rows.Clear();
            }




        }

        public void Eliminar_elemento()
        {


            DialogResult eliminar = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminar == DialogResult.Yes)
            {
                int indice = dgvDatos.SelectedRows[0].Index;
                dgvDatos.Rows.RemoveAt(indice);
            }

            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }

        }

        public void Cerrar_Programa()
        {


            DialogResult salir = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {

                Close();
            }

        }

        public void Guardar_datos()
        {
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;

            string path = @"C:\Users\Alan\source\repos\Examen_practico_ra2_alanelieselemanuelperez\Examen_practico_ra2_alanelieselemanuelperez\archivo.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string matricula = row.Cells[0].Value?.ToString() ?? "";
                        string nombre = row.Cells[1].Value?.ToString() ?? "";
                        string curso = row.Cells[6].Value?.ToString() ?? "";
                        string seccion = row.Cells[7].Value?.ToString() ?? "";
                        string areaTecnica = row.Cells[8].Value?.ToString() ?? "";

                        sw.WriteLine($"{matricula}\t{nombre}\t{curso}\t{seccion}\t{areaTecnica}");
                    }
                }
            }

            MessageBox.Show("Se han almacenado los datos en el archivo.txt");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

}
