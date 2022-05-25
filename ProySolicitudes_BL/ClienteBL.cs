using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;
using ProySolicitudes_ADO;
using ProySolicitudes_BE;

namespace ProySolicitudes_BL
{
    public class ClienteBL
    {
        ClienteADO objclienteADO = new ClienteADO();

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            return objclienteADO.InsertarCliente(objClienteBE);
        }
        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            return objclienteADO.ActualizarCliente(objClienteBE);
        }
        public Boolean EliminarCliente(String strcod)
        {
            return objclienteADO.EliminarCliente(strcod);
        }
        public ClienteBE ConsultarCliente(String strCod)
        {
            return objclienteADO.ConsultarCliente(strCod);
        }
        public DataTable ListarCliente()
        {
            return objclienteADO.ListarCliente();
        }
    }
}
