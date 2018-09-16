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
    public partial class FrmMecanicos : Form
    {
        Mecanico mechanic = new Mecanico();
        public FrmMecanicos()
        {
            InitializeComponent();
        }

        private void btnMregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMecanicos_Load(object sender, EventArgs e)
        {
            fillGridView();
            gbDatosForm.Enabled = false;
        }
        public void fillGridView()
        {
            string json = mechanic.read();

            if (!json.Equals("[]"))
            {
                dtgMecanico.DataSource = Tools.Util.convertToDataTable(json);
                dtgMecanico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dtgMecanico.Columns["active"].Visible = true;
                this.dtgMecanico.Columns["created_at"].Visible = false;
                this.dtgMecanico.Columns["updated_at"].Visible = false;
                this.dtgMecanico.Columns["__v"].Visible = false;
                this.dtgMecanico.Columns["_id"].Visible = false;

                dtgMecanico.Columns["number"].DisplayIndex = 0;
                dtgMecanico.Columns["number"].HeaderText = "Número";
                dtgMecanico.Columns["firstname"].DisplayIndex = 1;
                dtgMecanico.Columns["firstname"].HeaderText = "Nombre";
                dtgMecanico.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgMecanico.Columns["lastname"].DisplayIndex = 2;
                dtgMecanico.Columns["lastname"].HeaderText = "Apellidos";
                dtgMecanico.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgMecanico.Columns["address"].DisplayIndex = 3;
                dtgMecanico.Columns["address"].HeaderText = "Dirección";
                dtgMecanico.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgMecanico.Columns["phone1"].DisplayIndex = 4;
                dtgMecanico.Columns["phone1"].HeaderText = "Teléfono 1";
                dtgMecanico.Columns["phone2"].DisplayIndex = 5;
                dtgMecanico.Columns["phone2"].HeaderText = "Teléfono 2";
                dtgMecanico.Columns["email"].DisplayIndex = 6;
                dtgMecanico.Columns["email"].HeaderText = "Email";
                dtgMecanico.Columns["dateadmission"].DisplayIndex = 7;
                dtgMecanico.Columns["dateadmission"].HeaderText = "Fecha Ingreso";
                dtgMecanico.Columns["active"].DisplayIndex = 8;
                dtgMecanico.Columns["active"].HeaderText = "Status";
            }
        }

        private void btnMnuevo_Click(object sender, EventArgs e)
        {
            mechanic = new Mecanico();
            txtMnumero.Text = "";
            txtMnombre.Text = "";
            txtMapellido.Text = "";
            txtMemail.Text = "";
            txtMtelefono.Text = "";
            txtMcelular.Text = "";
            txtMdireccion.Text = "";
            txtMfiltro.Text = "";
            txtMemail.Text = "";
            gbDatosForm.Enabled = true;
            btnMguardar.Enabled = true;
            gbDatosGrid.Enabled = false;
        }

        private void btnMguardar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                loadDataFromForm();
                mechanic.upSert();
                reloadInitialState();
            }
        }

        private void dtgMecanico_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgMecanico.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        private void btnMeditar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = true;
            gbDatosGrid.Enabled = false;
            btnMguardar.Enabled = true;
        }

        private void txtMfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtMfiltro.Text != "")
            {
                dtgMecanico.CurrentCell = null;
                foreach (DataGridViewRow r in dtgMecanico.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgMecanico.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).Contains(txtMfiltro.Text.ToUpper()))
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
            mechanic.Id = row.Cells["_id"].Value.ToString();
            mechanic.Number = txtMnumero.Text = row.Cells["number"].Value.ToString();
            mechanic.Firstname = txtMnombre.Text = row.Cells["firstname"].Value.ToString();
            mechanic.Lastname = txtMapellido.Text = row.Cells["lastname"].Value.ToString();
            mechanic.Address = txtMdireccion.Text = row.Cells["address"].Value.ToString();
            mechanic.Phone1 = txtMtelefono.Text = row.Cells["phone1"].Value.ToString();
            mechanic.Phone2 = txtMcelular.Text = row.Cells["phone2"].Value.ToString();
            mechanic.Email = txtMemail.Text = row.Cells["email"].Value.ToString();
            dtpMfadmision.Text = row.Cells["dateadmission"].Value.ToString();//.Substring(0,24);
            mechanic.DateAdmission = DateTime.ParseExact(dtpMfadmision.Text, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.CurrentCulture).ToString();
            mechanic.Active = rbActivo.Checked = (bool)row.Cells["active"].Value;
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            mechanic.Number = txtMnumero.Text;
            mechanic.Firstname = txtMnombre.Text;
            mechanic.Lastname = txtMapellido.Text;
            mechanic.Address = txtMdireccion.Text;
            mechanic.Phone1 = txtMtelefono.Text;
            mechanic.Phone2 = txtMcelular.Text;
            mechanic.Email = txtMemail.Text;
            DateTime dt1 = DateTime.ParseExact(dtpMfadmision.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            mechanic.DateAdmission = dt1.Month + "/" + dt1.Day + "/" + dt1.Year;
            mechanic.Active = rbActivo.Checked;

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

        public void filterActive()
        {
            if (!chbMecanicos.Checked)
            {
                chbMecanicos.Text = "Mostrar solo mecánicos activos.";
                dtgMecanico.CurrentCell = null;
                foreach (DataGridViewRow r in dtgMecanico.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgMecanico.Rows)
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
                chbMecanicos.Text = "Mostrar todos los mecánicos.";
                foreach (DataGridViewRow r in dtgMecanico.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void btnMcancelar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
        }

        private void chbMecanicos_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        private void btnMfiltrar_Click(object sender, EventArgs e)
        {
            txtMfiltro.Text = string.Empty;
            fillGridView();
        }
    }
}
