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
    public partial class Buscarproveedores : Form
    {
        Proveedor provider = new Proveedor();
        private string _idprovider;
        private IFindProvider _caller;

        public Buscarproveedores(IFindProvider caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarproveedores(IFindProvider caller, string idprovider) : this(caller)
        {
            InitializeComponent();
            _idprovider = idprovider;
        }

        private void Buscarproveedores_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fillGridView()
        {
            string json = provider.read();

            if (!json.Equals("[]"))
            {
                DataTable data = Tools.Util.convertToDataTable(json);
                dataGrid.AutoGenerateColumns = true;
                dataGrid.DataSource = data;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGrid.Columns["active"].Visible = true;
                dataGrid.Columns["created_at"].Visible = false;
                dataGrid.Columns["updated_at"].Visible = false;
                dataGrid.Columns["__v"].Visible = false;
                dataGrid.Columns["_id"].Visible = false;

                dataGrid.Columns["number"].DisplayIndex = 0;
                dataGrid.Columns["number"].HeaderText = "Número";
                dataGrid.Columns["firstname"].DisplayIndex = 1;
                dataGrid.Columns["firstname"].HeaderText = "Nombre";
                dataGrid.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["lastname"].DisplayIndex = 2;
                dataGrid.Columns["lastname"].HeaderText = "Apellidos";
                dataGrid.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["address"].DisplayIndex = 3;
                dataGrid.Columns["address"].HeaderText = "Dirección";
                dataGrid.Columns["rfc"].DisplayIndex = 4;
                dataGrid.Columns["rfc"].HeaderText = "RFC";
                dataGrid.Columns["phone1"].DisplayIndex = 5;
                dataGrid.Columns["phone1"].HeaderText = "Teléfono1";
                dataGrid.Columns["phone2"].DisplayIndex = 5;
                dataGrid.Columns["phone2"].HeaderText = "Teléfono2";
                dataGrid.Columns["email"].DisplayIndex = 5;
                dataGrid.Columns["email"].HeaderText = "Email";
                dataGrid.Columns["active"].DisplayIndex = 5;
                dataGrid.Columns["active"].HeaderText = "Status";
            }
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = e.RowIndex;
            DataGridViewRow selectedRow = dataGrid.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Proveedor proveedor = new Proveedor();
            proveedor.Id = a;
            _caller.Selected((Proveedor)proveedor);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
