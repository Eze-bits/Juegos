using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using Entidades;


namespace Presentacion
{
    public partial class InformesFRM : Form
    {
        public InformesFRM()
        {
            InitializeComponent();
        }
        JugadaBLL jugBLL = new JugadaBLL();
        public void graficar()
        {
            int[] lista_jugadas = new int[2];
            string[] lista_juegos = new string[2];
            lista_juegos[0] = "Piedra Papel, o Tijera";
            lista_juegos[1] = "TaTeTI";


            jugBLL.lista_graficar().CopyTo(lista_jugadas,0);
          
            chart1.Series[0].Points.DataBindXY(lista_juegos, lista_jugadas);
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        }

        private void InformesFRM_Load(object sender, EventArgs e)
        {
            graficar();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
