using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
            System.Threading.Thread newThread = new System.Threading.Thread(emergenciaAleatoria);
            newThread.Start();
            CheckForIllegalCrossThreadCalls = false;
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

        private void emergenciaAleatoria()
        {
            Random r = new Random();
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = r.Next(1000, 10000);
            aTimer.Enabled = true;
        }

        List<dataEmergencia> emergencias = new List<dataEmergencia>();
        int count = 0;
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            count++;

            Random random = new Random();

            // Convert radius from meters to degrees
            double radiusInDegrees = 50000 / 111000f;

            double u = random.NextDouble();
            double v = random.NextDouble();
            double w = radiusInDegrees * Math.Sqrt(u);
            double t = 2 * Math.PI * v;
            double x = w * Math.Cos(t);
            double y = w * Math.Sin(t);

            // Adjust the x-coordinate for the shrinking of the east-west distances
            double new_x = x / Math.Cos(25.5428);

            double foundLongitude = new_x + -103.4068;
            double foundLatitude = y + 25.5428;

            dataEmergencia de = new dataEmergencia();
            de.idEmergencia = count;
            de.nombreEmergencia = "Emergencia Num. " + count;
            de.latitudEmergencia = foundLatitude;
            de.longitudEmergencia = foundLongitude;

            emergencias.Add(de);

            listBox1.Items.Add(de.ToString());

        }
    }
}
