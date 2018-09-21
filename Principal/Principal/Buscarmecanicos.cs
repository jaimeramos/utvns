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
    public partial class Buscarmecanicos : Form
    {
        Mecanico driver = new Mecanico();
        private string _idmechanic;
        private IFindMechanic _caller;

        public Buscarmecanicos(IFindMechanic caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarmecanicos(IFindMechanic caller, string idmechanic) : this(caller)
        {
            InitializeComponent();
            fillGridView();
            _idmechanic = idmechanic;
        }

        public void fillGridView()
        {
            string json = driver.read();
            
            if (!json.Equals("[]"))
            {
                dataGrid.DataSource = Tools.Util.convertToDataTable(json);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // dtgPermisionario.Enabled = false;

                this.dataGrid.Columns["active"].Visible = true;
                this.dataGrid.Columns["created_at"].Visible = false;
                this.dataGrid.Columns["updated_at"].Visible = false;
                this.dataGrid.Columns["__v"].Visible = false;
                this.dataGrid.Columns["_id"].Visible = false;

                dataGrid.Columns["number"].DisplayIndex = 0;
                dataGrid.Columns["number"].HeaderText = "Número";
                dataGrid.Columns["firstname"].DisplayIndex = 1;
                dataGrid.Columns["firstname"].HeaderText = "Nombre";
                dataGrid.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["lastname"].DisplayIndex = 2;
                dataGrid.Columns["lastname"].HeaderText = "Apellidos";
                dataGrid.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["email"].DisplayIndex = 3;
                dataGrid.Columns["email"].HeaderText = "Email";
                dataGrid.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["address"].DisplayIndex = 4;
                dataGrid.Columns["address"].HeaderText = "Dirección";
                dataGrid.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["phone1"].DisplayIndex = 5;
                dataGrid.Columns["phone1"].HeaderText = "Teléfono 1";
                dataGrid.Columns["phone2"].DisplayIndex = 6;
                dataGrid.Columns["phone2"].HeaderText = "Teléfono 2";
                dataGrid.Columns["dateadmission"].DisplayIndex = 7;
                dataGrid.Columns["dateadmission"].HeaderText = "Fecha Ingreso";
                dataGrid.Columns["active"].DisplayIndex = 8;
                dataGrid.Columns["active"].HeaderText = "Status";
            }
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgChoferes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar(e.RowIndex);
        }

        private void Buscarchoferes_Load(object sender, EventArgs e)
        {

        }
        int rowSelected = 0;
        private void btnVeditar_Click(object sender, EventArgs e)
        {
            seleccionar(rowSelected);
        }
        private void seleccionar(int i) {
            if (dataGrid.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = i;
            DataGridViewRow selectedRow = dataGrid.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Mecanico mechanic = new Mecanico();
            mechanic.Id = a;
            _caller.SelectedMechanic((Mecanico)mechanic);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }
    }
}
