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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPermitholder = new System.Windows.Forms.ComboBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegCredito = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.gbRefacciones = new System.Windows.Forms.GroupBox();
            this.cmbRefacciones = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminarRefaccion = new System.Windows.Forms.Button();
            this.btnAgregarRefaccion = new System.Windows.Forms.Button();
            this.dataGridRefacciones = new System.Windows.Forms.DataGridView();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreMec = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescWork = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantSvc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCostoWork = new System.Windows.Forms.TextBox();
            this.cmbMecanico = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.dataGridSvc = new System.Windows.Forms.DataGridView();
            this.gbVenta.SuspendLayout();
            this.gbRefacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRefacciones)).BeginInit();
            this.gbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSvc)).BeginInit();
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
            // cmbPermitholder
            // 
            this.cmbPermitholder.FormattingEnabled = true;
            this.cmbPermitholder.Location = new System.Drawing.Point(304, 19);
            this.cmbPermitholder.Name = "cmbPermitholder";
            this.cmbPermitholder.Size = new System.Drawing.Size(187, 21);
            this.cmbPermitholder.TabIndex = 24;
            // 
            // txtCredito
            // 
            this.txtCredito.Enabled = false;
            this.txtCredito.Location = new System.Drawing.Point(174, 60);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(43, 20);
            this.txtCredito.TabIndex = 23;
            this.txtCredito.TextChanged += new System.EventHandler(this.txtCredito_TextChanged);
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
            // btnRegCredito
            // 
            this.btnRegCredito.Enabled = false;
            this.btnRegCredito.Location = new System.Drawing.Point(219, 59);
            this.btnRegCredito.Name = "btnRegCredito";
            this.btnRegCredito.Size = new System.Drawing.Size(92, 23);
            this.btnRegCredito.TabIndex = 21;
            this.btnRegCredito.Text = "Registrar crédito";
            this.btnRegCredito.UseVisualStyleBackColor = true;
            this.btnRegCredito.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(550, 59);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 23);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(461, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar venta";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(44, 60);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(78, 21);
            this.cmbTipo.TabIndex = 18;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
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
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(356, 60);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTotal.TabIndex = 15;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Permisionario:";
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
            this.txtRecibo.TextChanged += new System.EventHandler(this.txtRecibo_TextChanged);
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
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // gbRefacciones
            // 
            this.gbRefacciones.Controls.Add(this.cmbRefacciones);
            this.gbRefacciones.Controls.Add(this.label11);
            this.gbRefacciones.Controls.Add(this.txtDescripcion);
            this.gbRefacciones.Controls.Add(this.label8);
            this.gbRefacciones.Controls.Add(this.txtCantidad);
            this.gbRefacciones.Controls.Add(this.label9);
            this.gbRefacciones.Controls.Add(this.txtPrecio);
            this.gbRefacciones.Controls.Add(this.button2);
            this.gbRefacciones.Controls.Add(this.label10);
            this.gbRefacciones.Controls.Add(this.btnEliminarRefaccion);
            this.gbRefacciones.Controls.Add(this.btnAgregarRefaccion);
            this.gbRefacciones.Controls.Add(this.dataGridRefacciones);
            this.gbRefacciones.Location = new System.Drawing.Point(30, 105);
            this.gbRefacciones.Name = "gbRefacciones";
            this.gbRefacciones.Size = new System.Drawing.Size(740, 222);
            this.gbRefacciones.TabIndex = 1;
            this.gbRefacciones.TabStop = false;
            this.gbRefacciones.Text = "Datos de refacciones ";
            // 
            // cmbRefacciones
            // 
            this.cmbRefacciones.FormattingEnabled = true;
            this.cmbRefacciones.Location = new System.Drawing.Point(11, 39);
            this.cmbRefacciones.Name = "cmbRefacciones";
            this.cmbRefacciones.Size = new System.Drawing.Size(107, 21);
            this.cmbRefacciones.TabIndex = 26;
            this.cmbRefacciones.SelectedIndexChanged += new System.EventHandler(this.cmbRefacciones_SelectedIndexChanged);
            this.cmbRefacciones.TextChanged += new System.EventHandler(this.cmbRefacciones_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(209, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(140, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(461, 39);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(355, 39);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Refacción:";
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
            // dataGridRefacciones
            // 
            this.dataGridRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRefacciones.Location = new System.Drawing.Point(6, 65);
            this.dataGridRefacciones.MultiSelect = false;
            this.dataGridRefacciones.Name = "dataGridRefacciones";
            this.dataGridRefacciones.ReadOnly = true;
            this.dataGridRefacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRefacciones.Size = new System.Drawing.Size(728, 148);
            this.dataGridRefacciones.TabIndex = 0;
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.label17);
            this.gbServicios.Controls.Add(this.txtNombreMec);
            this.gbServicios.Controls.Add(this.label14);
            this.gbServicios.Controls.Add(this.txtDescWork);
            this.gbServicios.Controls.Add(this.label15);
            this.gbServicios.Controls.Add(this.txtCantSvc);
            this.gbServicios.Controls.Add(this.label16);
            this.gbServicios.Controls.Add(this.txtCostoWork);
            this.gbServicios.Controls.Add(this.cmbMecanico);
            this.gbServicios.Controls.Add(this.button3);
            this.gbServicios.Controls.Add(this.label13);
            this.gbServicios.Controls.Add(this.cmbServicio);
            this.gbServicios.Controls.Add(this.btnBuscarServicio);
            this.gbServicios.Controls.Add(this.label12);
            this.gbServicios.Controls.Add(this.btnEliminarServicio);
            this.gbServicios.Controls.Add(this.btnAgregarServicio);
            this.gbServicios.Controls.Add(this.dataGridSvc);
            this.gbServicios.Location = new System.Drawing.Point(30, 333);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(740, 225);
            this.gbServicios.TabIndex = 2;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = " Datos de servicios ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(260, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Nombre:";
            // 
            // txtNombreMec
            // 
            this.txtNombreMec.Enabled = false;
            this.txtNombreMec.Location = new System.Drawing.Point(328, 53);
            this.txtNombreMec.Name = "txtNombreMec";
            this.txtNombreMec.Size = new System.Drawing.Size(219, 20);
            this.txtNombreMec.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Descripción:";
            // 
            // txtDescWork
            // 
            this.txtDescWork.Enabled = false;
            this.txtDescWork.Location = new System.Drawing.Point(328, 16);
            this.txtDescWork.Name = "txtDescWork";
            this.txtDescWork.Size = new System.Drawing.Size(174, 20);
            this.txtDescWork.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(614, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Cantidad:";
            // 
            // txtCantSvc
            // 
            this.txtCantSvc.Location = new System.Drawing.Point(669, 16);
            this.txtCantSvc.Name = "txtCantSvc";
            this.txtCantSvc.Size = new System.Drawing.Size(65, 20);
            this.txtCantSvc.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(507, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Costo:";
            // 
            // txtCostoWork
            // 
            this.txtCostoWork.Enabled = false;
            this.txtCostoWork.Location = new System.Drawing.Point(547, 15);
            this.txtCostoWork.Name = "txtCostoWork";
            this.txtCostoWork.Size = new System.Drawing.Size(65, 20);
            this.txtCostoWork.TabIndex = 33;
            // 
            // cmbMecanico
            // 
            this.cmbMecanico.FormattingEnabled = true;
            this.cmbMecanico.Location = new System.Drawing.Point(60, 53);
            this.cmbMecanico.Name = "cmbMecanico";
            this.cmbMecanico.Size = new System.Drawing.Size(117, 21);
            this.cmbMecanico.TabIndex = 32;
            this.cmbMecanico.SelectedIndexChanged += new System.EventHandler(this.cmbMecanico_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mecánico:";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(60, 16);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(117, 21);
            this.cmbServicio.TabIndex = 29;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Location = new System.Drawing.Point(183, 15);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarServicio.TabIndex = 28;
            this.btnBuscarServicio.Text = "Buscar";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Servicio:";
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Location = new System.Drawing.Point(569, 53);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarServicio.TabIndex = 17;
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(659, 53);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarServicio.TabIndex = 16;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // dataGridSvc
            // 
            this.dataGridSvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSvc.Location = new System.Drawing.Point(6, 85);
            this.dataGridSvc.MultiSelect = false;
            this.dataGridSvc.Name = "dataGridSvc";
            this.dataGridSvc.ReadOnly = true;
            this.dataGridSvc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSvc.Size = new System.Drawing.Size(728, 134);
            this.dataGridSvc.TabIndex = 1;
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
            this.gbRefacciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRefacciones)).EndInit();
            this.gbServicios.ResumeLayout(false);
            this.gbServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSvc)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridRefacciones;
        private System.Windows.Forms.DataGridView dataGridSvc;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRefacciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescWork;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantSvc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCostoWork;
        private System.Windows.Forms.ComboBox cmbMecanico;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreMec;
    }
}