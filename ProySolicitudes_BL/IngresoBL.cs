using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProySolicitudes_ADO;

namespace ProySolicitudes_BL
{
    public class IngresoBL
    {
        IngresoADO objIngresoADO = new IngresoADO();

        public DataTable ListarIngreso()
        {
            return objIngresoADO.ListarIngreso();
        }

        public DataTable ListarIngresoXcliente(String strId)
        {
            return objIngresoADO.ListarIngresoXcliente(strId);
        }
    }
}
