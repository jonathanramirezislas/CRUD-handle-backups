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
    public partial class ModificarMateria : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarMateria()
        {
            InitializeComponent();
        }

        private void ModificarMateria_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From materia Order By clave_m", "materia");
            comboBox1.DataSource = dsResultados.Tables["materia"];
            comboBox1.DisplayMember = dsResultados.Tables["materia"].Columns["clave_m"].ToString();
            comboBox1.ValueMember = "clave_m";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update materia set nom_m='" + textBoxname.Text+ "',cred_m=" + textBoxcredi.Text+ ",hora_inicio='" + dateTimePickerHoraInicio.Text+ "',hora_fin='"+dateTimePickerHoraFinal.Text+ "',semestrecorrespondiente_m="+ textBoxsesmtrecorrespo .Text+ " Where clave_m="+comboBox1.Text+"";

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
            textBoxcredi.Text = "";
            dateTimePickerHoraFinal.Text = "";
            dateTimePickerHoraInicio.Text = "";
            textBoxname.Text = "";
            textBoxsesmtrecorrespo.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM materia Where  clave_m = '" + comboBox1.Text + "'", "materia");

            this.textBoxname.Text = ds.Tables[0].Rows[0][1].ToString();
            this.textBoxcredi.Text = ds.Tables[0].Rows[0][2].ToString();
            this.dateTimePickerHoraInicio.Text = ds.Tables[0].Rows[0][3].ToString();
            this.dateTimePickerHoraFinal.Text = ds.Tables[0].Rows[0][4].ToString();
            this.textBoxsesmtrecorrespo.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void textBoxhorainicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
