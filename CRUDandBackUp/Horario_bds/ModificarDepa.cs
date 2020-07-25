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
    public partial class ModificarDepa : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarDepa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM departamento Where  clave_d = '" + comboBoxclavedepa.Text + "'", "departamento");

            this.textBoxName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.comboBoxaREA.Text = ds.Tables[0].Rows[0][2].ToString();
            this.textBoxNumS.Text = ds.Tables[0].Rows[0][3].ToString();
            
        }

        private void ModificarDepa_Load(object sender, EventArgs e)
        {
            comboBoxaREA.Items.Add("A1");
            comboBoxaREA.Items.Add("A2");
            comboBoxaREA.Items.Add("B1");
            comboBoxaREA.Items.Add("B2");
            comboBoxaREA.Items.Add("C1");
            comboBoxaREA.Items.Add("C2");
            dsResultados = llamar.CargaDatos("Select * From departamento Order By clave_d", "departamento");
            comboBoxclavedepa.DataSource = dsResultados.Tables["departamento"];
            comboBoxclavedepa.DisplayMember = dsResultados.Tables["departamento"].Columns["clave_d"].ToString();
            comboBoxclavedepa.ValueMember = "clave_d";
        }

        private void buttoncambios_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update departamento set Nombre_d='" + textBoxName.Text + "',Area_d='" + comboBoxaREA.Text + "',Numdesalones_d=" + textBoxNumS.Text + " Where clave_d="+comboBoxclavedepa.Text+"";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            textBoxName.Text = "";
            comboBoxaREA.Text = "";
            textBoxNumS.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
