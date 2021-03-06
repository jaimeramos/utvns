﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Principal.Entidades;

namespace Principal
{
    public partial class Buscarservicios : Form
    {
        Workshopsvc workshopsvc = new Workshopsvc();
        private string _idworkshopsvc;
        private IFindWorkshopsvc _caller;

        public Buscarservicios(IFindWorkshopsvc caller)
        {
            InitializeComponent();
            fillGridView();
            _caller = caller;
        }

        public Buscarservicios(IFindWorkshopsvc caller, string idworkshopsvc) :this(caller)
        {
            InitializeComponent();
            _idworkshopsvc = idworkshopsvc;
        }

        private void btnPeregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscarpermisos_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        public void fillGridView()
        {
            string json = workshopsvc.read();
            
            if (!json.Equals("[]"))
            {
                DataTable data = Tools.Util.convertToDataTable(json);
                dataGrid.AutoGenerateColumns = true;
                dataGrid.DataSource = data;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGrid.Columns["active"].Visible = true;
                dataGrid.Columns["created_at"].Visible = false;
                dataGrid.Columns["updated_at"].Visible = false;
                dataGrid.Columns["__v"].Visible = false;
                dataGrid.Columns["_id"].Visible = false;

                dataGrid.Columns["number"].DisplayIndex = 0;
                dataGrid.Columns["number"].HeaderText = "Número";
                dataGrid.Columns["description"].DisplayIndex = 1;
                dataGrid.Columns["description"].HeaderText = "Descripción";
                dataGrid.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns["cost"].DisplayIndex = 2;
                dataGrid.Columns["cost"].HeaderText = "Costo";
                dataGrid.Columns["active"].DisplayIndex = 3;
                dataGrid.Columns["active"].HeaderText = "Status";

            }
        }

         private void dtgPermisos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int rowSelected = 0;
        private void btnVeditar_Click(object sender, EventArgs e)
        {
            seleccionar(rowSelected);
        }

        private void txtPefiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPefiltrar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seleccionar(e.RowIndex);
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }
        private void seleccionar(int i) {
            if (dataGrid.CurrentRow == null)
            {
                return;
            }
            int selectedrowindex = i;
            DataGridViewRow selectedRow = dataGrid.Rows[selectedrowindex];
            Workshopsvc workshopsvc = new Workshopsvc();
            workshopsvc.Id = Convert.ToString(selectedRow.Cells["_id"].Value); ;
            workshopsvc.Description = Convert.ToString(selectedRow.Cells["description"].Value);
            workshopsvc.Cost = Convert.ToString(selectedRow.Cells["cost"].Value);
            _caller.SelectedWorkshopsvc((Workshopsvc)workshopsvc);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
