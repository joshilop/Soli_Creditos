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
    public partial class SolicitudMan02 : Form
    {

        SolicitudBE objSolicitudBE = new SolicitudBE();
        SolicitudBL objSolicitudBL = new SolicitudBL();

        public SolicitudMan02()
        {
            InitializeComponent();
        }

        private void SolicitudMan02_Load(object sender, EventArgs e)
        {
            cboProducto.SelectedItem = "Prestamo Facil";
            cboEstado.SelectedItem = "En proceso";
            cboCuotas.SelectedItem = "6";
            CargarCliente("C000001");
            CargarAnalista("AA00001");

            
            dtpFecAprobacion.Enabled = false;
            dtpFecRechazo.Enabled = false;
            txtMotivo.Enabled = false;
            chkDesembolso.Enabled = false;

        }

        private void CargarAnalista(String IdAnalista)
        {
            AnalistasBL objAnalistaBL = new AnalistasBL();

            cboAnalista.DataSource = objAnalistaBL.ListarAnalista();
            cboAnalista.ValueMember = "Id_analista";
            cboAnalista.DisplayMember = "ApellNombres";
            cboAnalista.SelectedValue = IdAnalista;
        }

        private void CargarCliente(String IdCliente)
        {
            ClienteBL objClienteBL = new ClienteBL();

            cboCliente.DataSource = objClienteBL.ListarCliente();
            cboCliente.ValueMember = "Id_cli";
            cboCliente.DisplayMember = "ApellNombres";
            cboCliente.SelectedValue = IdCliente;

        }

        private void cboEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("En proceso"))
            {
                dtpFecRechazo.Enabled = false;
                dtpFecAprobacion.Enabled = false;
                
            }
            else if (cboEstado.SelectedItem.Equals("Aprobada"))
            {
                dtpFecAprobacion.Enabled = true;
                dtpFecRechazo.Enabled = false;
                chkDesembolso.Enabled = true;
            }
            else
            {
                dtpFecRechazo.Enabled = true;
                dtpFecAprobacion.Enabled = false;
                txtMotivo.Enabled = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objSolicitudBE.Id_solicitud = "";
                objSolicitudBE.Id_cli = cboCliente.SelectedValue.ToString();
                
                objSolicitudBE.Id_analista = cboAnalista.SelectedValue.ToString();
                objSolicitudBE.Motivo_rechazo = txtMotivo.Text.Trim();
                objSolicitudBE.Cuotas = Convert.ToInt16(cboCuotas.SelectedItem);
                objSolicitudBE.Monto_solici = Convert.ToSingle(mskMonto.Text.Trim());
                objSolicitudBE.Num_cuenta = mskCuenta.Text;

                if (chkDesembolso.Checked == true & cboEstado.SelectedItem.Equals("Aprobada"))
                {
                    objSolicitudBE.Est_desembolso = 2;
                }
                else
                {
                    objSolicitudBE.Est_desembolso = 1;
                }

                if (cboProducto.SelectedItem.Equals("Prestamo Facil"))
                {
                    objSolicitudBE.Tipo_producto = 1;
                }
                else if (cboProducto.SelectedItem.Equals("Credito Hipotecario"))
                {
                    objSolicitudBE.Tipo_producto = 2;
                }
                else if (cboProducto.SelectedItem.Equals("Credito Vehicular"))
                {
                    objSolicitudBE.Tipo_producto = 3;
                }
                else
                {
                    objSolicitudBE.Tipo_producto = 4;
                }

                if (cboEstado.SelectedItem.Equals("Aprobada"))
                {
                    objSolicitudBE.Est_solicitud = 3;
                }
                else if (cboEstado.SelectedItem.Equals("En proceso"))
                {
                    objSolicitudBE.Est_solicitud = 2;
                }
                else
                {
                    objSolicitudBE.Est_solicitud = 1;
                }

                objSolicitudBE.Fec_aprobacion = dtpFecAprobacion.Value.Date;
                objSolicitudBE.Fec_rechazo = dtpFecRechazo.Value.Date;


                objSolicitudBE.Usu_registro = clsCredenciales.Usuario;

                if (objSolicitudBL.InsertarSolicitud(objSolicitudBE) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
