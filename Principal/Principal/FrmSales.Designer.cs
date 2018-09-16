namespace Principal
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.gbRefacciones = new System.Windows.Forms.GroupBox();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarpermisionario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAgregarRefaccion = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRegCredito = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnEliminarRefaccion = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.cmbPermitholder = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbVenta.SuspendLayout();
            this.gbRefacciones.SuspendLayout();
            this.gbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.button1);
            this.gbVenta.Controls.Add(this.cmbPermitholder);
            this.gbVenta.Controls.Add(this.txtCredito);
            this.gbVenta.Controls.Add(this.label7);
            this.gbVenta.Controls.Add(this.btnRegCredito);
            this.gbVenta.Controls.Add(this.btnConfirmar);
            this.gbVenta.Controls.Add(this.btnGuardar);
            this.gbVenta.Controls.Add(this.cmbTipo);
            this.gbVenta.Controls.Add(this.label6);
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
            this.gbVenta.Location = new System.Drawing.Point(30, 12);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(740, 92);
            this.gbVenta.TabIndex = 0;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Venta de refacciones y servicios ";
            // 
            // gbRefacciones
            // 
            this.gbRefacciones.Controls.Add(this.btnEliminarRefaccion);
            this.gbRefacciones.Controls.Add(this.btnAgregarRefaccion);
            this.gbRefacciones.Controls.Add(this.dataGridView1);
            this.gbRefacciones.Location = new System.Drawing.Point(30, 105);
            this.gbRefacciones.Name = "gbRefacciones";
            this.gbRefacciones.Size = new System.Drawing.Size(740, 222);
            this.gbRefacciones.TabIndex = 1;
            this.gbRefacciones.TabStop = false;
            this.gbRefacciones.Text = "Datos de refacciones ";
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.btnEliminarServicio);
            this.gbServicios.Controls.Add(this.btnAgregarServicio);
            this.gbServicios.Controls.Add(this.dataGridView2);
            this.gbServicios.Location = new System.Drawing.Point(30, 333);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(740, 225);
            this.gbServicios.TabIndex = 2;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = " Datos de servicios ";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(44, 21);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(53, 20);
            this.txtFolio.TabIndex = 4;
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
            this.txtRecibo.Location = new System.Drawing.Point(158, 21);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(59, 20);
            this.txtRecibo.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(631, 21);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(94, 20);
            this.dtpFecha.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Permisionario:";
            // 
            // btnBuscarpermisionario
            // 
            this.btnBuscarpermisionario.Location = new System.Drawing.Point(502, 20);
            this.btnBuscarpermisionario.Name = "btnBuscarpermisionario";
            this.btnBuscarpermisionario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarpermisionario.TabIndex = 14;
            this.btnBuscarpermisionario.Text = "Buscar";
            this.btnBuscarpermisionario.UseVisualStyleBackColor = true;
            this.btnBuscarpermisionario.Click += new System.EventHandler(this.btnBuscarpermisionario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total: $";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(356, 60);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(44, 60);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(78, 21);
            this.cmbTipo.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(728, 177);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnAgregarRefaccion
            // 
            this.btnAgregarRefaccion.Location = new System.Drawing.Point(659, 14);
            this.btnAgregarRefaccion.Name = "btnAgregarRefaccion";
            this.btnAgregarRefaccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRefaccion.TabIndex = 15;
            this.btnAgregarRefaccion.Text = "Agregar";
            this.btnAgregarRefaccion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(659, 13);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarServicio.TabIndex = 16;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(461, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar venta";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(550, 59);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 23);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnRegCredito
            // 
            this.btnRegCredito.Location = new System.Drawing.Point(219, 59);
            this.btnRegCredito.Name = "btnRegCredito";
            this.btnRegCredito.Size = new System.Drawing.Size(92, 23);
            this.btnRegCredito.TabIndex = 21;
            this.btnRegCredito.Text = "Registrar crédito";
            this.btnRegCredito.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "No.Cred.";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(174, 60);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(43, 20);
            this.txtCredito.TabIndex = 23;
            // 
            // btnEliminarRefaccion
            // 
            this.btnEliminarRefaccion.Location = new System.Drawing.Point(578, 14);
            this.btnEliminarRefaccion.Name = "btnEliminarRefaccion";
            this.btnEliminarRefaccion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRefaccion.TabIndex = 16;
            this.btnEliminarRefaccion.Text = "Eliminar";
            this.btnEliminarRefaccion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Location = new System.Drawing.Point(578, 13);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarServicio.TabIndex = 17;
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            // 
            // cmbPermitholder
            // 
            this.cmbPermitholder.FormattingEnabled = true;
            this.cmbPermitholder.Location = new System.Drawing.Point(304, 19);
            this.cmbPermitholder.Name = "cmbPermitholder";
            this.cmbPermitholder.Size = new System.Drawing.Size(187, 21);
            this.cmbPermitholder.TabIndex = 24;
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
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.gbServicios);
            this.Controls.Add(this.gbRefacciones);
            this.Controls.Add(this.gbVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSales";
            this.Text = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            this.gbRefacciones.ResumeLayout(false);
            this.gbServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.GroupBox gbRefacciones;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBuscarpermisionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAgregarRefaccion;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegCredito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarRefaccion;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.ComboBox cmbPermitholder;
        private System.Windows.Forms.Button button1;
    }
}