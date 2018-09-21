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
    public partial class Buscarrefacciones : Form
    {
        Sparepart sparepart = new Sparepart();
        private string _idsparepart;
        private IFindSparepart _caller;

        public Buscarrefacciones(IFindSparepart caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarrefacciones(IFindSparepart caller, string idsparepart):this(caller)
        {
            InitializeComponent();
            _idsparepart = idsparepart;
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
            string json = sparepart.read();
            
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
                dataGrid.Columns["description"].DisplayIndex = 1;
                dataGrid.Columns["description"].HeaderText = "Descripción";
                dataGrid.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["cost"].DisplayIndex = 2;
                dataGrid.Columns["cost"].HeaderText = "Vigencia";
                dataGrid.Columns["price"].DisplayIndex = 3;
                dataGrid.Columns["price"].HeaderText = "Vigencia";
                dataGrid.Columns["cost"].DisplayIndex = 4;
                dataGrid.Columns["cost"].HeaderText = "Vigencia";
                dataGrid.Columns["stock"].DisplayIndex = 5;
                dataGrid.Columns["stock"].HeaderText = "Vigencia";
                dataGrid.Columns["active"].DisplayIndex = 6;
                dataGrid.Columns["active"].HeaderText = "Status";

            }
        }

         private void dtgPermisos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void dataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar(e.RowIndex);
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }
        private void seleccionar(int i) {
            if (dataGrid.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = i;
            DataGridViewRow selectedRow = dataGrid.Rows[selectedrowindex];
            Sparepart sparepart = new Sparepart();
            sparepart.Id = Convert.ToString(selectedRow.Cells["_id"].Value); ;
            sparepart.Description = Convert.ToString(selectedRow.Cells["description"].Value);
            sparepart.Price = Convert.ToString(selectedRow.Cells["price"].Value);
            _caller.Selected((Sparepart)sparepart);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
