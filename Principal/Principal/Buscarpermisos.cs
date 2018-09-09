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
                dtgPermisos.AutoGenerateColumns = true;
                dtgPermisos.DataSource = data;
                dtgPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgPermisos.Columns["active"].Visible = true;
                dtgPermisos.Columns["idadmin"].Visible = false;
                dtgPermisos.Columns["created_at"].Visible = false;
                dtgPermisos.Columns["updated_at"].Visible = false;
                dtgPermisos.Columns["__v"].Visible = false;
                dtgPermisos.Columns["_id"].Visible = false;

                dtgPermisos.Columns["number"].DisplayIndex = 0;
                dtgPermisos.Columns["number"].HeaderText = "Número";
                dtgPermisos.Columns["type"].DisplayIndex = 1;
                dtgPermisos.Columns["type"].HeaderText = "Tipo";
                dtgPermisos.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermisos.Columns["description"].DisplayIndex = 2;
                dtgPermisos.Columns["description"].HeaderText = "Descripción";
                dtgPermisos.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgPermisos.Columns["validity_at"].DisplayIndex = 3;
                dtgPermisos.Columns["validity_at"].HeaderText = "Vigencia";
                dtgPermisos.Columns["active"].DisplayIndex = 4;
                dtgPermisos.Columns["active"].HeaderText = "Status";

            }
        }

         private void dtgPermisos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPermisos.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = e.RowIndex;
            DataGridViewRow selectedRow = dtgPermisos.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Permiso permiso = new Permiso();
            permiso.Id = a;
            _caller.Selected((Permiso)permiso);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVeditar_Click(object sender, EventArgs e)
        {

        }
    }
}
