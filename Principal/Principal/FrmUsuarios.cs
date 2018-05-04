using System;
using System.Windows.Forms;
using Principal.Entidades;
using System.Data;
using System.Collections.Generic;
using Principal.Tools;
using System.Collections;
using Newtonsoft.Json;

namespace Principal
{
    public partial class FrmUsuarios : Form
    {
        Usuario user = new Usuario();
        ArrayList  users = new ArrayList();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            fillGridView();
        }
        public void fillGridView() {
            string json = user.read();
            dtgUsuario.DataSource = Util.convertToDataTable(json);

            dtgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            gbUsuarios.Enabled = false;
         
            this.dtgUsuario.Columns["pwd"].Visible = false;
            this.dtgUsuario.Columns["created_at"].Visible = false;
            this.dtgUsuario.Columns["updated_at"].Visible = false;
            this.dtgUsuario.Columns["__v"].Visible = false;
            this.dtgUsuario.Columns["_id"].Visible = false;

            dtgUsuario.Columns["nickname"].DisplayIndex = 0;
            dtgUsuario.Columns["nickname"].HeaderText = "Usuario";
            dtgUsuario.Columns["name"].DisplayIndex = 1;
            dtgUsuario.Columns["name"].HeaderText = "Nombre";
            dtgUsuario.Columns["lastname"].DisplayIndex = 2;
            dtgUsuario.Columns["lastname"].HeaderText = "Apellidos";
            dtgUsuario.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgUsuario.Columns["email"].DisplayIndex = 3;
            dtgUsuario.Columns["email"].HeaderText = "Email";
            dtgUsuario.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgUsuario.Columns["expirationdate"].DisplayIndex = 4;
            dtgUsuario.Columns["expirationdate"].HeaderText = "Vigencia";
            dtgUsuario.Columns["active"].DisplayIndex = 5;
            dtgUsuario.Columns["active"].HeaderText = "Activo";
            dtgUsuario.Columns["admin"].DisplayIndex = 6;
            dtgUsuario.Columns["admin"].HeaderText = "Administrador";

        }
        private void btnFiltrarU_Click(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void btnUregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNusuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUnombre.Text = "";
            txtUapellidos.Text = "";
            txtUemail.Text = "";
            txtUcontraseña.Text = "";
            txtUccontraseña.Text = "";
            dtpUfvencimiento.Text = "";
            chbUactivo.Text = "";

            gbUsuarios.Enabled = true;
            btnUactualizar.Enabled = false;
            btnUguardar.Enabled = true;
            gbUsuarios1.Enabled = false;
        }

        private void btnUeditar_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = true;
            gbUsuarios1.Enabled = false;
            btnUguardar.Enabled = false;
            btnUactualizar.Enabled = true;
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dtgUsuario.Rows[e.RowIndex];
            //    loadDataFromGrid(row);
            //}
        }
        public void loadDataFromGrid(DataGridViewRow row) {
            user.Nickname = txtUsuario.Text = row.Cells[3].Value.ToString();
            user.Name = txtUnombre.Text = row.Cells[4].Value.ToString();
            user.Lastname= txtUapellidos.Text = row.Cells[5].Value.ToString();
            user.Email= txtUemail.Text = row.Cells[7].Value.ToString();
            dtpUfvencimiento.Text = row.Cells[1].Value.ToString();//.Substring(0,24);
            user.ExpirationDate= DateTime.ParseExact(dtpUfvencimiento.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            user.Id= row.Cells[2].Value.ToString();
            user.Active=chbUactivo.Checked = (bool)row.Cells[0].Value;
            user.Admin= chbUadmin.Checked=(bool)row.Cells[11].Value;
        }
        public void loadDataFromForm() {
            user.Nickname = txtUsuario.Text ;
            user.Name = txtUnombre.Text ;
            user.Lastname = txtUapellidos.Text ;
            user.Email = txtUemail.Text ;
            user.ExpirationDate = DateTime.ParseExact(dtpUfvencimiento.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            user.Active = chbUactivo.Checked ;
            user.Admin = chbUadmin.Checked ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gbUsuarios1.Enabled = true;
            gbUsuarios.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUfiltro.Text !="")
            {
                dtgUsuario.CurrentCell = null;
                foreach (DataGridViewRow r in dtgUsuario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgUsuario.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtUfiltro.Text.ToUpper()) == 0)
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

        private void btnUactualizar_Click(object sender, EventArgs e)
        {
            loadDataFromForm();
            user.upSert();
            gbUsuarios.Enabled = false;
            gbUsuarios1.Enabled = true;
            btnUguardar.Enabled = true;
            btnUactualizar.Enabled = false;
            fillGridView();
        }

        private void btnUguardar_Click(object sender, EventArgs e)
        {
            //user.upSert();
            gbUsuarios.Enabled = false;
        }

        private void dtgUsuario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgUsuario.Rows[e.RowIndex];
                loadDataFromGrid(row);
            }
        }
    }
      
   }

