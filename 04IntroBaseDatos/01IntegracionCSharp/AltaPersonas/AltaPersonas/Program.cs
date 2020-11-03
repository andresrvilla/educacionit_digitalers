using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Server:
             *  Nombre de la maquina
             *  localhost
             *  127.0.0.1
             *  .
             */
            //string cadena = "Server=.\\sqlexpress;Database=Digitalers;Trusted_Connection=True;";

            string cadena = "Server=digitalers.redirectme.net;Database=Digitalers;User Id=sa;Password=Digitalers_01;";

            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            Console.WriteLine("Estado de la conexion: " + conexion.State);
            string nuevaPersona = "INSERT INTO Personas (Legajo, DNI, Apellido, Nombre, Direccion, FechaDeNacimiento, Activa) VALUES (99, 1235412, 'ApellidoCsharp', 'NombreCsharp', 'Calle Falsa 123', '2000-06-27T13:00:00', 1); ";

            //Indico voy a ejecutar la consulta "nuevaPersona" en la conexion "conexion"
            SqlCommand comandoInsercion = new SqlCommand(nuevaPersona, conexion);
            comandoInsercion.ExecuteNonQuery();
            Console.WriteLine("Termino de ejecutar la consulta");
            conexion.Close();
            Console.ReadKey();
        }
    }
}
