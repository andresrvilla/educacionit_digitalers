using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    class Moto : Vehiculo
    {

        public override decimal PrecioDeUso { get; set; } = 50;

        public Moto(string patente) : base(patente)
        {

        }
    }
}
