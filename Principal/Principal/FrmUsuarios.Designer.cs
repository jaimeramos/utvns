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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUcancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpUfvencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtUapellidos = new System.Windows.Forms.TextBox();
            this.txtUccontraseña = new System.Windows.Forms.TextBox();
            this.txtUnombre = new System.Windows.Forms.TextBox();
            this.gbUtipo = new System.Windows.Forms.GroupBox();
            this.chbUadmin = new System.Windows.Forms.CheckBox();
            this.chbUactivo = new System.Windows.Forms.CheckBox();
            this.txtUcontraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUsuarios1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUeditar = new System.Windows.Forms.Button();
            this.btnUregresar = new System.Windows.Forms.Button();
            this.btnUnuevo = new System.Windows.Forms.Button();
            this.btnUfiltrar = new System.Windows.Forms.Button();
            this.eperror = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.gbUtipo.SuspendLayout();
            this.gbUsuarios1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(4, 74);
            this.dtgUsuario.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.Size = new System.Drawing.Size(730, 195);
            this.dtgUsuario.TabIndex = 17;
            this.dtgUsuario.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_RowEnter);
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.txtUsuario);
            this.gbUsuarios.Controls.Add(this.label4);
            this.gbUsuarios.Controls.Add(this.btnUcancelar);
            this.gbUsuarios.Controls.Add(this.label3);
            this.gbUsuarios.Controls.Add(this.btnUguardar);
            this.gbUsuarios.Controls.Add(this.label2);
            this.gbUsuarios.Controls.Add(this.dtpUfvencimiento);
            this.gbUsuarios.Controls.Add(this.txtUapellidos);
            this.gbUsuarios.Controls.Add(this.txtUccontraseña);
            this.gbUsuarios.Controls.Add(this.txtUnombre);
            this.gbUsuarios.Controls.Add(this.gbUtipo);
            this.gbUsuarios.Controls.Add(this.txtUcontraseña);
            this.gbUsuarios.Controls.Add(this.label8);
            this.gbUsuarios.Controls.Add(this.txtUemail);
            this.gbUsuarios.Controls.Add(this.label7);
            this.gbUsuarios.Controls.Add(this.label6);
            this.gbUsuarios.Controls.Add(this.label5);
            this.gbUsuarios.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarios.Location = new System.Drawing.Point(29, 332);
            this.gbUsuarios.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbUsuarios.Size = new System.Drawing.Size(751, 177);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Datos del Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(71, 24);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(164, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Validated += new System.EventHandler(this.txtUsuario_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos:";
            // 
            // btnUcancelar
            // 
            this.btnUcancelar.FlatAppearance.BorderSize = 0;
            this.btnUcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnUcancelar.Image")));
            this.btnUcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcancelar.Location = new System.Drawing.Point(595, 99);
            this.btnUcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUcancelar.Name = "btnUcancelar";
            this.btnUcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnUcancelar.TabIndex = 11;
            this.btnUcancelar.Text = "Cancelar";
            this.btnUcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUcancelar.UseVisualStyleBackColor = true;
            this.btnUcancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // btnUguardar
            // 
            this.btnUguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUguardar.FlatAppearance.BorderSize = 0;
            this.btnUguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnUguardar.Image")));
            this.btnUguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUguardar.Location = new System.Drawing.Point(595, 35);
            this.btnUguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUguardar.Name = "btnUguardar";
            this.btnUguardar.Size = new System.Drawing.Size(115, 40);
            this.btnUguardar.TabIndex = 10;
            this.btnUguardar.Text = "Guardar";
            this.btnUguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUguardar.UseVisualStyleBackColor = true;
            this.btnUguardar.Click += new System.EventHandler(this.btnUactualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // dtpUfvencimiento
            // 
            this.dtpUfvencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUfvencimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpUfvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUfvencimiento.Location = new System.Drawing.Point(409, 89);
            this.dtpUfvencimiento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpUfvencimiento.Name = "dtpUfvencimiento";
            this.dtpUfvencimiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpUfvencimiento.Size = new System.Drawing.Size(142, 23);
            this.dtpUfvencimiento.TabIndex = 6;
            // 
            // txtUapellidos
            // 
            this.txtUapellidos.Location = new System.Drawing.Point(71, 86);
            this.txtUapellidos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUapellidos.Name = "txtUapellidos";
            this.txtUapellidos.Size = new System.Drawing.Size(164, 23);
            this.txtUapellidos.TabIndex = 2;
            this.txtUapellidos.Validated += new System.EventHandler(this.txtUapellidos_Validated);
            // 
            // txtUccontraseña
            // 
            this.txtUccontraseña.Location = new System.Drawing.Point(409, 57);
            this.txtUccontraseña.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUccontraseña.Name = "txtUccontraseña";
            this.txtUccontraseña.PasswordChar = '*';
            this.txtUccontraseña.Size = new System.Drawing.Size(142, 23);
            this.txtUccontraseña.TabIndex = 5;
            // 
            // txtUnombre
            // 
            this.txtUnombre.Location = new System.Drawing.Point(71, 55);
            this.txtUnombre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUnombre.Name = "txtUnombre";
            this.txtUnombre.Size = new System.Drawing.Size(164, 23);
            this.txtUnombre.TabIndex = 1;
            this.txtUnombre.Validated += new System.EventHandler(this.txtUnombre_Validated);
            // 
            // gbUtipo
            // 
            this.gbUtipo.Controls.Add(this.chbUadmin);
            this.gbUtipo.Controls.Add(this.chbUactivo);
            this.gbUtipo.Location = new System.Drawing.Point(267, 114);
            this.gbUtipo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUtipo.Name = "gbUtipo";
            this.gbUtipo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUtipo.Size = new System.Drawing.Size(284, 45);
            this.gbUtipo.TabIndex = 16;
            this.gbUtipo.TabStop = false;
            // 
            // chbUadmin
            // 
            this.chbUadmin.AutoSize = true;
            this.chbUadmin.Location = new System.Drawing.Point(142, 15);
            this.chbUadmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chbUadmin.Name = "chbUadmin";
            this.chbUadmin.Size = new System.Drawing.Size(117, 19);
            this.chbUadmin.TabIndex = 8;
            this.chbUadmin.Text = "Es administrador";
            this.chbUadmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbUadmin.UseVisualStyleBackColor = true;
            // 
            // chbUactivo
            // 
            this.chbUactivo.AutoSize = true;
            this.chbUactivo.Location = new System.Drawing.Point(27, 15);
            this.chbUactivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chbUactivo.Name = "chbUactivo";
            this.chbUactivo.Size = new System.Drawing.Size(83, 19);
            this.chbUactivo.TabIndex = 7;
            this.chbUactivo.Text = "Está activo";
            this.chbUactivo.UseVisualStyleBackColor = true;
            // 
            // txtUcontraseña
            // 
            this.txtUcontraseña.Location = new System.Drawing.Point(409, 27);
            this.txtUcontraseña.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUcontraseña.Name = "txtUcontraseña";
            this.txtUcontraseña.PasswordChar = '*';
            this.txtUcontraseña.Size = new System.Drawing.Size(142, 23);
            this.txtUcontraseña.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de Vencimiento:";
            // 
            // txtUemail
            // 
            this.txtUemail.Location = new System.Drawing.Point(71, 121);
            this.txtUemail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUemail.Name = "txtUemail";
            this.txtUemail.Size = new System.Drawing.Size(164, 23);
            this.txtUemail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirmar Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // txtUfiltro
            // 
            this.txtUfiltro.Location = new System.Drawing.Point(53, 27);
            this.txtUfiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUfiltro.Name = "txtUfiltro";
            this.txtUfiltro.Size = new System.Drawing.Size(148, 23);
            this.txtUfiltro.TabIndex = 12;
            this.txtUfiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
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
            this.gbUsuarios1.Controls.Add(this.btnUnuevo);
            this.gbUsuarios1.Controls.Add(this.btnUfiltrar);
            this.gbUsuarios1.Location = new System.Drawing.Point(29, 12);
            this.gbUsuarios1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUsuarios1.Name = "gbUsuarios1";
            this.gbUsuarios1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUsuarios1.Size = new System.Drawing.Size(751, 313);
            this.gbUsuarios1.TabIndex = 17;
            this.gbUsuarios1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(561, 275);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Mostrar todos los usuarios.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUeditar
            // 
            this.btnUeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUeditar.FlatAppearance.BorderSize = 0;
            this.btnUeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUeditar.Image = ((System.Drawing.Image)(resources.GetObject("btnUeditar.Image")));
            this.btnUeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUeditar.Location = new System.Drawing.Point(472, 20);
            this.btnUeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUeditar.Name = "btnUeditar";
            this.btnUeditar.Size = new System.Drawing.Size(136, 40);
            this.btnUeditar.TabIndex = 15;
            this.btnUeditar.Text = "Editar Usuario";
            this.btnUeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUeditar.UseVisualStyleBackColor = true;
            this.btnUeditar.Click += new System.EventHandler(this.btnUeditar_Click);
            // 
            // btnUregresar
            // 
            this.btnUregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUregresar.FlatAppearance.BorderSize = 0;
            this.btnUregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnUregresar.Image")));
            this.btnUregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUregresar.Location = new System.Drawing.Point(612, 20);
            this.btnUregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUregresar.Name = "btnUregresar";
            this.btnUregresar.Size = new System.Drawing.Size(98, 40);
            this.btnUregresar.TabIndex = 16;
            this.btnUregresar.Text = "Regresar";
            this.btnUregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUregresar.UseVisualStyleBackColor = true;
            this.btnUregresar.Click += new System.EventHandler(this.btnUregresar_Click);
            // 
            // btnUnuevo
            // 
            this.btnUnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnuevo.FlatAppearance.BorderSize = 0;
            this.btnUnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnUnuevo.Image")));
            this.btnUnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnuevo.Location = new System.Drawing.Point(334, 20);
            this.btnUnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUnuevo.Name = "btnUnuevo";
            this.btnUnuevo.Size = new System.Drawing.Size(134, 40);
            this.btnUnuevo.TabIndex = 14;
            this.btnUnuevo.Text = "Nuevo Usuario";
            this.btnUnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnuevo.UseVisualStyleBackColor = true;
            this.btnUnuevo.Click += new System.EventHandler(this.btnNusuario_Click);
            // 
            // btnUfiltrar
            // 
            this.btnUfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUfiltrar.FlatAppearance.BorderSize = 0;
            this.btnUfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnUfiltrar.Image")));
            this.btnUfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUfiltrar.Location = new System.Drawing.Point(213, 20);
            this.btnUfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUfiltrar.Name = "btnUfiltrar";
            this.btnUfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnUfiltrar.TabIndex = 13;
            this.btnUfiltrar.Text = "Limpiar filtro";
            this.btnUfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUfiltrar.UseVisualStyleBackColor = true;
            this.btnUfiltrar.Click += new System.EventHandler(this.btnFiltrarU_Click);
            // 
            // eperror
            // 
            this.eperror.ContainerControl = this;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 529);
            this.Controls.Add(this.gbUsuarios1);
            this.Controls.Add(this.gbUsuarios);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTVNS - Gestión de Usuarios del Sistema";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.gbUtipo.ResumeLayout(false);
            this.gbUtipo.PerformLayout();
            this.gbUsuarios1.ResumeLayout(false);
            this.gbUsuarios1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).EndInit();
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
        private System.Windows.Forms.Button btnUfiltrar;
        private System.Windows.Forms.DateTimePicker dtpUfvencimiento;
        private System.Windows.Forms.TextBox txtUccontraseña;
        private System.Windows.Forms.GroupBox gbUtipo;
        private System.Windows.Forms.Button btnUguardar;
        private System.Windows.Forms.Button btnUnuevo;
        private System.Windows.Forms.Button btnUregresar;
        private System.Windows.Forms.Button btnUeditar;
        private System.Windows.Forms.Button btnUcancelar;
        private System.Windows.Forms.GroupBox gbUsuarios1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider eperror;
    }
}