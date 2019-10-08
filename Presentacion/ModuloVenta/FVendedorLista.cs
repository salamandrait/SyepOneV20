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

namespace Presentacion.ModuloVenta
{
    public partial class FVendedorLista : Form
    {
        public String TxtFlag;

        public FVendedorLista()
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
                DataListado.Columns["cod_vendedor"].Visible = true;
                DataListado.Columns["desc_vendedor"].Visible = true;
                DataListado.Columns["Rif"].Visible = true;
                DataListado.Columns["Telefono"].Visible = false;
                DataListado.Columns["Direccion"].Visible = false;
                DataListado.Columns["Nivel"].Visible = true;
                DataListado.Columns["Comisionventa"].Visible = false;
                DataListado.Columns["Comisioncobro"].Visible = false;
                DataListado.Columns["Tventas_item"].Visible = false;
                DataListado.Columns["Tventas_monto"].Visible = false;
                DataListado.Columns["Fecha_reg"].Visible = false;
                DataListado.Columns["Cobra"].Visible = true;
                DataListado.Columns["Venta"].Visible = true;
                DataListado.Columns["Activo"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_vendedor"].HeaderText = "Codigo";
                DataListado.Columns["desc_vendedor"].HeaderText = "Descripcion";
                DataListado.Columns["rif"].HeaderText = "Rif";
                DataListado.Columns["Nivel"].HeaderText = "Nivel";
                DataListado.Columns["Cobra"].HeaderText = "Cobrador";
                DataListado.Columns["Venta"].HeaderText = "Vendedor";
                           
                DataListado.Columns["cod_vendedor"].Width = 100;
                DataListado.Columns["desc_vendedor"].Width = 150;
                DataListado.Columns["Nivel"].Width = 80;
                DataListado.Columns["Cobra"].Width = 100;
                DataListado.Columns["Venta"].Width = 100;
                DataListado.Columns["rif"].Width = 120;

                DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["Nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["Cobra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["rif"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FVendedor mForm = FVendedor.GetForm();
                mForm.Listar();
                Close();
            }
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EVendedor.Mostrar();
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
                DataListado.DataSource = EVendedor.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EVendedor.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FVendedorListar_Load(object sender, EventArgs e)
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
                FVendedor mForm = FVendedor.GetForm();
                string cod_vendedor, desc_vendedor, rif, telefono, direccion, nivel, comisionventa, comisioncobro, tventas_item, tventas_monto, fecha_reg, cobra, venta, activo, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_vendedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_vendedor"].Value);
                desc_vendedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_vendedor"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                telefono = Convert.ToString(DataListado.CurrentRow.Cells["telefono"].Value);
                direccion = Convert.ToString(DataListado.CurrentRow.Cells["direccion"].Value);
                nivel = Convert.ToString(DataListado.CurrentRow.Cells["nivel"].Value);
                comisionventa = Convert.ToString(DataListado.CurrentRow.Cells["comisionventa"].Value);
                comisioncobro = Convert.ToString(DataListado.CurrentRow.Cells["comisioncobro"].Value);
                tventas_item = Convert.ToString(DataListado.CurrentRow.Cells["tventas_item"].Value);
                tventas_monto = Convert.ToString(DataListado.CurrentRow.Cells["tventas_monto"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                cobra = Convert.ToString(DataListado.CurrentRow.Cells["cobra"].Value);
                venta = Convert.ToString(DataListado.CurrentRow.Cells["venta"].Value);
                activo = Convert.ToString(DataListado.CurrentRow.Cells["activo"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetVendedor(cod_vendedor, desc_vendedor, rif, telefono, direccion, nivel, comisionventa, comisioncobro, tventas_item, tventas_monto, fecha_reg, cobra, venta, activo, campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
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
                            Rpta = EVendedor.Eliminar(Convert.ToString(row.Cells["cod_vendedor"].Value));
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
            //FRptVendedor Reporte = new FRptVendedor();
            //Reporte.ShowDialog();
        }

    }
}
