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
    public partial class JugadoresFRM : Form
    {
        public JugadoresFRM()
        {
            InitializeComponent();
        }
        public List<Jugador> Lista_jugadores = new List<Jugador>();

        private void altabtn_Click(object sender, EventArgs e)
        {
            Jugador_am_FRM J = new Jugador_am_FRM();
            J.ShowDialog();
            actualizar_jugadores();
        }
        JugadorBLL JuBLL = new JugadorBLL();
        public void actualizar_jugadores()
        {


            grilla_jugadores.DataSource = null;
            grilla_jugadores.DataSource = JuBLL.retorna_lista_jugadores();



        }

        private void JugadoresFRM_Load(object sender, EventArgs e)
        {
            actualizar_jugadores();
        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            
            {

                Jugador J = new Jugador();
                J = ((Jugador)grilla_jugadores.SelectedRows[0].DataBoundItem);
                Jugador_am_FRM Ju = new Jugador_am_FRM(J);
                Ju.ShowDialog();
                actualizar_jugadores();
            }
            
            
            
            { 
            
            
            }

        }

        private void bajabtn_Click(object sender, EventArgs e)
        {
            Jugador J = new Jugador();
            J = ((Jugador)grilla_jugadores.SelectedRows[0].DataBoundItem);
            JuBLL.borrar_jugador(J);
            actualizar_jugadores();
        }
    }
}
