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
    public partial class EliminarCarrera : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public EliminarCarrera()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EliminarCarrera_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From carrera Order By clave_c", "carrera");
            comboBox1.DataSource = dsResultados.Tables["carrera"];
            comboBox1.DisplayMember = dsResultados.Tables["carrera"].Columns["clave_c"].ToString();
            comboBox1.ValueMember = "clave_c";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM carrera  WHERE clave_c LIKE ('%" + comboBox1.SelectedValue + "%')", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea elimnar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {

                string SentenciaSQL2 = string.Empty;
                SentenciaSQL2 = "Delete From carrera Where clave_c = " + comboBox1.SelectedValue + "";


                if (llamar.EjecutaSentencia(SentenciaSQL2) == false)
                {
                    MessageBox.Show("Se ha eliminado la carrera de la bd.");

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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
