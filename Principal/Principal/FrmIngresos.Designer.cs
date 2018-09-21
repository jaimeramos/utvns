namespace Principal
{
    partial class FrmIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresos));
            this.gbRefacciones = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLineaNegDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaCubierta = new System.Windows.Forms.DateTimePicker();
            this.cmbLineaNegocio = new System.Windows.Forms.ComboBox();
            this.btnLineaNegocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnTipoIngreso = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminarRefaccion = new System.Windows.Forms.Button();
            this.btnAgregarRefaccion = new System.Windows.Forms.Button();
            this.dataGridID = new System.Windows.Forms.DataGridView();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbVehicles = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuscarpermisionario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.gbRefacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridID)).BeginInit();
            this.gbVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRefacciones
            // 
            this.gbRefacciones.Controls.Add(this.label12);
            this.gbRefacciones.Controls.Add(this.txtLineaNegDesc);
            this.gbRefacciones.Controls.Add(this.label7);
            this.gbRefacciones.Controls.Add(this.dtpFechaCubierta);
            this.gbRefacciones.Controls.Add(this.cmbLineaNegocio);
            this.gbRefacciones.Controls.Add(this.btnLineaNegocio);
            this.gbRefacciones.Controls.Add(this.label6);
            this.gbRefacciones.Controls.Add(this.cmbTipoIngreso);
            this.gbRefacciones.Controls.Add(this.label11);
            this.gbRefacciones.Controls.Add(this.txtDescripcion);
            this.gbRefacciones.Controls.Add(this.label9);
            this.gbRefacciones.Controls.Add(this.txtMonto);
            this.gbRefacciones.Controls.Add(this.btnTipoIngreso);
            this.gbRefacciones.Controls.Add(this.label10);
            this.gbRefacciones.Controls.Add(this.btnEliminarRefaccion);
            this.gbRefacciones.Controls.Add(this.btnAgregarRefaccion);
            this.gbRefacciones.Controls.Add(this.dataGridID);
            this.gbRefacciones.Location = new System.Drawing.Point(29, 100);
            this.gbRefacciones.Name = "gbRefacciones";
            this.gbRefacciones.Size = new System.Drawing.Size(740, 366);
            this.gbRefacciones.TabIndex = 3;
            this.gbRefacciones.TabStop = false;
            this.gbRefacciones.Text = "Datos del tipo de ingreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Línea de Negocio:";
            // 
            // txtLineaNegDesc
            // 
            this.txtLineaNegDesc.Enabled = false;
            this.txtLineaNegDesc.Location = new System.Drawing.Point(270, 85);
            this.txtLineaNegDesc.Name = "txtLineaNegDesc";
            this.txtLineaNegDesc.Size = new System.Drawing.Size(140, 20);
            this.txtLineaNegDesc.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha cubierta:";
            // 
            // dtpFechaCubierta
            // 
            this.dtpFechaCubierta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCubierta.Location = new System.Drawing.Point(416, 85);
            this.dtpFechaCubierta.Name = "dtpFechaCubierta";
            this.dtpFechaCubierta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCubierta.TabIndex = 30;
            // 
            // cmbLineaNegocio
            // 
            this.cmbLineaNegocio.FormattingEnabled = true;
            this.cmbLineaNegocio.Location = new System.Drawing.Point(12, 85);
            this.cmbLineaNegocio.Name = "cmbLineaNegocio";
            this.cmbLineaNegocio.Size = new System.Drawing.Size(169, 21);
            this.cmbLineaNegocio.TabIndex = 29;
            this.cmbLineaNegocio.SelectedIndexChanged += new System.EventHandler(this.cmbLineaNegocio_SelectedIndexChanged);
            // 
            // btnLineaNegocio
            // 
            this.btnLineaNegocio.Location = new System.Drawing.Point(187, 84);
            this.btnLineaNegocio.Name = "btnLineaNegocio";
            this.btnLineaNegocio.Size = new System.Drawing.Size(75, 23);
            this.btnLineaNegocio.TabIndex = 28;
            this.btnLineaNegocio.Text = "Buscar";
            this.btnLineaNegocio.UseVisualStyleBackColor = true;
            this.btnLineaNegocio.Click += new System.EventHandler(this.btnLineaNegocio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Línea de Negocio:";
            // 
            // cmbTipoIngreso
            // 
            this.cmbTipoIngreso.FormattingEnabled = true;
            this.cmbTipoIngreso.Location = new System.Drawing.Point(11, 39);
            this.cmbTipoIngreso.Name = "cmbTipoIngreso";
            this.cmbTipoIngreso.Size = new System.Drawing.Size(169, 21);
            this.cmbTipoIngreso.TabIndex = 26;
            this.cmbTipoIngreso.TextChanged += new System.EventHandler(this.cmbTipoIngreso_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(270, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(140, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(416, 39);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 20;
            // 
            // btnTipoIngreso
            // 
            this.btnTipoIngreso.Location = new System.Drawing.Point(186, 38);
            this.btnTipoIngreso.Name = "btnTipoIngreso";
            this.btnTipoIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnTipoIngreso.TabIndex = 19;
            this.btnTipoIngreso.Text = "Buscar";
            this.btnTipoIngreso.UseVisualStyleBackColor = true;
            this.btnTipoIngreso.Click += new System.EventHandler(this.btnTipoIngreso_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo de Ingreso:";
            // 
            // btnEliminarRefaccion
            // 
            this.btnEliminarRefaccion.Location = new System.Drawing.Point(573, 37);
            this.btnEliminarRefaccion.Name = "btnEliminarRefaccion";
            this.btnEliminarRefaccion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRefaccion.TabIndex = 16;
            this.btnEliminarRefaccion.Text = "Eliminar";
            this.btnEliminarRefaccion.UseVisualStyleBackColor = true;
            this.btnEliminarRefaccion.Click += new System.EventHandler(this.btnEliminarRefaccion_Click);
            // 
            // btnAgregarRefaccion
            // 
            this.btnAgregarRefaccion.Location = new System.Drawing.Point(654, 37);
            this.btnAgregarRefaccion.Name = "btnAgregarRefaccion";
            this.btnAgregarRefaccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRefaccion.TabIndex = 15;
            this.btnAgregarRefaccion.Text = "Agregar";
            this.btnAgregarRefaccion.UseVisualStyleBackColor = true;
            this.btnAgregarRefaccion.Click += new System.EventHandler(this.btnAgregarRefaccion_Click);
            // 
            // dataGridID
            // 
            this.dataGridID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridID.Location = new System.Drawing.Point(6, 133);
            this.dataGridID.MultiSelect = false;
            this.dataGridID.Name = "dataGridID";
            this.dataGridID.ReadOnly = true;
            this.dataGridID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridID.Size = new System.Drawing.Size(728, 227);
            this.dataGridID.TabIndex = 0;
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.button1);
            this.gbVenta.Controls.Add(this.cmbVehicles);
            this.gbVenta.Controls.Add(this.btnConfirmar);
            this.gbVenta.Controls.Add(this.btnGuardar);
            this.gbVenta.Controls.Add(this.label5);
            this.gbVenta.Controls.Add(this.txtTotal);
            this.gbVenta.Controls.Add(this.btnBuscarpermisionario);
            this.gbVenta.Controls.Add(this.label4);
            this.gbVenta.Controls.Add(this.label3);
            this.gbVenta.Controls.Add(this.dtpFecha);
            this.gbVenta.Controls.Add(this.label2);
            this.gbVenta.Controls.Add(this.txtRecibo);
            this.gbVenta.Controls.Add(this.label1);
            this.gbVenta.Controls.Add(this.txtFolio);
            this.gbVenta.Location = new System.Drawing.Point(29, 7);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(740, 92);
            this.gbVenta.TabIndex = 2;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = " Registro de ingresos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbVehicles
            // 
            this.cmbVehicles.FormattingEnabled = true;
            this.cmbVehicles.Location = new System.Drawing.Point(62, 59);
            this.cmbVehicles.Name = "cmbVehicles";
            this.cmbVehicles.Size = new System.Drawing.Size(200, 21);
            this.cmbVehicles.TabIndex = 24;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(542, 59);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 23);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar ingreso";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(452, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar ingreso";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total: $";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(270, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // btnBuscarpermisionario
            // 
            this.btnBuscarpermisionario.Location = new System.Drawing.Point(279, 59);
            this.btnBuscarpermisionario.Name = "btnBuscarpermisionario";
            this.btnBuscarpermisionario.Size = new System.Drawing.Size(84, 23);
            this.btnBuscarpermisionario.TabIndex = 14;
            this.btnBuscarpermisionario.Text = "Buscar";
            this.btnBuscarpermisionario.UseVisualStyleBackColor = true;
            this.btnBuscarpermisionario.Click += new System.EventHandler(this.btnBuscarpermisionario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vehículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(631, 21);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(94, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recibo #:";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Enabled = false;
            this.txtRecibo.Location = new System.Drawing.Point(158, 21);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(59, 20);
            this.txtRecibo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folio:";
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(44, 21);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(53, 20);
            this.txtFolio.TabIndex = 4;
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 576);
            this.Controls.Add(this.gbRefacciones);
            this.Controls.Add(this.gbVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresos";
            this.Text = "FrmIngresos";
            this.Load += new System.EventHandler(this.FrmIngresos_Load);
            this.gbRefacciones.ResumeLayout(false);
            this.gbRefacciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridID)).EndInit();
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRefacciones;
        private System.Windows.Forms.ComboBox cmbTipoIngreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnTipoIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminarRefaccion;
        private System.Windows.Forms.Button btnAgregarRefaccion;
        private System.Windows.Forms.DataGridView dataGridID;
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBuscarpermisionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.ComboBox cmbLineaNegocio;
        private System.Windows.Forms.Button btnLineaNegocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCubierta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLineaNegDesc;
    }
}