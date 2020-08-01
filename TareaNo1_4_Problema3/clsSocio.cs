using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_4_Problema3
{
    public class clsSocio
    {
        private string Nombre;
        private int Antiguedad;

        public clsSocio(string NombreSocio, int AntiguedadSocio)
        {
            Nombre = NombreSocio;
            Antiguedad = AntiguedadSocio;
        }
        public int RetornarAntiguedad()
        {
            return Antiguedad;
        }
        public string RetornarNombre()
        {
            return Nombre;
        }

    }
}
