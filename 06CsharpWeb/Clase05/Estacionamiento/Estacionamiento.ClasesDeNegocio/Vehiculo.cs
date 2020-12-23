using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public abstract class Vehiculo
    {
        public string Patente { get; protected set; }

        public abstract decimal Precio { get; }

    }
}
