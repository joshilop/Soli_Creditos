using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProySolicitudesWEB_GUI
{
    public partial class MenuSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "¡Hola " + Session["Usuario"].ToString() + "! Bienvenido a su pagina de consultas de Caja Crédito Perú";
        }
    }
}