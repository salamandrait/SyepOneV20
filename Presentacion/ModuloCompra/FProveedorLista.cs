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

namespace Presentacion.ModuloCompra
{
    public partial class FProveedorLista : Form
    {
        public String TxtFlag;

        public FProveedorLista()
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
                DataListado.Columns["cod_proveedor"].Visible = true;
                DataListado.Columns["desc_proveedor"].Visible = true;
                DataListado.Columns["clasificacion"].Visible = false;
                DataListado.Columns["rif"].Visible = true;
                DataListado.Columns["contacto"].Visible = true;
                DataListado.Columns["direccion"].Visible = false;
                DataListado.Columns["direccion_alterna"].Visible = false;
                DataListado.Columns["ciudad"].Visible = false;
                DataListado.Columns["telefono"].Visible = true;
                DataListado.Columns["movil"].Visible = false;
                DataListado.Columns["cod_postal"].Visible = false;
                DataListado.Columns["web"].Visible = false;
                DataListado.Columns["email"].Visible = false;
                DataListado.Columns["montofiscal"].Visible = false;
                DataListado.Columns["descuentopp"].Visible = false;
                DataListado.Columns["descuentogb"].Visible = false;
                DataListado.Columns["limite_cred"].Visible = false;
                DataListado.Columns["activo"].Visible = false;
                DataListado.Columns["nacional"].Visible = false;
                DataListado.Columns["fiscal"].Visible = false;
                DataListado.Columns["aplica_credito"].Visible = false;
                DataListado.Columns["fecha_reg"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_tipoproveedor"].Visible = false;
                DataListado.Columns["desc_tipoproveedor"].Visible = true;
                DataListado.Columns["cod_segmento"].Visible = false;
                DataListado.Columns["desc_segmento"].Visible = false;
                DataListado.Columns["cod_condicionpago"].Visible = false;
                DataListado.Columns["desc_condicionpago"].Visible = false;
                DataListado.Columns["diascredito"].Visible = false;
                DataListado.Columns["cod_cuentasie"].Visible = false;
                DataListado.Columns["desc_cuentasie"].Visible = false;
                DataListado.Columns["cod_islr"].Visible = false;
                DataListado.Columns["desc_islr"].Visible = false;
                DataListado.Columns["cod_pais"].Visible = false;
                DataListado.Columns["desc_pais"].Visible = false;
                DataListado.Columns["cod_moneda"].Visible = false;
                DataListado.Columns["desc_moneda"].Visible = false;
                DataListado.Columns["cod_zona"].Visible = false;
                DataListado.Columns["desc_zona"].Visible = false;

                DataListado.Columns["cod_proveedor"].HeaderText = "Codigo";
                DataListado.Columns["desc_proveedor"].HeaderText = "Descripcion";
                DataListado.Columns["rif"].HeaderText = " Rif ";
                DataListado.Columns["contacto"].HeaderText = "Contacto";
                DataListado.Columns["telefono"].HeaderText = "Telefono";
                DataListado.Columns["desc_tipoproveedor"].HeaderText = "Tipo";

                DataListado.Columns["cod_proveedor"].Width = 120;
                DataListado.Columns["desc_proveedor"].Width = 350;
                DataListado.Columns["rif"].Width = 120;
                DataListado.Columns["contacto"].Width = 150;
                DataListado.Columns["telefono"].Width = 150;
                DataListado.Columns["desc_tipoproveedor"].Width = 150;

                DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FProveedor mForm = FProveedor.GetForm();
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
                DataListado.DataSource = EProveedor.Mostrar();
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
                DataListado.DataSource = EProveedor.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EProveedor.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FProveedorListar_Load(object sender, EventArgs e)
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
                FProveedor mForm = FProveedor.GetForm();
                string cod_proveedor, desc_proveedor, clasificacion, rif, contacto, direccion, direccion_alterna, ciudad, telefono, movil, cod_postal, web, email, montofiscal, descuentopp, descuentogb, limite_cred, activo, nacional, fiscal, aplica_credito, fecha_reg, campo1, campo2, campo3, campo4, campo5, campo6, cod_tipoproveedor, desc_tipoproveedor, cod_segmento, desc_segmento, cod_condicionpago, desc_condicionpago, diascredito, cod_cuentasie, desc_cuentasie, cod_islr, desc_islr, cod_pais, desc_pais, cod_moneda, desc_moneda, cod_zona, desc_zona;

                cod_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_proveedor"].Value);
                desc_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_proveedor"].Value);
                clasificacion = Convert.ToString(DataListado.CurrentRow.Cells["clasificacion"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                contacto = Convert.ToString(DataListado.CurrentRow.Cells["contacto"].Value);
                direccion = Convert.ToString(DataListado.CurrentRow.Cells["direccion"].Value);
                direccion_alterna = Convert.ToString(DataListado.CurrentRow.Cells["direccion_alterna"].Value);
                ciudad = Convert.ToString(DataListado.CurrentRow.Cells["ciudad"].Value);
                telefono = Convert.ToString(DataListado.CurrentRow.Cells["telefono"].Value);
                movil = Convert.ToString(DataListado.CurrentRow.Cells["movil"].Value);
                cod_postal = Convert.ToString(DataListado.CurrentRow.Cells["cod_postal"].Value);
                web = Convert.ToString(DataListado.CurrentRow.Cells["web"].Value);
                email = Convert.ToString(DataListado.CurrentRow.Cells["email"].Value);
                montofiscal = Convert.ToString(DataListado.CurrentRow.Cells["montofiscal"].Value);
                descuentopp = Convert.ToString(DataListado.CurrentRow.Cells["descuentopp"].Value);
                descuentogb = Convert.ToString(DataListado.CurrentRow.Cells["descuentogb"].Value);
                limite_cred = Convert.ToString(DataListado.CurrentRow.Cells["limite_cred"].Value);
                activo = Convert.ToString(DataListado.CurrentRow.Cells["activo"].Value);
                nacional = Convert.ToString(DataListado.CurrentRow.Cells["nacional"].Value);
                fiscal = Convert.ToString(DataListado.CurrentRow.Cells["fiscal"].Value);
                aplica_credito = Convert.ToString(DataListado.CurrentRow.Cells["aplica_credito"].Value);
                fecha_reg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                cod_tipoproveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_tipoproveedor"].Value);
                desc_tipoproveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_tipoproveedor"].Value);
                cod_segmento = Convert.ToString(DataListado.CurrentRow.Cells["cod_segmento"].Value);
                desc_segmento = Convert.ToString(DataListado.CurrentRow.Cells["desc_segmento"].Value);
                cod_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["cod_condicionpago"].Value);
                desc_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["desc_condicionpago"].Value);
                diascredito = Convert.ToString(DataListado.CurrentRow.Cells["diascredito"].Value);
                cod_cuentasie = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuentasie"].Value);
                desc_cuentasie = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuentasie"].Value);
                cod_islr = Convert.ToString(DataListado.CurrentRow.Cells["cod_islr"].Value);
                desc_islr = Convert.ToString(DataListado.CurrentRow.Cells["desc_islr"].Value);
                cod_pais = Convert.ToString(DataListado.CurrentRow.Cells["cod_pais"].Value);
                desc_pais = Convert.ToString(DataListado.CurrentRow.Cells["desc_pais"].Value);
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                cod_zona = Convert.ToString(DataListado.CurrentRow.Cells["cod_zona"].Value);
                desc_zona = Convert.ToString(DataListado.CurrentRow.Cells["desc_zona"].Value);
                mForm.SetProveedor(cod_proveedor, desc_proveedor, clasificacion, rif, contacto, direccion, direccion_alterna, ciudad, telefono, movil, cod_postal, web, email, montofiscal, descuentopp, descuentogb, limite_cred, activo, nacional, fiscal, aplica_credito, fecha_reg, campo1, campo2, campo3, campo4, campo5, campo6, cod_tipoproveedor, desc_tipoproveedor, cod_segmento, desc_segmento, cod_condicionpago, desc_condicionpago, diascredito, cod_cuentasie, desc_cuentasie, cod_islr, desc_islr, cod_pais, desc_pais, cod_moneda, desc_moneda, cod_zona, desc_zona);
                mForm.TxtEditar.Text = "Listar";
            }
            else if (TxtFlag == "CCompra")
            {
                FCCompra mForm = FCCompra.GetForm();
                string cod_proveedor, desc_proveedor,rif, nacional,cod_condicionpago, desc_condicionpago, diascredito;
                cod_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_proveedor"].Value);
                desc_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_proveedor"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                nacional = Convert.ToString(DataListado.CurrentRow.Cells["nacional"].Value);
                cod_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["cod_condicionpago"].Value);
                desc_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["desc_condicionpago"].Value);
                diascredito = Convert.ToString(DataListado.CurrentRow.Cells["diascredito"].Value);
                mForm.SetProveedor(cod_proveedor, desc_proveedor, rif,nacional,cod_condicionpago, desc_condicionpago, diascredito);
            }
            else if (TxtFlag == "PCompra")
            {
                FPCompra mForm = FPCompra.GetForm();
                string cod_proveedor, desc_proveedor, rif, nacional, cod_condicionpago, desc_condicionpago, diascredito;
                cod_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_proveedor"].Value);
                desc_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_proveedor"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                nacional = Convert.ToString(DataListado.CurrentRow.Cells["nacional"].Value);
                cod_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["cod_condicionpago"].Value);
                desc_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["desc_condicionpago"].Value);
                diascredito = Convert.ToString(DataListado.CurrentRow.Cells["diascredito"].Value);
                mForm.SetProveedor(cod_proveedor, desc_proveedor, rif, nacional, cod_condicionpago, desc_condicionpago, diascredito);
            }
            else if (TxtFlag == "FCompra")
            {
                FFCompra mForm = FFCompra.GetForm();
                string cod_proveedor, desc_proveedor, rif, nacional, cod_condicionpago, desc_condicionpago, diascredito;
                cod_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_proveedor"].Value);
                desc_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_proveedor"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                nacional = Convert.ToString(DataListado.CurrentRow.Cells["nacional"].Value);
                cod_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["cod_condicionpago"].Value);
                desc_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["desc_condicionpago"].Value);
                diascredito = Convert.ToString(DataListado.CurrentRow.Cells["diascredito"].Value);
                mForm.SetProveedor(cod_proveedor, desc_proveedor, rif, nacional, cod_condicionpago, desc_condicionpago, diascredito);
            }
            else if (TxtFlag == "DCompra")
            {
                FDCompra mForm = FDCompra.GetForm();
                string cod_proveedor, desc_proveedor, rif, nacional, cod_condicionpago, desc_condicionpago, diascredito;
                cod_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_proveedor"].Value);
                desc_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_proveedor"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                nacional = Convert.ToString(DataListado.CurrentRow.Cells["nacional"].Value);
                cod_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["cod_condicionpago"].Value);
                desc_condicionpago = Convert.ToString(DataListado.CurrentRow.Cells["desc_condicionpago"].Value);
                diascredito = Convert.ToString(DataListado.CurrentRow.Cells["diascredito"].Value);
                mForm.SetProveedor(cod_proveedor, desc_proveedor, rif, nacional, cod_condicionpago, desc_condicionpago, diascredito);
            }
            else if (TxtFlag == "Pagar")
            {
                FPago mForm = FPago.GetForm();
                string cod_proveedor, desc_proveedor, rif;
                cod_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["cod_proveedor"].Value);
                desc_proveedor = Convert.ToString(DataListado.CurrentRow.Cells["desc_proveedor"].Value);
                rif = Convert.ToString(DataListado.CurrentRow.Cells["rif"].Value);
                mForm.SetProveedor(cod_proveedor, desc_proveedor, rif);
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
                            Rpta = EProveedor.Eliminar(Convert.ToString(row.Cells["cod_proveedor"].Value));
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
            //FRptProveedor Reporte = new FRptProveedor();
            //Reporte.ShowDialog();
        }

    }
}
