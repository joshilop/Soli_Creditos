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
    public partial class SolicitudMan01 : Form
    {

        SolicitudBL objSolicitudBL = new SolicitudBL();
        DataView dtv;

        public SolicitudMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv.RowFilter = "[Nombre cliente] like '%" + strFiltro + "%'";
            dtgSolicitud.DataSource = dtv;

            lblRegistros.Text = dtgSolicitud.Rows.Count.ToString();
        }

        public void CargarDatosxAnalista(String strFiltro)
        {
            dtv.RowFilter = "[Nombre analista] like '%" + strFiltro + "%'";
            dtgSolicitud.DataSource = dtv;

            lblRegistros.Text = dtgSolicitud.Rows.Count.ToString();
        }

        private void SolicitudMan01_Load(object sender, EventArgs e)
        {
            cboFiltro.SelectedItem = "Cliente";
            txtAnalistaFiltro.Enabled = false;

            try
            {
                dtgSolicitud.AutoGenerateColumns = false;
                dtv = objSolicitudBL.ListarSolicitud().DefaultView;
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
                SolicitudMan02 obj02 = new SolicitudMan02();
                obj02.ShowDialog();

                dtv = objSolicitudBL.ListarSolicitud().DefaultView;
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
                String strCod = dtgSolicitud.CurrentRow.Cells[0].Value.ToString();

                SolicitudMan03 obj03 = new SolicitudMan03();
                obj03.Codigo = strCod;
                obj03.ShowDialog();

                dtv = objSolicitudBL.ListarSolicitud().DefaultView;
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

        private void cboFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedItem.Equals("Analista"))
            {
                txtAnalistaFiltro.Enabled = true;
                txtFiltro.Enabled = false;
                txtAnalistaFiltro.Focus();
                txtFiltro.Clear();
            }
            else
            {
                txtAnalistaFiltro.Enabled = false;
                txtFiltro.Enabled = true;
                txtFiltro.Focus();
                txtAnalistaFiltro.Clear();
            }
        }

        private void txtAnalistaFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatosxAnalista(txtAnalistaFiltro.Text.Trim());
        }
    }
}
