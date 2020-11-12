using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01.Clases
{
    class CajaDeAhorro
    {
        //Atributos
        decimal saldo;

        //Metodos
        void informarSaldo()
        {
            Console.WriteLine(saldo);
        }

        decimal obtenerSaldo()
        {
            return saldo;
        }

        void depositarDinero(decimal monto)
        {
            saldo += monto;
        }

        void extraerDinero(decimal monto)
        {
            saldo -= monto;
        }
    }
}
