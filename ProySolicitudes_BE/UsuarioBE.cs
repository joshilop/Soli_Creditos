using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProySolicitudes_BE
{
    public class UsuarioBE
    {
        // Miembros privados
        private String mvarlogin_usuario;
        private String mvarpassword_usuario;
        private Int16 mvarnivel_usuario;
        private Int16 mvarestado_usuario;
        private DateTime mvarfec_registro;
        private String mvarusu_registro;

        // Propiedades

        public String Login_Usuario
        {
            get { return mvarlogin_usuario; }
            set { mvarlogin_usuario = value; }
        }

        public String Password_Usuario
        {
            get { return mvarpassword_usuario; }
            set { mvarpassword_usuario = value; }
        }

        public Int16 Nivel_Usuario
        {
            get { return mvarnivel_usuario; }
            set { mvarnivel_usuario = value; }
        }

        public Int16 Estado_Usuario
        {
            get { return mvarestado_usuario; }
            set { mvarestado_usuario = value; }
        }

        public DateTime Fec_Registro
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }
        }

        public String Usu_Registro
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }
        }
    }
}
