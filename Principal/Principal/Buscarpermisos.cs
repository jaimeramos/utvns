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
    public partial class Buscarpermisos : Form
    {
        Permiso permit = new Permiso();
        private string _idpermit;
        private IFindPermit _caller;

        public Buscarpermisos(IFindPermit caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarpermisos(IFindPermit caller, string idpermit):this(caller)
        {
            InitializeComponent();
            _idpermit = idpermit;
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
            string json = permit.read();
            
            if (!json.Equals("[]"))
            {
                DataTable data = Tools.Util.convertToDataTable(json);
                dataGrid.AutoGenerateColumns = true;
                dataGrid.DataSource = data;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGrid.Columns["active"].Visible = true;
                dataGrid.Columns["idadmin"].Visible = false;
                dataGrid.Columns["created_at"].Visible = false;
                dataGrid.Columns["updated_at"].Visible = false;
                dataGrid.Columns["__v"].Visible = false;
                dataGrid.Columns["_id"].Visible = false;

                dataGrid.Columns["number"].DisplayIndex = 0;
                dataGrid.Columns["number"].HeaderText = "Número";
                dataGrid.Columns["type"].DisplayIndex = 1;
                dataGrid.Columns["type"].HeaderText = "Tipo";
                dataGrid.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["description"].DisplayIndex = 2;
                dataGrid.Columns["description"].HeaderText = "Descripción";
                dataGrid.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["validity_at"].DisplayIndex = 3;
                dataGrid.Columns["validity_at"].HeaderText = "Vigencia";
                dataGrid.Columns["active"].DisplayIndex = 4;
                dataGrid.Columns["active"].HeaderText = "Status";

            }
        }

         private void dtgPermisos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar(e.RowIndex);
        }
        int rowSelected = 0;
        private void btnVeditar_Click(object sender, EventArgs e)
        {
            seleccionar(rowSelected);
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
        private void seleccionar(int i) {
            if (dataGrid.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = i;
            DataGridViewRow selectedRow = dataGrid.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Permiso permiso = new Permiso();
            permiso.Id = a;
            _caller.Selected((Permiso)permiso);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }
    }
}
