using System;

namespace FormPrincipal
{
    public class Prestamo
    {
        public int id_prestamo { get; set; }
        public DateTime fecha_hora_prestamo { get; set; }
        public DateTime fecha_hora_devolucion { get; set; }
        public int id_usuario { get; set; }
        public int id_ejemplar { get; set; }
        
        public Prestamo()
        {
            this.id_prestamo = 0;
            this.id_usuario = 0;
            this.id_ejemplar = 0;
        }

        public Prestamo(int id_prestamo, DateTime fecha_hora_prestamo, DateTime fecha_hora_devolucion, int id_usuario, int id_ejemplar)
        {
            this.id_prestamo = id_prestamo;
            this.fecha_hora_prestamo = fecha_hora_prestamo;
            this.fecha_hora_devolucion = fecha_hora_devolucion;
            this.id_usuario = id_usuario;
            this.id_ejemplar = id_ejemplar;
        }
    }
}