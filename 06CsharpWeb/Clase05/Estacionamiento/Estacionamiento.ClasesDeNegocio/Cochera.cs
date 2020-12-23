using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class Cochera
    {
        public int NumeroCochera { get; }

        private Vehiculo vehiculo;

        public Cochera(int numeroCochera)
        {
            NumeroCochera = numeroCochera;
        }

        public bool Ingresar(Vehiculo vehiculo)
        {
            bool resultado = false;
            if (EstaVacia == true)
            {
                this.vehiculo = vehiculo;
                resultado = true;
            }
            return resultado;
        }

        public Vehiculo Egresar(string patente)
        {
            Vehiculo resultado = null;

            if (EstaVacia == false)
            {
                if(vehiculo.Patente == patente)
                {
                    resultado = vehiculo;
                    vehiculo = null;
                }
            }

            return resultado;
        }

        public bool EstaVacia
        {
            get
            {
                bool resultado = false;
                if (vehiculo == null)
                {
                    resultado = true;
                }
                return resultado;
            }
        }
    }
}
