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

        private void button1_Click(object sender, EventArgs e)
        {
            string emergenciaout = listBox1.Items[0].ToString();
            string id = emergenciaout.Substring(emergenciaout.Length - 1, 1);
            //MessageBox.Show("" + id);

            agregarEmergencia(id);

            listBox1.Items.RemoveAt(0);
        }

        private void agregarEmergencia(string id)
        {
            int idAmbulancia = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Disponible")
                {
                    MessageBox.Show("" + dataGridView1.Rows[i].Cells[0].Value.ToString());
                    idAmbulancia = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
            ConexionMySQL conexion = new ConexionMySQL();
            if (idAmbulancia != 0)
            {
                try
                {
                    string Query = "INSERT INTO ambulanciasemergencias(idAmbulancia,ubicacionEmergencia,horaSalidaEmergencia) VALUES(" + idAmbulancia + ",\"" + emergencias[0].latitudEmergencia + "," + emergencias[0].longitudEmergencia + "\",\"" + DateTime.Now.ToString("G") + "\");";
                    MySqlDataReader adapter = conexion.conexionSendData(Query);
                    while (adapter.Read())
                    {
                    }
                    conexion.conexionClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                emergencias.RemoveAt(0);

                try
                {
                    string Query = "UPDATE ambulanciasdisponibles SET disponibleAmbulancia=\"No Disponible\" WHERE idAmbulancia=" + idAmbulancia + ";";
                    MySqlDataReader adapter = conexion.conexionSendData(Query);
                    while (adapter.Read())
                    {
                    }
                    conexion.conexionClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarAmbulancias();
            }
        }
    }
}
