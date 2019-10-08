using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloConfig
{
    public partial class FIslrLista : Form
    {
        public String TxtFlag;
        public String Cod_islr;
        public String Desc_islr;
           

        public FIslrLista()
        {
            InitializeComponent();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OcultarColumnas()
        {
            if (DataListado.Rows.Count != 0)
            {
                DataListado.Columns["Eliminar"].Visible = false;
                DataListado.Columns["reng"].Visible = true;
                DataListado.Columns["cod_islr"].Visible = false;
                DataListado.Columns["concepto"].Visible = true;
                DataListado.Columns["desc_concepto"].Visible = true;
                DataListado.Columns["basep"].Visible = true;
                DataListado.Columns["retencion"].Visible = true;
                DataListado.Columns["sustraendo"].Visible = true;

                DataListado.Columns["reng"].Width = 50;
                DataListado.Columns["concepto"].Width = 80;
                DataListado.Columns["desc_concepto"].Width = 450;
                DataListado.Columns["basep"].Width = 100;
                DataListado.Columns["retencion"].Width = 100;
                DataListado.Columns["sustraendo"].Width = 100;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FIslr mForm = FIslr.GetForm();
                mForm.Listar();
                Close();
            }

            string Formato = "N2";

            DataListado.Columns["reng"].HeaderText = "Reng";
            DataListado.Columns["concepto"].HeaderText = "Concepto";
            DataListado.Columns["desc_concepto"].HeaderText = "Descripcion";
            DataListado.Columns["basep"].HeaderText = "Base Imp.";
            DataListado.Columns["retencion"].HeaderText = "% Ret.";
            DataListado.Columns["sustraendo"].HeaderText = "Sustraendo";

            DataListado.Columns["concepto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["basep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["retencion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["sustraendo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataListado.Columns["basep"].DefaultCellStyle.Format = String.Format(Formato);
            DataListado.Columns["retencion"].DefaultCellStyle.Format = String.Format(Formato);
            DataListado.Columns["sustraendo"].DefaultCellStyle.Format = String.Format(Formato);

            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Concepto", "Descripcion" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EIslrDetalle.Mostrar(Cod_islr);
                OcultarColumnas();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void Buscar()
        {
            if (TxtBtipo.Text == "Concepto")
            {
                DataListado.DataSource = EIslrDetalle.Buscar(TxtBuscar.Text, "con", Cod_islr);
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EIslrDetalle.Buscar(TxtBuscar.Text, "Desc", Cod_islr);
            }
        }

        private void FIslrListar_Load(object sender, EventArgs e)
        {
            Text = "...::: Listado :::...";
            Mostrar();
            CbBtipo();
            TxtBtipo.Text = "Concepto";
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
                BtnEliminar.Enabled = Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void DataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ChkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEliminar.Checked)
            {
                DataListado.Columns["Eliminar"].Visible = true;
                DataListado.Columns["Eliminar"].Width = 80;
            }
            else
            {
                DataListado.Columns["Eliminar"].Visible = false;
                DataListado.Columns["Eliminar"].Width = 80;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptIslr Reporte = new FRptIslr();
            //Reporte.ShowDialog();
        }

    }
}
