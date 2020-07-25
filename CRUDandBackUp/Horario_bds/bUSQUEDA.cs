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
    public partial class bUSQUEDA : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public bUSQUEDA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                DataSet ds;
                ds = llamar.CargaDatos("Select * FROM Horario Where hora_inicio="+ dateTimePickerHoraInicio.Text+ " and (clave_p1=" + comboBox1.Text+ " and clave_m1="+comboBox2+")", "horario");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void bUSQUEDA_Load(object sender, EventArgs e)
        {
            DataSet dsResultados = new DataSet();
            Form1 llamar = new Form1();
        }
    }
}
