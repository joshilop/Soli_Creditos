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
    public partial class ClienteMan01 : Form
    {

        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        DataView dtv;

        public ClienteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv.RowFilter = "Ape_cli like '%" + strFiltro + "%'";
            dtgCliente.DataSource = dtv;

            lblRegistros.Text = dtgCliente.Rows.Count.ToString();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;
                dtv = objClienteBL.ListarCliente().DefaultView;
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
                ClienteMan02 obj02 = new ClienteMan02();
                obj02.ShowDialog();

                dtv = objClienteBL.ListarCliente().DefaultView;
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
                String strCod = dtgCliente.CurrentRow.Cells[0].Value.ToString();

                ClienteMan03 obj03 = new ClienteMan03();
                obj03.Codigo = strCod;
                obj03.ShowDialog();

                dtv = objClienteBL.ListarCliente().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("El registro " + objClienteBE.Nom_cli + "se eliminará", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    objClienteBL.EliminarCliente(dtgCliente.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Se ha eliminado el registro");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
