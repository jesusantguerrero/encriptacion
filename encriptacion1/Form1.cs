/*
* program by Jesus Guerrero
* grupo: Jesus Guerrero , Tommy Suazo , Ezequiel Williams y Jahiro Manzano
* april 1st 2017
* Practica: programa que maneje el concepto de encriptacion
* Univeridad Dominicana OyM
* Materia: Comunicacion Avanzada De Datos 
* 
*/


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace encriptacion1
{
    public partial class F_principal : Form
    {

        private string nombre;
        private string contrasenia;
        private string mensaje;
        private string cifrado = "";
        private List<char> caracteres = new List<char>();


        public F_principal()
        {
            InitializeComponent();


        }

        // principal buttons / botones principales

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            if (btn_encriptar.Text == "Encriptar")
            {
                encriptar();
            }
            else
            {
                descifrar();
            }

        }

        //  menu buttons / los botones del menu

        private void btn_m_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_m_minimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // native window behavior / funciones para que se comporte como una venana nativa

        private void p_headbar_MouseDown(object sender, MouseEventArgs e)
        {
            CustomWindow.ReleaseCapture();
            CustomWindow.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void lbl_title_MouseDown(object sender, MouseEventArgs e)
        {
            CustomWindow.ReleaseCapture();
            CustomWindow.SendMessage(Handle, 0x112, 0xf012, 0);
        }



        // encripting methods / metodos de encriptación

        private void encriptar()
        {
            if (is_valid())
            {
                nombre = txt_nombre.Text;
                contrasenia = txt_contrasenia.Text;
                mensaje = rtxt_mensaje.Text;

                for (int i = 0; i < mensaje.Length; i++)
                {
                    caracteres.Add(mensaje[i]);
                    caracteres[i] = Convert.ToChar(caracteres[i] + 1);
                    cifrado += caracteres[i];
                }

                mensaje = "";

                borrarCampos();
                btn_encriptar.Text = "Descifrar";
                rtxt_mensaje.Text = cifrado;
                MessageBox.Show("Su mensaje ha sido encriptado para descifrarlo ingrese sus datos y haga click en descifrar");

            }
            else
            {
                MessageBox.Show("llene todo los campos por favor");
            }

        }


        private void descifrar()
        {
            if (is_info())
            {
                btn_encriptar.Text = "Encriptar";

                for (int i = 0; i < caracteres.Count; i++)
                {
                    caracteres[i] = Convert.ToChar(caracteres[i] - 1);
                    mensaje += caracteres[i];
                }

                caracteres.Clear();
                cifrado = "";
                rtxt_mensaje.Text = mensaje;
                MessageBox.Show(this, "sr(a) " + nombre + " su mensaje descifrado es '" + mensaje + "'", "Mensaje Descifrado");

            }
            else
            {
                MessageBox.Show("sus datos no corresponden con los que ingresó al entrar el mensaje");
            }

        }


        private void borrarCampos()
        {
            txt_nombre.Text = "";
            txt_contrasenia.Text = "";
            rtxt_mensaje.Text = "";
        }

        private bool is_valid()
        {
            bool result = false;
            if (txt_nombre.Text != "" && txt_contrasenia.Text != "" && rtxt_mensaje.Text != "")
            {
                result = true;
            }

            return result;
        }


        private bool is_info()
        {
            bool result = false;
            if (txt_nombre.Text == nombre && txt_contrasenia.Text == contrasenia)
            {
                result = true;
            }
            return result;
        }

        private void btn_m_info_Click(object sender, EventArgs e)
        {
            var info = "Este programa fue realizado por el grupo conformado por: \n \n * Jesus Guerrero \n * Jahiro Manzano,";
            info += " \n * Ezequiel Williams \n * Tommy suazo \n \n Para una practica de";
            info += "Comunicacion Avanzada De Datos";
            MessageBox.Show(info);
        }
    }
}
