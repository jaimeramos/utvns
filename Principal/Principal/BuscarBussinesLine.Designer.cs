namespace Principal
{
    partial class BuscarBussinesLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarBussinesLine));
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnVeditar = new System.Windows.Forms.Button();
            this.txtPefiltro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnPefiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeregresar = new System.Windows.Forms.Button();
            this.gbPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.dataGrid);
            this.gbPermisos.Controls.Add(this.btnVeditar);
            this.gbPermisos.Controls.Add(this.txtPefiltro);
            this.gbPermisos.Controls.Add(this.checkBox1);
            this.gbPermisos.Controls.Add(this.btnPefiltrar);
            this.gbPermisos.Controls.Add(this.label1);
            this.gbPermisos.Controls.Add(this.btnPeregresar);
            this.gbPermisos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermisos.Location = new System.Drawing.Point(10, 40);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(781, 370);
            this.gbPermisos.TabIndex = 28;
            this.gbPermisos.TabStop = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 69);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(759, 270);
            this.dataGrid.TabIndex = 94;
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisos_CellContentDoubleClick_1);
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
            this.btnVeditar.Location = new System.Drawing.Point(500, 17);
            this.btnVeditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVeditar.Name = "btnVeditar";
            this.btnVeditar.Size = new System.Drawing.Size(136, 40);
            this.btnVeditar.TabIndex = 93;
            this.btnVeditar.Text = "Seleccionar";
            this.btnVeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeditar.UseVisualStyleBackColor = true;
            this.btnVeditar.Click += new System.EventHandler(this.btnVeditar_Click);
            // 
            // txtPefiltro
            // 
            this.txtPefiltro.Location = new System.Drawing.Point(72, 22);
            this.txtPefiltro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPefiltro.Name = "txtPefiltro";
            this.txtPefiltro.Size = new System.Drawing.Size(303, 23);
            this.txtPefiltro.TabIndex = 20;
            this.txtPefiltro.TextChanged += new System.EventHandler(this.txtPefiltro_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(507, 345);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Mostrar todos los Permisos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnPefiltrar
            // 
            this.btnPefiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPefiltrar.FlatAppearance.BorderSize = 0;
            this.btnPefiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPefiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPefiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPefiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnPefiltrar.Image")));
            this.btnPefiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPefiltrar.Location = new System.Drawing.Point(379, 14);
            this.btnPefiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPefiltrar.Name = "btnPefiltrar";
            this.btnPefiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnPefiltrar.TabIndex = 21;
            this.btnPefiltrar.Text = "Limpiar filtro";
            this.btnPefiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPefiltrar.UseVisualStyleBackColor = true;
            this.btnPefiltrar.Click += new System.EventHandler(this.btnPefiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtro:";
            // 
            // btnPeregresar
            // 
            this.btnPeregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeregresar.FlatAppearance.BorderSize = 0;
            this.btnPeregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPeregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPeregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnPeregresar.Image")));
            this.btnPeregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeregresar.Location = new System.Drawing.Point(655, 14);
            this.btnPeregresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPeregresar.Name = "btnPeregresar";
            this.btnPeregresar.Size = new System.Drawing.Size(98, 43);
            this.btnPeregresar.TabIndex = 24;
            this.btnPeregresar.Text = "Regresar";
            this.btnPeregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeregresar.UseVisualStyleBackColor = true;
            this.btnPeregresar.Click += new System.EventHandler(this.btnPeregresar_Click);
            // 
            // BuscarBussinesLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPermisos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarBussinesLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscarpermisos";
            this.Load += new System.EventHandler(this.Buscarpermisos_Load);
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.TextBox txtPefiltro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnPefiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeregresar;
        private System.Windows.Forms.Button btnVeditar;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}