using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProySolicitudes_BE
{
    public class SolicitudBE
    {
        private String mvaid_solicitud;
        public String Id_solicitud
        {
            get { return mvaid_solicitud; }
            set { mvaid_solicitud = value; }
        }
        private String mvaid_cli;
        public String Id_cli
        {
            get { return mvaid_cli; }
            set { mvaid_cli = value; }
        }
        private String mvaid_analista;
        public String Id_analista
        {
            get { return mvaid_analista; }
            set { mvaid_analista = value; }
        }
        private Int16 mvatipo_producto;
        public Int16 Tipo_producto
        {
            get { return mvatipo_producto; }
            set { mvatipo_producto = value; }
        }
        private DateTime mvafec_solicitud;
        public DateTime Fec_solicitud
        {
            get { return mvafec_solicitud; }
            set { mvafec_solicitud = value; }
        }
        private Single mvamonto_solici;
        public Single Monto_solici
        {
            get { return mvamonto_solici; }
            set { mvamonto_solici = value; }
        }
        private String mvanum_cuenta;
        public String Num_cuenta
        {
            get { return mvanum_cuenta; }
            set { mvanum_cuenta = value; }
        }
        private Int16 mvaest_solicitud;
        public Int16 Est_solicitud
        {
            get { return mvaest_solicitud; }
            set { mvaest_solicitud = value; }
        }
        private DateTime mvafec_aprobacion;
        public DateTime Fec_aprobacion
        {
            get { return mvafec_aprobacion; }
            set { mvafec_aprobacion = value; }
        }
        private DateTime mvafec_rechazo;
        public DateTime Fec_rechazo
        {
            get { return mvafec_rechazo; }
            set { mvafec_rechazo = value; }
        }
        private String mvamotivo_rechazo;
        public String Motivo_rechazo
        {
            get { return mvamotivo_rechazo; }
            set { mvamotivo_rechazo = value; }
        }
        private Int16 mvaest_desembolso;
        public Int16 Est_desembolso
        {
            get { return mvaest_desembolso; }
            set { mvaest_desembolso = value; }
        }
        private DateTime mvafec_desembolso;
        public DateTime Fec_desembolso
        {
            get { return mvafec_desembolso; }
            set { mvafec_desembolso = value; }
        }
        private DateTime mvafec_pago;
        public DateTime Fec_pago
        {
            get { return mvafec_pago; }
            set { mvafec_pago = value; }
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


        private String mvaproducto;
        public String Producto
        {
            get { return mvaproducto; }
            set { mvaproducto = value; }
        }
        private String mvaestadodesembolso;
        public String Estado_Desembolso
        {
            get { return mvaestadodesembolso; }
            set { mvaestadodesembolso = value; }
        }

        private Int16 mvacuotas;
        public Int16 Cuotas
        {
            get { return mvacuotas; }
            set { mvacuotas = value; }
        }

    }
}
