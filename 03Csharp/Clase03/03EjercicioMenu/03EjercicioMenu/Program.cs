using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EjercicioMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuPrincipal = new string[] { "Laptop", "Teclado", "Cables", "Memorias", "Salir" }; //equivalente a new string [5];
            string[] menuLaptop = new string[] { "Acer", "HP", "Dell" };
            string[] menuTeclado = new string[] { "Gamer", "Inalambrico" };
            string[] menuCables = new string[] { "Impresora", "Micro USB", "USB C" };
            string[] menuMemorias = new string[] { "512MB", "1GB", "4GB" };

            int opcionSeleccionada = DibujarMenu(menuPrincipal);
            
            //EXTRA! para mejorar
            string[][] menus; //menus[opcionSeleccionada]

            switch (opcionSeleccionada)
            {
                case 0:
                    DibujarMenu(menuLaptop);
                    break;
                case 1:
                    DibujarMenu(menuTeclado);
                    break;
                case 2:
                    DibujarMenu(menuCables);
                    break;
                case 3:
                    DibujarMenu(menuMemorias);
                    break;
                case 4:
                    Console.WriteLine("Ingresó la opción salir. Gracias por utilizar el programa.");
                    break;
                case -1:
                    Console.WriteLine("El valor ingresado no es un numero");
                    break;
                default:
                    Console.WriteLine("HA INGRESADO UNA OPCION INCORRECTA");
                    break;
            }

            Console.ReadKey();
        }

        static int DibujarMenu(string[] opciones)
        {
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine("MENU");
            Console.WriteLine("POR FAVOR SELECCIONE UN NUMERO DE OPCION");
            Console.WriteLine("**************");
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine((i+1) + "-" + opciones[i]);
            }
            string opcionSeleccionada = Console.ReadLine();
            //int resultado = Convert.ToInt32(opcionSeleccionada);
            //Alternativa que sirve para validar.
            int resultado = 0;
            bool pudoConvertir = Int32.TryParse(opcionSeleccionada, out resultado);
            
            if (pudoConvertir == false)
            {
                resultado = 0;
            }

            return (resultado-1);
        }
    }
}
