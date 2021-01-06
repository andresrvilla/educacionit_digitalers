using Estacionamiento.ClasesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.AccesoDatos
{
    public class PlayaEstacionamientoDatos
    {
        public List<PlayaEstacionamiento> ObtenerTodosLosEstacionamientos()
        {
            //Aca debería tener la lectura desde la base de datos
            List<PlayaEstacionamiento> resultado = new List<PlayaEstacionamiento>();
            //resultado.Add(new PlayaEstacionamiento("Gorriti 100", 15));
            //resultado.Add(new PlayaEstacionamiento("Yapeyu 120", 17));
            //resultado.Add(new PlayaEstacionamiento("San Martín 1", 21));

            SqlConnection conexion = 
                new SqlConnection("Server=localhost;Database=EstacionamientoIT;Trusted_Connection=True;");

            SqlCommand comando = new SqlCommand(
                "SELECT Id,Nombre FROM PlayasEstacionamiento",
                conexion);

            conexion.Open();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string nombre = reader.GetString(1);
                PlayaEstacionamiento elemento = new PlayaEstacionamiento(nombre, 10)
                {
                    //Id = reader.GetInt32(0)
                    Id = Convert.ToInt32(reader["Id"])
                };
                resultado.Add(elemento);
            }

            reader.Close(); //Ojo, esto me olvide de poner en la clase anterior. Asi que es facil olvidarse
            conexion.Close(); // Esto puedo olvidarmelo!

            return resultado;
        }
    }
}
