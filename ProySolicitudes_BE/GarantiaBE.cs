using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProySolicitudes_BE
{
    public class GarantiaBE
    {
        private Int16 mvaid_garantia;
        public Int16 Id_garantia
        {
            get { return mvaid_garantia; }
            set { mvaid_garantia = value; }
        }
        private String mvatip_garantia;
        public String Tip_garantia
        {
            get { return mvatip_garantia; }
            set { mvatip_garantia = value; }
        }
        private String mvades_garantia;
        public String Des_garantia
        {
            get { return mvades_garantia; }
            set { mvades_garantia = value; }
        }
        private Single mvavalor_garantia;
        public Single Valor_garantia
        {
            get { return mvavalor_garantia; }
            set { mvavalor_garantia = value; }
        }
        private String mvaid_cli;
        public String Id_cli
        {
            get { return mvaid_cli; }
            set { mvaid_cli = value; }
        }
        private Int16 mvaest_garantia;
        public Int16 Est_garantia
        {
            get { return mvaest_garantia; }
            set { mvaest_garantia = value; }
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
    }
}
