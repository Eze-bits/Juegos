using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Presentacion
{
    public partial class pptFRM : Form
    {
        Jugador J;
        JugadorBLL JuBll = new JugadorBLL();
        JugadaBLL JugaBLL = new JugadaBLL();
        
        Piedra_papel_tijera Ppt = new Piedra_papel_tijera();
        public pptFRM(Jugador Ju)
        {
            InitializeComponent();
            J = Ju;

        }

        private void pptFRM_Load(object sender, EventArgs e)
        {
            comboelect.Items.Add("Piedra");
            comboelect.Items.Add("Papel");
            comboelect.Items.Add("Tijera");
        }

        private void jugarbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            int r = 0;


            if (comboelect.SelectedItem.ToString() == "Piedra")
            { n = 1; }
            if (comboelect.SelectedItem.ToString() == "Papel")
            { n = 2; }

            if (comboelect.SelectedItem.ToString() == "Tijera")
            { n = 3; }


            r = J.sumar_puntos(Ppt.Jugada(n));

            if (n == 1 & r == 0) { respuestatxt.Text = "Papel"; resultadotxt.Text = "Perdio"; }
            if (n == 1 & r == 3) { respuestatxt.Text = "Tijera"; resultadotxt.Text = "Gano"; }
            if (n == 1 & r == 1) { respuestatxt.Text = "Piedra"; resultadotxt.Text = "Empate"; }
            if (n == 2 & r == 0) { respuestatxt.Text = "Tijera"; resultadotxt.Text = "Perdio"; }
            if (n == 2 & r == 3) { respuestatxt.Text = "Piedra"; resultadotxt.Text = "Gano"; }
            if (n == 2 & r == 1) { respuestatxt.Text = "Papel"; resultadotxt.Text = "Empate"; }
            if (n == 3 & r == 0) { respuestatxt.Text = "Piedra"; resultadotxt.Text = "Perdio"; }
            if (n == 3 & r == 3) { respuestatxt.Text = "Papel"; resultadotxt.Text = "Gano"; }
            if (n == 3 & r == 1) { respuestatxt.Text = "Tijera"; resultadotxt.Text = "Empate"; }

        

            JuBll.modificar_jugador(J);    ///guardo el puntaje

            Jugada jug = new Jugada();
            jug.Nombre_juego = "Piedra,Papel o Tijera";
            jug.Codigo_jugador = J.Codigo;
            jug.Resultado = resultadotxt.Text;

            JugaBLL.grabar_jugada(jug);


        }
    }
}
