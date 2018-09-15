using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Principal.Entidades;
using Principal.Tools;



namespace Principal
{
    public interface IFindDriver
    {
        void SelectedDriver(Permisionario chofer);
    }

    public interface IFindPermit
    {
        void Selected(Permiso permit);
    }

    public partial class FrmVehiculos : Form, IFindPermit, IFindDriver
    {
        Vehiculo vehicle = new Vehiculo();

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
            loadComboboxPermisionario();
            loadComboboxPermiso();
            gbVehiculos.Enabled = false;
            fillGridView();
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
            txtVdescripcion.Text = "";
            txtVaño.Text = "";
            txtVcolor.Text = "";
            txtVserie.Text = "";
            txtVseriemotor.Text = "";
            txtVplaca.Text = "";
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

        private void btnVcancelar_Click(object sender, EventArgs e)
        {
            gbVehiculos1.Enabled = true;
            gbVehiculos.Enabled = false;
        }

        private void btnVguardar_Click(object sender, EventArgs e)
        {
            if (validar(this)) {
                loadDataFromForm();
                string x=vehicle.upSert();
                Vehiculo nuevoVehiculo = JsonConvert.DeserializeObject<Vehiculo>(x.Replace("_id", "Id"));
                Permitvehicle permitvehicle = new Permitvehicle();
                permitvehicle.Idvehicle = nuevoVehiculo.Id;
                permitvehicle.Idpermit = nuevoVehiculo.Idpermit;
                permitvehicle.Dateassigned = DateTime.Today.ToShortDateString().Substring(0, 10);
                permitvehicle.upSert();
                Driverassign driverassign = new Driverassign();
                driverassign.Idvehicle = nuevoVehiculo.Id;
                driverassign.Iddriver  = nuevoVehiculo.Iddriver;
                driverassign.Dateassigned = DateTime.Today.ToShortDateString().Substring(0, 10);
                driverassign.upSert();
                reloadInitialState();
            }
        }

        private void dtgVehiculo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgVehiculo.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        private bool validar(Form formulario)
        {
            bool todoOk = true;
            foreach (Control oControls in gbVehiculos.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox)
                {
                    if (oControls.Text == String.Empty) // Verificamos que no este vacio. 
                    {
                        MessageBox.Show("Favor de llenar los campos vacios."); // Si nuestra variable es verdadera mostramos un mensaje.
                        todoOk = false;
                        break;                                                     // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                    }
                }
            }
            return todoOk;
        }

        public void reloadInitialState()
        {
            gbVehiculos.Enabled = false;
            gbVehiculos1.Enabled = true;
            btnVguardar.Enabled = false;
            fillGridView();
        }

        public void loadDataFromGrid(DataGridViewRow row)
        {
            vehicle.Number = txtVnumero.Text = row.Cells["number"].Value.ToString();
            vehicle.Brand = txtVmarca.Text = row.Cells["brand"].Value.ToString();
            vehicle.Model = txtVmodelo.Text = row.Cells["model"].Value.ToString();
            vehicle.Description = txtVdescripcion.Text = row.Cells["description"].Value.ToString();
            vehicle.Year = txtVaño.Text = row.Cells["year"].Value.ToString();
            vehicle.Color = txtVcolor.Text = row.Cells["color"].Value.ToString();
            vehicle.Serie = txtVserie.Text = row.Cells["serie"].Value.ToString();
            vehicle.Motorserie = txtVseriemotor.Text = row.Cells["motorserie"].Value.ToString();
            vehicle.Plate = txtVplaca.Text = row.Cells["plate"].Value.ToString();
            vehicle.Id = row.Cells["_id"].Value.ToString();
            vehicle.Iddriver= row.Cells["iddriver"].Value.ToString();
            cmbPermitholder.SelectedValue = vehicle.Iddriver;
            vehicle.Idpermit = row.Cells["idpermit"].Value.ToString();
            cmbPermit.SelectedValue = vehicle.Idpermit;
            vehicle.Active = rbActivo.Checked = (bool)row.Cells["active"].Value;
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            vehicle.Number = txtVnumero.Text;
            vehicle.Brand = txtVmarca.Text;
            vehicle.Model = txtVmodelo.Text;
            vehicle.Description = txtVdescripcion.Text;
            vehicle.Year = txtVaño.Text;
            vehicle.Color = txtVcolor.Text;
            vehicle.Serie = txtVserie.Text;
            vehicle.Motorserie = txtVseriemotor.Text;
            vehicle.Plate = txtVplaca.Text;
            vehicle.Iddriver = cmbPermitholder.SelectedValue.ToString();
            vehicle.Idpermit = cmbPermit.SelectedValue.ToString();
            vehicle.Active = rbActivo.Checked;
        }

