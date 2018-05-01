using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.Entidades;
namespace Principal
{
    public partial class FrmVehiculos : Form
    {
        Usuario user = new Usuario();
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void lblVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
          gbVehiculos.Enabled = false;
          dtgVehiculos.DataSource =  user.read();
            bool x = true;
         }

        
 void btnSalir_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = false;
            MessageBox.Show("Vehiculo Fue Registrado");

            // FrmRegVehiculos vreg = new FrmRegVehiculos();
            //vreg.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = true;
            btnVactualizar.Enabled = false;
            btnVguardar.Enabled = true;

            txtID.Text = "";
            txtNumero.Text = "";
            txtModelo.Text = "";
            cmbTipo.Text = "";
            txtDescripcion.Text = "";
            txtAño.Text = "";
            txtColor.Text = "";
            txtSerie.Text = "";
            txtSeriemotor.Text = "";
            txtPlaca.Text = "";
            cmbEstatus.Text = "";
            dtpAlta.Text = "";
            dtpActualizacion.Text = "";
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = true;
            btnVguardar.Enabled = false;
            btnVactualizar.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.read();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
