using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Entidades;

namespace Mapper
{
    public class JugadaMP
    {
        public void guardar_jugada(Jugada Jug)
        {
            if (System.IO.File.Exists("Lista_jugadas.xml") == false)

            {

                XmlTextWriter Jugadorestwr = new XmlTextWriter("Lista_jugadas.xml", System.Text.Encoding.UTF8);
                Jugadorestwr.Formatting = Formatting.Indented;
                Jugadorestwr.Indentation = 2;
                Jugadorestwr.WriteStartDocument(true);
                Jugadorestwr.WriteStartElement("Jugadas");
                Jugadorestwr.WriteEndElement();
                Jugadorestwr.WriteEndDocument();
                Jugadorestwr.Close();
            }

            XDocument xmlJugadores = XDocument.Load("Lista_jugadas.xml");
            var xDoc = XDocument.Load("Lista_jugadas.xml");

            xmlJugadores.Element("Jugadas").Add(new XElement("Jugada",
                                          new XElement("Nombre_juego", Jug.Nombre_juego),
                                          new XAttribute("Codigo_jugador", Jug.Codigo_jugador),
            new XElement("Resultado", Jug.Resultado)));


            xmlJugadores.Save("Lista_jugadas.xml");
        }

        public int[] lista_graficar()
        {
            int ppt = 0;
            int ttt = 0;
            int[] lista = new int[2];

            if (System.IO.File.Exists("Lista_jugadas.xml") == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Lista_jugadas.xml");

                XmlElement root = doc.DocumentElement;
                XmlNodeList elemList = root.GetElementsByTagName("Nombre_juego");
                foreach (XmlNode nod in elemList)
                {
                    if (nod.InnerXml == "TaTeTi")
                    { ttt++; }
                    if (nod.InnerXml == "Piedra,Papel o Tijera")
                    { ppt++; }

                }

                lista[0] = ppt;
                lista[1] = ttt;
            }

            return lista;
        }

        public int[] graficarxjugadorPPT(int n)
        {
            int ganados = 0;
            int perdidos = 0;
            int empatados = 0;
            int[] estadisticappt = new int[3];

            if (System.IO.File.Exists("Lista_jugadas.xml") == true)
            {
                var query =

                       from Jugada in XElement.Load("Lista_jugadas.xml").Elements("Jugada")

                       select new Jugada
                       {
                           Codigo_jugador = (Convert.ToInt32(Jugada.Attribute("Codigo_jugador").Value)),
                           Nombre_juego = Convert.ToString(Convert.ToString(Jugada.Element("Nombre_juego").Value)),
                           Resultado = (Convert.ToString(Jugada.Element("Resultado").Value)),

                       };


                List<Jugada> Lista_jugadas = query.ToList<Jugada>();

                foreach (Jugada jug in Lista_jugadas)
                {
                    if (jug.Nombre_juego == "Piedra,Papel o Tijera" & jug.Codigo_jugador == n)

                    {
                        if (jug.Resultado == "Gano")
                        { ganados++; }
                        if (jug.Resultado == "Perdio")
                        { perdidos++; }
                        if (jug.Resultado == "Empate")
                        { empatados++; }

                    }

                }

            }
            estadisticappt[0] = ganados;
            estadisticappt[1] = perdidos;
            estadisticappt[2] = empatados;

            return estadisticappt;
        
        }

        public int[] graficarxjugadorTTT(int n) {
            int ganados = 0;
            int perdidos = 0;
            int empatados = 0;
            int[] estadisticattt = new int[3];

            if (System.IO.File.Exists("Lista_jugadas.xml") == true)
            {
                var query =

                       from Jugada in XElement.Load("Lista_jugadas.xml").Elements("Jugada")

                       select new Jugada
                       {
                           Codigo_jugador = (Convert.ToInt32(Jugada.Attribute("Codigo_jugador").Value)),
                           Nombre_juego = Convert.ToString(Convert.ToString(Jugada.Element("Nombre_juego").Value)),
                           Resultado = (Convert.ToString(Jugada.Element("Resultado").Value)),

                       };


                List<Jugada> Lista_jugadas = query.ToList<Jugada>();

                foreach (Jugada jug in Lista_jugadas)
                {
                    if (jug.Nombre_juego == "TaTeTi" & jug.Codigo_jugador == n)

                    {
                        if (jug.Resultado == "Gano")
                        { ganados++; }
                        if (jug.Resultado == "Perdio")
                        { perdidos++; }
                        if (jug.Resultado == "Empate")
                        { empatados++; }

                    }

                }

            }
            estadisticattt[0] = ganados;
            estadisticattt[1] = perdidos;
            estadisticattt[2] = empatados;

            return estadisticattt;
        }
    }
}
