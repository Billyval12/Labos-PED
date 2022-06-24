using System;
using System.Timers;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtIDUsuario.Clear();
            txtIDEjemplar.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtpReserva.Value != null && dtpPrestamo.Value != null && dtpDevolucion.Value != null && txtIDUsuario.Text.Length >0 && 
                txtIDEjemplar.Text.Length > 0)
            {
                Reserva col = new Reserva();
                col.fecha_hora_reserva = dtpReserva.Value.Date + dtpReservaH.Value.TimeOfDay;
                col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                col.id_usuario = Convert.ToInt32(txtIDUsuario.Text);
                col.id_ejemplar = Convert.ToInt32(txtIDEjemplar.Text);

                ReservasDAO.CrearNuevo(col);
                MessageBox.Show("Nueva reserva agregada correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
           
            Limpiar();
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = ReservasDAO.ObtenerTodos();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = ReservasDAO.ObtenerTodos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtReservaMod.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtReservaMod.Text);

                if (ReservasDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Reserva eliminada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de reserva correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = ReservasDAO.ObtenerTodos();
            
            Limpiar();
        }


        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (dtpReserva.Value != null && dtpPrestamo.Value != null && dtpDevolucion.Value != null && txtIDUsuario.Text.Length >0 && 
                txtIDEjemplar.Text.Length > 0)
            {
                Reserva col = new Reserva();
                col.id_reserva = Convert.ToInt32(txtReservaMod.Text);
                col.fecha_hora_reserva = dtpReserva.Value.Date + dtpReservaH.Value.TimeOfDay;
                col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                col.id_usuario = Convert.ToInt32(txtIDUsuario.Text);
                col.id_ejemplar = Convert.ToInt32(txtIDEjemplar.Text);

                ReservasDAO.ActualizarPorID(col);
                MessageBox.Show("Reserva actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
           
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = ReservasDAO.ObtenerTodos();
            Limpiar();
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            dtpReservaH.Value = DateTime.Now;
        }
    }
}