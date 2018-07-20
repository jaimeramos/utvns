namespace Principal
{
    partial class FrmDetalledeingresos
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
            this.gbBitacora = new System.Windows.Forms.GroupBox();
            this.txtDIfiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDIfiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDIregresar = new System.Windows.Forms.Button();
            this.dtgDetalledeingreso = new System.Windows.Forms.DataGridView();
            this.gbBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalledeingreso)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBitacora
            // 
            this.gbBitacora.Controls.Add(this.txtDIfiltro);
            this.gbBitacora.Controls.Add(this.checkBox1);
            this.gbBitacora.Controls.Add(this.btnDIfiltrar);
            this.gbBitacora.Controls.Add(this.label1);
            this.gbBitacora.Controls.Add(this.btnDIregresar);
            this.gbBitacora.Controls.Add(this.dtgDetalledeingreso);
            this.gbBitacora.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBitacora.Location = new System.Drawing.Point(12, 12);
            this.gbBitacora.Name = "gbBitacora";
            this.gbBitacora.Size = new System.Drawing.Size(781, 527);
            this.gbBitacora.TabIndex = 30;
            this.gbBitacora.TabStop = false;
            // 
            // txtDIfiltro
            // 
            this.txtDIfiltro.Location = new System.Drawing.Point(72, 22);
            this.txtDIfiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDIfiltro.Name = "txtDIfiltro";
            this.txtDIfiltro.Size = new System.Drawing.Size(164, 23);
            this.txtDIfiltro.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(525, 492);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(228, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los detalles de Ingreso";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDIfiltrar
            // 
            this.btnDIfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDIfiltrar.FlatAppearance.BorderSize = 0;
            this.btnDIfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDIfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDIfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDIfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDIfiltrar.Location = new System.Drawing.Point(266, 11);
            this.btnDIfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDIfiltrar.Name = "btnDIfiltrar";
            this.btnDIfiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnDIfiltrar.TabIndex = 21;
            this.btnDIfiltrar.Text = "Limpiar filtro";
            this.btnDIfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDIfiltrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtrar:";
            // 
            // btnDIregresar
            // 
            this.btnDIregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDIregresar.FlatAppearance.BorderSize = 0;
            this.btnDIregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDIregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDIregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDIregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDIregresar.Location = new System.Drawing.Point(423, 11);
            this.btnDIregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDIregresar.Name = "btnDIregresar";
            this.btnDIregresar.Size = new System.Drawing.Size(98, 43);
            this.btnDIregresar.TabIndex = 24;
            this.btnDIregresar.Text = "Regresar";
            this.btnDIregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDIregresar.UseVisualStyleBackColor = true;
            // 
            // dtgDetalledeingreso
            // 
            this.dtgDetalledeingreso.AllowUserToAddRows = false;
            this.dtgDetalledeingreso.AllowUserToDeleteRows = false;
            this.dtgDetalledeingreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDetalledeingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalledeingreso.Location = new System.Drawing.Point(23, 72);
            this.dtgDetalledeingreso.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgDetalledeingreso.Name = "dtgDetalledeingreso";
            this.dtgDetalledeingreso.ReadOnly = true;
            this.dtgDetalledeingreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalledeingreso.Size = new System.Drawing.Size(740, 413);
            this.dtgDetalledeingreso.TabIndex = 25;
            // 
            // FrmDetalledeingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 561);
            this.Controls.Add(this.gbBitacora);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalledeingreso";
            this.Text = "Frmdetalledeingreso";
            this.gbBitacora.ResumeLayout(false);
            this.gbBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalledeingreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBitacora;
        private System.Windows.Forms.TextBox txtDIfiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDIfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDIregresar;
        private System.Windows.Forms.DataGridView dtgDetalledeingreso;
    }
}