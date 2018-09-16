using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Principal.Entidades;
namespace Principal
{
    public partial class FrmSales : Form, IFindDriver
    {
        Venta sale = new Venta();
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadSalesTypes();
        }
        public void loadSalesTypes()
        {
            string json = sale.read();
            string types = sale.readTypes();
            var x = JsonConvert.DeserializeObject<IEnumerable<string>>(types);
            cmbTipo.Items.Clear();
            foreach (var type in x)
            {
                cmbTipo.Items.Add(type);
            }
        }
        private void loadCombobox()
        {
            Permisionario permitholder = new Permisionario();
            string json = permitholder.read();
            List<Permisionario> x = JsonConvert.DeserializeObject<List<Permisionario>>(json.Replace("_id", "id"));
            if (!json.Equals("[]"))
            {
                Dictionary<String, String> datasource = new Dictionary<string, string>();
                foreach (Permisionario p in x)
                {
                    datasource.Add(p.Id, p.Firstname + " " + p.Lastname);
                }
                cmbPermitholder.DataSource = new BindingSource(datasource, null);
                cmbPermitholder.DisplayMember = "Value";
                cmbPermitholder.ValueMember = "Key";
            }
        }

        private void btnBuscarpermisionario_Click(object sender, EventArgs e)
        {
            Buscarchoferes bPermisionarios = new Buscarchoferes(this, cmbPermitholder.SelectedValue.ToString());
            bPermisionarios.ShowDialog();
        }

        public void SelectedDriver(Permisionario permitholderselected)
        {
            sale.Idpermitholder = permitholderselected.Id;
            cmbPermitholder.SelectedValue = sale.Idpermitholder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
