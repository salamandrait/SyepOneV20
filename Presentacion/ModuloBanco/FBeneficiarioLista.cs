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
    public partial class FBeneficiarioLista : Form
    {
        public String TxtFlag;

        public FBeneficiarioLista()
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
                DataListado.Columns["cod_beneficiario"].Visible = true;
                DataListado.Columns["desc_beneficiario"].Visible = true;
                DataListado.Columns["cod_islr"].Visible = true;
                DataListado.Columns["desc_islr"].Visible = false;
                DataListado.Columns["rif"].Visible = true;
                DataListado.Columns["direccion"].Visible = false;
                DataListado.Columns["telefono"].Visible = true;
                DataListado.Columns["activo"].Visible = false;
                DataListado.Columns["fecha_reg"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_beneficiario"].Width = 80;
                DataListado.Columns["desc_beneficiario"].Width = 250;
                DataListado.Columns["cod_islr"].Width = 100;
                DataListado.Columns["rif"].Width = 100;
                DataListado.Columns["telefono"].Width = 150;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FBeneficiario mForm = FBeneficiario.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_beneficiario"].HeaderText = "Codigo";
            DataListado.Columns["desc_beneficiario"].HeaderText = "Descripcion";
            DataListado.Columns["cod_islr"].HeaderText = "Tipo Fiscal";
            DataListado.Columns["rif"].HeaderText = "Rif";
            DataListado.Columns["telefono"].HeaderText = "Telefono";
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["cod_islr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion", "Rif" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EBeneficiario.Mostrar();
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
                DataListado.DataSource = EBeneficiario.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EBeneficiario.Buscar(TxtBuscar.Text, "Desc");
            }
            else if (TxtBtipo.Text == "Rif")
            {
                DataListado.DataSource = EBeneficiario.Buscar(TxtBuscar.Text, "rif");
            }
        }

        private void FBeneficiarioListar_Load(object sender, EventArgs e)
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
                FBeneficiario mForm = FBeneficiario.GetForm();
                String cod_beneficiario, desc_beneficiario, cod_islr, desc_islr, rif, direccion, telefono, activo, fecha_reg, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_beneficiario = Convert.ToString(DataListado.CurrentRow.Cells["cod_beneficiario"].Value);
                desc_beneficiario = Convert.ToString(DataListado.CurrentRow.Cells["desc_beneficiario"].Value);
                cod_islr = Convert.ToString(DataListado.CurrentRow.Cells["cod_islr"].Value);
                desc_islr = Convert.ToString(DataListado.CurrentRow.Cells["desc_islr"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                direccion = Convert.ToString(DataListado.CurrentRow.Cells["direccion"].Value);
                telefono = Convert.ToString(DataListado.CurrentRow.Cells["telefono"].Value);
                activo = Convert.ToString(DataListado.CurrentRow.Cells["activo"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetBeneficiario(cod_beneficiario, desc_beneficiario, cod_islr, desc_islr, rif, direccion, telefono, activo, fecha_reg, campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
                Close();
            }
            else if (TxtFlag == "OPago")
            {
                FOPago mForm = FOPago.GetForm();
                string cod_beneficiario, desc_beneficiario, rif;
                cod_beneficiario = Convert.ToString(DataListado.CurrentRow.Cells["cod_beneficiario"].Value);
                desc_beneficiario = Convert.ToString(DataListado.CurrentRow.Cells["desc_beneficiario"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                mForm.SetBeneficiario(cod_beneficiario, desc_beneficiario, rif);
                Close();
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
                            Rpta = EBeneficiario.Eliminar(Convert.ToString(row.Cells["cod_beneficiario"].Value));
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
            //FRptBeneficiario Reporte = new FRptBeneficiario();
            //Reporte.ShowDialog();
        }

    }
}
