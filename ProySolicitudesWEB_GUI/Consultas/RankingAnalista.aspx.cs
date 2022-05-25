using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProySolicitudes_BL;

namespace ProySolicitudesWEB_GUI.Consultas
{

    public partial class RankingAnalista : System.Web.UI.Page
    {

        SolicitudBL objSolicitudBL = new SolicitudBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            grvTopSolicitud.DataSource = objSolicitudBL.RankingAnalistas(10, 3);
            grvTopSolicitud.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                grvTopSolicitud.DataSource = objSolicitudBL.RankingAnalistas(Convert.ToInt16(txtTop.Text), Convert.ToInt16(DropDownList1.SelectedValue));
                grvTopSolicitud.DataBind();
                lblTitulo.Text = "Mensaje";
                Label1.Text = "Calculos correctos";
                mpeMensaje.Show();

            }
            catch (Exception ex)
            {
                lblTitulo.Text = "Error";
                Label1.Text = "Error " + ex.Message;
                mpeMensaje.Show();
            }
            
            
        }
    }
}