        public void fillGridView()
        {
            string json = vehicle.read();
            if (!json.Equals("[]"))
            {
                dtgVehiculo.DataSource = Util.convertToDataTable(json);
                dtgVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                gbVehiculos.Enabled = false;

                this.dtgVehiculo.Columns["created_at"].Visible = false;
                this.dtgVehiculo.Columns["updated_at"].Visible = false;
                this.dtgVehiculo.Columns["_id"].Visible = false;
                this.dtgVehiculo.Columns["__v"].Visible = false;

                dtgVehiculo.Columns["number"].DisplayIndex = 0;
                dtgVehiculo.Columns["number"].HeaderText = "Numero";
                dtgVehiculo.Columns["number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["brand"].DisplayIndex = 1;
                dtgVehiculo.Columns["brand"].HeaderText = "Marca";
                dtgVehiculo.Columns["brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["model"].DisplayIndex = 2;
                dtgVehiculo.Columns["model"].HeaderText = "Modelo";
                dtgVehiculo.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dtgVehiculo.Columns["type"].DisplayIndex = 3;
                //dtgVehiculo.Columns["type"].HeaderText = "Tipo";
                //dtgVehiculo.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["description"].DisplayIndex = 3;
                dtgVehiculo.Columns["description"].HeaderText = "Descripcion";
                dtgVehiculo.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["year"].DisplayIndex = 4;
                dtgVehiculo.Columns["year"].HeaderText = "Año";
                dtgVehiculo.Columns["year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["color"].DisplayIndex = 5;
                dtgVehiculo.Columns["color"].HeaderText = "Color";
                dtgVehiculo.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["serie"].DisplayIndex = 6;
                dtgVehiculo.Columns["serie"].HeaderText = "Serie";
                dtgVehiculo.Columns["serie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["motorserie"].DisplayIndex = 7;
                dtgVehiculo.Columns["motorserie"].HeaderText = "Serie motor";
                dtgVehiculo.Columns["motorserie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["plate"].DisplayIndex = 8;
                dtgVehiculo.Columns["plate"].HeaderText = "Placa";
                dtgVehiculo.Columns["plate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["iddriver"].Visible = false;
                dtgVehiculo.Columns["iddriver"].DisplayIndex = 9;
                dtgVehiculo.Columns["iddriver"].HeaderText = "Numero permisionario";
                dtgVehiculo.Columns["iddriver"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["idpermit"].Visible = false;
                dtgVehiculo.Columns["idpermit"].DisplayIndex = 10;
                dtgVehiculo.Columns["idpermit"].HeaderText = "Numero de permiso";
                dtgVehiculo.Columns["idpermit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["active"].DisplayIndex = 11;
                dtgVehiculo.Columns["active"].HeaderText = "Status";
                dtgVehiculo.Columns["active"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void loadComboboxPermisionario() {
            Permisionario permitholder = new Permisionario();
            string json=permitholder.read();
            List<Permisionario> x = JsonConvert.DeserializeObject<List<Permisionario>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Permisionario p in x)
                {
                    datasource.Add(p.Id, p.Firstname + " " + p.Lastname);
                }
                cmbPermitholder.DataSource = new BindingSource(datasource, null);
                cmbPermitholder.DisplayMember = "Value";
                cmbPermitholder.ValueMember = "Key";
            }
        }

        private void loadComboboxPermiso()
        {
            Permiso permit = new Permiso();
            string json = permit.read();
            List<Permiso> x = JsonConvert.DeserializeObject<List<Permiso>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Permiso p in x)
                {
                    datasource.Add(p.Id, p.Description);
                }
                cmbPermit.DataSource = new BindingSource(datasource, null);
                cmbPermit.DisplayMember = "Value";
                cmbPermit.ValueMember = "Key";
            }
        }

        private void chbVehiculos_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        public void filterActive()
        {
            if (!chbVehiculos.Checked)
            {
                chbVehiculos.Text = "Mostrar solo vehiculos activos.";
                dtgVehiculo.CurrentCell = null;
                foreach (DataGridViewRow r in dtgVehiculo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgVehiculo.Rows)
                {
                    {
                        if ((bool)r.Cells["active"].Value)
                        {
                            r.Visible = true;
                        }
                    }
                }
            }
            else
            {
                chbVehiculos.Text = "Mostrar todos los vehiculos.";
                foreach (DataGridViewRow r in dtgVehiculo.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void txtVcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscarpermisos bPermisos = new Buscarpermisos(this, cmbPermit.SelectedValue.ToString());
            bPermisos.ShowDialog();
        } 

        void IFindPermit.Selected(Permiso permitSelected)
        {
            vehicle.Idpermit = permitSelected.Id;
            cmbPermit.SelectedValue = vehicle.Idpermit;
        }

        public void SelectedDriver(Permisionario driverSelected)
        {
            vehicle.Iddriver = driverSelected.Id;
            cmbPermitholder.SelectedValue = vehicle.Iddriver;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscarchoferes bChoferes = new Buscarchoferes(this, cmbPermit.SelectedValue.ToString());
            bChoferes.ShowDialog();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
