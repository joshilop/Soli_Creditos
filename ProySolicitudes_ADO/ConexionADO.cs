using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Configuration;

namespace ProySolicitudes_ADO
{
    class ConexionADO
    {
        public String GetCnx()
        {
            string strCnx = ConfigurationManager.ConnectionStrings["Solicitudes"].ConnectionString;
            if(object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}
