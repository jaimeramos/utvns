using System;
using System.Drawing;
using System.Windows.Forms;
using Principal.EnlaceDatos;
using System.Drawing;
namespace Principal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //pbImagen.Image = Image.FromFile("login.png");
            //pbUsuario.Image = Image.FromFile("usuario.png");
            //pbContraseña.Image = Image.FromFile("candado.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (Data.Login(txtLusuario.Text, txtLcontraseña.Text))
            {
                this.Hide();
                new Principal().Show();
                }
                else
                {
                    MessageBox.Show("El nombre de Usuario o la contraseña estan incorrectas");
                txtLusuario.Text = "";
                txtLcontraseña.Text = "";
            }
            }
        
    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLusuario.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtLusuario_Click(object sender, EventArgs e)
        {
            txtLusuario.Text = "";
        }

        private void txtLcontraseña_Click(object sender, EventArgs e)
        {
            txtLcontraseña.Text = "";
        }

        private void txtLusuario_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtLcontraseña_TextChanged(object sender, EventArgs e)
        {
           txtLcontraseña.UseSystemPasswordChar = true;
           
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void txtLusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) {
                button1_Click(sender,e);
            }
        }
    }
}
