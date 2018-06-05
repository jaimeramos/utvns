namespace Principal
{
    partial class FrmPermisionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisionarios));
            this.gbPermisionarios = new System.Windows.Forms.GroupBox();
            this.cmbPestado = new System.Windows.Forms.ComboBox();
            this.cmbPlvigente = new System.Windows.Forms.ComboBox();
            this.btnPcancelar = new System.Windows.Forms.Button();
            this.btnPguardar = new System.Windows.Forms.Button();
            this.dtpPfactualizacion = new System.Windows.Forms.DateTimePicker();
            this.dtpPfalta = new System.Windows.Forms.DateTimePicker();
            this.dtpPfadmision = new System.Windows.Forms.DateTimePicker();
            this.cmbPtipo = new System.Windows.Forms.ComboBox();
            this.txtPnumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPemail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPcelular = new System.Windows.Forms.TextBox();
            this.txtPtelefono = new System.Windows.Forms.TextBox();
            this.txtPrfc = new System.Windows.Forms.TextBox();
            this.txtPdireccion = new System.Windows.Forms.TextBox();
            this.txtPnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgVehiculos = new System.Windows.Forms.DataGridView();
            this.btnPeditar = new System.Windows.Forms.Button();
            this.btnPregresar = new System.Windows.Forms.Button();
            this.chbPermisionarios = new System.Windows.Forms.CheckBox();
            this.btnPnuevo = new System.Windows.Forms.Button();
            this.btnPfiltrar = new System.Windows.Forms.Button();
            this.txtPfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPermisionarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPermisionarios
            // 
            this.gbPermisionarios.Controls.Add(this.cmbPestado);
            this.gbPermisionarios.Controls.Add(this.cmbPlvigente);
            this.gbPermisionarios.Controls.Add(this.btnPcancelar);
            this.gbPermisionarios.Controls.Add(this.btnPguardar);
            this.gbPermisionarios.Controls.Add(this.dtpPfactualizacion);
            this.gbPermisionarios.Controls.Add(this.dtpPfalta);
            this.gbPermisionarios.Controls.Add(this.dtpPfadmision);
            this.gbPermisionarios.Controls.Add(this.cmbPtipo);
            this.gbPermisionarios.Controls.Add(this.txtPnumero);
            this.gbPermisionarios.Controls.Add(this.label15);
            this.gbPermisionarios.Controls.Add(this.txtPemail);
            this.gbPermisionarios.Controls.Add(this.label14);
            this.gbPermisionarios.Controls.Add(this.label9);
            this.gbPermisionarios.Controls.Add(this.label13);
            this.gbPermisionarios.Controls.Add(this.label8);
            this.gbPermisionarios.Controls.Add(this.label12);
            this.gbPermisionarios.Controls.Add(this.label11);
            this.gbPermisionarios.Controls.Add(this.label10);
            this.gbPermisionarios.Controls.Add(this.txtPcelular);
            this.gbPermisionarios.Controls.Add(this.txtPtelefono);
            this.gbPermisionarios.Controls.Add(this.txtPrfc);
            this.gbPermisionarios.Controls.Add(this.txtPdireccion);
            this.gbPermisionarios.Controls.Add(this.txtPnombre);
            this.gbPermisionarios.Controls.Add(this.label7);
            this.gbPermisionarios.Controls.Add(this.label6);
            this.gbPermisionarios.Controls.Add(this.label5);
            this.gbPermisionarios.Controls.Add(this.label4);
            this.gbPermisionarios.Controls.Add(this.label3);
            this.gbPermisionarios.Location = new System.Drawing.Point(34, 384);
            this.gbPermisionarios.Name = "gbPermisionarios";
            this.gbPermisionarios.Size = new System.Drawing.Size(856, 213);
            this.gbPermisionarios.TabIndex = 6;
            this.gbPermisionarios.TabStop = false;
            this.gbPermisionarios.Text = "Datos del Permisionario";
            // 
            // cmbPestado
            // 
            this.cmbPestado.FormattingEnabled = true;
            this.cmbPestado.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.cmbPestado.Location = new System.Drawing.Point(450, 75);
            this.cmbPestado.Name = "cmbPestado";
            this.cmbPestado.Size = new System.Drawing.Size(148, 22);
            this.cmbPestado.TabIndex = 97;
            // 
            // cmbPlvigente
            // 
            this.cmbPlvigente.FormattingEnabled = true;
            this.cmbPlvigente.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbPlvigente.Location = new System.Drawing.Point(450, 23);
            this.cmbPlvigente.Name = "cmbPlvigente";
            this.cmbPlvigente.Size = new System.Drawing.Size(104, 22);
            this.cmbPlvigente.TabIndex = 96;
            // 
            // btnPcancelar
            // 
            this.btnPcancelar.FlatAppearance.BorderSize = 0;
            this.btnPcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnPcancelar.Image")));
            this.btnPcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPcancelar.Location = new System.Drawing.Point(655, 114);
            this.btnPcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPcancelar.Name = "btnPcancelar";
            this.btnPcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnPcancelar.TabIndex = 95;
            this.btnPcancelar.Text = "Cancelar";
            this.btnPcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPcancelar.UseVisualStyleBackColor = true;
            // 
            // btnPguardar
            // 
            this.btnPguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPguardar.FlatAppearance.BorderSize = 0;
            this.btnPguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnPguardar.Image")));
            this.btnPguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPguardar.Location = new System.Drawing.Point(655, 36);
            this.btnPguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPguardar.Name = "btnPguardar";
            this.btnPguardar.Size = new System.Drawing.Size(115, 40);
            this.btnPguardar.TabIndex = 94;
            this.btnPguardar.Text = "Guardar";
            this.btnPguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPguardar.UseVisualStyleBackColor = true;
            // 
            // dtpPfactualizacion
            // 
            this.dtpPfactualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPfactualizacion.Location = new System.Drawing.Point(451, 153);
            this.dtpPfactualizacion.Name = "dtpPfactualizacion";
            this.dtpPfactualizacion.Size = new System.Drawing.Size(104, 22);
            this.dtpPfactualizacion.TabIndex = 33;
            // 
            // dtpPfalta
            // 
            this.dtpPfalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPfalta.Location = new System.Drawing.Point(451, 127);
            this.dtpPfalta.Name = "dtpPfalta";
            this.dtpPfalta.Size = new System.Drawing.Size(103, 22);
            this.dtpPfalta.TabIndex = 32;
            // 
            // dtpPfadmision
            // 
            this.dtpPfadmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPfadmision.Location = new System.Drawing.Point(451, 101);
            this.dtpPfadmision.Name = "dtpPfadmision";
            this.dtpPfadmision.Size = new System.Drawing.Size(103, 22);
            this.dtpPfadmision.TabIndex = 31;
            // 
            // cmbPtipo
            // 
            this.cmbPtipo.FormattingEnabled = true;
            this.cmbPtipo.Items.AddRange(new object[] {
            "Taxi Ejecutivo",
            "Taxi Tradicional",
            "Taxi Radio"});
            this.cmbPtipo.Location = new System.Drawing.Point(451, 49);
            this.cmbPtipo.Name = "cmbPtipo";
            this.cmbPtipo.Size = new System.Drawing.Size(148, 22);
            this.cmbPtipo.TabIndex = 9;
            // 
            // txtPnumero
            // 
            this.txtPnumero.Location = new System.Drawing.Point(138, 21);
            this.txtPnumero.Name = "txtPnumero";
            this.txtPnumero.Size = new System.Drawing.Size(103, 22);
            this.txtPnumero.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Numero:";
            // 
            // txtPemail
            // 
            this.txtPemail.Location = new System.Drawing.Point(138, 177);
            this.txtPemail.Name = "txtPemail";
            this.txtPemail.Size = new System.Drawing.Size(181, 22);
            this.txtPemail.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "Fecha de Actualización:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "Fecha de Alta:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha de Admisión:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Licencia Vigente :";
            // 
            // txtPcelular
            // 
            this.txtPcelular.Location = new System.Drawing.Point(138, 151);
            this.txtPcelular.Name = "txtPcelular";
            this.txtPcelular.Size = new System.Drawing.Size(103, 22);
            this.txtPcelular.TabIndex = 7;
            // 
            // txtPtelefono
            // 
            this.txtPtelefono.Location = new System.Drawing.Point(138, 125);
            this.txtPtelefono.Name = "txtPtelefono";
            this.txtPtelefono.Size = new System.Drawing.Size(105, 22);
            this.txtPtelefono.TabIndex = 6;
            // 
            // txtPrfc
            // 
            this.txtPrfc.Location = new System.Drawing.Point(138, 99);
            this.txtPrfc.Name = "txtPrfc";
            this.txtPrfc.Size = new System.Drawing.Size(104, 22);
            this.txtPrfc.TabIndex = 5;
            // 
            // txtPdireccion
            // 
            this.txtPdireccion.Location = new System.Drawing.Point(138, 73);
            this.txtPdireccion.Name = "txtPdireccion";
            this.txtPdireccion.Size = new System.Drawing.Size(181, 22);
            this.txtPdireccion.TabIndex = 4;
            // 
            // txtPnombre
            // 
            this.txtPnombre.Location = new System.Drawing.Point(138, 47);
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(181, 22);
            this.txtPnombre.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tel. Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "RFC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgVehiculos);
            this.groupBox2.Controls.Add(this.btnPeditar);
            this.groupBox2.Controls.Add(this.btnPregresar);
            this.groupBox2.Controls.Add(this.chbPermisionarios);
            this.groupBox2.Controls.Add(this.btnPnuevo);
            this.groupBox2.Controls.Add(this.btnPfiltrar);
            this.groupBox2.Controls.Add(this.txtPfiltro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 359);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // dtgVehiculos
            // 
            this.dtgVehiculos.AllowUserToAddRows = false;
            this.dtgVehiculos.AllowUserToDeleteRows = false;
            this.dtgVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculos.Location = new System.Drawing.Point(11, 82);
            this.dtgVehiculos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgVehiculos.Name = "dtgVehiculos";
            this.dtgVehiculos.ReadOnly = true;
            this.dtgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVehiculos.Size = new System.Drawing.Size(839, 246);
            this.dtgVehiculos.TabIndex = 100;
            // 
            // btnPeditar
            // 
            this.btnPeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeditar.FlatAppearance.BorderSize = 0;
            this.btnPeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeditar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeditar.Image")));
            this.btnPeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeditar.Location = new System.Drawing.Point(567, 30);
            this.btnPeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeditar.Name = "btnPeditar";
            this.btnPeditar.Size = new System.Drawing.Size(152, 40);
            this.btnPeditar.TabIndex = 98;
            this.btnPeditar.Text = "Editar Permisionario";
            this.btnPeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeditar.UseVisualStyleBackColor = true;
            // 
            // btnPregresar
            // 
            this.btnPregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPregresar.FlatAppearance.BorderSize = 0;
            this.btnPregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnPregresar.Image")));
            this.btnPregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregresar.Location = new System.Drawing.Point(742, 30);
            this.btnPregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPregresar.Name = "btnPregresar";
            this.btnPregresar.Size = new System.Drawing.Size(98, 40);
            this.btnPregresar.TabIndex = 99;
            this.btnPregresar.Text = "Regresar";
            this.btnPregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPregresar.UseVisualStyleBackColor = true;
            this.btnPregresar.Click += new System.EventHandler(this.btnPregresar_Click);
            // 
            // chbPermisionarios
            // 
            this.chbPermisionarios.AutoSize = true;
            this.chbPermisionarios.Location = new System.Drawing.Point(662, 335);
            this.chbPermisionarios.Name = "chbPermisionarios";
            this.chbPermisionarios.Size = new System.Drawing.Size(188, 18);
            this.chbPermisionarios.TabIndex = 15;
            this.chbPermisionarios.Text = "Mostrar todos los Permisionarios";
            this.chbPermisionarios.UseVisualStyleBackColor = true;
            // 
            // btnPnuevo
            // 
            this.btnPnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPnuevo.FlatAppearance.BorderSize = 0;
            this.btnPnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnPnuevo.Image")));
            this.btnPnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPnuevo.Location = new System.Drawing.Point(382, 30);
            this.btnPnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPnuevo.Name = "btnPnuevo";
            this.btnPnuevo.Size = new System.Drawing.Size(157, 40);
            this.btnPnuevo.TabIndex = 97;
            this.btnPnuevo.Text = "Nuevo Permisionario";
            this.btnPnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPnuevo.UseVisualStyleBackColor = true;
            // 
            // btnPfiltrar
            // 
            this.btnPfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPfiltrar.FlatAppearance.BorderSize = 0;
            this.btnPfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnPfiltrar.Image")));
            this.btnPfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPfiltrar.Location = new System.Drawing.Point(237, 30);
            this.btnPfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPfiltrar.Name = "btnPfiltrar";
            this.btnPfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnPfiltrar.TabIndex = 96;
            this.btnPfiltrar.Text = "Limpiar Filtro";
            this.btnPfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPfiltrar.UseVisualStyleBackColor = true;
            // 
            // txtPfiltro
            // 
            this.txtPfiltro.Location = new System.Drawing.Point(62, 40);
            this.txtPfiltro.Name = "txtPfiltro";
            this.txtPfiltro.Size = new System.Drawing.Size(136, 22);
            this.txtPfiltro.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro:";
            // 
            // FrmPermisionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPermisionarios);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPermisionarios";
            this.Text = "UTVNS.- Gestion de Permisionarios del Sistema";
            this.Load += new System.EventHandler(this.FrmPermisionarios_Load);
            this.gbPermisionarios.ResumeLayout(false);
            this.gbPermisionarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPermisionarios;
        private System.Windows.Forms.TextBox txtPemail;
        private System.Windows.Forms.TextBox txtPcelular;
        private System.Windows.Forms.TextBox txtPtelefono;
        private System.Windows.Forms.TextBox txtPrfc;
        private System.Windows.Forms.TextBox txtPdireccion;
        private System.Windows.Forms.TextBox txtPnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPnumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPtipo;
        private System.Windows.Forms.DateTimePicker dtpPfactualizacion;
        private System.Windows.Forms.DateTimePicker dtpPfalta;
        private System.Windows.Forms.DateTimePicker dtpPfadmision;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbPermisionarios;
        private System.Windows.Forms.TextBox txtPfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPcancelar;
        private System.Windows.Forms.Button btnPguardar;
        private System.Windows.Forms.Button btnPeditar;
        private System.Windows.Forms.Button btnPregresar;
        private System.Windows.Forms.Button btnPnuevo;
        private System.Windows.Forms.Button btnPfiltrar;
        private System.Windows.Forms.DataGridView dtgVehiculos;
        private System.Windows.Forms.ComboBox cmbPlvigente;
        private System.Windows.Forms.ComboBox cmbPestado;
    }
}