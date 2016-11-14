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
    public partial class Reportes : Form
    {
        private string[] Datos;

        public Reportes(string[] datos)
        {
            InitializeComponent();
            Datos = datos;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emergencyDataSet1.reporte_medico' table. You can move, or remove it, as needed.
            this.reporte_medicoTableAdapter.Fill(this.emergencyDataSet1.reporte_medico);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int idReporte = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                cargarDatos(idReporte);
            }
        }

        private void cargarDatos(int idReporte)
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            DataTable datosRow = new DataTable();
            try
            {
                string Query = "SELECT * FROM reporte_medico WHERE idReporte=" + idReporte;
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                adapter.Fill(datosRow);
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
            }

            DataRow row = datosRow.Rows[0];

            // Llena campos de texto
            textBox2.Text = row["idReporte"].ToString();
            textBox1.Text = getAmbulancia(Convert.ToInt32(row["idAmbulancia"].ToString()));
            textBox3.Text = row["fechaReporte"].ToString();
            textBox4.Text = row["nombrePaciente"].ToString();
            textBox5.Text = row["apellidoPaciente"].ToString();
            textBox6.Text = row["edadPaciente"].ToString();
            textBox7.Text = row["sexoPaciente"].ToString();
            textBox8.Text = row["presionPaciente"].ToString();
            textBox9.Text = row["pulsoPaciente"].ToString();
            textBox10.Text = row["sangrePaciente"].ToString();
            textBox11.Text = Convert.ToString(row["diagnosticoPaciente"]);
        }

        private string getAmbulancia(int idAmbulancia)
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            DataTable datosRow = new DataTable();
            try
            {
                string Query = "SELECT nombreAmbulancia FROM ambulanciasdisponibles WHERE idAmbulancia=" + idAmbulancia;
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                adapter.Fill(datosRow);
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
            }

            DataRow row = datosRow.Rows[0];

            return row["nombreAmbulancia"].ToString();
        }
    }
}
