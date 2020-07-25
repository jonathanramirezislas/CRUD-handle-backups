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
    public partial class EliminarProfesor : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public EliminarProfesor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM profesor  WHERE clave_p LIKE ('%" + comboBox1.SelectedValue + "%')", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void EliminarProfesor_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From profesor Order By clave_p", "profesor");
            comboBox1.DataSource = dsResultados.Tables["profesor"];
            comboBox1.DisplayMember = dsResultados.Tables["profesor"].Columns["clave_p"].ToString();
            comboBox1.ValueMember = "clave_p";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea elimnar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {

                string SentenciaSQL2 = string.Empty;
                SentenciaSQL2 = "Delete From profesor Where clave_p = " + comboBox1.SelectedValue + "";


                if (llamar.EjecutaSentencia(SentenciaSQL2) == false)
                {
                    MessageBox.Show("Se ha eliminado el profesor de la bd.");

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
