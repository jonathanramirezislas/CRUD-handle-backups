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
    public partial class EliminarAlumno : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public EliminarAlumno()
        {
            InitializeComponent();
        }

        private void EliminarAlumno_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From alumno Order By mat_alu", "alumno");
            comboBox1.DataSource = dsResultados.Tables["alumno"];
            comboBox1.DisplayMember = dsResultados.Tables["alumno"].Columns["mat_alu"].ToString();
            comboBox1.ValueMember = "mat_alu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Seguro que desea elimnar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {

                string SentenciaSQL2 = string.Empty;
                SentenciaSQL2 = "Delete From alumno Where mat_alu = " + comboBox1.SelectedValue + "";


                if (llamar.EjecutaSentencia(SentenciaSQL2) == false)
                {
                    MessageBox.Show("Se ha eliminado al alumno de la bd.");

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
            this.Hide();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM alumno  WHERE mat_alu LIKE ('%" + comboBox1.SelectedValue + "%')","alumnos");
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
