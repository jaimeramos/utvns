namespace Principal
{
    partial class FrmPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisos));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeeditar = new System.Windows.Forms.Button();
            this.dtgPermiso = new System.Windows.Forms.DataGridView();
            this.btnPeregresar = new System.Windows.Forms.Button();
            this.txtPefiltro = new System.Windows.Forms.TextBox();
            this.btnPenuevo = new System.Windows.Forms.Button();
            this.btnPefiltrar = new System.Windows.Forms.Button();
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.gbdatospermisos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPermitholder = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.btnPecancelar = new System.Windows.Forms.Button();
            this.btnPeguardar = new System.Windows.Forms.Button();
            this.txtPenpermisionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPevencimiento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPetipo = new System.Windows.Forms.ComboBox();
            this.txtPenumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPedescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermiso)).BeginInit();
            this.gbPermisos.SuspendLayout();
            this.gbdatospermisos.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(507, 345);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los Permisos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtro:";
            // 
            // btnPeeditar
            // 
            this.btnPeeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeeditar.FlatAppearance.BorderSize = 0;
            this.btnPeeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeeditar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeeditar.Image")));
            this.btnPeeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeeditar.Location = new System.Drawing.Point(527, 12);
            this.btnPeeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeeditar.Name = "btnPeeditar";
            this.btnPeeditar.Size = new System.Drawing.Size(136, 43);
            this.btnPeeditar.TabIndex = 23;
            this.btnPeeditar.Text = "Editar Permiso";
            this.btnPeeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeeditar.UseVisualStyleBackColor = true;
            this.btnPeeditar.Click += new System.EventHandler(this.btnPeeditar_Click);
            // 
            // dtgPermiso
            // 
            this.dtgPermiso.AllowUserToAddRows = false;
            this.dtgPermiso.AllowUserToDeleteRows = false;
            this.dtgPermiso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermiso.Location = new System.Drawing.Point(5, 62);
            this.dtgPermiso.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgPermiso.Name = "dtgPermiso";
            this.dtgPermiso.ReadOnly = true;
            this.dtgPermiso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermiso.Size = new System.Drawing.Size(771, 277);
            this.dtgPermiso.TabIndex = 25;
            this.dtgPermiso.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermiso_RowEnter);
            // 
            // btnPeregresar
            // 
            this.btnPeregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeregresar.FlatAppearance.BorderSize = 0;
            this.btnPeregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeregresar.Image")));
            this.btnPeregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeregresar.Location = new System.Drawing.Point(675, 12);
            this.btnPeregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeregresar.Name = "btnPeregresar";
            this.btnPeregresar.Size = new System.Drawing.Size(98, 43);
            this.btnPeregresar.TabIndex = 24;
            this.btnPeregresar.Text = "Regresar";
            this.btnPeregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeregresar.UseVisualStyleBackColor = true;
            this.btnPeregresar.Click += new System.EventHandler(this.btnPeregresar_Click);
            // 
            // txtPefiltro
            // 
            this.txtPefiltro.Location = new System.Drawing.Point(50, 22);
            this.txtPefiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPefiltro.Name = "txtPefiltro";
            this.txtPefiltro.Size = new System.Drawing.Size(178, 23);
            this.txtPefiltro.TabIndex = 20;
            this.txtPefiltro.TextChanged += new System.EventHandler(this.txtPefiltro_TextChanged);
            // 
            // btnPenuevo
            // 
            this.btnPenuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPenuevo.FlatAppearance.BorderSize = 0;
            this.btnPenuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPenuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPenuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnPenuevo.Image")));
            this.btnPenuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenuevo.Location = new System.Drawing.Point(381, 12);
            this.btnPenuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPenuevo.Name = "btnPenuevo";
            this.btnPenuevo.Size = new System.Drawing.Size(134, 43);
            this.btnPenuevo.TabIndex = 22;
            this.btnPenuevo.Text = "Nuevo Permiso";
            this.btnPenuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPenuevo.UseVisualStyleBackColor = true;
            this.btnPenuevo.Click += new System.EventHandler(this.btnPenuevo_Click);
            // 
            // btnPefiltrar
            // 
            this.btnPefiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPefiltrar.FlatAppearance.BorderSize = 0;
            this.btnPefiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPefiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPefiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPefiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnPefiltrar.Image")));
            this.btnPefiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPefiltrar.Location = new System.Drawing.Point(232, 12);
            this.btnPefiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPefiltrar.Name = "btnPefiltrar";
            this.btnPefiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnPefiltrar.TabIndex = 21;
            this.btnPefiltrar.Text = "Limpiar filtro";
            this.btnPefiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPefiltrar.UseVisualStyleBackColor = true;
            this.btnPefiltrar.Click += new System.EventHandler(this.btnPefiltrar_Click);
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.txtPefiltro);
            this.gbPermisos.Controls.Add(this.checkBox1);
            this.gbPermisos.Controls.Add(this.btnPefiltrar);
            this.gbPermisos.Controls.Add(this.label1);
            this.gbPermisos.Controls.Add(this.btnPenuevo);
            this.gbPermisos.Controls.Add(this.btnPeeditar);
            this.gbPermisos.Controls.Add(this.btnPeregresar);
            this.gbPermisos.Controls.Add(this.dtgPermiso);
            this.gbPermisos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermisos.Location = new System.Drawing.Point(12, 12);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(781, 370);
            this.gbPermisos.TabIndex = 27;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Text = "Registro de Permisos ";
            // 
            // gbdatospermisos
            // 
            this.gbdatospermisos.Controls.Add(this.button1);
            this.gbdatospermisos.Controls.Add(this.cmbPermitholder);
            this.gbdatospermisos.Controls.Add(this.gbStatus);
            this.gbdatospermisos.Controls.Add(this.btnPecancelar);
            this.gbdatospermisos.Controls.Add(this.btnPeguardar);
            this.gbdatospermisos.Controls.Add(this.txtPenpermisionario);
            this.gbdatospermisos.Controls.Add(this.label2);
            this.gbdatospermisos.Controls.Add(this.dtpPevencimiento);
            this.gbdatospermisos.Controls.Add(this.label12);
            this.gbdatospermisos.Controls.Add(this.cmbPetipo);
            this.gbdatospermisos.Controls.Add(this.txtPenumero);
            this.gbdatospermisos.Controls.Add(this.label15);
            this.gbdatospermisos.Controls.Add(this.label9);
            this.gbdatospermisos.Controls.Add(this.txtPedescripcion);
            this.gbdatospermisos.Controls.Add(this.label4);
            this.gbdatospermisos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatospermisos.Location = new System.Drawing.Point(12, 388);
            this.gbdatospermisos.Name = "gbdatospermisos";
            this.gbdatospermisos.Size = new System.Drawing.Size(781, 156);
            this.gbdatospermisos.TabIndex = 28;
            this.gbdatospermisos.TabStop = false;
            this.gbdatospermisos.Text = "Datos del Permiso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPermitholder
            // 
            this.cmbPermitholder.FormattingEnabled = true;
            this.cmbPermitholder.Location = new System.Drawing.Point(341, 33);
            this.cmbPermitholder.Name = "cmbPermitholder";
            this.cmbPermitholder.Size = new System.Drawing.Size(184, 23);
            this.cmbPermitholder.TabIndex = 3;
            this.cmbPermitholder.SelectedIndexChanged += new System.EventHandler(this.cmbPermitholder_SelectedIndexChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactivo);
            this.gbStatus.Controls.Add(this.rbActivo);
            this.gbStatus.Location = new System.Drawing.Point(499, 61);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(136, 42);
            this.gbStatus.TabIndex = 115;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(63, 14);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(67, 19);
            this.rbInactivo.TabIndex = 7;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(6, 15);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(59, 19);
            this.rbActivo.TabIndex = 6;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // btnPecancelar
            // 
            this.btnPecancelar.FlatAppearance.BorderSize = 0;
            this.btnPecancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPecancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPecancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnPecancelar.Image")));
            this.btnPecancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecancelar.Location = new System.Drawing.Point(649, 106);
            this.btnPecancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPecancelar.Name = "btnPecancelar";
            this.btnPecancelar.Size = new System.Drawing.Size(115, 40);
            this.btnPecancelar.TabIndex = 9;
            this.btnPecancelar.Text = "Cancelar";
            this.btnPecancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecancelar.UseVisualStyleBackColor = true;
            this.btnPecancelar.Click += new System.EventHandler(this.btnPecancelar_Click);
            // 
            // btnPeguardar
            // 
            this.btnPeguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeguardar.FlatAppearance.BorderSize = 0;
            this.btnPeguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeguardar.Image")));
            this.btnPeguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeguardar.Location = new System.Drawing.Point(649, 42);
            this.btnPeguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeguardar.Name = "btnPeguardar";
            this.btnPeguardar.Size = new System.Drawing.Size(115, 40);
            this.btnPeguardar.TabIndex = 8;
            this.btnPeguardar.Text = "Guardar";
            this.btnPeguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeguardar.UseVisualStyleBackColor = true;
            this.btnPeguardar.Click += new System.EventHandler(this.btnPeguardar_Click);
            // 
            // txtPenpermisionario
            // 
            this.txtPenpermisionario.Location = new System.Drawing.Point(349, 33);
            this.txtPenpermisionario.Name = "txtPenpermisionario";
            this.txtPenpermisionario.Size = new System.Drawing.Size(118, 23);
            this.txtPenpermisionario.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "Administrador:";
            // 
            // dtpPevencimiento
            // 
            this.dtpPevencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPevencimiento.Location = new System.Drawing.Point(341, 71);
            this.dtpPevencimiento.Name = "dtpPevencimiento";
            this.dtpPevencimiento.Size = new System.Drawing.Size(146, 23);
            this.dtpPevencimiento.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 104;
            this.label12.Text = "Fecha de Vencimiento:";
            // 
            // cmbPetipo
            // 
            this.cmbPetipo.FormattingEnabled = true;
            this.cmbPetipo.Location = new System.Drawing.Point(92, 71);
            this.cmbPetipo.Name = "cmbPetipo";
            this.cmbPetipo.Size = new System.Drawing.Size(114, 23);
            this.cmbPetipo.TabIndex = 1;
            // 
            // txtPenumero
            // 
            this.txtPenumero.Location = new System.Drawing.Point(92, 33);
            this.txtPenumero.Name = "txtPenumero";
            this.txtPenumero.Size = new System.Drawing.Size(114, 23);
            this.txtPenumero.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tipo:";
            // 
            // txtPedescripcion
            // 
            this.txtPedescripcion.Location = new System.Drawing.Point(92, 109);
            this.txtPedescripcion.Multiline = true;
            this.txtPedescripcion.Name = "txtPedescripcion";
            this.txtPedescripcion.Size = new System.Drawing.Size(543, 37);
            this.txtPedescripcion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descripción:";
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 553);
            this.Controls.Add(this.gbdatospermisos);
            this.Controls.Add(this.gbPermisos);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPermisos";
            this.Text = "FrmPermisos";
            this.Load += new System.EventHandler(this.FrmPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermiso)).EndInit();
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            this.gbdatospermisos.ResumeLayout(false);
            this.gbdatospermisos.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeeditar;
        private System.Windows.Forms.DataGridView dtgPermiso;
        private System.Windows.Forms.Button btnPeregresar;
        private System.Windows.Forms.TextBox txtPefiltro;
        private System.Windows.Forms.Button btnPenuevo;
        private System.Windows.Forms.Button btnPefiltrar;
        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.GroupBox gbdatospermisos;
        private System.Windows.Forms.ComboBox cmbPetipo;
        private System.Windows.Forms.TextBox txtPenumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPedescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPevencimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPenpermisionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPecancelar;
        private System.Windows.Forms.Button btnPeguardar;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.ComboBox cmbPermitholder;
        private System.Windows.Forms.Button button1;
    }
}