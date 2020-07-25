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
    public partial class AgregarProfesor : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarProfesor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;
            FormaSentencia = "insert into profesor  values ("+textBoxClave.Text+",'"+ textBoxNombre.Text + "','"+textBoxAppellidos.Text+"','"+ FechaNacdateTimePicker.Text + "','"+textBoxDom.Text+"',"+textBoxTelf.Text+","+textBoxEdad.Text+","+comboBoxDepa.SelectedValue+")";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            textBoxAppellidos.Text = "";
            textBoxClave.Text = "";
            textBoxDom.Text = "";
            textBoxEdad.Text = "";
            textBoxNombre.Text = "";
            textBoxTelf.Text = "";
            
        }

        private void AgregarProfesor_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From departamento Order By Nombre_d", "departamento");
            comboBoxDepa.DataSource = dsResultados.Tables["departamento"];
            comboBoxDepa.DisplayMember = dsResultados.Tables["departamento"].Columns["Nombre_d"].ToString();
            comboBoxDepa.ValueMember = "clave_d";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
