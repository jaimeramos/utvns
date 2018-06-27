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

        public FrmUsuarios()
        {
            InitializeComponent();
        }

       // Variable utilizada para saber si hay algún TextBox vacio. 
        private void validar(Form formulario)
        { 
            bool vacio=true; 
            foreach (Control oControls in gbUsuarios.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox)
                {
                    if (oControls.Text == String.Empty) // Verificamos que no este vacio. 
                    {
                       
                       // vacio = true;
                        // if (vacio == true)
                        MessageBox.Show("Favor de llenar los campos vacios."); // Si nuestra variable es verdadera mostramos un mensaje.
                           break;                                                     // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                    }
                    else
                    {

                        //vacio = false; // Devolvemos el valor original a nuestra variable. 


                        loadDataFromForm();
                        string pwd1 = txtUccontraseña.Text.Trim(), pwd2 = txtUcontraseña.Text.Trim();
                        if (pwd1.Equals(string.Empty) && pwd2.Equals(string.Empty))
                        {
                            user.upSert(false);
                            reloadInitialState();
                        }
                        else
                        {
                            if (pwd1.Length >= 8 && pwd2.Length >= 8 && pwd1.Equals(pwd2))
                            {
                                user.Pwd = txtUcontraseña.Text;
                                user.upSert(true);
                                reloadInitialState();
                            }
                            else
                            {
                                MessageBox.Show("Verifique que la contraseña coincida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                }
            }
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
            dtgUsuario.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgUsuario.Columns["lastname"].DisplayIndex = 2;
            dtgUsuario.Columns["lastname"].HeaderText = "Apellidos";
            dtgUsuario.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgUsuario.Columns["email"].DisplayIndex = 3;
            dtgUsuario.Columns["email"].HeaderText = "Email";
            dtgUsuario.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgUsuario.Columns["expirationdate"].DisplayIndex = 4;
            dtgUsuario.Columns["expirationdate"].HeaderText = "Vigencia";
            dtgUsuario.Columns["expirationdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgUsuario.Columns["active"].DisplayIndex = 5;
            dtgUsuario.Columns["active"].HeaderText = "Activo";
            dtgUsuario.Columns["admin"].DisplayIndex = 6;
            dtgUsuario.Columns["admin"].HeaderText = "Administrador";

        }
        private void btnFiltrarU_Click(object sender, EventArgs e)
        {
            txtUfiltro.Text = string.Empty;
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
            // chbUactivo.Text = "";
            user = new Usuario();
            gbUsuarios.Enabled = true;
            btnUguardar.Enabled = true;
            gbUsuarios1.Enabled = false;
        }

        private void btnUeditar_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = true;
            gbUsuarios1.Enabled = false;
            btnUguardar.Enabled = true;
        }

        public void loadDataFromGrid(DataGridViewRow row) {
            user.Nickname = txtUsuario.Text = row.Cells["nickname"].Value.ToString();
            user.Name = txtUnombre.Text = row.Cells["name"].Value.ToString();
            user.Lastname = txtUapellidos.Text = row.Cells["lastname"].Value.ToString();
            user.Email = txtUemail.Text = row.Cells["email"].Value.ToString();
            dtpUfvencimiento.Text = row.Cells["expirationdate"].Value.ToString();//.Substring(0,24);
            user.ExpirationDate = DateTime.ParseExact(dtpUfvencimiento.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CurrentCulture).ToString();
            user.Id = row.Cells["_id"].Value.ToString();
            user.Active = chbUactivo.Checked = (bool)row.Cells["active"].Value;
            user.Admin = chbUadmin.Checked = (bool)row.Cells["admin"].Value;
        }
        public void loadDataFromForm() {
            user.Nickname = txtUsuario.Text;
            user.Name = txtUnombre.Text;
            user.Lastname = txtUapellidos.Text;
            user.Email = txtUemail.Text;
            DateTime dt = DateTime.ParseExact(dtpUfvencimiento.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            user.ExpirationDate = dt.Month + "/" + dt.Day + "/" + dt.Year;
            user.Active = chbUactivo.Checked;
            user.Admin = chbUadmin.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gbUsuarios1.Enabled = true;
            gbUsuarios.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUfiltro.Text != "")
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
                        if ((c.Value.ToString().ToUpper()).Contains(txtUfiltro.Text.ToUpper()))
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
           
                // Llamar la función validar
                validar(this);




                //   if (txtUsuario.Text.Length == 0)
                //   {
                //        MessageBox.Show("El usuario no debe estar vacio");
                //    }
                //     else if (txtUnombre.Text.Length == 0 || txtUapellidos.Text.Length == 0)
                //     {
                //         MessageBox.Show("El campo Nombre o Apellido no deben estar vacios");
                //     }
                // else
                //   {
            //    loadDataFromForm();
            //    string pwd1 = txtUccontraseña.Text.Trim(), pwd2 = txtUcontraseña.Text.Trim();
            //    if (pwd1.Equals(string.Empty) && pwd2.Equals(string.Empty))
            //    {
            //        user.upSert(false);
             //       reloadInitialState();
           //     }
            //    else
            //    {
            //        if (pwd1.Length >= 8 && pwd2.Length >= 8 && pwd1.Equals(pwd2))
            //        {
            //            user.Pwd = txtUcontraseña.Text;
            //            user.upSert(true);
            //            reloadInitialState();
            //        }
            //        else
             //       {
            //            MessageBox.Show("Verifique que la contraseña coincida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
           //     }
            }
         
        
          public void reloadInitialState() {
            gbUsuarios.Enabled = false;
            gbUsuarios1.Enabled = true;
            btnUguardar.Enabled = false;
            fillGridView();
            filterActive();
            txtUcontraseña.Text = txtUccontraseña.Text = string.Empty;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filterActive();
        }

        public void filterActive() {
            if (!checkBox1.Checked)
            {
                checkBox1.Text = "Mostrar solo usuarios activos.";
                dtgUsuario.CurrentCell = null;
                foreach (DataGridViewRow r in dtgUsuario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgUsuario.Rows)
                {
                    //foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((bool)r.Cells["active"].Value)
                        {
                            r.Visible = true;
                            //break;
                        }
                    }
                }
            }
            else
            {
                checkBox1.Text = "Mostrar todos los usuarios.";
                foreach (DataGridViewRow r in dtgUsuario.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                eperror.SetError(txtUsuario, "Introduce un Usuario...");
                txtUsuario.Focus();
            }
            else
            {
                eperror.Clear();
            }
      }

        private void txtUnombre_Validated(object sender, EventArgs e)
        {
            if (txtUnombre.Text.Trim() == "")
            {
                eperror.SetError(txtUnombre, "Introduce un Nombre...");
                txtUnombre.Focus();
            }
            else
            {
                eperror.Clear();
            }
        }

        private void txtUapellidos_Validated(object sender, EventArgs e)
        {
            if (txtUapellidos.Text.Trim() == "")
            {
                eperror.SetError(txtUapellidos, "Introduce un Apellido...");
                txtUapellidos.Focus();
            }
            else
            {
                eperror.Clear();
            }
        }
    }
      
   }

