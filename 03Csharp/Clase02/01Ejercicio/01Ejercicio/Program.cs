using System;

namespace _01Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal IVAREDUCIDO = 10.5M;
            const decimal IVACOMPLETO = 21;

            Console.Write("Por favor ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Por favor ingrese el costo del producto: ");
            string costoProducto = Console.ReadLine();

            /*
             float: tipo de dato de precision simple
             double: tipo de precision doble
             decimal: tipo de datos para datos monetario
             */

            decimal costo = Convert.ToDecimal(costoProducto);

            Console.WriteLine("Por favor ingrese el IVA del producto: ");
            Console.WriteLine("a) " + IVAREDUCIDO + "%");
            Console.WriteLine("b) " + IVACOMPLETO + "%");
            string tipoIva = Console.ReadLine();

            /*
            //CON IF
            decimal iva = 0;

            if (tipoIva == "a")
            {
                iva = IVAREDUCIDO;
            }
            else
            {
                iva = IVACOMPLETO;
            }
            */

            /*
            //Switch
            decimal iva = 0;

            switch (tipoIva)
            {
                case "a":
                    iva = IVAREDUCIDO;
                    break;
                default:
                    iva = IVACOMPLETO;
                    break;
            }
            */

            // OPERADOR TERNARIO
            // VARIABLE = CONDICION ? VALOR_VERDADERA : VALOR_FALSA

            decimal iva = tipoIva == "a" ? IVAREDUCIDO : IVACOMPLETO;

            decimal costoConIva = costo + (costo * iva / 100);

            Console.WriteLine("El producto {0} tiene un precio de lista de {1} y un precio con iva de {2}", nombreProducto, costo, costoConIva);
            Console.ReadKey();
        }
    }
}
