using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.EnlaceDatos;
namespace Principal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pbImagen.Image = Image.FromFile("login.png");
            pbUsuario.Image = Image.FromFile("usuario.png");
            pbContraseña.Image = Image.FromFile("candado.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.Login(txtLusuario.Text, txtLcontraseña.Text))
            {
                this.Hide();
                new Principal().Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLusuario_Click(object sender, EventArgs e)
        {

        }

        private void txtLcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtLusuario_Validated(object sender, EventArgs e)
        {
        }
    }
}