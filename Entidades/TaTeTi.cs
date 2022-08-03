using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TaTeTi : Juego
    {
        public override void Descripcion()
        {
            this.Nombre = "TaTeTi";
        }

        public TaTeTi() { Descripcion(); Cod_juego = 101; }


        public string checkear_ganador(string[] r)
        {
            if (r[0] == r[1] & r[1] == r[2] & r[0] != null & r[1] != null & r[2] != null)   ///filas
            {
                switch (r[0])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }
            if (r[3] == r[4] & r[4] == r[5] & r[3] != null & r[4] != null & r[5] != null)
            {
                switch (r[3])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }

            if (r[6] == r[7] & r[7] == r[8] & r[6] != null & r[7] != null & r[8] != null)
            {
                switch (r[6])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }

            if (r[0] == r[3] & r[3] == r[6] & r[0] != null & r[3] != null & r[6] != null)   //columnas
            {
                switch (r[0])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }

            if (r[1] == r[4] & r[4] == r[7] & r[1] != null & r[4] != null & r[7] != null)
            {
                switch (r[1])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }

            if (r[2] == r[5] & r[5] == r[8] & r[2] != null & r[5] != null & r[8] != null)
            {
                switch (r[2])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }

            if (r[0] == r[4] & r[4] == r[8] & r[0] != null & r[4] != null & r[8] != null)    /// diagonales
            {
                switch (r[0])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }

            if (r[2] == r[4] & r[4] == r[6] & r[2] != null& r[4] != null & r[6] != null)
            {
                switch (r[2])
                {
                    case "X":
                        return "X";
                    case "O":
                        return "O";
                }
            }
            int cont = 0;                    // checkeo si hay empate contando los casilleros ocupados
            foreach (string t in r)
            {
                if (t != null)
                    cont++;
            }

            if (cont == 9)
            { return "E"; }                     /// E si hay empate


            return "C";                         ///C continua el juego
        }



        public string[] Jugada(string[] r)
        {

            string[] resultado= new string[9];

            while (true)
            {
                Random aleatorio = new Random();
                int a = aleatorio.Next(0, 9);
                if (r[a] == null)
                {
                    r[a] = "O";
                    break;
                }

            }

            r.CopyTo(resultado,0);

            return resultado;
        }




    }
}
