using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Principal.Entidades;
using Principal.Tools;

namespace Principal
{
    public interface IFindSparepart
    {
        void Selected(Sparepart sparepart);
    }
    public interface IFindMechanic
    {
        void SelectedMechanic(Mecanico selectedmechanic);
    }
    public interface IFindWorkshopsvc
    {
        void SelectedWorkshopsvc(Workshopsvc selectedworkshopsvc);
    }
    public partial class FrmSales : Form, IFindDriver, IFindSparepart, IFindMechanic, IFindWorkshopsvc
    {
        List<Detalleventa> saledetailslist = new List<Detalleventa>();
        List<Detalleventasvc> saledetailssvclist = new List<Detalleventasvc>();
        Venta sale = new Venta();
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadComboboxSpareparts();
            loadComboboxWorkshopsvc();
            loadComboboxMechanic();
            loadSalesTypes();
        }
        public void loadSalesTypes()
        {
            string json = sale.read();
            string types = sale.readTypes();
            var x = JsonConvert.DeserializeObject<IEnumerable<string>>(types);
            cmbTipo.Items.Clear();
            foreach (var type in x)
            {
                cmbTipo.Items.Add(type);
            }
        }
        private void loadCombobox()
        {
            Permisionario permitholder = new Permisionario();
            string json = permitholder.read();
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
        private void loadComboboxMechanic() {
            Mecanico mechanic = new Mecanico();
            string json = mechanic.read();
            List<Mecanico> x = JsonConvert.DeserializeObject<List<Mecanico>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Mecanico p in x)
                {
                    datasource.Add(p.Id, p.Firstname+" "+p.Lastname);
                }
                cmbMecanico.DataSource = new BindingSource(datasource, null);
                cmbMecanico.DisplayMember = "Value";
                cmbMecanico.ValueMember = "Key";
            }
        }
        private void loadComboboxWorkshopsvc() {
            Workshopsvc workshopsvc = new Workshopsvc();
            string json = workshopsvc.read();
            List<Workshopsvc> x = JsonConvert.DeserializeObject<List<Workshopsvc>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Workshopsvc p in x)
                {
                    datasource.Add(p.Id, p.Description);
                }
                cmbServicio.DataSource = new BindingSource(datasource, null);
                cmbServicio.DisplayMember = "Value";
                cmbServicio.ValueMember = "Key";
            }
        }
        private void loadComboboxSpareparts()
        {
            Sparepart sparepart = new Sparepart();
            string json = sparepart.read();
            List<Sparepart> x = JsonConvert.DeserializeObject<List<Sparepart>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Sparepart p in x)
                {
                    datasource.Add(p.Id, p.Description);
                }
                cmbRefacciones.DataSource = new BindingSource(datasource, null);
                cmbRefacciones.DisplayMember = "Value";
                cmbRefacciones.ValueMember = "Key";
            }
        }
        private void btnBuscarpermisionario_Click(object sender, EventArgs e)
        {
            Buscarchoferes bPermisionarios = new Buscarchoferes(this, cmbPermitholder.SelectedValue.ToString());
            bPermisionarios.ShowDialog();
        }

        public void SelectedDriver(Permisionario permitholderselected)
        {
            sale.Idpermitholder = permitholderselected.Id;
            cmbPermitholder.SelectedValue = sale.Idpermitholder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscarrefacciones bRefacciones = new Buscarrefacciones(this, cmbRefacciones.SelectedValue.ToString());
            bRefacciones.ShowDialog();
        }

        Detalleventa saledetailgral;

        public void Selected(Sparepart sparepartselected)
        {
            saledetailgral = new Detalleventa();
            saledetailgral.Idsparepart  = sparepartselected.Id;
            saledetailgral.Price        = txtPrecio.Text = sparepartselected.Price;

            txtDescripcion.Text     = sparepartselected.Description;
            
            cmbRefacciones.SelectedValue = saledetailgral.Idsparepart;
        }

        private void btnAgregarRefaccion_Click(object sender, EventArgs e)
        {
            double cantidad = 0, stock=0;
            Double.TryParse(txtCantidad.Text, out cantidad);
            Double.TryParse(sparepart.Stock, out stock);
            if (txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Indique la cantidad");
                txtCantidad.Focus();
            }
            else if (stock >= cantidad)
            {
                Detalleventa saledetail = new Detalleventa();
                if (saledetailgral != null)
                    saledetail.Idsparepart = saledetailgral.Idsparepart;
                saledetail.Quantity = txtCantidad.Text;
                saledetail.Idsparepart = cmbRefacciones.SelectedValue.ToString();
                saledetail.Description = txtDescripcion.Text;
                saledetail.Price = txtPrecio.Text;
                saledetailslist.Add(saledetail);
                dataGridRefacciones.DataSource = null;

                double total = 0, precio = 0;
                Double.TryParse(txtTotal.Text, out total);
                //Double.TryParse(txtCantidad.Text, out cantidad);
                Double.TryParse(txtPrecio.Text, out precio);
                total += cantidad * precio;
                txtTotal.Text = "" + total;
                reloadInitialStateRef();

            }
            else {
                MessageBox.Show("Cantidad de artículos solicitada es mayor a la existencia en inventario.");
            }
        }
        Sparepart sparepart = new Sparepart();
        private void cmbRefacciones_SelectedIndexChanged(object sender, EventArgs e)
        {
                string json = sparepart.readById(cmbRefacciones.SelectedValue.ToString());
                sparepart = JsonConvert.DeserializeObject<Sparepart>(json.Replace("_id", "id"));
                txtDescripcion.Text = sparepart.Description;
                txtPrecio.Text = sparepart.Price;
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {
            Util.validaInteger(sender);
        }

        private void txtRecibo_TextChanged(object sender, EventArgs e)
        {
            Util.validaInteger(sender);
        }

        private void txtCredito_TextChanged(object sender, EventArgs e)
        {
            Util.validaInteger(sender);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Util.validaInteger(sender);
        }

        private void cmbRefacciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text.Equals("Contado"))
            {
                txtCredito.Enabled = false;
                btnRegCredito.Enabled = false;
            }
            else {
                txtCredito.Enabled = true;
                btnRegCredito.Enabled = true;
            }
        }

        private void btnEliminarRefaccion_Click(object sender, EventArgs e)
        {
            if (dataGridRefacciones.Rows.Count>0&& dataGridRefacciones.SelectedRows.Count>0) {
                double precio = 0, cantidad=0, total=0;
                Double.TryParse(saledetailslist[dataGridRefacciones.SelectedRows[0].Index].Price,out precio);
                Double.TryParse(saledetailslist[dataGridRefacciones.SelectedRows[0].Index].Quantity, out cantidad);
                Double.TryParse(txtTotal.Text, out total);
                txtTotal.Text = "" + (total - (precio * cantidad));
                saledetailslist.RemoveAt(dataGridRefacciones.SelectedRows[0].Index);
                reloadInitialStateRef();
                //dataGridRefacciones.Rows.RemoveAt(dataGridRefacciones.SelectedRows[0].Index);
            }
        }

        public void reloadInitialStateRef() {
            dataGridRefacciones.DataSource = null;
            dataGridRefacciones.DataSource = saledetailslist;
            txtCantidad.Text = "";
            dataGridRefacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridRefacciones.Columns["Active"].Visible = false;
            dataGridRefacciones.Columns["CreatedAt"].Visible = false;
            dataGridRefacciones.Columns["UpdatedAt"].Visible = false;
            dataGridRefacciones.Columns["Folio"].Visible = false;
            dataGridRefacciones.Columns["Idsale"].Visible = false;
            dataGridRefacciones.Columns["Id"].Visible = false;
            dataGridRefacciones.Columns["Idsparepart"].Visible = false;

            dataGridRefacciones.Columns["Description"].DisplayIndex = 0;
            dataGridRefacciones.Columns["Description"].HeaderText = "Refacción";
            dataGridRefacciones.Columns["Price"].DisplayIndex = 1;
            dataGridRefacciones.Columns["Price"].HeaderText = "Precio";
            dataGridRefacciones.Columns["Quantity"].DisplayIndex = 2;
            dataGridRefacciones.Columns["Quantity"].HeaderText = "Cantidad";
        }
        public void reloadInitialStateSvc()
        {
            dataGridSvc.DataSource = null;
            dataGridSvc.DataSource = saledetailssvclist;
            txtCantSvc.Text = "";
            dataGridSvc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridSvc.Columns["Active"].Visible = false;
            dataGridSvc.Columns["CreatedAt"].Visible = false;
            dataGridSvc.Columns["UpdatedAt"].Visible = false;
            dataGridSvc.Columns["Folio"].Visible = false;
            dataGridSvc.Columns["Idsale"].Visible = false;
            dataGridSvc.Columns["Id"].Visible = false;
            dataGridSvc.Columns["Idworkshopsvc"].Visible = false;
            dataGridSvc.Columns["Idmechanic"].Visible = false;

            dataGridSvc.Columns["Svcdescription"].DisplayIndex = 0;
            dataGridSvc.Columns["Svcdescription"].HeaderText = "Servicio";
            dataGridSvc.Columns["Mechname"].DisplayIndex = 1;
            dataGridSvc.Columns["Mechname"].HeaderText = "Mecánico";
            dataGridSvc.Columns["Price"].DisplayIndex = 2;
            dataGridSvc.Columns["Price"].HeaderText = "Precio";
            dataGridSvc.Columns["Quantity"].DisplayIndex = 3;
            dataGridSvc.Columns["Quantity"].HeaderText = "Cantidad";
        }
        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Workshopsvc workshopsvc = new Workshopsvc();
            string json = workshopsvc.readById(cmbServicio.SelectedValue.ToString());
            workshopsvc = JsonConvert.DeserializeObject<Workshopsvc>(json.Replace("_id", "id"));
            txtDescWork.Text = workshopsvc.Description;
            txtCostoWork.Text = workshopsvc.Cost;
        }

        private void cmbMecanico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mecanico mechanic = new Mecanico();
            string json = mechanic.readById(cmbMecanico.SelectedValue.ToString());
            mechanic = JsonConvert.DeserializeObject<Mecanico>(json.Replace("_id", "id"));
            txtNombreMec.Text = mechanic.Firstname+ " "+ mechanic.Lastname;
        }
        Detalleventasvc saledetailsvcgral = new Detalleventasvc();
        public void SelectedMechanic(Mecanico selectedmechanic)
        {
            //saledetailsvcgral = new Detalleventasvc();
            saledetailsvcgral.Idmechanic = selectedmechanic.Id;
            //saledetailsvcgral.Price = txtPrecio.Text = sparepartselected.Price;

            txtNombreMec.Text = selectedmechanic.Firstname+" "+ selectedmechanic.Lastname;

            cmbMecanico.SelectedValue = saledetailsvcgral.Idmechanic;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscarmecanicos bMecanicos = new Buscarmecanicos(this, cmbMecanico.SelectedValue.ToString());
            bMecanicos.ShowDialog();
        }

        public void SelectedWorkshopsvc(Workshopsvc selectedworkshopsvc)
        {
            //saledetailsvcgral = new Detalleventasvc();
            saledetailsvcgral.Idworkshopsvc = selectedworkshopsvc.Id;
            saledetailsvcgral.Price = txtCostoWork.Text = selectedworkshopsvc.Cost;

            txtDescWork.Text = selectedworkshopsvc.Description;

            cmbServicio.SelectedValue = saledetailsvcgral.Idworkshopsvc;
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            Buscarservicios bServicios = new Buscarservicios(this, cmbServicio.SelectedValue.ToString());
            bServicios.ShowDialog();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (txtCantSvc.Text.Trim() == "")
            {
                MessageBox.Show("Indique la cantidad");
                txtCantSvc.Focus();
            }
            else
            {
                Detalleventasvc saledetailsvc = new Detalleventasvc();
                if (saledetailsvcgral != null)
                {
                    saledetailsvc.Idworkshopsvc = saledetailsvcgral.Idworkshopsvc;
                    saledetailsvc.Idmechanic = saledetailsvcgral.Idmechanic;
                }
                saledetailsvc.Quantity = txtCantSvc.Text;
                saledetailsvc.Idworkshopsvc = cmbServicio.SelectedValue.ToString();
                saledetailsvc.Mechname = txtNombreMec.Text;
                saledetailsvc.Svcdescription = txtDescWork.Text;
                saledetailsvc.Price = txtCostoWork.Text;
                saledetailssvclist.Add(saledetailsvc);
                dataGridSvc.DataSource = null;

                double total = 0, cantidad = 0, precio = 0;
                Double.TryParse(txtTotal.Text, out total);
                Double.TryParse(txtCantSvc.Text, out cantidad);
                Double.TryParse(txtCostoWork.Text, out precio);
                total += cantidad * precio;
                txtTotal.Text = "" + total;
                reloadInitialStateSvc();
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (dataGridSvc.Rows.Count > 0 && dataGridSvc.SelectedRows.Count > 0)
            {
                double precio = 0, cantidad = 0, total = 0;
                Double.TryParse(saledetailssvclist[dataGridSvc.SelectedRows[0].Index].Price, out precio);
                Double.TryParse(saledetailssvclist[dataGridSvc.SelectedRows[0].Index].Quantity, out cantidad);
                Double.TryParse(txtTotal.Text, out total);
                txtTotal.Text = "" + (total - (precio * cantidad));
                saledetailssvclist.RemoveAt(dataGridSvc.SelectedRows[0].Index);
                reloadInitialStateSvc();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar(this)&& (dataGridRefacciones.Rows.Count>0|| dataGridSvc.Rows.Count > 0))
            {
                loadDataFromForm();
                string json=sale.upSert();
                sale = JsonConvert.DeserializeObject<Venta>(json.Replace("_id", "id"));
                txtFolio.Text = sale.Folio ;
                txtRecibo.Text = sale.Receiptnumber;
                btnGuardar.Enabled = false;
                btnConfirmar.Enabled = true;
            }
            else {
                MessageBox.Show("Verifique haber ingresado todos los datos.");
            }
        }
        public void loadDataFromForm()
        {
            sale.Idpermitholder = cmbPermitholder.SelectedValue.ToString();
            sale.Amount         = txtTotal.Text;
            sale.Type           = cmbTipo.Text;
            DateTime dt1 = DateTime.ParseExact(dtpFecha.Text, "dd/MM/yyyy",
                                      System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            sale.Date = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
        }
        private bool validar(Form formulario)
        {
            bool todoOk = true;
            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox && oControls.Enabled)
                {
                    if (oControls.Text == String.Empty) // Verificamos que no este vacio. 
                    {
                        MessageBox.Show("Favor de llenar los campos vacios."); // Si nuestra variable es verdadera mostramos un mensaje.
                        todoOk = false;
                        break;
                    }
                }
            }
            return todoOk;
        }
        private void actualizaStock(string idsp, double qty) {
            Sparepart sparepart = new Sparepart();
            string json = sparepart.read();
            List<Sparepart> x = JsonConvert.DeserializeObject<List<Sparepart>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                foreach (Sparepart p in x)
                {
                    if (p.Id.Equals(idsp)) {
                        double newStock = 0;
                        Double.TryParse(p.Stock, out newStock);
                        p.Stock =""+(newStock-qty);
                        p.upSert();
                        break;
                    }
                }
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                loadDataFromForm();
                string json = sale.upSert();
                foreach (Detalleventa dv in saledetailslist) {
                    dv.Idsale = sale.Id;
                    dv.upSert();
                    double qty = 0;
                    Double.TryParse(dv.Quantity, out qty);
                    actualizaStock(dv.Idsparepart, qty);
                    //actualizar el stock
                }
                foreach (Detalleventasvc dvsvc in saledetailssvclist)
                {
                    dvsvc.Idsale = sale.Id;
                    dvsvc.upSert();
                }
                if (cmbTipo.Text.Equals("Credito"))
                {
                    Credit credit = new Credit();
                    credit.Idsale = sale.Id;
                    credit.Idpermitholder = sale.Idpermitholder;
                    credit.Amount = sale.Amount;
                    credit.upSert();
                }
                reloadInitialState();
            }
            else
            {
            }
        }
        private void reloadInitialState() {
            saledetailssvclist.Clear();
            saledetailslist.Clear();
            reloadInitialStateRef();
            reloadInitialStateSvc();
            txtFolio.Text = "";
            txtRecibo.Text = "";
            txtCredito.Text = "";
            txtTotal.Text = "";
            sale = new Venta();
            txtCredito.Enabled = false;
            btnRegCredito.Enabled = false;
            btnGuardar.Enabled = true;
            btnConfirmar.Enabled = false;
        }
    }
}
