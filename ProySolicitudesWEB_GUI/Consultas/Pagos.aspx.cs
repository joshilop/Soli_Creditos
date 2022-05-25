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
    public partial class Pagos : System.Web.UI.Page
    {

        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        SolicitudBL objSolicitudBL = new SolicitudBL();
        SolicitudBE objSolicitudBE = new SolicitudBE();


        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                try
                {
                    /*
                    cboBusqueda.DataSource = objClienteBL.ListarCliente();
                    cboBusqueda.DataValueField = "Id_cli";
                    cboBusqueda.DataTextField = "ApellNombres";
                    cboBusqueda.DataBind();*/

                    /*grvPagos.DataSource = objSolicitudBL.ListarPago();
                    grvPagos.DataBind();

                    lblInfoCant.Text = "Pagos totales generales:";
                    lblNumCant.Text = grvPagos.Rows.Count.ToString();*/
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //if(cboFiltro.SelectedIndex == 0)
            /*{
                try
                {
                    objClienteBE = objClienteBL.ConsultarCliente(txtId.Text);
                    //objClienteBE = objClienteBL.ConsultarCliente(cboBusqueda.SelectedValue);
                    txtNom.Text = objClienteBE.Nom_cli;
                    txtApell.Text = objClienteBE.Ape_cli;
                    txtCod.Text = objClienteBE.Id_cli;
                    txtCorreo.Text = objClienteBE.Email;
                    txtEstCiv.Text = objClienteBE.Est_Civ;
                    txtRUC.Text = objClienteBE.Ruc_cli;
                    txtxDNI.Text = objClienteBE.Dni_cli;

                    grvPagos.DataSource = objSolicitudBL.ListarPagoCliente(objClienteBE.Id_cli);
                    grvPagos.DataBind();

                    lblInfoCant.Text = "Cantidad pagos:";
                    Int32 num = grvPagos.Rows.Count;
                    lblNumCant.Text = num.ToString();
                    if (num == 0)
                    {
                        lblReporte.Text = "El usuario no cuenta con ninguna solicitud aprobada por pagar";
                        lblTitulo.Text = "Sin Solicitud";
                        Label1.Text = "No cuenta con ninguna solicitud";
                        mpeMensaje.Show();
                    }
                    else
                    {
                        lblReporte.Text = "";
                        //lblTitulo.Text = "Mensaje";
                        //Label1.Text = "Si cuenta con solicitud";
                        //mpeMensaje.Show();
                    }
                }
                catch (Exception ex)
                {
                    lblTitulo.Text = "Error";
                    Label1.Text = "Error " + ex.Message;
                    mpeMensaje.Show();
                }
            }
            else
            {*/
            if(txtId.Text.Length != 6)
            {
                lblMensaje.Text = "*El id de la solicitud debe tener 6 caracteres";
                //txtId.Text = "";
                txtNom.Text = "";
                txtApell.Text = "";
                txtCod.Text = "";
                txtCorreo.Text = "";
                txtEstCiv.Text = "";
                txtRUC.Text = "";
                txtxDNI.Text = "";

                grvPagos.DataSource = "";
                grvPagos.DataBind();
            }
            else
            {
                try
                {
                    ClienteBE clienteBE2 = new ClienteBE();
                    objSolicitudBE = objSolicitudBL.ConsultarSolicitud(txtId.Text);
                    //txtCod.Text = objSolicitudBE.Id_cli;
                    clienteBE2 = objClienteBL.ConsultarCliente(objSolicitudBE.Id_cli);
                    txtNom.Text = clienteBE2.Nom_cli;
                    txtApell.Text = clienteBE2.Ape_cli;
                    txtCod.Text = objSolicitudBE.Id_cli;
                    txtCorreo.Text = clienteBE2.Email;
                    txtEstCiv.Text = clienteBE2.Est_Civ;
                    txtRUC.Text = clienteBE2.Ruc_cli;
                    txtxDNI.Text = clienteBE2.Dni_cli;
                    /*txtNom.Text = clienteBE2.Nom_cli;
                    txtApell.Text = clienteBE2.Ape_cli;
                    txtCod.Text = clienteBE2.Id_cli;
                    txtCorreo.Text = clienteBE2.Email;
                    txtEstCiv.Text = clienteBE2.Est_Civ;
                    txtRUC.Text = clienteBE2.Ruc_cli;
                    txtxDNI.Text = clienteBE2.Dni_cli;*/

                    grvPagos.DataSource = objSolicitudBL.ListarPagoCliente(clienteBE2.Id_cli);
                    grvPagos.DataBind();

                    lblInfoCant.Text = "Cantidad pagos del credito:";
                    Int32 num = grvPagos.Rows.Count;
                    lblNumCant.Text = num.ToString();
                    if (num == 0)
                    {
                        lblReporte.Text = "El usuario no cuenta con ninguna solicitud aprobada por pagar";
                        lblTitulo.Text = "Sin solicitud";
                        Label1.Text = "No cuenta con ninguna solicitud";
                        mpeMensaje.Show();
                    }
                    else
                    {
                        lblReporte.Text = "";
                        /*lblTitulo.Text = "Mensaje";
                        Label1.Text = "Si cuenta con solicitud";
                        mpeMensaje.Show();*/
                    }
                    lblMensaje.Text = "";
                }
                catch (Exception ex)
                {
                    lblTitulo.Text = "Error";
                    Label1.Text = "Error " + ex.Message;
                    mpeMensaje.Show();
                }
            }
                
            //}
        }

        protected void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*txtId.Text = "";
            txtNom.Text = "";
            txtApell.Text = "";
            txtCod.Text = "";
            txtCorreo.Text = "";
            txtEstCiv.Text = "";
            txtRUC.Text = "";
            txtxDNI.Text = "";

            grvPagos.DataSource = objSolicitudBL.ListarPago();
            grvPagos.DataBind();

            lblInfoCant.Text = "Pagos totales generales:";
            lblNumCant.Text = grvPagos.Rows.Count.ToString();*/

            /*if (cboFiltro.SelectedIndex == 0)
            {
                cboBusqueda.DataSource = objClienteBL.ListarCliente();
                cboBusqueda.DataValueField = "Id_cli";
                cboBusqueda.DataTextField = "ApellNombres";
                cboBusqueda.DataBind();
            }
            else
            {
                try
                {
                    cboBusqueda.DataSource = objSolicitudBL.ListarSolicitudEstado(3);
                    cboBusqueda.DataValueField = "Id_solicitud";
                    cboBusqueda.DataTextField = "Id_solicitud";
                    cboBusqueda.DataBind();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }*/

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (txtId.Text.StartsWith("S") & txtId.Text.Length == 6)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}