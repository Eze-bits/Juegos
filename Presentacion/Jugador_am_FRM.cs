using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entidades;
using BLL;
using System.Xml.Linq;
using System.Xml;


namespace Presentacion
{
    public partial class Jugador_am_FRM : Form
    {
        public Jugador_am_FRM()                ///ALTA
        {
            InitializeComponent();
            modbtn.Hide();
            codigotxt.Hide();
            label3.Hide();
        }
        Jugador Jp;
        public Jugador_am_FRM(Jugador J)      ////MODIFICACION
        {
            InitializeComponent();

            dnitxt.Text = Convert.ToString(J.DNI);
            codigotxt.Text = Convert.ToString(J.Codigo);
            nombretxt.Text = J.Nombre;
            apetxt.Text = J.Apellido;
            nactxt.Text = J.Fecha_de_nacimiento.ToShortDateString();
            loctxt.Text = J.Localidad;
            emailtxt.Text = J.Email;
            codigotxt.ReadOnly = true;
            dnitxt.ReadOnly = true;
            altabtn.Hide();
            Jp = J;
        }
        JugadorBLL JuBLL = new JugadorBLL();

        private void altabtn_Click(object sender, EventArgs e)    ///   ALTA
        {

            try

            {
                if (JuBLL.checkear_jugador(Convert.ToInt32(dnitxt.Text)) == true)
                {
                    Regex nalx = new Regex(@"^[a-zA-Z]+$");
                    Regex dnirx = new Regex("^([0-9]{7}|[0-9]{8})$");
                    Regex nacx = new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$");
                    Regex emailx = new Regex("^\\S+@\\S+\\.\\S+$");

                    if (nalx.IsMatch(Convert.ToString(loctxt.Text)) == false | nalx.IsMatch(Convert.ToString(nombretxt.Text)) == false | nalx.IsMatch(Convert.ToString(apetxt.Text)) == false)

                    { MessageBox.Show("Error: localidad, nombre y apellido solo se puede ingresar con letras"); }


                    else
                    {
                        if (dnirx.IsMatch(Convert.ToString(dnitxt.Text)) == false)
                        {
                            MessageBox.Show("Error: El numero de DNI solo debe poseer 7 u 8 cifras");
                        }
                        else
                        {
                            if (nacx.IsMatch(nactxt.Text) == false)
                            {
                                MessageBox.Show("Error en el formato de fecha debe ser dd/mm/aaaa ");
                            }
                            else

                            {
                                if (emailx.IsMatch(emailtxt.Text) == false)
                                { MessageBox.Show("Error en el formato de email"); }
                                else
                                {
                                    Jugador Ju = new Jugador(Convert.ToInt32(dnitxt.Text), nombretxt.Text, apetxt.Text, emailtxt.Text, Convert.ToDateTime(nactxt.Text), loctxt.Text);
                                    JuBLL.graba_jugador(Ju);
                                    MessageBox.Show("El alta de jugador se realizo correctamente");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else { MessageBox.Show("Error al dar alta al usuario, ya existe el DNI"); }
            }

            catch { MessageBox.Show("Error al dar alta al usuario"); }

        }

        private void modbtn_Click(object sender, EventArgs e)
        {
           try {
                if (JuBLL.checkear_jugador(Convert.ToInt32(dnitxt.Text)) == true)
                {
                    Regex nalx = new Regex(@"^[a-zA-Z]+$");
                    Regex dnirx = new Regex("^([0-9]{7}|[0-9]{8})$");
                    Regex nacx = new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$");
                    Regex emailx = new Regex("^\\S+@\\S+\\.\\S+$");

                    if (nalx.IsMatch(Convert.ToString(loctxt.Text)) == false | nalx.IsMatch(Convert.ToString(nombretxt.Text)) == false | nalx.IsMatch(Convert.ToString(apetxt.Text)) == false)

                    { MessageBox.Show("Error: localidad, nombre y apellido solo se puede ingresar con letras"); }


                    else
                    {
                        if (dnirx.IsMatch(Convert.ToString(dnitxt.Text)) == false)
                        {
                            MessageBox.Show("Error: El numero de DNI solo debe poseer 7 u 8 cifras");
                        }
                        else
                        {
                            if (nacx.IsMatch(nactxt.Text) == false)
                            {
                                MessageBox.Show("Error en el formato de fecha debe ser dd/mm/aaaa ");
                            }
                            else

                            {
                                if (emailx.IsMatch(emailtxt.Text) == false)
                                { MessageBox.Show("Error en el formato de email"); }
                                else
                                {
                                    Jugador Ju = new Jugador(Convert.ToInt32(dnitxt.Text), nombretxt.Text, apetxt.Text, emailtxt.Text, Convert.ToDateTime(nactxt.Text), loctxt.Text);
                                    Ju.Puntos = Jp.Puntos;
                                    Ju.Codigo = Jp.Codigo;

                                    JuBLL.modificar_jugador(Ju);
                                    MessageBox.Show("La modificacion del jugador se realizo correctamente");
                                    this.Close();
                                }
                            }
                        }
                    }

                }
                else { MessageBox.Show("Error al modificar jugador, ya existe el DNI"); }
            }
            catch{ MessageBox.Show("Error al modificar jugador"); }


        }
    }
}
