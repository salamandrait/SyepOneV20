using Entidades;
using Presentacion.ModuloBanco;
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
    public partial class FPago : Form
    {

        string Pref = "";
        string TxtCod_moneda = "";
        decimal Saldocuenta = 0;
        DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();
        DialogResult Opcion;
        DataTable DtDetalle = new DataTable();

        private static FPago _Instancia;

        public static FPago GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FPago();
            }
            return _Instancia;
        }

        public FPago()
        {
            InitializeComponent();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 5.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 5.1:::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Top_serie()
        {
            try
            {
                Ds = ECorrelativos.GetCorrelativo(TxtTabla.Text);

                TxtCadena.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                Pref = Ds.Tables[0].Rows[0]["precadena"].ToString();
            }
            catch (Exception Ex)
            {
                string rpta = "";
                rpta = Ex.Message;
            }
        }

        private void Registros()
        {
            Dt = EPago.Mostrar();
            LbTotalReg.Text = Convert.ToString(Dt.Rows.Count.ToString());
        }

        private void MostraUsuario()
        {
            FLogin mFLogin = FLogin.GetForm();
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet Ds = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
            TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
        }

        private void Limpiar()
        {
            TxtCod_pago.Text = String.Empty;
            TxtCod_pagov.Text = String.Empty;
            TxtDesc_pago.Text = String.Empty;
            TxtCod_proveedor.Text = String.Empty;
            TxtDesc_proveedor.Text = String.Empty;
            TxtRif.Text = String.Empty;
            TxtFecha_reg.Text = String.Empty;
            TxtEstatus.Text = "Sin Procesar";
            //TxtForma.Text = "Transferencia";
            TxtMonto.Text = String.Empty;
            TxtCampo1.Text = String.Empty;
            TxtCampo2.Text = String.Empty;
            TxtCampo3.Text = String.Empty;
            TxtCampo4.Text = String.Empty;
            TxtCampo5.Text = String.Empty;
            TxtCampo6.Text = String.Empty;

            TxtCod_pago.Text = String.Empty;
            TxtCod_cuenta.Text = String.Empty;
            TxtCod_caja.Text = String.Empty;
            TxtCod_compra.Text = String.Empty;
            TxtNumdocpago.Text = String.Empty;
            TxtOptipo.Text = String.Empty;
            TxtForma.Text = "Transferencia";
            TxtCod_movbanco.Text = String.Empty;
            TxtCod_movcaja.Text = String.Empty;
            TxtAbonoGen.Text = String.Empty;
            TxtEsretenislr.Text = false.ToString();
            TxtEsreteniva.Text = false.ToString();
            TxtFecha_reg.Text = String.Empty;
            TxtCod_caja.Visible = false;
            TxtDesc_caja.Visible = false;
            TxtCod_movcaja.Visible = false;
            Top_serie();
        }

        private void Habilitar(bool Valor)
        {
            TxtCod_pago.Enabled = Valor;
            TxtCod_pagov.Enabled = Valor;
            TxtDesc_pago.Enabled = Valor;
            TxtCod_proveedor.Enabled = Valor;
            TxtDesc_proveedor.Enabled = Valor;
            TxtRif.Enabled = Valor;
            TxtFecha_reg.Enabled = Valor;
            TxtEstatus.Enabled = Valor;
            TxtMonto.Enabled = Valor;
            Top_serie();
        }

        internal void Botones()
        {
            if (TxtEditar.Text == "Nuevo")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;

                BtnAnterior.Enabled = false;
                BtnPrimero.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnUltimo.Enabled = false;

                //BtnImportar.Enabled = true;
                //BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Enabled = true;
                //BtnOtros.Enabled = true;
                //BtnArtCargar.Enabled = true;
                //ChkEliminarReng.Enabled = true;

                //ImportarChk.Visible = false;
                //BtnAceptarImp.Visible = false;
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;

                BtnAnterior.Enabled = false;
                BtnPrimero.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnUltimo.Enabled = false;

                //BtnImportar.Enabled = true;
                //BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Enabled = true;
                //BtnOtros.Enabled = true;
                //BtnArtCargar.Enabled = true;
                //ChkEliminarReng.Enabled = true;

                //ImportarChk.Visible = false;
                //BtnAceptarImp.Visible = false;
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnImprimir.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;

                //BtnImportar.Enabled = false;
                //BtnPagar.Enabled = true;
                BtnAnular.Enabled = true;
                //BtnEliminarReng.Enabled = true;
                //BtnOtros.Enabled = true;
                //BtnArtCargar.Enabled = true;
                //ChkEliminarReng.Enabled = true;

                //ImportarChk.Visible = false;
                //BtnAceptarImp.Visible = false;
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;

                //BtnImportar.Enabled = false;
                //BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Enabled = false;
                //BtnOtros.Enabled = false;
                //BtnArtCargar.Enabled = false;
                //ChkEliminarReng.Enabled = false;

                //ImportarChk.Visible = false;
                //BtnAceptarImp.Visible = false;
                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Anulado")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;

                //BtnImportar.Enabled = false;
                //BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Enabled = false;
                //BtnOtros.Enabled = false;
                //BtnArtCargar.Enabled = false;
                //ChkEliminarReng.Enabled = false;

                //ImportarChk.Visible = false;
                //BtnAceptarImp.Visible = false;
                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;

                //BtnImportar.Enabled = false;
                //BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Visible = false;
                //BtnOtros.Enabled = false;
                //BtnArtCargar.Visible = false;
                //ChkEliminarReng.Visible = false;

                //ImportarChk.Visible = true;
                //BtnAceptarImp.Visible = false;
                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado Parcial")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;

                //BtnImportar.Enabled = false;
                //BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Visible = false;
                //BtnOtros.Enabled = false;
                //BtnArtCargar.Visible = false;
                //ChkEliminarReng.Visible = false;

                //ImportarChk.Visible = true;
                //BtnAceptarImp.Visible = false;
                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado Parcial")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;

                //BtnImportar.Enabled = false;
                //BtnPagar.Enabled = true;
                BtnAnular.Enabled = false;
                //BtnEliminarReng.Visible = false;
                //BtnOtros.Enabled = false;
                //BtnArtCargar.Visible = false;
                //ChkEliminarReng.Visible = false;

                //ImportarChk.Visible = true;
                //BtnAceptarImp.Visible = false;
                Habilitar(false);
            }
        }

        private void CbBtipo()
        {
            CbBucar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Rif" });
        }

        private void FormaPago()
        {
            TxtForma.Items.AddRange(new object[] { "Transferencia", "Cheque", "Deposito", "Efectivo" });
        }

        private void Listar()
        {
            try
            {
                DataSet DsListar = EPago.Listar();

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["Cod_proveedor"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["Desc_pago"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["Estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["Anulado"].ToString();
                TxtMonto.Text = DsListar.Tables[0].Rows[0]["Monto"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = DsListar.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
            }
            catch (Exception Exc)
            {
                Limpiar();
                Show();
                TxtEditar.Text = "Nuevo";
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                Botones();
                string rpta = Exc.Message;
                DataListado.DataSource = null;
            }
            MostraUsuario();
            Botones();
            Registros();
            FormaPago();
        }

        private void CambiosTexBox()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
            }
            ErrorTexto.Dispose();
        }

        private void FPago_Load(object sender, EventArgs e)
        {
            Listar();
            CbBtipo();
            CbBucar.Text = "Codigo";
        }

        #region LLAMAR REGISTROS
        internal void SetProveedor(string cod_proveedor, string desc_proveedor, string rif)
        {
            TxtCod_proveedor.Text = cod_proveedor;
            TxtDesc_proveedor.Text = desc_proveedor;
            TxtRif.Text = rif;
        }

        private void TxtCod_proveedor_DoubleClick(object sender, EventArgs e)
        {
            DataListado.DataSource = null;
            TxtMonto.Text = "";
            FProveedorLista Listado = new FProveedorLista
            {
                TxtFlag = "Pagar"
            };
            Dt = EProveedor.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
            DataListado.DataSource = null;
            TxtMonto.Text = "";
        }

        private void TxtCod_proveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                DataListado.DataSource = null;
                TxtMonto.Text = "";
                FProveedorLista Listado = new FProveedorLista
                {
                    TxtFlag = "Pagar"
                };
                Dt = EProveedor.Mostrar();
                if (Dt.Rows.Count == 0)
                {
                    MensajeError("No Existen Registros Disponibles!");
                }
                else if (Dt.Rows.Count != 0)
                {
                    Listado.ShowDialog();
                };
                DataListado.DataSource = null;
                TxtMonto.Text = "";
            }
        }

        private void TxtCod_caja_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt = ECaja.Mostrar();

            foreach (DataRow Row in Dt.Rows)
            {
                if (Convert.ToString(Row["cod_caja"]).Equals(TxtCod_caja.Text))
                {
                    TxtDesc_caja.Text = Convert.ToString(Row["desc_caja"]);
                }
            }
        }

        internal void SetCuenta(string cod_cuenta, string desc_cuenta, string cod_moneda, string saldo)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtCod_moneda = cod_moneda;
            Saldocuenta = Convert.ToDecimal(saldo);
        }

        private void TxtCod_cuenta_DoubleClick(object sender, EventArgs e)
        {
            FCuentaLista Listado = new FCuentaLista
            {
                TxtFlag = "Pago"
            };

            Dt = ECuenta.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FCuentaLista Listado = new FCuentaLista
                {
                    TxtFlag = "Pago"
                };

                Dt = ECuenta.Mostrar();
                if (Dt.Rows.Count == 0)
                {
                    MensajeError("No Existen Registros Disponibles!");
                }
                else if (Dt.Rows.Count != 0)
                {
                    Listado.ShowDialog();
                };
            }
        }
        #endregion

        #region PROCESOS
        private void MostarDoc()
        {
            DataListado.DataSource = EPago.MostrarProv(TxtCod_proveedor.Text);
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            if (DataListado.Rows.Count != 0)
            {
                foreach (DataGridViewRow Fila in DataListado.Rows)
                {
                    #region CICLO FOREACH
                    if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("PCompra"))
                    {
                        Fila.Cells["optipo"].Value = "Pedido";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("FCompra"))
                    {
                        Fila.Cells["optipo"].Value = "Factura";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("DCompra"))
                    {
                        Fila.Cells["optipo"].Value = "Doc. de Compra";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("RETIVA"))
                    {
                        Fila.Cells["optipo"].Value = "Retencion de IVA";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("RETISLR"))
                    {
                        Fila.Cells["optipo"].Value = "Retencion de ISLR";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("ND"))
                    {
                        Fila.Cells["optipo"].Value = "Nota de Debito";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("NC"))
                    {
                        Fila.Cells["optipo"].Value = "Nota de Credito";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("AJNC"))
                    {
                        Fila.Cells["optipo"].Value = "Ajuste Negativo";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("AJPC"))
                    {
                        Fila.Cells["optipo"].Value = "Ajuste Positivo";
                    }
                    else if (Convert.ToString(Fila.Cells["optipo"].Value).Equals("ADP"))
                    {
                        Fila.Cells["optipo"].Value = "Adelanto de Pago";
                    }
                    #endregion
                    DataListado.Columns["eliminar"].Visible = false;
                    DataListado.Columns["anular"].Visible = false;
                    DataListado.Columns["cod_compra"].Visible = false;
                    DataListado.Columns["numdocumento"].Visible = true;
                    DataListado.Columns["optipo"].Visible = true;
                    DataListado.Columns["total"].Visible = true;
                    DataListado.Columns["monto"].Visible = true;
                    DataListado.Columns["saldo"].Visible = true;
                    DataListado.Columns["esretenislr"].Visible = true;
                    DataListado.Columns["esreteniva"].Visible = true;
                    DataListado.Columns["fecha_doc"].Visible = true;
                    DataListado.Columns["fecha_ven"].Visible = true;

                    DataListado.Columns["numdocumento"].HeaderText = "N° Doc.";
                    DataListado.Columns["optipo"].HeaderText = "Tipo Doc.";
                    DataListado.Columns["total"].HeaderText = "Total";
                    DataListado.Columns["monto"].HeaderText = "Abono";
                    DataListado.Columns["saldo"].HeaderText = "Saldo";
                    DataListado.Columns["esreteniva"].HeaderText = "R.I.V.A.";
                    DataListado.Columns["esretenislr"].HeaderText = "R.I.S.L.R.";
                    DataListado.Columns["fecha_doc"].HeaderText = "Emision";
                    DataListado.Columns["fecha_ven"].HeaderText = "Venc.";

                    DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DataListado.Columns["total"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListado.Columns["monto"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListado.Columns["saldo"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

                    DataListado.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["fecha_doc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DataListado.Columns["fecha_ven"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataListado.Columns["numdocumento"].Width = 120;
                    DataListado.Columns["optipo"].Width = 150;
                    DataListado.Columns["total"].Width = 150;
                    DataListado.Columns["monto"].Width = 150;
                    DataListado.Columns["saldo"].Width = 150;
                    DataListado.Columns["esreteniva"].Width = 80;
                    DataListado.Columns["esretenislr"].Width = 80;
                }
            }
            else
            {

            }
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            MostarDoc();
            if (DataListado.Rows.Count == 0)
            {
                MensajeError("El Proveedor Seleccionado No posee Documentos Pendientes!");
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Guardar();
            Botones();
            Registros();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Listar();
            Botones();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Nuevo";
            Limpiar();
            Botones();
            DataListado.DataSource = null;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void TxtForma_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_proveedor_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_pago_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtAnulado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo1_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo2_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo3_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo4_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo5_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo6_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtMonto_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }
        #endregion

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {

                Ds = EPago.Primero();

                TxtCod_pago.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_pagov.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_proveedor.Text = Ds.Tables[0].Rows[0]["Cod_proveedor"].ToString();
                TxtDesc_pago.Text = Ds.Tables[0].Rows[0]["Desc_pago"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["Estatus"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["Anulado"].ToString();
                TxtMonto.Text = Ds.Tables[0].Rows[0]["Monto"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                //MostrarDetalle();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            try
            {

                Ds = EPago.Anterior(TxtCod_pago.Text);

                TxtCod_pago.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_pagov.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_proveedor.Text = Ds.Tables[0].Rows[0]["Cod_proveedor"].ToString();
                TxtDesc_pago.Text = Ds.Tables[0].Rows[0]["Desc_pago"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["Estatus"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["Anulado"].ToString();
                TxtMonto.Text = Ds.Tables[0].Rows[0]["Monto"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                //MostrarDetalle();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {

                Ds = EPago.Siguiente(TxtCod_pago.Text);

                TxtCod_pago.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_pagov.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_proveedor.Text = Ds.Tables[0].Rows[0]["Cod_proveedor"].ToString();
                TxtDesc_pago.Text = Ds.Tables[0].Rows[0]["Desc_pago"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["Estatus"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["Anulado"].ToString();
                TxtMonto.Text = Ds.Tables[0].Rows[0]["Monto"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                //MostrarDetalle();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {

            try
            {

                Ds = EPago.Ultimo();

                TxtCod_pago.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_pagov.Text = Ds.Tables[0].Rows[0]["Cod_pago"].ToString();
                TxtCod_proveedor.Text = Ds.Tables[0].Rows[0]["Cod_proveedor"].ToString();
                TxtDesc_pago.Text = Ds.Tables[0].Rows[0]["Desc_pago"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["Estatus"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["Anulado"].ToString();
                TxtMonto.Text = Ds.Tables[0].Rows[0]["Monto"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                //MostrarDetalle();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        #endregion


        private void FPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                Opcion = MessageBox.Show("Desea Guardar el Registro antes de Salir? ", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    //Guardar();
                }
            }
        }

        private void TxtForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtForma.Text == "Transferencia" || TxtForma.Text == "Cheque")
            {
                TxtCod_cuenta.Visible = true;
                TxtDesc_cuenta.Visible = true;
                TxtCod_movbanco.Visible = true;
                TxtCod_caja.Visible = false;
                TxtDesc_caja.Visible = false;
                TxtCod_movcaja.Visible = false;
                TxtCod_caja.Text = "";
                TxtDesc_caja.Text = "";
                TxtCod_movcaja.Text = "";
            }
            else if (TxtForma.Text == "Deposito" || TxtForma.Text == "Efectivo")
            {
                TxtCod_cuenta.Visible = false;
                TxtDesc_cuenta.Visible = false;
                TxtCod_movbanco.Visible = false;
                TxtCod_caja.Visible = true;
                TxtDesc_caja.Visible = true;
                TxtCod_movcaja.Visible = true;
                TxtCod_cuenta.Text = "";
                TxtDesc_cuenta.Text = "";
                TxtCod_movbanco.Text = "";
            }
        }

        private void DataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Factura"))
                {
                    TxtOptipo.Text = "FCompra";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Pedido"))
                {
                    TxtOptipo.Text = "PCompra";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Doc. de Compra"))
                {
                    TxtOptipo.Text = "DCompra";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Retencion de IVA"))
                {
                    TxtOptipo.Text = "RETIVA";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Retencion de ISLR"))
                {
                    TxtOptipo.Text = "RETISLR";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Nota de Debito"))
                {
                    TxtOptipo.Text = "ND";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Nota de Credito"))
                {
                    TxtOptipo.Text = "NC";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Ajuste Negativo"))
                {
                    TxtOptipo.Text = "AJNC";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Ajuste Positivo"))
                {
                    TxtOptipo.Text = "AJPC";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Adelanto de Pago"))
                {
                    TxtOptipo.Text = "ADP";
                }

                TxtCod_compra.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_compra"].Value);
                TxtEsretenislr.Text = Convert.ToString(DataListado.CurrentRow.Cells["esretenislr"].Value);
                TxtEsreteniva.Text = Convert.ToString(DataListado.CurrentRow.Cells["esreteniva"].Value);

                TxtCod_caja.Text = string.Empty;
                TxtDesc_caja.Text = string.Empty;
                TxtCod_cuenta.Text = string.Empty;
                TxtDesc_cuenta.Text = string.Empty;
                TxtNumdocpago.Text = string.Empty;

                TxtTotal.Text = Convert.ToString(DataListado.CurrentRow.Cells["total"].Value);
                TxtSaldo.Text = Convert.ToString(DataListado.CurrentRow.Cells["saldo"].Value);

            }
        }
    }
}
