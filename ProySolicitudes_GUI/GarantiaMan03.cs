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
    public partial class GarantiaMan03 : Form
    {

        GarantiaBE objGarantiaBE = new GarantiaBE();
        GarantiaBL objGarantiaBL = new GarantiaBL();

        public GarantiaMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private void CargarCliente(String IdCliente)
        {
            ClienteBL objClienteBL = new ClienteBL();

            cboCliente.DataSource = objClienteBL.ListarCliente();
            cboCliente.ValueMember = "Id_cli";
            cboCliente.DisplayMember = "ApellNombres";
            cboCliente.SelectedValue = IdCliente;

        }

        private void GarantiaMan03_Load(object sender, EventArgs e)
        {
            objGarantiaBE = objGarantiaBL.ConsultarGarantia(Codigo);

            CargarCliente(objGarantiaBE.Id_cli);

            lblIdGarantia.Text = objGarantiaBE.Id_garantia.ToString();
            cboGarantia.SelectedItem = objGarantiaBE.Tip_garantia.ToString();
            
            txtDescrip.Text = objGarantiaBE.Des_garantia.ToString();
            mskValor.Text = objGarantiaBE.Valor_garantia.ToString("###,##0.00");
            
            if (objGarantiaBE.Est_garantia == 1)
            {
                chkActivo.Checked = true;
            }
            else
            {
                chkActivo.Checked = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objGarantiaBE.Id_garantia = Convert.ToInt16(lblIdGarantia.Text.Trim());
                
                objGarantiaBE.Tip_garantia = cboGarantia.SelectedItem.ToString();
                objGarantiaBE.Des_garantia = txtDescrip.Text.Trim();
                objGarantiaBE.Valor_garantia = Convert.ToSingle(mskValor.Text.Trim());
                
                objGarantiaBE.Id_cli = cboCliente.SelectedValue.ToString();
                if (chkActivo.Checked == true)
                {
                    objGarantiaBE.Est_garantia = 1;
                }
                else
                {
                    objGarantiaBE.Est_garantia = 2;
                }


                objGarantiaBE.Usu_ult_mod = clsCredenciales.Usuario;

                if (objGarantiaBL.ActualizarGarantia(objGarantiaBE) == true)
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
                MessageBox.Show("Mensaje: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
