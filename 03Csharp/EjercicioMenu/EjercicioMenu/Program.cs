using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuPrincipal = new string[] { "Laptop", "Teclado", "Cables", "Memorias" }; //equivalente a new string [5];
            string[] menuLaptop = new string[] { "Acer", "HP", "Dell" };
            string[] menuTeclado = new string[] { "Gamer", "Inalambrico" };
            string[] menuCables = new string[] { "Impresora", "Micro USB", "USB C" };
            string[] menuMemorias = new string[] { "512MB", "1GB", "4GB" };

            string[] menuActual = menuPrincipal;
            string[] elementosSeleccionados = new string[0];

            bool esMenuPrincipal = true;
            int opcionSeleccionada = 0;

            while (opcionSeleccionada != -1)
            {
                opcionSeleccionada = DibujarMenu(menuActual);

                if (esMenuPrincipal)
                {
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            menuActual = menuLaptop;
                            esMenuPrincipal = false;
                            break;
                        case 1:
                            menuActual = menuTeclado;
                            esMenuPrincipal = false;
                            break;
                        case 2:
                            menuActual = menuCables;
                            esMenuPrincipal = false;
                            break;
                        case 3:
                            menuActual = menuMemorias;
                            esMenuPrincipal = false;
                            break;
                        case -1:
                            Console.WriteLine("Ingresó la opción salir. Esto son los productos que eligió:");
                            for (int i = 0; i < elementosSeleccionados.Length; i++)
                            {
                                Console.WriteLine("-" + elementosSeleccionados[i]);
                            }
                            Console.WriteLine("Gracias por utilizar el programa.");
                            break;
                        case -2:
                            Console.WriteLine("El valor ingresado no es un numero");
                            break;
                        default:
                            Console.WriteLine("HA INGRESADO UNA OPCION INCORRECTA");
                            break;
                    }
                }
                else
                {
                    if (opcionSeleccionada == -1)
                    {
                        menuActual = menuPrincipal;
                        esMenuPrincipal = true;
                        opcionSeleccionada = 0;
                    }
                    else if (opcionSeleccionada>=0)
                    {
                        elementosSeleccionados = AgregarElemento(elementosSeleccionados, menuActual[opcionSeleccionada]);
                        Console.WriteLine("Usted seleccionó " + menuActual[opcionSeleccionada] + ". Pulse una tecla para continuar. ");
                        Console.ReadKey();
                    }
                }

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

            Console.WriteLine("0-Salir");

            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine((i + 1) + "-" + opciones[i]);
            }
            string opcionSeleccionada = Console.ReadLine();
            //int resultado = Convert.ToInt32(opcionSeleccionada);
            //Alternativa que sirve para validar.
            int resultado = 0;
            bool pudoConvertir = Int32.TryParse(opcionSeleccionada, out resultado);

            if (pudoConvertir == false)
            {
                resultado = -1; //Pongo -1 asi devuelve -2, porque -1 es la opcion "Salir"
            }

            return (resultado - 1);
        }

        static string[] AgregarElemento(string[] listado,string elemento)
        {
            string[] auxiliar = new string[listado.Length+1];

            for (int i = 0; i < listado.Length; i++)
            {
                auxiliar[i] = listado[i];
            }
            auxiliar[auxiliar.Length - 1] = elemento;

            return auxiliar;
        }
    }
}
