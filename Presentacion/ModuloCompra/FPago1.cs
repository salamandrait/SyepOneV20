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
        public bool Importar = false;
        Decimal Saldocuenta = 0;
        Decimal Saldocaja = 0;
        Decimal Total = 0;
        Decimal Abono = 0;
        Decimal Saldo = 0;
        String Moneda = "";
        public string TipoImp = "";
        internal DataTable DtDetalle;
        string Pref = "";
        DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();
        DialogResult Opcion;

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
            ListarCaja();
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

        private void CambiosTexBox()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
            }
            ErrorTexto.Dispose();
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
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar" && Importar == false)
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
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado" && (Importar == true || Importar == false))
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
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Anulado" && (Importar == true || Importar == false))
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
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar" && Importar == true)
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
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado Parcial" && Importar == true)
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
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado Parcial" && Importar == false)
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

        private void GenerarCod()
        {
            Top_serie();
            try
            {
                int rpta = Convert.ToInt32(EPago.GenerarCod(TxtCod_pago.Text));
                TxtCod_pago.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_pago.Focus();
            }
        }

        public void Limpiar()
        {
            TxtCod_pago.Text = string.Empty;
            TxtCod_proveedor.Text = string.Empty;
            TxtDesc_proveedor.Text = string.Empty;
            TxtRif.Text = string.Empty;
            TxtDesc_pago.Text = string.Empty;
            TxtEstatus.Text = "Sin Procesar";
            TxtAnulado.Text = false.ToString();
            TxtMonto.Text = string.Empty;
            TxtFecha_reg.Text = string.Empty;
            TxtFecha_regpago.Text = string.Empty;
            TxtCod_movbanco.Text = string.Empty;
            TxtCod_movcaja.Text = string.Empty;
            TxtEsretenislr.Text = false.ToString();
            TxtEsreteniva.Text = false.ToString();
            TxtNumdocpago.Text = string.Empty;
            TxtOptipo.Text = string.Empty;
            TxtSerialretiva.Text = string.Empty;
            TxtCod_caja.Text = string.Empty;
            TxtCod_cuenta.Text = string.Empty;
            TxtCod_compra.Text = string.Empty;
            TxtDesc_caja.Text = string.Empty;
            TxtDesc_cuenta.Text = string.Empty;
            TxtCod_islr.Text = string.Empty;
            TxtCampo1.Text = string.Empty;
            TxtCampo2.Text = string.Empty;
            TxtCampo3.Text = string.Empty;
            TxtCampo4.Text = string.Empty;
            TxtCampo5.Text = string.Empty;
            TxtCampo6.Text = string.Empty;
            TxtBForma.Text = "Transferencia";
            Top_serie();
        }

        public void Habilitar(bool valor)
        {
            TxtCod_pago.Enabled = valor;
            TxtCod_proveedor.Enabled = valor;
            TxtDesc_proveedor.Enabled = valor;
            TxtRif.Enabled = valor;
            TxtDesc_pago.Enabled = valor;
            TxtEstatus.Enabled = valor;
            TxtMonto.Enabled = valor;
            TxtFecha_reg.Enabled = valor;
            TxtCampo1.Enabled = valor;
            TxtCampo2.Enabled = valor;
            TxtCampo3.Enabled = valor;
            TxtCampo4.Enabled = valor;
            TxtCampo5.Enabled = valor;
            TxtCampo6.Enabled = valor;

        }

        private void Listar()
        {
            try
            {
                DataSet DsListar = EPago.Listar();

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["desc_pago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["Rif"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();

                TxtCod_caja.Text = DsListar.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = DsListar.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = DsListar.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = DsListar.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_islr.Text = DsListar.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtCod_compra.Text = DsListar.Tables[0].Rows[0]["cod_compra"].ToString();
                TxtNumdocpago.Text = DsListar.Tables[0].Rows[0]["numdocpago"].ToString();
                TxtSerialretiva.Text = DsListar.Tables[0].Rows[0]["serialretiva"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtBForma.Text = DsListar.Tables[0].Rows[0]["forma"].ToString();
                TxtMonto.Text = DsListar.Tables[0].Rows[0]["monto"].ToString();
                TxtEsreteniva.Text = DsListar.Tables[0].Rows[0]["esreteniva"].ToString();
                TxtEsretenislr.Text = DsListar.Tables[0].Rows[0]["esretenislr"].ToString();

                TxtEditar.Text = "Listar";
                TxtSaldo.Text = string.Empty;
                MostrarDetalle();

            }
            catch (Exception Exc)
            {
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                TxtEditar.Text = "Nuevo";
                Limpiar();
                Botones();
                string rpta = Exc.Message;
                TxtBForma.Text = "Transferencia";
                TxtCod_caja.Enabled = false;
                TxtCod_cuenta.Enabled = true;
                DataListado.DataSource = null;
            }
            FormaPago();
            MostraUsuario();
            MostrarListado();
        }

        private void OcultarColumnas()
        {
            foreach (DataGridViewRow Fila in DataListado.Rows)
            {
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



                if (DataListado.Rows.Count > 0)
                {
                    DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataListado.Columns["Pagar"].Visible = true;
                    DataListado.Columns["Anular"].Visible = false;
                    DataListado.Columns["cod_compra"].Visible = false;
                    DataListado.Columns["numdocpago"].Visible = true;
                    DataListado.Columns["optipo"].Visible = true;
                    DataListado.Columns["total"].Visible = true;
                    DataListado.Columns["abono"].Visible = true;
                    DataListado.Columns["saldo"].Visible = true;
                    DataListado.Columns["esreteniva"].Visible = true;
                    DataListado.Columns["esretenislr"].Visible = true;
                    DataListado.Columns["fecha_doc"].Visible = true;
                    DataListado.Columns["fecha_ven"].Visible = true;

                    DataListado.Columns["cod_compra"].HeaderText = "Codigo Doc.";
                    DataListado.Columns["numdocpago"].HeaderText = "Documento";
                    DataListado.Columns["optipo"].HeaderText = "Tipo Doc.";
                    DataListado.Columns["total"].HeaderText = "Total";
                    DataListado.Columns["abono"].HeaderText = "Abonado";
                    DataListado.Columns["saldo"].HeaderText = "Saldo";
                    DataListado.Columns["esreteniva"].HeaderText = "I.V.A.";
                    DataListado.Columns["esretenislr"].HeaderText = "I.S.L.R.";
                    DataListado.Columns["fecha_doc"].HeaderText = "Emision";
                    DataListado.Columns["fecha_ven"].HeaderText = "Venc.";

                    DataListado.Columns["cod_compra"].Width = 150;
                    DataListado.Columns["total"].Width = 150;
                    DataListado.Columns["abono"].Width = 150;
                    DataListado.Columns["saldo"].Width = 150;
                    DataListado.Columns["esreteniva"].Width = 50;
                    DataListado.Columns["esretenislr"].Width = 50;

                    DataListado.Columns["total"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListado.Columns["abono"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListado.Columns["saldo"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

                    DataListado.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["abono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["fecha_doc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DataListado.Columns["fecha_ven"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    LbInexistente.Visible = false;

                }
                else
                {
                    LbInexistente.Visible = true;
                }
            }
        }

        private void OcultarColumnasDetalle()
        {
            foreach (DataGridViewRow Fila in DataListado.Rows)
            {
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



                if (DataListado.Rows.Count > 0)
                {
                    DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataListado.Columns["Eliminar"].Visible = false;
                    DataListado.Columns["Anular"].Visible = false;
                    DataListado.Columns["cod_pago"].Visible = false;
                    DataListado.Columns["cod_compra"].Visible = true;
                    DataListado.Columns["optipo"].Visible = true;
                    DataListado.Columns["numdocumento"].Visible = true;
                    DataListado.Columns["numdocpago"].Visible = true;
                    DataListado.Columns["total"].Visible = true;
                    DataListado.Columns["abono"].Visible = true;
                    DataListado.Columns["saldo"].Visible = true;
                    DataListado.Columns["esreteniva"].Visible = true;
                    DataListado.Columns["esretenislr"].Visible = true;
                    DataListado.Columns["fecha_doc"].Visible = true;
                    DataListado.Columns["fecha_ven"].Visible = true;


                    DataListado.Columns["cod_compra"].HeaderText = "Codigo Doc.";
                    DataListado.Columns["numdocpago"].HeaderText = "Documento";
                    DataListado.Columns["optipo"].HeaderText = "Tipo Doc.";
                    DataListado.Columns["total"].HeaderText = "Total";
                    DataListado.Columns["abono"].HeaderText = "Abonado";
                    DataListado.Columns["saldo"].HeaderText = "Saldo";
                    DataListado.Columns["esreteniva"].HeaderText = "I.V.A.";
                    DataListado.Columns["esretenislr"].HeaderText = "I.S.L.R.";
                    DataListado.Columns["fecha_doc"].HeaderText = "Emision";
                    DataListado.Columns["fecha_ven"].HeaderText = "Venc.";

                    DataListado.Columns["cod_compra"].Width = 150;
                    DataListado.Columns["numdocpago"].Width = 150;
                    DataListado.Columns["optipo"].Width = 150;
                    DataListado.Columns["total"].Width = 150;
                    DataListado.Columns["abono"].Width = 150;
                    DataListado.Columns["saldo"].Width = 150;
                    DataListado.Columns["esreteniva"].Width = 50;
                    DataListado.Columns["esretenislr"].Width = 50;

                    DataListado.Columns["total"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListado.Columns["abono"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListado.Columns["saldo"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

                    DataListado.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["abono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListado.Columns["fecha_doc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DataListado.Columns["fecha_ven"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    LbInexistente.Visible = false;

                }
                else
                {
                    LbInexistente.Visible = true;
                }
            }
        }

        private void OcultarColumnasGen()
        {
            if (DataListadoGen.Rows.Count > 0)
            {
                foreach (DataGridViewRow Fila in DataListadoGen.Rows)
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

                    DataListadoGen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataListadoGen.Columns["cod_compra"].Visible = false;
                    DataListadoGen.Columns["cod_proveedor"].Visible = false;
                    DataListadoGen.Columns["desc_proveedor"].Visible = true;
                    DataListadoGen.Columns["rif"].Visible = true;
                    DataListadoGen.Columns["optipo"].Visible = true;
                    DataListadoGen.Columns["numdocumento"].Visible = true;
                    DataListadoGen.Columns["cod_pago"].Visible = true;
                    DataListadoGen.Columns["numdocpago"].Visible = true;
                    DataListadoGen.Columns["total"].Visible = true;
                    DataListadoGen.Columns["abono"].Visible = true;
                    DataListadoGen.Columns["saldo"].Visible = true;
                    DataListadoGen.Columns["esreteniva"].Visible = true;
                    DataListadoGen.Columns["esretenislr"].Visible = true;
                    DataListadoGen.Columns["fecha_doc"].Visible = true;
                    DataListadoGen.Columns["fecha_ven"].Visible = true;

                    DataListadoGen.Columns["desc_proveedor"].HeaderText = "Proveedor";
                    DataListadoGen.Columns["rif"].HeaderText = "RIF";
                    DataListadoGen.Columns["optipo"].HeaderText = "Tipo Doc.";
                    DataListadoGen.Columns["numdocumento"].HeaderText = "N° Doc.";
                    DataListadoGen.Columns["cod_pago"].HeaderText = "N° Pago";
                    DataListadoGen.Columns["numdocpago"].HeaderText = "N° Doc.Pago";
                    DataListadoGen.Columns["total"].HeaderText = "Total";
                    DataListadoGen.Columns["abono"].HeaderText = "Abonado";
                    DataListadoGen.Columns["saldo"].HeaderText = "Saldo";
                    DataListadoGen.Columns["saldo"].Clone();
                    DataListadoGen.Columns["esreteniva"].HeaderText = "I.V.A.";
                    DataListadoGen.Columns["esretenislr"].HeaderText = "I.S.L.R.";
                    DataListadoGen.Columns["fecha_doc"].HeaderText = "Emision";
                    DataListadoGen.Columns["fecha_ven"].HeaderText = "Venc.";

                    DataListadoGen.Columns["desc_proveedor"].Width = 250;
                    DataListadoGen.Columns["rif"].Width = 100;
                    DataListadoGen.Columns["optipo"].Width = 150;
                    DataListadoGen.Columns["numdocumento"].Width = 100;
                    DataListadoGen.Columns["numdocpago"].Width = 120;
                    DataListadoGen.Columns["total"].Width = 150;
                    DataListadoGen.Columns["abono"].Width = 150;
                    DataListadoGen.Columns["saldo"].Width = 150;
                    DataListadoGen.Columns["esreteniva"].Width = 50;
                    DataListadoGen.Columns["esretenislr"].Width = 50;

                    DataListadoGen.Columns["total"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListadoGen.Columns["abono"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
                    DataListadoGen.Columns["saldo"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

                    DataListadoGen.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListadoGen.Columns["abono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListadoGen.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataListadoGen.Columns["fecha_doc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DataListadoGen.Columns["fecha_ven"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    LbInexistenteGen.Visible = false;
                }
            }
            else
            {
                LbInexistenteGen.Visible = true;
            }
        }

        private void Mostrar()
        {
            DataListado.DataSource = EPago.MostrarSaldo(TxtCod_proveedor.Text);
            OcultarColumnas();
        }

        private void MostrarDetalle()
        {
            DataListado.DataSource = EPagoDetalle.Mostrar(TxtCod_pago.Text);
            OcultarColumnasDetalle();
        }

        private void MostrarListado()
        {
            DataListadoGen.DataSource = EPago.MostrarSaldoTodos();
            OcultarColumnasGen();

            decimal _SaldoGen = 0;
            decimal _AbonadoGen = 0;
            decimal _TotalGen = 0;

            foreach (DataGridViewRow Fila in DataListadoGen.Rows)
            {
                decimal TotalGen = Convert.ToDecimal(Fila.Cells["total"].Value);
                decimal AbonadoGen = Convert.ToDecimal(Fila.Cells["abono"].Value);
                decimal SaldoGen = Convert.ToDecimal(Fila.Cells["saldo"].Value);
                _SaldoGen += SaldoGen;
                _AbonadoGen += AbonadoGen;
                _TotalGen += TotalGen;
            }

            TxtAbono.Text = _AbonadoGen.ToString();
            TxtSaldoGen.Text = _SaldoGen.ToString();
            TxtTotalGen.Text = _TotalGen.ToString();
        }

        private void FormaPago()
        {
            TxtBForma.Items.AddRange(new object[] { "Transferencia", "Cheque", "Deposito", "Efectivo" });
        }

        internal void ListarCaja()
        {
            DataTable Dt = ECaja.Mostrar();

            for (int i = 0; i <= Convert.ToInt32(Dt.Rows.Count) - 1; i++)
            {
                TxtCod_caja.Items.Add(Dt.Rows[i]["cod_caja"].ToString());
            }
        }

        private void EventosTexBox()
        {
            if (TxtEsretenislr.Text == true.ToString())
            {
                ChkEsRetenISLR.Checked = true;
            }
            else
            {
                ChkEsRetenISLR.Checked = false;
            }

            if (TxtEsreteniva.Text == true.ToString())
            {
                ChkEsReteniva.Checked = true;
            }
            else
            {
                ChkEsReteniva.Checked = false;
            }
        }

        private void EventosCheckBox()
        {
            if (ChkEsRetenISLR.Checked == true)
            {
                TxtEsretenislr.Text = true.ToString();
            }
            else
            {
                TxtEsretenislr.Text = false.ToString();
            }

            if (ChkEsReteniva.Checked == true)
            {
                TxtEsreteniva.Text = true.ToString();
            }
            else
            {
                TxtEsreteniva.Text = false.ToString();
            }
        }

        private void FPago_Load(object sender, EventArgs e)
        {
            Text = "...::: Cuentas por Pagar :::...";
            Listar();
            //CbBtipo();
            CbBucar.Text = "Codigo";
        }

        #region CONTROL DE CAMBIOS
        private void TxtCod_pago_TextChanged(object sender, EventArgs e)
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

        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_pagov_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_compra_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumdocpago_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumcontrol_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_regpago_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
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

        private void TxtDoc_asociado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtAnulado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }
        #endregion

        #region BOTONES

        internal void Guardar()
        {
            try
            {
                DataSet DsEmpresa = EEmpresa.Listar();
                string Rpta = "";
                bool registrar = true;

                if (TxtCod_proveedor.Text == string.Empty || TxtNumdocpago.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_proveedor, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtNumdocpago, "Campo Obligatorio");
                    registrar = false;
                }
                if (Convert.ToBoolean(DsEmpresa.Tables[0].Rows[0]["fiscal"].ToString()).Equals(true))
                {
                    if (TxtEsreteniva.Text == false.ToString())
                    {
                        Opcion = MessageBox.Show("El Documento a Procesar no Posee Retencion de I.V.A. Aun Asi desea Continuar?", "...::: Step One Ver 5.1 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.Cancel)
                        {
                            registrar = false;
                        }
                    }
                }
                else if (registrar)
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        GenerarCod();
                        Rpta = EPago.Insertar(TxtCod_pago.Text.Trim(), TxtCod_proveedor.Text.Trim(), TxtDesc_pago.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), Convert.ToDecimal(TxtMonto.Text), Convert.ToDateTime(TxtFecha_regpago.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);

                        Rpta = EPagoDetalle.Insertar(TxtCod_pago.Text, TxtCod_cuenta.Text, TxtCod_caja.Text, TxtCod_islr.Text, TxtCod_compra.Text, TxtNumdocpago.Text, TxtSerialretiva.Text, TxtNumcheque.Text, TxtOptipo.Text, TxtBForma.Text, Convert.ToDecimal(TxtMonto.Text), Convert.ToBoolean(TxtEsretenislr.Text), Convert.ToBoolean(TxtEsreteniva.Text), Convert.ToDateTime(TxtFecha_regpago.Text), TxtCod_movbanco.Text, TxtCod_movcaja.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EPago.Editar(TxtCod_pago.Text.Trim(), TxtCod_pagov.Text.Trim(), TxtCod_proveedor.Text.Trim(), TxtDesc_pago.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), Convert.ToDecimal(TxtMonto.Text), Convert.ToDateTime(TxtFecha_regpago.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);

                        Rpta = EPagoDetalle.Editar(Convert.ToInt32(TxtReng.Text), TxtCod_pago.Text, TxtCod_cuenta.Text, TxtCod_caja.Text, TxtCod_islr.Text, TxtCod_compra.Text, TxtNumdocpago.Text, TxtSerialretiva.Text, TxtNumcheque.Text, TxtOptipo.Text, TxtBForma.Text, Convert.ToDecimal(TxtMonto.Text), Convert.ToBoolean(TxtEsretenislr.Text), Convert.ToBoolean(TxtEsreteniva.Text), Convert.ToDateTime(TxtFecha_regpago.Text), TxtCod_movbanco.Text, TxtCod_movcaja.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            Listar();
                        }
                        else if (TxtEditar.Text == "Editar")
                        {
                            MensajeOk("El Registro se Editó Correctamente");
                            TxtEditar.Text = "Listar";
                            Listar();
                        }
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        //public void GuardarDetalle()
        //{
        //    try
        //    {
        //        string Rpta = "";
        //        Int32 _rorigen;
        //        string _cod_pago, _cod_cuenta, _cod_caja, _cod_islr, _cod_compra, _numdocpago, _serialretiva, _numcheque, _optipo, _forma, _movbanco, _movcaja;
        //        bool _esretenislr, _esreteniva;
        //        decimal _monto;

        //        Rpta = EPagoDetalle.Insertar(TxtCod_pago.Text, TxtCod_cuenta.Text, TxtCod_caja.Text, TxtCod_islr.Text, TxtCod_compra.Text, TxtNumdocpago.Text, TxtSerialretiva.Text, TxtNumcheque.Text, TxtOptipo.Text, TxtBForma.Text, Convert.ToDecimal(TxtMonto.Text), Convert.ToBoolean(TxtEsretenislr.Text), Convert.ToBoolean(TxtEsreteniva.Text), Convert.ToDateTime(TxtFecha_regpago.Text), TxtCod_movbanco.Text, TxtCod_movcaja.Text);

        //        foreach (DataGridViewRow row in DataListado.Rows)
        //        {
        //            _cod_caja = Convert.ToString(row.Cells["cod_articulo"].Value);
        //            _cod_islr = Convert.ToString(row.Cells["cod_unidad"].Value);
        //            _cod_compra = Convert.ToString(row.Cells["cod_impuesto"].Value);
        //            _optipo = TxtOptipo.Text;
        //            _cantidad = Convert.ToDecimal(row.Cells["cantidad"].Value);
        //            _equivalencia = Convert.ToDecimal(row.Cells["equivalencia"].Value);
        //            _montound = Convert.ToDecimal(row.Cells["montound"].Value);
        //            _descuento = Convert.ToDecimal(row.Cells["descuento"].Value);
        //            _descuentop = Convert.ToDecimal(row.Cells["descuentop"].Value);
        //            _subtotalund = Convert.ToDecimal(row.Cells["subtotalund"].Value);
        //            _montoimp = Convert.ToDecimal(row.Cells["montoimp"].Value);
        //            _totalund = Convert.ToDecimal(row.Cells["totalund"].Value);
        //            _estatus = Convert.ToString(row.Cells["estatus"].Value);
        //            _rorigen = Convert.ToInt32(row.Cells["rorigen"].Value);

        //            Rpta = EPagoDetalle.Insertar(TxtCod_pago.Text, TxtCod_cuenta.Text, TxtCod_caja.Text, TxtCod_islr.Text, TxtCod_compra.Text, TxtNumdocpago.Text, TxtSerialretiva.Text, TxtNumcheque.Text, TxtOptipo.Text, TxtBForma.Text, Convert.ToDecimal(TxtMonto.Text), Convert.ToBoolean(TxtEsretenislr.Text), Convert.ToBoolean(TxtEsreteniva.Text), Convert.ToDateTime(TxtFecha_regpago.Text), TxtCod_movbanco.Text, TxtCod_movcaja.Text);
        //        }
        //    }
        //    catch (Exception Exc)
        //    {
        //        MensajeError(Exc.Message);
        //    }
        //}


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Nuevo";
            Limpiar();
            Botones();
            DataListado.DataSource = null;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            Botones();
            Registros();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Listar();
            Botones();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente desea Eliminar el Registro ?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string Rpta = "";
                if (Opcion == DialogResult.OK)
                {
                    Rpta = EPago.Eliminar(TxtCod_pago.Text);

                    if (Rpta.Equals("Y"))
                    {
                        MensajeOk("Registro Eliminado Correctamente!");
                        Botones();
                        Listar();
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
                else
                {
                    MensajeError("Cancelando la Eliminacon de Registros!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente desea Anular el Registro ?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string Rpta = "";
                if (Opcion == DialogResult.OK)
                {
                    Rpta = EPago.Anular(TxtCod_pago.Text, "", true, TxtCod_usuario.Text);

                    if (Rpta.Equals("Y"))
                    {
                        MensajeOk("Registro Anulado Correctamente!");
                        Botones();
                        Listar();
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
                else
                {
                    MensajeError("Cancelando la Anulacion de Registros!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnRetenIVA_Click(object sender, EventArgs e)
        {

        }

        private void BtnRetenISLR_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DsListar = EPago.Primero();

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["desc_pago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["Rif"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();

                TxtCod_caja.Text = DsListar.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = DsListar.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = DsListar.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = DsListar.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_islr.Text = DsListar.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtCod_compra.Text = DsListar.Tables[0].Rows[0]["cod_compra"].ToString();
                TxtNumdocpago.Text = DsListar.Tables[0].Rows[0]["numdocpago"].ToString();
                TxtSerialretiva.Text = DsListar.Tables[0].Rows[0]["serialretiva"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtBForma.Text = DsListar.Tables[0].Rows[0]["forma"].ToString();
                TxtMonto.Text = DsListar.Tables[0].Rows[0]["monto"].ToString();
                TxtEsreteniva.Text = DsListar.Tables[0].Rows[0]["esreteniva"].ToString();
                TxtEsretenislr.Text = DsListar.Tables[0].Rows[0]["esretenislr"].ToString();
                TxtSaldo.Text = string.Empty;
                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                DataSet DsListar = EPago.Anterior(TxtCod_pago.Text);

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["desc_pago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["Rif"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();

                TxtCod_caja.Text = DsListar.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = DsListar.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = DsListar.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = DsListar.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_islr.Text = DsListar.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtCod_compra.Text = DsListar.Tables[0].Rows[0]["cod_compra"].ToString();
                TxtNumdocpago.Text = DsListar.Tables[0].Rows[0]["numdocpago"].ToString();
                TxtSerialretiva.Text = DsListar.Tables[0].Rows[0]["serialretiva"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtBForma.Text = DsListar.Tables[0].Rows[0]["forma"].ToString();
                TxtMonto.Text = DsListar.Tables[0].Rows[0]["monto"].ToString();
                TxtEsreteniva.Text = DsListar.Tables[0].Rows[0]["esreteniva"].ToString();
                TxtEsretenislr.Text = DsListar.Tables[0].Rows[0]["esretenislr"].ToString();

                TxtSaldo.Text = string.Empty;
                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                DataSet DsListar = EPago.Siguiente(TxtCod_pago.Text);

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["desc_pago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["Rif"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();

                TxtCod_caja.Text = DsListar.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = DsListar.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = DsListar.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = DsListar.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_islr.Text = DsListar.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtCod_compra.Text = DsListar.Tables[0].Rows[0]["cod_compra"].ToString();
                TxtNumdocpago.Text = DsListar.Tables[0].Rows[0]["numdocpago"].ToString();
                TxtSerialretiva.Text = DsListar.Tables[0].Rows[0]["serialretiva"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtBForma.Text = DsListar.Tables[0].Rows[0]["forma"].ToString();
                TxtMonto.Text = DsListar.Tables[0].Rows[0]["monto"].ToString();
                TxtEsreteniva.Text = DsListar.Tables[0].Rows[0]["esreteniva"].ToString();
                TxtEsretenislr.Text = DsListar.Tables[0].Rows[0]["esretenislr"].ToString();

                TxtSaldo.Text = string.Empty;
                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                DataSet DsListar = EPago.Ultimo();

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["desc_pago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["Rif"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();

                TxtCod_caja.Text = DsListar.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = DsListar.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = DsListar.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = DsListar.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_islr.Text = DsListar.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtCod_compra.Text = DsListar.Tables[0].Rows[0]["cod_compra"].ToString();
                TxtNumdocpago.Text = DsListar.Tables[0].Rows[0]["numdocpago"].ToString();
                TxtSerialretiva.Text = DsListar.Tables[0].Rows[0]["serialretiva"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtBForma.Text = DsListar.Tables[0].Rows[0]["forma"].ToString();
                TxtMonto.Text = DsListar.Tables[0].Rows[0]["monto"].ToString();
                TxtEsreteniva.Text = DsListar.Tables[0].Rows[0]["esreteniva"].ToString();
                TxtEsretenislr.Text = DsListar.Tables[0].Rows[0]["esretenislr"].ToString();

                TxtSaldo.Text = string.Empty;
                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                    Guardar();
                }
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
                TxtNumcheque.Text = string.Empty;
                TxtCod_cuenta.Text = string.Empty;
                TxtDesc_cuenta.Text = string.Empty;
                TxtNumdocpago.Text = string.Empty;
                TxtNumcheque.Text = string.Empty;

                Total = Convert.ToDecimal(DataListado.CurrentRow.Cells["total"].Value);
                Abono = Convert.ToDecimal(DataListado.CurrentRow.Cells["abono"].Value);
                Saldo = Convert.ToDecimal(DataListado.CurrentRow.Cells["saldo"].Value);

                TxtMonto.Text = Convert.ToString(Saldo);
                TxtSaldo.Text = Convert.ToString(Total);
            }
        }

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

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            Mostrar();
            if (DataListado.Rows.Count == 0)
            {
                MensajeError("El Proveedor Seleccionado No posee Documentos Pendientes!");
            }
        }

        private void TxtCod_cuenta_DoubleClick(object sender, EventArgs e)
        {
            Saldocuenta = 0;
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
                Saldocuenta = 0;
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

        internal void SetCuenta(string cod_cuenta, string desc_cuenta, string cod_moneda, string saldo, string numcuenta)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            Moneda = cod_moneda;
            Saldocuenta = Convert.ToDecimal(saldo);
            TxtNumcuenta.Text = numcuenta;
        }

        #region CONTROL DE CAMBIOS
        private void TxtBForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtBForma.Text == "Transferencia" || TxtBForma.Text == "Cheque")
            {
                TxtCod_caja.Enabled = false;
                TxtCod_cuenta.Enabled = true;
                TxtCod_caja.Text = "";
                TxtDesc_caja.Text = "";
            }
            else if (TxtBForma.Text == "Deposito" || TxtBForma.Text == "Efectivo")
            {
                TxtCod_caja.Enabled = true;
                TxtCod_cuenta.Enabled = false;
                TxtCod_cuenta.Text = "";
                TxtDesc_cuenta.Text = "";

            }

        }

        private void ChkEsReteniva_CheckedChanged(object sender, EventArgs e)
        {
            EventosCheckBox();
        }

        private void ChkEsRetenISLR_CheckedChanged(object sender, EventArgs e)
        {
            EventosCheckBox();
        }

        private void TxtEsreteniva_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
        }

        private void TxtEsretenislr_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
        }

        private void TxtDesc_cuenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_caja_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void CbBucar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCod_caja_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt = ECaja.Mostrar();

            foreach (DataRow Row in Dt.Rows)
            {
                if (!String.IsNullOrWhiteSpace(TxtCod_caja.Text) || !String.IsNullOrEmpty(TxtCod_caja.Text))
                {
                    if (Convert.ToString(Row["cod_caja"]).Equals(TxtCod_caja.Text))
                    {
                        TxtDesc_caja.Text = Convert.ToString(Row["desc_caja"]);
                        Saldocaja = Convert.ToDecimal(Row["saldototal"]);
                        Moneda = Convert.ToString(Row["cod_moneda"]);

                        if ((Convert.ToDouble(Saldocaja) < TxtMonto.Value))
                        {
                            MensajeOk("La Caja No possee Saldo Disponible para realizar la Operacion. El Saldo negativo sera :" + (Convert.ToDouble(Saldocaja) - TxtMonto.Value).ToString() + " " + Moneda);
                        }

                    }
                }
            }
        }

        private void TxtCod_cuenta_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtMonto_ValueChanged(object sender, EventArgs e)
        {
            if (TxtSaldo.Value > 0)
            {
                TxtSaldo.Value = TxtSaldo.Value - TxtMonto.Value;
            }
            else if (TxtSaldo.Value < 0)
            {
                TxtSaldo.Value = TxtSaldo.Value + TxtMonto.Value;
            }
        }

        private void TxtSaldo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
