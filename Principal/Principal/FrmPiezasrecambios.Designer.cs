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
            this.gbRecambios = new System.Windows.Forms.GroupBox();
            this.dtgRecambios = new System.Windows.Forms.DataGridView();
            this.btnPreditar = new System.Windows.Forms.Button();
            this.btnPrregresar = new System.Windows.Forms.Button();
            this.chbRecambios = new System.Windows.Forms.CheckBox();
            this.btnPrnuevo = new System.Windows.Forms.Button();
            this.btnPrfiltrar = new System.Windows.Forms.Button();
            this.txtPrfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosderecambios = new System.Windows.Forms.GroupBox();
            this.txtPrcosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVtcancelar = new System.Windows.Forms.Button();
            this.btnVtguardar = new System.Windows.Forms.Button();
            this.txtPrnumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrprecio = new System.Windows.Forms.TextBox();
            this.txtPrdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPridproveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRecambios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecambios)).BeginInit();
            this.gbDatosderecambios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRecambios
            // 
            this.gbRecambios.Controls.Add(this.dtgRecambios);
            this.gbRecambios.Controls.Add(this.btnPreditar);
            this.gbRecambios.Controls.Add(this.btnPrregresar);
            this.gbRecambios.Controls.Add(this.chbRecambios);
            this.gbRecambios.Controls.Add(this.btnPrnuevo);
            this.gbRecambios.Controls.Add(this.btnPrfiltrar);
            this.gbRecambios.Controls.Add(this.txtPrfiltro);
            this.gbRecambios.Controls.Add(this.label1);
            this.gbRecambios.Location = new System.Drawing.Point(12, 12);
            this.gbRecambios.Name = "gbRecambios";
            this.gbRecambios.Size = new System.Drawing.Size(710, 359);
            this.gbRecambios.TabIndex = 17;
            this.gbRecambios.TabStop = false;
            // 
            // dtgRecambios
            // 
            this.dtgRecambios.AllowUserToAddRows = false;
            this.dtgRecambios.AllowUserToDeleteRows = false;
            this.dtgRecambios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRecambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecambios.Location = new System.Drawing.Point(11, 82);
            this.dtgRecambios.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgRecambios.Name = "dtgRecambios";
            this.dtgRecambios.ReadOnly = true;
            this.dtgRecambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecambios.Size = new System.Drawing.Size(687, 246);
            this.dtgRecambios.TabIndex = 6;
            // 
            // btnPreditar
            // 
            this.btnPreditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreditar.FlatAppearance.BorderSize = 0;
            this.btnPreditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPreditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPreditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreditar.Location = new System.Drawing.Point(474, 30);
            this.btnPreditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreditar.Name = "btnPreditar";
            this.btnPreditar.Size = new System.Drawing.Size(113, 40);
            this.btnPreditar.TabIndex = 3;
            this.btnPreditar.Text = "Editar Recambio";
            this.btnPreditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreditar.UseVisualStyleBackColor = true;
            // 
            // btnPrregresar
            // 
            this.btnPrregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrregresar.FlatAppearance.BorderSize = 0;
            this.btnPrregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrregresar.Location = new System.Drawing.Point(612, 30);
            this.btnPrregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrregresar.Name = "btnPrregresar";
            this.btnPrregresar.Size = new System.Drawing.Size(86, 40);
            this.btnPrregresar.TabIndex = 4;
            this.btnPrregresar.Text = "Regresar";
            this.btnPrregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrregresar.UseVisualStyleBackColor = true;
            // 
            // chbRecambios
            // 
            this.chbRecambios.AutoSize = true;
            this.chbRecambios.Location = new System.Drawing.Point(532, 335);
            this.chbRecambios.Name = "chbRecambios";
            this.chbRecambios.Size = new System.Drawing.Size(166, 18);
            this.chbRecambios.TabIndex = 5;
            this.chbRecambios.Text = "Mostrar todos los recambios";
            this.chbRecambios.UseVisualStyleBackColor = true;
            // 
            // btnPrnuevo
            // 
            this.btnPrnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrnuevo.FlatAppearance.BorderSize = 0;
            this.btnPrnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrnuevo.Location = new System.Drawing.Point(343, 30);
            this.btnPrnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrnuevo.Name = "btnPrnuevo";
            this.btnPrnuevo.Size = new System.Drawing.Size(112, 40);
            this.btnPrnuevo.TabIndex = 2;
            this.btnPrnuevo.Text = "Nueva Recambio";
            this.btnPrnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrnuevo.UseVisualStyleBackColor = true;
            // 
            // btnPrfiltrar
            // 
            this.btnPrfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrfiltrar.FlatAppearance.BorderSize = 0;
            this.btnPrfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrfiltrar.Location = new System.Drawing.Point(222, 30);
            this.btnPrfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrfiltrar.Name = "btnPrfiltrar";
            this.btnPrfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnPrfiltrar.TabIndex = 1;
            this.btnPrfiltrar.Text = "Limpiar Filtro";
            this.btnPrfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrfiltrar.UseVisualStyleBackColor = true;
            // 
            // txtPrfiltro
            // 
            this.txtPrfiltro.Location = new System.Drawing.Point(62, 40);
            this.txtPrfiltro.Name = "txtPrfiltro";
            this.txtPrfiltro.Size = new System.Drawing.Size(136, 22);
            this.txtPrfiltro.TabIndex = 0;
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
            // gbDatosderecambios
            // 
            this.gbDatosderecambios.Controls.Add(this.txtPridproveedor);
            this.gbDatosderecambios.Controls.Add(this.label6);
            this.gbDatosderecambios.Controls.Add(this.txtPrstock);
            this.gbDatosderecambios.Controls.Add(this.label5);
            this.gbDatosderecambios.Controls.Add(this.txtPrcosto);
            this.gbDatosderecambios.Controls.Add(this.label2);
            this.gbDatosderecambios.Controls.Add(this.btnVtcancelar);
            this.gbDatosderecambios.Controls.Add(this.btnVtguardar);
            this.gbDatosderecambios.Controls.Add(this.txtPrnumero);
            this.gbDatosderecambios.Controls.Add(this.label15);
            this.gbDatosderecambios.Controls.Add(this.txtPrprecio);
            this.gbDatosderecambios.Controls.Add(this.txtPrdescripcion);
            this.gbDatosderecambios.Controls.Add(this.label4);
            this.gbDatosderecambios.Controls.Add(this.label3);
            this.gbDatosderecambios.Location = new System.Drawing.Point(12, 391);
            this.gbDatosderecambios.Name = "gbDatosderecambios";
            this.gbDatosderecambios.Size = new System.Drawing.Size(710, 158);
            this.gbDatosderecambios.TabIndex = 16;
            this.gbDatosderecambios.TabStop = false;
            this.gbDatosderecambios.Text = "Datos de los Recambios";
            // 
            // txtPrcosto
            // 
            this.txtPrcosto.Location = new System.Drawing.Point(103, 90);
            this.txtPrcosto.Name = "txtPrcosto";
            this.txtPrcosto.Size = new System.Drawing.Size(128, 22);
            this.txtPrcosto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
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
            this.btnVtcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtcancelar.Location = new System.Drawing.Point(544, 79);
            this.btnVtcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtcancelar.Name = "btnVtcancelar";
            this.btnVtcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnVtcancelar.TabIndex = 15;
            this.btnVtcancelar.Text = "Cancelar";
            this.btnVtcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtcancelar.UseVisualStyleBackColor = true;
            // 
            // btnVtguardar
            // 
            this.btnVtguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVtguardar.FlatAppearance.BorderSize = 0;
            this.btnVtguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVtguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVtguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVtguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVtguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtguardar.Location = new System.Drawing.Point(544, 21);
            this.btnVtguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtguardar.Name = "btnVtguardar";
            this.btnVtguardar.Size = new System.Drawing.Size(115, 40);
            this.btnVtguardar.TabIndex = 14;
            this.btnVtguardar.Text = "Guardar";
            this.btnVtguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtguardar.UseVisualStyleBackColor = true;
            // 
            // txtPrnumero
            // 
            this.txtPrnumero.Location = new System.Drawing.Point(103, 29);
            this.txtPrnumero.Name = "txtPrnumero";
            this.txtPrnumero.Size = new System.Drawing.Size(87, 22);
            this.txtPrnumero.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Numero:";
            // 
            // txtPrprecio
            // 
            this.txtPrprecio.Location = new System.Drawing.Point(343, 29);
            this.txtPrprecio.Name = "txtPrprecio";
            this.txtPrprecio.Size = new System.Drawing.Size(141, 22);
            this.txtPrprecio.TabIndex = 3;
            // 
            // txtPrdescripcion
            // 
            this.txtPrdescripcion.Location = new System.Drawing.Point(103, 59);
            this.txtPrdescripcion.Name = "txtPrdescripcion";
            this.txtPrdescripcion.Size = new System.Drawing.Size(128, 22);
            this.txtPrdescripcion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción:";
            // 
            // txtPrstock
            // 
            this.txtPrstock.Location = new System.Drawing.Point(343, 59);
            this.txtPrstock.Name = "txtPrstock";
            this.txtPrstock.Size = new System.Drawing.Size(141, 22);
            this.txtPrstock.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 101;
            this.label5.Text = "Stock:";
            // 
            // txtPridproveedor
            // 
            this.txtPridproveedor.Location = new System.Drawing.Point(343, 89);
            this.txtPridproveedor.Name = "txtPridproveedor";
            this.txtPridproveedor.Size = new System.Drawing.Size(141, 22);
            this.txtPridproveedor.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 14);
            this.label6.TabIndex = 103;
            this.label6.Text = "Id del Proveedor:";
            // 
            // FrmPiezasrecambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 566);
            this.Controls.Add(this.gbRecambios);
            this.Controls.Add(this.gbDatosderecambios);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPiezasrecambio";
            this.Text = "FrmPiezasrecambio";
            this.gbRecambios.ResumeLayout(false);
            this.gbRecambios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecambios)).EndInit();
            this.gbDatosderecambios.ResumeLayout(false);
            this.gbDatosderecambios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRecambios;
        private System.Windows.Forms.DataGridView dtgRecambios;
        private System.Windows.Forms.Button btnPreditar;
        private System.Windows.Forms.Button btnPrregresar;
        private System.Windows.Forms.CheckBox chbRecambios;
        private System.Windows.Forms.Button btnPrnuevo;
        private System.Windows.Forms.Button btnPrfiltrar;
        private System.Windows.Forms.TextBox txtPrfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosderecambios;
        private System.Windows.Forms.TextBox txtPrcosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVtcancelar;
        private System.Windows.Forms.Button btnVtguardar;
        private System.Windows.Forms.TextBox txtPrnumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrprecio;
        private System.Windows.Forms.TextBox txtPrdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPridproveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrstock;
        private System.Windows.Forms.Label label5;
    }
}