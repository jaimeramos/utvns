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
    public partial class FrmPermisionarios : Form
    {
        Permisionario permitholder = new Permisionario();
        public FrmPermisionarios()
        {
            InitializeComponent();
        }

        private void btnPregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPermisionarios_Load(object sender, EventArgs e)
        {
            fillGridView();
            gbDatospermisionario.Enabled = false;
        }      

        private void btnPnuevo_Click(object sender, EventArgs e)
        {
            txtPnumero.Text = "";
            txtPnombre.Text = "";
            txtPapellido.Text = "";
            txtPemail.Text = "";
            txtPrfc.Text = "";
            txtPtelefono.Text = "";
            txtPcelular.Text = "";
            txtPdireccion.Text = "";
            txtPfiltro.Text = "";
            txtPlicencia.Text = "";
            permitholder = new Permisionario();
            gbDatospermisionario.Enabled = true;
            btnPguardar.Enabled = true;
            gbPermisionarios.Enabled = false;
        }

        private void btnPguardar_Click(object sender, EventArgs e)
        {
            if (validar(this)) {
                loadDataFromForm();
                permitholder.upSert();
                reloadInitialState();
            }
        }

        private void dtgPermisionario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgPermisionario.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        private void btnPeditar_Click(object sender, EventArgs e)
        {
            gbDatospermisionario.Enabled = true;
            gbPermisionarios.Enabled = false;
            btnPguardar.Enabled = true;
        }

        private void txtPfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtPfiltro.Text != "")
            {
                dtgPermisionario.CurrentCell = null;
                foreach (DataGridViewRow r in dtgPermisionario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgPermisionario.Rows)
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
            permitholder.Id         = row.Cells["_id"].Value.ToString();
            permitholder.Number     = txtPnumero.Text       = row.Cells["number"].Value.ToString();
            permitholder.Firstname  = txtPnombre.Text       = row.Cells["firstname"].Value.ToString();
            permitholder.Lastname   = txtPapellido.Text     = row.Cells["lastname"].Value.ToString();
            permitholder.Address    = txtPdireccion.Text    = row.Cells["address"].Value.ToString();
            permitholder.Rfc        = txtPrfc.Text          = row.Cells["rfc"].Value.ToString();
            permitholder.Phone1     = txtPtelefono.Text     = row.Cells["phone1"].Value.ToString();
            permitholder.Phone2     = txtPcelular.Text      = row.Cells["phone2"].Value.ToString();
            permitholder.Email      = txtPemail.Text        = row.Cells["email"].Value.ToString();
            permitholder.Type       = cmbPtipo.Text         = row.Cells["type"].Value.ToString();
            permitholder.License    = txtPlicencia.Text     = row.Cells["license"].Value.ToString();
            dtpPvigencia.Text       = row.Cells["licensevalidity"].Value.ToString();//.Substring(0,24);
            permitholder.LicenseValidity = DateTime.ParseExact(dtpPvigencia.Text, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.CurrentCulture).ToString();
            dtpPfadmision.Text = row.Cells["dateadmission"].Value.ToString();//.Substring(0,24);
            permitholder.DateAdmission = DateTime.ParseExact(dtpPfadmision.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CurrentCulture).ToString();
            permitholder.Active     = rbActivo.Checked      = (bool) row.Cells["active"].Value;
            rbInactivo.Checked      = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            permitholder.Number = txtPnumero.Text;
            permitholder.Firstname = txtPnombre.Text;
            permitholder.Lastname = txtPapellido.Text;
            permitholder.Address = txtPapellido.Text;
            permitholder.Rfc = txtPrfc.Text;
            permitholder.Phone1 = txtPtelefono.Text;
            permitholder.Phone2 = txtPcelular.Text;
            permitholder.Email = txtPemail.Text;
            permitholder.Type = cmbPtipo.Text;
            permitholder.License = txtPlicencia.Text;
            DateTime dt1 = DateTime.ParseExact(dtpPvigencia.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            permitholder.LicenseValidity = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
            DateTime dt2 = DateTime.ParseExact(dtpPfadmision.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            permitholder.DateAdmission = dt2.Month + "/" + dt2.Day + "/" + dt2.Year;
            permitholder.Active = rbActivo.Checked;

        }

        private bool validar(Form formulario)
        {
            bool todoOk = true;
            foreach (Control oControls in gbDatospermisionario.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
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
            gbDatospermisionario.Enabled = false;
            gbPermisionarios.Enabled = true;
            fillGridView();
            filterActive();
        }

        public void fillGridView()
        {
            string json = permitholder.read();
            string types = permitholder.readTypes();
            var x = JsonConvert.DeserializeObject<IEnumerable<string>>(types);
            cmbPtipo.Items.Clear();
            foreach (var type in x)
            {
                cmbPtipo.Items.Add(type);
            }
            if (!json.Equals("[]"))
            {
                dtgPermisionario.DataSource = Tools.Util.convertToDataTable(json);
                dtgPermisionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // dtgPermisionario.Enabled = false;

                this.dtgPermisionario.Columns["active"].Visible = true;
                this.dtgPermisionario.Columns["created_at"].Visible = false;
                this.dtgPermisionario.Columns["updated_at"].Visible = false;
                this.dtgPermisionario.Columns["__v"].Visible = false;
                this.dtgPermisionario.Columns["_id"].Visible = false;

                dtgPermisionario.Columns["number"].DisplayIndex = 0;
                dtgPermisionario.Columns["number"].HeaderText = "Número";
                dtgPermisionario.Columns["firstname"].DisplayIndex = 1;
                dtgPermisionario.Columns["firstname"].HeaderText = "Nombre";
                dtgPermisionario.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermisionario.Columns["lastname"].DisplayIndex = 2;
                dtgPermisionario.Columns["lastname"].HeaderText = "Apellidos";
                dtgPermisionario.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermisionario.Columns["email"].DisplayIndex = 3;
                dtgPermisionario.Columns["email"].HeaderText = "Email";
                dtgPermisionario.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermisionario.Columns["address"].DisplayIndex = 4;
                dtgPermisionario.Columns["address"].HeaderText = "Dirección";
                dtgPermisionario.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermisionario.Columns["rfc"].DisplayIndex = 5;
                dtgPermisionario.Columns["rfc"].HeaderText = "RFC";
                dtgPermisionario.Columns["phone1"].DisplayIndex = 6;
                dtgPermisionario.Columns["phone1"].HeaderText = "Teléfono 1";
                dtgPermisionario.Columns["phone2"].DisplayIndex = 7;
                dtgPermisionario.Columns["phone2"].HeaderText = "Teléfono 2";
                dtgPermisionario.Columns["license"].DisplayIndex = 8;
                dtgPermisionario.Columns["license"].HeaderText = "Licencia";
                dtgPermisionario.Columns["licensevalidity"].DisplayIndex = 9;
                dtgPermisionario.Columns["licensevalidity"].HeaderText = "Vigencia";
                dtgPermisionario.Columns["type"].DisplayIndex = 10;
                dtgPermisionario.Columns["type"].HeaderText = "Tipo";
                dtgPermisionario.Columns["dateadmission"].DisplayIndex = 11;
                dtgPermisionario.Columns["dateadmission"].HeaderText = "Fecha Ingreso";
                dtgPermisionario.Columns["active"].DisplayIndex = 12;
                dtgPermisionario.Columns["active"].HeaderText = "Status";
            }
        }

        public void filterActive()
        {
            if (!chbPermisionarios.Checked)
            {
                chbPermisionarios.Text = "Mostrar solo permisionarios activos.";
                dtgPermisionario.CurrentCell = null;
                foreach (DataGridViewRow r in dtgPermisionario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgPermisionario.Rows)
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
                chbPermisionarios.Text = "Mostrar todos los permisionarios.";
                foreach (DataGridViewRow r in dtgPermisionario.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void btnPcancelar_Click(object sender, EventArgs e)
        {
            gbDatospermisionario.Enabled = false;
            gbPermisionarios.Enabled = true;
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
    }
}
