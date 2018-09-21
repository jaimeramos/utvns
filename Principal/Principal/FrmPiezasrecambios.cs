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
namespace Principal
{
    public interface IFindProvider
    {
        void Selected(Proveedor provider);
    }
    public partial class FrmPiezasrecambios : Form, IFindProvider
    {

        Sparepart sparepart = new Sparepart();
        public FrmPiezasrecambios()
        {
            InitializeComponent();
        }

        private void btnPrregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPiezasrecambios_Load(object sender, EventArgs e)
        {
            fillGridView();
            loadComboboxProveedor();
            gbDatosForm.Enabled = false;
        }

        private void btnPreditar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = true;
            gbDatosGrid.Enabled = false;
            btnGuardar.Enabled = true;
        }
        public void fillGridView()
        {
            string json = sparepart.read();

            if (!json.Equals("[]"))
            {
                dataGrid.DataSource = Tools.Util.convertToDataTable(json);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dataGrid.Columns["active"].Visible = true;
                this.dataGrid.Columns["created_at"].Visible = false;
                this.dataGrid.Columns["updated_at"].Visible = false;
                this.dataGrid.Columns["__v"].Visible = false;
                this.dataGrid.Columns["_id"].Visible = false;

                dataGrid.Columns["number"].DisplayIndex = 0;
                dataGrid.Columns["number"].HeaderText = "Número";
                dataGrid.Columns["description"].DisplayIndex = 1;
                dataGrid.Columns["description"].HeaderText = "Descripción";
                dataGrid.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["cost"].DisplayIndex = 2;
                dataGrid.Columns["cost"].HeaderText = "Costo";
                dataGrid.Columns["cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["price"].DisplayIndex = 3;
                dataGrid.Columns["price"].HeaderText = "Precio";
                dataGrid.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["stock"].DisplayIndex = 4;
                dataGrid.Columns["stock"].HeaderText = "Stock";
                dataGrid.Columns["active"].DisplayIndex = 5;
                dataGrid.Columns["active"].HeaderText = "Status";
            }
        }

        private void btnPrnuevo_Click(object sender, EventArgs e)
        {
            sparepart = new Sparepart();
            txtPrnumero.Text = "";
            txtPrdescripcion.Text = "";
            txtPrcosto.Text = "";
            txtPrprecio.Text = "";
            txtPrstock.Text = "";
            txtPrfiltro.Text = "";
            gbDatosForm.Enabled = true;
            btnGuardar.Enabled = true;
            gbDatosGrid.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                loadDataFromForm();
                sparepart.upSert();
                reloadInitialState();
            }
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        private void txtPrfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtPrfiltro.Text != "")
            {
                dataGrid.CurrentCell = null;
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).Contains(txtPrfiltro.Text.ToUpper()))
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

        public void loadDataFromGrid(DataGridViewRow row)
        {
            sparepart.Id = row.Cells["_id"].Value.ToString();
            sparepart.Number = txtPrnumero.Text = row.Cells["number"].Value.ToString();
            sparepart.Description = txtPrdescripcion.Text = row.Cells["description"].Value.ToString();
            sparepart.Cost = txtPrcosto.Text = row.Cells["cost"].Value.ToString();
            sparepart.Price = txtPrprecio.Text = row.Cells["price"].Value.ToString();
            sparepart.Stock = txtPrstock.Text = row.Cells["stock"].Value.ToString();
            sparepart.Idprovider =  row.Cells["idprovider"].Value.ToString();
            cmbProveedor.SelectedValue = sparepart.Idprovider;
            sparepart.Active = rbActivo.Checked = (bool)row.Cells["active"].Value;
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            sparepart.Number = txtPrnumero.Text;
            sparepart.Description = txtPrdescripcion.Text;
            sparepart.Cost = txtPrcosto.Text;
            sparepart.Price = txtPrprecio.Text;
            sparepart.Stock = txtPrstock.Text;
            sparepart.Idprovider = cmbProveedor.SelectedValue.ToString();
            sparepart.Active = rbActivo.Checked;
        }

        private bool validar(Form formulario)
        {
            bool todoOk = true;
            foreach (Control oControls in gbDatosForm.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
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

        public void reloadInitialState()
        {
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
            fillGridView();
            filterActive();
        }

        public void filterActive()
        {
            if (!chbRecambios.Checked)
            {
                chbRecambios.Text = "Mostrar solo refacciones activas.";
                dataGrid.CurrentCell = null;
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    //foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((bool)r.Cells["active"].Value)
                        {
                            r.Visible = true;
                            //break;
                        }
                    }
                }
            }
            else
            {
                chbRecambios.Text = "Mostrar todas las refacciones.";
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void btnVtcancelar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
        }

        private void chbRecambios_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        private void btnPrfiltrar_Click(object sender, EventArgs e)
        {
            txtPrfiltro.Text = string.Empty;
            fillGridView();
        }

        private void txtPrprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Buscarproveedores bProveedores = new Buscarproveedores(this, cmbProveedor.SelectedValue.ToString());
            bProveedores.ShowDialog();
        }

        public void Selected(Proveedor providerSelected)
        {
            sparepart.Idprovider = providerSelected.Id;
            cmbProveedor.SelectedValue = sparepart.Idprovider;
        }
        private void loadComboboxProveedor()
        {
            Proveedor provider = new Proveedor();
            string json = provider.read();
            List<Proveedor> x = JsonConvert.DeserializeObject<List<Proveedor>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Proveedor p in x)
                {
                    datasource.Add(p.Id, p.Firstname+" "+p.Lastname);
                }
                cmbProveedor.DataSource = new BindingSource(datasource, null);
                cmbProveedor.DisplayMember = "Value";
                cmbProveedor.ValueMember = "Key";
            }
        }

        private void txtPrcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(((TextBox)sender).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(((TextBox)sender).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
