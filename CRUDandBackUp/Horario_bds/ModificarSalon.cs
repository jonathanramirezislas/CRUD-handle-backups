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
    public partial class ModificarSalon : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarSalon()
        {
            InitializeComponent();
        }

        private void ModificarSalon_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From salon Order By clave_s", "salon");
            comboBoxCalveSalon.DataSource = dsResultados.Tables["salon"];
            comboBoxCalveSalon.DisplayMember = dsResultados.Tables["salon"].Columns["clave_s"].ToString();
            comboBoxCalveSalon.ValueMember = "clave_s";

            comboBoxProyector.Items.Add("si");
            comboBoxProyector.Items.Add("no");
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update salon set clave_s=" + comboBoxCalveSalon.Text + ",nombre_s='" + textBoxName.Text + "',Numerosillas_s=" + textBoxsillas.Text + ",Proyector_s='" + comboBoxProyector.Text + "',descrpcion_s= '" + textBoxdesripcion.Text + "' Where clave_s=" + comboBoxCalveSalon.Text + "";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM salon Where  clave_s = '" + comboBoxCalveSalon.Text + "'", "departamento");

            this.textBoxName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.textBoxsillas.Text = ds.Tables[0].Rows[0][2].ToString();
            this.comboBoxProyector.Text = ds.Tables[0].Rows[0][3].ToString();
            this.textBoxdesripcion.Text= ds.Tables[0].Rows[0][4].ToString();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
