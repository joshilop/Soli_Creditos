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
    public partial class GarantiaMan02 : Form
    {

        GarantiaBE objGarantiaBE = new GarantiaBE();
        GarantiaBL objGarantiaBL = new GarantiaBL();

        public GarantiaMan02()
        {
            InitializeComponent();
        }

        private void CargarCliente(String IdCliente)
        {
            ClienteBL objClienteBL = new ClienteBL();

            cboCliente.DataSource = objClienteBL.ListarCliente();
            cboCliente.ValueMember = "Id_cli";
            cboCliente.DisplayMember = "ApellNombres";
            cboCliente.SelectedValue = IdCliente;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                
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

                objGarantiaBE.Usu_registro = clsCredenciales.Usuario;

                if (objGarantiaBL.InsertarGarantia(objGarantiaBE) == true)
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

        private void GarantiaMan02_Load(object sender, EventArgs e)
        {
            cboGarantia.SelectedIndex = 1;
            CargarCliente("C000001");
        }
    }
}
