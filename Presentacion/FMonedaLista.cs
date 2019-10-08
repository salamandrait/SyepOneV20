using Entidades;
using Presentacion.ModuloBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FMonedaLista : Form
    {
        public String TxtFlag;

        public FMonedaLista()
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
                DataListado.Columns["cod_moneda"].Visible = true;
                DataListado.Columns["desc_moneda"].Visible = true;
                DataListado.Columns["monebase"].Visible = true;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_moneda"].Width = 100;
                DataListado.Columns["monebase"].Width = 100;
                DataListado.Columns["desc_moneda"].Width = 300;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FMoneda mForm = FMoneda.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_moneda"].HeaderText = "Codigo";
            DataListado.Columns["desc_moneda"].HeaderText = "Descripcion";
            DataListado.Columns["monebase"].HeaderText = "M.Base";
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EMoneda.Mostrar();
                OcultarColumnas();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void Buscar()
        {
            if (TxtBtipo.Text == "Codigo")
            {
                DataListado.DataSource = EMoneda.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EMoneda.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FMonedaListar_Load(object sender, EventArgs e)
        {
            Text = "...::: Listado :::...";
            Mostrar();
            CbBtipo();
            TxtBtipo.Text = "Codigo";
        }

        private void DataListado_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();

            SizeF size = e.Graphics.MeasureString(strRowNumber, Font);

            if (DataListado.RowHeadersWidth < Convert.ToInt32((size.Width + 10)))
            {
                DataListado.RowHeadersWidth = Convert.ToInt32((size.Width + 10));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString
                (strRowNumber, Font, b, e.RowBounds.Location.X
                + 10, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 5));
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
            if (TxtFlag == 0.ToString())
            {
                FMoneda mForm = FMoneda.GetForm();
                string cod_moneda, desc_moneda, monebase,campo1, campo2, campo3, campo4, campo5, campo6;
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                monebase = Convert.ToString(DataListado.CurrentRow.Cells["monebase"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetMoneda(cod_moneda, desc_moneda, monebase,campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
            }
            else if (TxtFlag == "Banco")
            {
                FBanco mForm = FBanco.GetForm();
                string cod_moneda, desc_moneda;
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                mForm.SetMoneda(cod_moneda, desc_moneda);
            }
            else if (TxtFlag == "Cuenta")
            {
                FCuenta mForm = FCuenta.GetForm();
                string cod_moneda, desc_moneda;
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                mForm.SetMoneda(cod_moneda, desc_moneda);
            }
            else if (TxtFlag == "Caja")
            {
                FCaja mForm = FCaja.GetForm();
                string cod_moneda, desc_moneda;
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                mForm.SetMoneda(cod_moneda, desc_moneda);
            }
            else if (TxtFlag == "Pais")
            {
                FPais mForm = FPais.GetForm();
                string cod_moneda, desc_moneda;
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                mForm.SetMoneda(cod_moneda, desc_moneda);
            }
            Close();
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
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros Seleccionados ?", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Rpta = EMoneda.Eliminar(Convert.ToString(row.Cells["cod_moneda"].Value));
                        }
                    }

                    if (Rpta.Equals("Y"))
                    {
                        ChkEliminar.CheckState = CheckState.Unchecked;
                        MensajeOk("Se Eliminó Correctamente el registro");
                        Mostrar();
                    }
                    else
                    {
                        MensajeError(Rpta);
                        ChkEliminar.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    MensajeError("Cancelando la Eliminacon de Registros!");
                    ChkEliminar.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptMoneda Reporte = new FRptMoneda();
            //Reporte.ShowDialog();
        }

    }
}
