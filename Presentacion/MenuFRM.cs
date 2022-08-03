using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuFRM : Form
    {
        public MenuFRM()
        {
            InitializeComponent();
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JugadoresFRM F = new JugadoresFRM();
            F.MdiParent = this;
            F.Show();
        }

        private void piedraPapelOTijeraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void piedrapapelOTijeraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void juegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jugador_juegosFRM F = new Jugador_juegosFRM();
            F.MdiParent = this;
            F.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformesFRM I = new InformesFRM();
            I.MdiParent = this;
            I.Show();
        }

        private void informePorJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformexJugadorFRM I = new InformexJugadorFRM();
            I.MdiParent = this;
            I.Show();
        }
    }
}
