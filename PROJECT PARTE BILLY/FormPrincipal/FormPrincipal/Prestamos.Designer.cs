using System.ComponentModel;

namespace FormPrincipal
{
    partial class Prestamos
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
            this.dtpDevolucionH = new System.Windows.Forms.DateTimePicker();
            this.dtpPrestamoH = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDEjemplar = new System.Windows.Forms.TextBox();
            this.lblIDcoleccion = new System.Windows.Forms.Label();
            this.txtPrestamoMod = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDevolucionH
            // 
            this.dtpDevolucionH.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDevolucionH.Location = new System.Drawing.Point(569, 268);
            this.dtpDevolucionH.Name = "dtpDevolucionH";
            this.dtpDevolucionH.Size = new System.Drawing.Size(249, 22);
            this.dtpDevolucionH.TabIndex = 107;
            // 
            // dtpPrestamoH
            // 
            this.dtpPrestamoH.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPrestamoH.Location = new System.Drawing.Point(569, 177);
            this.dtpPrestamoH.Name = "dtpPrestamoH";
            this.dtpPrestamoH.Size = new System.Drawing.Size(249, 22);
            this.dtpPrestamoH.TabIndex = 106;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(569, 240);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(249, 22);
            this.dtpDevolucion.TabIndex = 105;
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.Location = new System.Drawing.Point(569, 149);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(249, 22);
            this.dtpPrestamo.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(569, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 22);
            this.label4.TabIndex = 103;
            this.label4.Text = "ID Ejemplar";
            // 
            // txtIDEjemplar
            // 
            this.txtIDEjemplar.Location = new System.Drawing.Point(569, 379);
            this.txtIDEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEjemplar.Name = "txtIDEjemplar";
            this.txtIDEjemplar.Size = new System.Drawing.Size(249, 22);
            this.txtIDEjemplar.TabIndex = 102;
            // 
            // lblIDcoleccion
            // 
            this.lblIDcoleccion.Location = new System.Drawing.Point(569, 415);
            this.lblIDcoleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDcoleccion.Name = "lblIDcoleccion";
            this.lblIDcoleccion.Size = new System.Drawing.Size(324, 22);
            this.lblIDcoleccion.TabIndex = 101;
            this.lblIDcoleccion.Text = "ID Reserva (eliminar o editar)";
            // 
            // txtPrestamoMod
            // 
            this.txtPrestamoMod.Location = new System.Drawing.Point(569, 441);
            this.txtPrestamoMod.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrestamoMod.Name = "txtPrestamoMod";
            this.txtPrestamoMod.Size = new System.Drawing.Size(249, 22);
            this.txtPrestamoMod.TabIndex = 100;
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(569, 124);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(324, 22);
            this.lblGenero.TabIndex = 99;
            this.lblGenero.Text = "Fecha y hora de prestamo";
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(569, 215);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(324, 22);
            this.lblTipo.TabIndex = 98;
            this.lblTipo.Text = "Fecha y hora de devolucion";
            // 
            // lblPiso
            // 
            this.lblPiso.Location = new System.Drawing.Point(569, 303);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(324, 22);
            this.lblPiso.TabIndex = 97;
            this.lblPiso.Text = "ID Usuario\r\n\r\n";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(569, 327);
            this.txtIDUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(249, 22);
            this.txtIDUsuario.TabIndex = 96;
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnActualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar2.ForeColor = System.Drawing.Color.White;
            this.btnActualizar2.Location = new System.Drawing.Point(307, 460);
            this.btnActualizar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(180, 37);
            this.btnActualizar2.TabIndex = 95;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = false;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(45, 127);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.Size = new System.Drawing.Size(443, 288);
            this.dgvPrestamos.TabIndex = 94;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(307, 515);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(180, 37);
            this.btnMostrar.TabIndex = 93;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(45, 515);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 37);
            this.btnEliminar.TabIndex = 92;
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
            this.btnAgregar.Location = new System.Drawing.Point(45, 460);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 37);
            this.btnAgregar.TabIndex = 91;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(228, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 66);
            this.label1.TabIndex = 90;
            this.label1.Text = "PRESTAMOS";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(569, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 108;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(569, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 109;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(569, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 23);
            this.label5.TabIndex = 110;
            this.label5.Text = "label5";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 583);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDevolucionH);
            this.Controls.Add(this.dtpPrestamoH);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.dtpPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDEjemplar);
            this.Controls.Add(this.lblIDcoleccion);
            this.Controls.Add(this.txtPrestamoMod);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize) (this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DateTimePicker dtpDevolucionH;
        private System.Windows.Forms.DateTimePicker dtpPrestamoH;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDEjemplar;
        private System.Windows.Forms.Label lblIDcoleccion;
        private System.Windows.Forms.TextBox txtPrestamoMod;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}