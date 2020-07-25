using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mi_libreria;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Horario_bds
{
    public partial class Mostrar : Form
    {
        DataSet dsResultados = new DataSet();


        Form1 llamar = new Form1();

        AgregarAlumno AgreA = new AgregarAlumno();
        AgregarCarrera AgreC = new AgregarCarrera();
        AgregarDepartamento AgreD = new AgregarDepartamento();
        AgregarHorario AgreH = new AgregarHorario();
        AgregarMateria AgreM = new AgregarMateria();
        AgregarProfesor AgreP = new AgregarProfesor();
        AgregarSalon AgreS = new AgregarSalon();

        ModificarAlumno ModA = new ModificarAlumno();
        ModificarCarrera ModC = new ModificarCarrera();
        ModificarDepa ModD = new ModificarDepa();
        ModificarHorario ModH = new ModificarHorario();
        ModificarMateria ModM = new ModificarMateria();
        ModificarProfesor ModP = new ModificarProfesor();
        ModificarSalon ModS = new ModificarSalon();

        EliminarAlumno EliA = new EliminarAlumno();
        EliminarCarrera EliC = new EliminarCarrera();
        EliminarDepartamento ELiD = new EliminarDepartamento();
        EliminarHorario EliH = new EliminarHorario();
        EliminarMateria EliM = new EliminarMateria();
        EliminarProfesor EliP = new EliminarProfesor();
        EliminarSalon EliS = new EliminarSalon();
        public Mostrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=true;
            try
            {
                DataSet ds;
                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", comboBoxTablas.Text);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
            
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            comboBoxAgregar.Items.Add("Alumnos");
            comboBoxAgregar.Items.Add("Profesor");
            comboBoxAgregar.Items.Add("Carrera");
            comboBoxAgregar.Items.Add("Departamento");
            comboBoxAgregar.Items.Add("Horario");
            comboBoxAgregar.Items.Add("Materia");
            comboBoxAgregar.Items.Add("Salon");

            comboBoxModificar.Items.Add("Alumnos");
            comboBoxModificar.Items.Add("Profesor");
            comboBoxModificar.Items.Add("Carrera");
            comboBoxModificar.Items.Add("Departamento");
            comboBoxModificar.Items.Add("Horario");
            comboBoxModificar.Items.Add("Materia");
            comboBoxModificar.Items.Add("Salon");

            comboBoxEliminar.Items.Add("Alumnos");
            comboBoxEliminar.Items.Add("Profesor");
            comboBoxEliminar.Items.Add("Carrera");
            comboBoxEliminar.Items.Add("Departamento");
            comboBoxEliminar.Items.Add("Horario");
            comboBoxEliminar.Items.Add("Materia");
            comboBoxEliminar.Items.Add("Salon");

            comboBoxTablas.Items.Add("alumno");
            comboBoxTablas.Items.Add("carrera");
            comboBoxTablas.Items.Add("departamento");
            comboBoxTablas.Items.Add("horario");
            comboBoxTablas.Items.Add("materia");
            comboBoxTablas.Items.Add("profesor");
            comboBoxTablas.Items.Add("salon");
            comboBoxTablas.Items.Add("movimientos");


        }

        public DataSet LlenarDataGV(String tabla) { 
        DataSet DS;
        //vamos a llenar la informacion que recivamos por parametro
        String cmd = string.Format("SELECT * FROM " + tabla);

        DS = Utilidades.Ejecutar(cmd);

            return DS;
        }

        private void buttonAlumn_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = LlenarDataGV("alumno").Tables[0];
        }

        private void buttonCarreras_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

                 private void buttonEjecutar_Click(object sender, EventArgs e)
        {
           
            string Agregar = "";
             Agregar =Convert.ToString( comboBoxAgregar.SelectedItem.ToString());
            switch (Agregar)
            {
                case "Alumnos":AgreA.Show(); break;
                case "Profesor":AgreP.Show(); break;
                case "Carrera": AgreC.Show(); break;
                case "Departamento":AgreD.Show(); break;
                case "Horario":AgreH.Show(); break;
                case "Materia":AgreM.Show(); break;
                case "Salon":AgreS.Show(); break;
                default: break;

            }
            comboBoxAgregar.Text = "Agregar";
          
        }

        private void buttonEjecutarModificar_Click(object sender, EventArgs e)
        {

            string Modificar = "";
            Modificar= Convert.ToString(comboBoxModificar.SelectedItem.ToString());
            switch (Modificar)
            {
                case "Alumnos": ModA.Show(); break;
                case "Profesor": ModP.Show(); break;
                case "Carrera": ModC.Show(); break;
                case "Departamento": ModD.Show(); break;
                case "Horario": ModH.Show(); break;
                case "Materia": ModM.Show(); break;
                case "Salon": ModS.Show(); break;
                default: break;
            }
            comboBoxModificar.Text = "Modificar";
        }

        private void buttonEjecutarEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "";
            eliminar= Convert.ToString(comboBoxEliminar.SelectedItem.ToString());

            switch (eliminar)
            {
                case "Alumnos": EliA.Show(); break;
                case "Profesor": EliP.Show(); break;
                case "Carrera": EliC.Show(); break;
                case "Departamento": ELiD.Show(); break;
                case "Horario": EliH.Show(); break;
                case "Materia": EliM.Show(); break;
                case "Salon": EliS.Show(); break;
                default: break;
            }
            comboBoxEliminar.Text = "Eliminar";
        }

        private void comboBoxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void carreras(){

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " +comboBoxTablas.Text +"", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        public void alumnos()
        {

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
        public void departamentos()
        {

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
        public void profesor()
        {

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
        public void salon()
        {

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
        public void meteria()
        {

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
        public void horario()
        {

            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select * FROM " + comboBoxTablas.Text + "", "alumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void comboBoxEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            llamar.EjecutaSentencia("BACKUP DATABASE Escuelita_Programa TO Escuelita_Programas_Backup_HD WITH INIT ");
            MessageBox.Show("Se hizo el respaldo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            llamar.EjecutaSentencia(" use master restore database Escuelita_Programa FROM DISK ='c:\\Program Files\\Microsoft SQL Server\\MSSQL10.SQLEXPRESS\\MSSQL\\Backup\\Escuelita_Programa.bak'");
            MessageBox.Show("Se hizo la restauracion");
        }
    }
}
