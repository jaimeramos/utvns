namespace Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculos));
            this.txtVplaca = new System.Windows.Forms.TextBox();
            this.txtVseriemotor = new System.Windows.Forms.TextBox();
            this.txtVserie = new System.Windows.Forms.TextBox();
            this.txtVcolor = new System.Windows.Forms.TextBox();
            this.txtVaño = new System.Windows.Forms.TextBox();
            this.txtVdescripcion = new System.Windows.Forms.TextBox();
            this.txtVmodelo = new System.Windows.Forms.TextBox();
            this.txtVnumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.cmbPermit = new System.Windows.Forms.ComboBox();
            this.cmbPermitholder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVmarca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVcancelar = new System.Windows.Forms.Button();
            this.btnVguardar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbVehiculos1 = new System.Windows.Forms.GroupBox();
            this.chbVehiculos = new System.Windows.Forms.CheckBox();
            this.btnVeditar = new System.Windows.Forms.Button();
            this.btnVregresar = new System.Windows.Forms.Button();
            this.btnVnuevo = new System.Windows.Forms.Button();
            this.btnVFiltrar = new System.Windows.Forms.Button();
            this.dtgVehiculo = new System.Windows.Forms.DataGridView();
            this.txtVfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVehiculos.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbVehiculos1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVplaca
            // 
            this.txtVplaca.Location = new System.Drawing.Point(427, 76);
            this.txtVplaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVplaca.Name = "txtVplaca";
            this.txtVplaca.Size = new System.Drawing.Size(160, 23);
            this.txtVplaca.TabIndex = 7;
            // 
            // txtVseriemotor
            // 
            this.txtVseriemotor.Location = new System.Drawing.Point(427, 46);
            this.txtVseriemotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVseriemotor.Name = "txtVseriemotor";
            this.txtVseriemotor.Size = new System.Drawing.Size(160, 23);
            this.txtVseriemotor.TabIndex = 6;
            // 
            // txtVserie
            // 
            this.txtVserie.Location = new System.Drawing.Point(427, 16);
            this.txtVserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVserie.Name = "txtVserie";
            this.txtVserie.Size = new System.Drawing.Size(160, 23);
            this.txtVserie.TabIndex = 5;
            // 
            // txtVcolor
            // 
            this.txtVcolor.Location = new System.Drawing.Point(111, 104);
            this.txtVcolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVcolor.Name = "txtVcolor";
            this.txtVcolor.Size = new System.Drawing.Size(183, 23);
            this.txtVcolor.TabIndex = 3;
            this.txtVcolor.TextChanged += new System.EventHandler(this.txtVcolor_TextChanged);
            // 
            // txtVaño
            // 
            this.txtVaño.Location = new System.Drawing.Point(111, 132);
            this.txtVaño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVaño.Name = "txtVaño";
            this.txtVaño.Size = new System.Drawing.Size(183, 23);
            this.txtVaño.TabIndex = 4;
            // 
            // txtVdescripcion
            // 
            this.txtVdescripcion.Location = new System.Drawing.Point(111, 160);
            this.txtVdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVdescripcion.Multiline = true;
            this.txtVdescripcion.Name = "txtVdescripcion";
            this.txtVdescripcion.Size = new System.Drawing.Size(622, 45);
            this.txtVdescripcion.TabIndex = 10;
            // 
            // txtVmodelo
            // 
            this.txtVmodelo.Location = new System.Drawing.Point(111, 76);
            this.txtVmodelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVmodelo.Name = "txtVmodelo";
            this.txtVmodelo.Size = new System.Drawing.Size(183, 23);
            this.txtVmodelo.TabIndex = 2;
            // 
            // txtVnumero
            // 
            this.txtVnumero.Location = new System.Drawing.Point(111, 20);
            this.txtVnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVnumero.Name = "txtVnumero";
            this.txtVnumero.Size = new System.Drawing.Size(183, 23);
            this.txtVnumero.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 71;
            this.label11.Text = "Chofer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de Placa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 67;
            this.label9.Text = "Serie del Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "Serie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Numero:";
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.button2);
            this.gbVehiculos.Controls.Add(this.button1);
            this.gbVehiculos.Controls.Add(this.gbStatus);
            this.gbVehiculos.Controls.Add(this.cmbPermit);
            this.gbVehiculos.Controls.Add(this.cmbPermitholder);
            this.gbVehiculos.Controls.Add(this.label4);
            this.gbVehiculos.Controls.Add(this.txtVmarca);
            this.gbVehiculos.Controls.Add(this.label14);
            this.gbVehiculos.Controls.Add(this.btnVcancelar);
            this.gbVehiculos.Controls.Add(this.btnVguardar);
            this.gbVehiculos.Controls.Add(this.txtVnumero);
            this.gbVehiculos.Controls.Add(this.label2);
            this.gbVehiculos.Controls.Add(this.txtVmodelo);
            this.gbVehiculos.Controls.Add(this.txtVserie);
            this.gbVehiculos.Controls.Add(this.label3);
            this.gbVehiculos.Controls.Add(this.label5);
            this.gbVehiculos.Controls.Add(this.txtVcolor);
            this.gbVehiculos.Controls.Add(this.txtVdescripcion);
            this.gbVehiculos.Controls.Add(this.txtVplaca);
            this.gbVehiculos.Controls.Add(this.label11);
            this.gbVehiculos.Controls.Add(this.label6);
            this.gbVehiculos.Controls.Add(this.txtVseriemotor);
            this.gbVehiculos.Controls.Add(this.label10);
            this.gbVehiculos.Controls.Add(this.txtVaño);
            this.gbVehiculos.Controls.Add(this.label7);
            this.gbVehiculos.Controls.Add(this.label9);
            this.gbVehiculos.Controls.Add(this.label8);
            this.gbVehiculos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehiculos.Location = new System.Drawing.Point(29, 367);
            this.gbVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehiculos.Size = new System.Drawing.Size(939, 212);
            this.gbVehiculos.TabIndex = 79;
            this.gbVehiculos.TabStop = false;
            this.gbVehiculos.Text = "Datos del Vehiculo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Buscar chofer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar permiso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactivo);
            this.gbStatus.Controls.Add(this.rbActivo);
            this.gbStatus.Location = new System.Drawing.Point(620, 16);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(113, 77);
            this.gbStatus.TabIndex = 116;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(34, 47);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(67, 19);
            this.rbInactivo.TabIndex = 11;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(34, 22);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(59, 19);
            this.rbActivo.TabIndex = 10;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // cmbPermit
            // 
            this.cmbPermit.FormattingEnabled = true;
            this.cmbPermit.Location = new System.Drawing.Point(427, 106);
            this.cmbPermit.Name = "cmbPermit";
            this.cmbPermit.Size = new System.Drawing.Size(194, 23);
            this.cmbPermit.TabIndex = 8;
            // 
            // cmbPermitholder
            // 
            this.cmbPermitholder.FormattingEnabled = true;
            this.cmbPermitholder.Location = new System.Drawing.Point(427, 136);
            this.cmbPermitholder.Name = "cmbPermitholder";
            this.cmbPermitholder.Size = new System.Drawing.Size(194, 23);
            this.cmbPermitholder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 92;
            this.label4.Text = "Permiso:";
            // 
            // txtVmarca
            // 
            this.txtVmarca.Location = new System.Drawing.Point(111, 48);
            this.txtVmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVmarca.Name = "txtVmarca";
            this.txtVmarca.Size = new System.Drawing.Size(183, 23);
            this.txtVmarca.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 89;
            this.label14.Text = "Marca:";
            // 
            // btnVcancelar
            // 
            this.btnVcancelar.FlatAppearance.BorderSize = 0;
            this.btnVcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVcancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnVcancelar.Image")));
            this.btnVcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVcancelar.Location = new System.Drawing.Point(788, 119);
            this.btnVcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVcancelar.Name = "btnVcancelar";
            this.btnVcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnVcancelar.TabIndex = 15;
            this.btnVcancelar.Text = "Cancelar";
            this.btnVcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVcancelar.UseVisualStyleBackColor = true;
            this.btnVcancelar.Click += new System.EventHandler(this.btnVcancelar_Click);
            // 
            // btnVguardar
            // 
            this.btnVguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVguardar.FlatAppearance.BorderSize = 0;
            this.btnVguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVguardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnVguardar.Image")));
            this.btnVguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVguardar.Location = new System.Drawing.Point(788, 42);
            this.btnVguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVguardar.Name = "btnVguardar";
            this.btnVguardar.Size = new System.Drawing.Size(115, 40);
            this.btnVguardar.TabIndex = 14;
            this.btnVguardar.Text = "Guardar";
            this.btnVguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVguardar.UseVisualStyleBackColor = true;
            this.btnVguardar.Click += new System.EventHandler(this.btnVguardar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "mod";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 39;
            // 
            // gbVehiculos1
            // 
            this.gbVehiculos1.Controls.Add(this.chbVehiculos);
            this.gbVehiculos1.Controls.Add(this.btnVeditar);
            this.gbVehiculos1.Controls.Add(this.btnVregresar);
            this.gbVehiculos1.Controls.Add(this.btnVnuevo);
            this.gbVehiculos1.Controls.Add(this.btnVFiltrar);
            this.gbVehiculos1.Controls.Add(this.dtgVehiculo);
            this.gbVehiculos1.Controls.Add(this.txtVfiltro);
            this.gbVehiculos1.Controls.Add(this.label1);
            this.gbVehiculos1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehiculos1.Location = new System.Drawing.Point(29, 26);
            this.gbVehiculos1.Name = "gbVehiculos1";
            this.gbVehiculos1.Size = new System.Drawing.Size(939, 336);
            this.gbVehiculos1.TabIndex = 87;
            this.gbVehiculos1.TabStop = false;
            // 
            // chbVehiculos
            // 
            this.chbVehiculos.AutoSize = true;
            this.chbVehiculos.Checked = true;
            this.chbVehiculos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVehiculos.Location = new System.Drawing.Point(740, 311);
            this.chbVehiculos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chbVehiculos.Name = "chbVehiculos";
            this.chbVehiculos.Size = new System.Drawing.Size(176, 19);
            this.chbVehiculos.TabIndex = 94;
            this.chbVehiculos.Text = "Mostrar todos los Vehículos";
            this.chbVehiculos.UseVisualStyleBackColor = true;
            this.chbVehiculos.CheckedChanged += new System.EventHandler(this.chbVehiculos_CheckedChanged);
            // 
            // btnVeditar
            // 
            this.btnVeditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVeditar.FlatAppearance.BorderSize = 0;
            this.btnVeditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeditar.Image = ((System.Drawing.Image)(resources.GetObject("btnVeditar.Image")));
            this.btnVeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeditar.Location = new System.Drawing.Point(631, 29);
            this.btnVeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVeditar.Name = "btnVeditar";
            this.btnVeditar.Size = new System.Drawing.Size(136, 40);
            this.btnVeditar.TabIndex = 92;
            this.btnVeditar.Text = "Editar Vehículo";
            this.btnVeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeditar.UseVisualStyleBackColor = true;
            this.btnVeditar.Click += new System.EventHandler(this.btnVeditar_Click);
            // 
            // btnVregresar
            // 
            this.btnVregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVregresar.FlatAppearance.BorderSize = 0;
            this.btnVregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnVregresar.Image")));
            this.btnVregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVregresar.Location = new System.Drawing.Point(817, 29);
            this.btnVregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVregresar.Name = "btnVregresar";
            this.btnVregresar.Size = new System.Drawing.Size(98, 40);
            this.btnVregresar.TabIndex = 93;
            this.btnVregresar.Text = "Regresar";
            this.btnVregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVregresar.UseVisualStyleBackColor = true;
            this.btnVregresar.Click += new System.EventHandler(this.btnVregresar_Click);
            // 
            // btnVnuevo
            // 
            this.btnVnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVnuevo.FlatAppearance.BorderSize = 0;
            this.btnVnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnVnuevo.Image")));
            this.btnVnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVnuevo.Location = new System.Drawing.Point(435, 29);
            this.btnVnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVnuevo.Name = "btnVnuevo";
            this.btnVnuevo.Size = new System.Drawing.Size(146, 40);
            this.btnVnuevo.TabIndex = 91;
            this.btnVnuevo.Text = "Nuevo Vehículo";
            this.btnVnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVnuevo.UseVisualStyleBackColor = true;
            this.btnVnuevo.Click += new System.EventHandler(this.btnVnuevo_Click);
            // 
            // btnVFiltrar
            // 
            this.btnVFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVFiltrar.FlatAppearance.BorderSize = 0;
            this.btnVFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnVFiltrar.Image")));
            this.btnVFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVFiltrar.Location = new System.Drawing.Point(268, 29);
            this.btnVFiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVFiltrar.Name = "btnVFiltrar";
            this.btnVFiltrar.Size = new System.Drawing.Size(117, 40);
            this.btnVFiltrar.TabIndex = 90;
            this.btnVFiltrar.Text = "Limpiar Filtro";
            this.btnVFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVFiltrar.UseVisualStyleBackColor = true;
            this.btnVFiltrar.Click += new System.EventHandler(this.btnVFiltrar_Click);
            // 
            // dtgVehiculo
            // 
            this.dtgVehiculo.AllowUserToAddRows = false;
            this.dtgVehiculo.AllowUserToDeleteRows = false;
            this.dtgVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculo.Location = new System.Drawing.Point(21, 76);
            this.dtgVehiculo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgVehiculo.Name = "dtgVehiculo";
            this.dtgVehiculo.ReadOnly = true;
            this.dtgVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVehiculo.Size = new System.Drawing.Size(895, 228);
            this.dtgVehiculo.TabIndex = 89;
            this.dtgVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculo_CellContentClick);
            this.dtgVehiculo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculo_RowEnter);
            // 
            // txtVfiltro
            // 
            this.txtVfiltro.Location = new System.Drawing.Point(68, 39);
            this.txtVfiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVfiltro.Name = "txtVfiltro";
            this.txtVfiltro.Size = new System.Drawing.Size(144, 23);
            this.txtVfiltro.TabIndex = 88;
            this.txtVfiltro.TextChanged += new System.EventHandler(this.txtVfiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "Filtro";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 593);
            this.Controls.Add(this.gbVehiculos1);
            this.Controls.Add(this.gbVehiculos);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTVNS - Gestion de Vehículos del Sistema";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.gbVehiculos.ResumeLayout(false);
            this.gbVehiculos.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbVehiculos1.ResumeLayout(false);
            this.gbVehiculos1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtVplaca;
        private System.Windows.Forms.TextBox txtVseriemotor;
        private System.Windows.Forms.TextBox txtVserie;
        private System.Windows.Forms.TextBox txtVcolor;
        private System.Windows.Forms.TextBox txtVaño;
        private System.Windows.Forms.TextBox txtVdescripcion;
        private System.Windows.Forms.TextBox txtVmodelo;
        private System.Windows.Forms.TextBox txtVnumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbVehiculos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVcancelar;
        private System.Windows.Forms.Button btnVguardar;
        private System.Windows.Forms.GroupBox gbVehiculos1;
        private System.Windows.Forms.Button btnVeditar;
        private System.Windows.Forms.Button btnVregresar;
        private System.Windows.Forms.Button btnVnuevo;
        private System.Windows.Forms.Button btnVFiltrar;
        private System.Windows.Forms.DataGridView dtgVehiculo;
        private System.Windows.Forms.TextBox txtVfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbVehiculos;
        private System.Windows.Forms.TextBox txtVmarca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPermitholder;
        private System.Windows.Forms.ComboBox cmbPermit;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}