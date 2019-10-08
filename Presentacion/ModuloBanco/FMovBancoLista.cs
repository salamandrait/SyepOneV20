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

namespace Presentacion.ModuloBanco
{
    public partial class FMovBancoLista : Form
    {
        public String TxtFlag;

        public FMovBancoLista()
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
                DataListado.Columns["cod_movbanco"].Visible = true;
                DataListado.Columns["desc_movbanco"].Visible = false;
                DataListado.Columns["cod_cuenta"].Visible = false;
                DataListado.Columns["desc_cuenta"].Visible = true;
                DataListado.Columns["numcuenta"].Visible = true;
                DataListado.Columns["cod_banco"].Visible = false;
                DataListado.Columns["desc_banco"].Visible = false;
                DataListado.Columns["cod_moneda"].Visible = true;
                DataListado.Columns["desc_moneda"].Visible = false;
                DataListado.Columns["cod_cuentasie"].Visible = false;
                DataListado.Columns["desc_cuentasie"].Visible = false;
                DataListado.Columns["tipomov"].Visible = true;
                DataListado.Columns["optipo"].Visible = false;
                DataListado.Columns["numdoc"].Visible = true;
                DataListado.Columns["numop"].Visible = true;
                DataListado.Columns["origen"].Visible = false;
                DataListado.Columns["estatus"].Visible = true;
                DataListado.Columns["montod"].Visible = true;
                DataListado.Columns["montoh"].Visible = true;
                DataListado.Columns["fecha_reg"].Visible = true;
                DataListado.Columns["saldoinicial"].Visible = false;
                DataListado.Columns["anulado"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_usuario"].Visible = false;

                LbInexistente.Visible = false;
                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);

                DataListado.Columns["cod_movbanco"].HeaderText = "Codigo";
                DataListado.Columns["desc_cuenta"].HeaderText = "Cuenta";
                DataListado.Columns["numcuenta"].HeaderText = "Numero";
                DataListado.Columns["cod_moneda"].HeaderText = "Moneda";
                DataListado.Columns["tipomov"].HeaderText = "Tipo";
                DataListado.Columns["numdoc"].HeaderText = "Documento";
                DataListado.Columns["numop"].HeaderText = "N° de Op.";
                DataListado.Columns["estatus"].HeaderText = "Estatus";
                DataListado.Columns["montod"].HeaderText = "Ingreso";
                DataListado.Columns["montoh"].HeaderText = "Egreso";
                DataListado.Columns["fecha_reg"].HeaderText = "Fecha";

                DataListado.Columns["cod_movbanco"].Width = 100;
                DataListado.Columns["desc_cuenta"].Width = 200;
                DataListado.Columns["numcuenta"].Width = 150;
                DataListado.Columns["cod_moneda"].Width = 80;
                DataListado.Columns["tipomov"].Width = 120;
                DataListado.Columns["numdoc"].Width = 120;
                DataListado.Columns["numop"].Width = 120;
                DataListado.Columns["estatus"].Width = 100;
                DataListado.Columns["montod"].Width = 150;
                DataListado.Columns["montoh"].Width = 150;
                DataListado.Columns["fecha_reg"].Width = 100;

                DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["montod"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DataListado.Columns["montoh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DataListado.Columns["cod_movbanco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["numcuenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["cod_moneda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["tipomov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["numdoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["numop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["fecha_reg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataListado.Columns["montod"].DefaultCellStyle.Format = Convert.ToString("N2");
                DataListado.Columns["montoh"].DefaultCellStyle.Format = Convert.ToString("N2");
                DataListado.Columns["fecha_reg"].DefaultCellStyle.Format = Convert.ToString("dd/MM/yyyy");
            }
            else
            {
                FMovBanco mForm = FMovBanco.GetForm();
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
                DataListado.DataSource = EMovBanco.Mostrar();
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
                DataListado.DataSource = EMovBanco.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EMovBanco.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FMovBancoListar_Load(object sender, EventArgs e)
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
                FMovBanco mForm = FMovBanco.GetForm();
                string cod_movbanco, desc_movbanco, cod_cuenta, desc_cuenta, numcuenta, cod_banco, desc_banco, cod_moneda, desc_moneda, cod_cuentasie, desc_cuentasie, tipomov, optipo, numdoc, numop, origen, estatus, montod, montoh, fecha_reg, saldoinicial, anulado, campo1, campo2, campo3, campo4, campo5, campo6, cod_usuario;
                cod_movbanco = Convert.ToString(DataListado.CurrentRow.Cells["cod_movbanco"].Value);
                desc_movbanco = Convert.ToString(DataListado.CurrentRow.Cells["desc_movbanco"].Value);
                cod_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuenta"].Value);
                desc_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuenta"].Value);
                numcuenta = Convert.ToString(DataListado.CurrentRow.Cells["numcuenta"].Value);
                cod_banco = Convert.ToString(DataListado.CurrentRow.Cells["cod_banco"].Value);
                desc_banco = Convert.ToString(DataListado.CurrentRow.Cells["desc_banco"].Value);
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                cod_cuentasie = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuentasie"].Value);
                desc_cuentasie = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuentasie"].Value);
                tipomov = Convert.ToString(DataListado.CurrentRow.Cells["tipomov"].Value);
                optipo = Convert.ToString(DataListado.CurrentRow.Cells["optipo"].Value);
                numdoc = Convert.ToString(DataListado.CurrentRow.Cells["numdoc"].Value);
                numop = Convert.ToString(DataListado.CurrentRow.Cells["numop"].Value);
                origen = Convert.ToString(DataListado.CurrentRow.Cells["origen"].Value);
                estatus = Convert.ToString(DataListado.CurrentRow.Cells["estatus"].Value);
                montod = Convert.ToString(DataListado.CurrentRow.Cells["montod"].Value);
                montoh = Convert.ToString(DataListado.CurrentRow.Cells["montoh"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                saldoinicial = Convert.ToString(DataListado.CurrentRow.Cells["saldoinicial"].Value);
                anulado = Convert.ToString(DataListado.CurrentRow.Cells["anulado"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                cod_usuario = Convert.ToString(DataListado.CurrentRow.Cells["cod_usuario"].Value);
                mForm.SetMovBanco(cod_movbanco, desc_movbanco, cod_cuenta, desc_cuenta, numcuenta, cod_banco, desc_banco, cod_moneda, desc_moneda, cod_cuentasie, desc_cuentasie, tipomov, optipo, numdoc, numop, origen, estatus, montod, montoh, fecha_reg, saldoinicial, anulado, campo1, campo2, campo3, campo4, campo5, campo6, cod_usuario);
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
                            Rpta = EMovBanco.Eliminar(Convert.ToString(row.Cells["cod_movbanco"].Value), Convert.ToString(row.Cells["cod_cuenta"].Value), Convert.ToString(row.Cells["optipo"].Value), Convert.ToDecimal(row.Cells["montod"].Value), Convert.ToDecimal(row.Cells["montoh"].Value));
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
            //FRptMovBanco Reporte = new FRptMovBanco();
            //Reporte.ShowDialog();
        }

    }
}
