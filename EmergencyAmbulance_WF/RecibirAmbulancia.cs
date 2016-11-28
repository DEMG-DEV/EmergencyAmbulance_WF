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
    public partial class RecibirAmbulancia : Form
    {
        private string[] Datos;
        public RecibirAmbulancia(string[] datos)
        {
            InitializeComponent();
            Datos = datos;
        }

        private void RecibirAmbulancia_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cargarDatos();
            comboBox1.DisplayMember = "nombreAmbulancia";
            comboBox1.ValueMember = "idEmergencia";
        }

        private DataTable cargarDatos()
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            DataTable datosRow = new DataTable();
            try
            {
                string Query = "SELECT ambulanciasemergencias.idAmbulancia,ambulanciasdisponibles.nombreAmbulancia,ambulanciasemergencias.idEmergencia FROM ambulanciasemergencias,ambulanciasdisponibles WHERE ambulanciasemergencias.idAmbulancia=ambulanciasdisponibles.idAmbulancia;";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                adapter.Fill(datosRow);
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
            }

            return datosRow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = comboBox1.SelectedValue.ToString().Split(',');
            int idEmergencia = Convert.ToInt32(words[0]);
            recibir(idEmergencia);
        }

        private void recibir(int idEmergencia)
        {
            // Obtengo datos segun el id seleccionado en el combobox
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            DataTable datosRow = new DataTable();
            try
            {
                string Query = "SELECT * FROM ambulanciasemergencias WHERE idEmergencia=" + idEmergencia + ";";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                adapter.Fill(datosRow);
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Obtener datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Inserto datos obtenidos con el id seleccionado en combobox
            DataRow row = datosRow.Rows[0];
            try
            {
                string Query = "INSERT INTO ambulanciashistorial(idEmergencia,idAmbulancia,ubicacionEmergencia,horaSalidaEmergencia,horaEntradaEmergencia) VALUES(" + row["idEmergencia"] + "," + row["idAmbulancia"] + ",\"" + row["ubicacionEmergencia"].ToString() + "\",\"" + row["horaSalidaEmergencia"].ToString() + "\",\"" + DateTime.Now.ToString("G") + "\"); ";
                MySqlDataReader adapter = conexion.conexionSendData(Query);
                while (adapter.Read())
                {
                }
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar,\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Actualizar estatus de ambulancia    
            try
            {
                string Query = "UPDATE ambulanciasdisponibles SET disponibleAmbulancia=\"Disponible\" WHERE idAmbulancia=\"" + row["idAmbulancia"] + "\";";
                MySqlDataReader adapter = conexion.conexionSendData(Query);
                while (adapter.Read())
                {
                }
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Editar,\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Eliminar registro de "ambulanciasemergencias"
            try
            {
                string Query = "DELETE FROM ambulanciasemergencias WHERE idEmergencia=" + idEmergencia + ";";
                MySqlDataReader adapter = conexion.conexionSendData(Query);
                while (adapter.Read())
                {
                }
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar,\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Dispose();
        }
    }
}
