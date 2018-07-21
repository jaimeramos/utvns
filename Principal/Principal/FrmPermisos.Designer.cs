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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnPecancelar = new System.Windows.Forms.Button();
            this.btnPeguardar = new System.Windows.Forms.Button();
            this.txtPenpermisionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbPeactivo = new System.Windows.Forms.CheckBox();
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
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(594, 346);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los Permisos";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // btnPeeditar
            // 
            this.btnPeeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeeditar.FlatAppearance.BorderSize = 0;
            this.btnPeeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeeditar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeeditar.Image")));
            this.btnPeeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeeditar.Location = new System.Drawing.Point(507, 14);
            this.btnPeeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeeditar.Name = "btnPeeditar";
            this.btnPeeditar.Size = new System.Drawing.Size(136, 43);
            this.btnPeeditar.TabIndex = 23;
            this.btnPeeditar.Text = "Editar Permiso";
            this.btnPeeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeeditar.UseVisualStyleBackColor = true;
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
            // btnPeregresar
            // 
            this.btnPeregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeregresar.FlatAppearance.BorderSize = 0;
            this.btnPeregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeregresar.Image")));
            this.btnPeregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeregresar.Location = new System.Drawing.Point(655, 14);
            this.btnPeregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeregresar.Name = "btnPeregresar";
            this.btnPeregresar.Size = new System.Drawing.Size(98, 43);
            this.btnPeregresar.TabIndex = 24;
            this.btnPeregresar.Text = "Regresar";
            this.btnPeregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeregresar.UseVisualStyleBackColor = true;
            // 
            // txtPefiltro
            // 
            this.txtPefiltro.Location = new System.Drawing.Point(72, 22);
            this.txtPefiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPefiltro.Name = "txtPefiltro";
            this.txtPefiltro.Size = new System.Drawing.Size(148, 23);
            this.txtPefiltro.TabIndex = 20;
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
            this.btnPenuevo.Location = new System.Drawing.Point(361, 14);
            this.btnPenuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPenuevo.Name = "btnPenuevo";
            this.btnPenuevo.Size = new System.Drawing.Size(134, 43);
            this.btnPenuevo.TabIndex = 22;
            this.btnPenuevo.Text = "Nuevo Permiso";
            this.btnPenuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPenuevo.UseVisualStyleBackColor = true;
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
            this.btnPefiltrar.Location = new System.Drawing.Point(232, 14);
            this.btnPefiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPefiltrar.Name = "btnPefiltrar";
            this.btnPefiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnPefiltrar.TabIndex = 21;
            this.btnPefiltrar.Text = "Limpiar filtro";
            this.btnPefiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPefiltrar.UseVisualStyleBackColor = true;
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
            // 
            // gbdatospermisos
            // 
            this.gbdatospermisos.Controls.Add(this.checkBox2);
            this.gbdatospermisos.Controls.Add(this.btnPecancelar);
            this.gbdatospermisos.Controls.Add(this.btnPeguardar);
            this.gbdatospermisos.Controls.Add(this.txtPenpermisionario);
            this.gbdatospermisos.Controls.Add(this.label2);
            this.gbdatospermisos.Controls.Add(this.chbPeactivo);
            this.gbdatospermisos.Controls.Add(this.dtpPevencimiento);
            this.gbdatospermisos.Controls.Add(this.label12);
            this.gbdatospermisos.Controls.Add(this.cmbPetipo);
            this.gbdatospermisos.Controls.Add(this.txtPenumero);
            this.gbdatospermisos.Controls.Add(this.label15);
            this.gbdatospermisos.Controls.Add(this.label9);
            this.gbdatospermisos.Controls.Add(this.txtPedescripcion);
            this.gbdatospermisos.Controls.Add(this.label4);
            this.gbdatospermisos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatospermisos.Location = new System.Drawing.Point(18, 403);
            this.gbdatospermisos.Name = "gbdatospermisos";
            this.gbdatospermisos.Size = new System.Drawing.Size(781, 171);
            this.gbdatospermisos.TabIndex = 28;
            this.gbdatospermisos.TabStop = false;
            this.gbdatospermisos.Text = "Datos de Permisos";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(463, 121);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 19);
            this.checkBox2.TabIndex = 112;
            this.checkBox2.Text = "Inactivo";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            this.btnPecancelar.Location = new System.Drawing.Point(632, 99);
            this.btnPecancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPecancelar.Name = "btnPecancelar";
            this.btnPecancelar.Size = new System.Drawing.Size(115, 40);
            this.btnPecancelar.TabIndex = 111;
            this.btnPecancelar.Text = "Cancelar";
            this.btnPecancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecancelar.UseVisualStyleBackColor = true;
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
            this.btnPeguardar.Location = new System.Drawing.Point(632, 35);
            this.btnPeguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeguardar.Name = "btnPeguardar";
            this.btnPeguardar.Size = new System.Drawing.Size(115, 40);
            this.btnPeguardar.TabIndex = 110;
            this.btnPeguardar.Text = "Guardar";
            this.btnPeguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeguardar.UseVisualStyleBackColor = true;
            // 
            // txtPenpermisionario
            // 
            this.txtPenpermisionario.Location = new System.Drawing.Point(435, 72);
            this.txtPenpermisionario.Name = "txtPenpermisionario";
            this.txtPenpermisionario.Size = new System.Drawing.Size(118, 23);
            this.txtPenpermisionario.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "Numero de Permisionario:";
            // 
            // chbPeactivo
            // 
            this.chbPeactivo.AutoSize = true;
            this.chbPeactivo.Location = new System.Drawing.Point(385, 121);
            this.chbPeactivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chbPeactivo.Name = "chbPeactivo";
            this.chbPeactivo.Size = new System.Drawing.Size(60, 19);
            this.chbPeactivo.TabIndex = 106;
            this.chbPeactivo.Text = "Activo";
            this.chbPeactivo.UseVisualStyleBackColor = true;
            // 
            // dtpPevencimiento
            // 
            this.dtpPevencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPevencimiento.Location = new System.Drawing.Point(435, 35);
            this.dtpPevencimiento.Name = "dtpPevencimiento";
            this.dtpPevencimiento.Size = new System.Drawing.Size(118, 23);
            this.dtpPevencimiento.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 104;
            this.label12.Text = "Fecha de Vencimiento:";
            // 
            // cmbPetipo
            // 
            this.cmbPetipo.FormattingEnabled = true;
            this.cmbPetipo.Location = new System.Drawing.Point(96, 67);
            this.cmbPetipo.Name = "cmbPetipo";
            this.cmbPetipo.Size = new System.Drawing.Size(148, 23);
            this.cmbPetipo.TabIndex = 34;
            // 
            // txtPenumero
            // 
            this.txtPenumero.Location = new System.Drawing.Point(96, 31);
            this.txtPenumero.Name = "txtPenumero";
            this.txtPenumero.Size = new System.Drawing.Size(83, 23);
            this.txtPenumero.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tipo:";
            // 
            // txtPedescripcion
            // 
            this.txtPedescripcion.Location = new System.Drawing.Point(96, 107);
            this.txtPedescripcion.Multiline = true;
            this.txtPedescripcion.Name = "txtPedescripcion";
            this.txtPedescripcion.Size = new System.Drawing.Size(175, 41);
            this.txtPedescripcion.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descripción:";
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 586);
            this.Controls.Add(this.gbdatospermisos);
            this.Controls.Add(this.gbPermisos);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPermisos";
            this.Text = "FrmPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermiso)).EndInit();
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            this.gbdatospermisos.ResumeLayout(false);
            this.gbdatospermisos.PerformLayout();
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
        private System.Windows.Forms.CheckBox chbPeactivo;
        private System.Windows.Forms.TextBox txtPenpermisionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPecancelar;
        private System.Windows.Forms.Button btnPeguardar;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}