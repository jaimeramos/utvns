﻿namespace Principal
{
    partial class FrmVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgVehiculos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndtgEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtSeriemotor = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpActualizacion = new System.Windows.Forms.DateTimePicker();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.btnVactualizar = new System.Windows.Forms.Button();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnVguardar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnVeditar = new System.Windows.Forms.Button();
            this.btnVregistro = new System.Windows.Forms.Button();
            this.btnVfiltrar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).BeginInit();
            this.gbVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVehiculos
            // 
            this.dtgVehiculos.AllowUserToDeleteRows = false;
            this.dtgVehiculos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgVehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiculos.BackgroundColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.btndtgEditar});
            this.dtgVehiculos.Location = new System.Drawing.Point(29, 104);
            this.dtgVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVehiculos.Name = "dtgVehiculos";
            this.dtgVehiculos.ReadOnly = true;
            this.dtgVehiculos.Size = new System.Drawing.Size(983, 224);
            this.dtgVehiculos.TabIndex = 0;
            this.dtgVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 77.48927F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 77.48927F;
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 77.48927F;
            this.Column3.HeaderText = "Modelo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 77.48927F;
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FillWeight = 77.48927F;
            this.Column5.HeaderText = "Descripción";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 77.48927F;
            this.Column6.HeaderText = "Año";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 77.48927F;
            this.Column7.HeaderText = "Color";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 77.48927F;
            this.Column8.HeaderText = "Serie";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 77.48927F;
            this.Column9.HeaderText = "Serie del Motor";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 77.48927F;
            this.Column10.HeaderText = "Numero de Placa";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 77.48927F;
            this.Column11.HeaderText = "Estatus";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 77.48927F;
            this.Column12.HeaderText = "Fecha de Alta";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column13.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column13.FillWeight = 77.48927F;
            this.Column13.HeaderText = "Fecha de Actualización";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // btndtgEditar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Olive;
            this.btndtgEditar.DefaultCellStyle = dataGridViewCellStyle5;
            this.btndtgEditar.FillWeight = 50F;
            this.btndtgEditar.HeaderText = "mod";
            this.btndtgEditar.Name = "btndtgEditar";
            this.btndtgEditar.ReadOnly = true;
            this.btndtgEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.btndtgEditar.Text = "Edit";
            this.btndtgEditar.ToolTipText = "Editar Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(65, 52);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(84, 23);
            this.txbID.TabIndex = 5;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(357, 97);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(98, 23);
            this.txtPlaca.TabIndex = 69;
            // 
            // txtSeriemotor
            // 
            this.txtSeriemotor.Location = new System.Drawing.Point(93, 97);
            this.txtSeriemotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeriemotor.Name = "txtSeriemotor";
            this.txtSeriemotor.Size = new System.Drawing.Size(160, 23);
            this.txtSeriemotor.TabIndex = 66;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(558, 43);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(120, 23);
            this.txtSerie.TabIndex = 65;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(421, 46);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(98, 23);
            this.txtColor.TabIndex = 63;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(292, 46);
            this.txtAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(79, 23);
            this.txtAño.TabIndex = 61;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(83, 52);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 37);
            this.txtDescripcion.TabIndex = 58;
            // 
            // dtpActualizacion
            // 
            this.dtpActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActualizacion.Location = new System.Drawing.Point(461, 127);
            this.dtpActualizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpActualizacion.Name = "dtpActualizacion";
            this.dtpActualizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpActualizacion.Size = new System.Drawing.Size(156, 23);
            this.dtpActualizacion.TabIndex = 75;
            // 
            // dtpAlta
            // 
            this.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlta.Location = new System.Drawing.Point(153, 128);
            this.dtpAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAlta.Size = new System.Drawing.Size(156, 23);
            this.dtpAlta.TabIndex = 72;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(302, 18);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(160, 23);
            this.txtModelo.TabIndex = 55;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(171, 18);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 23);
            this.txtNumero.TabIndex = 52;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 23);
            this.txtID.TabIndex = 51;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 74;
            this.label13.Text = "Fecha de Actualización:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 73;
            this.label12.Text = "Fecha de Alta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 71;
            this.label11.Text = "Estatus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de Placa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 67;
            this.label9.Text = "Serie del Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "Serie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Numero:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 50;
            this.label14.Text = "ID:";
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.btnVactualizar);
            this.gbVehiculos.Controls.Add(this.cmbEstatus);
            this.gbVehiculos.Controls.Add(this.cmbTipo);
            this.gbVehiculos.Controls.Add(this.txtID);
            this.gbVehiculos.Controls.Add(this.label14);
            this.gbVehiculos.Controls.Add(this.dtpActualizacion);
            this.gbVehiculos.Controls.Add(this.txtNumero);
            this.gbVehiculos.Controls.Add(this.btnVguardar);
            this.gbVehiculos.Controls.Add(this.label2);
            this.gbVehiculos.Controls.Add(this.label13);
            this.gbVehiculos.Controls.Add(this.txtModelo);
            this.gbVehiculos.Controls.Add(this.txtSerie);
            this.gbVehiculos.Controls.Add(this.dtpAlta);
            this.gbVehiculos.Controls.Add(this.label3);
            this.gbVehiculos.Controls.Add(this.label4);
            this.gbVehiculos.Controls.Add(this.label5);
            this.gbVehiculos.Controls.Add(this.label12);
            this.gbVehiculos.Controls.Add(this.txtColor);
            this.gbVehiculos.Controls.Add(this.txtDescripcion);
            this.gbVehiculos.Controls.Add(this.txtPlaca);
            this.gbVehiculos.Controls.Add(this.label11);
            this.gbVehiculos.Controls.Add(this.label6);
            this.gbVehiculos.Controls.Add(this.txtSeriemotor);
            this.gbVehiculos.Controls.Add(this.label10);
            this.gbVehiculos.Controls.Add(this.txtAño);
            this.gbVehiculos.Controls.Add(this.label7);
            this.gbVehiculos.Controls.Add(this.label9);
            this.gbVehiculos.Controls.Add(this.label8);
            this.gbVehiculos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehiculos.Location = new System.Drawing.Point(29, 342);
            this.gbVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehiculos.Size = new System.Drawing.Size(802, 171);
            this.gbVehiculos.TabIndex = 79;
            this.gbVehiculos.TabStop = false;
            this.gbVehiculos.Text = "Datos del Vehiculo";
            // 
            // btnVactualizar
            // 
            this.btnVactualizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVactualizar.Location = new System.Drawing.Point(724, 91);
            this.btnVactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVactualizar.Name = "btnVactualizar";
            this.btnVactualizar.Size = new System.Drawing.Size(66, 60);
            this.btnVactualizar.TabIndex = 77;
            this.btnVactualizar.Text = "Actualizar";
            this.btnVactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVactualizar.UseVisualStyleBackColor = true;
            this.btnVactualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.cmbEstatus.Location = new System.Drawing.Point(514, 96);
            this.cmbEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(120, 23);
            this.cmbEstatus.TabIndex = 76;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Taxi Ejecutivo",
            "Taxi Tradicional",
            "Taxi Radio"});
            this.cmbTipo.Location = new System.Drawing.Point(503, 17);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(106, 23);
            this.cmbTipo.TabIndex = 60;
            // 
            // btnVguardar
            // 
            this.btnVguardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVguardar.Location = new System.Drawing.Point(724, 18);
            this.btnVguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVguardar.Name = "btnVguardar";
            this.btnVguardar.Size = new System.Drawing.Size(66, 60);
            this.btnVguardar.TabIndex = 1;
            this.btnVguardar.Text = "Guardar";
            this.btnVguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVguardar.UseVisualStyleBackColor = true;
            this.btnVguardar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(524, 49);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(74, 25);
            this.btnVolver.TabIndex = 81;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVeditar
            // 
            this.btnVeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeditar.Location = new System.Drawing.Point(425, 49);
            this.btnVeditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVeditar.Name = "btnVeditar";
            this.btnVeditar.Size = new System.Drawing.Size(74, 25);
            this.btnVeditar.TabIndex = 80;
            this.btnVeditar.Text = "Editar";
            this.btnVeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeditar.UseVisualStyleBackColor = true;
            this.btnVeditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // btnVregistro
            // 
            this.btnVregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVregistro.Location = new System.Drawing.Point(289, 49);
            this.btnVregistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVregistro.Name = "btnVregistro";
            this.btnVregistro.Size = new System.Drawing.Size(121, 25);
            this.btnVregistro.TabIndex = 76;
            this.btnVregistro.Text = "Nuevo Registro";
            this.btnVregistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVregistro.UseVisualStyleBackColor = true;
            this.btnVregistro.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnVfiltrar
            // 
            this.btnVfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVfiltrar.Location = new System.Drawing.Point(154, 49);
            this.btnVfiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVfiltrar.Name = "btnVfiltrar";
            this.btnVfiltrar.Size = new System.Drawing.Size(71, 25);
            this.btnVfiltrar.TabIndex = 2;
            this.btnVfiltrar.Text = "Filtrar";
            this.btnVfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVfiltrar.UseVisualStyleBackColor = true;
            this.btnVfiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "mod";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 39;
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 524);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVeditar);
            this.Controls.Add(this.gbVehiculos);
            this.Controls.Add(this.btnVregistro);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVfiltrar);
            this.Controls.Add(this.dtgVehiculos);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).EndInit();
            this.gbVehiculos.ResumeLayout(false);
            this.gbVehiculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVehiculos;
        private System.Windows.Forms.Button btnVguardar;
        private System.Windows.Forms.Button btnVfiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnVregistro;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtSeriemotor;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpActualizacion;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbVehiculos;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnVeditar;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Button btnVactualizar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn btndtgEditar;
        private System.Windows.Forms.Button btnVolver;
    }
}