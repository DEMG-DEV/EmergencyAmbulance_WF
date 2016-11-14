using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmergencyAmbulance_WF
{
    public partial class Login : Form
    {
        public string[] data;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = new string[3];
            data[0] = textBox1.Text;
            data[1] = textBox2.Text;
            data[2] = textBox3.Text;

            bool dato = checarConexion();

            if (dato == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (dato == false)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private bool checarConexion()
        {
            ConexionMySQL conexion = new ConexionMySQL(data);
            DataTable datosRow = new DataTable();
            try
            {
                string Query = "SELECT COUNT(*) FROM emergency.ambulanciasdisponibles;";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                adapter.Fill(datosRow);
                if (datosRow.Rows.Count >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexion.conexionClose();
            }

        }
    }
}
