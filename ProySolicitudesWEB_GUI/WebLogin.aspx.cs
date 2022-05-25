using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProySolicitudes_BE;
using ProySolicitudes_BL;

namespace SitioVentasWEB_GUI
{
    public partial class WebLogin : System.Web.UI.Page
    {

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Valido = objUsuarioBL.Confirmarlogin(txtUsuario.Text.Trim(), txtPass.Text.Trim());
                if (Valido)
                {
                    Session["Usuario"] = txtUsuario.Text;
                    Response.Redirect("Consultas/MenuSolicitudes.aspx");
                }
                else
                {
                    throw new Exception("Usuario o password errados.");
                }



                // Usuario y password obligatorios
                /*if (txtUsuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el usuario.");
                }

                if (txtPass.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el password.");
                }


                // Validamos el usuario y contraseña

                if (txtUsuario.Text.Trim() == "ISIL" & txtPass.Text.Trim() == "12345")
                {
                    Response.Redirect("Consultas/MenuSolicitudes.aspx");
                }
                else
                {
                    throw new Exception("Usuario o password errados.");
                }*/

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}