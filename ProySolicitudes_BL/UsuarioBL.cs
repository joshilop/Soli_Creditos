using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProySolicitudes_ADO;
using ProySolicitudes_BE;

namespace ProySolicitudes_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioADO.ConsultarUsuario(strLogin);
        }

        public bool Confirmarlogin(string usuario, string contraseña)
        {
            return objUsuarioADO.Confirmarlogin(usuario, contraseña);
        }
    }
}
