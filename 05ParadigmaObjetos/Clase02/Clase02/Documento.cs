using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Documento
    {
        public string tipoDeDocumento;

        public string numeroDeDocumento;

        public Documento()
        {

        }

        public Documento(string tipo, string numeroDeDocumento)
        {
            tipoDeDocumento = tipo;
            this.numeroDeDocumento = numeroDeDocumento;
        }
    }
}
