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
    public partial class TaTeTiFRM : Form
    {
        public TaTeTiFRM(Jugador J)
        {
            InitializeComponent();
            Ju = J;
        }
      
        public TaTeTi TTT = new TaTeTi();
        public Jugador Ju;
        public JugadorBLL Jug_BLL = new JugadorBLL();
        public JugadaBLL JuBLL = new JugadaBLL();
        
        
        public void recibir_tablero(string[] t)
        {

            if (t[0] == "O")
            {
                btn0.Text = "O";
                btn0.Enabled = false;
            }

            if (t[1] == "O")
            {
                btn1.Text = "O";
                btn1.Enabled = false;
            }
            if (t[2] == "O")
            {
                btn2.Text = "O";
                btn2.Enabled = false;
            }
            if (t[3] == "O")
            {
                btn3.Text = "O";
                btn3.Enabled = false;
            }

            if (t[4] == "O")
            {
                btn4.Text = "O";
                btn4.Enabled = false;
            }
            if (t[5] == "O")
            {
                btn5.Text = "O";
                btn5.Enabled = false;
            }

            if (t[6] == "O")
            {
                btn6.Text = "O";
                btn6.Enabled = false;
            }

            if (t[7] == "O")
            {
                btn7.Text = "O";
                btn7.Enabled = false;
            }
            if (t[8] == "O")
            {
                btn8.Text = "O";
                btn8.Enabled = false;
            }

        }


        public string[] enviar_tablero()
        {
            string[] tablero = new string[9];

            switch (btn0.Text)
            {
                case "X":
                    tablero[0] = "X";
                    break;
                case "O":
                    tablero[0] = "O";
                    break;
            }

            switch (btn1.Text)
            {
                case "X":
                    tablero[1] = "X";
                    break;
                case "O":
                    tablero[1] = "O";
                    break;
            }

            switch (btn2.Text)
            {
                case "X":
                    tablero[2] = "X";
                    break;
                case "O":
                    tablero[2] = "O";
                    break;
            }
            switch (btn3.Text)
            {
                case "X":
                    tablero[3] = "X";
                    break;
                case "O":
                    tablero[3] = "O";
                    break;
            }

            switch (btn4.Text)
            {
                case "X":
                    tablero[4] = "X";
                    break;
                case "O":
                    tablero[4] = "O";
                    break;
            }


            switch (btn5.Text)
            {
                case "X":
                    tablero[5] = "X";
                    break;
                case "O":
                    tablero[5] = "O";
                    break;
            }

            switch (btn6.Text)
            {
                case "X":
                    tablero[6] = "X";
                    break;
                case "O":
                    tablero[6] = "O";
                    break;
            }

            switch (btn7.Text)
            {
                case "X":
                    tablero[7] = "X";
                    break;
                case "O":
                    tablero[7] = "O";
                    break;
            }

            switch (btn8.Text)
            {
                case "X":
                    tablero[8] = "X";
                    break;
                case "O":
                    tablero[8] = "O";
                    break;
            }


            return tablero;
        }

        public void resetear_tablero()
        {

            btn0.Text = ""; btn0.Enabled = true;
            btn1.Text = ""; btn1.Enabled = true;
            btn2.Text = ""; btn2.Enabled = true;
            btn3.Text = ""; btn3.Enabled = true;
            btn4.Text = ""; btn4.Enabled = true;
            btn5.Text = ""; btn5.Enabled = true;
            btn6.Text = ""; btn6.Enabled = true;
            btn7.Text = ""; btn7.Enabled = true;
            btn8.Text = ""; btn8.Enabled = true;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            ((Button)sender).Text = "X";

            switch (TTT.checkear_ganador(enviar_tablero()))
            {
                case "X":

                    jugador_gano();
                    break;

                case "O":
                    pc_gano();
                    break;

                case "E":
                    empate();
                    break;

                case "C":
                    recibir_tablero(TTT.Jugada(enviar_tablero()));
                    string resultado = TTT.checkear_ganador(enviar_tablero());
                    if (resultado == "O") { pc_gano(); }
                    if (resultado == "X") { jugador_gano();  }
                    if (resultado == "E") { empate(); }
                    break;

            }

        }

        public void anular_tablero()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
        }

        public void jugador_gano()
        {
            MessageBox.Show("El jugador gano el juego!!");
            Ju.sumar_puntos(5);
            Jug_BLL.modificar_jugador(Ju);
            Jugada jugad = new Jugada();
            jugad.Codigo_jugador = Ju.Codigo;
            jugad.Nombre_juego = TTT.Nombre;
            jugad.Resultado = "Gano";
            JuBLL.grabar_jugada(jugad);
            anular_tablero();
            nuevobtn.Show();
        }

        public void empate()
        {
            MessageBox.Show("Se ha producido un empate!!");
            Ju.sumar_puntos(1);
            Jug_BLL.modificar_jugador(Ju);
            Jugada jugad = new Jugada();
            jugad.Codigo_jugador = Ju.Codigo;
            jugad.Nombre_juego = TTT.Nombre;
            jugad.Resultado = "Empate";
            JuBLL.grabar_jugada(jugad);


            anular_tablero();
            nuevobtn.Show();
        }


        public void pc_gano()
        {
            MessageBox.Show("La Pc gano el juego!!");
            Jugada jugad = new Jugada();
            jugad.Codigo_jugador = Ju.Codigo;
            jugad.Nombre_juego = TTT.Nombre;
            jugad.Resultado = "Perdio";
            JuBLL.grabar_jugada(jugad);


            anular_tablero();
            nuevobtn.Show();

        }

        private void TaTeTiFRM_Load(object sender, EventArgs e)
        {
            nuevobtn.Hide();
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            resetear_tablero();
            nuevobtn.Hide();
        }
    }
}
