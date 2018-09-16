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
    public interface IFindBussinesLine
    {
        void Selected(Lineanegocio bussinesline);
    }
    public partial class FrmOutcomes : Form, IFindBussinesLine
    {
        Egreso outcome = new Egreso();
        public FrmOutcomes()
        {
            InitializeComponent();
        }

        private void btnPregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

           

        private void btnPnuevo_Click(object sender, EventArgs e)
        {
            txtFolio.Text = "";
            txtDescripcion.Text = "";
            txtReferencia.Text = "";
            cmbTipo.Text = "";
            txtMonto.Text = "";
            cmbBussinesline.Text = "";
            txtPfiltro.Text = "";
            dtpFecha.Text = "";
            outcome = new Egreso();
            gbDatosForm.Enabled = true;
            btnPguardar.Enabled = true;
            gbDatosGrid.Enabled = false;
        }

        private void btnPguardar_Click(object sender, EventArgs e)
        {
            if (validar(this)) {
                loadDataFromForm();
                outcome.upSert();
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

        private void btnPeditar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = true;
            gbDatosGrid.Enabled = false;
            btnPguardar.Enabled = true;
        }

        private void txtPfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtPfiltro.Text != "")
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
                        if ((c.Value.ToString().ToUpper()).Contains(txtPfiltro.Text.ToUpper()))
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
            outcome.Id              = row.Cells["_id"].Value.ToString();
            outcome.Folio           = txtFolio.Text         = row.Cells["folio"].Value.ToString();
            outcome.Description     = txtDescripcion.Text   = row.Cells["description"].Value.ToString();
            outcome.Reference       = txtReferencia.Text    = row.Cells["reference"].Value.ToString();
            outcome.Type            = cmbTipo.Text          = row.Cells["type"].Value.ToString();
            outcome.Amount          = txtMonto.Text         = row.Cells["amount"].Value.ToString();
            outcome.Idbusinessline  = row.Cells["idbusinessline"].Value.ToString();
            cmbBussinesline.SelectedValue = outcome.Idbusinessline;
            dtpFecha.Text = row.Cells["date"].Value.ToString();//.Substring(0,24);
            outcome.Date = DateTime.ParseExact(dtpFecha.Text, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.CurrentCulture).ToString();
            outcome.Active          = rbActivo.Checked      = (bool) row.Cells["active"].Value;
            rbInactivo.Checked      = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            outcome.Folio           = txtFolio.Text;
            outcome.Description     = txtDescripcion.Text;
            outcome.Reference       = txtReferencia.Text;
            outcome.Type            = cmbTipo.Text;
            outcome.Amount          = txtMonto.Text;
            outcome.Idbusinessline  = cmbBussinesline.SelectedValue.ToString();
            DateTime dt1 = DateTime.ParseExact(dtpFecha.Text, "dd/MM/yyyy",
                                      System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            outcome.Date = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
            outcome.Active          = rbActivo.Checked;
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

        public void fillGridView()
        {
            string json = outcome.read();
            string types = outcome.readTypes();
            var x = JsonConvert.DeserializeObject<IEnumerable<string>>(types);
            cmbTipo.Items.Clear();
            foreach (var type in x)
            {
                cmbTipo.Items.Add(type);
            }
            if (!json.Equals("[]"))
            {
                dataGrid.DataSource = Tools.Util.convertToDataTable(json);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // dataGrid.Enabled = false;

                this.dataGrid.Columns["active"].Visible = true;
                this.dataGrid.Columns["created_at"].Visible = false;
                this.dataGrid.Columns["updated_at"].Visible = false;
                this.dataGrid.Columns["__v"].Visible = false;
                this.dataGrid.Columns["_id"].Visible = false;

                dataGrid.Columns["folio"].DisplayIndex = 0;
                dataGrid.Columns["folio"].HeaderText = "Folio";
                dataGrid.Columns["description"].DisplayIndex = 1;
                dataGrid.Columns["description"].HeaderText = "Descripción";
                dataGrid.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["reference"].DisplayIndex = 2;
                dataGrid.Columns["reference"].HeaderText = "Referencia";
                dataGrid.Columns["reference"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["type"].DisplayIndex = 3;
                dataGrid.Columns["type"].HeaderText = "Tipo";
                dataGrid.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["amount"].DisplayIndex = 4;
                dataGrid.Columns["amount"].HeaderText = "Monto";
                dataGrid.Columns["amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["date"].DisplayIndex = 5;
                dataGrid.Columns["date"].HeaderText = "Fecha";
                dataGrid.Columns["active"].DisplayIndex = 6;
                dataGrid.Columns["active"].HeaderText = "Status";
            }
        }

        public void filterActive()
        {
            if (!chbPermisionarios.Checked)
            {
                chbPermisionarios.Text = "Mostrar solo egresos activos.";
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
                chbPermisionarios.Text = "Mostrar todos los egresos.";
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void btnPcancelar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
        }

        private void chbPermisionarios_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        private void btnPfiltrar_Click(object sender, EventArgs e)
        {
            txtPfiltro.Text = string.Empty;
            fillGridView();
        }

        private void FrmPermisionarios_Load_1(object sender, EventArgs e)
        {
            
        }

        private void FrmOutcomes_Load(object sender, EventArgs e)
        {
            loadComboboxBussinesLines();
            fillGridView();
            gbDatosForm.Enabled = false;
        }

        private void loadComboboxBussinesLines()
        {
            Lineanegocio bussinesline = new Lineanegocio();
            string json = bussinesline.read();
            List<Lineanegocio> x = JsonConvert.DeserializeObject<List<Lineanegocio>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Lineanegocio p in x)
                {
                    datasource.Add(p.Id, p.Name);
                }
                cmbBussinesline.DataSource = new BindingSource(datasource, null);
                cmbBussinesline.DisplayMember = "Value";
                cmbBussinesline.ValueMember = "Key";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarBussinesLine bBussinesLine = new BuscarBussinesLine(this, cmbBussinesline.SelectedValue.ToString());
            bBussinesLine.ShowDialog();
        }

        public void Selected(Lineanegocio bussinesline)
        {
            outcome.Idbusinessline = bussinesline.Id;
            cmbBussinesline.SelectedValue = outcome.Idbusinessline;
        }

        private void dataGrid_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }
    }
}
