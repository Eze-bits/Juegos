using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;
using System.Xml.Linq;
using System.Xml;


namespace BLL
{

    public class JugadorBLL
    {
        JugadorMP jMP = new JugadorMP();
        public void graba_jugador(Jugador J) { jMP.graba_jugad(J); }
        public void borrar_jugador(Jugador J) { jMP.borrar_jugador(J); }
        public List<Jugador> retorna_lista_jugadores() { return jMP.retorna_lista_jugadores(); }
        public void modificar_jugador(Jugador J) { jMP.modificar_jugador(J); }
        
        public bool checkear_jugador(int DNI) { return jMP.checkear_jugador(DNI); }
    }
}