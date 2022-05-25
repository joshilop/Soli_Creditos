using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProySolicitudes_BE;
using ProySolicitudes_BL;

namespace ProySolicitudes_GUI
{
    public partial class InicioSesion : Form
    {

        //Declaramos variables de intentos
        Int16 intentos = 0;
        //Declaramos instancias para autentificacion de Usuarios...
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void ValidaAccesos()
        {
            if(intentos == 3)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el numero de intentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            /*if(txtUsuario.Text.Trim() != "" & txtClave.Text.Trim() != "")
            {
                // Obtenemos las credenciales de acuerdo al login ingresado
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUsuario.Text);

                // Si el usuario no existe
                if(objUsuarioBE.Login_Usuario == null)
                {
                    MessageBox.Show("Usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
                else // Si existiera
                {
                    if(txtUsuario.Text == objUsuarioBE.Login_Usuario & txtClave.Text == objUsuarioBE.Password_Usuario)
                    {
                        // Si las credenciales son correctas se registraran las mismas en la clase  estatica clsCredenciales
                        // Y se lanza el MDI principal
                        this.Hide();

                        // Guardamos las credenciales ....
                        clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                        clsCredenciales.Password = objUsuarioBE.Password_Usuario;
                        clsCredenciales.Nivel = objUsuarioBE.Nivel_Usuario;

                        // Mostramos el MDI...
                        MDIPrincipal mdi = new MDIPrincipal();
                        mdi.ShowDialog();
                    }
                    else // Si el pass es incorrecto
                    {
                        MessageBox.Show("Usuario o Password incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        intentos += 1;
                        ValidaAccesos();

                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligartorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }*/

            bool Valido = objUsuarioBL.Confirmarlogin(txtUsuario.Text.Trim(), txtClave.Text.Trim());
            if (Valido)
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUsuario.Text);
                clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                clsCredenciales.Password = objUsuarioBE.Password_Usuario;
                clsCredenciales.Nivel = objUsuarioBE.Nivel_Usuario;

                this.Hide();
                MDIPrincipal mdi = new MDIPrincipal();
                mdi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Password incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }

            
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InicioSesion_KeyDown(object sender, KeyEventArgs e)
        {
            //Para al pulsar enter  acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
