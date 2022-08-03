using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Entidades
{
    public class Piedra_papel_tijera : Juego
    {

        public override void Descripcion() { this.Nombre = "Piedra,Papel o Tijera"; }

        public int Jugada(int n)        ///1=Piedra , 2= Papel, 3=Tijera
        {
            Random aleatorio = new Random();
            int a = aleatorio.Next(1, 4);
            int resultado = 0;
            string jugador = "";
            string PC = "";
            switch (n)            //jugador
            {
                case 1:
                    jugador = "Piedra";
                    break;
                case 2:
                    jugador = "Papel";
                    break;

                case 3:
                    jugador = "Tijera";
                    break;
            }

            switch (a)             ///PC
            {
                case 1:
                    PC = "Piedra";
                    break;
                case 2:
                    PC = "Papel";
                    break;

                case 3:
                    PC = "Tijera";
                    break;
            }

            switch (jugador)
            {
                case "Piedra":
                    if (PC == "Piedra")
                    { resultado = 1; }

                    if (PC == "Papel")
                    { resultado = 0; }

                    if (PC == "Tijera")
                    { resultado = 3; }

                    break;

                case "Papel":
                    if (PC == "Piedra")
                    { resultado = 3; }

                    if (PC == "Papel")
                    { resultado = 1; }

                    if (PC == "Tijera")
                    { resultado = 0; }

                    break;

                case "Tijera":
                    if (PC == "Piedra")
                    { resultado = 0; }

                    if (PC == "Papel")
                    { resultado = 3; }

                    if (PC == "Tijera")
                    { resultado = 1; }
                    break;

            }
            return resultado;

        }

        public Piedra_papel_tijera()
        {
            Descripcion();
            Cod_juego = 100;

        }





    }
}
