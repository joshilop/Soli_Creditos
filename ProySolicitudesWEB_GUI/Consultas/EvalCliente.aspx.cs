using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProySolicitudes_BE;
using ProySolicitudes_BL;
using System.Data;
// Agregar para el excel
using OfficeOpenXml;
using System.IO;

namespace ProySolicitudesWEB_GUI.Consultas
{
    public partial class EvalCliente : System.Web.UI.Page
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        GarantiaBL objGarantiaBL = new GarantiaBL();
        SolicitudBL objSolicitudBL = new SolicitudBL();
        IngresoBL objIngresoBL = new IngresoBL();
        DataView dtv;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    dtv = new DataView(objGarantiaBL.ListarGarantia());
                    Session["Vista"] = dtv;
                    cboCliente.DataSource = objClienteBL.ListarCliente();
                    cboCliente.DataValueField = "Id_cli";
                    cboCliente.DataTextField = "ApellNombres";
                    cboCliente.DataBind();
                    //CargarDatos("");
                    //Cambiando
                    /*cboCliente.DataSource = objClienteBL.ListarCliente();
                    cboCliente.DataValueField = "Id_cli";
                    cboCliente.DataTextField = "ApellNombres";
                    cboCliente.DataBind();*/


                    /*lblInfoIngr.Text = "Estas son todos los ingresos: ";                    
                    grvIngresos.DataSource = objIngresoBL.ListarIngreso();
                    grvIngresos.DataBind();
                    lblCantIngr.Text = grvIngresos.Rows.Count.ToString();

                    lblInfoGaran.Text = "Estas son todas las garantias: ";                    
                    grvGarantia.DataSource = objGarantiaBL.ListarGarantia();
                    grvGarantia.DataBind();
                    lblCantGaran.Text = grvGarantia.Rows.Count.ToString();

                    lblInfoSoli.Text = "Estas son todas las solicitudes: ";                    
                    grvSolicitud.DataSource = objSolicitudBL.ListarSolicitud();
                    grvSolicitud.DataBind();
                    lblCantSoli.Text = grvSolicitud.Rows.Count.ToString();*/

                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cambios
                objClienteBE = objClienteBL.ConsultarCliente(cboCliente.SelectedValue);

                //Cambiado
                /*objClienteBE = objClienteBL.ConsultarCliente(cboCliente.SelectedValue);*/
                txtCod.Text = objClienteBE.Id_cli;
                txtEdad.Text = objClienteBE.Edad.ToString();
                txtEmail.Text = objClienteBE.Email;
                txtDNI.Text = objClienteBE.Dni_cli;
                txtEstCivil.Text = objClienteBE.Est_Civ;
                txtRUC.Text = objClienteBE.Ruc_cli;

                lblInfoIngr.Text = "Total ingresos del cliente: ";
                grvIngresos.DataSource = objIngresoBL.ListarIngresoXcliente(objClienteBE.Id_cli);
                grvIngresos.DataBind();
                lblCantIngr.Text = grvIngresos.Rows.Count.ToString();
                if(grvIngresos.Rows.Count == 0)
                {
                    lblReporteIngresos.Text = "El cliente no cuenta con ingresos registrados";
                }

                lblInfoGaran.Text = "Total garantias del cliente: ";
                grvGarantia.DataSource = objGarantiaBL.ListarGarantiaXcliente(objClienteBE.Id_cli);
                grvGarantia.DataBind();
                lblCantGaran.Text = grvGarantia.Rows.Count.ToString();
                if(grvGarantia.Rows.Count == 0)
                {
                    lblReporteGarantia.Text = "El cliente no cuenta con garantias registradas";
                }

                lblInfoSoli.Text = "Total solicitudes del cliente: ";
                grvSolicitud.DataSource = objSolicitudBL.ListarSolicitudXcliente(objClienteBE.Id_cli);
                grvSolicitud.DataBind();
                lblCantSoli.Text = grvSolicitud.Rows.Count.ToString();
                if(grvSolicitud.Rows.Count == 0)
                {
                    lblReporteSolicitudes.Text = "El clente no cuenta con solicitudes registradas";
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
//}