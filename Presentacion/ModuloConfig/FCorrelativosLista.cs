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
    public partial class FCorrelativosLista : Form
    {
        public String TxtFlag;

        public FCorrelativosLista()
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
                DataListado.Columns["cod_correlativos"].Visible = true;
                DataListado.Columns["desc_correlativos"].Visible = true;
                DataListado.Columns["tabla"].Visible = true;
                DataListado.Columns["precadena"].Visible = true;
                DataListado.Columns["cadena"].Visible = false;
                DataListado.Columns["cod_num"].Visible = true;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;

                DataListado.Columns["cod_correlativos"].Width = 100;
                DataListado.Columns["desc_correlativos"].Width = 250;
                DataListado.Columns["tabla"].Width = 200;
                DataListado.Columns["cod_num"].Width = 120;

                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FCorrelativos mForm = FCorrelativos.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_correlativos"].HeaderText = "Codigo";
            DataListado.Columns["desc_correlativos"].HeaderText = "Descripcion";
            DataListado.Columns["tabla"].HeaderText = "Tabla";
            DataListado.Columns["precadena"].HeaderText = "Prefijo";
            DataListado.Columns["cod_num"].HeaderText = "Correlativo";
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion", "Tabla" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = ECorrelativos.Mostrar();
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
                DataListado.DataSource = ECorrelativos.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = ECorrelativos.Buscar(TxtBuscar.Text, "Desc");
            }
            else if (TxtBtipo.Text == "Tabla")
            {
                DataListado.DataSource = ECorrelativos.Buscar(TxtBuscar.Text, "Tab");
            }
        }

        private void FCorrelativosListar_Load(object sender, EventArgs e)
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
                FCorrelativos mForm = FCorrelativos.GetForm();
                string cod_correlativos, desc_correlativos, tabla, precadena, cod_num,campo1, campo2, campo3, campo4, campo5, campo6;
                cod_correlativos = Convert.ToString(DataListado.CurrentRow.Cells["cod_correlativos"].Value);
                desc_correlativos = Convert.ToString(DataListado.CurrentRow.Cells["desc_correlativos"].Value);
                tabla = Convert.ToString(DataListado.CurrentRow.Cells["tabla"].Value);
                precadena = Convert.ToString(DataListado.CurrentRow.Cells["precadena"].Value);
                cod_num = Convert.ToString(DataListado.CurrentRow.Cells["cod_num"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetCorrelativos(cod_correlativos, desc_correlativos, tabla, precadena, cod_num, campo1, campo2, campo3, campo4, campo5, campo6);
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
                            Rpta = ECorrelativos.Eliminar(Convert.ToString(row.Cells["cod_correlativos"].Value));
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
            //FRptCorrelativos Reporte = new FRptCorrelativos();
            //Reporte.ShowDialog();
        }

    }
}
