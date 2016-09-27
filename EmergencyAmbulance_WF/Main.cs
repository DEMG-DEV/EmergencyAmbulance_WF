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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Historial his = new Historial();
            his.MdiParent = this;
            his.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes();
            rep.MdiParent = this;
            rep.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Emergencias eme = new Emergencias();
            eme.MdiParent = this;
            eme.Show();
        }
    }
}
