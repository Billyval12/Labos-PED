using System;

namespace FormPrincipal
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public DateTime fecha_hora_reserva { get; set; }
        public DateTime fecha_hora_prestamo { get; set; }
        public DateTime fecha_hora_devolucion { get; set; }
        public int id_usuario { get; set; }
        public int id_ejemplar { get; set; }

        public Reserva()
        {
            this.id_reserva = 0;
            this.id_usuario = 0;
            this.id_ejemplar = 0;
        }

        public Reserva(int id_reserva, DateTime fecha_hora_reserva, DateTime fecha_hora_prestamo, DateTime fecha_hora_devolucion, int id_usuario, int id_ejemplar)
        {
            this.id_reserva = id_reserva;
            this.fecha_hora_reserva = fecha_hora_reserva;
            this.fecha_hora_prestamo = fecha_hora_prestamo;
            this.fecha_hora_devolucion = fecha_hora_devolucion;
            this.id_usuario = id_usuario;
            this.id_ejemplar = id_ejemplar;
        }
    }
}