using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Horario_bds
{
    public partial class ModificarHorario : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();
        public ModificarHorario()
        {
            InitializeComponent();
        }

        private void ModificarHorario_Load(object sender, EventArgs e)
        {
            dsResultados = llamar.CargaDatos("Select * From materia Order By clave_m", "materia");
            comboBoxmateria.DataSource = dsResultados.Tables["materia"];
            comboBoxmateria.DisplayMember = dsResultados.Tables["materia"].Columns["clave_m"].ToString();
            comboBoxmateria.ValueMember = "clave_m";

            dsResultados = llamar.CargaDatos("Select * From alumno Order By mat_alu", "alumno");
            comboBoxalumno.DataSource = dsResultados.Tables["alumno"];
            comboBoxalumno.DisplayMember = dsResultados.Tables["alumno"].Columns["mat_alu"].ToString();
            comboBoxalumno.ValueMember = "mat_alu";

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

        private void buttonCambios_Click(object sender, EventArgs e)
        {
            string FormaSentencia = string.Empty;

            FormaSentencia = " update horario set hora_inicio='" +dateTimePickerHoraInicio.Text  + "',hora_fin='" + dateTimePickerHoraFinal.Text + "',mat_alu1=" + comboBoxalumno.SelectedValue + ",clave_p1='" + comboBoxProf.SelectedValue+ "',clave_m1= " + comboBoxMate.SelectedValue + ",clave_s1= " + comboBoxSal.Text + " where clave_m1=" + comboBoxmateria.Text+ " and mat_alu1=" + comboBoxalumno.Text+"";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


            ds = llamar.CargaDatos("Select * FROM horario  WHERE clave_m1 =" + comboBoxmateria.SelectedValue + "and  mat_alu1 =" + comboBoxalumno.SelectedValue + " ", "horario");



            DataSet dsmatricula;
            dsmatricula = llamar.CargaDatos("Select * FROM alumno where mat_alu=" + ds.Tables[0].Rows[0][2].ToString() + "", "departamento");

            DataSet dsprofesor;
            dsprofesor = llamar.CargaDatos("Select * FROM profesor where clave_p=" + ds.Tables[0].Rows[0][3].ToString() + "", "departamento");

            DataSet dsmateria;
            dsmateria = llamar.CargaDatos("Select * FROM materia where clave_m=" + ds.Tables[0].Rows[0][4].ToString() + "", "departamento");

            DataSet dssalon;
            dssalon = llamar.CargaDatos("Select * FROM salon where clave_s=" + ds.Tables[0].Rows[0][5].ToString() + "", "departamento");

            this.dateTimePickerHoraInicio.Text = ds.Tables[0].Rows[0][0].ToString();
            this.dateTimePickerHoraFinal.Text = ds.Tables[0].Rows[0][1].ToString();
          
            comboBoxAlu.Text = dsmatricula.Tables[0].Rows[0][1].ToString();
            comboBoxProf.Text= dsprofesor.Tables[0].Rows[0][1].ToString();
            comboBoxMate.Text = dsmateria.Tables[0].Rows[0][1].ToString();
            comboBoxSal.Text = dssalon.Tables[0].Rows[0][1].ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Dato no encontrado");
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos Verifique sus datos");
            }
        }
    }
}
