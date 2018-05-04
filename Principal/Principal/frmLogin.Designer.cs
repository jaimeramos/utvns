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
            this.components = new System.ComponentModel.Container();
            this.btnLacceder = new System.Windows.Forms.Button();
            this.txtLusuario = new System.Windows.Forms.TextBox();
            this.txtLcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLacceder
            // 
            this.btnLacceder.Location = new System.Drawing.Point(75, 174);
            this.btnLacceder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLacceder.Name = "btnLacceder";
            this.btnLacceder.Size = new System.Drawing.Size(167, 33);
            this.btnLacceder.TabIndex = 0;
            this.btnLacceder.Text = "Acceder";
            this.btnLacceder.UseVisualStyleBackColor = true;
            this.btnLacceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLusuario
            // 
            this.txtLusuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLusuario.Location = new System.Drawing.Point(75, 42);
            this.txtLusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLusuario.Name = "txtLusuario";
            this.txtLusuario.Size = new System.Drawing.Size(166, 27);
            this.txtLusuario.TabIndex = 1;
            this.txtLusuario.Text = "Usuario";
            this.txtLusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLusuario.Click += new System.EventHandler(this.txtLusuario_Click);
            this.txtLusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLusuario_KeyPress);
            this.txtLusuario.Validated += new System.EventHandler(this.txtLusuario_Validated);
            // 
            // txtLcontraseña
            // 
            this.txtLcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLcontraseña.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLcontraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLcontraseña.Location = new System.Drawing.Point(75, 112);
            this.txtLcontraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLcontraseña.Name = "txtLcontraseña";
            this.txtLcontraseña.Size = new System.Drawing.Size(166, 25);
            this.txtLcontraseña.TabIndex = 2;
            this.txtLcontraseña.Text = "contraseña";
            this.txtLcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLcontraseña.UseWaitCursor = true;
            this.txtLcontraseña.Click += new System.EventHandler(this.txtLcontraseña_Click);
            this.txtLcontraseña.TextChanged += new System.EventHandler(this.txtLcontraseña_TextChanged);
            this.txtLcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLusuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(155, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio de Sesión";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pbContraseña);
            this.groupBox1.Controls.Add(this.pbUsuario);
            this.groupBox1.Controls.Add(this.txtLcontraseña);
            this.groupBox1.Controls.Add(this.btnLacceder);
            this.groupBox1.Controls.Add(this.txtLusuario);
            this.groupBox1.Location = new System.Drawing.Point(112, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pbImagen
            // 
            this.pbImagen.ErrorImage = null;
            this.pbImagen.Image = global::Principal.Properties.Resources.login;
            this.pbImagen.InitialImage = null;
            this.pbImagen.Location = new System.Drawing.Point(171, 45);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(183, 180);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // pbContraseña
            // 
            this.pbContraseña.ErrorImage = null;
            this.pbContraseña.Image = global::Principal.Properties.Resources.candado;
            this.pbContraseña.InitialImage = null;
            this.pbContraseña.Location = new System.Drawing.Point(28, 99);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(40, 40);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContraseña.TabIndex = 4;
            this.pbContraseña.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Principal.Properties.Resources.usuario;
            this.pbUsuario.InitialImage = null;
            this.pbUsuario.Location = new System.Drawing.Point(28, 29);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(40, 40);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 3;
            this.pbUsuario.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(543, 474);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLacceder;
        private System.Windows.Forms.TextBox txtLusuario;
        private System.Windows.Forms.TextBox txtLcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbContraseña;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ErrorProvider epError;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}