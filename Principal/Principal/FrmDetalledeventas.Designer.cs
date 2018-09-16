namespace Principal
{
    partial class FrmDetalledeventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalledeventas));
            this.gbDetalleventa = new System.Windows.Forms.GroupBox();
            this.txtDvfiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDvfiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDvregresar = new System.Windows.Forms.Button();
            this.dtgDetalledeventa = new System.Windows.Forms.DataGridView();
            this.gbDetalleventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalledeventa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalleventa
            // 
            this.gbDetalleventa.Controls.Add(this.txtDvfiltro);
            this.gbDetalleventa.Controls.Add(this.checkBox1);
            this.gbDetalleventa.Controls.Add(this.btnDvfiltrar);
            this.gbDetalleventa.Controls.Add(this.label1);
            this.gbDetalleventa.Controls.Add(this.btnDvregresar);
            this.gbDetalleventa.Controls.Add(this.dtgDetalledeventa);
            this.gbDetalleventa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleventa.Location = new System.Drawing.Point(12, 12);
            this.gbDetalleventa.Name = "gbDetalleventa";
            this.gbDetalleventa.Size = new System.Drawing.Size(781, 527);
            this.gbDetalleventa.TabIndex = 31;
            this.gbDetalleventa.TabStop = false;
            // 
            // txtDvfiltro
            // 
            this.txtDvfiltro.Location = new System.Drawing.Point(72, 22);
            this.txtDvfiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDvfiltro.Name = "txtDvfiltro";
            this.txtDvfiltro.Size = new System.Drawing.Size(164, 23);
            this.txtDvfiltro.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(525, 492);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(225, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los detalles de Ventas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDvfiltrar
            // 
            this.btnDvfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDvfiltrar.FlatAppearance.BorderSize = 0;
            this.btnDvfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDvfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDvfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDvfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDvfiltrar.Location = new System.Drawing.Point(266, 11);
            this.btnDvfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDvfiltrar.Name = "btnDvfiltrar";
            this.btnDvfiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnDvfiltrar.TabIndex = 21;
            this.btnDvfiltrar.Text = "Limpiar filtro";
            this.btnDvfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDvfiltrar.UseVisualStyleBackColor = true;
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
            // btnDvregresar
            // 
            this.btnDvregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDvregresar.FlatAppearance.BorderSize = 0;
            this.btnDvregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDvregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDvregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDvregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDvregresar.Location = new System.Drawing.Point(423, 11);
            this.btnDvregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDvregresar.Name = "btnDvregresar";
            this.btnDvregresar.Size = new System.Drawing.Size(98, 43);
            this.btnDvregresar.TabIndex = 24;
            this.btnDvregresar.Text = "Regresar";
            this.btnDvregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDvregresar.UseVisualStyleBackColor = true;
            // 
            // dtgDetalledeventa
            // 
            this.dtgDetalledeventa.AllowUserToAddRows = false;
            this.dtgDetalledeventa.AllowUserToDeleteRows = false;
            this.dtgDetalledeventa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDetalledeventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalledeventa.Location = new System.Drawing.Point(23, 72);
            this.dtgDetalledeventa.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgDetalledeventa.Name = "dtgDetalledeventa";
            this.dtgDetalledeventa.ReadOnly = true;
            this.dtgDetalledeventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalledeventa.Size = new System.Drawing.Size(740, 413);
            this.dtgDetalledeventa.TabIndex = 25;
            // 
            // FrmDetalledeventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 572);
            this.Controls.Add(this.gbDetalleventa);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetalledeventas";
            this.Text = "FrmDetalledeventas";
            this.gbDetalleventa.ResumeLayout(false);
            this.gbDetalleventa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalledeventa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleventa;
        private System.Windows.Forms.TextBox txtDvfiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDvfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDvregresar;
        private System.Windows.Forms.DataGridView dtgDetalledeventa;
    }
}