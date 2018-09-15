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
    public interface IFindVehicle
    {
        void Selected(Vehiculo vehiculo);
    }
    public partial class FrmEjecutivos : Form, IFindVehicle
    {
        Executivesvc executivesvc = new Executivesvc();

        public FrmEjecutivos()
        {
            InitializeComponent();
        }

        private void btnEjguardar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                loadDataFromForm();
                string x = executivesvc.upSert();
                reloadInitialState();
            }
        }

        private void FrmEjecutivos_Load(object sender, EventArgs e)
        {
            loadComboboxVehiculo();
            gbDatosGrid.Enabled = true;
            gbDatosForm.Enabled = false;
            fillGridView();
        }

        private void loadComboboxVehiculo()
        {
            Vehiculo vehicle = new Vehiculo();
            string json = vehicle.read();
            List<Vehiculo> x = JsonConvert.DeserializeObject<List<Vehiculo>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Vehiculo p in x)
                {
                    datasource.Add(p.Id, p.Number);
                }
                cmbVehicle.DataSource = new BindingSource(datasource, null);
                cmbVehicle.DisplayMember = "Value";
                cmbVehicle.ValueMember = "Key";
            }
        }

        public void fillGridView()
        {
            string json = executivesvc.read();
            if (!json.Equals("[]"))
            {
                dtgEjecutivo.DataSource = Util.convertToDataTable(json);
                dtgEjecutivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dtgEjecutivo.Enabled = false;

                dtgEjecutivo.Columns["created_at"].Visible = false;
                dtgEjecutivo.Columns["updated_at"].Visible = false;
                dtgEjecutivo.Columns["_id"].Visible = false;
                dtgEjecutivo.Columns["__v"].Visible = false;

                dtgEjecutivo.Columns["number"].DisplayIndex = 0;
                dtgEjecutivo.Columns["number"].HeaderText = "Número";
                dtgEjecutivo.Columns["number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["linenumber"].DisplayIndex = 1;
                dtgEjecutivo.Columns["linenumber"].HeaderText = "Número de línea";
                dtgEjecutivo.Columns["linenumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["imei"].DisplayIndex = 2;
                dtgEjecutivo.Columns["imei"].HeaderText = "Imei";
                dtgEjecutivo.Columns["imei"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["simcard"].DisplayIndex = 3;
                dtgEjecutivo.Columns["simcard"].HeaderText = "SimCard";
                dtgEjecutivo.Columns["simcard"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["model"].DisplayIndex = 4;
                dtgEjecutivo.Columns["model"].HeaderText = "Modelo";
                dtgEjecutivo.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["brand"].DisplayIndex = 5;
                dtgEjecutivo.Columns["brand"].HeaderText = "Marca";
                dtgEjecutivo.Columns["brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["contractnumber"].DisplayIndex = 6;
                dtgEjecutivo.Columns["contractnumber"].HeaderText = "Contrato";
                dtgEjecutivo.Columns["contractnumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["validity"].DisplayIndex = 7;
                dtgEjecutivo.Columns["validity"].HeaderText = "Vigencia";
                dtgEjecutivo.Columns["validity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["startdate"].DisplayIndex = 8;
                dtgEjecutivo.Columns["startdate"].HeaderText = "Fecha Inicio";
                dtgEjecutivo.Columns["startdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["cutoffdate"].DisplayIndex = 9;
                dtgEjecutivo.Columns["cutoffdate"].HeaderText = "Fecha Corte";
                dtgEjecutivo.Columns["cutoffdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["amount"].DisplayIndex = 10;
                dtgEjecutivo.Columns["amount"].HeaderText = "Cantidad";
                dtgEjecutivo.Columns["amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgEjecutivo.Columns["idvehicle"].DisplayIndex = 11;
                dtgEjecutivo.Columns["idvehicle"].HeaderText = "Vehículo";
                dtgEjecutivo.Columns["idvehicle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;    
                dtgEjecutivo.Columns["active"].DisplayIndex = 12;
                dtgEjecutivo.Columns["active"].HeaderText = "Status";
                dtgEjecutivo.Columns["active"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void btnEjregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEjcancelar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
        }

        private void btnEjfiltrar_Click(object sender, EventArgs e)
        {
            txtEjfiltro.Text = string.Empty;
            fillGridView();
        }

        private void txtEjfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtEjfiltro.Text != "")
            {
                dtgEjecutivo.CurrentCell = null;
                foreach (DataGridViewRow r in dtgEjecutivo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgEjecutivo.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).Contains(txtEjfiltro.Text.ToUpper()))
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

        private void btnEjnuevo_Click(object sender, EventArgs e)
        {
            txtEjnumero.Text = "";
            txtEjnumlinea.Text = "";
            txtEjimei.Text = "";
            txtEjsim.Text = "";
            txtEjmarca.Text = "";
            txtEjmodelo.Text = "";
            txtEjnumcontrato.Text = "";
            dtpEjfvigencia.Text = "";
            dtpEjfinicio.Text = "";
            dtpEjfcorte.Text = "";
            txtEjmonto.Text = "";
            gbDatosForm.Enabled = true;
            btnEjguardar.Enabled = true;
            gbDatosGrid.Enabled = false;
        }

        private void btnEjeditar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = true;
            gbDatosGrid.Enabled = false;
            btnEjguardar.Enabled = true;
        }

        private bool validar(Form formulario)
        {
            bool todoOk = true;
            foreach (Control oControls in gbDatosForm.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
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
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
            btnEjguardar.Enabled = false;
            fillGridView();
        }

        public void loadDataFromGrid(DataGridViewRow row)
        {
            executivesvc.Id             = row.Cells["_id"].Value.ToString();
            executivesvc.Number         = txtEjnumero.Text      = row.Cells["number"].Value.ToString();
            executivesvc.Brand          = txtEjmarca.Text       = row.Cells["brand"].Value.ToString();
            executivesvc.Model          = txtEjmodelo.Text      = row.Cells["model"].Value.ToString();
            executivesvc.Imei           = txtEjimei.Text        = row.Cells["imei"].Value.ToString();
            executivesvc.Linenumber     = txtEjnumlinea.Text    = row.Cells["linenumber"].Value.ToString();
            executivesvc.Simcard        = txtEjsim.Text         = row.Cells["simcard"].Value.ToString();
            executivesvc.Contractnumber = txtEjnumcontrato.Text = row.Cells["contractnumber"].Value.ToString();
            dtpEjfvigencia.Text= row.Cells["validity"].Value.ToString();
            DateTime dt1 = DateTime.ParseExact(dtpEjfvigencia.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            dtpEjfinicio.Text = row.Cells["startdate"].Value.ToString();
            executivesvc.Validity       = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
            DateTime dt2 = DateTime.ParseExact(dtpEjfinicio.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            executivesvc.Startdate      = dt2.Month + "/" + dt2.Day + "/" + dt2.Year;
            dtpEjfcorte.Text = row.Cells["cutoffdate"].Value.ToString();
            DateTime dt3 = DateTime.ParseExact(dtpEjfcorte.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            executivesvc.Startdate      = dt3.Month + "/" + dt3.Day + "/" + dt3.Year;
            executivesvc.Amount         = txtEjmonto.Text       = row.Cells["amount"].Value.ToString();
            executivesvc.Idvehicle      = row.Cells["idvehicle"].Value.ToString();
            cmbVehicle.SelectedValue    = executivesvc.Idvehicle;
            executivesvc.Active = rbActivo.Checked = (bool)row.Cells["active"].Value;
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            executivesvc.Number = txtEjnumero.Text;
            executivesvc.Brand = txtEjmarca.Text;
            executivesvc.Model = txtEjmodelo.Text;
            executivesvc.Linenumber = txtEjnumlinea.Text;
            executivesvc.Imei = txtEjimei.Text;
            executivesvc.Contractnumber = txtEjnumcontrato.Text;
            executivesvc.Amount = txtEjmonto.Text;
            executivesvc.Idvehicle = cmbVehicle.SelectedValue.ToString();
            executivesvc.Simcard = txtEjsim.Text;
            DateTime dt1 = DateTime.ParseExact(dtpEjfvigencia.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            executivesvc.Validity = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
            DateTime dt2 = DateTime.ParseExact(dtpEjfinicio.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            executivesvc.Startdate = dt2.Month + "/" + dt2.Day + "/" + dt2.Year;
            DateTime dt3 = DateTime.ParseExact(dtpEjfcorte.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            executivesvc.Cutoffdate = dt3.Month + "/" + dt3.Day + "/" + dt3.Year;
            executivesvc.Active = rbActivo.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        public void filterActive()
        {
            if (!chbExecutivesvc.Checked)
            {
                chbExecutivesvc.Text = "Mostrar solo servicios activos.";
                dtgEjecutivo.CurrentCell = null;
                foreach (DataGridViewRow r in dtgEjecutivo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgEjecutivo.Rows)
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
                chbExecutivesvc.Text = "Mostrar todos los servicios.";
                foreach (DataGridViewRow r in dtgEjecutivo.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void dtgEjecutivo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgEjecutivo.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Buscarvehiculos bVehiculos = new Buscarvehiculos(this, cmbVehicle.SelectedValue.ToString());
            bVehiculos.ShowDialog();
        }

        public void Selected(Vehiculo vehicleselected)
        {
            executivesvc.Idvehicle = vehicleselected.Id;
            cmbVehicle.SelectedValue = executivesvc.Idvehicle;
        }
    }
}
