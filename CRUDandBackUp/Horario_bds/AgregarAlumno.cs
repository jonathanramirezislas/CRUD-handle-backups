using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mi_libreria;

namespace Horario_bds
{
   
    public partial class AgregarAlumno : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarAlumno_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From carrera Order By nom_c","carrera");
            comboBoxCarrera.DataSource = dsResultados.Tables["carrera"];
            comboBoxCarrera.DisplayMember = dsResultados.Tables["carrera"].Columns["nom_c"].ToString();
            comboBoxCarrera.ValueMember = "clave_c";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            string FormaSentencia = string.Empty;
           
            FormaSentencia = " insert into alumno values ("+textBoxMatricula.Text+", '"+ textBoxNombre.Text+ "', '"+textBoxApellido.Text+"', '"+ FechaNacdateTimePicker.Text + "', "+textBoxEdad.Text+", "+ textBoxSemestre.Text+ ", "+textBoxGeneracion.Text+", "+comboBoxCarrera.SelectedValue+")";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";
            textBoxGeneracion.Text = "";
            textBoxNombre.Text = "";
            textBoxSemestre.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
