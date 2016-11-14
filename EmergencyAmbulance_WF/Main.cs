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
        private string[] data;
        public Main()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Historial his = new Historial(data);
            his.MdiParent = this;
            his.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes(data);
            rep.MdiParent = this;
            rep.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Emergencias eme = new Emergencias(data);
            eme.MdiParent = this;
            eme.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor a = new Autor();
            a.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            DialogResult res = l.ShowDialog();

            if (res == DialogResult.OK)
            {
                this.data = l.data;
            }
            else if (res == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
