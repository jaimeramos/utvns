namespace Principal
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUactualizar = new System.Windows.Forms.Button();
            this.dtpUfvencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtUccontraseña = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbUadmin = new System.Windows.Forms.CheckBox();
            this.chbUactivo = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtUnombre = new System.Windows.Forms.TextBox();
            this.txtUcontraseña = new System.Windows.Forms.TextBox();
            this.txtUapellidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUsuarios1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUeditar = new System.Windows.Forms.Button();
            this.btnUregresar = new System.Windows.Forms.Button();
            this.btnUusuario = new System.Windows.Forms.Button();
            this.btnUFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbUsuarios1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(5, 70);
            this.dtgUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.Size = new System.Drawing.Size(821, 208);
            this.dtgUsuario.TabIndex = 17;
            this.dtgUsuario.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_RowEnter);
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.button1);
            this.gbUsuarios.Controls.Add(this.btnUactualizar);
            this.gbUsuarios.Controls.Add(this.dtpUfvencimiento);
            this.gbUsuarios.Controls.Add(this.txtUccontraseña);
            this.gbUsuarios.Controls.Add(this.groupBox2);
            this.gbUsuarios.Controls.Add(this.txtUsuario);
            this.gbUsuarios.Controls.Add(this.txtUnombre);
            this.gbUsuarios.Controls.Add(this.txtUcontraseña);
            this.gbUsuarios.Controls.Add(this.txtUapellidos);
            this.gbUsuarios.Controls.Add(this.label8);
            this.gbUsuarios.Controls.Add(this.txtUemail);
            this.gbUsuarios.Controls.Add(this.label7);
            this.gbUsuarios.Controls.Add(this.label6);
            this.gbUsuarios.Controls.Add(this.label2);
            this.gbUsuarios.Controls.Add(this.label5);
            this.gbUsuarios.Controls.Add(this.label3);
            this.gbUsuarios.Controls.Add(this.label4);
            this.gbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarios.Location = new System.Drawing.Point(3, 313);
            this.gbUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsuarios.Size = new System.Drawing.Size(832, 202);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Datos del Usuario";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Principal.Properties.Resources.cerrar_little;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(709, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUactualizar
            // 
            this.btnUactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnUactualizar.Image")));
            this.btnUactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUactualizar.Location = new System.Drawing.Point(709, 38);
            this.btnUactualizar.Name = "btnUactualizar";
            this.btnUactualizar.Size = new System.Drawing.Size(95, 62);
            this.btnUactualizar.TabIndex = 10;
            this.btnUactualizar.Text = "Guardar";
            this.btnUactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUactualizar.UseVisualStyleBackColor = true;
            this.btnUactualizar.Click += new System.EventHandler(this.btnUactualizar_Click);
            // 
            // dtpUfvencimiento
            // 
            this.dtpUfvencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUfvencimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpUfvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUfvencimiento.Location = new System.Drawing.Point(483, 100);
            this.dtpUfvencimiento.Name = "dtpUfvencimiento";
            this.dtpUfvencimiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpUfvencimiento.Size = new System.Drawing.Size(182, 22);
            this.dtpUfvencimiento.TabIndex = 6;
            // 
            // txtUccontraseña
            // 
            this.txtUccontraseña.Location = new System.Drawing.Point(483, 66);
            this.txtUccontraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUccontraseña.Name = "txtUccontraseña";
            this.txtUccontraseña.PasswordChar = '*';
            this.txtUccontraseña.Size = new System.Drawing.Size(182, 22);
            this.txtUccontraseña.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbUadmin);
            this.groupBox2.Controls.Add(this.chbUactivo);
            this.groupBox2.Location = new System.Drawing.Point(301, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // chbUadmin
            // 
            this.chbUadmin.AutoSize = true;
            this.chbUadmin.Location = new System.Drawing.Point(182, 16);
            this.chbUadmin.Name = "chbUadmin";
            this.chbUadmin.Size = new System.Drawing.Size(144, 20);
            this.chbUadmin.TabIndex = 8;
            this.chbUadmin.Text = "Es administrador";
            this.chbUadmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbUadmin.UseVisualStyleBackColor = true;
            // 
            // chbUactivo
            // 
            this.chbUactivo.AutoSize = true;
            this.chbUactivo.Location = new System.Drawing.Point(35, 16);
            this.chbUactivo.Name = "chbUactivo";
            this.chbUactivo.Size = new System.Drawing.Size(104, 20);
            this.chbUactivo.TabIndex = 7;
            this.chbUactivo.Text = "Está activo";
            this.chbUactivo.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(81, 34);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtUnombre
            // 
            this.txtUnombre.Location = new System.Drawing.Point(82, 66);
            this.txtUnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnombre.Name = "txtUnombre";
            this.txtUnombre.Size = new System.Drawing.Size(210, 22);
            this.txtUnombre.TabIndex = 1;
            // 
            // txtUcontraseña
            // 
            this.txtUcontraseña.Location = new System.Drawing.Point(483, 34);
            this.txtUcontraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUcontraseña.Name = "txtUcontraseña";
            this.txtUcontraseña.PasswordChar = '*';
            this.txtUcontraseña.Size = new System.Drawing.Size(182, 22);
            this.txtUcontraseña.TabIndex = 4;
            // 
            // txtUapellidos
            // 
            this.txtUapellidos.Location = new System.Drawing.Point(81, 100);
            this.txtUapellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUapellidos.Name = "txtUapellidos";
            this.txtUapellidos.Size = new System.Drawing.Size(210, 22);
            this.txtUapellidos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de Vencimiento:";
            // 
            // txtUemail
            // 
            this.txtUemail.Location = new System.Drawing.Point(81, 133);
            this.txtUemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUemail.Name = "txtUemail";
            this.txtUemail.Size = new System.Drawing.Size(210, 22);
            this.txtUemail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirmar Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos:";
            // 
            // txtUfiltro
            // 
            this.txtUfiltro.Location = new System.Drawing.Point(55, 26);
            this.txtUfiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUfiltro.Name = "txtUfiltro";
            this.txtUfiltro.Size = new System.Drawing.Size(236, 22);
            this.txtUfiltro.TabIndex = 12;
            this.txtUfiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro:";
            // 
            // gbUsuarios1
            // 
            this.gbUsuarios1.Controls.Add(this.checkBox1);
            this.gbUsuarios1.Controls.Add(this.label1);
            this.gbUsuarios1.Controls.Add(this.btnUeditar);
            this.gbUsuarios1.Controls.Add(this.dtgUsuario);
            this.gbUsuarios1.Controls.Add(this.btnUregresar);
            this.gbUsuarios1.Controls.Add(this.txtUfiltro);
            this.gbUsuarios1.Controls.Add(this.btnUusuario);
            this.gbUsuarios1.Controls.Add(this.btnUFiltrar);
            this.gbUsuarios1.Location = new System.Drawing.Point(3, 0);
            this.gbUsuarios1.Name = "gbUsuarios1";
            this.gbUsuarios1.Size = new System.Drawing.Size(832, 311);
            this.gbUsuarios1.TabIndex = 17;
            this.gbUsuarios1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(590, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Mostrar todos los usuarios.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUeditar
            // 
            this.btnUeditar.Image = global::Principal.Properties.Resources.Editar_usuario_little;
            this.btnUeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUeditar.Location = new System.Drawing.Point(575, 21);
            this.btnUeditar.Name = "btnUeditar";
            this.btnUeditar.Size = new System.Drawing.Size(142, 33);
            this.btnUeditar.TabIndex = 15;
            this.btnUeditar.Text = "Editar Usuario";
            this.btnUeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUeditar.UseVisualStyleBackColor = true;
            this.btnUeditar.Click += new System.EventHandler(this.btnUeditar_Click);
            // 
            // btnUregresar
            // 
            this.btnUregresar.Image = global::Principal.Properties.Resources.REGRESAR1;
            this.btnUregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUregresar.Location = new System.Drawing.Point(723, 21);
            this.btnUregresar.Name = "btnUregresar";
            this.btnUregresar.Size = new System.Drawing.Size(103, 33);
            this.btnUregresar.TabIndex = 16;
            this.btnUregresar.Text = "Regresar";
            this.btnUregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUregresar.UseVisualStyleBackColor = true;
            this.btnUregresar.Click += new System.EventHandler(this.btnUregresar_Click);
            // 
            // btnUusuario
            // 
            this.btnUusuario.Image = global::Principal.Properties.Resources.registro_usuario_1;
            this.btnUusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUusuario.Location = new System.Drawing.Point(431, 20);
            this.btnUusuario.Name = "btnUusuario";
            this.btnUusuario.Size = new System.Drawing.Size(138, 33);
            this.btnUusuario.TabIndex = 14;
            this.btnUusuario.Text = "Nuevo Usuario";
            this.btnUusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUusuario.UseVisualStyleBackColor = true;
            this.btnUusuario.Click += new System.EventHandler(this.btnNusuario_Click);
            // 
            // btnUFiltrar
            // 
            this.btnUFiltrar.Image = global::Principal.Properties.Resources.depositphotos_63778659_stock_illustration_vector_search_document_icon2;
            this.btnUFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUFiltrar.Location = new System.Drawing.Point(297, 21);
            this.btnUFiltrar.Name = "btnUFiltrar";
            this.btnUFiltrar.Size = new System.Drawing.Size(128, 33);
            this.btnUFiltrar.TabIndex = 13;
            this.btnUFiltrar.Text = "Limpiar filtro";
            this.btnUFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUFiltrar.UseVisualStyleBackColor = true;
            this.btnUFiltrar.Click += new System.EventHandler(this.btnFiltrarU_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 520);
            this.Controls.Add(this.gbUsuarios1);
            this.Controls.Add(this.gbUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTVNS - Gestión de usuarios del sistema";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbUsuarios1.ResumeLayout(false);
            this.gbUsuarios1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.CheckBox chbUadmin;
        private System.Windows.Forms.CheckBox chbUactivo;
        private System.Windows.Forms.TextBox txtUnombre;
        private System.Windows.Forms.TextBox txtUapellidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUcontraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUfiltro;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUFiltrar;
        private System.Windows.Forms.DateTimePicker dtpUfvencimiento;
        private System.Windows.Forms.TextBox txtUccontraseña;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUactualizar;
        private System.Windows.Forms.Button btnUusuario;
        private System.Windows.Forms.Button btnUregresar;
        private System.Windows.Forms.Button btnUeditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbUsuarios1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}