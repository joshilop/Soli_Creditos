using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProySolicitudes_BL;
using ProySolicitudes_BE;

namespace ProySolicitudes_GUI
{
    public partial class SolicitudMan03 : Form
    {

        SolicitudBE objSolicitudBE = new SolicitudBE();
        SolicitudBL objSolicitudBL = new SolicitudBL();

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public SolicitudMan03()
        {
            InitializeComponent();
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

        private void SolicitudMan03_Load(object sender, EventArgs e)
        {
            objSolicitudBE = objSolicitudBL.ConsultarSolicitud(Codigo);

            CargarCliente(objSolicitudBE.Id_cli);
            CargarAnalista(objSolicitudBE.Id_analista);
            cboCuotas.SelectedItem = objSolicitudBE.Cuotas.ToString();

            

            lblCod.Text = objSolicitudBE.Id_solicitud;
           
            if (objSolicitudBE.Tipo_producto == 1)
            {
                
                cboProducto.Text = "Prestamo Facil";
            }
            else if (objSolicitudBE.Tipo_producto == 2)
            {
                
                cboProducto.Text = "Credito Hipotecario";
            }
            else if (objSolicitudBE.Tipo_producto == 3)
            {
                
                cboProducto.Text = "Credito Vehicular";
            }
            else
            {
                
                cboProducto.Text = "Tarjeta de Credito";
            }

            mskMonto.Text = objSolicitudBE.Monto_solici.ToString("###,##0.00");
            if (objSolicitudBE.Est_solicitud == 1)
            {
                cboEstado.Text = "Rechazada";
            }
            else if (objSolicitudBE.Est_solicitud == 2)
            {
                cboEstado.Text = "En proceso";
                txtMotivo.Enabled = false;
            }
            else if(objSolicitudBE.Est_solicitud == 3)
            {
                cboEstado.Text = "Aprobada";
                txtMotivo.Enabled = false;
            }
           
            txtMotivo.Text = objSolicitudBE.Motivo_rechazo;
            mskCuenta.Text = objSolicitudBE.Num_cuenta;
            if (objSolicitudBE.Est_desembolso == 2)
            {
                chkDesembolso.Checked = true;
            }
            else
            {
                chkDesembolso.Checked = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                objSolicitudBE.Id_solicitud = lblCod.Text;
                objSolicitudBE.Id_cli = cboCliente.SelectedValue.ToString();
                objSolicitudBE.Cuotas = Convert.ToInt16(cboCuotas.Text.Trim());

                objSolicitudBE.Id_analista = cboAnalista.SelectedValue.ToString();
                objSolicitudBE.Motivo_rechazo = txtMotivo.Text.Trim();
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


                objSolicitudBE.Usu_ult_mod = clsCredenciales.Usuario;

                if (objSolicitudBL.ActualizarSolicitud(objSolicitudBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("En proceso"))
            {
                dtpFecRechazo.Enabled = false;
                dtpFecAprobacion.Enabled = false;
                chkDesembolso.Enabled = false;
                chkDesembolso.Checked = false;
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
                chkDesembolso.Enabled = false;
                chkDesembolso.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
