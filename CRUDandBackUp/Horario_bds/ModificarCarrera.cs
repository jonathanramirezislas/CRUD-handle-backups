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
    public partial class ModificarCarrera : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarCarrera()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificarCarrera_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From carrera Order By clave_c", "carrera");
            comboBox1.DataSource = dsResultados.Tables["carrera"];
            comboBox1.DisplayMember = dsResultados.Tables["carrera"].Columns["clave_c"].ToString();
            comboBox1.ValueMember = "clave_c";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM carrera Where  clave_c = '" + comboBox1.Text + "'", "carrera");

            this.textBoxNombre.Text = ds.Tables[0].Rows[0][1].ToString();
            this.textBoxDuracion.Text = ds.Tables[0].Rows[0][2].ToString();
            this.textBoxCreditos.Text = ds.Tables[0].Rows[0][3].ToString();
            this.textBoxNumSem.Text = ds.Tables[0].Rows[0][4].ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update carrera set clave_c=" + comboBox1.Text + ",nom_c='" + textBoxNombre.Text + "',durac_c=" + textBoxDuracion.Text + ",creditos_c=" + textBoxCreditos.Text + ",numsemestres_c= "+textBoxNumSem.Text+ " Where clave_c="+comboBox1.Text+"";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            comboBox1.Text = "";
            textBoxCreditos.Text = "";
            textBoxDuracion.Text = "";
            textBoxNombre.Text = "";
            textBoxNumSem.Text = "";
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
