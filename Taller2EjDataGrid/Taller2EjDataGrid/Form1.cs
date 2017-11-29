using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taller2EjDataGrid
{
    public partial class Form1 : Form
    {
        public List<Persona> Personas { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Personas = new List<Persona>();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = this.txtNombre.Text;
            persona.Apellido = this.txtApellido.Text;
            persona.Edad = int.Parse(this.txtEdad.Text);

            this.Personas.Add(persona);

            this.dataGridView1.DataSource = null; // para permitir la actualizacion del data grid cuando ya tiene elementos
            this.dataGridView1.DataSource = this.Personas;
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
        }

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {
            this.txtApellido.Text = string.Empty;
            this.txtEdad.Text = string.Empty;
            this.txtNombre.Text = string.Empty;

            this.txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir del programa?", "Salir", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
