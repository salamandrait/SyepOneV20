using Entidades;
using Presentacion.ModuloInventario;
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
    public partial class FArtCargarC : Form
    {

        private static FArtCargarC _Instacia;

        public static FArtCargarC GetArtCargarC()
        {
            if (_Instacia == null)
            {
                _Instacia = new FArtCargarC();
            }
            return _Instacia;
        }

        public FArtCargarC()
        {
            InitializeComponent();
            ListarImpuesto();
            ListarDeposito();
        }

        private void Limpiar()
        {
            TxtCod_articulo.Text = string.Empty;
            TxtDesc_articulo.Text = string.Empty;
            TxtCod_deposito.Text = string.Empty;
            TxtDesc_deposito.Text = string.Empty;
            TxtCod_unidad.Text = string.Empty;
            TxtDesc_unidad.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtMontound.Text = string.Empty;
            TxtDescuento.Text = string.Empty;
            TxtDesc_impuesto.Text = "Tasa General";
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ListarDeposito()
        {
            DataTable DtDep = EDeposito.Mostrar();
            for (int i = 0; i <= Convert.ToInt32(DtDep.Rows.Count) - 1; i++)
            {
                TxtDesc_deposito.Items.Add(DtDep.Rows[i]["desc_deposito"].ToString());
            }
        }

        internal void ListarImpuesto()
        {
            DataTable DtImp = EImpuesto.Mostrar();

            for (int i = 0; i <= Convert.ToInt32(DtImp.Rows.Count) - 1; i++)
            {
                TxtDesc_impuesto.Items.Add(DtImp.Rows[i]["desc_impuesto"].ToString());
            }
        }

        private void SeleccionarDeposito()
        {
            DataSet DsDep = EDeposito.ListarOp(TxtDesc_deposito.Text);
            TxtCod_deposito.Text = DsDep.Tables[0].Rows[0]["cod_deposito"].ToString();
        }

        private void SeleccionarImpuesto()
        {
            try
            {
                DataSet DsImp = EImpuesto.ListarTasa(TxtDesc_impuesto.Text);
                TxtCod_impuesto.Text = DsImp.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtTasaimp.Text = DsImp.Tables[0].Rows[0]["tasaimp"].ToString();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }

        }

        internal void InsertarNuevo()
        {
            string reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund;

            reng = TxtReng.Text;
            cod_impuesto = TxtCod_impuesto.Text;
            cod_deposito = TxtCod_deposito.Text;
            cod_unidad = TxtCod_unidad.Text;
            cod_articulo = TxtCod_articulo.Text;
            desc_articulo = TxtDesc_articulo.Text;
            desc_deposito = TxtDesc_deposito.Text;
            desc_unidad = TxtDesc_unidad.Text;
            cantidad = TxtCantidad.Text;
            equivalencia = TxtEquivalencia.Text;
            montound = TxtMontound.Text;
            descuento = TxtDescuento.Text;
            descuentop = TxtDescuentop.Text;
            subtotalund = TxtSubtotalund.Text;
            desc_impuesto = TxtDesc_impuesto.Text;
            tasaimp = TxtTasaimp.Text;
            montoimp = TxtMontoimp.Text;
            totalund = TxtTotalund.Text;

            try
            {
                if (TxtCod_articulo.Text == string.Empty || TxtCod_deposito.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar algunos Datos");
                }
                else
                {
                    bool registrar = true;
                    if (TxtFlag.Text == "CCompra")
                    {
                        FCCompra mForm = FCCompra.GetForm();

                        foreach (DataRow row in mForm.DtDetalle.Rows)
                        {
                            if (Convert.ToString(row["cod_articulo"]).Equals(cod_articulo))
                            {
                                registrar = false;
                                MensajeError("El Articulo Seleccionado ya se encuentra en la Lista");
                            }
                        }
                        if (registrar)
                        {
                            mForm.AgregarColumnas(reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, "N", reng);
                            mForm.CalcularDetalle();
                            Close();
                            Limpiar();
                        }
                    }
                    else if (TxtFlag.Text == "PCompra")
                    {
                        FPCompra mForm = FPCompra.GetForm();

                        foreach (DataRow row in mForm.DtDetalle.Rows)
                        {
                            if (Convert.ToString(row["cod_articulo"]).Equals(cod_articulo))
                            {
                                registrar = false;
                                MensajeError("El Articulo Seleccionado ya se encuentra en la Lista");
                            }
                        }
                        if (registrar)
                        {
                            mForm.AgregarColumnas(reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, "N", reng);
                            mForm.CalcularDetalle();
                            Close();
                            Limpiar();
                        }
                    }
                    else if (TxtFlag.Text == "FCompra")
                    {
                        FFCompra mForm = FFCompra.GetForm();

                        foreach (DataRow row in mForm.DtDetalle.Rows)
                        {
                            if (Convert.ToString(row["cod_articulo"]).Equals(cod_articulo))
                            {
                                registrar = false;
                                MensajeError("El Articulo Seleccionado ya se encuentra en la Lista");
                            }
                        }
                        if (registrar)
                        {
                            mForm.AgregarColumnas(reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, "N", reng);
                            mForm.CalcularDetalle();
                            Close();
                            Limpiar();
                        }
                    }
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        internal void InsertarEditar()
        {
            try
            {
                bool registrar = true;
                string Rpta = "";
                if (TxtFlag.Text == "CCompra")
                {
                    FCCompra mForm = FCCompra.GetForm();

                    foreach (DataGridViewRow row in mForm.DataListado.Rows)
                    {
                        if (Convert.ToString(row.Cells["cod_articulo"].Value) == TxtCod_articulo.Text)
                        {
                            registrar = false;
                            MensajeError("El Articulo Seleccionado ya se encuentra en la Lista");
                        }
                    }
                    if (registrar)
                    {
                        Rpta = ECCompraDetalle.Insertar(TxtCod_compra.Text, TxtCod_deposito.Text, TxtCod_articulo.Text, TxtCod_unidad.Text, TxtCod_impuesto.Text, TxtOptipo.Text, Convert.ToDecimal(TxtCantidad.Text), Convert.ToDecimal(TxtEquivalencia.Text), Convert.ToDecimal(TxtMontound.Text), Convert.ToDecimal(TxtDescuento.Text), Convert.ToDecimal(TxtDescuentop.Text), Convert.ToDecimal(TxtSubtotalund.Text), Convert.ToDecimal(TxtMontoimp.Text), Convert.ToDecimal(TxtTotalund.Text), Convert.ToInt32(TxtReng.Text));
                        mForm.MostrarDetalle();
                        mForm.CalcularDetalle();
                        Close();
                        Limpiar();
                    }
                }
                else if (TxtFlag.Text == "PCompra")
                {
                    FPCompra mForm = FPCompra.GetForm();

                    foreach (DataGridViewRow row in mForm.DataListado.Rows)
                    {

                        if (Convert.ToString(row.Cells["cod_articulo"].Value) == TxtCod_articulo.Text)
                        {
                            registrar = false;
                            MensajeError("El Articulo Seleccionado ya se encuentra en la Lista");
                        }
                    }
                    if (registrar)
                    {
                        Rpta = EPCompraDetalle.Insertar(TxtCod_compra.Text, TxtCod_deposito.Text, TxtCod_articulo.Text, TxtCod_unidad.Text, TxtCod_impuesto.Text, TxtOptipo.Text, Convert.ToDecimal(TxtCantidad.Text), Convert.ToDecimal(TxtEquivalencia.Text), Convert.ToDecimal(TxtMontound.Text), Convert.ToDecimal(TxtDescuento.Text), Convert.ToDecimal(TxtDescuentop.Text), Convert.ToDecimal(TxtSubtotalund.Text), Convert.ToDecimal(TxtMontoimp.Text), Convert.ToDecimal(TxtTotalund.Text), Convert.ToInt32(TxtReng.Text));
                        mForm.MostrarDetalle();
                        mForm.CalcularDetalle();
                        Close();
                        Limpiar();
                    }
                }
                else if (TxtFlag.Text == "FCompra")
                {
                    FFCompra mForm = FFCompra.GetForm();

                    foreach (DataGridViewRow row in mForm.DataListado.Rows)
                    {
                        if (Convert.ToString(row.Cells["cod_articulo"].Value) == TxtCod_articulo.Text)
                        {
                            registrar = false;
                            MensajeError("El Articulo Seleccionado ya se encuentra en la Lista");
                        }
                    }
                    if (registrar)
                    {
                        Rpta = EFCompraDetalle.Insertar(TxtCod_compra.Text, TxtCod_deposito.Text, TxtCod_articulo.Text, TxtCod_unidad.Text, TxtCod_impuesto.Text, TxtOptipo.Text, Convert.ToDecimal(TxtCantidad.Text), Convert.ToDecimal(TxtEquivalencia.Text), Convert.ToDecimal(TxtMontound.Text), Convert.ToDecimal(TxtDescuento.Text), Convert.ToDecimal(TxtDescuentop.Text), Convert.ToDecimal(TxtSubtotalund.Text), Convert.ToDecimal(TxtMontoimp.Text), Convert.ToDecimal(TxtTotalund.Text), "N", Convert.ToInt32(TxtReng.Text));
                        mForm.MostrarDetalle();
                        mForm.CalcularDetalle();
                        Close();
                        Limpiar();
                    }
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        internal void SetColumnas(string reng, string cod_compra, string cod_deposito, string cod_impuesto, string optipo, string cod_articulo, string desc_articulo, string desc_deposito, string cod_unidad, string desc_unidad, string cantidad, string equivalencia, string montound, string descuento, string descuentop, string subtotalund, string desc_impuesto, string tasaimp, string montoimp, string totalund)
        {
            TxtReng.Text = reng;
            TxtCod_compra.Text = cod_compra;
            TxtCod_deposito.Text = cod_deposito;
            TxtCod_impuesto.Text = cod_impuesto;
            TxtOptipo.Text = optipo;
            TxtCod_articulo.Text = cod_articulo;
            TxtDesc_articulo.Text = desc_articulo;
            TxtDesc_deposito.Text = desc_deposito;
            TxtCod_unidad.Text = cod_unidad;
            TxtDesc_unidad.Text = desc_unidad;
            TxtCantidad.Text = cantidad;
            TxtEquivalencia.Text = equivalencia;
            TxtMontound.Text = montound;
            TxtDescuento.Text = descuento;
            TxtDescuentop.Text = descuentop;
            TxtSubtotalund.Text = subtotalund;
            TxtDesc_impuesto.Text = desc_impuesto;
            TxtTasaimp.Text = tasaimp;
            TxtMontoimp.Text = montoimp;
            TxtTotalund.Text = totalund;
        }

        private void CArtCargar_Load(object sender, EventArgs e)
        {
            DataSet Dep = EDeposito.Listar();
            TxtCod_deposito.Text = Dep.Tables[0].Rows[0]["cod_deposito"].ToString();
            TxtDesc_deposito.Text = Dep.Tables[0].Rows[0]["Desc_deposito"].ToString();

            TxtDesc_impuesto.Text = "Tasa General";
            Top = 160;
        }

        private void TxtCod_articulo_DoubleClick(object sender, EventArgs e)
        {
            FArtUnidadLista Listado = FArtUnidadLista.GetArtUnidadLista();
            Listado.Flag = "Comp";
            Listado.ShowDialog();
        }

        private void TxtDesc_deposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarDeposito();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtFlag.Text == "CCompra")
            {
                if (TxtEditar.Text == "Nuevo")
                {
                    InsertarNuevo();
                }
                else if (TxtEditar.Text == "Editar")
                {
                    InsertarEditar();
                }
            }
            else if (TxtFlag.Text == "PCompra")
            {
                if (TxtEditar.Text == "Nuevo")
                {
                    InsertarNuevo();
                }
                else if (TxtEditar.Text == "Editar")
                {
                    InsertarEditar();
                }
            }
            else if (TxtFlag.Text == "FCompra")
            {
                if (TxtEditar.Text == "Nuevo")
                {
                    InsertarNuevo();
                }
                else if (TxtEditar.Text == "Editar")
                {
                    InsertarEditar();
                }
            }
        }

        private void TxtDesc_impuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarImpuesto();
        }

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {
            TxtSubtotalund.Value = TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value);
            TxtMontoimp.Value = ((TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value)) * TxtTasaimp.Value) / 100;
            TxtEquivalencia.Value = TxtContador.Value * TxtCantidad.Value;
        }

        private void TxtMontound_ValueChanged(object sender, EventArgs e)
        {
            TxtSubtotalund.Value = TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value);
            TxtMontoimp.Value = ((TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value)) * TxtTasaimp.Value) / 100;
        }

        private void TxtTasaimp_ValueChanged(object sender, EventArgs e)
        {
            TxtMontoimp.Value = ((TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value)) * TxtTasaimp.Value) / 100;
        }

        private void TxtDescuento_ValueChanged(object sender, EventArgs e)
        {
            TxtSubtotalund.Value = TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value);
            TxtMontoimp.Value = ((TxtCantidad.Value * (TxtMontound.Value - TxtDescuento.Value)) * TxtTasaimp.Value) / 100;
        }

        private void TxtSubtotalund_ValueChanged(object sender, EventArgs e)
        {
            TxtTotalund.Value = TxtSubtotalund.Value + TxtMontoimp.Value;
        }

        private void TxtMontoimp_ValueChanged(object sender, EventArgs e)
        {
            TxtTotalund.Value = TxtSubtotalund.Value + TxtMontoimp.Value;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (TxtEditar.Text == "Editar" && TxtCod_articulo.Text != string.Empty)
            {
                InsertarEditar();
            }
            else if (TxtCod_articulo.Text == string.Empty)
            {
                Close();
            }
        }

        private void FArtCargarC_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instacia = null;
        }

        private void TxtContador_ValueChanged(object sender, EventArgs e)
        {
            TxtEquivalencia.Value = TxtContador.Value * TxtCantidad.Value;
        }
    }
}
