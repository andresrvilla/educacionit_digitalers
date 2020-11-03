using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectandoSEQLSERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Server=localhost\\SQLEXPRESS;Database=programa;Trusted_Connection=True;";
            SqlConnection conectar = new SqlConnection(cadena);
            conectar.Open();
            Console.WriteLine("¿que desea hacer?: ");
            Console.WriteLine("1-INSERTAR DATOS EN UNA TABLA");
            Console.WriteLine("2-MODIFICAR UNA TABLA");
            Console.WriteLine("3-ELIMINAR UNA TABLA");
            string opcion = Console.ReadLine();
            int conopcion = Convert.ToInt32(opcion);
            creartabla(conopcion,conectar);
            modificarDatos(conopcion, conectar);
            eliminarTabla(conopcion, conectar);
            conectar.Close();
            Console.ReadKey();


        }
        static void creartabla(int conopcion, SqlConnection conectar)
        {
            if (conopcion==1)
                        {
                                Console.WriteLine("¿que datos quiere insertar?");
                                Console.WriteLine("1-dni,nombre,apellido,direccion,activo");
                                Console.WriteLine("2-dni,nombre,apellido,fechaNac,activo");
                                Console.WriteLine("3-dni,nombre,apellido,activo");
                                Console.WriteLine("4-dni,nombre,apellido,direccion,fechaNac");
                                Console.WriteLine("5-dni,nombre,apellido");
                                Console.WriteLine("6-dni,nombre,apellido,direccion,fechaNac,activo");
                                string elegido = Console.ReadLine();
                                int convelegido = Convert.ToInt32(elegido);
                if (convelegido==1)
                {
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese direccion: ");
                    string direccion = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("insert into personas (dni,nombre,apellido,direccion,activo) values ({0},'{1}','{2}','{3}',{4});", convdni,nombre,apellido,direccion,activo);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                else if (convelegido == 2)
                {
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese fecha de nacimiento en formato aaaa-mm-dd: ");
                    string fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("insert into personas (dni,nombre,apellido,fechaNac,activo) values ({0},'{1}','{2}','{3}',{4});", convdni, nombre, apellido, fechaNacimiento, activo);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                else if (convelegido == 3)
                {
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();                   
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("insert into personas (dni,nombre,apellido,fechaNac,activo) values ({0},'{1}','{2}','{3}');", convdni, nombre, apellido, activo);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                else if (convelegido == 4)
                {
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese fecha de nacimiento en formato aaaa-mm-dd: ");
                    string fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("ingrese direccion: ");
                    string direccion = Console.ReadLine();
                    string nuevaPersona = string.Format("insert into personas (dni,nombre,apellido,direccion,fechaNac) values ({0},'{1}','{2}','{3}','{4}');", convdni, nombre, apellido, direccion, fechaNacimiento);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                else if (convelegido == 5)
                {
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    string nuevaPersona = string.Format("insert into personas (dni,nombre,apellido) values ({0},'{1}','{2}');", convdni, nombre, apellido);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                else if(convelegido == 6)
                {
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese fecha de nacimiento en formato aaaa-mm-dd: ");
                    string fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("ingrese direccion: ");
                    string direccion = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("insert into personas (dni,nombre,apellido,fechaNac,direccion,activo) values ({0},'{1}','{2}','{3}','{4}','{5}');", convdni, nombre, apellido, fechaNacimiento, direccion,activo);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
            }

                        
        }
        static void modificarDatos(int conopcion, SqlConnection conectar)
        {
            if (conopcion==2)
            {
                Console.WriteLine("¿que datos quiere modificar?");
                Console.WriteLine("1-dni,nombre,apellido,direccion,activo");
                Console.WriteLine("2-dni,nombre,apellido,fechaNac,activo");
                Console.WriteLine("3-dni,nombre,apellido,activo");
                Console.WriteLine("4-dni,nombre,apellido,direccion,fechaNac");
                Console.WriteLine("5-dni,nombre,apellido");
                Console.WriteLine("6-dni,nombre,apellido,direccion,fechaNac,activo");
                string elegido = Console.ReadLine();
                int convelegido = Convert.ToInt32(elegido);
                if (convelegido == 1)
                {
                    Console.WriteLine("escriba el nombre de la persona quiere actualizar");
                    string actualizar = Console.ReadLine();
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese direccion: ");
                    string direccion = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("update personas set dni = {0}, nombre = '{1}', apellido = '{2}' , direccion = '{3}', activo={4} where nombre = '{5}';", convdni, nombre, apellido, direccion, activo, actualizar);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                if (convelegido == 2)
                {
                    Console.WriteLine("escriba el el nombre de la persona que quiere actualizar");
                    string actualizar = Console.ReadLine();
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese fecha de nacimiento en formato aaaa-mm-dd: ");
                    string fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("update personas set dni = {0}, nombre = '{1}', apellido = '{2}' , fechaNac = '{3}', activo={4} where nombre = '{5}';", convdni, nombre, apellido, fechaNacimiento, activo, actualizar);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                if (convelegido == 3)
                {
                    Console.WriteLine("escriba el el nombre de la persona que quiere actualizar");
                    string actualizar = Console.ReadLine();
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("update personas set dni = {0}, nombre = '{1}', apellido = '{2}' , activo={3} where nombre = '{4}';", convdni, nombre, apellido, activo, actualizar);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                if (convelegido == 4)
                {
                    Console.WriteLine("escriba el el nombre de la persona que quiere actualizar");
                    string actualizar = Console.ReadLine();
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese direccion: ");
                    string direccion = Console.ReadLine();
                    Console.WriteLine("ingrese fecha de nacimiento en formato aaaa-mm-dd: ");
                    string fechaNacimiento = Console.ReadLine();
                    
                    string nuevaPersona = string.Format("update personas set dni = {0}, nombre = '{1}', apellido = '{2}' , direccion = '{3}' fechaNac = '{4}' where nombre = '{5}';", convdni, nombre, apellido, direccion, fechaNacimiento, actualizar);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                if (convelegido == 5)
                {
                    Console.WriteLine("escriba el el nombre de la persona que quiere actualizar");
                    string actualizar = Console.ReadLine();
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    
                    string nuevaPersona = string.Format("update personas set dni = {0}, nombre = '{1}', apellido = '{2}' where nombre = '{3}';", convdni, nombre, apellido, actualizar);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
                if (convelegido == 6)
                {
                    Console.WriteLine("escriba el el nombre de la persona que quiere actualizar");
                    string actualizar = Console.ReadLine();
                    Console.WriteLine("ingrese dni: ");
                    string dni = Console.ReadLine();
                    int convdni = Convert.ToInt32(dni);
                    Console.WriteLine("ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese direccion: ");
                    string direccion = Console.ReadLine();
                    Console.WriteLine("ingrese fecha de nacimiento en formato aaaa-mm-dd: ");
                    string fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("ingrese 1-si esta activo|| 0- si no esta activo: ");
                    string activo = Console.ReadLine();
                    string nuevaPersona = string.Format("update personas set dni = {0}, nombre = '{1}', apellido = '{2}' , direccion = '{3}' fechaNac = '{4}', activo = '{5}'where nombre = '{6}';", convdni, nombre, apellido, direccion, fechaNacimiento, activo, actualizar);
                    SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                    consulta.ExecuteNonQuery();
                    Console.WriteLine("datos ingresados");
                }
            }
            
        }
            
        static void eliminarTabla(int conopcion, SqlConnection conectar)
        {
            if (conopcion==3)
            {
                Console.WriteLine("escriba el nombre de la tabla a eliminar");
                string tablaeliminar = Console.ReadLine();
                string nuevaPersona = string.Format("drop table {0};", tablaeliminar);
                SqlCommand consulta = new SqlCommand(nuevaPersona, conectar);
                consulta.ExecuteNonQuery();
                Console.WriteLine("datos ingresados");
                
            }
        }
    }
}
