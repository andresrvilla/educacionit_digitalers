using Estacionamiento.ClasesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.AccesoDatos
{
    public class CocheraDatos
    {
        public List<Cochera> ObtenerCocherasEstacionamiento(int idEstacionamiento)
        {
            List<Cochera> resultado = new List<Cochera>();

            //Tengo que tener el acceso a datos
            using (SqlConnection conexion = new SqlConnection("Server=localhost;Database=EstacionamientoIT;Trusted_Connection=True;"))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Cocheras WHERE IdEstacionamiento = " + idEstacionamiento, conexion);

                conexion.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int nroCochera = reader.GetInt32(1);
                        Cochera cochera = new Cochera(nroCochera)
                        {
                            Id = id
                        };
                        string patente = reader["Patente"] == null ? null : reader["Patente"].ToString();
                        byte tipoVehiculo = reader["TipoDeVehiculo"] == DBNull.Value ? (byte)0 : Convert.ToByte(reader["TipoDeVehiculo"]);

                        if (string.IsNullOrWhiteSpace(patente) == false)
                        {
                            Vehiculo elVehiculo = null;
                            switch (tipoVehiculo)
                            {
                                case (byte)TipoVehiculo.Auto:
                                    elVehiculo = new Auto(patente);
                                    break;
                                case (byte)TipoVehiculo.Camioneta:
                                    elVehiculo = new Camioneta(patente);
                                    break;
                                case (byte)TipoVehiculo.Moto:
                                    elVehiculo = new Moto(patente);
                                    break;
                                    //TODO: Falta implementar el cuatriciclo
                            }
                            cochera.Ingresar(elVehiculo);
                        }
                        resultado.Add(cochera);
                    }
                }
            }
            return resultado;
        }

        public void Crear(Cochera cochera)
        {
            using (SqlConnection conexion = new SqlConnection("Server=localhost;Database=EstacionamientoIT;Trusted_Connection=True;"))
            {
                string query = "INSERT INTO Cocheras (NroCochera,IdEstacionamiento) VALUES (" + cochera.NumeroCochera + "," + cochera.IdCochera + ")";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
        }

        public void Actualizar(Cochera cochera)
        {
            using (SqlConnection conexion = new SqlConnection("Server=localhost;Database=EstacionamientoIT;Trusted_Connection=True;"))
            {
                //TODO: Falta crear logica para tipo de vehiculo
                string query = "UPDATE Cocheras SET Patente = '" + cochera.vehiculo.Patente + "' WHERE Id= " + cochera.Id;
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
        }

    }
}
