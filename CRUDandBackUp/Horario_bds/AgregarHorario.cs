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
    public partial class AgregarHorario : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public AgregarHorario()
        {
            InitializeComponent();
        }

        private void AgregarHorario_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From alumno Order By nombre_alu", "alumno");
            comboBoxAlu.DataSource = dsResultados.Tables["alumno"];
            comboBoxAlu.DisplayMember = dsResultados.Tables["alumno"].Columns["mat_alu"].ToString();
            comboBoxAlu.ValueMember = "mat_alu";

            dsResultados = llamar.CargaDatos("Select * From materia Order By clave_m", "materia");
            comboBoxMate.DataSource = dsResultados.Tables["materia"];
            comboBoxMate.DisplayMember = dsResultados.Tables["materia"].Columns["nom_m"].ToString();
            comboBoxMate.ValueMember = "clave_m";

            dsResultados = llamar.CargaDatos("Select * From profesor Order By clave_p", "profesor");
            comboBoxProf.DataSource = dsResultados.Tables["profesor"];
            comboBoxProf.DisplayMember = dsResultados.Tables["profesor"].Columns["nombre_p"].ToString();
            comboBoxProf.ValueMember = "clave_p";

            dsResultados = llamar.CargaDatos("Select * From salon Order By clave_s", "salon");
            comboBoxSal.DataSource = dsResultados.Tables["salon"];
            comboBoxSal.DisplayMember = dsResultados.Tables["salon"].Columns["nombre_s"].ToString();
            comboBoxSal.ValueMember = "clave_s";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " insert into horario values ('"+dateTimePickerHoraInicio.Text+"', '"+ dateTimePickerHoraInicio.Text + "', "+comboBoxAlu.SelectedValue+","+comboBoxProf.SelectedValue+","+comboBoxMate.SelectedValue+", "+comboBoxSal.SelectedValue+")";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            
            this.Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
