using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona();
            personaUno.Apellido = "Apellido Uno";

            Persona personaDos = new Persona()
            {
                Apellido = "Apellido Dos",
                Nombres = "Nombres Dos"
            };

            Persona personaTres = new Persona()
            {
                Apellido = "Apellido tres"
            };

            List<Persona> personas = new List<Persona>();
            personas.Add(personaUno);
            personas.Add(personaDos);
            personas.Add(personaTres);

            foreach(Persona unaPersona in personas)
            {
                Console.WriteLine("Persona apellido " + unaPersona.Apellido);
            }

            Persona personaAQuitar = new Persona()
            {
                Apellido = "Apellido Dos",
                Nombres = "Nombres Dos"
            };

            personas.Remove(personaAQuitar);

            foreach (Persona unaPersona in personas)
            {
                Console.WriteLine("Persona apellido " + unaPersona.Apellido);
            }

            personas.Remove(personaTres);

            foreach (Persona unaPersona in personas)
            {
                Console.WriteLine("Persona apellido " + unaPersona.Apellido);
            }

            Console.ReadKey();


        }
    }
}
