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
    public class JugadorMP
    {
        public void graba_jugad(Jugador J)
        {

            if (System.IO.File.Exists("Jugadores.xml") == false)

            {

                XmlTextWriter Jugadorestwr = new XmlTextWriter("Jugadores.xml", System.Text.Encoding.UTF8);
                Jugadorestwr.Formatting = Formatting.Indented;
                Jugadorestwr.Indentation = 2;
                Jugadorestwr.WriteStartDocument(true);
                Jugadorestwr.WriteStartElement("Jugadores");
                Jugadorestwr.WriteEndElement();
                Jugadorestwr.WriteEndDocument();
                Jugadorestwr.Close();
            }

            XDocument xmlJugadores = XDocument.Load("Jugadores.xml");
            var xDoc = XDocument.Load("Jugadores.xml");
            int conteo = xDoc.Descendants("Jugador").Count();
            xmlJugadores.Element("Jugadores").Add(new XElement("Jugador",
                                          new XAttribute("DNI", J.DNI),
                                          new XElement("Codigo", conteo + 1),
                                          new XElement("Nombre", J.Nombre),
                                          new XElement("Apellido", J.Apellido),
                                          new XElement("Email", J.Email),
                                          new XElement("Fecha_de_nacimiento", J.Fecha_de_nacimiento.ToShortDateString()),
                                          new XElement("Localidad", J.Localidad),
            new XElement("Puntos", 0)));


            xmlJugadores.Save("Jugadores.xml");

        }


        public bool checkear_jugador(int DNI)

        {
            if (System.IO.File.Exists("Jugadores.xml") == false)    // checkea si existe el archivo

            { return true; }           /// no existe retorna true

            else
            {
                var query =

                    from Jugador in XElement.Load("Jugadores.xml").Elements("Jugador")

                    select new Jugador
                    {
                        DNI = Convert.ToInt32(Convert.ToString(Jugador.Attribute("DNI").Value))

                    };

                List<Jugador> Jugador_consulta = query.ToList<Jugador>();

                foreach (Jugador Ju in Jugador_consulta)
                {
                    if (Ju.DNI == DNI)

                        return false;     /// existe el dni retorna falso
                }
                return true;              /// si llega hasta aca no encontro DNI retorna true
            }
        }

        public List<Jugador> retorna_lista_jugadores()
        {
            if (System.IO.File.Exists("Jugadores.xml") == true)
            {
                var query =

                       from Jugador in XElement.Load("Jugadores.xml").Elements("Jugador")

                       select new Jugador
                       {
                           DNI = Convert.ToInt32(Convert.ToString(Jugador.Attribute("DNI").Value)),
                           Codigo = Convert.ToInt32(Convert.ToString(Jugador.Element("Codigo").Value)),
                           Nombre = (Convert.ToString(Jugador.Element("Nombre").Value)),
                           Apellido = (Convert.ToString(Jugador.Element("Apellido").Value)),
                           Email = (Convert.ToString(Jugador.Element("Email").Value)),
                           Fecha_de_nacimiento = Convert.ToDateTime(Jugador.Element("Fecha_de_nacimiento").Value),
                           Localidad = (Convert.ToString(Jugador.Element("Localidad").Value)),
                           Puntos = (Convert.ToInt32(Jugador.Element("Puntos").Value))

                       };


                List<Jugador> Lista_jugadores = query.ToList<Jugador>();
                return Lista_jugadores;
            }
            else
            {
                List<Jugador> Lista_vacia = new List<Jugador>();
                return Lista_vacia;
            }
        }


        public void borrar_jugador(Jugador J)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("Jugadores.xml");

            XmlElement Jugadores = archivo.DocumentElement;
            XmlNodeList lista_jugadores = archivo.SelectNodes("Jugadores/Jugador");

            foreach (XmlNode nodo in lista_jugadores)

            {
                if (nodo.SelectSingleNode("@DNI").InnerText == Convert.ToString(J.DNI))
                {
                    Jugadores.RemoveChild(nodo);
                    archivo.Save("Jugadores.xml");
                    break;
                }
            }
        }

        public void modificar_jugador(Jugador J) {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("Jugadores.xml");

            XmlElement Jugadores = archivo.DocumentElement;
            XmlNodeList lista_jugadores = archivo.SelectNodes("Jugadores/Jugador");

            foreach (XmlNode nodo in lista_jugadores)

            {
                if (nodo.SelectSingleNode("@DNI").InnerText == Convert.ToString(J.DNI))
                {
                    Jugadores.RemoveChild(nodo);
                    archivo.Save("Jugadores.xml");
                    break;
                }
            }


            XDocument xmlJugadores = XDocument.Load("Jugadores.xml");
            var xDoc = XDocument.Load("Jugadores.xml");
          
            xmlJugadores.Element("Jugadores").Add(new XElement("Jugador",
                                          new XAttribute("DNI", J.DNI),
                                          new XElement("Codigo", J.Codigo),
                                          new XElement("Nombre", J.Nombre),
                                          new XElement("Apellido", J.Apellido),
                                          new XElement("Email", J.Email),
                                          new XElement("Fecha_de_nacimiento", J.Fecha_de_nacimiento.ToShortDateString()),
                                          new XElement("Localidad", J.Localidad),
            new XElement("Puntos", J.Puntos)));


            xmlJugadores.Save("Jugadores.xml");








        }






    }

}

