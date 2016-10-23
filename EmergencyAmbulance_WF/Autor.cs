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
    public partial class Autor : Form
    {
        private string getAutores()
        {
            return "Autores:\nDavid Enrique Mendez Guardado\nLuis Fernando Herrera Facio\nGerardo Emmanuel Mendiola Rosales\n" +
                "\nProfesor:\nNayeli Rocio Banda Aguilar";
        }
        public Autor()
        {
            InitializeComponent();
            label1.Text = getAutores();
        }
    }
}
