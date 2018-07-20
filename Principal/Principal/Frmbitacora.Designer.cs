namespace Principal
{
    partial class Frmbitacora
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
            this.txtBfiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBfiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBregresar = new System.Windows.Forms.Button();
            this.dtgBitacora = new System.Windows.Forms.DataGridView();
            this.gbBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBitacora
            // 
            this.gbBitacora.Controls.Add(this.txtBfiltro);
            this.gbBitacora.Controls.Add(this.checkBox1);
            this.gbBitacora.Controls.Add(this.btnBfiltrar);
            this.gbBitacora.Controls.Add(this.label1);
            this.gbBitacora.Controls.Add(this.btnBregresar);
            this.gbBitacora.Controls.Add(this.dtgBitacora);
            this.gbBitacora.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBitacora.Location = new System.Drawing.Point(12, 12);
            this.gbBitacora.Name = "gbBitacora";
            this.gbBitacora.Size = new System.Drawing.Size(781, 555);
            this.gbBitacora.TabIndex = 29;
            this.gbBitacora.TabStop = false;
            // 
            // txtBfiltro
            // 
            this.txtBfiltro.Location = new System.Drawing.Point(72, 22);
            this.txtBfiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBfiltro.Name = "txtBfiltro";
            this.txtBfiltro.Size = new System.Drawing.Size(164, 23);
            this.txtBfiltro.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(581, 503);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todas las bitacoras";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnBfiltrar
            // 
            this.btnBfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBfiltrar.FlatAppearance.BorderSize = 0;
            this.btnBfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBfiltrar.Location = new System.Drawing.Point(266, 11);
            this.btnBfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBfiltrar.Name = "btnBfiltrar";
            this.btnBfiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnBfiltrar.TabIndex = 21;
            this.btnBfiltrar.Text = "Limpiar filtro";
            this.btnBfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBfiltrar.UseVisualStyleBackColor = true;
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
            // btnBregresar
            // 
            this.btnBregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBregresar.FlatAppearance.BorderSize = 0;
            this.btnBregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBregresar.Location = new System.Drawing.Point(423, 11);
            this.btnBregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBregresar.Name = "btnBregresar";
            this.btnBregresar.Size = new System.Drawing.Size(98, 43);
            this.btnBregresar.TabIndex = 24;
            this.btnBregresar.Text = "Regresar";
            this.btnBregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBregresar.UseVisualStyleBackColor = true;
            // 
            // dtgBitacora
            // 
            this.dtgBitacora.AllowUserToAddRows = false;
            this.dtgBitacora.AllowUserToDeleteRows = false;
            this.dtgBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBitacora.Location = new System.Drawing.Point(23, 72);
            this.dtgBitacora.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgBitacora.Name = "dtgBitacora";
            this.dtgBitacora.ReadOnly = true;
            this.dtgBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBitacora.Size = new System.Drawing.Size(730, 413);
            this.dtgBitacora.TabIndex = 25;
            // 
            // Frmbitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 595);
            this.Controls.Add(this.gbBitacora);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmbitacora";
            this.Text = "Frmbitacora";
            this.gbBitacora.ResumeLayout(false);
            this.gbBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBitacora;
        private System.Windows.Forms.TextBox txtBfiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBregresar;
        private System.Windows.Forms.DataGridView dtgBitacora;
    }
}