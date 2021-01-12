using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.ClasesDeNegocio
{
    public class Cochera
    {
        public int Id { get; set; }

        public int NumeroCochera { get; }

        public int IdCochera { get; set; }

        public Vehiculo vehiculo { get; private set; }

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
