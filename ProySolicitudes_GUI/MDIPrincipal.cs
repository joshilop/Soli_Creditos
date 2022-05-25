using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProySolicitudes_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void garantiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarantiaMan01 objGarantia01 = new GarantiaMan01();
            objGarantia01.MdiParent = this;
            objGarantia01.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 objCliente01 = new ClienteMan01();
            objCliente01.MdiParent = this;
            objCliente01.Show();
        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitudMan01 objSolicitud01 = new SolicitudMan01();
            objSolicitud01.MdiParent = this;
            objSolicitud01.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + clsCredenciales.Usuario;
        }
    }
}
