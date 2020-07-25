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
    public partial class AgregarCarrera : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarCarrera()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;
            FormaSentencia = " insert into carrera  values ("+textBoxClave.Text+",'"+textBoxNomb.Text+"',"+textBoxDur.Text+","+textBoxCred.Text+","+textBoxNumsem.Text+")";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            textBoxClave.Text = "";
            textBoxCred.Text = "";
            textBoxDur.Text = "";
            textBoxNomb.Text = "";
            textBoxNumsem.Text = "";
        }

        private void AgregarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
