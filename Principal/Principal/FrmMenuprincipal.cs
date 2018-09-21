using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Principal.EnlaceDatos;

namespace Principal
{
    public partial class FrmMenuprincipal : Form
    {
        public FrmMenuprincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int Mesg, int wparam, int Iparam);
        private void FrmMenuprincipal_Load(object sender, EventArgs e)
        {
            lblMuser.Text = Data.user;
        }
        public void abrirfrmMenu(object frmMenu)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = frmMenu as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnMvehiculos_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmVehiculos());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

       private void btnSistemas_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pnlMenuvertical_MouseHover_1(object sender, EventArgs e)
        {
            pnlTransacciones.Visible = false;
            pnlCatalogo.Visible = false;
            pnlSistemas.Visible = false;
            //btnCatalogos.Location = new Point(21, 172);
            btnTransacciones.Location = new Point(14, 60);
            btnSistemas.Location = new Point(14, 120);
        }

        private void panelContenedor_MouseHover_1(object sender, EventArgs e)
        {
            pnlTransacciones.Visible = false;
            pnlCatalogo.Visible = false;
            pnlSistemas.Visible = false;
            //btnCatalogos.Location = new Point(21, 172);
            //btnTransacciones.Location = new Point(21, 272);
            //btnSistemas.Location = new Point(21, 372);
        }
        private void pnlMenuvertical_MouseHover(object sender, EventArgs e)
        {
            pnlTransacciones.Visible = false;
            pnlCatalogo.Visible = false;
            pnlSistemas.Visible = false;
            
        }
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (pnlMenuvertical.Width == 281)
            {
                pnlMenuvertical.Width = 82;
            }
            else
                pnlMenuvertical.Width = 281;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir del Sistema?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void iconmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir del Sistema?", "Cerrar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        

        

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            pnlMenuvertical.Enabled = true;
            Barratitulo.Enabled = true;
        }

        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMpermisionarios_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmPermisionarios());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void btnMgusuarios_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmUsuarios());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmPermisos());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmEjecutivos());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmMecanicos());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmProveedores());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmPiezasrecambios());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmWorkshopsvcs());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmLineadenegocios());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmIncometypes());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void btnMegresos_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmOutcomes());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }
        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            pnlCatalogo.Visible = true;
            pnlTransacciones.Visible = false;
            pnlSistemas.Visible = false;
            btnCatalogos.Location = new Point(14, 5);
            btnTransacciones.Location = new Point(14, 60 + pnlCatalogo.Size.Height);
            btnSistemas.Location = new Point(14, btnTransacciones.Location.Y + 60);
            pnlTransacciones.Location = new Point(121, 110);
        }
        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            pnlCatalogo.Visible = false;
            pnlTransacciones.Visible = true;
            pnlSistemas.Visible = false;
            btnCatalogos.Location = new Point(14, 5);
            btnTransacciones.Location = new Point(14, 60);
            btnSistemas.Location = new Point(14, btnTransacciones.Location.Y +51+ pnlTransacciones.Size.Height);
            pnlTransacciones.Location = new Point(121, 111);
        }

        private void btnSistemas_Click(object sender, EventArgs e)
        {
            pnlCatalogo.Visible = false;
            pnlTransacciones.Visible = false;
            pnlSistemas.Visible = true;
            btnCatalogos.Location = new Point(14, 5);
            btnTransacciones.Location = new Point(14, 60);
            btnSistemas.Location = new Point(14, 120);
            pnlSistemas.Location = new Point(121,btnSistemas.Location.Y+51);
        }

        private void Barratitulo_EnabledChanged(object sender, EventArgs e)
        {
            if (!Barratitulo.Enabled) Barratitulo.BackColor = Color.Gray;
            else Barratitulo.BackColor = Color.Azure;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmSales());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }

        private void FrmMenuprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMingresos_Click(object sender, EventArgs e)
        {
            abrirfrmMenu(new FrmIngresos());
            pnlMenuvertical.Enabled = false;
            Barratitulo.Enabled = false;
        }
    }
  }

