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
using System.Diagnostics;
using System.Net.Http;
using System.Net;
using ProySolicitudes_GUI.CodigoUsuario;
using ProySolicitudes_GUI.EntidadNegocio;

namespace ProySolicitudes_GUI
{
    public partial class ClienteMan02 : Form
    {

        ClienteBE objClienteBE = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();

        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
                cboEstCivil.SelectedItem = "Soltero/a";
                /*CargarEstadoCivil(1);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*private void CargarEstadoCivil(Int16 EstCiv)
        {
            cboEstCivil.DataSource = objClienteBL.ListarCliente();
            cboEstCivil.ValueMember = "Estado_civil";
            cboEstCivil.DisplayMember = "Est_civil";
            cboEstCivil.SelectedValue = EstCiv;
        }*/

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento("14");
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento("14", IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objClienteBE.Id_cli = "";
                objClienteBE.Nom_cli = txtNombre.Text.Trim();
                objClienteBE.Ape_cli = txtApellido.Text.Trim();
                objClienteBE.Dni_cli = mskDNI.Text;
                objClienteBE.Ruc_cli = mskRUC.Text;

                if (rdbMasculino.Checked == true)
                {
                    objClienteBE.Sexo = "M";
                }
                else
                {
                    objClienteBE.Sexo = "F";
                }
                
                objClienteBE.Fec_nacimiento = dtpFecNacimiento.Value.Date;
                objClienteBE.Nivel_educacion = txtEducacion.Text.Trim();
                //objClienteBE.Estado_civil = Convert.ToInt16(cboEstCivil.Text);

                if (cboEstCivil.SelectedItem.Equals("Soltero/a"))
                {
                    objClienteBE.Estado_civil = 1;
                }
                else if (cboEstCivil.SelectedItem.Equals("Casado/a"))
                {
                    objClienteBE.Estado_civil = 2;
                }
                else if (cboEstCivil.SelectedItem.Equals("Viudo/a"))
                {
                    objClienteBE.Estado_civil = 3;
                }
                else
                {
                    objClienteBE.Estado_civil = 4;
                }

                objClienteBE.Email = txtEmail.Text.Trim();
                
                if (chkActivo.Checked == true)
                {
                    objClienteBE.Est_cli = 1;
                }
                else
                {
                    objClienteBE.Est_cli = 2;
                }

                objClienteBE.Usu_registro = clsCredenciales.Usuario;

                objClienteBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();

                if (objClienteBL.InsertarCliente(objClienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";

            txtApellido.Text = "";
            txtNombre.Text = "";
            lblMensaje.Text = "";

            string numeroDNI = mskDNI.Text;
            if (string.IsNullOrWhiteSpace(numeroDNI))
                return;

            Stopwatch oCronometro = new Stopwatch();
            oCronometro.Start();

            CuTexto oCuTexto = new CuTexto();
            button1.Enabled = false;

            CookieContainer cookies = new CookieContainer();
            HttpClientHandler controladorMensaje = new HttpClientHandler();
            controladorMensaje.CookieContainer = cookies;
            controladorMensaje.UseCookies = true;
            using (HttpClient cliente = new HttpClient(controladorMensaje))
            {
                cliente.DefaultRequestHeaders.Add("Host", "eldni.com");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"90\", \"Google Chrome\";v=\"90\"");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "none");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
                cliente.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
                cliente.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |
                                                       SecurityProtocolType.Tls12;

                string url = "https://eldni.com/pe/buscar-por-dni";
                using (HttpResponseMessage resultadoConsultaToken = await cliente.GetAsync(new Uri(url)))
                {
                    if (resultadoConsultaToken.IsSuccessStatusCode)
                    {
                        mensajeRespuesta = await resultadoConsultaToken.Content.ReadAsStringAsync();

                        string token = oCuTexto.ExtraerContenidoEntreTagString(mensajeRespuesta, 0, "name=\"_token\" value=\"", "\">");

                        cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Site");

                        cliente.DefaultRequestHeaders.Add("Origin", "https://eldni.com");
                        cliente.DefaultRequestHeaders.Add("Referer", "https://eldni.com/pe/buscar-por-dni");
                        cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");

                        EnDNI.DatoExterno1Solicitud oDatoExterno1Solicitud = new EnDNI.DatoExterno1Solicitud();
                        oDatoExterno1Solicitud._token = token;
                        oDatoExterno1Solicitud.dni = numeroDNI;
                        using (HttpResponseMessage resultadoConsultaDatos = await cliente.PostAsJsonAsync(url, oDatoExterno1Solicitud))
                        {
                            if (resultadoConsultaDatos.IsSuccessStatusCode)
                            {
                                string contenidoHTML = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                string nombreInicio = "<table class=\"table table-striped table-scroll\">";
                                string nombreFin = "</table>";
                                string contenidoDNI = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
                                if (contenidoDNI == "")
                                {
                                    nombreInicio = "<h3 class=\"text-error\">";
                                    nombreFin = "</h3>";
                                    mensajeRespuesta = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
                                    mensajeRespuesta = mensajeRespuesta == ""
                                        ? string.Format(
                                            "No se pudo realizar la consulta del número de DNI {0}.", numeroDNI)
                                        : string.Format(
                                            "No se pudo realizar la consulta del número de DNI {0}.\r\nDetalle: {1}",
                                            numeroDNI,
                                            mensajeRespuesta);
                                }
                                else
                                {
                                    nombreInicio = "<td>";
                                    nombreFin = "</td>";
                                    string[] arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoDNI, 0,
                                        nombreInicio,
                                        nombreFin);
                                    if (arrResultado != null)
                                    {
                                        // Nombres
                                        arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoDNI,
                                            Convert.ToInt32(arrResultado[0]),
                                            nombreInicio, nombreFin);
                                        if (arrResultado != null)
                                        {
                                            txtNombre.Text = arrResultado[1];

                                            // Apellido Paterno
                                            arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoDNI,
                                                Convert.ToInt32(arrResultado[0]),
                                                nombreInicio, nombreFin);

                                            if (arrResultado != null)
                                            {
                                                txtApellido.Text = arrResultado[1];
                                                    tipoRespuesta = 1;
                                                    mensajeRespuesta = string.Format("Se realizó exitosamente la consulta del número de DNI {0}",
                                                                numeroDNI);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                mensajeRespuesta = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                mensajeRespuesta =
                                    string.Format(
                                        "Ocurrió un inconveniente al consultar los datos del DNI {0}.\r\nDetalle:{1}",
                                        numeroDNI, mensajeRespuesta);
                            }
                        }
                    }
                    else
                    {
                        mensajeRespuesta = await resultadoConsultaToken.Content.ReadAsStringAsync();
                        mensajeRespuesta =
                            string.Format(
                                "Ocurrió un inconveniente al consultar el número de DNI {0}.\r\nDetalle:{1}",
                                numeroDNI, mensajeRespuesta);
                    }
                }
            }

            oCronometro.Stop();


            if (tipoRespuesta > 1)
                MessageBox.Show(mensajeRespuesta, "Consultar DNI"
                    , MessageBoxButtons.OK
                    , tipoRespuesta == 2 ? MessageBoxIcon.Warning : MessageBoxIcon.Error);

            lblMensaje.Text = string.Format("Procesado en {0} seg.", oCronometro.Elapsed.TotalSeconds);

            button1.Enabled = true;
            mskDNI.Focus();
            mskDNI.SelectAll();
        }

        /*
        private async void button1_Click(object sender, EventArgs e)
        {
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";

            txtApellido.Text = "";
            txtNombre.Text = "";
            lblMensaje.Text = "";

            string numeroDNI = mskDNI.Text;
            if (string.IsNullOrWhiteSpace(numeroDNI))
                return;

            Stopwatch oCronometro = new Stopwatch();
            oCronometro.Start();

            button1.Enabled = false;

            CuTexto oCuTexto = new CuTexto();

            CookieContainer cookies = new CookieContainer();
            HttpClientHandler controladorMensaje = new HttpClientHandler();
            controladorMensaje.CookieContainer = cookies;
            controladorMensaje.UseCookies = true;

            using (HttpClient cliente = new HttpClient(controladorMensaje))
            {
                cliente.DefaultRequestHeaders.Add("Host", "aplicaciones007.jne.gob.pe");
                cliente.DefaultRequestHeaders.Add("Referer", "https://www.google.com/");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"91\", \"Google Chrome\";v=\"91\"");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "cross-site");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
                cliente.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
                cliente.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |
                                                       SecurityProtocolType.Tls12;

                string urlCodigo = "https://aplicaciones007.jne.gob.pe/srop_publico/Consulta/Afiliado";
                string urlDato =
                    "https://aplicaciones007.jne.gob.pe/srop_publico/Consulta/api/AfiliadoApi/GetNombresCiudadano";
                using (HttpResponseMessage resultadoConsultaToken = await cliente.GetAsync(urlCodigo))
                {
                    if (resultadoConsultaToken.IsSuccessStatusCode)
                    {
                        string contenidoHTML = await resultadoConsultaToken.Content.ReadAsStringAsync();
                        string nombreInicio = "pTokenCookie('";
                        string nombreFin = "'";
                        string pTokenCookie = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
                        nombreInicio = "pTokenForm('";
                        nombreFin = "'";
                        string pTokenForm = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);

                        cliente.DefaultRequestHeaders.Remove("Referer");
                        cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Dest");
                        cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Mode");
                        cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Site");

                        cliente.DefaultRequestHeaders.Add("Origin", "https://aplicaciones007.jne.gob.pe");
                        cliente.DefaultRequestHeaders.Add("Referer", "https://aplicaciones007.jne.gob.pe/srop_publico/Consulta/Afiliado");
                        cliente.DefaultRequestHeaders.Add("RequestVerificationToken", string.Format("{0}:{1}", pTokenCookie, pTokenForm));
                        cliente.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                        cliente.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                        cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
                        cliente.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

                        EnDNI.DatoJNESolictud oEnDatoJNESolictud = new EnDNI.DatoJNESolictud();
                        oEnDatoJNESolictud.CODDNI = numeroDNI;
                        using (HttpResponseMessage resultadoConsultaDatos = await cliente.PostAsJsonAsync(urlDato, oEnDatoJNESolictud))
                        {
                            if (resultadoConsultaDatos.IsSuccessStatusCode)
                            {
                                EnDNI.DatoJNERespuesta oDatoJNERespuesta = await resultadoConsultaDatos.Content.ReadAsAsync<EnDNI.DatoJNERespuesta>();
                                string contenido = oDatoJNERespuesta.data;
                                mensajeRespuesta = oDatoJNERespuesta.mensaje;
                                string[] arrContenido = contenido.Split('|');
                                if (arrContenido[0] == "")
                                {
                                    mensajeRespuesta = mensajeRespuesta == ""
                                        ? string.Format("No existe el número DNI {0}", numeroDNI)
                                        : string.Format("No existe el número DNI {0}\r\nDetalle: {1}", numeroDNI,
                                            mensajeRespuesta);
                                }
                                else
                                {
                                    txtApellido.Text = arrContenido[0];
                                    txtNombre.Text = arrContenido[2];

                                    tipoRespuesta = oDatoJNERespuesta.success ? 1 : 2;
                                }
                            }
                            else
                            {
                                mensajeRespuesta = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                mensajeRespuesta =
                                    string.Format(
                                        "Ocurrió un inconveniente al consultar los datos del DNI {0}.\r\nDetalle:{1}",
                                        numeroDNI, mensajeRespuesta);
                            }
                        }
                    }
                    else
                    {
                        mensajeRespuesta = await resultadoConsultaToken.Content.ReadAsStringAsync();
                        mensajeRespuesta =
                            string.Format(
                                "Ocurrió un inconveniente al consultar el número de DNI {0}.\r\nDetalle:{1}",
                                numeroDNI, mensajeRespuesta);
                    }
                }
            }


            oCronometro.Stop();


            if (tipoRespuesta > 1)
                MessageBox.Show(mensajeRespuesta, "Consultar DNI"
                    , MessageBoxButtons.OK
                    , tipoRespuesta == 2 ? MessageBoxIcon.Warning : MessageBoxIcon.Error);

            lblMensaje.Text = string.Format("Procesado en {0} seg.", oCronometro.Elapsed.TotalSeconds);

            button1.Enabled = true;
            mskDNI.Focus();
            mskDNI.SelectAll();
        */
    }
    
}
