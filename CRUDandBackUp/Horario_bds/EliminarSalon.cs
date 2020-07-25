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
    public partial class EliminarSalon : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public EliminarSalon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM salon  WHERE clave_s LIKE ('%" + comboBox1.SelectedValue + "%')", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void EliminarSalon_Load(object sender, EventArgs e)
        {

            dsResultados = llamar.CargaDatos("Select * From salon Order By clave_s", "salon");
            comboBox1.DataSource = dsResultados.Tables["salon"];
            comboBox1.DisplayMember = dsResultados.Tables["salon"].Columns["clave_s"].ToString();
            comboBox1.ValueMember = "clave_s";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea elimnar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {

                string SentenciaSQL2 = string.Empty;
                SentenciaSQL2 = "Delete From salon Where clave_s = " + comboBox1.SelectedValue + "";


                if (llamar.EjecutaSentencia(SentenciaSQL2) == false)
                {
                    MessageBox.Show("Se ha eliminado el salon de la bd.");

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
            this.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
