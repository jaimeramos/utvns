namespace Principal
{
    partial class FrmOutcomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutcomes));
            this.gbDatosForm = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBussinesline = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPcancelar = new System.Windows.Forms.Button();
            this.btnPguardar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDatosGrid = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnPeditar = new System.Windows.Forms.Button();
            this.btnPregresar = new System.Windows.Forms.Button();
            this.chbPermisionarios = new System.Windows.Forms.CheckBox();
            this.btnPnuevo = new System.Windows.Forms.Button();
            this.btnPfiltrar = new System.Windows.Forms.Button();
            this.txtPfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosForm.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbDatosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosForm
            // 
            this.gbDatosForm.Controls.Add(this.button1);
            this.gbDatosForm.Controls.Add(this.cmbBussinesline);
            this.gbDatosForm.Controls.Add(this.label4);
            this.gbDatosForm.Controls.Add(this.gbStatus);
            this.gbDatosForm.Controls.Add(this.dtpFecha);
            this.gbDatosForm.Controls.Add(this.label12);
            this.gbDatosForm.Controls.Add(this.txtReferencia);
            this.gbDatosForm.Controls.Add(this.label2);
            this.gbDatosForm.Controls.Add(this.btnPcancelar);
            this.gbDatosForm.Controls.Add(this.btnPguardar);
            this.gbDatosForm.Controls.Add(this.cmbTipo);
            this.gbDatosForm.Controls.Add(this.txtFolio);
            this.gbDatosForm.Controls.Add(this.label15);
            this.gbDatosForm.Controls.Add(this.label9);
            this.gbDatosForm.Controls.Add(this.txtMonto);
            this.gbDatosForm.Controls.Add(this.txtDescripcion);
            this.gbDatosForm.Controls.Add(this.label5);
            this.gbDatosForm.Controls.Add(this.label3);
            this.gbDatosForm.Location = new System.Drawing.Point(23, 377);
            this.gbDatosForm.Name = "gbDatosForm";
            this.gbDatosForm.Size = new System.Drawing.Size(885, 179);
            this.gbDatosForm.TabIndex = 6;
            this.gbDatosForm.TabStop = false;
            this.gbDatosForm.Text = "Datos del Egreso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 119;
            this.button1.Text = "Buscar línea de negocio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBussinesline
            // 
            this.cmbBussinesline.FormattingEnabled = true;
            this.cmbBussinesline.Location = new System.Drawing.Point(122, 147);
            this.cmbBussinesline.Name = "cmbBussinesline";
            this.cmbBussinesline.Size = new System.Drawing.Size(301, 22);
            this.cmbBussinesline.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 14);
            this.label4.TabIndex = 118;
            this.label4.Text = "Línea de negocio:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactivo);
            this.gbStatus.Controls.Add(this.rbActivo);
            this.gbStatus.Location = new System.Drawing.Point(458, 95);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(225, 49);
            this.gbStatus.TabIndex = 116;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(134, 21);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(64, 18);
            this.rbInactivo.TabIndex = 8;
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
            this.rbActivo.TabIndex = 7;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(527, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(156, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(455, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 14);
            this.label12.TabIndex = 102;
            this.label12.Text = "Fecha:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(122, 89);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(301, 22);
            this.txtReferencia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Referencia:";
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
            this.btnPcancelar.TabIndex = 10;
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
            this.btnPguardar.TabIndex = 9;
            this.btnPguardar.Text = "Guardar";
            this.btnPguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPguardar.UseVisualStyleBackColor = true;
            this.btnPguardar.Click += new System.EventHandler(this.btnPguardar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(122, 118);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(156, 22);
            this.cmbTipo.TabIndex = 3;
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(122, 31);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(156, 22);
            this.txtFolio.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Folio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(527, 30);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(156, 22);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(301, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción:";
            // 
            // gbDatosGrid
            // 
            this.gbDatosGrid.Controls.Add(this.dataGrid);
            this.gbDatosGrid.Controls.Add(this.btnPeditar);
            this.gbDatosGrid.Controls.Add(this.btnPregresar);
            this.gbDatosGrid.Controls.Add(this.chbPermisionarios);
            this.gbDatosGrid.Controls.Add(this.btnPnuevo);
            this.gbDatosGrid.Controls.Add(this.btnPfiltrar);
            this.gbDatosGrid.Controls.Add(this.txtPfiltro);
            this.gbDatosGrid.Controls.Add(this.label1);
            this.gbDatosGrid.Location = new System.Drawing.Point(23, 4);
            this.gbDatosGrid.Name = "gbDatosGrid";
            this.gbDatosGrid.Size = new System.Drawing.Size(885, 359);
            this.gbDatosGrid.TabIndex = 9;
            this.gbDatosGrid.TabStop = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(5, 66);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(875, 262);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter_1);
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
            this.btnPeditar.Location = new System.Drawing.Point(644, 19);
            this.btnPeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeditar.Name = "btnPeditar";
            this.btnPeditar.Size = new System.Drawing.Size(109, 40);
            this.btnPeditar.TabIndex = 3;
            this.btnPeditar.Text = "Editar Egreso";
            this.btnPeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnPregresar.Location = new System.Drawing.Point(777, 19);
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
            this.chbPermisionarios.Size = new System.Drawing.Size(153, 18);
            this.chbPermisionarios.TabIndex = 5;
            this.chbPermisionarios.Text = "Mostrar todos los egresos";
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
            this.btnPnuevo.Location = new System.Drawing.Point(504, 19);
            this.btnPnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPnuevo.Name = "btnPnuevo";
            this.btnPnuevo.Size = new System.Drawing.Size(116, 40);
            this.btnPnuevo.TabIndex = 2;
            this.btnPnuevo.Text = "Nuevo Egreso";
            this.btnPnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnPfiltrar.Location = new System.Drawing.Point(260, 19);
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
            this.txtPfiltro.Location = new System.Drawing.Point(62, 29);
            this.txtPfiltro.Name = "txtPfiltro";
            this.txtPfiltro.Size = new System.Drawing.Size(193, 22);
            this.txtPfiltro.TabIndex = 0;
            this.txtPfiltro.TextChanged += new System.EventHandler(this.txtPfiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro:";
            // 
            // FrmOutcomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 565);
            this.Controls.Add(this.gbDatosGrid);
            this.Controls.Add(this.gbDatosForm);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOutcomes";
            this.Text = "UTVNS.- Gestion de Permisionarios del Sistema";
            this.Load += new System.EventHandler(this.FrmOutcomes_Load);
            this.gbDatosForm.ResumeLayout(false);
            this.gbDatosForm.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbDatosGrid.ResumeLayout(false);
            this.gbDatosGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatosForm;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox gbDatosGrid;
        private System.Windows.Forms.CheckBox chbPermisionarios;
        private System.Windows.Forms.TextBox txtPfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPcancelar;
        private System.Windows.Forms.Button btnPguardar;
        private System.Windows.Forms.Button btnPeditar;
        private System.Windows.Forms.Button btnPregresar;
        private System.Windows.Forms.Button btnPnuevo;
        private System.Windows.Forms.Button btnPfiltrar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.ComboBox cmbBussinesline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}