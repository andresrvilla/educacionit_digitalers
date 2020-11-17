using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = "Andres";
            alumno.apellido = "Villa";

            Documento elDocumento = new Documento("DU","12312312");

            alumno.documento = elDocumento;

            Console.ReadKey();
        }
    }
}
