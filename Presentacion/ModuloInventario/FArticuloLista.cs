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
    public partial class FArticuloLista : Form
    {
        public String TxtFlag;

        public FArticuloLista()
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
                DataListado.Columns["cod_articulo"].Visible = true;
                DataListado.Columns["desc_articulo"].Visible = true;
                DataListado.Columns["tipo"].Visible = true;
                DataListado.Columns["origen"].Visible = false;
                DataListado.Columns["item"].Visible = false;
                DataListado.Columns["referencia"].Visible = false;
                DataListado.Columns["modelo"].Visible = false;
                DataListado.Columns["garantia"].Visible = false;
                DataListado.Columns["punto_min"].Visible = false;
                DataListado.Columns["punto_max"].Visible = false;
                DataListado.Columns["punto_ped"].Visible = false;
                DataListado.Columns["peso"].Visible = false;
                DataListado.Columns["volumen"].Visible = false;
                DataListado.Columns["alto"].Visible = false;
                DataListado.Columns["ancho"].Visible = false;
                DataListado.Columns["porcentaje"].Visible = false;
                DataListado.Columns["puntos"].Visible = false;
                DataListado.Columns["fecha_reg"].Visible = false;
                DataListado.Columns["activo"].Visible = false;
                DataListado.Columns["esserial"].Visible = false;
                DataListado.Columns["eslote"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_categoria"].Visible = false;
                DataListado.Columns["desc_categoria"].Visible = true;
                DataListado.Columns["cod_linea"].Visible = false;
                DataListado.Columns["desc_linea"].Visible = false;
                DataListado.Columns["cod_sublinea"].Visible = false;
                DataListado.Columns["desc_sublinea"].Visible = false;
                DataListado.Columns["cod_color"].Visible = false;
                DataListado.Columns["desc_color"].Visible = false;
                DataListado.Columns["cod_ubicacion"].Visible = false;
                DataListado.Columns["desc_ubicacion"].Visible = false;
                DataListado.Columns["cod_impuesto"].Visible = false;
                DataListado.Columns["desc_impuesto"].Visible = false;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);

                DataListado.Columns["cod_articulo"].Width = 150;
                DataListado.Columns["desc_articulo"].Width = 350;
                DataListado.Columns["tipo"].Width = 120;
                DataListado.Columns["desc_categoria"].Width = 200;

                DataListado.Columns["cod_articulo"].HeaderText = "Codigo";
                DataListado.Columns["desc_articulo"].HeaderText = "Descripcion";
                DataListado.Columns["tipo"].HeaderText = "Tipo";
                DataListado.Columns["desc_categoria"].HeaderText = "Categoria";

                DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["cod_articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataListado.Columns["desc_categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                FArticulo mForm = FArticulo.GetForm();
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
                DataListado.DataSource = EArticulo.Mostrar();
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
                DataListado.DataSource = EArticulo.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EArticulo.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FArticuloListar_Load(object sender, EventArgs e)
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
                FArticulo mForm = FArticulo.GetForm();
                string cod_articulo, desc_articulo, tipo, origen, item, referencia, modelo, garantia, punto_min, punto_max, punto_ped, peso, volumen, alto, ancho, porcentaje, puntos, fecha_reg, activo, esserial, eslote, campo1, campo2, campo3, campo4, campo5, campo6, cod_categoria, desc_categoria, cod_linea, desc_linea, cod_sublinea, desc_sublinea, cod_color, desc_color, cod_ubicacion, desc_ubicacion, cod_impuesto, desc_impuesto;

                cod_articulo = Convert.ToString(DataListado.CurrentRow.Cells["cod_articulo"].Value);
                desc_articulo = Convert.ToString(DataListado.CurrentRow.Cells["desc_articulo"].Value);
                tipo = Convert.ToString(DataListado.CurrentRow.Cells["tipo"].Value);
                origen = Convert.ToString(DataListado.CurrentRow.Cells["origen"].Value);
                item = Convert.ToString(DataListado.CurrentRow.Cells["item"].Value);
                referencia = Convert.ToString(DataListado.CurrentRow.Cells["referencia"].Value);
                modelo = Convert.ToString(DataListado.CurrentRow.Cells["modelo"].Value);
                garantia = Convert.ToString(DataListado.CurrentRow.Cells["garantia"].Value);
                punto_min = Convert.ToString(DataListado.CurrentRow.Cells["punto_min"].Value);
                punto_max = Convert.ToString(DataListado.CurrentRow.Cells["punto_max"].Value);
                punto_ped = Convert.ToString(DataListado.CurrentRow.Cells["punto_ped"].Value);
                peso = Convert.ToString(DataListado.CurrentRow.Cells["peso"].Value);
                volumen = Convert.ToString(DataListado.CurrentRow.Cells["volumen"].Value);
                alto = Convert.ToString(DataListado.CurrentRow.Cells["alto"].Value);
                ancho = Convert.ToString(DataListado.CurrentRow.Cells["ancho"].Value);
                porcentaje = Convert.ToString(DataListado.CurrentRow.Cells["porcentaje"].Value);
                puntos = Convert.ToString(DataListado.CurrentRow.Cells["puntos"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                activo = Convert.ToString(DataListado.CurrentRow.Cells["activo"].Value);
                esserial = Convert.ToString(DataListado.CurrentRow.Cells["esserial"].Value);
                eslote = Convert.ToString(DataListado.CurrentRow.Cells["eslote"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);

                cod_categoria = Convert.ToString(DataListado.CurrentRow.Cells["cod_categoria"].Value);
                desc_categoria = Convert.ToString(DataListado.CurrentRow.Cells["desc_categoria"].Value);

                cod_linea = Convert.ToString(DataListado.CurrentRow.Cells["cod_linea"].Value);
                desc_linea = Convert.ToString(DataListado.CurrentRow.Cells["desc_linea"].Value);

                cod_sublinea = Convert.ToString(DataListado.CurrentRow.Cells["cod_sublinea"].Value);
                desc_sublinea = Convert.ToString(DataListado.CurrentRow.Cells["desc_sublinea"].Value);

                cod_color = Convert.ToString(DataListado.CurrentRow.Cells["cod_color"].Value);
                desc_color = Convert.ToString(DataListado.CurrentRow.Cells["desc_color"].Value);

                cod_ubicacion = Convert.ToString(DataListado.CurrentRow.Cells["cod_ubicacion"].Value);
                desc_ubicacion = Convert.ToString(DataListado.CurrentRow.Cells["desc_ubicacion"].Value);

                cod_impuesto = Convert.ToString(DataListado.CurrentRow.Cells["cod_impuesto"].Value);
                desc_impuesto = Convert.ToString(DataListado.CurrentRow.Cells["desc_impuesto"].Value);

                mForm.SetArticulo(cod_articulo, desc_articulo, tipo, origen, item, referencia, modelo, garantia, punto_min, punto_max, punto_ped, peso, volumen, alto, ancho, porcentaje, puntos, fecha_reg, activo, esserial, eslote, campo1, campo2, campo3, campo4, campo5, campo6, cod_categoria, desc_categoria, cod_linea, desc_linea, cod_sublinea, desc_sublinea, cod_color, desc_color, cod_ubicacion, desc_ubicacion, cod_impuesto, desc_impuesto);
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
                            Rpta = EArticulo.Eliminar(Convert.ToString(row.Cells["cod_articulo"].Value));
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
            //FRptArticulo Reporte = new FRptArticulo();
            //Reporte.ShowDialog();
        }

    }
}
