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
    public partial class Buscarchoferes : Form
    {
        Permisionario driver = new Permisionario();
        private string _iddriver;
        private IFindDriver _caller;

        public Buscarchoferes(IFindDriver caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarchoferes(IFindDriver caller, string iddriver) : this(caller)
        {
            InitializeComponent();
            fillGridView();
            _iddriver = iddriver;
        }

        

        public void fillGridView()
        {
            string json = driver.read();
            
            if (!json.Equals("[]"))
            {
                dtgChoferes.DataSource = Tools.Util.convertToDataTable(json);
                dtgChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // dtgPermisionario.Enabled = false;

                this.dtgChoferes.Columns["active"].Visible = true;
                this.dtgChoferes.Columns["created_at"].Visible = false;
                this.dtgChoferes.Columns["updated_at"].Visible = false;
                this.dtgChoferes.Columns["__v"].Visible = false;
                this.dtgChoferes.Columns["_id"].Visible = false;

                dtgChoferes.Columns["number"].DisplayIndex = 0;
                dtgChoferes.Columns["number"].HeaderText = "Número";
                dtgChoferes.Columns["firstname"].DisplayIndex = 1;
                dtgChoferes.Columns["firstname"].HeaderText = "Nombre";
                dtgChoferes.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgChoferes.Columns["lastname"].DisplayIndex = 2;
                dtgChoferes.Columns["lastname"].HeaderText = "Apellidos";
                dtgChoferes.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgChoferes.Columns["email"].DisplayIndex = 3;
                dtgChoferes.Columns["email"].HeaderText = "Email";
                dtgChoferes.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgChoferes.Columns["address"].DisplayIndex = 4;
                dtgChoferes.Columns["address"].HeaderText = "Dirección";
                dtgChoferes.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgChoferes.Columns["rfc"].DisplayIndex = 5;
                dtgChoferes.Columns["rfc"].HeaderText = "RFC";
                dtgChoferes.Columns["phone1"].DisplayIndex = 6;
                dtgChoferes.Columns["phone1"].HeaderText = "Teléfono 1";
                dtgChoferes.Columns["phone2"].DisplayIndex = 7;
                dtgChoferes.Columns["phone2"].HeaderText = "Teléfono 2";
                dtgChoferes.Columns["license"].DisplayIndex = 8;
                dtgChoferes.Columns["license"].HeaderText = "Licencia";
                dtgChoferes.Columns["licensevalidity"].DisplayIndex = 9;
                dtgChoferes.Columns["licensevalidity"].HeaderText = "Vigencia";
                dtgChoferes.Columns["type"].DisplayIndex = 10;
                dtgChoferes.Columns["type"].HeaderText = "Tipo";
                dtgChoferes.Columns["dateadmission"].DisplayIndex = 11;
                dtgChoferes.Columns["dateadmission"].HeaderText = "Fecha Ingreso";
                dtgChoferes.Columns["active"].DisplayIndex = 12;
                dtgChoferes.Columns["active"].HeaderText = "Status";
            }
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgChoferes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgChoferes.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = e.RowIndex;
            DataGridViewRow selectedRow = dtgChoferes.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Permisionario chofer = new Permisionario();
            chofer.Id = a;
            _caller.SelectedDriver((Permisionario)chofer);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
