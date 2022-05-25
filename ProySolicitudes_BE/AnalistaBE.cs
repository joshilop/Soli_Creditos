using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProySolicitudes_BE
{
    public class AnalistaBE
    {
        private String mvarId_analista;
        public String Id_analista
        {
            get { return mvarId_analista; }
            set { mvarId_analista = value; }
        }

        private String mvarDNI_analista;
        public String DNI_analista
        {
            get { return mvarDNI_analista; }
            set { mvarDNI_analista = value; }
        }

        private String mvarNom_agencia;
        public String Nom_agencia
        {
            get { return mvarNom_agencia; }
            set { mvarNom_agencia = value; }
        }

        private String mvarEmail_analista;
        public String Email_analista
        {
            get { return mvarEmail_analista; }
            set { mvarEmail_analista = value; }
        }

        private DateTime mvarFecIngreso;
        public DateTime FecIngreso
        {
            get { return mvarFecIngreso; }
            set { mvarFecIngreso = value; }
        }
    }
}
