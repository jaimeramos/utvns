﻿namespace Principal
{
    partial class FrmMecanicos
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
            this.gbMecanicos = new System.Windows.Forms.GroupBox();
            this.dtgMecanico = new System.Windows.Forms.DataGridView();
            this.chbPermisionarios = new System.Windows.Forms.CheckBox();
            this.txtMfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosmecanico = new System.Windows.Forms.GroupBox();
            this.gbPtipo = new System.Windows.Forms.GroupBox();
            this.chbMinactivo = new System.Windows.Forms.CheckBox();
            this.chbMactivo = new System.Windows.Forms.CheckBox();
            this.txtMapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpMfadmision = new System.Windows.Forms.DateTimePicker();
            this.txtMnumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMcelular = new System.Windows.Forms.TextBox();
            this.txtMtelefono = new System.Windows.Forms.TextBox();
            this.txtMdireccion = new System.Windows.Forms.TextBox();
            this.txtMnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMeditar = new System.Windows.Forms.Button();
            this.btnMregresar = new System.Windows.Forms.Button();
            this.btnMnuevo = new System.Windows.Forms.Button();
            this.btnMfiltrar = new System.Windows.Forms.Button();
            this.btnMcancelar = new System.Windows.Forms.Button();
            this.btnMguardar = new System.Windows.Forms.Button();
            this.gbMecanicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMecanico)).BeginInit();
            this.gbDatosmecanico.SuspendLayout();
            this.gbPtipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMecanicos
            // 
            this.gbMecanicos.Controls.Add(this.dtgMecanico);
            this.gbMecanicos.Controls.Add(this.btnMeditar);
            this.gbMecanicos.Controls.Add(this.btnMregresar);
            this.gbMecanicos.Controls.Add(this.chbPermisionarios);
            this.gbMecanicos.Controls.Add(this.btnMnuevo);
            this.gbMecanicos.Controls.Add(this.btnMfiltrar);
            this.gbMecanicos.Controls.Add(this.txtMfiltro);
            this.gbMecanicos.Controls.Add(this.label1);
            this.gbMecanicos.Location = new System.Drawing.Point(12, 12);
            this.gbMecanicos.Name = "gbMecanicos";
            this.gbMecanicos.Size = new System.Drawing.Size(796, 359);
            this.gbMecanicos.TabIndex = 11;
            this.gbMecanicos.TabStop = false;
            // 
            // dtgMecanico
            // 
            this.dtgMecanico.AllowUserToAddRows = false;
            this.dtgMecanico.AllowUserToDeleteRows = false;
            this.dtgMecanico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMecanico.Location = new System.Drawing.Point(11, 82);
            this.dtgMecanico.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgMecanico.Name = "dtgMecanico";
            this.dtgMecanico.ReadOnly = true;
            this.dtgMecanico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMecanico.Size = new System.Drawing.Size(761, 246);
            this.dtgMecanico.TabIndex = 6;
            // 
            // chbPermisionarios
            // 
            this.chbPermisionarios.AutoSize = true;
            this.chbPermisionarios.Location = new System.Drawing.Point(605, 335);
            this.chbPermisionarios.Name = "chbPermisionarios";
            this.chbPermisionarios.Size = new System.Drawing.Size(167, 18);
            this.chbPermisionarios.TabIndex = 5;
            this.chbPermisionarios.Text = "Mostrar todos los Mecanicos";
            this.chbPermisionarios.UseVisualStyleBackColor = true;
            // 
            // txtMfiltro
            // 
            this.txtMfiltro.Location = new System.Drawing.Point(62, 40);
            this.txtMfiltro.Name = "txtMfiltro";
            this.txtMfiltro.Size = new System.Drawing.Size(136, 22);
            this.txtMfiltro.TabIndex = 0;
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
            // gbDatosmecanico
            // 
            this.gbDatosmecanico.Controls.Add(this.gbPtipo);
            this.gbDatosmecanico.Controls.Add(this.txtMapellido);
            this.gbDatosmecanico.Controls.Add(this.label2);
            this.gbDatosmecanico.Controls.Add(this.btnMcancelar);
            this.gbDatosmecanico.Controls.Add(this.btnMguardar);
            this.gbDatosmecanico.Controls.Add(this.dtpMfadmision);
            this.gbDatosmecanico.Controls.Add(this.txtMnumero);
            this.gbDatosmecanico.Controls.Add(this.label15);
            this.gbDatosmecanico.Controls.Add(this.txtMemail);
            this.gbDatosmecanico.Controls.Add(this.label8);
            this.gbDatosmecanico.Controls.Add(this.label11);
            this.gbDatosmecanico.Controls.Add(this.txtMcelular);
            this.gbDatosmecanico.Controls.Add(this.txtMtelefono);
            this.gbDatosmecanico.Controls.Add(this.txtMdireccion);
            this.gbDatosmecanico.Controls.Add(this.txtMnombre);
            this.gbDatosmecanico.Controls.Add(this.label7);
            this.gbDatosmecanico.Controls.Add(this.label6);
            this.gbDatosmecanico.Controls.Add(this.label4);
            this.gbDatosmecanico.Controls.Add(this.label3);
            this.gbDatosmecanico.Location = new System.Drawing.Point(12, 391);
            this.gbDatosmecanico.Name = "gbDatosmecanico";
            this.gbDatosmecanico.Size = new System.Drawing.Size(796, 170);
            this.gbDatosmecanico.TabIndex = 10;
            this.gbDatosmecanico.TabStop = false;
            this.gbDatosmecanico.Text = "Datos del Mecanico";
            // 
            // gbPtipo
            // 
            this.gbPtipo.Controls.Add(this.chbMinactivo);
            this.gbPtipo.Controls.Add(this.chbMactivo);
            this.gbPtipo.Location = new System.Drawing.Point(532, 29);
            this.gbPtipo.Name = "gbPtipo";
            this.gbPtipo.Size = new System.Drawing.Size(120, 99);
            this.gbPtipo.TabIndex = 104;
            this.gbPtipo.TabStop = false;
            // 
            // chbMinactivo
            // 
            this.chbMinactivo.AutoSize = true;
            this.chbMinactivo.Location = new System.Drawing.Point(29, 57);
            this.chbMinactivo.Name = "chbMinactivo";
            this.chbMinactivo.Size = new System.Drawing.Size(65, 18);
            this.chbMinactivo.TabIndex = 1;
            this.chbMinactivo.Text = "Inactivo";
            this.chbMinactivo.UseVisualStyleBackColor = true;
            // 
            // chbMactivo
            // 
            this.chbMactivo.AutoSize = true;
            this.chbMactivo.Location = new System.Drawing.Point(29, 17);
            this.chbMactivo.Name = "chbMactivo";
            this.chbMactivo.Size = new System.Drawing.Size(57, 18);
            this.chbMactivo.TabIndex = 0;
            this.chbMactivo.Text = "Activo";
            this.chbMactivo.UseVisualStyleBackColor = true;
            // 
            // txtMapellido
            // 
            this.txtMapellido.Location = new System.Drawing.Point(74, 88);
            this.txtMapellido.Name = "txtMapellido";
            this.txtMapellido.Size = new System.Drawing.Size(141, 22);
            this.txtMapellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Apellido:";
            // 
            // dtpMfadmision
            // 
            this.dtpMfadmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMfadmision.Location = new System.Drawing.Point(359, 117);
            this.dtpMfadmision.Name = "dtpMfadmision";
            this.dtpMfadmision.Size = new System.Drawing.Size(130, 22);
            this.dtpMfadmision.TabIndex = 11;
            // 
            // txtMnumero
            // 
            this.txtMnumero.Location = new System.Drawing.Point(74, 32);
            this.txtMnumero.Name = "txtMnumero";
            this.txtMnumero.Size = new System.Drawing.Size(83, 22);
            this.txtMnumero.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Numero:";
            // 
            // txtMemail
            // 
            this.txtMemail.Location = new System.Drawing.Point(359, 87);
            this.txtMemail.Name = "txtMemail";
            this.txtMemail.Size = new System.Drawing.Size(156, 22);
            this.txtMemail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha de Admisión:";
            // 
            // txtMcelular
            // 
            this.txtMcelular.Location = new System.Drawing.Point(359, 57);
            this.txtMcelular.Name = "txtMcelular";
            this.txtMcelular.Size = new System.Drawing.Size(103, 22);
            this.txtMcelular.TabIndex = 6;
            // 
            // txtMtelefono
            // 
            this.txtMtelefono.Location = new System.Drawing.Point(359, 27);
            this.txtMtelefono.Name = "txtMtelefono";
            this.txtMtelefono.Size = new System.Drawing.Size(105, 22);
            this.txtMtelefono.TabIndex = 5;
            // 
            // txtMdireccion
            // 
            this.txtMdireccion.Location = new System.Drawing.Point(74, 116);
            this.txtMdireccion.Name = "txtMdireccion";
            this.txtMdireccion.Size = new System.Drawing.Size(156, 22);
            this.txtMdireccion.TabIndex = 3;
            // 
            // txtMnombre
            // 
            this.txtMnombre.Location = new System.Drawing.Point(74, 59);
            this.txtMnombre.Name = "txtMnombre";
            this.txtMnombre.Size = new System.Drawing.Size(141, 22);
            this.txtMnombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tel. Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // btnMeditar
            // 
            this.btnMeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeditar.FlatAppearance.BorderSize = 0;
            this.btnMeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeditar.Location = new System.Drawing.Point(483, 30);
            this.btnMeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMeditar.Name = "btnMeditar";
            this.btnMeditar.Size = new System.Drawing.Size(126, 40);
            this.btnMeditar.TabIndex = 3;
            this.btnMeditar.Text = "Editar Mecanico";
            this.btnMeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMeditar.UseVisualStyleBackColor = true;
            // 
            // btnMregresar
            // 
            this.btnMregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMregresar.FlatAppearance.BorderSize = 0;
            this.btnMregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMregresar.Location = new System.Drawing.Point(613, 30);
            this.btnMregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMregresar.Name = "btnMregresar";
            this.btnMregresar.Size = new System.Drawing.Size(98, 40);
            this.btnMregresar.TabIndex = 4;
            this.btnMregresar.Text = "Regresar";
            this.btnMregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMregresar.UseVisualStyleBackColor = true;
            // 
            // btnMnuevo
            // 
            this.btnMnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMnuevo.FlatAppearance.BorderSize = 0;
            this.btnMnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMnuevo.Location = new System.Drawing.Point(342, 30);
            this.btnMnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMnuevo.Name = "btnMnuevo";
            this.btnMnuevo.Size = new System.Drawing.Size(130, 40);
            this.btnMnuevo.TabIndex = 2;
            this.btnMnuevo.Text = "Nuevo Mecanico";
            this.btnMnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMnuevo.UseVisualStyleBackColor = true;
            // 
            // btnMfiltrar
            // 
            this.btnMfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMfiltrar.FlatAppearance.BorderSize = 0;
            this.btnMfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMfiltrar.Location = new System.Drawing.Point(220, 30);
            this.btnMfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMfiltrar.Name = "btnMfiltrar";
            this.btnMfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnMfiltrar.TabIndex = 1;
            this.btnMfiltrar.Text = "Limpiar Filtro";
            this.btnMfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMfiltrar.UseVisualStyleBackColor = true;
            // 
            // btnMcancelar
            // 
            this.btnMcancelar.FlatAppearance.BorderSize = 0;
            this.btnMcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMcancelar.Location = new System.Drawing.Point(670, 94);
            this.btnMcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMcancelar.Name = "btnMcancelar";
            this.btnMcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnMcancelar.TabIndex = 15;
            this.btnMcancelar.Text = "Cancelar";
            this.btnMcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMcancelar.UseVisualStyleBackColor = true;
            // 
            // btnMguardar
            // 
            this.btnMguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMguardar.FlatAppearance.BorderSize = 0;
            this.btnMguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMguardar.Location = new System.Drawing.Point(670, 35);
            this.btnMguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMguardar.Name = "btnMguardar";
            this.btnMguardar.Size = new System.Drawing.Size(115, 40);
            this.btnMguardar.TabIndex = 14;
            this.btnMguardar.Text = "Guardar";
            this.btnMguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMguardar.UseVisualStyleBackColor = true;
            // 
            // FrmMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 581);
            this.Controls.Add(this.gbMecanicos);
            this.Controls.Add(this.gbDatosmecanico);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMecanicos";
            this.Text = "FrmMecanicos";
            this.gbMecanicos.ResumeLayout(false);
            this.gbMecanicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMecanico)).EndInit();
            this.gbDatosmecanico.ResumeLayout(false);
            this.gbDatosmecanico.PerformLayout();
            this.gbPtipo.ResumeLayout(false);
            this.gbPtipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMecanicos;
        private System.Windows.Forms.DataGridView dtgMecanico;
        private System.Windows.Forms.Button btnMeditar;
        private System.Windows.Forms.Button btnMregresar;
        private System.Windows.Forms.CheckBox chbPermisionarios;
        private System.Windows.Forms.Button btnMnuevo;
        private System.Windows.Forms.Button btnMfiltrar;
        private System.Windows.Forms.TextBox txtMfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosmecanico;
        private System.Windows.Forms.GroupBox gbPtipo;
        private System.Windows.Forms.CheckBox chbMinactivo;
        private System.Windows.Forms.CheckBox chbMactivo;
        private System.Windows.Forms.TextBox txtMapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMcancelar;
        private System.Windows.Forms.Button btnMguardar;
        private System.Windows.Forms.DateTimePicker dtpMfadmision;
        private System.Windows.Forms.TextBox txtMnumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMcelular;
        private System.Windows.Forms.TextBox txtMtelefono;
        private System.Windows.Forms.TextBox txtMdireccion;
        private System.Windows.Forms.TextBox txtMnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}