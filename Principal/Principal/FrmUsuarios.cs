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
    public partial class FrmUsuarios : Form
    {
        Usuario user = new Usuario();
       

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
          //  DataTable x =;
           // x.Select("nickname = 'jramos'");
            dtgUsuario.DataSource = user.read();
            //this.dtgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            gbUsuarios.Enabled = false;
         
            this.dtgUsuario.Columns[6].Visible = false;
            this.dtgUsuario.Columns[8].Visible = false;

            //this.dtgUsuario.Columns["_id"].SortMode =
          //  DataGridViewColumnSortMode.Automatic;

            dtgUsuario.Columns["_id"].Visible = false;
            dtgUsuario.Columns["nickname"].DisplayIndex = 0;
            dtgUsuario.Columns["name"].DisplayIndex = 1;
            dtgUsuario.Columns["lastname"].DisplayIndex = 2;
            dtgUsuario.Columns["email"].DisplayIndex = 3;
            dtgUsuario.Columns["expirationdate"].DisplayIndex = 4;
            dtgUsuario.Columns["active"].DisplayIndex = 5;


        }

        private void btnFiltrarU_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario();
            user.read();
        }

        private void btnUregresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgUsuario.Rows[e.RowIndex];
                txtUsuario.Text = row.Cells[3].Value.ToString();
                txtUnombre.Text = row.Cells[4].Value.ToString();
                txtUapellidos.Text = row.Cells[5].Value.ToString();
                txtUemail.Text = row.Cells[7].Value.ToString();
                dtpUfvencimiento.Text = row.Cells[1].Value.ToString();
                chbUactivo.Checked = (bool)row.Cells[0].Value;

            }
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
                    //try
                    //{
                        r.Visible = false;
                    //}
                    //catch (Exception)
                    //{

                    //    throw;
                    //}
                }
                foreach (DataGridViewRow r in dtgUsuario.Rows)
                {
                    bool valida = false;
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtUfiltro.Text.ToUpper()) == 0)
                        {
                            valida = true;
                            r.Visible = true;
                            break;

                        }
                    }
                   // if (valida == false) r.Visible = false;
                }
            }
            else
            {

                dtgUsuario.DataSource = user.read();

            }
        }

        private void btnUactualizar_Click(object sender, EventArgs e)
        {

        }
    }
      
   }

