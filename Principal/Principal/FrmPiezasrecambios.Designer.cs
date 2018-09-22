namespace Principal
{
    partial class FrmPiezasrecambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPiezasrecambios));
            this.gbDatosGrid = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnPreditar = new System.Windows.Forms.Button();
            this.btnPrregresar = new System.Windows.Forms.Button();
            this.chbRecambios = new System.Windows.Forms.CheckBox();
            this.btnPrnuevo = new System.Windows.Forms.Button();
            this.btnPrfiltrar = new System.Windows.Forms.Button();
            this.txtPrfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosForm = new System.Windows.Forms.GroupBox();
            this.txtPrnumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrcosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVtcancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPrprecio = new System.Windows.Forms.TextBox();
            this.txtPrdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDatosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gbDatosForm.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosGrid
            // 
            this.gbDatosGrid.Controls.Add(this.dataGrid);
            this.gbDatosGrid.Controls.Add(this.btnPreditar);
            this.gbDatosGrid.Controls.Add(this.btnPrregresar);
            this.gbDatosGrid.Controls.Add(this.chbRecambios);
            this.gbDatosGrid.Controls.Add(this.btnPrnuevo);
            this.gbDatosGrid.Controls.Add(this.btnPrfiltrar);
            this.gbDatosGrid.Controls.Add(this.txtPrfiltro);
            this.gbDatosGrid.Controls.Add(this.label1);
            this.gbDatosGrid.Location = new System.Drawing.Point(19, 12);
            this.gbDatosGrid.Name = "gbDatosGrid";
            this.gbDatosGrid.Size = new System.Drawing.Size(710, 359);
            this.gbDatosGrid.TabIndex = 17;
            this.gbDatosGrid.TabStop = false;
            this.gbDatosGrid.Text = "Registro de Refacciones ";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(5, 61);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(700, 267);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            // 
            // btnPreditar
            // 
            this.btnPreditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreditar.FlatAppearance.BorderSize = 0;
            this.btnPreditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPreditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPreditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreditar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreditar.Image")));
            this.btnPreditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreditar.Location = new System.Drawing.Point(478, 14);
            this.btnPreditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreditar.Name = "btnPreditar";
            this.btnPreditar.Size = new System.Drawing.Size(124, 40);
            this.btnPreditar.TabIndex = 3;
            this.btnPreditar.Text = "Editar refacción";
            this.btnPreditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreditar.UseVisualStyleBackColor = true;
            this.btnPreditar.Click += new System.EventHandler(this.btnPreditar_Click);
            // 
            // btnPrregresar
            // 
            this.btnPrregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrregresar.FlatAppearance.BorderSize = 0;
            this.btnPrregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrregresar.Image")));
            this.btnPrregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrregresar.Location = new System.Drawing.Point(606, 14);
            this.btnPrregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrregresar.Name = "btnPrregresar";
            this.btnPrregresar.Size = new System.Drawing.Size(96, 40);
            this.btnPrregresar.TabIndex = 4;
            this.btnPrregresar.Text = "Regresar";
            this.btnPrregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrregresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrregresar.UseVisualStyleBackColor = true;
            this.btnPrregresar.Click += new System.EventHandler(this.btnPrregresar_Click);
            // 
            // chbRecambios
            // 
            this.chbRecambios.AutoSize = true;
            this.chbRecambios.Location = new System.Drawing.Point(532, 335);
            this.chbRecambios.Name = "chbRecambios";
            this.chbRecambios.Size = new System.Drawing.Size(171, 18);
            this.chbRecambios.TabIndex = 5;
            this.chbRecambios.Text = "Mostrar todas las refacciones";
            this.chbRecambios.UseVisualStyleBackColor = true;
            this.chbRecambios.CheckedChanged += new System.EventHandler(this.chbRecambios_CheckedChanged);
            // 
            // btnPrnuevo
            // 
            this.btnPrnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrnuevo.FlatAppearance.BorderSize = 0;
            this.btnPrnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnPrnuevo.Image")));
            this.btnPrnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrnuevo.Location = new System.Drawing.Point(347, 14);
            this.btnPrnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrnuevo.Name = "btnPrnuevo";
            this.btnPrnuevo.Size = new System.Drawing.Size(128, 40);
            this.btnPrnuevo.TabIndex = 2;
            this.btnPrnuevo.Text = "Nueva refacción";
            this.btnPrnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrnuevo.UseVisualStyleBackColor = true;
            this.btnPrnuevo.Click += new System.EventHandler(this.btnPrnuevo_Click);
            // 
            // btnPrfiltrar
            // 
            this.btnPrfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrfiltrar.FlatAppearance.BorderSize = 0;
            this.btnPrfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrfiltrar.Image")));
            this.btnPrfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrfiltrar.Location = new System.Drawing.Point(222, 14);
            this.btnPrfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrfiltrar.Name = "btnPrfiltrar";
            this.btnPrfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnPrfiltrar.TabIndex = 1;
            this.btnPrfiltrar.Text = "Limpiar Filtro";
            this.btnPrfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrfiltrar.UseVisualStyleBackColor = true;
            this.btnPrfiltrar.Click += new System.EventHandler(this.btnPrfiltrar_Click);
            // 
            // txtPrfiltro
            // 
            this.txtPrfiltro.Location = new System.Drawing.Point(49, 23);
            this.txtPrfiltro.Name = "txtPrfiltro";
            this.txtPrfiltro.Size = new System.Drawing.Size(136, 22);
            this.txtPrfiltro.TabIndex = 0;
            this.txtPrfiltro.TextChanged += new System.EventHandler(this.txtPrfiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro:";
            // 
            // gbDatosForm
            // 
            this.gbDatosForm.Controls.Add(this.txtPrnumero);
            this.gbDatosForm.Controls.Add(this.label15);
            this.gbDatosForm.Controls.Add(this.btnProveedor);
            this.gbDatosForm.Controls.Add(this.cmbProveedor);
            this.gbDatosForm.Controls.Add(this.gbStatus);
            this.gbDatosForm.Controls.Add(this.label6);
            this.gbDatosForm.Controls.Add(this.txtPrstock);
            this.gbDatosForm.Controls.Add(this.label5);
            this.gbDatosForm.Controls.Add(this.txtPrcosto);
            this.gbDatosForm.Controls.Add(this.label2);
            this.gbDatosForm.Controls.Add(this.btnVtcancelar);
            this.gbDatosForm.Controls.Add(this.btnGuardar);
            this.gbDatosForm.Controls.Add(this.txtPrprecio);
            this.gbDatosForm.Controls.Add(this.txtPrdescripcion);
            this.gbDatosForm.Controls.Add(this.label4);
            this.gbDatosForm.Controls.Add(this.label3);
            this.gbDatosForm.Location = new System.Drawing.Point(19, 381);
            this.gbDatosForm.Name = "gbDatosForm";
            this.gbDatosForm.Size = new System.Drawing.Size(710, 158);
            this.gbDatosForm.TabIndex = 16;
            this.gbDatosForm.TabStop = false;
            this.gbDatosForm.Text = "Datos de la Refacción";
            // 
            // txtPrnumero
            // 
            this.txtPrnumero.Location = new System.Drawing.Point(78, 32);
            this.txtPrnumero.Name = "txtPrnumero";
            this.txtPrnumero.Size = new System.Drawing.Size(159, 22);
            this.txtPrnumero.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 14);
            this.label15.TabIndex = 32;
            this.label15.Text = "Numero:";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(461, 60);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(101, 23);
            this.btnProveedor.TabIndex = 6;
            this.btnProveedor.Text = "Buscar proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(314, 60);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(141, 22);
            this.cmbProveedor.TabIndex = 5;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactivo);
            this.gbStatus.Controls.Add(this.rbActivo);
            this.gbStatus.Location = new System.Drawing.Point(253, 94);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(202, 50);
            this.gbStatus.TabIndex = 120;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(115, 21);
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
            this.rbActivo.Location = new System.Drawing.Point(31, 21);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(56, 18);
            this.rbActivo.TabIndex = 7;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 103;
            this.label6.Text = "Proveedor:";
            // 
            // txtPrstock
            // 
            this.txtPrstock.Location = new System.Drawing.Point(314, 32);
            this.txtPrstock.Name = "txtPrstock";
            this.txtPrstock.Size = new System.Drawing.Size(141, 22);
            this.txtPrstock.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 101;
            this.label5.Text = "Stock:";
            // 
            // txtPrcosto
            // 
            this.txtPrcosto.Location = new System.Drawing.Point(78, 91);
            this.txtPrcosto.Name = "txtPrcosto";
            this.txtPrcosto.Size = new System.Drawing.Size(159, 22);
            this.txtPrcosto.TabIndex = 2;
            this.txtPrcosto.TextChanged += new System.EventHandler(this.txtPrcosto_TextChanged);
            this.txtPrcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrcosto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Costo:";
            // 
            // btnVtcancelar
            // 
            this.btnVtcancelar.FlatAppearance.BorderSize = 0;
            this.btnVtcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVtcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVtcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVtcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVtcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnVtcancelar.Image")));
            this.btnVtcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtcancelar.Location = new System.Drawing.Point(568, 82);
            this.btnVtcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtcancelar.Name = "btnVtcancelar";
            this.btnVtcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnVtcancelar.TabIndex = 15;
            this.btnVtcancelar.Text = "Cancelar";
            this.btnVtcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtcancelar.UseVisualStyleBackColor = true;
            this.btnVtcancelar.Click += new System.EventHandler(this.btnVtcancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(568, 24);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 40);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPrprecio
            // 
            this.txtPrprecio.Location = new System.Drawing.Point(78, 122);
            this.txtPrprecio.Name = "txtPrprecio";
            this.txtPrprecio.Size = new System.Drawing.Size(159, 22);
            this.txtPrprecio.TabIndex = 3;
            this.txtPrprecio.TextChanged += new System.EventHandler(this.txtPrprecio_TextChanged);
            this.txtPrprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrprecio_KeyPress);
            // 
            // txtPrdescripcion
            // 
            this.txtPrdescripcion.Location = new System.Drawing.Point(78, 60);
            this.txtPrdescripcion.Name = "txtPrdescripcion";
            this.txtPrdescripcion.Size = new System.Drawing.Size(159, 22);
            this.txtPrdescripcion.TabIndex = 1;
            this.txtPrdescripcion.TextChanged += new System.EventHandler(this.txtPrdescripcion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción:";
            // 
            // FrmPiezasrecambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 544);
            this.Controls.Add(this.gbDatosGrid);
            this.Controls.Add(this.gbDatosForm);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPiezasrecambios";
            this.Text = "FrmPiezasrecambio";
            this.Load += new System.EventHandler(this.FrmPiezasrecambios_Load);
            this.gbDatosGrid.ResumeLayout(false);
            this.gbDatosGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gbDatosForm.ResumeLayout(false);
            this.gbDatosForm.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosGrid;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnPreditar;
        private System.Windows.Forms.Button btnPrregresar;
        private System.Windows.Forms.CheckBox chbRecambios;
        private System.Windows.Forms.Button btnPrnuevo;
        private System.Windows.Forms.Button btnPrfiltrar;
        private System.Windows.Forms.TextBox txtPrfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosForm;
        private System.Windows.Forms.TextBox txtPrcosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVtcancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPrprecio;
        private System.Windows.Forms.TextBox txtPrdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.TextBox txtPrnumero;
        private System.Windows.Forms.Label label15;
    }
}