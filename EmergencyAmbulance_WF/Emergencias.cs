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
    public partial class Emergencias : Form
    {
        public Emergencias()
        {
            InitializeComponent();
        }

        private void Emergencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emergencyDataSet.ambulanciasdisponibles' table. You can move, or remove it, as needed.
            cargarAmbulancias();
        }

        private void cargarAmbulancias()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                string Query = "SELECT idAmbulancia,nombreAmbulancia,combustibleAmbulancia,disponibleAmbulancia FROM ambulanciasdisponibles";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);
                dataGridView1.DataSource = datos;
                conexion.conexionClose();

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Combustible";
                dataGridView1.Columns[3].HeaderText = "Disponibilidad";

                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 50;
                dataGridView1.Columns[3].Width = 100;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
