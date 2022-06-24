using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public static class ColeccionDAO
    {
        public static List<Coleccion> ObtenerTodos(){
                string cadena = Resources.cadena_conexion;
                List<Coleccion> lista = new List<Coleccion>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT id_coleccion, nombre, id_genero, id_tipo, numero_de_piso" + " FROM COLECCION";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Coleccion col = new Coleccion();
                            col.IDcoleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                            col.Nombre = reader["nombre"].ToString();
                            col.IDgenero = Convert.ToInt32(reader["id_genero"].ToString());
                            col.IDtipo = Convert.ToInt32(reader["id_tipo"].ToString());
                            col.numeroPiso = Convert.ToInt32(reader["numero_de_piso"].ToString());
                            lista.Add(col);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
        
            public static void CrearNuevo(Coleccion col)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO COLECCION (nombre, id_genero, id_tipo, numero_de_piso) " + 
                                   "VALUES (@nombre, @id_genero, @id_tipo, @numero_de_piso)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", col.Nombre);
                    command.Parameters.AddWithValue("@id_genero", col.IDgenero);
                    command.Parameters.AddWithValue("@id_tipo", col.IDtipo);
                    command.Parameters.AddWithValue("@numero_de_piso", col.numeroPiso);
                
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
                        string query = "DELETE FROM COLECCION WHERE id_coleccion = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", ID);
               
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
            
            public static bool ActualizarPorID(Coleccion col) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "UPDATE COLECCION SET nombre = @nuevonombre, id_genero = @nuevoid_genero, id_tipo = @nuevoid_tipo, numero_de_piso= @nuevonumero_de_piso WHERE id_coleccion = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        
                        command.Parameters.AddWithValue("@id", col.IDcoleccion);
                        command.Parameters.AddWithValue("@nuevonombre", col.Nombre);
                        command.Parameters.AddWithValue("@nuevoid_genero", col.IDgenero);
                        command.Parameters.AddWithValue("@nuevoid_tipo", col.IDtipo);
                        command.Parameters.AddWithValue("@nuevonumero_de_piso", col.numeroPiso);
               
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