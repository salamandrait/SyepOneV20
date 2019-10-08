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

namespace Presentacion.ModuloInventario
{
    public partial class FDepositoLista : Form
    {
        public String TxtFlag;

        public FDepositoLista()
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
                DataListado.Columns["cod_deposito"].Visible = true;
                DataListado.Columns["desc_deposito"].Visible = true;
                DataListado.Columns["resp_deposito"].Visible = true;
                DataListado.Columns["ubicacion_deposito"].Visible = false;
                DataListado.Columns["fecha_reg"].Visible = false;
                DataListado.Columns["direccion_adm"].Visible = false;
                DataListado.Columns["scompras"].Visible = false;
                DataListado.Columns["sventas"].Visible = false;
                DataListado.Columns["activo"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_deposito"].Width = 100;
                DataListado.Columns["desc_deposito"].Width = 350;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FDeposito mForm = FDeposito.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_deposito"].HeaderText = "Codigo";
            DataListado.Columns["desc_deposito"].HeaderText = "Descripcion";
            DataListado.Columns["resp_deposito"].HeaderText = "Responsable";
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
                DataListado.DataSource = EDeposito.Mostrar();
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
                DataListado.DataSource = EDeposito.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EDeposito.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FDepositoListar_Load(object sender, EventArgs e)
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
                FDeposito mForm = FDeposito.GetForm();
                string cod_deposito, desc_deposito, resp_deposito, ubicacion_deposito, fecha_reg, direccion_adm, scompras, sventas, activo, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_deposito = Convert.ToString(DataListado.CurrentRow.Cells["cod_deposito"].Value);
                desc_deposito = Convert.ToString(DataListado.CurrentRow.Cells["desc_deposito"].Value);
                resp_deposito = Convert.ToString(DataListado.CurrentRow.Cells["resp_deposito"].Value);
                ubicacion_deposito = Convert.ToString(DataListado.CurrentRow.Cells["ubicacion_deposito"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                direccion_adm = Convert.ToString(DataListado.CurrentRow.Cells["direccion_adm"].Value);
                scompras = Convert.ToString(DataListado.CurrentRow.Cells["scompras"].Value);
                sventas = Convert.ToString(DataListado.CurrentRow.Cells["sventas"].Value);
                activo = Convert.ToString(DataListado.CurrentRow.Cells["activo"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetDeposito(cod_deposito, desc_deposito, resp_deposito, ubicacion_deposito, fecha_reg, direccion_adm, scompras, sventas, activo, campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
            }
            if (TxtFlag == "ArtPrecio")
            {
                FArtPrecio mForm = FArtPrecio.GetForm();
                string cod_deposito, desc_deposito;
                cod_deposito = Convert.ToString(DataListado.CurrentRow.Cells["cod_deposito"].Value);
                desc_deposito = Convert.ToString(DataListado.CurrentRow.Cells["desc_deposito"].Value);
                mForm.SetDeposito(cod_deposito, desc_deposito);
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
                            Rpta = EDeposito.Eliminar(Convert.ToString(row.Cells["cod_deposito"].Value));
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
            //FRptDeposito Reporte = new FRptDeposito();
            //Reporte.ShowDialog();
        }

    }
}
