using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Milibreria
  
{
    public class Class1
    {
        private string conexion;
        SqlConnection bdCon;
        SqlCommand Comando;
        SqlDataAdapter daEjecuta;
        DataSet dsConjunto;


        public static DataSet Ejecutar(String cmd)
        {


            SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=Escuelita_horarios;Integrated Security=True");
            Conexion.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
            DP.Fill(DS);
            Conexion.Close();
            return DS;

        }

        public string Conexion
        {
            get
            {
                return "Data Source=JONAS-PC;Initial Catalog=AgendaAlumnos;Integrated Security=True";
            }
        }

        public bool EjecutaSentencia(string paramSentencia)
        {
            bdCon = new SqlConnection();
            Comando = new SqlCommand();
            daEjecuta = new SqlDataAdapter();
            bool Flag = false;
            try
            {
                bdCon.ConnectionString = Conexion;
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
               
               
            }
            finally
            {
                bdCon.Close();
                Comando.Dispose();
                daEjecuta.Dispose();
            }
            return Flag;
        }

    }
}
