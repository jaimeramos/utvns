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
    public partial class Buscarvehiculos : Form
    {
        //public Buscarvehiculos()
        //{
        //    InitializeComponent();
        //}
        Vehiculo vehicle = new Vehiculo();
        private string _idvehicle;
        private IFindVehicle _caller;

        public Buscarvehiculos(IFindVehicle caller)
        {
            
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarvehiculos(IFindVehicle caller, string idvehicle) : this(caller)
        {
            InitializeComponent();
            _idvehicle = idvehicle;
        }

        private void Buscarvehiculos_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        public void fillGridView()
        {
            string json = vehicle.read();

            if (!json.Equals("[]"))
            {
                DataTable data = Tools.Util.convertToDataTable(json);
                dtgVehiculo.AutoGenerateColumns = true;
                dtgVehiculo.DataSource = data;
                dtgVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgVehiculo.Columns["active"].Visible = true;
                dtgVehiculo.Columns["created_at"].Visible = false;
                dtgVehiculo.Columns["updated_at"].Visible = false;
                dtgVehiculo.Columns["__v"].Visible = false;
                dtgVehiculo.Columns["_id"].Visible = false;

                dtgVehiculo.Columns["number"].DisplayIndex = 0;
                dtgVehiculo.Columns["number"].HeaderText = "Número";
                dtgVehiculo.Columns["brand"].DisplayIndex = 1;
                dtgVehiculo.Columns["brand"].HeaderText = "Marca";
                dtgVehiculo.Columns["brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["model"].DisplayIndex = 2;
                dtgVehiculo.Columns["model"].HeaderText = "Modelo";
                dtgVehiculo.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["description"].DisplayIndex = 3;
                dtgVehiculo.Columns["description"].HeaderText = "Descripción";
                dtgVehiculo.Columns["year"].DisplayIndex = 2;
                dtgVehiculo.Columns["year"].HeaderText = "Año";
                dtgVehiculo.Columns["year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["color"].DisplayIndex = 2;
                dtgVehiculo.Columns["color"].HeaderText = "Color";
                dtgVehiculo.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["serie"].DisplayIndex = 2;
                dtgVehiculo.Columns["serie"].HeaderText = "Serie";
                dtgVehiculo.Columns["serie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["motorserie"].DisplayIndex = 2;
                dtgVehiculo.Columns["motorserie"].HeaderText = "Serie motor";
                dtgVehiculo.Columns["motorserie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["plate"].DisplayIndex = 2;
                dtgVehiculo.Columns["plate"].HeaderText = "Placa";
                dtgVehiculo.Columns["plate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtgVehiculo.Columns["active"].DisplayIndex = 4;
                dtgVehiculo.Columns["active"].HeaderText = "Status";

            }
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgVehiculos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dtgVehiculo.CurrentRow==null)
            {
                return;
            }
            int selectedrowindex = e.RowIndex;
            DataGridViewRow selectedRow = dtgVehiculo.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["_id"].Value);
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Id = a;
            _caller.Selected((Vehiculo)vehiculo);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
