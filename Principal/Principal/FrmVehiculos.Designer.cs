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
            this.dtpVfactualizacion = new System.Windows.Forms.DateTimePicker();
            this.dtpVfalta = new System.Windows.Forms.DateTimePicker();
            this.txtVmodelo = new System.Windows.Forms.TextBox();
            this.txtVnumero = new System.Windows.Forms.TextBox();
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
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.btnVcancelar = new System.Windows.Forms.Button();
            this.cmbVestatus = new System.Windows.Forms.ComboBox();
            this.btnVguardar = new System.Windows.Forms.Button();
            this.cmbVtipo = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbVehiculos = new System.Windows.Forms.CheckBox();
            this.btnVeditar = new System.Windows.Forms.Button();
            this.btnVregresar = new System.Windows.Forms.Button();
            this.btnVnuevo = new System.Windows.Forms.Button();
            this.btnVFiltrar = new System.Windows.Forms.Button();
            this.dtgVehiculos = new System.Windows.Forms.DataGridView();
            this.txtVfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVehiculos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVplaca
            // 
            this.txtVplaca.Location = new System.Drawing.Point(426, 83);
            this.txtVplaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVplaca.Name = "txtVplaca";
            this.txtVplaca.Size = new System.Drawing.Size(98, 23);
            this.txtVplaca.TabIndex = 69;
            // 
            // txtVseriemotor
            // 
            this.txtVseriemotor.Location = new System.Drawing.Point(426, 49);
            this.txtVseriemotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVseriemotor.Name = "txtVseriemotor";
            this.txtVseriemotor.Size = new System.Drawing.Size(160, 23);
            this.txtVseriemotor.TabIndex = 66;
            // 
            // txtVserie
            // 
            this.txtVserie.Location = new System.Drawing.Point(426, 15);
            this.txtVserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVserie.Name = "txtVserie";
            this.txtVserie.Size = new System.Drawing.Size(120, 23);
            this.txtVserie.TabIndex = 65;
            // 
            // txtVcolor
            // 
            this.txtVcolor.Location = new System.Drawing.Point(155, 190);
            this.txtVcolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVcolor.Name = "txtVcolor";
            this.txtVcolor.Size = new System.Drawing.Size(98, 23);
            this.txtVcolor.TabIndex = 63;
            // 
            // txtVaño
            // 
            this.txtVaño.Location = new System.Drawing.Point(155, 159);
            this.txtVaño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVaño.Name = "txtVaño";
            this.txtVaño.Size = new System.Drawing.Size(79, 23);
            this.txtVaño.TabIndex = 61;
            // 
            // txtVdescripcion
            // 
            this.txtVdescripcion.Location = new System.Drawing.Point(155, 114);
            this.txtVdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVdescripcion.Multiline = true;
            this.txtVdescripcion.Name = "txtVdescripcion";
            this.txtVdescripcion.Size = new System.Drawing.Size(168, 37);
            this.txtVdescripcion.TabIndex = 58;
            // 
            // dtpVfactualizacion
            // 
            this.dtpVfactualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVfactualizacion.Location = new System.Drawing.Point(426, 185);
            this.dtpVfactualizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpVfactualizacion.Name = "dtpVfactualizacion";
            this.dtpVfactualizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpVfactualizacion.Size = new System.Drawing.Size(156, 23);
            this.dtpVfactualizacion.TabIndex = 75;
            // 
            // dtpVfalta
            // 
            this.dtpVfalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVfalta.Location = new System.Drawing.Point(426, 151);
            this.dtpVfalta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpVfalta.Name = "dtpVfalta";
            this.dtpVfalta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpVfalta.Size = new System.Drawing.Size(156, 23);
            this.dtpVfalta.TabIndex = 72;
            // 
            // txtVmodelo
            // 
            this.txtVmodelo.Location = new System.Drawing.Point(155, 52);
            this.txtVmodelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVmodelo.Name = "txtVmodelo";
            this.txtVmodelo.Size = new System.Drawing.Size(130, 23);
            this.txtVmodelo.TabIndex = 55;
            // 
            // txtVnumero
            // 
            this.txtVnumero.Location = new System.Drawing.Point(155, 21);
            this.txtVnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVnumero.Name = "txtVnumero";
            this.txtVnumero.Size = new System.Drawing.Size(93, 23);
            this.txtVnumero.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 74;
            this.label13.Text = "Fecha de Actualización:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 73;
            this.label12.Text = "Fecha de Alta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 71;
            this.label11.Text = "Estatus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de Placa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 67;
            this.label9.Text = "Serie del Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "Serie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Numero:";
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.btnVcancelar);
            this.gbVehiculos.Controls.Add(this.cmbVestatus);
            this.gbVehiculos.Controls.Add(this.btnVguardar);
            this.gbVehiculos.Controls.Add(this.cmbVtipo);
            this.gbVehiculos.Controls.Add(this.dtpVfactualizacion);
            this.gbVehiculos.Controls.Add(this.txtVnumero);
            this.gbVehiculos.Controls.Add(this.label2);
            this.gbVehiculos.Controls.Add(this.label13);
            this.gbVehiculos.Controls.Add(this.txtVmodelo);
            this.gbVehiculos.Controls.Add(this.txtVserie);
            this.gbVehiculos.Controls.Add(this.dtpVfalta);
            this.gbVehiculos.Controls.Add(this.label3);
            this.gbVehiculos.Controls.Add(this.label4);
            this.gbVehiculos.Controls.Add(this.label5);
            this.gbVehiculos.Controls.Add(this.label12);
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
            this.gbVehiculos.Location = new System.Drawing.Point(29, 342);
            this.gbVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehiculos.Size = new System.Drawing.Size(867, 224);
            this.gbVehiculos.TabIndex = 79;
            this.gbVehiculos.TabStop = false;
            this.gbVehiculos.Text = "Datos del Vehiculo";
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
            this.btnVcancelar.Location = new System.Drawing.Point(670, 125);
            this.btnVcancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVcancelar.Name = "btnVcancelar";
            this.btnVcancelar.Size = new System.Drawing.Size(115, 40);
            this.btnVcancelar.TabIndex = 88;
            this.btnVcancelar.Text = "Cancelar";
            this.btnVcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVcancelar.UseVisualStyleBackColor = true;
            // 
            // cmbVestatus
            // 
            this.cmbVestatus.FormattingEnabled = true;
            this.cmbVestatus.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.cmbVestatus.Location = new System.Drawing.Point(426, 117);
            this.cmbVestatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVestatus.Name = "cmbVestatus";
            this.cmbVestatus.Size = new System.Drawing.Size(120, 23);
            this.cmbVestatus.TabIndex = 76;
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
            this.btnVguardar.Location = new System.Drawing.Point(670, 59);
            this.btnVguardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVguardar.Name = "btnVguardar";
            this.btnVguardar.Size = new System.Drawing.Size(115, 40);
            this.btnVguardar.TabIndex = 87;
            this.btnVguardar.Text = "Guardar";
            this.btnVguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVguardar.UseVisualStyleBackColor = true;
            // 
            // cmbVtipo
            // 
            this.cmbVtipo.FormattingEnabled = true;
            this.cmbVtipo.Items.AddRange(new object[] {
            "Taxi Ejecutivo",
            "Taxi Tradicional",
            "Taxi Radio"});
            this.cmbVtipo.Location = new System.Drawing.Point(155, 83);
            this.cmbVtipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVtipo.Name = "cmbVtipo";
            this.cmbVtipo.Size = new System.Drawing.Size(106, 23);
            this.cmbVtipo.TabIndex = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "mod";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbVehiculos);
            this.groupBox1.Controls.Add(this.btnVeditar);
            this.groupBox1.Controls.Add(this.btnVregresar);
            this.groupBox1.Controls.Add(this.btnVnuevo);
            this.groupBox1.Controls.Add(this.btnVFiltrar);
            this.groupBox1.Controls.Add(this.dtgVehiculos);
            this.groupBox1.Controls.Add(this.txtVfiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 300);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // chbVehiculos
            // 
            this.chbVehiculos.AutoSize = true;
            this.chbVehiculos.Checked = true;
            this.chbVehiculos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVehiculos.Location = new System.Drawing.Point(673, 275);
            this.chbVehiculos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chbVehiculos.Name = "chbVehiculos";
            this.chbVehiculos.Size = new System.Drawing.Size(176, 19);
            this.chbVehiculos.TabIndex = 94;
            this.chbVehiculos.Text = "Mostrar todos los Vehículos";
            this.chbVehiculos.UseVisualStyleBackColor = true;
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
            this.btnVeditar.Location = new System.Drawing.Point(585, 29);
            this.btnVeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVeditar.Name = "btnVeditar";
            this.btnVeditar.Size = new System.Drawing.Size(136, 40);
            this.btnVeditar.TabIndex = 92;
            this.btnVeditar.Text = "Editar Vehículo";
            this.btnVeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeditar.UseVisualStyleBackColor = true;
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
            this.btnVregresar.Location = new System.Drawing.Point(748, 29);
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
            this.btnVnuevo.Location = new System.Drawing.Point(412, 29);
            this.btnVnuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVnuevo.Name = "btnVnuevo";
            this.btnVnuevo.Size = new System.Drawing.Size(146, 40);
            this.btnVnuevo.TabIndex = 91;
            this.btnVnuevo.Text = "Nuevo Vehículo";
            this.btnVnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVnuevo.UseVisualStyleBackColor = true;
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
            // 
            // dtgVehiculos
            // 
            this.dtgVehiculos.AllowUserToAddRows = false;
            this.dtgVehiculos.AllowUserToDeleteRows = false;
            this.dtgVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculos.Location = new System.Drawing.Point(21, 76);
            this.dtgVehiculos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgVehiculos.Name = "dtgVehiculos";
            this.dtgVehiculos.ReadOnly = true;
            this.dtgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVehiculos.Size = new System.Drawing.Size(825, 195);
            this.dtgVehiculos.TabIndex = 89;
            // 
            // txtVfiltro
            // 
            this.txtVfiltro.Location = new System.Drawing.Point(68, 39);
            this.txtVfiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVfiltro.Name = "txtVfiltro";
            this.txtVfiltro.Size = new System.Drawing.Size(144, 23);
            this.txtVfiltro.TabIndex = 88;
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
            this.ClientSize = new System.Drawing.Size(911, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVehiculos);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTVNS - Gestion de Vehículos del Sistema";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.gbVehiculos.ResumeLayout(false);
            this.gbVehiculos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtVplaca;
        private System.Windows.Forms.TextBox txtVseriemotor;
        private System.Windows.Forms.TextBox txtVserie;
        private System.Windows.Forms.TextBox txtVcolor;
        private System.Windows.Forms.TextBox txtVaño;
        private System.Windows.Forms.TextBox txtVdescripcion;
        private System.Windows.Forms.DateTimePicker dtpVfactualizacion;
        private System.Windows.Forms.DateTimePicker dtpVfalta;
        private System.Windows.Forms.TextBox txtVmodelo;
        private System.Windows.Forms.TextBox txtVnumero;
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
        private System.Windows.Forms.GroupBox gbVehiculos;
        private System.Windows.Forms.ComboBox cmbVtipo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox cmbVestatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVcancelar;
        private System.Windows.Forms.Button btnVguardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVeditar;
        private System.Windows.Forms.Button btnVregresar;
        private System.Windows.Forms.Button btnVnuevo;
        private System.Windows.Forms.Button btnVFiltrar;
        private System.Windows.Forms.DataGridView dtgVehiculos;
        private System.Windows.Forms.TextBox txtVfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbVehiculos;
    }
}