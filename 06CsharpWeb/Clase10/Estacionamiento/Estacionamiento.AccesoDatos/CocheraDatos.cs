using Estacionamiento.ClasesDeNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
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
                                case (byte)TipoVehiculo.Cuatriciclo:
                                    elVehiculo = new Cuatriciclo(patente);
                                    break;
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
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cocheras (NroCochera,IdEstacionamiento) VALUES (" + cochera.NumeroCochera + "," + cochera.IdCochera + ")";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
        }

        public void Actualizar(Cochera cochera)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "";

                if(cochera.vehiculo != null && string.IsNullOrEmpty(cochera.vehiculo.Patente))
                {
                    query = "UPDATE Cocheras SET Patente = null, TipoDeVehiculo = null WHERE Id= " + cochera.Id;
                }
                else
                {
                    byte tipoDeVehiculo = 0;

                    var vehiculoMoto = cochera.vehiculo as Moto;
                    if (vehiculoMoto != null)
                    {
                        tipoDeVehiculo = (int)TipoVehiculo.Moto;
                    }

                    var vehiculoCuatriciclo = cochera.vehiculo as Cuatriciclo;
                    if (vehiculoCuatriciclo != null)
                    {
                        tipoDeVehiculo = (int)TipoVehiculo.Cuatriciclo;
                    }

                    var vehiculoAuto = cochera.vehiculo as Auto;
                    if (vehiculoAuto != null)
                    {
                        tipoDeVehiculo = (int)TipoVehiculo.Auto;
                    }

                    var vehiculoCamioneta = cochera.vehiculo as Camioneta;
                    if (vehiculoCamioneta != null)
                    {
                        tipoDeVehiculo = (int)TipoVehiculo.Camioneta;
                    }


                    query = "UPDATE Cocheras SET Patente = '" + cochera.vehiculo.Patente + "', TipoDeVehiculo='" + tipoDeVehiculo + "' WHERE Id= " + cochera.Id;
                }
                
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
        }

        public void Borrar(Cochera cochera)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Cocheras WHERE Id= " + cochera.Id;
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
        }

    }
}
