namespace Principal
{
    partial class FrmDetalledeventaservicios
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
            this.gbDvservicio = new System.Windows.Forms.GroupBox();
            this.txtDvsfiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDvsfiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDvsregresar = new System.Windows.Forms.Button();
            this.dtgDvservicio = new System.Windows.Forms.DataGridView();
            this.gbDvservicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDvservicio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDvservicio
            // 
            this.gbDvservicio.Controls.Add(this.txtDvsfiltro);
            this.gbDvservicio.Controls.Add(this.checkBox1);
            this.gbDvservicio.Controls.Add(this.btnDvsfiltrar);
            this.gbDvservicio.Controls.Add(this.label1);
            this.gbDvservicio.Controls.Add(this.btnDvsregresar);
            this.gbDvservicio.Controls.Add(this.dtgDvservicio);
            this.gbDvservicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDvservicio.Location = new System.Drawing.Point(22, 29);
            this.gbDvservicio.Name = "gbDvservicio";
            this.gbDvservicio.Size = new System.Drawing.Size(781, 527);
            this.gbDvservicio.TabIndex = 31;
            this.gbDvservicio.TabStop = false;
            // 
            // txtDvsfiltro
            // 
            this.txtDvsfiltro.Location = new System.Drawing.Point(72, 22);
            this.txtDvsfiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDvsfiltro.Name = "txtDvsfiltro";
            this.txtDvsfiltro.Size = new System.Drawing.Size(164, 23);
            this.txtDvsfiltro.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(482, 492);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(281, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los detalles de Venta de Sercicio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDvsfiltrar
            // 
            this.btnDvsfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDvsfiltrar.FlatAppearance.BorderSize = 0;
            this.btnDvsfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDvsfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDvsfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDvsfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDvsfiltrar.Location = new System.Drawing.Point(266, 11);
            this.btnDvsfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDvsfiltrar.Name = "btnDvsfiltrar";
            this.btnDvsfiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnDvsfiltrar.TabIndex = 21;
            this.btnDvsfiltrar.Text = "Limpiar filtro";
            this.btnDvsfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDvsfiltrar.UseVisualStyleBackColor = true;
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
            // btnDvsregresar
            // 
            this.btnDvsregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDvsregresar.FlatAppearance.BorderSize = 0;
            this.btnDvsregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDvsregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDvsregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDvsregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDvsregresar.Location = new System.Drawing.Point(423, 11);
            this.btnDvsregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDvsregresar.Name = "btnDvsregresar";
            this.btnDvsregresar.Size = new System.Drawing.Size(98, 43);
            this.btnDvsregresar.TabIndex = 24;
            this.btnDvsregresar.Text = "Regresar";
            this.btnDvsregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDvsregresar.UseVisualStyleBackColor = true;
            // 
            // dtgDvservicio
            // 
            this.dtgDvservicio.AllowUserToAddRows = false;
            this.dtgDvservicio.AllowUserToDeleteRows = false;
            this.dtgDvservicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDvservicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDvservicio.Location = new System.Drawing.Point(23, 72);
            this.dtgDvservicio.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgDvservicio.Name = "dtgDvservicio";
            this.dtgDvservicio.ReadOnly = true;
            this.dtgDvservicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDvservicio.Size = new System.Drawing.Size(740, 413);
            this.dtgDvservicio.TabIndex = 25;
            // 
            // FrmDetalledeventaservicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 604);
            this.Controls.Add(this.gbDvservicio);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalledeventaservicios";
            this.Text = "FrmDetalledeventaservicios";
            this.gbDvservicio.ResumeLayout(false);
            this.gbDvservicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDvservicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDvservicio;
        private System.Windows.Forms.TextBox txtDvsfiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDvsfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDvsregresar;
        private System.Windows.Forms.DataGridView dtgDvservicio;
    }
}