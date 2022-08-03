using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace Presentacion
{
    public partial class Jugador_juegosFRM : Form
    {
        public Jugador_juegosFRM()
        {
            InitializeComponent();
        }
        
        JugadorBLL JuBLL = new JugadorBLL();

        private void JugadorpptFRM_Load(object sender, EventArgs e)
        {
            grillajugadores.DataSource = null;

            grillajugadores.DataSource= JuBLL.retorna_lista_jugadores();
        
     
        
        }

        private void jugarbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Jugadores_Click(object sender, EventArgs e)
        {

        }

        private void jugarpptbtn_Click(object sender, EventArgs e)
        {
            Jugador J = (Jugador)(grillajugadores.SelectedRows[0].DataBoundItem);
            pptFRM ppt = new pptFRM(J);
            ppt.Show();
            this.Close();
        }

        private void jugatttbtn_Click(object sender, EventArgs e)
        {
            Jugador J = (Jugador)(grillajugadores.SelectedRows[0].DataBoundItem);
       TaTeTiFRM ttt = new TaTeTiFRM(J);
            ttt.Show();
            this.Close();
        }
    }
}
