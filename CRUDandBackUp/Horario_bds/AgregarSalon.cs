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
    public partial class AgregarSalon : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarSalon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;
            FormaSentencia = "insert into salon  values ("+textBoxclave.Text+",'"+textBoxnom.Text+"',"+textBoxNUmcilla.Text+",'"+ Convert.ToString(comboBox1.SelectedItem.ToString()) + "','"+textBoxdesc.Text+"')";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            this.Hide();
            textBoxclave.Text = "";
            textBoxdesc.Text = "";
            textBoxnom.Text = "";
            textBoxNUmcilla.Text = "";
            
        }

        private void AgregarSalon_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("SI");
            comboBox1.Items.Add("NO");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
