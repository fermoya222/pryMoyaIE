using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoyaIE
{
    internal class clsUsuario
    {
        string rutaArchivo;
        string CadenaConexion;

        OleDbConnection Conexion;
        OleDbCommand Comando;
        OleDbDataReader Lector;

        public string estadoConexion;
        public Int32 Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public clsUsuario()
        {
            rutaArchivo = @"../../Base de Datos/BrokerSeguros.accdb";
            CadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
            estadoConexion = "Cerrado";

            ConectarBD();
        }

        public void ConectarBD()
        {
            try
            {
                Conexion = new OleDbConnection();
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                estadoConexion = "Abierto";
                

            }
            catch (Exception ex)
            {
                estadoConexion = ex.Message;

            }
        }
        
        public void RegistrarLogs(string Usuario, string Contrasena, string Rol)
        {
            // Inicio de la función RegistrarLogs, que registra usuarios en la base de datos.

            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                // Se crea una conexión a la base de datos utilizando OleDbConnection y se asegura de que se cierre automáticamente al salir del bloque.

                conexion.Open();
                // Se abre la conexión

                string sqlUsuario = "SELECT Usuario FROM Usuario WHERE Usuario = ?";
                // Se define una consulta SQL para verificar la existencia de un usuario en la base de datos.

                using (OleDbCommand comandoUsuario = new OleDbCommand(sqlUsuario, conexion))
                {
                    // Se crea un objeto OleDbCommand para ejecutar la consulta SQL anterior.

                    comandoUsuario.Parameters.AddWithValue("parametro1", Usuario);
                    // Se agrega el parámetro Usuario a la consulta SQL.

                    using (OleDbDataReader reader = comandoUsuario.ExecuteReader())
                    {
                        // Se crea un lector de datos para ejecutar la consulta y leer los resultados.

                        if (reader.HasRows)
                        {
                            // Si se encontraron filas en el resultado de la consulta, significa que el usuario ya existe.
                            MessageBox.Show("Usuario Existente");
                            // Muestra un mensaje de advertencia en una ventana emergente.
                            return;
                            // Sale tempranamente de la función.
                        }
                    }
                }

                string sqlInsertarUsuario = "INSERT INTO Usuario(Usuario, Contraseña) VALUES (@parametro1, @parametro2)";
                // Se define una nueva consulta SQL para insertar un nuevo usuario en la base de datos.

                using (OleDbCommand comandoUsuario = new OleDbCommand(sqlInsertarUsuario, conexion))
                {
                    // Se crea otro objeto OleDbCommand para ejecutar la consulta SQL de inserción.

                    comandoUsuario.Parameters.AddWithValue("@parametro1", Usuario);
                    comandoUsuario.Parameters.AddWithValue("@parametro2", Contrasena);
                    comandoUsuario.Parameters.AddWithValue("@parametro3", Rol);
                    // Se agregan los parámetros Usuario, Contrasena y Rol a la consulta SQL.

                    comandoUsuario.ExecuteNonQuery();
                    // Se ejecuta la consulta SQL de inserción para registrar el nuevo usuario en la base de datos.
                }
            }


        }

        public static clsUsuario Login(string usuario, string contraseña)
        {
            // Inicio de la función Login, que se utiliza para autenticar a un usuario.
            string rutaArchivo = @"../../Base de Datos/BrokerSeguros.accdb";
            string CadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;


            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                // Se crea una conexión a la base de datos utilizando OleDbConnection y se asegura de que se cierre automáticamente al salir del bloque.

                conexion.Open();
                // Se abre la conexión.

                
                using (OleDbCommand comando = new OleDbCommand())
                {
                    // Se crea un objeto OleDbCommand para ejecutar la consulta SQL.

                    try
                    {
                        string sql = "SELECT * FROM Usuario WHERE Usuario = @p1 AND Contraseña = @p2";
                        // Se define una consulta SQL para buscar un usuario por nombre de usuario y contraseña.

                        comando.Connection = conexion;
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.CommandText = sql;

                        comando.Parameters.AddWithValue("@p1", usuario);
                        comando.Parameters.AddWithValue("@p2", contraseña);


                        // Se agregan los parámetros para el nombre de usuario y la contraseña a la consulta SQL.

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            // Se crea un lector de datos para ejecutar la consulta y leer los resultados.

                            if (reader.Read())
                            {
                                // Si se encuentra una fila en el resultado de la consulta, significa que el usuario se autenticó con éxito.

                                //string prueba = reader[1].ToString();

                                clsUsuario currentUser = new clsUsuario
                                {
                                    Id = reader.GetInt32(0),
                                    Usuario = reader.GetString(1),
                                    Contraseña = reader.GetString(2),
                                    //Rol = reader.GetString(3)
                                };
                                // Se crea un objeto clsLogs con los datos del usuario autenticado.

                                return currentUser;
                                // Se devuelve el objeto del usuario autenticado.
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        // Si se produce una excepción de OleDb, se muestra un mensaje de error en una ventana emergente.
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Si no se encontró un usuario autenticado o se produjo un error, se devuelve un valor nulo.
            return null;
        }
        public static void RegistrarLog(string usuario)
        {
            StreamWriter sw = new StreamWriter("logInicio.txt", true);
            sw.WriteLine("Inicio sesion el usuario: " + usuario + " - Fecha: " + DateTime.Now);
            sw.Close();
        }

        public void LogMenu(int idUsuario, DateTime fecha, string categoria)
        {
            // Inicio de la función LogMenu, que se utiliza para registrar información de registro en una base de datos.

            // Usa parámetros en lugar de insertar valores directamente en la sentencia SQL
            string Sentenciasql = "INSERT INTO Logs(Id, Usuario, FechaHora, Categoria) VALUES (?, ?, ?, ?)";
            // Se define una consulta SQL que insertará un registro de registro en la tabla "Logs". Se utilizan marcadores de posición para parámetros.

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
                {
                    // Se crea una conexión a la base de datos utilizando OleDbConnection.

                    conexion.Open();
                    // Se abre la conexión a la base de datos.

                    using (OleDbCommand comando = new OleDbCommand(Sentenciasql, conexion))
                    {
                        // Se crea un objeto OleDbCommand para ejecutar la consulta SQL.

                        comando.Parameters.AddWithValue("param1", idUsuario);
                        comando.Parameters.AddWithValue("param2", fecha);
                        comando.Parameters.AddWithValue("param3", categoria);
                        // Se agregan parámetros para reemplazar los marcadores de posición en la consulta SQL.

                        comando.ExecuteNonQuery();
                        // Se ejecuta la consulta SQL para insertar el registro en la tabla "Logs".
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de que se produzca una excepción, se captura y se muestra un mensaje de error en una ventana emergente.
                MessageBox.Show(ex.Message);
            }
        }


    }


}

