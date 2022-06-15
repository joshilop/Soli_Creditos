using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using ProySolicitudes_BL;
// Agregar para el excel
using OfficeOpenXml;
using System.IO;

namespace ProySolicitudesWEB_GUI
{
    public partial class MenuSolicitudes : System.Web.UI.Page
    {
        GarantiaBL objGarantiaBL = new GarantiaBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "¡Hola " + Session["Usuario"].ToString() + "! Bienvenido a su pagina de consultas de Caja Crédito Perú";
            ScriptManager scriptManager = ScriptManager.GetCurrent(this.Page);
            scriptManager.RegisterPostBackControl(this.btnDescarga);
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