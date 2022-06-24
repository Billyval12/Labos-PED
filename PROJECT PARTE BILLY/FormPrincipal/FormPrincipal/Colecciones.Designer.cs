using System.ComponentModel;

namespace FormPrincipal
{
    partial class Colecciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblColecciones = new System.Windows.Forms.Label();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.lblIDcoleccion = new System.Windows.Forms.Label();
            this.txtIDcoleccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvColeccion = new System.Windows.Forms.DataGridView();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtNombe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvColeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColecciones
            // 
            this.lblColecciones.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblColecciones.Location = new System.Drawing.Point(209, 9);
            this.lblColecciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(291, 54);
            this.lblColecciones.TabIndex = 1;
            this.lblColecciones.Text = "COLECCIONES";
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnActualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar2.ForeColor = System.Drawing.Color.White;
            this.btnActualizar2.Location = new System.Drawing.Point(226, 350);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(135, 30);
            this.btnActualizar2.TabIndex = 34;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = false;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // lblIDcoleccion
            // 
            this.lblIDcoleccion.Location = new System.Drawing.Point(414, 357);
            this.lblIDcoleccion.Name = "lblIDcoleccion";
            this.lblIDcoleccion.Size = new System.Drawing.Size(243, 18);
            this.lblIDcoleccion.TabIndex = 33;
            this.lblIDcoleccion.Text = "ID coleccion (eliminar o editar)";
            // 
            // txtIDcoleccion
            // 
            this.txtIDcoleccion.Location = new System.Drawing.Point(414, 378);
            this.txtIDcoleccion.Name = "txtIDcoleccion";
            this.txtIDcoleccion.Size = new System.Drawing.Size(234, 20);
            this.txtIDcoleccion.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(414, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(243, 18);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // dgvColeccion
            // 
            this.dgvColeccion.AllowUserToAddRows = false;
            this.dgvColeccion.AllowUserToDeleteRows = false;
            this.dgvColeccion.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.dgvColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColeccion.Location = new System.Drawing.Point(29, 80);
            this.dgvColeccion.Name = "dgvColeccion";
            this.dgvColeccion.ReadOnly = true;
            this.dgvColeccion.Size = new System.Drawing.Size(332, 234);
            this.dgvColeccion.TabIndex = 30;
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(414, 150);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(243, 18);
            this.lblGenero.TabIndex = 29;
            this.lblGenero.Text = "ID Genero";
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(414, 210);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(243, 18);
            this.lblTipo.TabIndex = 28;
            this.lblTipo.Text = "ID Tipo";
            // 
            // lblPiso
            // 
            this.lblPiso.Location = new System.Drawing.Point(414, 272);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(243, 18);
            this.lblPiso.TabIndex = 27;
            this.lblPiso.Text = "Numero de piso";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(226, 395);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Mostrar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(29, 395);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 30);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(29, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 30);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(414, 293);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(234, 20);
            this.txtPiso.TabIndex = 23;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(414, 231);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(234, 20);
            this.txtTipo.TabIndex = 22;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(414, 171);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(234, 20);
            this.txtGenero.TabIndex = 21;
            // 
            // txtNombe
            // 
            this.txtNombe.Location = new System.Drawing.Point(414, 107);
            this.txtNombe.Name = "txtNombe";
            this.txtNombe.Size = new System.Drawing.Size(234, 20);
            this.txtNombe.TabIndex = 20;
            // 
            // Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.lblIDcoleccion);
            this.Controls.Add(this.txtIDcoleccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvColeccion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombe);
            this.Controls.Add(this.lblColecciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Colecciones";
            this.Text = "Colecciones";
            ((System.ComponentModel.ISupportInitialize) (this.dgvColeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.Label lblIDcoleccion;
        private System.Windows.Forms.TextBox txtIDcoleccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvColeccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtNombe;

        private System.Windows.Forms.Label lblColecciones;

        #endregion
    }
}