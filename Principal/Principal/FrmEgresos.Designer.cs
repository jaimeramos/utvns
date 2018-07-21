namespace Principal
{
    partial class FrmEgresos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmEgresos
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FrmEgresos";
            this.Load += new System.EventHandler(this.FrmEgresos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEreferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdescripcion;
        private System.Windows.Forms.Button btnEcancelar;
        private System.Windows.Forms.Button btnEguardar;
        private System.Windows.Forms.TextBox txtEfolio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEfiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnEfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnuevo;
        private System.Windows.Forms.Button btnEeditar;
        private System.Windows.Forms.Button btnEregresar;
        private System.Windows.Forms.DataGridView dtgPermiso;
        private System.Windows.Forms.ComboBox cmbEtipo;
    }
}