using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ProySolicitudes_BE
{
    public class ClienteBE
    {
        private String mvaid_cli;
        public String Id_cli
        {
            get { return mvaid_cli; }
            set { mvaid_cli = value; }
        }
        private String mvanom_cli;
        public String Nom_cli
        {
            get { return mvanom_cli; }
            set { mvanom_cli = value; }
        }
        private String mvaape_cli;
        public String Ape_cli
        {
            get { return mvaape_cli; }
            set { mvaape_cli = value; }
        }
        private String mvadni_cli;
        public String Dni_cli
        {
            get { return mvadni_cli; }
            set { mvadni_cli = value; }
        }
        private String mvaruc_cli;
        public String Ruc_cli
        {
            get { return mvaruc_cli; }
            set { mvaruc_cli = value; }
        }
        private String mvasexo;
        public String Sexo
        {
            get { return mvasexo; }
            set { mvasexo = value; }
        }
        private DateTime mvafec_nacimiento;
        public DateTime Fec_nacimiento
        {
            get { return mvafec_nacimiento; }
            set { mvafec_nacimiento = value; }
        }
        private String mvanivel_educacion;
        public String Nivel_educacion
        {
            get { return mvanivel_educacion; }
            set { mvanivel_educacion = value; }
        }
        private Int16 mvaestado_civil;
        public Int16 Estado_civil
        {
            get { return mvaestado_civil; }
            set { mvaestado_civil = value; }
        }

        private String mvaest_civil;
        public String Est_Civ
        {
            get { return mvaest_civil; }
            set { mvaest_civil = value; }
        }

        private String mvaemail;
        public String Email
        {
            get { return mvaemail; }
            set { mvaemail = value; }
        }
        public String mvaid_ubigeo;
        public String Id_ubigeo
        {
            get { return mvaid_ubigeo; }
            set { mvaid_ubigeo = value; }
        }
        private Int16 mvaest_cli;
        public Int16 Est_cli
        {
            get { return mvaest_cli; }
            set { mvaest_cli = value; }
        }

        private String mvaestado_cliente;
        public String Estado_Cliente
        {
            get { return mvaestado_cliente; }
            set { mvaestado_cliente = value; }
        }

        private DateTime mvafec_reg;
        public DateTime Fec_reg
        {
            get { return mvafec_reg; }
            set { mvafec_reg = value; }
        }
        private String mvausu_registro;
        public String Usu_registro
        {
            get { return mvausu_registro; }
            set { mvausu_registro = value; }
        }
        private DateTime mvafec_ult_mod;
        public DateTime Fec_ult_mod
        {
            get { return mvafec_ult_mod; }
            set { mvafec_ult_mod = value; }
        }
        private String mvausu_ult_mod;
        public String Usu_ult_mod
        {
            get { return mvausu_ult_mod; }
            set { mvausu_ult_mod = value; }
        }


        private String mvaestado;
        public String Estado
        {
            get { return mvaestado; }
            set { mvaestado = value; }
        }

        private Int16 mvaEdad;
        public Int16 Edad
        {
            get { return mvaEdad; }
            set { mvaEdad = value; }
        }

    }
}
