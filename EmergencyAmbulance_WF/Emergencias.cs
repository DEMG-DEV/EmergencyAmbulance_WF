using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace EmergencyAmbulance_WF
{
    public partial class Emergencias : Form
    {
        List<dataEmergencia> emergenciasList = new List<dataEmergencia>();
        GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
        GMap.NET.WindowsForms.GMapMarker marker;
        int count = 0;

        private string[] Datos;

        public Emergencias(string[] datos)
        {
            InitializeComponent();
            Datos = datos;
            //webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Emergencias_Load(object sender, EventArgs e)
        {
            // se cargan las ambulancias
            cargarAmbulancias();

            // Inicia thread que busca cada 30 seg en la bd de emergencia
            System.Threading.Thread newThread = new System.Threading.Thread(cargarEmergencias);
            newThread.Start();
            CheckForIllegalCrossThreadCalls = false;

            // se crea mapa y se localiza a la mitad de Torreón
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(25.5428443, -103.40678609999998);
            //gMapControl1.SetPositionByKeywords("Torreón, Coahuila de Zaragoza");
        }

        // Codigo relacionado a la generacion aleatoria de emergencias
        private void cargarEmergencias()
        {
            Random r = new Random();
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 15000;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            // limpia List y arraylist
            listBox1.Items.Clear();
            emergenciasList.Clear();
            marker = null;
            markers.Clear();

            // codigo nuevo, solo carga las emergencias de la BD
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            try
            {
                string Query = "SELECT idEmergencia,ubicacionEmergencia FROM emergencias WHERE statusEmergencia=\"Activo\"";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);
                conexion.conexionClose();

                if (datos.Rows.Count != 0)
                {
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        String[] latLong = datos.Rows[i][1].ToString().Split(',');

                        dataEmergencia de = new dataEmergencia();
                        de.idEmergencia = Convert.ToInt64(datos.Rows[i][0].ToString());
                        de.nombreEmergencia = "Emergencia Num. " + Convert.ToInt64(datos.Rows[i][0].ToString());
                        de.latitudEmergencia = Convert.ToDouble(latLong[0].ToString());
                        de.longitudEmergencia = Convert.ToDouble(latLong[1].ToString());

                        emergenciasList.Add(de);

                        listBox1.Items.Add(de.ToString());

                        // posiciona la emergencia en el mapa
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(latLong[0]), Convert.ToDouble(latLong[1])), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.lightblue);
                        markers.Markers.Add(marker);
                        marker.ToolTipText = de.nombreEmergencia;
                        marker.ToolTip.Fill = Brushes.DarkCyan;
                        marker.ToolTip.Foreground = Brushes.White;
                        marker.ToolTip.Stroke = Pens.Black;
                        marker.ToolTip.TextPadding = new Size(20, 20);
                        gMapControl1.Overlays.Add(markers);
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }

        // Codigo relacionado a MySQL
        private void cargarAmbulancias()
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            try
            {
                string Query = "SELECT * FROM ambulanciasdisponibles";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);
                dataGridView1.DataSource = datos;
                conexion.conexionClose();

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Disponibilidad";

                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 100;
            }
            catch (Exception ex)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emergenciaout = listBox1.Items[0].ToString();
            string id = emergenciaout.Substring(emergenciaout.Length - 1, 1);
            //MessageBox.Show("" + id);

            agregarEmergencia(id);
            cambiarStatusEmergencia(id);

            listBox1.Items.RemoveAt(0);
            markers.Markers.RemoveAt(0);
            gMapControl1.Overlays.Add(markers);
        }

        private void cambiarStatusEmergencia(string id)
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            try
            {
                string Query = "UPDATE emergencias SET statusEmergencia=\"No Activo\" WHERE idEmergencia=" + id + ";";
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
        }

        private void agregarEmergencia(string id)
        {
            int idAmbulancia = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Disponible")
                {
                    //MessageBox.Show("" + dataGridView1.Rows[i].Cells[0].Value.ToString());
                    idAmbulancia = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            if (idAmbulancia != 0)
            {
                try
                {
                    string Query = "INSERT INTO ambulanciasemergencias(idEmergencia,idAmbulancia,ubicacionEmergencia,horaSalidaEmergencia) VALUES(" + emergenciasList[0].idEmergencia + "," + idAmbulancia + ",\"" + emergenciasList[0].latitudEmergencia + "," + emergenciasList[0].longitudEmergencia + "\",\"" + DateTime.Now.ToString("G") + "\");";
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
                emergenciasList.RemoveAt(0);

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

        private void button2_Click(object sender, EventArgs e)
        {
            RecibirAmbulancia ra = new RecibirAmbulancia(Datos);
            ra.ShowDialog(this);
            cargarAmbulancias();
        }
    }
}