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
    public partial class AgregarMateria : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarMateria()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMateria_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;
            FormaSentencia = "insert into materia  values ("+textBoxClave.Text+",'"+textBoxNombre.Text+"',"+textBoxCreditos.Text+",'"+ dateTimePickerHoraInicio.Text+"','"+ dateTimePickerHoraFinal.Text+"'," +textBoxSem.Text+")";

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
            textBoxCreditos.Text = "";
            textBoxNombre.Text = "";
            textBoxSem.Text = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
