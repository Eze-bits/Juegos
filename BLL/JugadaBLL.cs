using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using Entidades;

namespace BLL
{

    public class JugadaBLL
    {
        JugadaMP jugMP = new JugadaMP();
        public void grabar_jugada(Jugada Jug)
        { jugMP.guardar_jugada(Jug); }
        public int[] lista_graficar() { return jugMP.lista_graficar(); }
        public int[] graficarxjugadorTTT(int n) { return jugMP.graficarxjugadorTTT(n); }
        public int[] graficarxjugadorPPT(int n) { return jugMP.graficarxjugadorPPT(n); }

    }
}
