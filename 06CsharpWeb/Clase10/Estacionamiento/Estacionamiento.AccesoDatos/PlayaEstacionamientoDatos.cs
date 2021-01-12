using Estacionamiento.ClasesDeNegocio;
using Estacionamiento.ClasesDeNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection conexion = 
                new SqlConnection(connectionString);

            SqlCommand comando = new SqlCommand(
                "SELECT Id,Nombre FROM PlayasEstacionamiento",
                conexion);
            /// Desde aca puede fallar

            try
            {
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
                
            }
            catch (SqlException sqlException)
            {
                //Guardar en un archivo de texto donde tengo los errores el sqlException.Message
                throw new AccesoDatosException("Ha ocurrido un error al acceder a los datos");
            }
            finally
            {
                conexion.Close(); // Esto puedo olvidarmelo!
            }
            /// Hasta aca
            return resultado;
        }
    }
}
