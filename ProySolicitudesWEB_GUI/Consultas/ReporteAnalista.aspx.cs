using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProySolicitudes_BL;
using ProySolicitudes_BE;

namespace ProySolicitudesWEB_GUI.Consultas
{
    public partial class ReporteAnalista : System.Web.UI.Page
    {

        AnalistasBL objAnalistaBL = new AnalistasBL();
        AnalistaBE objAnalistaBE = new AnalistaBE();
        SolicitudBL objSolicitudBL = new SolicitudBL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Page.IsPostBack == false)
                {
                    cboAnalista.DataSource = objAnalistaBL.ListarAnalista();
                    cboAnalista.DataValueField = "Id_analista";
                    cboAnalista.DataTextField = "ApellNombres";
                    cboAnalista.DataBind();

                    /*grvSolicitud.DataSource = objSolicitudBL.ListarSolicitud();
                    grvSolicitud.DataBind();*/

                    /*lblCantReg.Text = grvSolicitud.Rows.Count.ToString();*/

                    //lblInforme.Text = "Solicitudes generales totales:";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objAnalistaBE = objAnalistaBL.ConsultarAnalista(cboAnalista.SelectedValue);
                txtCod.Text = objAnalistaBE.Id_analista;
                txtAgencia.Text = objAnalistaBE.Nom_agencia;
                txtDNI.Text = objAnalistaBE.DNI_analista;
                txtEmail.Text = objAnalistaBE.Email_analista;
                txtFecIng.Text = objAnalistaBE.FecIngreso.ToString();

                grvSolicitud.DataSource = objSolicitudBL.ListarSolicitudEstAna(objAnalistaBE.Id_analista, cboEstado.SelectedItem.ToString());
                grvSolicitud.DataBind();
                lblCantReg.Text = grvSolicitud.Rows.Count.ToString();
                lblInforme.Text = "El sistema registra las siguientes solicitudes:";

                if(grvSolicitud.Rows.Count == 0)
                {
                    lblMensaje.Text = "El analista no tiene ninguna solitud " + cboEstado.SelectedItem;
                }
                else
                {
                    lblMensaje.Text = "";
                }
                /*lblTitulo.Text = "Mensaje";
                Label1.Text = "Calculos correctos";
                mpeMensaje.Show();*/
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