using System;
using System.Windows.Forms;
using Principal.EnlaceDatos;
namespace Principal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.Login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                new Principal().Show();
    }        }
    }
}
