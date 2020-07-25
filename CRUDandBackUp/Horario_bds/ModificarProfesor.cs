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
    public partial class ModificarProfesor : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarProfesor()
        {
            InitializeComponent();
        }

        private void ModificarProfesor_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From profesor Order By clave_p", "profesor");
            comboBoxClaveProfesor.DataSource = dsResultados.Tables["profesor"];
            comboBoxClaveProfesor.DisplayMember = dsResultados.Tables["profesor"].Columns["clave_p"].ToString();
            comboBoxClaveProfesor.ValueMember = "clave_p";

            dsResultados = llamar.CargaDatos("Select * From departamento Order By clave_d", "departamento");
            comboBoxDepartamenot.DataSource = dsResultados.Tables["departamento"];
            comboBoxDepartamenot.DisplayMember = dsResultados.Tables["departamento"].Columns["clave_d"].ToString();
            comboBoxDepartamenot.ValueMember = "clave_d";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update profesor set clave_p=" + comboBoxClaveProfesor.Text + ",nombre_p='" + textBoxname.Text + "',apellidos_p='" + textBoxappelido.Text + "',fecha_Nacimiento='" + FechaNacdateTimePicker.Text + "',dir_p= '" + textBoxdireccion.Text + "',tel_p= " + textBoxtelefono.Text + ",edad_p= " + textBoxedad.Text + ",clave_d1=" + comboBoxDepartamenot.SelectedValue + " Where clave_p = " + comboBoxClaveProfesor.Text + "";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }

            this.Hide();
            comboBoxClaveProfesor.Text = "";
            comboBoxDepartamenot.Text = "";
            textBoxappelido.Text = "";
            textBoxdireccion.Text = "";
            textBoxname.Text = "";
            textBoxedad.Text = "";
            textBoxtelefono.Text = "";
            
        }

        private void textBoxfeha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM profesor Where  clave_p = '" + comboBoxClaveProfesor.Text + "'", "profesor");

            DataSet dsdepartamento;
            dsdepartamento = llamar.CargaDatos("Select * FROM departamento where clave_d=" + ds.Tables[0].Rows[0][7].ToString() + "", "departamento");



            this.textBoxname.Text = ds.Tables[0].Rows[0][1].ToString();
            this.textBoxappelido.Text = ds.Tables[0].Rows[0][2].ToString();
            this.FechaNacdateTimePicker.Text = ds.Tables[0].Rows[0][3].ToString();
            this.textBoxdireccion.Text = ds.Tables[0].Rows[0][4].ToString();
            this.textBoxtelefono.Text = ds.Tables[0].Rows[0][5].ToString();
            this.textBoxedad.Text = ds.Tables[0].Rows[0][6].ToString();
            comboBoxDepartamenot.Text = dsdepartamento.Tables[0].Rows[0][1].ToString();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
