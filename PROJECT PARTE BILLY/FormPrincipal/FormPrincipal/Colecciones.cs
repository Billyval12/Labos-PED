using System;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Colecciones : Form
    {
        public Colecciones()
        {
            InitializeComponent();
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (txtNombe.Text.Length > 0 && txtGenero.Text.Length > 0 && txtPiso.Text.Length > 0 &&
                txtPiso.Text.Length > 0)
            {
                Coleccion col = new Coleccion();
                col.IDcoleccion = Convert.ToInt32(txtIDcoleccion.Text);
                col.Nombre = txtNombe.Text;
                col.IDgenero = Convert.ToInt32(txtGenero.Text);
                col.IDtipo = Convert.ToInt32(txtTipo.Text);
                col.numeroPiso = Convert.ToInt32(txtPiso.Text);
                
                
                if (ColeccionDAO.ActualizarPorID(col))
                    MessageBox.Show("Coleccion actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvColeccion.DataSource = null;
            dgvColeccion.DataSource = ColeccionDAO.ObtenerTodos();
            
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDcoleccion.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDcoleccion.Text);

                if (ColeccionDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Coleccion eliminada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de coleccion correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvColeccion.DataSource = null;
            dgvColeccion.DataSource = ColeccionDAO.ObtenerTodos();
            
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombe.Text.Length > 2 && txtGenero.Text.Length > 0 && txtPiso.Text.Length > 0 &&
                txtPiso.Text.Length > 0)
            {
                Coleccion col = new Coleccion();
                col.Nombre = txtNombe.Text;
                col.IDgenero = Convert.ToInt32(txtGenero.Text);
                col.IDtipo = Convert.ToInt32(txtTipo.Text);
                col.numeroPiso = Convert.ToInt32(txtPiso.Text);

                ColeccionDAO.CrearNuevo(col);
                MessageBox.Show("Nueva coleccion agregada correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            Limpiar();
            dgvColeccion.DataSource = null;
            dgvColeccion.DataSource = ColeccionDAO.ObtenerTodos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvColeccion.DataSource = null;
            dgvColeccion.DataSource = ColeccionDAO.ObtenerTodos();
        }
        
        public void Limpiar()
        {
            txtIDcoleccion.Clear();
            txtNombe.Clear();
            txtGenero.Clear();
            txtTipo.Clear();
            txtPiso.Clear();
        }
    }
}