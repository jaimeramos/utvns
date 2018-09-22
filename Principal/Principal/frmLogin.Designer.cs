namespace Principal
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLacceder = new System.Windows.Forms.Button();
            this.txtLusuario = new System.Windows.Forms.TextBox();
            this.txtLcontraseña = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLacceder
            // 
            this.btnLacceder.BackColor = System.Drawing.Color.Silver;
            this.btnLacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLacceder.Location = new System.Drawing.Point(72, 114);
            this.btnLacceder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLacceder.Name = "btnLacceder";
            this.btnLacceder.Size = new System.Drawing.Size(169, 30);
            this.btnLacceder.TabIndex = 0;
            this.btnLacceder.Text = "Acceder";
            this.btnLacceder.UseVisualStyleBackColor = false;
            this.btnLacceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLusuario
            // 
            this.txtLusuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLusuario.Location = new System.Drawing.Point(72, 21);
            this.txtLusuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLusuario.Name = "txtLusuario";
            this.txtLusuario.Size = new System.Drawing.Size(169, 27);
            this.txtLusuario.TabIndex = 1;
            this.txtLusuario.Text = "jramos";
            this.txtLusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLusuario.Click += new System.EventHandler(this.txtLusuario_Click);
            this.txtLusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLusuario_KeyPress);
            this.txtLusuario.Validated += new System.EventHandler(this.txtLusuario_Validated);
            // 
            // txtLcontraseña
            // 
            this.txtLcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLcontraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLcontraseña.Location = new System.Drawing.Point(72, 73);
            this.txtLcontraseña.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLcontraseña.Name = "txtLcontraseña";
            this.txtLcontraseña.Size = new System.Drawing.Size(169, 24);
            this.txtLcontraseña.TabIndex = 2;
            this.txtLcontraseña.Text = "123admin";
            this.txtLcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLcontraseña.UseWaitCursor = true;
            this.txtLcontraseña.Click += new System.EventHandler(this.txtLcontraseña_Click);
            this.txtLcontraseña.TextChanged += new System.EventHandler(this.txtLcontraseña_TextChanged);
            this.txtLcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLusuario_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pbContraseña);
            this.groupBox1.Controls.Add(this.pbUsuario);
            this.groupBox1.Controls.Add(this.txtLcontraseña);
            this.groupBox1.Controls.Add(this.btnLacceder);
            this.groupBox1.Controls.Add(this.txtLusuario);
            this.groupBox1.Location = new System.Drawing.Point(210, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(270, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pbContraseña
            // 
            this.pbContraseña.ErrorImage = null;
            this.pbContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pbContraseña.Image")));
            this.pbContraseña.InitialImage = null;
            this.pbContraseña.Location = new System.Drawing.Point(34, 65);
            this.pbContraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(32, 32);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContraseña.TabIndex = 4;
            this.pbContraseña.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.InitialImage = null;
            this.pbUsuario.Location = new System.Drawing.Point(34, 13);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(32, 33);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 3;
            this.pbUsuario.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 320);
            this.panel1.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(515, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLacceder;
        private System.Windows.Forms.TextBox txtLusuario;
        private System.Windows.Forms.TextBox txtLcontraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbContraseña;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}