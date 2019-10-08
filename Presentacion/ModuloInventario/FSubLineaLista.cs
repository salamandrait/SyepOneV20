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
    public partial class FSubLineaLista : Form
    {
        public String TxtFlag;
        public String TxtCod_linea1;

        public FSubLineaLista()
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
                DataListado.Columns["cod_sublinea"].Visible = true;
                DataListado.Columns["desc_sublinea"].Visible = true;
                DataListado.Columns["cod_linea"].Visible = true;
                DataListado.Columns["desc_linea"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_sublinea"].Width = 100;
                DataListado.Columns["desc_sublinea"].Width = 350;
                DataListado.Columns["cod_linea"].Width = 100;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FSubLinea mForm = FSubLinea.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_sublinea"].HeaderText = "Codigo";
            DataListado.Columns["desc_sublinea"].HeaderText = "Descripcion";
            DataListado.Columns["cod_linea"].HeaderText = "Linea";
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
                DataListado.DataSource = ESubLinea.Mostrar();
                OcultarColumnas();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        public void MostrarOpc()
        {
            try
            {
                DataListado.DataSource = ESubLinea.MostrarOpc(TxtCod_linea.Text);
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
                DataListado.DataSource = ESubLinea.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = ESubLinea.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FSubLineaListar_Load(object sender, EventArgs e)
        {
            Text = "...::: Listado :::...";
            CbBtipo();
            TxtBtipo.Text = "Codigo";
            if (!String.IsNullOrWhiteSpace(TxtCod_linea.Text) || !String.IsNullOrEmpty(TxtCod_linea.Text))
            {
                MostrarOpc();
            }
            else
            {
                Mostrar();
            }
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
                FSubLinea mForm = FSubLinea.GetForm();
                string cod_sublinea, cod_linea, desc_linea, desc_sublinea, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_sublinea = Convert.ToString(DataListado.CurrentRow.Cells["cod_sublinea"].Value);
                cod_linea = Convert.ToString(DataListado.CurrentRow.Cells["cod_linea"].Value);
                desc_linea = Convert.ToString(DataListado.CurrentRow.Cells["desc_linea"].Value);
                desc_sublinea = Convert.ToString(DataListado.CurrentRow.Cells["desc_sublinea"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetSubLinea(cod_sublinea, cod_linea, desc_linea, desc_sublinea, campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
            }
            else if (TxtFlag == "Articulo")
            {
                FArticulo mForm = FArticulo.GetForm();
                string cod_sublinea, desc_sublinea;
                cod_sublinea = Convert.ToString(DataListado.CurrentRow.Cells["cod_sublinea"].Value);
                desc_sublinea = Convert.ToString(DataListado.CurrentRow.Cells["desc_sublinea"].Value);
                mForm.SetSubLinea(cod_sublinea, desc_sublinea);
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
                            Rpta = ESubLinea.Eliminar(Convert.ToString(row.Cells["cod_sublinea"].Value));
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
            //FRptSubLinea Reporte = new FRptSubLinea();
            //Reporte.ShowDialog();
        }

    }
}
