using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class PrestamosDAO
    {
        public static List<Prestamo> ObtenerTodos(){
                string cadena = Resources.cadena_conexion;
                List<Prestamo> lista = new List<Prestamo>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT * FROM PRESTAMO";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Prestamo prestamo = new Prestamo();
                            prestamo.id_prestamo = Convert.ToInt32(reader["id_prestamo"].ToString());
                            prestamo.fecha_hora_prestamo = Convert.ToDateTime(reader["fecha_hora_prestamo"].ToString());
                            prestamo.fecha_hora_devolucion = Convert.ToDateTime(reader["fecha_hora_devolucion"].ToString());
                            prestamo.id_usuario = Convert.ToInt32(reader["id_usuario"].ToString());
                            prestamo.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            lista.Add(prestamo);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
        
            public static void CrearNuevo(Prestamo col)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO PRESTAMO (fecha_hora_prestamo, fecha_hora_devolucion, id_usuario,id_ejemplar) "+
                                   " VALUES (@fecha_hora_prestamo, @fecha_hora_devolucion, @id_usuario, @id_ejemplar)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fecha_hora_prestamo", Convert.ToDateTime(col.fecha_hora_prestamo));
                    command.Parameters.AddWithValue("@fecha_hora_devolucion", Convert.ToDateTime(col.fecha_hora_devolucion));
                    command.Parameters.AddWithValue("@id_usuario", Convert.ToInt32(col.id_usuario));
                    command.Parameters.AddWithValue("@id_ejemplar", Convert.ToInt32(col.id_ejemplar));
                
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }
            
            public static bool EliminarPorID(int ID) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "DELETE FROM PRESTAMO WHERE id_prestamo = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", ID.ToString());
               
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception e) {
                    exito = false;
                }
                return exito;
            } 
            
            public static bool ActualizarPorID(Prestamo col) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "UPDATE PRESTAMO SET fecha_hora_prestamo = @nueva_fecha_hora_prestamo,fecha_hora_devolucion = @nueva_fecha_hora_devolucion, id_usuario = @nuevo_id_usuario, id_ejemplar = @nuevo_id_ejemplar WHERE id_prestamo = @id_prestamo";
                        SqlCommand command = new SqlCommand(query, connection);
                        
                        command.Parameters.AddWithValue("@id_prestamo", Convert.ToInt32(col.id_prestamo));
                        command.Parameters.AddWithValue("@nueva_fecha_hora_prestamo", Convert.ToDateTime(col.fecha_hora_prestamo));
                        command.Parameters.AddWithValue("@nueva_fecha_hora_devolucion", Convert.ToDateTime(col.fecha_hora_devolucion));
                        command.Parameters.AddWithValue("@nuevo_id_usuario",Convert.ToInt32(col.id_usuario) );
                        command.Parameters.AddWithValue("@nuevo_id_ejemplar",Convert.ToInt32(col.id_ejemplar));
               
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception e) {
                    exito = false;
                }
                return exito;
            }
    }
}