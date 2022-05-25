using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProySolicitudes_ADO;
using ProySolicitudes_BE;

namespace ProySolicitudes_BL
{
    public class SolicitudBL
    {
        SolicitudADO objSolicitudADO = new SolicitudADO();

        public Boolean InsertarSolicitud(SolicitudBE objSolicitudBE)
        {
            return objSolicitudADO.InsertarSolicitud(objSolicitudBE);
        }
        public Boolean ActualizarSolicitud(SolicitudBE objSolicitudBE)
        {
            return objSolicitudADO.ActualizarSolicitud(objSolicitudBE);
        }
        public Boolean EliminarSolicitud(String strCod)
        {
            return objSolicitudADO.EliminarSolicitud(strCod);
        }
        public SolicitudBE ConsultarSolicitud(String strCod)
        {
            return objSolicitudADO.ConsultarSolicitud(strCod);
        }
        public DataTable ListarSolicitud()
        {
            return objSolicitudADO.ListarSolicitud();
        }
        public DataTable ListarSolicitudXcliente(String strId)
        {
            return objSolicitudADO.ListarSolicitudXcliente(strId);
        }
        public DataTable ListarSolicitudEstAna(String strId, String strEstado)
        {
            return objSolicitudADO.ListarSolicitudEstAna(strId, strEstado);
        }
        public DataTable ListarPago()
        {
            return objSolicitudADO.ListarPago();
        }
        public DataTable ListarPagoCliente(String strId)
        {
            return objSolicitudADO.ListarPagoCliente(strId);
        }
        public DataTable ListarPagoSolicitud(String strIdSoli)
        {
            return objSolicitudADO.ListarPagoSolicitud(strIdSoli);
        }
        public DataTable ListarSolicitudEstado(Int16 numEst)
        {
            return objSolicitudADO.ListarSolicitudEstado(numEst);
        }
        public DataTable RankingAnalistas(Int16 numTop, Int16 numEst)
        {
            return objSolicitudADO.RankingAnalistas(numTop, numEst);
        }

        public DataTable ListarSolicitudes_Paginacion(String strIdCli, String strIdAna, String strEstado, Int16 intNumPag)
        {
            return objSolicitudADO.ListarSolicitudes_Paginacion(strIdCli, strIdAna, strEstado, intNumPag);
        }

        public Int16 NumPag_ListarSolicitudes_Paginacion(String strIdCli, String strIdAna, String strEstado)
        {
            return objSolicitudADO.NumPag_ListarSolicitudes_Paginacion(strIdCli, strIdAna, strEstado);
        }
    }
}
