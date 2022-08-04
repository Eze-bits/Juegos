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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class InformexJugadorFRM : Form
    {
        public InformexJugadorFRM()
        {
            InitializeComponent();
        }
        JugadorBLL JuBLL = new JugadorBLL();
        JugadaBLL JugadBLL = new JugadaBLL();
        private void InformexJugadorFRM_Load(object sender, EventArgs e)
        {
            grilla_jugadores.DataSource = null;
            grilla_jugadores.DataSource = JuBLL.retorna_lista_jugadores();
        }

        private void grilla_jugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

               

                Jugador J= (Jugador)grilla_jugadores.SelectedRows[0].DataBoundItem;
                
                int[] ppt = new int[3];
                int[] ttt = new int[3];
                string[] etiquetas = new string[3];
                etiquetas[0] = "Ganados";
                etiquetas[1] = "Perdidos";
                etiquetas[2] = "Empatados";
                JugadBLL.graficarxjugadorPPT(J.Codigo).CopyTo(ppt,0);
                JugadBLL.graficarxjugadorTTT(J.Codigo).CopyTo(ttt,0);

                chart1.Series[0].Points.DataBindXY(etiquetas, ppt);
                chart1.Series[0].ChartType = SeriesChartType.Pie;
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                chart2.Series[0].Points.DataBindXY(etiquetas, ttt);
                chart2.Series[0].ChartType = SeriesChartType.Pie;
                chart2.ChartAreas[0].Area3DStyle.Enable3D = true;




            }
            catch { }
        }
    }
}
