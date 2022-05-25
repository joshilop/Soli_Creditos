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
    public class GarantiaBL
    {

        GarantiaADO objGarantiaADO = new GarantiaADO();

        public Boolean InsertarGarantia(GarantiaBE objGarantiaBE)
        {
            return objGarantiaADO.InsertarGarantia(objGarantiaBE);
        }
        public Boolean ActualizarGarantia(GarantiaBE objGarantiaBE)
        {
            return objGarantiaADO.ActualizarGarantia(objGarantiaBE);
        }
        public Boolean EliminarGarantia(String strcod)
        {
            return objGarantiaADO.EliminarGarantia(strcod);
        }
        public GarantiaBE ConsultarGarantia(String strCod)
        {
            return objGarantiaADO.ConsultarGarantia(strCod);
        }
        public DataTable ListarGarantia()
        {
            return objGarantiaADO.ListarGarantia();
        }
        public DataTable ListarGarantiaXcliente(String strId)
        {
            return objGarantiaADO.ListarGarantiaXcliente(strId);
        }

    }
}
