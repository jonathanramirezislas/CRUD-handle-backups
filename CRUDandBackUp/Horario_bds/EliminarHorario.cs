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
    public partial class EliminarHorario : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public EliminarHorario()
        {
            InitializeComponent();
        }

        private void EliminarHorario_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From materia Order By clave_m", "materia");
            comboBox1.DataSource = dsResultados.Tables["materia"];
            comboBox1.DisplayMember = dsResultados.Tables["materia"].Columns["nom_m"].ToString();
            comboBox1.ValueMember = "clave_m";

            dsResultados = llamar.CargaDatos("Select * From alumno Order By mat_alu", "alumno");
            comboBox2.DataSource = dsResultados.Tables["alumno"];
            comboBox2.DisplayMember = dsResultados.Tables["alumno"].Columns["mat_alu"].ToString();
            comboBox2.ValueMember = "mat_alu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea elimnar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {

                string SentenciaSQL2 = string.Empty;
                SentenciaSQL2 = "Delete From horario Where clave_m1 = " + comboBox1.SelectedValue + "and  mat_alu1 =" + comboBox2.SelectedValue + "";


                if (llamar.EjecutaSentencia(SentenciaSQL2) == false)
                {
                    MessageBox.Show("Se ha dado de baja el alumno de la materia de la bd.");

                }
                else
                {
                    MessageBox.Show("Problemas con la base de datos.");
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {

                }
            }
            catch
            {
                MessageBox.Show("Datos incorrectos Verifique sus datos");
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM horario  WHERE clave_m1 =" + comboBox1.SelectedValue + "and  mat_alu1 =" + comboBox2.SelectedValue + " ", "horario");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
