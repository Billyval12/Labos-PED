using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirFormulario(object form2)
        {
            if (this.PanelContainer.Controls.Count > 0)
            {
               this.PanelContainer.Controls.RemoveAt(0);
            }
            Form f2 = form2 as Form;
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(f2);
            this.PanelContainer.Tag = f2;
            f2.Show();
        }
        private void btINICIO_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Inicio());
            btINICIO.BackColor = Color.Orange;
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btPISOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Pisos());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = Color.DarkTurquoise;
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btAREAS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Areas());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = Color.DarkTurquoise;
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btEVENTOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Eventos());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = Color.DarkTurquoise;
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btCOLECCIONES_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Colecciones());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = Color.DarkTurquoise;
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btEJEMPLARES_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Ejemplares());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = Color.DarkTurquoise;
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btUSUARIOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Usuarios());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = Color.DarkTurquoise;
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btPRESTAMOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Prestamos());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = Color.DarkTurquoise;
            btRESERVAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btRESERVAS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Reservas());
            btINICIO.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPISOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btAREAS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEVENTOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btCOLECCIONES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btEJEMPLARES.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btUSUARIOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btPRESTAMOS.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btRESERVAS.BackColor = Color.DarkTurquoise;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abrirFormulario(new Inicio());
            btINICIO.BackColor = Color.Orange;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}