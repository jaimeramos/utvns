﻿namespace Principal
{
    partial class Buscarvehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscarvehiculos));
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.dtgVehiculo = new System.Windows.Forms.DataGridView();
            this.btnVeditar = new System.Windows.Forms.Button();
            this.txtPefiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnPefiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeregresar = new System.Windows.Forms.Button();
            this.gbPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.dtgVehiculo);
            this.gbPermisos.Controls.Add(this.btnVeditar);
            this.gbPermisos.Controls.Add(this.txtPefiltro);
            this.gbPermisos.Controls.Add(this.checkBox1);
            this.gbPermisos.Controls.Add(this.btnPefiltrar);
            this.gbPermisos.Controls.Add(this.label1);
            this.gbPermisos.Controls.Add(this.btnPeregresar);
            this.gbPermisos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermisos.Location = new System.Drawing.Point(7, 5);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(781, 370);
            this.gbPermisos.TabIndex = 30;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Text = "Selección de Vehículos ";
            // 
            // dtgVehiculo
            // 
            this.dtgVehiculo.AllowUserToAddRows = false;
            this.dtgVehiculo.AllowUserToDeleteRows = false;
            this.dtgVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculo.Location = new System.Drawing.Point(6, 69);
            this.dtgVehiculo.MultiSelect = false;
            this.dtgVehiculo.Name = "dtgVehiculo";
            this.dtgVehiculo.ReadOnly = true;
            this.dtgVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVehiculo.Size = new System.Drawing.Size(769, 270);
            this.dtgVehiculo.TabIndex = 94;
            this.dtgVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculo_CellContentClick);
            this.dtgVehiculo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculos_CellContentDoubleClick);
            this.dtgVehiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculo_CellDoubleClick);
            this.dtgVehiculo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculo_RowEnter);
            // 
            // btnVeditar
            // 
            this.btnVeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVeditar.FlatAppearance.BorderSize = 0;
            this.btnVeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeditar.Image = ((System.Drawing.Image)(resources.GetObject("btnVeditar.Image")));
            this.btnVeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeditar.Location = new System.Drawing.Point(524, 17);
            this.btnVeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVeditar.Name = "btnVeditar";
            this.btnVeditar.Size = new System.Drawing.Size(109, 40);
            this.btnVeditar.TabIndex = 93;
            this.btnVeditar.Text = "Seleccionar";
            this.btnVeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVeditar.UseVisualStyleBackColor = true;
            this.btnVeditar.Click += new System.EventHandler(this.btnVeditar_Click);
            // 
            // txtPefiltro
            // 
            this.txtPefiltro.Location = new System.Drawing.Point(72, 26);
            this.txtPefiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPefiltro.Name = "txtPefiltro";
            this.txtPefiltro.Size = new System.Drawing.Size(303, 23);
            this.txtPefiltro.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(560, 345);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los Vehículos.";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.btnPefiltrar.Location = new System.Drawing.Point(379, 16);
            this.btnPefiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPefiltrar.Name = "btnPefiltrar";
            this.btnPefiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnPefiltrar.TabIndex = 21;
            this.btnPefiltrar.Text = "Limpiar filtro";
            this.btnPefiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPefiltrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtro:";
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
            this.btnPeregresar.Location = new System.Drawing.Point(655, 16);
            this.btnPeregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeregresar.Name = "btnPeregresar";
            this.btnPeregresar.Size = new System.Drawing.Size(98, 43);
            this.btnPeregresar.TabIndex = 24;
            this.btnPeregresar.Text = "Regresar";
            this.btnPeregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeregresar.UseVisualStyleBackColor = true;
            this.btnPeregresar.Click += new System.EventHandler(this.btnPeregresar_Click);
            // 
            // Buscarvehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.gbPermisos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscarvehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscarvehiculos";
            this.Load += new System.EventHandler(this.Buscarvehiculos_Load);
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.DataGridView dtgVehiculo;
        private System.Windows.Forms.Button btnVeditar;
        private System.Windows.Forms.TextBox txtPefiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnPefiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeregresar;
    }
}