using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstacionamiento
{
    class Cochera
    {
        private int numero;

        private Vehiculo vehiculo;

        public bool EstaDisponible()
        {
            bool resultado = true;

            if (vehiculo != null)
            {
                resultado = false;
            }

            return resultado;
        }

        public Vehiculo Egresar(string patente)
        {
            Vehiculo resultado = null;

            if (EstaDisponible() == true)
            {
                if(vehiculo.Patente == patente)
                {
                    resultado = vehiculo;
                    vehiculo = null;
                }
            }

            return resultado;
        }

        public bool Ingresar(Vehiculo vehiculo)
        {
            bool resultado = false;

            if(EstaDisponible() == true)
            {
                this.vehiculo = vehiculo;
                resultado = true;
            }

            return resultado;
        }
    }
}
