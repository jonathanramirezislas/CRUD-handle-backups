using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Respaldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuscar1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
              //  BrowseBackupBtn.Enabled = true;
            }


        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Escuelita_horarios;Integrated Security=True");

            con.Open();
          

            String database = con.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    //  s.Speak("please enter the valid backup file location");
                    MessageBox.Show("please enter the backup file location");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + textBox1.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, con);
                    scmd.ExecuteNonQuery();
                    // s.Speak("Backup taken successfully");
                    MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //button2.Enabled = false;

                }
            }
            catch (Exception)
            {

            }
            con.Close();
    }

        private void buttonBuscar2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Escuelita_horarios;Integrated Security=True");

            con.Open();
            String database = con.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    //  s.Speak("please enter the valid backup file location");
                    MessageBox.Show("please enter the backup file location");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + textBox1.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, con);
                    scmd.ExecuteNonQuery();
                    // s.Speak("Backup taken successfully");
                    MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //button2.Enabled = false;

                }
            }
            catch (Exception)
            {

            }
            con.Close();
    }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Escuelita_horarios;Integrated Security=True");

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
          //      RestoreBtn.Enabled = true;
            }
            //code for the restore button
            con.Open();
            String database = con.Database.ToString();
            try
            {

                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                // s.Speak("Database Restored successfully");
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  button2.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close();
            }

        }
    }
}
