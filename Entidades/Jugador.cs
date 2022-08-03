using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private DateTime VFecha_de_nacimiento;
        #region Propiedades
        public int DNI { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_de_nacimiento { get { return VFecha_de_nacimiento.Date; } set { VFecha_de_nacimiento = value.Date;  } }
        public string Localidad { get; set; }
        public int Puntos { get; set; }
        public TaTeTi Ttt = new TaTeTi();
        public Piedra_papel_tijera Ppt = new Piedra_papel_tijera();
        #endregion
        #region Constructores
        public Jugador(int pDNI, string pNombre, string pApellido,string pEmail,DateTime pFecha_de_nacimiento, string pLocalidad) {

            DNI = pDNI;
            Codigo = 0;
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Fecha_de_nacimiento = pFecha_de_nacimiento;
            Localidad = pLocalidad;
            Puntos = 0;
        }
        public Jugador(int pCodigo,int pDNI, string pNombre, string pApellido, string pEmail, DateTime pFecha_de_nacimiento, string pLocalidad)
        {

            DNI = pDNI;
            Codigo = pCodigo;
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Fecha_de_nacimiento = pFecha_de_nacimiento;
            Localidad = pLocalidad;
            Puntos = 0;
        }

        public Jugador() { }
        #endregion
        public int sumar_puntos(int n) { this.Puntos += n; int r=n; return r; }

    }
}
