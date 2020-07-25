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
    public partial class AgregarDepartamento : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarDepartamento()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;
            FormaSentencia = "insert into departamento  values ("+textBoxClave.Text+",'"+textBoxNombre.Text+"','"+comboBoxArea.Text+"',"+textBoxNumSa.Text+")";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            comboBoxArea.Text = "";
            textBoxClave.Text = "";
            textBoxNombre.Text = "";
            textBoxNumSa.Text = "";

        }

        private void AgregarDepartamento_Load(object sender, EventArgs e)
        {
            comboBoxArea.Items.Add("A1");
            comboBoxArea.Items.Add("A2");
            comboBoxArea.Items.Add("B1");
            comboBoxArea.Items.Add("B2");
            comboBoxArea.Items.Add("C1");
            comboBoxArea.Items.Add("C2");
           
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
