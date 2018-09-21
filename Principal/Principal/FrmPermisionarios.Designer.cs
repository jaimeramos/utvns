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
            this.gbDatospermisionario = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.txtPlicencia = new System.Windows.Forms.TextBox();
            this.dtpPvigencia = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPcancelar = new System.Windows.Forms.Button();
            this.btnPguardar = new System.Windows.Forms.Button();
            this.dtpPfadmision = new System.Windows.Forms.DateTimePicker();
            this.cmbPtipo = new System.Windows.Forms.ComboBox();
            this.txtPnumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPemail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.gbPermisionarios = new System.Windows.Forms.GroupBox();
            this.dtgPermisionario = new System.Windows.Forms.DataGridView();
            this.btnPeditar = new System.Windows.Forms.Button();
            this.btnPregresar = new System.Windows.Forms.Button();
            this.chbPermisionarios = new System.Windows.Forms.CheckBox();
            this.btnPnuevo = new System.Windows.Forms.Button();
            this.btnPfiltrar = new System.Windows.Forms.Button();
            this.txtPfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatospermisionario.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbPermisionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatospermisionario
            // 
            this.gbDatospermisionario.Controls.Add(this.gbStatus);
            this.gbDatospermisionario.Controls.Add(this.txtPlicencia);
            this.gbDatospermisionario.Controls.Add(this.dtpPvigencia);
            this.gbDatospermisionario.Controls.Add(this.label12);
            this.gbDatospermisionario.Controls.Add(this.txtPapellido);
            this.gbDatospermisionario.Controls.Add(this.label2);
            this.gbDatospermisionario.Controls.Add(this.btnPcancelar);
            this.gbDatospermisionario.Controls.Add(this.btnPguardar);
            this.gbDatospermisionario.Controls.Add(this.dtpPfadmision);
            this.gbDatospermisionario.Controls.Add(this.cmbPtipo);
            this.gbDatospermisionario.Controls.Add(this.txtPnumero);
            this.gbDatospermisionario.Controls.Add(this.label15);
            this.gbDatospermisionario.Controls.Add(this.txtPemail);
            this.gbDatospermisionario.Controls.Add(this.label9);
            this.gbDatospermisionario.Controls.Add(this.label8);
            this.gbDatospermisionario.Controls.Add(this.label11);
            this.gbDatospermisionario.Controls.Add(this.label10);
            this.gbDatospermisionario.Controls.Add(this.txtPcelular);
            this.gbDatospermisionario.Controls.Add(this.txtPtelefono);
            this.gbDatospermisionario.Controls.Add(this.txtPrfc);
            this.gbDatospermisionario.Controls.Add(this.txtPdireccion);
            this.gbDatospermisionario.Controls.Add(this.txtPnombre);
            this.gbDatospermisionario.Controls.Add(this.label7);
            this.gbDatospermisionario.Controls.Add(this.label6);
            this.gbDatospermisionario.Controls.Add(this.label5);
            this.gbDatospermisionario.Controls.Add(this.label4);
            this.gbDatospermisionario.Controls.Add(this.label3);
            this.gbDatospermisionario.Location = new System.Drawing.Point(23, 377);
            this.gbDatospermisionario.Name = "gbDatospermisionario";
            this.gbDatospermisionario.Size = new System.Drawing.Size(885, 168);
            this.gbDatospermisionario.TabIndex = 6;
            this.gbDatospermisionario.TabStop = false;
            this.gbDatospermisionario.Text = "Datos del Permisionario";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactivo);
            this.gbStatus.Controls.Add(this.rbActivo);
            this.gbStatus.Location = new System.Drawing.Point(457, 94);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(242, 64);
            this.gbStatus.TabIndex = 116;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(154, 21);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(64, 18);
            this.rbInactivo.TabIndex = 115;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(50, 21);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(56, 18);
            this.rbActivo.TabIndex = 114;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // txtPlicencia
            // 
            this.txtPlicencia.Location = new System.Drawing.Point(294, 134);
            this.txtPlicencia.Name = "txtPlicencia";
            this.txtPlicencia.Size = new System.Drawing.Size(156, 22);
            this.txtPlicencia.TabIndex = 9;
            // 
            // dtpPvigencia
            // 
            this.dtpPvigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPvigencia.Location = new System.Drawing.Point(569, 25);
            this.dtpPvigencia.Name = "dtpPvigencia";
            this.dtpPvigencia.Size = new System.Drawing.Size(130, 22);
            this.dtpPvigencia.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 14);
            this.label12.TabIndex = 102;
            this.label12.Text = "Vigencia de Licencia:";
            // 
            // txtPapellido
            // 
            this.txtPapellido.Location = new System.Drawing.Point(63, 77);
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(156, 22);
            this.txtPapellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Apellido:";
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
            this.btnPcancelar.Location = new System.Drawing.Point(741, 104);
            this.btnPcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPcancelar.Name = "btnPcancelar";
            this.btnPcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnPcancelar.TabIndex = 15;
            this.btnPcancelar.Text = "Cancelar";
            this.btnPcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPcancelar.UseVisualStyleBackColor = true;
            this.btnPcancelar.Click += new System.EventHandler(this.btnPcancelar_Click);
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
            this.btnPguardar.Location = new System.Drawing.Point(741, 37);
            this.btnPguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPguardar.Name = "btnPguardar";
            this.btnPguardar.Size = new System.Drawing.Size(115, 40);
            this.btnPguardar.TabIndex = 14;
            this.btnPguardar.Text = "Guardar";
            this.btnPguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPguardar.UseVisualStyleBackColor = true;
            this.btnPguardar.Click += new System.EventHandler(this.btnPguardar_Click);
            // 
            // dtpPfadmision
            // 
            this.dtpPfadmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPfadmision.Location = new System.Drawing.Point(569, 57);
            this.dtpPfadmision.Name = "dtpPfadmision";
            this.dtpPfadmision.Size = new System.Drawing.Size(130, 22);
            this.dtpPfadmision.TabIndex = 11;
            // 
            // cmbPtipo
            // 
            this.cmbPtipo.FormattingEnabled = true;
            this.cmbPtipo.Location = new System.Drawing.Point(294, 106);
            this.cmbPtipo.Name = "cmbPtipo";
            this.cmbPtipo.Size = new System.Drawing.Size(156, 22);
            this.cmbPtipo.TabIndex = 8;
            // 
            // txtPnumero
            // 
            this.txtPnumero.Location = new System.Drawing.Point(63, 21);
            this.txtPnumero.Name = "txtPnumero";
            this.txtPnumero.Size = new System.Drawing.Size(156, 22);
            this.txtPnumero.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Número:";
            // 
            // txtPemail
            // 
            this.txtPemail.Location = new System.Drawing.Point(294, 78);
            this.txtPemail.Name = "txtPemail";
            this.txtPemail.Size = new System.Drawing.Size(156, 22);
            this.txtPemail.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha de Admisión:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Licencia :";
            // 
            // txtPcelular
            // 
            this.txtPcelular.Location = new System.Drawing.Point(294, 50);
            this.txtPcelular.Name = "txtPcelular";
            this.txtPcelular.Size = new System.Drawing.Size(156, 22);
            this.txtPcelular.TabIndex = 6;
            // 
            // txtPtelefono
            // 
            this.txtPtelefono.Location = new System.Drawing.Point(294, 22);
            this.txtPtelefono.Name = "txtPtelefono";
            this.txtPtelefono.Size = new System.Drawing.Size(156, 22);
            this.txtPtelefono.TabIndex = 5;
            // 
            // txtPrfc
            // 
            this.txtPrfc.Location = new System.Drawing.Point(63, 133);
            this.txtPrfc.Name = "txtPrfc";
            this.txtPrfc.Size = new System.Drawing.Size(156, 22);
            this.txtPrfc.TabIndex = 4;
            // 
            // txtPdireccion
            // 
            this.txtPdireccion.Location = new System.Drawing.Point(63, 105);
            this.txtPdireccion.Name = "txtPdireccion";
            this.txtPdireccion.Size = new System.Drawing.Size(156, 22);
            this.txtPdireccion.TabIndex = 3;
            // 
            // txtPnombre
            // 
            this.txtPnombre.Location = new System.Drawing.Point(63, 49);
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(156, 22);
            this.txtPnombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tel. Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "RFC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // gbPermisionarios
            // 
            this.gbPermisionarios.Controls.Add(this.dtgPermisionario);
            this.gbPermisionarios.Controls.Add(this.btnPeditar);
            this.gbPermisionarios.Controls.Add(this.btnPregresar);
            this.gbPermisionarios.Controls.Add(this.chbPermisionarios);
            this.gbPermisionarios.Controls.Add(this.btnPnuevo);
            this.gbPermisionarios.Controls.Add(this.btnPfiltrar);
            this.gbPermisionarios.Controls.Add(this.txtPfiltro);
            this.gbPermisionarios.Controls.Add(this.label1);
            this.gbPermisionarios.Location = new System.Drawing.Point(23, 4);
            this.gbPermisionarios.Name = "gbPermisionarios";
            this.gbPermisionarios.Size = new System.Drawing.Size(885, 359);
            this.gbPermisionarios.TabIndex = 9;
            this.gbPermisionarios.TabStop = false;
            this.gbPermisionarios.Text = "Registro de Socios/Permisionarios ";
            // 
            // dtgPermisionario
            // 
            this.dtgPermisionario.AllowUserToAddRows = false;
            this.dtgPermisionario.AllowUserToDeleteRows = false;
            this.dtgPermisionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPermisionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisionario.Location = new System.Drawing.Point(5, 82);
            this.dtgPermisionario.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgPermisionario.Name = "dtgPermisionario";
            this.dtgPermisionario.ReadOnly = true;
            this.dtgPermisionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisionario.Size = new System.Drawing.Size(875, 246);
            this.dtgPermisionario.TabIndex = 6;
            this.dtgPermisionario.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisionario_RowEnter);
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
            this.btnPeditar.Location = new System.Drawing.Point(600, 24);
            this.btnPeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeditar.Name = "btnPeditar";
            this.btnPeditar.Size = new System.Drawing.Size(152, 40);
            this.btnPeditar.TabIndex = 3;
            this.btnPeditar.Text = "Editar Permisionario";
            this.btnPeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeditar.UseVisualStyleBackColor = true;
            this.btnPeditar.Click += new System.EventHandler(this.btnPeditar_Click);
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
            this.btnPregresar.Location = new System.Drawing.Point(777, 24);
            this.btnPregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPregresar.Name = "btnPregresar";
            this.btnPregresar.Size = new System.Drawing.Size(98, 40);
            this.btnPregresar.TabIndex = 4;
            this.btnPregresar.Text = "Regresar";
            this.btnPregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPregresar.UseVisualStyleBackColor = true;
            this.btnPregresar.Click += new System.EventHandler(this.btnPregresar_Click);
            // 
            // chbPermisionarios
            // 
            this.chbPermisionarios.AutoSize = true;
            this.chbPermisionarios.Location = new System.Drawing.Point(593, 335);
            this.chbPermisionarios.Name = "chbPermisionarios";
            this.chbPermisionarios.Size = new System.Drawing.Size(188, 18);
            this.chbPermisionarios.TabIndex = 5;
            this.chbPermisionarios.Text = "Mostrar todos los permisionarios";
            this.chbPermisionarios.UseVisualStyleBackColor = true;
            this.chbPermisionarios.CheckedChanged += new System.EventHandler(this.chbPermisionarios_CheckedChanged);
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
            this.btnPnuevo.Location = new System.Drawing.Point(418, 24);
            this.btnPnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPnuevo.Name = "btnPnuevo";
            this.btnPnuevo.Size = new System.Drawing.Size(157, 40);
            this.btnPnuevo.TabIndex = 2;
            this.btnPnuevo.Text = "Nuevo Permisionario";
            this.btnPnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPnuevo.UseVisualStyleBackColor = true;
            this.btnPnuevo.Click += new System.EventHandler(this.btnPnuevo_Click);
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
            this.btnPfiltrar.Location = new System.Drawing.Point(259, 24);
            this.btnPfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPfiltrar.Name = "btnPfiltrar";
            this.btnPfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnPfiltrar.TabIndex = 1;
            this.btnPfiltrar.Text = "Limpiar Filtro";
            this.btnPfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPfiltrar.UseVisualStyleBackColor = true;
            this.btnPfiltrar.Click += new System.EventHandler(this.btnPfiltrar_Click);
            // 
            // txtPfiltro
            // 
            this.txtPfiltro.Location = new System.Drawing.Point(51, 33);
            this.txtPfiltro.Name = "txtPfiltro";
            this.txtPfiltro.Size = new System.Drawing.Size(203, 22);
            this.txtPfiltro.TabIndex = 0;
            this.txtPfiltro.TextChanged += new System.EventHandler(this.txtPfiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro:";
            // 
            // FrmPermisionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 557);
            this.Controls.Add(this.gbPermisionarios);
            this.Controls.Add(this.gbDatospermisionario);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPermisionarios";
            this.Text = "UTVNS.- Gestion de Permisionarios del Sistema";
            this.Load += new System.EventHandler(this.FrmPermisionarios_Load);
            this.gbDatospermisionario.ResumeLayout(false);
            this.gbDatospermisionario.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbPermisionarios.ResumeLayout(false);
            this.gbPermisionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatospermisionario;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPnumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbPtipo;
        private System.Windows.Forms.DateTimePicker dtpPfadmision;
        private System.Windows.Forms.GroupBox gbPermisionarios;
        private System.Windows.Forms.CheckBox chbPermisionarios;
        private System.Windows.Forms.TextBox txtPfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPcancelar;
        private System.Windows.Forms.Button btnPguardar;
        private System.Windows.Forms.Button btnPeditar;
        private System.Windows.Forms.Button btnPregresar;
        private System.Windows.Forms.Button btnPnuevo;
        private System.Windows.Forms.Button btnPfiltrar;
        private System.Windows.Forms.DataGridView dtgPermisionario;
        private System.Windows.Forms.TextBox txtPapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPvigencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlicencia;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
    }
}