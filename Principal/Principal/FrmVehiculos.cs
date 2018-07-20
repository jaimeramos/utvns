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
using Principal.Tools;


namespace Principal
{
    public partial class FrmVehiculos : Form
    {
        Vehiculo vehicle = new Vehiculo();
        public FrmVehiculos()
        {
            InitializeComponent();
        }
        private void validar(Form formulario)
        {
            //bool vacio = true; 
            foreach (Control oControls in gbVehiculos.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox)
                {
                    if (oControls.Text == String.Empty) // Verificamos que no este vacio. 
                    {
                        // vacio = true;
                        // if (vacio == true)
                        MessageBox.Show("Favor de llenar los campos vacios."); // Si nuestra variable es verdadera mostramos un mensaje.
                        break;                                                     // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                    }
                    else
                    {
                        //vacio = false; // Devolvemos el valor original a nuestra variable. 
                        loadDataFromForm();
                        vehicle.upSert(false);
                        reloadInitialState();
                    }
                }
            }
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
          fillGridView();
          //dtgVehiculo.DataSource =  user.read();
        }
        public void fillGridView()
        {
            string json = vehicle.read();
            dtgVehiculo.DataSource = Util.convertToDataTable(json);
            dtgVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gbVehiculos.Enabled = false;

            this.dtgVehiculo.Columns["created_at"].Visible = false;
            this.dtgVehiculo.Columns["updated_at"].Visible = false;
            this.dtgVehiculo.Columns["_id"].Visible = false;
            this.dtgVehiculo.Columns["active"].Visible = false;
           

            dtgVehiculo.Columns["number"].DisplayIndex = 0;
            dtgVehiculo.Columns["number"].HeaderText = "Numero";
            dtgVehiculo.Columns["number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["brand"].DisplayIndex = 1;
            dtgVehiculo.Columns["brand"].HeaderText = "Marca";
            dtgVehiculo.Columns["brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["model"].DisplayIndex = 2;
            dtgVehiculo.Columns["model"].HeaderText = "Modelo";
            dtgVehiculo.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["type"].DisplayIndex = 3;
            dtgVehiculo.Columns["type"].HeaderText = "Tipo";
            dtgVehiculo.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["description"].DisplayIndex = 4;
            dtgVehiculo.Columns["description"].HeaderText = "Descripcion";
            dtgVehiculo.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["year"].DisplayIndex = 5;
            dtgVehiculo.Columns["year"].HeaderText = "Año";
            dtgVehiculo.Columns["year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["color"].DisplayIndex = 6;
            dtgVehiculo.Columns["color"].HeaderText = "Color";
            dtgVehiculo.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["serie"].DisplayIndex = 7;
            dtgVehiculo.Columns["serie"].HeaderText = "Serie";
            dtgVehiculo.Columns["serie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["motorserie"].DisplayIndex = 8;
            dtgVehiculo.Columns["motorserie"].HeaderText = "Serie motor";
            dtgVehiculo.Columns["motorserie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["plate"].DisplayIndex = 9;
            dtgVehiculo.Columns["plate"].HeaderText = "Placa";
            dtgVehiculo.Columns["plate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgVehiculo.Columns["iddriver"].DisplayIndex = 10;
            dtgVehiculo.Columns["iddriver"].HeaderText = "Numero permisionario";
            dtgVehiculo.Columns["iddriver"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
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
           
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            
       }

        private void Editar_Click(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = true;
            btnVguardar.Enabled = false;
            btnVguardar.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Vehiculo vehicle = new Vehiculo();
            vehicle.read();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtVfiltro.Text != "")
            {
                dtgVehiculo.CurrentCell = null;
                foreach (DataGridViewRow r in dtgVehiculo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgVehiculo.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).Contains(txtVfiltro.Text.ToUpper()))
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                fillGridView();
            }
        }

        private void btnVFiltrar_Click(object sender, EventArgs e)
        {

            txtVfiltro.Text = string.Empty;
            fillGridView();
        }

        private void btnVnuevo_Click(object sender, EventArgs e)
        {
            txtVnumero.Text = "";
            txtVmarca.Text = "";
            txtVmodelo.Text = "";
            cmbVtipo.Text = "";
            txtVdescripcion.Text = "";
            txtVaño.Text = "";
            txtVcolor.Text = "";
            txtVserie.Text = "";
            txtVseriemotor.Text = "";
            txtVplaca.Text = "";
            txtVnumpermisionario.Text = "";
            vehicle = new Vehiculo();
            gbVehiculos.Enabled = true;
            btnVguardar.Enabled = true;
            gbVehiculos1.Enabled = false;
        }

        private void btnVeditar_Click(object sender, EventArgs e)
        {
            gbVehiculos.Enabled = true;
            gbVehiculos1.Enabled = false;
            btnVguardar.Enabled = true;
        }
        public void loadDataFromGrid(DataGridViewRow row) {
            vehicle.Number = txtVnumero.Text = row.Cells["number"].Value.ToString();
            vehicle.Brand = txtVmarca.Text = row.Cells["brand"].Value.ToString();
            vehicle.Model = txtVmodelo.Text = row.Cells["model"].Value.ToString();
            vehicle.Type = cmbVtipo.Text = row.Cells["type"].Value.ToString();
            vehicle.Description = txtVdescripcion.Text = row.Cells["description"].Value.ToString();
            vehicle.Year = txtVaño.Text = row.Cells["year"].Value.ToString();
            vehicle.Color = txtVcolor.Text = row.Cells["color"].Value.ToString();
            vehicle.Serie = txtVserie.Text = row.Cells["serie"].Value.ToString();
            vehicle.Motorserie = txtVseriemotor.Text = row.Cells["motorserie"].Value.ToString();
            vehicle.Plate = txtVplaca.Text = row.Cells["plate"].Value.ToString();
            vehicle.Iddriver = txtVnumpermisionario.Text = row.Cells["iddriver"].Value.ToString();
            vehicle.Id = row.Cells["_id"].Value.ToString();
            
        }
        public void loadDataFromForm()
        {
            vehicle.Number = txtVnumero.Text;
            vehicle.Brand = txtVmarca.Text;
            vehicle.Model = txtVmodelo.Text;
            vehicle.Type = cmbVtipo.Text;
            vehicle.Description = txtVdescripcion.Text;
            vehicle.Year = txtVaño.Text;
            vehicle.Color = txtVcolor.Text;
            vehicle.Serie = txtVserie.Text;
            vehicle.Motorserie = txtVseriemotor.Text;
            vehicle.Plate = txtVplaca.Text;
            vehicle.Iddriver = txtVnumpermisionario.Text;

                   }


        private void btnVcancelar_Click(object sender, EventArgs e)
        {
            gbVehiculos1.Enabled = true;
            gbVehiculos.Enabled = false;
        }

        private void btnVguardar_Click(object sender, EventArgs e)
        {
            validar(this);


            //  loadDataFromForm();
            //    string pwd1 = txtUccontraseña.Text.Trim(), pwd2 = txtUcontraseña.Text.Trim();
            //    if (pwd1.Equals(string.Empty) && pwd2.Equals(string.Empty))
            //    {
            //        vehicle.upSert(false);

            //     }
            //    else
            //    {
            //        if (pwd1.Length >= 8 && pwd2.Length >= 8 && pwd1.Equals(pwd2))
            //        {
            //            user.Pwd = txtUcontraseña.Text;
            //            user.upSert(true);
            //            reloadInitialState();
            //        }
            //        else
            //       {
            //            MessageBox.Show("Verifique que la contraseña coincida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
        }
        public void reloadInitialState()
        {
            gbVehiculos.Enabled = false;
            gbVehiculos1.Enabled = true;
            btnVguardar.Enabled = false;
            fillGridView();
            
        }

        private void dtgVehiculo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgVehiculo.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }
    }
}
