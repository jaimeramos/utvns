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
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLacceder
            // 
            this.btnLacceder.Location = new System.Drawing.Point(74, 160);
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
            this.txtLusuario.Location = new System.Drawing.Point(75, 42);
            this.txtLusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLusuario.Name = "txtLusuario";
            this.txtLusuario.Size = new System.Drawing.Size(166, 27);
            this.txtLusuario.TabIndex = 1;
            this.txtLusuario.Click += new System.EventHandler(this.txtLusuario_Click);
            this.txtLusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLusuario.Validated += new System.EventHandler(this.txtLusuario_Validated);
            // 
            // txtLcontraseña
            // 
            this.txtLcontraseña.Location = new System.Drawing.Point(75, 112);
            this.txtLcontraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLcontraseña.Name = "txtLcontraseña";
            this.txtLcontraseña.PasswordChar = '*';
            this.txtLcontraseña.Size = new System.Drawing.Size(166, 27);
            this.txtLcontraseña.TabIndex = 2;
            this.txtLcontraseña.Click += new System.EventHandler(this.txtLcontraseña_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(153, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio de Sesión";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
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
            // pbContraseña
            // 
            this.pbContraseña.Location = new System.Drawing.Point(36, 93);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(32, 27);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContraseña.TabIndex = 4;
            this.pbContraseña.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.InitialImage = null;
            this.pbUsuario.Location = new System.Drawing.Point(36, 28);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(32, 27);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 3;
            this.pbUsuario.TabStop = false;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(171, 45);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(183, 180);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epError;
    }
}