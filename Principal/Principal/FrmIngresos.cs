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
namespace Principal
{
    public interface IFindIncomeType
    {
        void SelectedIncometype(Incometype incometype);
    }
    public partial class FrmIngresos : Form, IFindVehicle, IFindBussinesLine, IFindIncomeType
    {
        List<Incomedetail> incomedetailslist = new List<Incomedetail>();
        Ingreso income = new Ingreso();
        public FrmIngresos()
        {
            InitializeComponent();
        }

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            loadComboboxVehicles();
            loadComboboxIncomeTypes();
            loadComboboxBusinessLine();
        }

        private void btnInuevo_Click(object sender, EventArgs e)
        {

        }
        private void loadComboboxIncomeTypes() {
            Incometype incometype = new Incometype();
            string json = incometype.read();
            List<Incometype> x = JsonConvert.DeserializeObject<List<Incometype>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Incometype p in x)
                {
                    datasource.Add(p.Id, p.Description);
                }
                cmbTipoIngreso.DataSource = new BindingSource(datasource, null);
                cmbTipoIngreso.DisplayMember = "Value";
                cmbTipoIngreso.ValueMember = "Key";
            }
        }
        private void loadComboboxBusinessLine() {
            Lineanegocio businessline = new Lineanegocio();
            string json = businessline.read();
            List<Lineanegocio> x = JsonConvert.DeserializeObject<List<Lineanegocio>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Lineanegocio p in x)
                {
                    datasource.Add(p.Id, p.Name);
                }
                cmbLineaNegocio.DataSource = new BindingSource(datasource, null);
                cmbLineaNegocio.DisplayMember = "Value";
                cmbLineaNegocio.ValueMember = "Key";
            }
        }
        private void loadComboboxVehicles() {
            Vehiculo vehicle = new Vehiculo();
            string json = vehicle.read();
            List<Vehiculo> x = JsonConvert.DeserializeObject<List<Vehiculo>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Vehiculo p in x)
                {
                    datasource.Add(p.Id, p.Number+" "+p.Brand+" "+p.Model+" "+p.Year);
                }
                cmbVehicles.DataSource = new BindingSource(datasource, null);
                cmbVehicles.DisplayMember = "Value";
                cmbVehicles.ValueMember = "Key";
            }
        }
        
        public void Selected(Vehiculo vehiculo)
        {
            income.Idvehicle = vehiculo.Id;
            cmbVehicles.SelectedValue = income.Idvehicle;
        }
        Incomedetail  incomedetailgral = new Incomedetail();
        public void Selected(Lineanegocio bussinesline)
        {
            incomedetailgral.Idbusinessline = bussinesline.Id;
            txtLineaNegDesc.Text = bussinesline.Name;
            cmbLineaNegocio.SelectedValue = incomedetailgral.Idbusinessline;
        }

        public void SelectedIncometype(Incometype incometype)
        {
            incomedetailgral.Idincometype = incometype.Id;
            txtDescripcion.Text = incometype.Description;
            txtMonto.Text = incometype.Amount;
            cmbTipoIngreso.SelectedValue = incomedetailgral.Idincometype;
        }

        private void btnBuscarpermisionario_Click(object sender, EventArgs e)
        {
            Buscarvehiculos bVehiculos = new Buscarvehiculos(this, cmbVehicles.SelectedValue.ToString());
            bVehiculos.ShowDialog();
        }

        private void btnLineaNegocio_Click(object sender, EventArgs e)
        {
            BuscarBussinesLine bBusinessLine = new BuscarBussinesLine(this, cmbLineaNegocio.SelectedValue.ToString());
            bBusinessLine.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTipoIngreso_Click(object sender, EventArgs e)
        {
            BuscarIncometypes bIncomeType = new BuscarIncometypes(this, cmbTipoIngreso.SelectedValue.ToString());
            bIncomeType.ShowDialog();
        }

        private void btnAgregarRefaccion_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text.Trim() == "")
            {
                MessageBox.Show("Indique la cantidad");
                txtMonto.Focus();
            }
            else
            {
                Incomedetail incomedetail = new Incomedetail();
                if (incomedetailgral != null)
                    incomedetail.Idincometype = incomedetailgral.Idincometype;
                incomedetail.Itdescription = txtDescripcion.Text;
                incomedetail.Idbusinessline = cmbLineaNegocio.SelectedValue.ToString();
                incomedetail.Blname = txtLineaNegDesc.Text;
                incomedetail.Amount = txtMonto.Text;
                DateTime dt1 = DateTime.ParseExact(dtpFechaCubierta.Text, "dd/MM/yyyy",
                                      System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                incomedetail.Datecovered = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
                incomedetailslist.Add(incomedetail);
                dataGridID.DataSource = null;
                double monto = 0, total=0;
                Double.TryParse(txtMonto.Text, out monto);
                Double.TryParse(txtTotal.Text, out total);
                txtTotal.Text = "" + (total + monto);
                reloadInitialStateRef();
            }
        }
        public void reloadInitialStateRef()
        {
            dataGridID.DataSource = null;
            dataGridID.DataSource = incomedetailslist;
            dataGridID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridID.Columns["Active"].Visible = false;
            dataGridID.Columns["CreatedAt"].Visible = false;
            dataGridID.Columns["UpdatedAt"].Visible = false;
            dataGridID.Columns["Folio"].Visible = false;
            dataGridID.Columns["Idincome"].Visible = false;
            dataGridID.Columns["Id"].Visible = false;
            dataGridID.Columns["Idincometype"].Visible = false;
            dataGridID.Columns["Idbusinessline"].Visible = false;
            dataGridID.Columns["itdescription"].DisplayIndex = 0;
            dataGridID.Columns["itdescription"].HeaderText = "Cuota/Ingreso";
            dataGridID.Columns["amount"].DisplayIndex = 1;
            dataGridID.Columns["amount"].HeaderText = "Cantidad";
            dataGridID.Columns["datecovered"].DisplayIndex = 2;
            dataGridID.Columns["datecovered"].HeaderText = "Fecha";
            dataGridID.Columns["blname"].DisplayIndex = 3;
            dataGridID.Columns["blname"].HeaderText = "Línea de Negocio";
        }

        private void cmbLineaNegocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lineanegocio businessline = new Lineanegocio();
            string json = businessline.readById(cmbLineaNegocio.SelectedValue.ToString());
            businessline = JsonConvert.DeserializeObject<Lineanegocio>(json.Replace("_id", "id"));
            txtLineaNegDesc.Text = businessline.Name;
        }

        private void cmbTipoIngreso_TextChanged(object sender, EventArgs e)
        {
            Incometype incometype = new Incometype();
            string json = incometype.readById(cmbTipoIngreso.SelectedValue.ToString());
            incometype = JsonConvert.DeserializeObject<Incometype>(json.Replace("_id", "id"));
            txtDescripcion.Text = incometype.Description;
            txtMonto.Text = incometype.Amount;
        }

        private void btnEliminarRefaccion_Click(object sender, EventArgs e)
        {
            if (dataGridID.Rows.Count > 0 && dataGridID.SelectedRows.Count > 0)
            {
                double monto = 0, total = 0;
                Double.TryParse(incomedetailslist[dataGridID.SelectedRows[0].Index].Amount, out monto);
                Double.TryParse(txtTotal.Text, out total);
                txtTotal.Text = "" + (total - monto);
                incomedetailslist.RemoveAt(dataGridID.SelectedRows[0].Index);
                reloadInitialStateRef();
            }
        }
    }
}
