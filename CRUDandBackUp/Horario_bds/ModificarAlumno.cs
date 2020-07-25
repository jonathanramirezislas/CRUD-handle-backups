using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horario_bds
{
    public partial class ModificarAlumno : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarAlumno()
        {
            InitializeComponent();
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From carrera Order By clave_c", "carrera");
            comboBoxcarrera.DataSource = dsResultados.Tables["carrera"];
            comboBoxcarrera.DisplayMember = dsResultados.Tables["carrera"].Columns["nom_c"].ToString();
            comboBoxcarrera.ValueMember = "clave_c";

            dsResultados = llamar.CargaDatos("Select * From alumno Order By mat_alu", "alumno");
            comboBoxmatricula.DataSource = dsResultados.Tables["alumno"];
            comboBoxmatricula.DisplayMember = dsResultados.Tables["alumno"].Columns["mat_alu"].ToString();
            comboBoxmatricula.ValueMember = "mat_alu";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM alumno Where  mat_alu = '" + comboBoxmatricula.Text + "'", "alumno");

            DataSet dscarrera;
            dscarrera = llamar.CargaDatos("Select * FROM carrera where clave_c="+ ds.Tables[0].Rows[0][7].ToString() + "","carrera");

           

            this.textBoxNom.Text = ds.Tables[0].Rows[0][1].ToString();
            this.textBoxApellidos.Text = ds.Tables[0].Rows[0][2].ToString();
            this.FechaNacdateTimePicker.Text= ds.Tables[0].Rows[0][3].ToString();
            this.textBoxEdad.Text = ds.Tables[0].Rows[0][4].ToString();
            this.textBoxSemestre.Text = ds.Tables[0].Rows[0][5].ToString();
            this.textBoxGener.Text = ds.Tables[0].Rows[0][6].ToString();
            comboBoxcarrera.Text= dscarrera.Tables[0].Rows[0][1].ToString();
           
        }

        private void comboBoxmatricula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update alumno set mat_alu=" + comboBoxmatricula.Text + ",nombre_alu='" + textBoxNom.Text + "',apellidos_alu='" + textBoxApellidos.Text + "',fecha_Nacimiento_alu='" + FechaNacdateTimePicker.Text + "',edad_alu= " + textBoxEdad.Text + ",sem_alu= " + textBoxSemestre.Text + ",gen_alu= " + textBoxGener.Text + ",clave_c1=" + comboBoxcarrera.SelectedValue + " Where mat_alu = "+comboBoxmatricula.Text+"";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            comboBoxmatricula.Text = "";
            comboBoxcarrera.Text = "";
            textBoxApellidos.Text = "";
            textBoxEdad.Text = "";
            textBoxGener.Text = "";
            textBoxNom.Text = "";
            textBoxSemestre.Text = "";
            
        }

        private void FechaNacdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
