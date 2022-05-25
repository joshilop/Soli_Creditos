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
                ScriptManager scriptManager = ScriptManager.GetCurrent(this.Page);
                scriptManager.RegisterPostBackControl(this.btnDescarga);
                if (Page.IsPostBack == false)
                {
                    dtv = new DataView(objGarantiaBL.ListarGarantia());
                    Session["Vista"] = dtv;
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

        private void CargarDatos(String strFiltro)
        {
            dtv = (DataView)Session["Vista"];
            dtv.RowFilter = "Id_cli like '%" + strFiltro + "%'";
            grvGarantia.DataSource = dtv;
            grvGarantia.DataBind();

            if (grvGarantia.Rows.Count == 0)
            {
                lblMensaje.Text = "No existen registros con el filtro indicado";
                mpeMensaje.Show();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cambios
                objClienteBE = objClienteBL.ConsultarCliente(txtIdCli.Text);

                //Cambiado
                /*objClienteBE = objClienteBL.ConsultarCliente(cboCliente.SelectedValue);*/
                txtCod.Text = objClienteBE.Nom_cli;
                txtApellido.Text = objClienteBE.Ape_cli;
                txtDNI.Text = objClienteBE.Dni_cli;
                txtEdad.Text = objClienteBE.Edad.ToString();
                txtEmail.Text = objClienteBE.Email;
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

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(txtIdCli.Text.StartsWith("C") & txtIdCli.Text.Length == 7)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void btnDescarga_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo plantilla del reporte en desarrollo
                String rutaarchivo = Server.MapPath("/") + @"Consultas\ListadoProveedores.xlsx";
                // Ruta del archivo plantilla en produccion (publicado)
                //String rutaarchivo = Server.MapPath("/") + @"SitioVentasWEB_GUI\Mantenimientos\ListadoProveedores.xlsx";

                // Obtenemos los proveedores
                DataTable dtClientes = new DataTable();
                dtClientes = objGarantiaBL.ListarGarantia();
                // fila de inicio del reporte
                Int16 fila1 = 5;
                using (var pck = new OfficeOpenXml.ExcelPackage(new FileInfo(rutaarchivo)))
                {
                    ////Nombre de archivo para descargar
                    String filename = "ListadoGarantias-" + DateTime.Today.ToShortDateString();
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                    ////llenamos el Excel con los proveedores
                    foreach (DataRow drProveedor in dtClientes.Rows)
                    {
                        ws.Cells[fila1, 1].Value = drProveedor["Id_cli"].ToString();
                        ws.Cells[fila1, 2].Value = drProveedor["Tip_Garantia"].ToString();
                        ws.Cells[fila1, 3].Value = drProveedor["Des_garantia"].ToString();
                        ws.Cells[fila1, 4].Value = drProveedor["Valor_garantia"].ToString();
                        /*ws.Cells[fila1, 5].Value = drProveedor["Departamento"].ToString() + "-" + drProveedor["Provincia"].ToString() + "-" +
                                                                 drProveedor["Distrito"].ToString();
                        ws.Cells[fila1, 6].Value = drProveedor["Rep_ven"].ToString();*/
                        fila1 += 1;
                    }

                    ////modificando el ancho de las columnas
                    ws.Column(1).Width = 30;
                    ws.Column(2).Width = 50;
                    ws.Column(3).Width = 50;
                    ws.Column(4).Width = 40;
                    ws.Column(5).Width = 45;
                    ws.Column(6).Width = 45;

                    //Escribir de nuevo al cliente y descargar el archivo desde el navegador
                    Response.Clear();
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.AddHeader("content-disposition", "attachment;  filename=" + filename + ".xlsx");
                    using (var memoryStream = new MemoryStream())
                    {
                        pck.SaveAs(memoryStream);
                        memoryStream.WriteTo(Response.OutputStream);
                    }
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }
    }
    }
//}