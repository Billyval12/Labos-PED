using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class ReservasDAO
    {
        public static List<Reserva> ObtenerTodos(){
                string cadena = Resources.cadena_conexion;
                List<Reserva> lista = new List<Reserva>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT * FROM RESERVA";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva();
                            reserva.id_reserva = Convert.ToInt32(reader["id_reserva"].ToString());
                            reserva.fecha_hora_reserva= Convert.ToDateTime(reader["fecha_hora_reserva"].ToString());
                            reserva.fecha_hora_prestamo = Convert.ToDateTime(reader["fecha_hora_prestamo"].ToString());
                            reserva.fecha_hora_devolucion = Convert.ToDateTime(reader["fecha_hora_devolucion"].ToString());
                            reserva.id_usuario = Convert.ToInt32(reader["id_usuario"].ToString());
                            reserva.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            lista.Add(reserva);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }

        public static void CrearNuevo(Reserva col)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO RESERVA (fecha_hora_reserva, fecha_hora_prestamo, fecha_hora_devolucion, id_usuario,id_ejemplar) "+
                                   " VALUES (@fecha_hora_reserva, @fecha_hora_prestamo, @fecha_hora_devolucion, @id_usuario, @id_ejemplar)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fecha_hora_reserva", Convert.ToDateTime(col.fecha_hora_reserva));
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
                        string query = "DELETE FROM RESERVA WHERE id_reserva = @id";
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
            
            public static bool ActualizarPorID(Reserva col) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "UPDATE RESERVA SET fecha_hora_reserva = @nueva_fecha_hora_reserva, fecha_hora_prestamo = @nueva_fecha_hora_prestamo,fecha_hora_devolucion = @nueva_fecha_hora_devolucion, id_usuario = @nuevo_id_usuario, id_ejemplar = @nuevo_id_ejemplar WHERE id_reserva = @id_reserva";
                        SqlCommand command = new SqlCommand(query, connection);
                        
                        command.Parameters.AddWithValue("@id_reserva", Convert.ToInt32(col.id_reserva));
                        command.Parameters.AddWithValue("@nueva_fecha_hora_reserva", Convert.ToDateTime(col.fecha_hora_reserva));
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