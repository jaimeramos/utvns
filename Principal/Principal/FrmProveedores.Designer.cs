namespace Principal
{
    partial class FrmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            this.gbProveedores = new System.Windows.Forms.GroupBox();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.btnPreditar = new System.Windows.Forms.Button();
            this.btnPrregresar = new System.Windows.Forms.Button();
            this.chbPermisionarios = new System.Windows.Forms.CheckBox();
            this.btnPrnuevo = new System.Windows.Forms.Button();
            this.btnPrfiltrar = new System.Windows.Forms.Button();
            this.txtPrfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosproveedor = new System.Windows.Forms.GroupBox();
            this.gbPtipo = new System.Windows.Forms.GroupBox();
            this.chbPrinactivo = new System.Windows.Forms.CheckBox();
            this.chbPractivo = new System.Windows.Forms.CheckBox();
            this.txtPrdireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrcancelar = new System.Windows.Forms.Button();
            this.btnPrguardar = new System.Windows.Forms.Button();
            this.txtPrnumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPremail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrcelular = new System.Windows.Forms.TextBox();
            this.txtPrtelefono = new System.Windows.Forms.TextBox();
            this.txtPrrfc = new System.Windows.Forms.TextBox();
            this.txtPrnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.gbDatosproveedor.SuspendLayout();
            this.gbPtipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProveedores
            // 
            this.gbProveedores.Controls.Add(this.dtgProveedor);
            this.gbProveedores.Controls.Add(this.btnPreditar);
            this.gbProveedores.Controls.Add(this.btnPrregresar);
            this.gbProveedores.Controls.Add(this.chbPermisionarios);
            this.gbProveedores.Controls.Add(this.btnPrnuevo);
            this.gbProveedores.Controls.Add(this.btnPrfiltrar);
            this.gbProveedores.Controls.Add(this.txtPrfiltro);
            this.gbProveedores.Controls.Add(this.label1);
            this.gbProveedores.Location = new System.Drawing.Point(12, 12);
            this.gbProveedores.Name = "gbProveedores";
            this.gbProveedores.Size = new System.Drawing.Size(813, 359);
            this.gbProveedores.TabIndex = 13;
            this.gbProveedores.TabStop = false;
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(11, 82);
            this.dtgProveedor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(781, 246);
            this.dtgProveedor.TabIndex = 6;
            // 
            // btnPreditar
            // 
            this.btnPreditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreditar.FlatAppearance.BorderSize = 0;
            this.btnPreditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPreditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPreditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreditar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreditar.Image")));
            this.btnPreditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreditar.Location = new System.Drawing.Point(511, 30);
            this.btnPreditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreditar.Name = "btnPreditar";
            this.btnPreditar.Size = new System.Drawing.Size(139, 40);
            this.btnPreditar.TabIndex = 3;
            this.btnPreditar.Text = "Editar Proveedor";
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
            this.btnPrregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrregresar.Image")));
            this.btnPrregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrregresar.Location = new System.Drawing.Point(693, 30);
            this.btnPrregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrregresar.Name = "btnPrregresar";
            this.btnPrregresar.Size = new System.Drawing.Size(98, 40);
            this.btnPrregresar.TabIndex = 4;
            this.btnPrregresar.Text = "Regresar";
            this.btnPrregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrregresar.UseVisualStyleBackColor = true;
            // 
            // chbPermisionarios
            // 
            this.chbPermisionarios.AutoSize = true;
            this.chbPermisionarios.Location = new System.Drawing.Point(616, 335);
            this.chbPermisionarios.Name = "chbPermisionarios";
            this.chbPermisionarios.Size = new System.Drawing.Size(176, 18);
            this.chbPermisionarios.TabIndex = 5;
            this.chbPermisionarios.Text = "Mostrar todos los Proveedores";
            this.chbPermisionarios.UseVisualStyleBackColor = true;
            // 
            // btnPrnuevo
            // 
            this.btnPrnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrnuevo.FlatAppearance.BorderSize = 0;
            this.btnPrnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnPrnuevo.Image")));
            this.btnPrnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrnuevo.Location = new System.Drawing.Point(364, 30);
            this.btnPrnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrnuevo.Name = "btnPrnuevo";
            this.btnPrnuevo.Size = new System.Drawing.Size(136, 40);
            this.btnPrnuevo.TabIndex = 2;
            this.btnPrnuevo.Text = "Nuevo Proveedor";
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
            this.btnPrfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrfiltrar.Image")));
            this.btnPrfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrfiltrar.Location = new System.Drawing.Point(237, 30);
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
            // gbDatosproveedor
            // 
            this.gbDatosproveedor.Controls.Add(this.gbPtipo);
            this.gbDatosproveedor.Controls.Add(this.txtPrdireccion);
            this.gbDatosproveedor.Controls.Add(this.label2);
            this.gbDatosproveedor.Controls.Add(this.btnPrcancelar);
            this.gbDatosproveedor.Controls.Add(this.btnPrguardar);
            this.gbDatosproveedor.Controls.Add(this.txtPrnumero);
            this.gbDatosproveedor.Controls.Add(this.label15);
            this.gbDatosproveedor.Controls.Add(this.txtPremail);
            this.gbDatosproveedor.Controls.Add(this.label8);
            this.gbDatosproveedor.Controls.Add(this.txtPrcelular);
            this.gbDatosproveedor.Controls.Add(this.txtPrtelefono);
            this.gbDatosproveedor.Controls.Add(this.txtPrrfc);
            this.gbDatosproveedor.Controls.Add(this.txtPrnombre);
            this.gbDatosproveedor.Controls.Add(this.label7);
            this.gbDatosproveedor.Controls.Add(this.label6);
            this.gbDatosproveedor.Controls.Add(this.label4);
            this.gbDatosproveedor.Controls.Add(this.label3);
            this.gbDatosproveedor.Location = new System.Drawing.Point(12, 391);
            this.gbDatosproveedor.Name = "gbDatosproveedor";
            this.gbDatosproveedor.Size = new System.Drawing.Size(813, 170);
            this.gbDatosproveedor.TabIndex = 12;
            this.gbDatosproveedor.TabStop = false;
            this.gbDatosproveedor.Text = "Datos del Proveedor";
            // 
            // gbPtipo
            // 
            this.gbPtipo.Controls.Add(this.chbPrinactivo);
            this.gbPtipo.Controls.Add(this.chbPractivo);
            this.gbPtipo.Location = new System.Drawing.Point(359, 116);
            this.gbPtipo.Name = "gbPtipo";
            this.gbPtipo.Size = new System.Drawing.Size(205, 42);
            this.gbPtipo.TabIndex = 104;
            this.gbPtipo.TabStop = false;
            // 
            // chbPrinactivo
            // 
            this.chbPrinactivo.AutoSize = true;
            this.chbPrinactivo.Location = new System.Drawing.Point(104, 17);
            this.chbPrinactivo.Name = "chbPrinactivo";
            this.chbPrinactivo.Size = new System.Drawing.Size(65, 18);
            this.chbPrinactivo.TabIndex = 1;
            this.chbPrinactivo.Text = "Inactivo";
            this.chbPrinactivo.UseVisualStyleBackColor = true;
            // 
            // chbPractivo
            // 
            this.chbPractivo.AutoSize = true;
            this.chbPractivo.Location = new System.Drawing.Point(29, 17);
            this.chbPractivo.Name = "chbPractivo";
            this.chbPractivo.Size = new System.Drawing.Size(57, 18);
            this.chbPractivo.TabIndex = 0;
            this.chbPractivo.Text = "Activo";
            this.chbPractivo.UseVisualStyleBackColor = true;
            // 
            // txtPrdireccion
            // 
            this.txtPrdireccion.Location = new System.Drawing.Point(111, 86);
            this.txtPrdireccion.Name = "txtPrdireccion";
            this.txtPrdireccion.Size = new System.Drawing.Size(187, 22);
            this.txtPrdireccion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Direccion:";
            // 
            // btnPrcancelar
            // 
            this.btnPrcancelar.FlatAppearance.BorderSize = 0;
            this.btnPrcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrcancelar.Image")));
            this.btnPrcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrcancelar.Location = new System.Drawing.Point(625, 85);
            this.btnPrcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrcancelar.Name = "btnPrcancelar";
            this.btnPrcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnPrcancelar.TabIndex = 15;
            this.btnPrcancelar.Text = "Cancelar";
            this.btnPrcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrcancelar.UseVisualStyleBackColor = true;
            // 
            // btnPrguardar
            // 
            this.btnPrguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrguardar.FlatAppearance.BorderSize = 0;
            this.btnPrguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrguardar.Image")));
            this.btnPrguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrguardar.Location = new System.Drawing.Point(625, 30);
            this.btnPrguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrguardar.Name = "btnPrguardar";
            this.btnPrguardar.Size = new System.Drawing.Size(115, 40);
            this.btnPrguardar.TabIndex = 14;
            this.btnPrguardar.Text = "Guardar";
            this.btnPrguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrguardar.UseVisualStyleBackColor = true;
            // 
            // txtPrnumero
            // 
            this.txtPrnumero.Location = new System.Drawing.Point(111, 30);
            this.txtPrnumero.Name = "txtPrnumero";
            this.txtPrnumero.Size = new System.Drawing.Size(87, 22);
            this.txtPrnumero.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Numero:";
            // 
            // txtPremail
            // 
            this.txtPremail.Location = new System.Drawing.Point(408, 87);
            this.txtPremail.Name = "txtPremail";
            this.txtPremail.Size = new System.Drawing.Size(156, 22);
            this.txtPremail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // txtPrcelular
            // 
            this.txtPrcelular.Location = new System.Drawing.Point(408, 57);
            this.txtPrcelular.Name = "txtPrcelular";
            this.txtPrcelular.Size = new System.Drawing.Size(103, 22);
            this.txtPrcelular.TabIndex = 6;
            // 
            // txtPrtelefono
            // 
            this.txtPrtelefono.Location = new System.Drawing.Point(408, 27);
            this.txtPrtelefono.Name = "txtPrtelefono";
            this.txtPrtelefono.Size = new System.Drawing.Size(105, 22);
            this.txtPrtelefono.TabIndex = 5;
            // 
            // txtPrrfc
            // 
            this.txtPrrfc.Location = new System.Drawing.Point(111, 114);
            this.txtPrrfc.Name = "txtPrrfc";
            this.txtPrrfc.Size = new System.Drawing.Size(141, 22);
            this.txtPrrfc.TabIndex = 3;
            // 
            // txtPrnombre
            // 
            this.txtPrnombre.Location = new System.Drawing.Point(111, 57);
            this.txtPrnombre.Name = "txtPrnombre";
            this.txtPrnombre.Size = new System.Drawing.Size(187, 22);
            this.txtPrnombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tel. Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 574);
            this.Controls.Add(this.gbProveedores);
            this.Controls.Add(this.gbDatosproveedor);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedor";
            this.gbProveedores.ResumeLayout(false);
            this.gbProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.gbDatosproveedor.ResumeLayout(false);
            this.gbDatosproveedor.PerformLayout();
            this.gbPtipo.ResumeLayout(false);
            this.gbPtipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProveedores;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Button btnPreditar;
        private System.Windows.Forms.Button btnPrregresar;
        private System.Windows.Forms.CheckBox chbPermisionarios;
        private System.Windows.Forms.Button btnPrnuevo;
        private System.Windows.Forms.Button btnPrfiltrar;
        private System.Windows.Forms.TextBox txtPrfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosproveedor;
        private System.Windows.Forms.GroupBox gbPtipo;
        private System.Windows.Forms.CheckBox chbPrinactivo;
        private System.Windows.Forms.CheckBox chbPractivo;
        private System.Windows.Forms.TextBox txtPrdireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrcancelar;
        private System.Windows.Forms.Button btnPrguardar;
        private System.Windows.Forms.TextBox txtPrnumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPremail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrcelular;
        private System.Windows.Forms.TextBox txtPrtelefono;
        private System.Windows.Forms.TextBox txtPrrfc;
        private System.Windows.Forms.TextBox txtPrnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}