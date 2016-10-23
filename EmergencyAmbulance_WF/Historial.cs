using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Windows.Forms;

namespace EmergencyAmbulance_WF
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(25.5428443, -103.40678609999998);
            cargarHistorial();
        }

        private void cargarHistorial()
        {
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker;
            ConexionMySQL conexion = new ConexionMySQL();
            DataTable datosRow = new DataTable();
            try
            {
                string Query = "SELECT	ambulanciasdisponibles.nombreAmbulancia,ambulanciashistorial.* FROM ambulanciashistorial, ambulanciasdisponibles WHERE ambulanciashistorial.idAmbulancia = ambulanciasdisponibles.idAmbulancia";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                adapter.Fill(datosRow);
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
            }

            // Añadir datos al mapa
            foreach (DataRow row in datosRow.Rows)
            {
                string[] latlng = row["ubicacionEmergencia"].ToString().Split(',');

                marker = new GMarkerGoogle(
                    new PointLatLng(Convert.ToDouble(latlng[0]), Convert.ToDouble(latlng[1])), GMarkerGoogleType.lightblue_pushpin);
                markers.Markers.Add(marker);
                marker.ToolTipText = "Folio: " + row["idEmergencia"] + "\n" + row["nombreAmbulancia"] + "\n" +
                    "Salida: " + row["horaSalidaEmergencia"] + "\n" + "Regreso: " + row["horaEntradaEmergencia"];
                marker.ToolTip.Fill = Brushes.DarkCyan;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                gMapControl1.Overlays.Add(markers);
            }
        }
    }
}
