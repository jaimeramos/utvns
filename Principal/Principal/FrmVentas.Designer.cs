namespace Principal
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.btnVteditar = new System.Windows.Forms.Button();
            this.btnVtregresar = new System.Windows.Forms.Button();
            this.chbPermisionarios = new System.Windows.Forms.CheckBox();
            this.btnVtnuevo = new System.Windows.Forms.Button();
            this.btnVtfiltrar = new System.Windows.Forms.Button();
            this.txtVtfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosdeventa = new System.Windows.Forms.GroupBox();
            this.dtpVtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtVtidpermisionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVtcancelar = new System.Windows.Forms.Button();
            this.btnVtguardar = new System.Windows.Forms.Button();
            this.txtVtfolio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVtmonto = new System.Windows.Forms.TextBox();
            this.txtVtnumrecepcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.gbDatosdeventa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.dtgVentas);
            this.gbVentas.Controls.Add(this.btnVteditar);
            this.gbVentas.Controls.Add(this.btnVtregresar);
            this.gbVentas.Controls.Add(this.chbPermisionarios);
            this.gbVentas.Controls.Add(this.btnVtnuevo);
            this.gbVentas.Controls.Add(this.btnVtfiltrar);
            this.gbVentas.Controls.Add(this.txtVtfiltro);
            this.gbVentas.Controls.Add(this.label1);
            this.gbVentas.Location = new System.Drawing.Point(12, 12);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(756, 359);
            this.gbVentas.TabIndex = 15;
            this.gbVentas.TabStop = false;
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AllowUserToDeleteRows = false;
            this.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(11, 82);
            this.dtgVentas.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentas.Size = new System.Drawing.Size(733, 246);
            this.dtgVentas.TabIndex = 6;
            // 
            // btnVteditar
            // 
            this.btnVteditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVteditar.FlatAppearance.BorderSize = 0;
            this.btnVteditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVteditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVteditar.Image = ((System.Drawing.Image)(resources.GetObject("btnVteditar.Image")));
            this.btnVteditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVteditar.Location = new System.Drawing.Point(474, 30);
            this.btnVteditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVteditar.Name = "btnVteditar";
            this.btnVteditar.Size = new System.Drawing.Size(119, 40);
            this.btnVteditar.TabIndex = 3;
            this.btnVteditar.Text = "Editar Venta";
            this.btnVteditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVteditar.UseVisualStyleBackColor = true;
            // 
            // btnVtregresar
            // 
            this.btnVtregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVtregresar.FlatAppearance.BorderSize = 0;
            this.btnVtregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVtregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVtregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVtregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnVtregresar.Image")));
            this.btnVtregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtregresar.Location = new System.Drawing.Point(612, 30);
            this.btnVtregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtregresar.Name = "btnVtregresar";
            this.btnVtregresar.Size = new System.Drawing.Size(101, 40);
            this.btnVtregresar.TabIndex = 4;
            this.btnVtregresar.Text = "Regresar";
            this.btnVtregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtregresar.UseVisualStyleBackColor = true;
            // 
            // chbPermisionarios
            // 
            this.chbPermisionarios.AutoSize = true;
            this.chbPermisionarios.Location = new System.Drawing.Point(596, 335);
            this.chbPermisionarios.Name = "chbPermisionarios";
            this.chbPermisionarios.Size = new System.Drawing.Size(148, 18);
            this.chbPermisionarios.TabIndex = 5;
            this.chbPermisionarios.Text = "Mostrar todas las Ventas";
            this.chbPermisionarios.UseVisualStyleBackColor = true;
            // 
            // btnVtnuevo
            // 
            this.btnVtnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVtnuevo.FlatAppearance.BorderSize = 0;
            this.btnVtnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVtnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVtnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVtnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnVtnuevo.Image")));
            this.btnVtnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtnuevo.Location = new System.Drawing.Point(343, 30);
            this.btnVtnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtnuevo.Name = "btnVtnuevo";
            this.btnVtnuevo.Size = new System.Drawing.Size(127, 40);
            this.btnVtnuevo.TabIndex = 2;
            this.btnVtnuevo.Text = "Nueva Venta";
            this.btnVtnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtnuevo.UseVisualStyleBackColor = true;
            // 
            // btnVtfiltrar
            // 
            this.btnVtfiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVtfiltrar.FlatAppearance.BorderSize = 0;
            this.btnVtfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVtfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVtfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVtfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnVtfiltrar.Image")));
            this.btnVtfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtfiltrar.Location = new System.Drawing.Point(222, 30);
            this.btnVtfiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtfiltrar.Name = "btnVtfiltrar";
            this.btnVtfiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnVtfiltrar.TabIndex = 1;
            this.btnVtfiltrar.Text = "Limpiar Filtro";
            this.btnVtfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtfiltrar.UseVisualStyleBackColor = true;
            // 
            // txtVtfiltro
            // 
            this.txtVtfiltro.Location = new System.Drawing.Point(62, 40);
            this.txtVtfiltro.Name = "txtVtfiltro";
            this.txtVtfiltro.Size = new System.Drawing.Size(136, 22);
            this.txtVtfiltro.TabIndex = 0;
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
            // gbDatosdeventa
            // 
            this.gbDatosdeventa.Controls.Add(this.dtpVtfecha);
            this.gbDatosdeventa.Controls.Add(this.txtVtidpermisionario);
            this.gbDatosdeventa.Controls.Add(this.label2);
            this.gbDatosdeventa.Controls.Add(this.btnVtcancelar);
            this.gbDatosdeventa.Controls.Add(this.btnVtguardar);
            this.gbDatosdeventa.Controls.Add(this.txtVtfolio);
            this.gbDatosdeventa.Controls.Add(this.label15);
            this.gbDatosdeventa.Controls.Add(this.txtVtmonto);
            this.gbDatosdeventa.Controls.Add(this.txtVtnumrecepcion);
            this.gbDatosdeventa.Controls.Add(this.label6);
            this.gbDatosdeventa.Controls.Add(this.label4);
            this.gbDatosdeventa.Controls.Add(this.label3);
            this.gbDatosdeventa.Location = new System.Drawing.Point(12, 391);
            this.gbDatosdeventa.Name = "gbDatosdeventa";
            this.gbDatosdeventa.Size = new System.Drawing.Size(756, 158);
            this.gbDatosdeventa.TabIndex = 14;
            this.gbDatosdeventa.TabStop = false;
            this.gbDatosdeventa.Text = "Datos de la Venta";
            // 
            // dtpVtfecha
            // 
            this.dtpVtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVtfecha.Location = new System.Drawing.Point(368, 65);
            this.dtpVtfecha.Name = "dtpVtfecha";
            this.dtpVtfecha.Size = new System.Drawing.Size(141, 22);
            this.dtpVtfecha.TabIndex = 100;
            // 
            // txtVtidpermisionario
            // 
            this.txtVtidpermisionario.Location = new System.Drawing.Point(146, 90);
            this.txtVtidpermisionario.Name = "txtVtidpermisionario";
            this.txtVtidpermisionario.Size = new System.Drawing.Size(128, 22);
            this.txtVtidpermisionario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Id Permisionario:";
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
            this.btnVtcancelar.Location = new System.Drawing.Point(574, 79);
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
            this.btnVtguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnVtguardar.Image")));
            this.btnVtguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVtguardar.Location = new System.Drawing.Point(574, 24);
            this.btnVtguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVtguardar.Name = "btnVtguardar";
            this.btnVtguardar.Size = new System.Drawing.Size(115, 40);
            this.btnVtguardar.TabIndex = 14;
            this.btnVtguardar.Text = "Guardar";
            this.btnVtguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVtguardar.UseVisualStyleBackColor = true;
            // 
            // txtVtfolio
            // 
            this.txtVtfolio.Location = new System.Drawing.Point(146, 29);
            this.txtVtfolio.Name = "txtVtfolio";
            this.txtVtfolio.Size = new System.Drawing.Size(87, 22);
            this.txtVtfolio.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(104, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Folio:";
            // 
            // txtVtmonto
            // 
            this.txtVtmonto.Location = new System.Drawing.Point(368, 35);
            this.txtVtmonto.Name = "txtVtmonto";
            this.txtVtmonto.Size = new System.Drawing.Size(141, 22);
            this.txtVtmonto.TabIndex = 3;
            // 
            // txtVtnumrecepcion
            // 
            this.txtVtnumrecepcion.Location = new System.Drawing.Point(146, 59);
            this.txtVtnumrecepcion.Name = "txtVtnumrecepcion";
            this.txtVtnumrecepcion.Size = new System.Drawing.Size(128, 22);
            this.txtVtnumrecepcion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de Recepción:";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 561);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.gbDatosdeventa);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.gbDatosdeventa.ResumeLayout(false);
            this.gbDatosdeventa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button btnVteditar;
        private System.Windows.Forms.Button btnVtregresar;
        private System.Windows.Forms.CheckBox chbPermisionarios;
        private System.Windows.Forms.Button btnVtnuevo;
        private System.Windows.Forms.Button btnVtfiltrar;
        private System.Windows.Forms.TextBox txtVtfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosdeventa;
        private System.Windows.Forms.TextBox txtVtidpermisionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVtcancelar;
        private System.Windows.Forms.Button btnVtguardar;
        private System.Windows.Forms.TextBox txtVtfolio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVtmonto;
        private System.Windows.Forms.TextBox txtVtnumrecepcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVtfecha;
    }
}