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

namespace ProySolicitudes_GUI
{
    public partial class GarantiaMan01 : Form
    {

        GarantiaBL objGarantiaBL = new GarantiaBL();
        DataView dtv;

        public GarantiaMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv.RowFilter = "Ape_cli like '%" + strFiltro + "%'";
            dtgGarantia.DataSource = dtv;

            lblRegistros.Text = dtgGarantia.Rows.Count.ToString();
        }

        private void GarantiaMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgGarantia.AutoGenerateColumns = false;
                dtv = objGarantiaBL.ListarGarantia().DefaultView;
                CargarDatos(String.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                GarantiaMan02 obj02 = new GarantiaMan02();
                obj02.ShowDialog();

                dtv = objGarantiaBL.ListarGarantia().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String strCod = dtgGarantia.CurrentRow.Cells[0].Value.ToString();

                GarantiaMan03 obj03 = new GarantiaMan03();
                obj03.Codigo = strCod;
                obj03.ShowDialog();

                dtv = objGarantiaBL.ListarGarantia().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
