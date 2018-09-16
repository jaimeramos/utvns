using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Principal.Entidades;
namespace Principal
{
    public partial class BuscarBussinesLine : Form
    {
        Lineanegocio lineanegocio = new Lineanegocio();
        private string _idbussinesline;
        private IFindBussinesLine _caller;

        public BuscarBussinesLine(IFindBussinesLine caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public BuscarBussinesLine(IFindBussinesLine caller, string idbussinesline):this(caller)
        {
            InitializeComponent();
            _idbussinesline = idbussinesline;
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscarpermisos_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        public void fillGridView()
        {
            string json = lineanegocio.read();
            
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
                dataGrid.Columns["name"].DisplayIndex = 1;
                dataGrid.Columns["name"].HeaderText = "Nombre";
                dataGrid.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["description"].DisplayIndex = 2;
                dataGrid.Columns["description"].HeaderText = "Descripción";
                dataGrid.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["active"].DisplayIndex = 3;
                dataGrid.Columns["active"].HeaderText = "Status";

            }
        }

         private void dtgPermisos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = e.RowIndex;
            DataGridViewRow selectedRow = dataGrid.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Lineanegocio lineanegocio = new Lineanegocio();
            lineanegocio.Id = a;
            _caller.Selected((Lineanegocio)lineanegocio);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVeditar_Click(object sender, EventArgs e)
        {

        }

        private void txtPefiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPefiltrar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
