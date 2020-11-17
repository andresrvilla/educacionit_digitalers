using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    /*
     * Visibilidad
     * public: Se puede ver desde todos los proyectos
     * internal: Se puede ver solo del mismo proyecto
     * private: Solo se puede ver desde la misma clase
     */
    public class Alumno
    {
        /*
         * Visibilidad a nivel miembros (atributos o metodos)
         * public: Se puede ver desde cualqueir lado
         * protected (Por defecto): Es publico para la clase o sus hijos y privado para afuera
         * private: solo se puede ver en la misma clase
         */
        public string nombre;

        public string apellido;

        public Documento documento;

        //Cursos

        //Asistencia

        //Pagos

        public bool pagosAlDia;

        string ObtenerEstadoAlumno()
        {
            string estado;
            if (pagosAlDia == true)
            {
                estado = "Tiene los pagos al día";
            }
            else
            {
                estado = "Debe algun pago";
            }
            string resultado = nombre + " " + apellido +" (" + documento + ") "+estado;
            return resultado;
        }

        public void ImprimirEstadoAlumno()
        {
            string descripcionEstado = ObtenerEstadoAlumno();
            Console.WriteLine(descripcionEstado);
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + nombre + " " + apellido);
        }

        public void Saludar(string saludo)
        {
            Console.WriteLine(saludo + ", soy " + nombre + " " + apellido);
        }
    }
}
