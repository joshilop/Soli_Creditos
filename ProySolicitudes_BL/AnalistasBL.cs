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
    public class AnalistasBL
    {
        AnalistaADO objAnalistaADO = new AnalistaADO();

        public DataTable ListarAnalista()
        {
            return objAnalistaADO.ListarAnalista();
        }

        public AnalistaBE ConsultarAnalista(String strIdAna)
        {
            return objAnalistaADO.ConsultarAnalista(strIdAna);
        }
    }
}
