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
using Principal.Entidades;
using Principal.Tools;

namespace Principal
{
    public partial class FrmIncometypes : Form
    {
        Incometype incometype = new Incometype();
        public FrmIncometypes()
        {
            InitializeComponent();
        }

        private void FrmWorkshopsvcs_Load(object sender, EventArgs e)
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
            btnGuardar.Enabled = true;
        }
        public void fillGridView()
        {
            string json = incometype.read();

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
                dataGrid.Columns["amount"].DisplayIndex = 2;
                dataGrid.Columns["amount"].HeaderText = "Monto";
                dataGrid.Columns["amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["active"].DisplayIndex = 3;
                dataGrid.Columns["active"].HeaderText = "Status";
            }
        }

        private void btnPrnuevo_Click(object sender, EventArgs e)
        {
            incometype = new Incometype();
            txtPrnumero.Text = "";
            txtPrdescripcion.Text = "";
            txtPrcosto.Text = "";
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
                incometype.upSert();
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
            incometype.Id = row.Cells["_id"].Value.ToString();
            incometype.Number = txtPrnumero.Text = row.Cells["number"].Value.ToString();
            incometype.Description = txtPrdescripcion.Text = row.Cells["description"].Value.ToString();
            incometype.Amount = txtPrcosto.Text = row.Cells["amount"].Value.ToString();
            incometype.Active = rbActivo.Checked = (bool)row.Cells["active"].Value;
            rbInactivo.Checked = !rbActivo.Checked;
        }

        public void loadDataFromForm()
        {
            incometype.Number = txtPrnumero.Text;
            incometype.Description = txtPrdescripcion.Text;
            incometype.Amount = txtPrcosto.Text;
            incometype.Active = rbActivo.Checked;
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
        public void filterActive()
        {
            if (!chbRecambios.Checked)
            {
                chbRecambios.Text = "Mostrar solo tipos de ingreso activos.";
                dataGrid.CurrentCell = null;
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                        if ((bool)r.Cells["active"].Value)
                        {
                            r.Visible = true;
                            //break;
                        }
                }
            }
            else
            {
                chbRecambios.Text = "Mostrar todos los tipos de ingreso.";
                foreach (DataGridViewRow r in dataGrid.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void txtPrcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.validaDecimal(sender, e);
        }

        private void txtPrcosto_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
