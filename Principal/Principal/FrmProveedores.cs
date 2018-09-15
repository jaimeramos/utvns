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
namespace Principal
{
    public partial class FrmProveedores : Form
    {
        Proveedor provider = new Proveedor();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            fillGridView();
            gbDatosForm.Enabled = false;
        }

        private void btnPrregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreditar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = true;
            gbDatosGrid.Enabled = false;
            btnPrguardar.Enabled = true;
        }

        public void fillGridView()
        {
            string json = provider.read();

            if (!json.Equals("[]"))
            {
                dtgProveedor.DataSource = Tools.Util.convertToDataTable(json);
                dtgProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dtgProveedor.Columns["active"].Visible = true;
                this.dtgProveedor.Columns["created_at"].Visible = false;
                this.dtgProveedor.Columns["updated_at"].Visible = false;
                this.dtgProveedor.Columns["__v"].Visible = false;
                this.dtgProveedor.Columns["_id"].Visible = false;

                dtgProveedor.Columns["number"].DisplayIndex = 0;
                dtgProveedor.Columns["number"].HeaderText = "Número";
                dtgProveedor.Columns["firstname"].DisplayIndex = 1;
                dtgProveedor.Columns["firstname"].HeaderText = "Nombre";
                dtgProveedor.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgProveedor.Columns["lastname"].DisplayIndex = 2;
                dtgProveedor.Columns["lastname"].HeaderText = "Apellidos";
                dtgProveedor.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgProveedor.Columns["address"].DisplayIndex = 3;
                dtgProveedor.Columns["address"].HeaderText = "Dirección";
                dtgProveedor.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgProveedor.Columns["phone1"].DisplayIndex = 4;
                dtgProveedor.Columns["phone1"].HeaderText = "Teléfono 1";
                dtgProveedor.Columns["phone2"].DisplayIndex = 5;
                dtgProveedor.Columns["phone2"].HeaderText = "Teléfono 2";
                dtgProveedor.Columns["email"].DisplayIndex = 6;
                dtgProveedor.Columns["email"].HeaderText = "Email";
                dtgProveedor.Columns["rfc"].DisplayIndex = 7;
                dtgProveedor.Columns["rfc"].HeaderText = "RFC";
                dtgProveedor.Columns["active"].DisplayIndex = 8;
                dtgProveedor.Columns["active"].HeaderText = "Status";
            }
        }

        private void btnPrnuevo_Click(object sender, EventArgs e)
        {
            provider = new Proveedor();
            txtPrnumero.Text = "";
            txtPrnombre.Text = "";
            txtPrapellido.Text = "";
            txtPremail.Text = "";
            txtPrtelefono.Text = "";
            txtPrcelular.Text = "";
            txtPrdireccion.Text = "";
            txtPrfiltro.Text = "";
            txtPremail.Text = "";
            txtPrrfc.Text = "";
            gbDatosForm.Enabled = true;
            btnPrguardar.Enabled = true;
            gbDatosGrid.Enabled = false;
        }

        private void btnPrguardar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                loadDataFromForm();
                provider.upSert();
                reloadInitialState();
            }
        }

        private void dtgProveedor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgProveedor.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }

        private void txtPrfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtPrfiltro.Text != "")
            {
                dtgProveedor.CurrentCell = null;
                foreach (DataGridViewRow r in dtgProveedor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgProveedor.Rows)
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
            provider.Id = row.Cells["_id"].Value.ToString();
            provider.Number = txtPrnumero.Text = row.Cells["number"].Value.ToString();
            provider.Firstname = txtPrnombre.Text = row.Cells["firstname"].Value.ToString();
            provider.Lastname = txtPrapellido.Text = row.Cells["lastname"].Value.ToString();
            provider.Rfc = txtPrrfc.Text = row.Cells["rfc"].Value.ToString();
            provider.Address = txtPrdireccion.Text = row.Cells["address"].Value.ToString();
            provider.Phone1 = txtPrtelefono.Text = row.Cells["phone1"].Value.ToString();
            provider.Phone2 = txtPrcelular.Text = row.Cells["phone2"].Value.ToString();
            provider.Email = txtPremail.Text = row.Cells["email"].Value.ToString();
            provider.Active = rbActivo.Checked = (bool)row.Cells["active"].Value;
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            provider.Number = txtPrnumero.Text;
            provider.Firstname = txtPrnombre.Text;
            provider.Lastname = txtPrapellido.Text;
            provider.Rfc = txtPrrfc.Text;
            provider.Address = txtPrdireccion.Text;
            provider.Phone1 = txtPrtelefono.Text;
            provider.Phone2 = txtPrcelular.Text;
            provider.Email = txtPremail.Text;
            provider.Active = rbActivo.Checked;

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
            if (!chbProveedores.Checked)
            {
                chbProveedores.Text = "Mostrar solo mecánicos activos.";
                dtgProveedor.CurrentCell = null;
                foreach (DataGridViewRow r in dtgProveedor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgProveedor.Rows)
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
                chbProveedores.Text = "Mostrar todos los mecánicos.";
                foreach (DataGridViewRow r in dtgProveedor.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void btnPrcancelar_Click(object sender, EventArgs e)
        {
            gbDatosForm.Enabled = false;
            gbDatosGrid.Enabled = true;
        }

        private void chbProveedores_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        private void btnPrfiltrar_Click(object sender, EventArgs e)
        {
            txtPrfiltro.Text = string.Empty;
            fillGridView();
        }
    }
}
