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
    public partial class FrmPermisos : Form
    {

        Permiso permit = new Permiso();
        public FrmPermisos()
        {
            InitializeComponent();
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            loadCombobox();
            fillGridView();
            gbdatospermisos.Enabled = false;
        }

        private void btnPenuevo_Click(object sender, EventArgs e)
        {
            txtPenumero.Text = "";
            cmbPetipo.Text = "";
            txtPedescripcion.Text = "";
            txtPenpermisionario.Text = "";
            dtpPevencimiento.Text = "";
            gbPermisos.Enabled = false;
            gbdatospermisos.Enabled = true;
            txtPenpermisionario.Text = cmbPermitholder.SelectedValue.ToString();
            permit = new Permiso();
        }

        private void btnPeguardar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                loadDataFromForm();
                permit.upSert();
                reloadInitialState();
            }
            
        }

        private void dtgPermiso_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgPermiso.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        private void btnPeeditar_Click(object sender, EventArgs e)
        {
            gbdatospermisos.Enabled = true;
            gbPermisos.Enabled = false;
            btnPeguardar.Enabled = true;
        }

        private void txtPefiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtPefiltro.Text != "")
            {
                dtgPermiso.CurrentCell = null;
                foreach (DataGridViewRow r in dtgPermiso.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgPermiso.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).Contains(txtPefiltro.Text.ToUpper()))
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
            permit.Id               = row.Cells["_id"].Value.ToString();
            permit.Number           = txtPenumero.Text = row.Cells["number"].Value.ToString();
            permit.Type             = cmbPetipo.Text = row.Cells["type"].Value.ToString();
            permit.Description      = txtPedescripcion.Text = row.Cells["description"].Value.ToString();
            // load the assigned permitholder´s name 
            string dataP = new Permisionario().readById(row.Cells["idadmin"].Value.ToString());
            Permisionario permitholder = JsonConvert.DeserializeObject<Permisionario>(dataP);
            permit.Idadmin = txtPenpermisionario.Text = row.Cells["idadmin"].Value.ToString();

            cmbPermitholder.Text = permitholder.Firstname + " " + permitholder.Lastname;
            
            dtpPevencimiento.Text   = row.Cells["validity_at"].Value.ToString();//.Substring(0,24);
            permit.ValidityAt = DateTime.ParseExact(dtpPevencimiento.Text, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.CurrentCulture).ToString();
            permit.Active           = rbActivo.Checked = (bool) row.Cells["active"].Value;
            
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            permit.Number       = txtPenumero.Text;
            permit.Type         = cmbPetipo.Text;
            permit.Description  = txtPedescripcion.Text;
            
            permit.Idadmin      = txtPenpermisionario.Text;
            DateTime dt1 = DateTime.ParseExact(dtpPevencimiento.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            permit.ValidityAt   = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
            permit.Active       = rbActivo.Checked;

        }

        private bool validar(Form formulario)
        {
            bool todoOk = true;
            foreach (Control oControls in gbdatospermisos.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
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
            gbdatospermisos.Enabled = false;
            gbPermisos.Enabled = true;
            fillGridView();
            filterActive();
            loadCombobox();
        }

        public void fillGridView()
        {
            string json = permit.read();
            string types = permit.readTypes();
            var x = JsonConvert.DeserializeObject<IEnumerable<string>>(types);
            cmbPetipo.Items.Clear();
            foreach (var type in x)
            {
                cmbPetipo.Items.Add(type);
            }
            if (!json.Equals("[]"))
            {
                dtgPermiso.DataSource = Tools.Util.convertToDataTable(json);
                dtgPermiso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgPermiso.Columns["active"].Visible = true;
                dtgPermiso.Columns["idadmin"].Visible = false;
                dtgPermiso.Columns["created_at"].Visible = false;
                dtgPermiso.Columns["updated_at"].Visible = false;
                dtgPermiso.Columns["__v"].Visible = false;
                dtgPermiso.Columns["_id"].Visible = false;

                dtgPermiso.Columns["number"].DisplayIndex = 0;
                dtgPermiso.Columns["number"].HeaderText = "Número";
                dtgPermiso.Columns["type"].DisplayIndex = 1;
                dtgPermiso.Columns["type"].HeaderText = "Tipo";
                dtgPermiso.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermiso.Columns["description"].DisplayIndex = 2;
                dtgPermiso.Columns["description"].HeaderText = "Descripción";
                dtgPermiso.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermiso.Columns["validity_at"].DisplayIndex = 3;
                dtgPermiso.Columns["validity_at"].HeaderText = "Vigencia";
                dtgPermiso.Columns["active"].DisplayIndex = 4;
                dtgPermiso.Columns["active"].HeaderText = "Status";

            }
        }

        public void filterActive()
        {
            if (!checkBox1.Checked)
            {
                checkBox1.Text = "Mostrar solo permisos activos.";
                dtgPermiso.CurrentCell = null;
                foreach (DataGridViewRow r in dtgPermiso.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgPermiso.Rows)
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
                checkBox1.Text = "Mostrar todos los permisos.";
                foreach (DataGridViewRow r in dtgPermiso.Rows)
                {
                    r.Visible = true;
                }
            }
        }
       
        private void loadCombobox() {
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

        private void btnPecancelar_Click(object sender, EventArgs e)
        {
            gbdatospermisos.Enabled = false;
            gbPermisos.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        private void cmbPermitholder_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPenpermisionario.Text = cmbPermitholder.SelectedValue.ToString();
        }

        private void btnPefiltrar_Click(object sender, EventArgs e)
        {
            txtPefiltro.Text = string.Empty;
            fillGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
