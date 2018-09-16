namespace Principal
{
    partial class FrmEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEgresos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEtipo = new System.Windows.Forms.ComboBox();
            this.dtpEfecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEreferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdescripcion = new System.Windows.Forms.TextBox();
            this.btnEcancelar = new System.Windows.Forms.Button();
            this.btnEguardar = new System.Windows.Forms.Button();
            this.txtEfolio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEfiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEfiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnuevo = new System.Windows.Forms.Button();
            this.btnEeditar = new System.Windows.Forms.Button();
            this.btnEregresar = new System.Windows.Forms.Button();
            this.dtgPermiso = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermiso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEtipo);
            this.groupBox2.Controls.Add(this.dtpEfecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEcantidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEreferencia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEdescripcion);
            this.groupBox2.Controls.Add(this.btnEcancelar);
            this.groupBox2.Controls.Add(this.btnEguardar);
            this.groupBox2.Controls.Add(this.txtEfolio);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 152);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Permisos";
            // 
            // cmbEtipo
            // 
            this.cmbEtipo.FormattingEnabled = true;
            this.cmbEtipo.Location = new System.Drawing.Point(380, 31);
            this.cmbEtipo.Name = "cmbEtipo";
            this.cmbEtipo.Size = new System.Drawing.Size(140, 23);
            this.cmbEtipo.TabIndex = 127;
            // 
            // dtpEfecha
            // 
            this.dtpEfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEfecha.Location = new System.Drawing.Point(380, 93);
            this.dtpEfecha.Name = "dtpEfecha";
            this.dtpEfecha.Size = new System.Drawing.Size(120, 23);
            this.dtpEfecha.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 122;
            this.label6.Text = "Fecha:";
            // 
            // txtEcantidad
            // 
            this.txtEcantidad.Location = new System.Drawing.Point(380, 62);
            this.txtEcantidad.Name = "txtEcantidad";
            this.txtEcantidad.Size = new System.Drawing.Size(102, 23);
            this.txtEcantidad.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 120;
            this.label5.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 116;
            this.label3.Text = "Tipo:";
            // 
            // txtEreferencia
            // 
            this.txtEreferencia.Location = new System.Drawing.Point(99, 114);
            this.txtEreferencia.Name = "txtEreferencia";
            this.txtEreferencia.Size = new System.Drawing.Size(180, 23);
            this.txtEreferencia.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 114;
            this.label2.Text = "Referencia:";
            // 
            // txtEdescripcion
            // 
            this.txtEdescripcion.Location = new System.Drawing.Point(99, 60);
            this.txtEdescripcion.Multiline = true;
            this.txtEdescripcion.Name = "txtEdescripcion";
            this.txtEdescripcion.Size = new System.Drawing.Size(180, 46);
            this.txtEdescripcion.TabIndex = 113;
            // 
            // btnEcancelar
            // 
            this.btnEcancelar.FlatAppearance.BorderSize = 0;
            this.btnEcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEcancelar.Location = new System.Drawing.Point(632, 92);
            this.btnEcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEcancelar.Name = "btnEcancelar";
            this.btnEcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnEcancelar.TabIndex = 111;
            this.btnEcancelar.Text = "Cancelar";
            this.btnEcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEcancelar.UseVisualStyleBackColor = true;
            // 
            // btnEguardar
            // 
            this.btnEguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEguardar.FlatAppearance.BorderSize = 0;
            this.btnEguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEguardar.Location = new System.Drawing.Point(632, 35);
            this.btnEguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEguardar.Name = "btnEguardar";
            this.btnEguardar.Size = new System.Drawing.Size(115, 40);
            this.btnEguardar.TabIndex = 110;
            this.btnEguardar.Text = "Guardar";
            this.btnEguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEguardar.UseVisualStyleBackColor = true;
            // 
            // txtEfolio
            // 
            this.txtEfolio.Location = new System.Drawing.Point(99, 29);
            this.txtEfolio.Name = "txtEfolio";
            this.txtEfolio.Size = new System.Drawing.Size(89, 23);
            this.txtEfolio.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Folio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEfiltro);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnEfiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEnuevo);
            this.groupBox1.Controls.Add(this.btnEeditar);
            this.groupBox1.Controls.Add(this.btnEregresar);
            this.groupBox1.Controls.Add(this.dtgPermiso);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 370);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // txtEfiltro
            // 
            this.txtEfiltro.Location = new System.Drawing.Point(72, 22);
            this.txtEfiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtEfiltro.Name = "txtEfiltro";
            this.txtEfiltro.Size = new System.Drawing.Size(148, 23);
            this.txtEfiltro.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(583, 346);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los Egresos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEfiltrar
            // 
            this.btnEfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEfiltrar.FlatAppearance.BorderSize = 0;
            this.btnEfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEfiltrar.Location = new System.Drawing.Point(232, 14);
            this.btnEfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEfiltrar.Name = "btnEfiltrar";
            this.btnEfiltrar.Size = new System.Drawing.Size(125, 43);
            this.btnEfiltrar.TabIndex = 21;
            this.btnEfiltrar.Text = "Limpiar filtro";
            this.btnEfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEfiltrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtro:";
            // 
            // btnEnuevo
            // 
            this.btnEnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnuevo.FlatAppearance.BorderSize = 0;
            this.btnEnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnuevo.Location = new System.Drawing.Point(372, 14);
            this.btnEnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEnuevo.Name = "btnEnuevo";
            this.btnEnuevo.Size = new System.Drawing.Size(121, 43);
            this.btnEnuevo.TabIndex = 22;
            this.btnEnuevo.Text = "Nuevo Egreso";
            this.btnEnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnuevo.UseVisualStyleBackColor = true;
            // 
            // btnEeditar
            // 
            this.btnEeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEeditar.FlatAppearance.BorderSize = 0;
            this.btnEeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEeditar.Location = new System.Drawing.Point(508, 14);
            this.btnEeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEeditar.Name = "btnEeditar";
            this.btnEeditar.Size = new System.Drawing.Size(132, 43);
            this.btnEeditar.TabIndex = 23;
            this.btnEeditar.Text = "Editar Egreso";
            this.btnEeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEeditar.UseVisualStyleBackColor = true;
            // 
            // btnEregresar
            // 
            this.btnEregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEregresar.FlatAppearance.BorderSize = 0;
            this.btnEregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEregresar.Location = new System.Drawing.Point(655, 14);
            this.btnEregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEregresar.Name = "btnEregresar";
            this.btnEregresar.Size = new System.Drawing.Size(98, 43);
            this.btnEregresar.TabIndex = 24;
            this.btnEregresar.Text = "Regresar";
            this.btnEregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEregresar.UseVisualStyleBackColor = true;
            // 
            // dtgPermiso
            // 
            this.dtgPermiso.AllowUserToAddRows = false;
            this.dtgPermiso.AllowUserToDeleteRows = false;
            this.dtgPermiso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermiso.Location = new System.Drawing.Point(23, 72);
            this.dtgPermiso.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgPermiso.Name = "dtgPermiso";
            this.dtgPermiso.ReadOnly = true;
            this.dtgPermiso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermiso.Size = new System.Drawing.Size(730, 267);
            this.dtgPermiso.TabIndex = 25;
            // 
            // FrmEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEgresos";
            this.Text = "FrmEgresos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEreferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdescripcion;
        private System.Windows.Forms.Button btnEcancelar;
        private System.Windows.Forms.Button btnEguardar;
        private System.Windows.Forms.TextBox txtEfolio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEfiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnEfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnuevo;
        private System.Windows.Forms.Button btnEeditar;
        private System.Windows.Forms.Button btnEregresar;
        private System.Windows.Forms.DataGridView dtgPermiso;
        private System.Windows.Forms.ComboBox cmbEtipo;
    }
}