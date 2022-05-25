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
    public partial class ClienteMan03 : Form
    {

        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        public ClienteMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {

                objClienteBE = objClienteBL.ConsultarCliente(Codigo);

                lblCodigo.Text = objClienteBE.Id_cli;
                txtNombre.Text = objClienteBE.Nom_cli;
                txtApellido.Text = objClienteBE.Ape_cli;
                mskDNI.Text = objClienteBE.Dni_cli;
                mskRUC.Text = objClienteBE.Ruc_cli;
                if (objClienteBE.Sexo == "M")
                {
                    rbdMasculino.Checked = true;
                    rbdFemenino.Checked = false;
                }
                else
                {
                    rbdMasculino.Checked = false;
                    rbdFemenino.Checked = true;
                }
                dtpFecNacimiento.Value = objClienteBE.Fec_nacimiento;
                txtEducacion.Text = objClienteBE.Nivel_educacion;
                //cboEstCivil.SelectedItem = objClienteBE.Estado_civil;

                if (objClienteBE.Est_Civ.Equals("Soltero/a"))
                {
                    //cboEstCivil.SelectedItem = 1;
                    cboEstCivil.Text = "Soltero/a";
                }
                else if (objClienteBE.Est_Civ.Equals("Casado/a"))
                {
                    //cboEstCivil.SelectedItem = 2;
                    cboEstCivil.Text = "Casado/a";
                }
                else if (objClienteBE.Est_Civ.Equals("Viudo/a"))
                {
                    //cboEstCivil.SelectedItem = 3;
                    cboEstCivil.Text = "Viudo/a";
                }
                else
                {
                    //cboEstCivil.SelectedItem = 4;
                    cboEstCivil.Text = "Divorciado/a";
                }

                txtEmail.Text = objClienteBE.Email;
                if(objClienteBE.Est_cli == 1)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }

                String Id_Ubigeo = objClienteBE.Id_ubigeo;

                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if(mskRUC.MaskFull == false)
                {
                    throw new Exception("El RUC debe tener 11 digitos");
                }

                objClienteBE.Id_cli = lblCodigo.Text;
                objClienteBE.Nom_cli = txtNombre.Text.Trim();
                objClienteBE.Ape_cli = txtApellido.Text.Trim();
                objClienteBE.Dni_cli = mskDNI.Text;
                objClienteBE.Ruc_cli = mskRUC.Text;

                if (rbdMasculino.Checked == true)
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

                objClienteBE.Usu_ult_mod = clsCredenciales.Usuario;

                objClienteBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();

                if (objClienteBL.ActualizarCliente(objClienteBE) == true)
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

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
