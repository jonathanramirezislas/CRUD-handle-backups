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
using Mi_libreria;
using System.IO;


namespace Horario_bds
{
    public partial class Form1 : Form
    {
        private string conexion;
        SqlConnection bdCon;
        SqlCommand Comando;
        SqlDataAdapter daEjecuta;
        DataSet dsConjunto;
     public static  string conection ;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoniniciar_Click(object sender, EventArgs e)
        {
         conection="Data Source =.; Initial Catalog = Escuelita_Programa; User ID = "+textBoxNombre.Text+"; Password = "+textBoxContraseña.Text+"";
            try
            {

                SqlConnection Con = new SqlConnection(conection);

                Con.Open();
                Mostrar Ventanamostrar = new Mostrar();
                MessageBox.Show("Conexion creada");
                Con.Close();
                Ventanamostrar.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {


        }

        //////////////////
       
        public string Conexion()
        {
            
            return conection;
                //"Data Source=.;Initial Catalog=Escuelita_Programa;User ID=Jona;Password=1234";           
        }

        public bool EjecutaSentencia(string paramSentencia)
        {
            bdCon = new SqlConnection();
            Comando = new SqlCommand();
            daEjecuta = new SqlDataAdapter();
            bool Flag = false;
            try
            {
                bdCon.ConnectionString = Conexion();
                if (bdCon.State == ConnectionState.Closed)
               {
                    bdCon.Open();
                }
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = paramSentencia;
               Comando.Connection = bdCon;
                Comando.ExecuteNonQuery();
                Flag = false;
            }
            catch (SqlException ex)
            {
                Flag = true;
                MessageBox.Show("Error al ejecutar sentencia. " + ex.Message);
            }
            finally
            {
               bdCon.Close();
                Comando.Dispose();
                daEjecuta.Dispose();
            }
            return Flag;
        }

        public DataSet CargaDatos(string paramCriterio,string Tabla)
        {
           bdCon = new SqlConnection();
            Comando = new SqlCommand();
            daEjecuta = new SqlDataAdapter();
            dsConjunto = new DataSet();
            try
            {
                bdCon.ConnectionString = Conexion();
                if (bdCon.State == ConnectionState.Closed)
                {
                    bdCon.Open();
                }
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = paramCriterio;
               Comando.Connection = bdCon;
                daEjecuta.SelectCommand = Comando;
                daEjecuta.Fill(dsConjunto, Tabla);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                bdCon.Close();
                Comando.Dispose();
                daEjecuta.Dispose();
            }
            return dsConjunto;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }



      









    }
}
