﻿using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculos v = new FrmVehiculos();
            v.MdiParent = this;
            v.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void titularDelPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPermisionarios P = new FrmPermisionarios();
            P.MdiParent = this;
            P.Show();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios U = new FrmUsuarios();
            U.MdiParent = this;
            U.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
