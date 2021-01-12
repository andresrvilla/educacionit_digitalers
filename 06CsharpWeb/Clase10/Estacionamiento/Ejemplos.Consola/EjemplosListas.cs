using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Consola
{
    class EjemplosListas
    {
        public EjemplosListas()
        {
            List<int> numeros = new List<int>();

            List<int> notas = new List<int>() { 5, 10, 7, 8, 15 };

            Persona unaPersona = new Persona();

            List<Persona> alumnos = new List<Persona>()
            {
                unaPersona,
                new Persona()
            };

            alumnos.Add(new Persona());

            alumnos.Remove(unaPersona);

            foreach (var item in alumnos)
            {
                item.Apellido = "SARAZA";
                //item = new Persona();
            }
        }
    }
}
