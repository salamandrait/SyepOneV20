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
    public partial class FChequeraLista : Form
    {
        public String TxtFlag;

        public FChequeraLista()
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
                DataListado.Columns["cod_chequera"].Visible = true;
                DataListado.Columns["desc_chequera"].Visible = true;
                DataListado.Columns["cod_cuenta"].Visible = true;
                DataListado.Columns["desc_cuenta"].Visible = false;
                DataListado.Columns["cod_banco"].Visible = false;
                DataListado.Columns["desc_banco"].Visible = false;
                DataListado.Columns["numcuenta"].Visible = true;
                DataListado.Columns["responsable"].Visible = false;
                DataListado.Columns["cantidad"].Visible = false;
                DataListado.Columns["estatus"].Visible = true;
                DataListado.Columns["fecha_reg"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;

                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);

            }
            else
            {
                FChequera mForm = FChequera.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_chequera"].HeaderText = "Codigo";
            DataListado.Columns["desc_chequera"].HeaderText = "Descripcion";
            DataListado.Columns["cod_cuenta"].HeaderText = "Cuenta";
            DataListado.Columns["numcuenta"].HeaderText = "Nro de Cuenta";
            DataListado.Columns["estatus"].HeaderText = "Estatus";

            DataListado.Columns["cod_chequera"].Width = 120;
            DataListado.Columns["desc_chequera"].Width = 250;
            DataListado.Columns["cod_cuenta"].Width = 120;
            DataListado.Columns["numcuenta"].Width = 200;
            DataListado.Columns["estatus"].Width = 100;

            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["cod_cuenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["numcuenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion", "Cuenta", "Nro de Cuenta" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EChequera.Mostrar();
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
                DataListado.DataSource = EChequera.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EChequera.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FChequeraListar_Load(object sender, EventArgs e)
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
                FChequera mForm = FChequera.GetForm();
                string cod_chequera, desc_chequera, cod_cuenta, desc_cuenta, cod_banco, desc_banco, numcuenta, responsable, cantidad, estatus, fecha_reg, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_chequera = Convert.ToString(DataListado.CurrentRow.Cells["cod_chequera"].Value);
                desc_chequera = Convert.ToString(DataListado.CurrentRow.Cells["desc_chequera"].Value);
                cod_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuenta"].Value);
                desc_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuenta"].Value);
                cod_banco = Convert.ToString(DataListado.CurrentRow.Cells["cod_banco"].Value);
                desc_banco = Convert.ToString(DataListado.CurrentRow.Cells["desc_banco"].Value);
                numcuenta = Convert.ToString(DataListado.CurrentRow.Cells["numcuenta"].Value);
                responsable = Convert.ToString(DataListado.CurrentRow.Cells["responsable"].Value);
                cantidad = Convert.ToString(DataListado.CurrentRow.Cells["cantidad"].Value);
                estatus = Convert.ToString(DataListado.CurrentRow.Cells["estatus"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetChequera(cod_chequera, desc_chequera, cod_cuenta, desc_cuenta, cod_banco, desc_banco, numcuenta, responsable, cantidad, estatus, fecha_reg, campo1, campo2, campo3, campo4, campo5, campo6);
                Close();
                mForm.TxtEditar.Text = "Listar";
            }

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
                            Rpta = EChequera.Eliminar(Convert.ToString(row.Cells["cod_chequera"].Value));
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
            //FRptChequera Reporte = new FRptChequera();
            //Reporte.ShowDialog();
        }

    }
}
