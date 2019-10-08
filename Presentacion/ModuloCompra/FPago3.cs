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
    public partial class FPago : Form
    {
        string Pref = "";
        DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();
        DialogResult Opcion;
        public Decimal MontoPagado = 0;
        public DataTable DtDetalle = new DataTable();
        public DataTable DtProceso = new DataTable();

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
            TxtAnulado.Text = false.ToString();
            TxtTotal.Text = String.Empty;
            TxtCampo1.Text = String.Empty;
            TxtCampo2.Text = String.Empty;
            TxtCampo3.Text = String.Empty;
            TxtCampo4.Text = String.Empty;
            TxtCampo5.Text = String.Empty;
            TxtCampo6.Text = String.Empty;
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
            TxtTotal.Enabled = Valor;
            TxtCampo1.Enabled = Valor;
            TxtCampo2.Enabled = Valor;
            TxtCampo3.Enabled = Valor;
            TxtCampo4.Enabled = Valor;
            TxtCampo5.Enabled = Valor;
            TxtCampo6.Enabled = Valor;
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

                BtnAnular.Enabled = false;
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

                BtnAnular.Enabled = false;
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

                BtnAnular.Enabled = true;
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

                BtnAnular.Enabled = false;
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

                BtnAnular.Enabled = false;
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

                BtnAnular.Enabled = false;
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

                BtnAnular.Enabled = false;
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

                BtnAnular.Enabled = false;
                Habilitar(false);
            }
        }

        private void CbBtipo()
        {
            CbBucar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Rif" });
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

        private void Listar()
        {
            try
            {
                DataSet DsListar = EPago.Listar();

                TxtCod_pago.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_pagov.Text = DsListar.Tables[0].Rows[0]["cod_pago"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtDesc_pago.Text = DsListar.Tables[0].Rows[0]["desc_pago"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtTotal.Text = DsListar.Tables[0].Rows[0]["total"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = DsListar.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalles();
                MostrarDetallesP();
            }
            catch (Exception Exc)
            {
                CrearTabla();
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                TxtEditar.Text = "Nuevo";
                Limpiar();
                Botones();
                string rpta = Exc.Message;
                DataListado.DataSource = null;
                DataProcesar.DataSource = null;
            }
            MostraUsuario();
            Registros();
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
            Text = "....:::: Cuentas por Pagar ::::....";
            Listar();
            CbBtipo();
            CbBucar.Text = "Codigo";
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

                    DataListado.Columns["proceso"].Visible = true;
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

        private void MostrarDetallesP()
        {
            DataListado.DataSource = EPagoDetalle.MostrarP(TxtCod_pago.Text);
            OcultarColumnas();
        }

        private void OcultarColumnasDet()
        {

            DataProcesar.Columns["reng"].Visible = false;
            DataProcesar.Columns["cod_pago"].Visible = false;
            DataProcesar.Columns["cod_compra"].Visible = false;
            DataProcesar.Columns["cod_cuenta"].Visible = false;
            DataProcesar.Columns["cod_caja"].Visible = false;
            DataProcesar.Columns["numdocumento"].Visible = true;
            DataProcesar.Columns["optipo"].Visible = false;
            DataProcesar.Columns["numdocpago"].Visible = true;
            DataProcesar.Columns["forma"].Visible = true;
            DataProcesar.Columns["cod_movbanco"].Visible = true;
            DataProcesar.Columns["desc_cuenta"].Visible = true;
            DataProcesar.Columns["cod_movcaja"].Visible = true;
            DataProcesar.Columns["desc_caja"].Visible = true;
            DataProcesar.Columns["monto"].Visible = true;
            DataProcesar.Columns["esretenislr"].Visible = false;
            DataProcesar.Columns["esreteniva"].Visible = false;
            DataProcesar.Columns["fecha_reg"].Visible = false;

            DataProcesar.Columns["numdocumento"].HeaderText = "N° Compra";
            DataProcesar.Columns["numdocpago"].HeaderText = "N° Pago";
            DataProcesar.Columns["forma"].HeaderText = "Forma";
            DataProcesar.Columns["cod_movbanco"].HeaderText = "Mov Banco";
            DataProcesar.Columns["cod_movcaja"].HeaderText = "Mov. Caja";
            DataProcesar.Columns["monto"].HeaderText = "Abono";
            DataProcesar.Columns["desc_cuenta"].HeaderText = "Cuenta";
            DataProcesar.Columns["desc_caja"].HeaderText = "Caja";

            DataProcesar.Columns["desc_cuenta"].Width = 150;
            DataProcesar.Columns["desc_caja"].Width = 150;
            DataProcesar.Columns["forma"].Width = 100;
            DataProcesar.Columns["numdocumento"].Width = 100;
            DataProcesar.Columns["numdocpago"].Width = 120;
            DataProcesar.Columns["monto"].Width = 150;

            DataProcesar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataProcesar.Columns["monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataProcesar.Columns["monto"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

        }

        private void MostrarDetalles()
        {
            try
            {
                DataProcesar.DataSource = EPagoDetalle.Mostrar(TxtCod_pago.Text);
                OcultarColumnasDet();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        #region PROCESOS

        private void MostrarDocProveedor()
        {
            DataTable DtLista = EPago.MostrarProv(TxtCod_proveedor.Text);
            foreach (DataRow Row in DtLista.Rows)
            {
                if (Convert.ToDecimal(Row["total"]) != 0)
                {
                    DtDetalle = new DataTable("DtCCompraDetalle");
                    DtDetalle.Columns.Add("proceso", Type.GetType("System.DateTime"));
                    DtDetalle.Columns.Add("cod_compra", Type.GetType("System.Int32"));
                    DtDetalle.Columns.Add("numdocumento", Type.GetType("System.Int32"));
                    DtDetalle.Columns.Add("optipo", Type.GetType("System.Int32"));
                    DtDetalle.Columns.Add("total", Type.GetType("System.Decimal"));
                    DtDetalle.Columns.Add("monto", Type.GetType("System.Decimal"));
                    DtDetalle.Columns.Add("saldo", Type.GetType("System.Decimal"));
                    DtDetalle.Columns.Add("esretenislr", Type.GetType("System.Boolean"));
                    DtDetalle.Columns.Add("esreteniva", Type.GetType("System.Boolean"));
                    DtDetalle.Columns.Add("fecha_doc", Type.GetType("System.DateTime"));
                    DtDetalle.Columns.Add("fecha_ven", Type.GetType("System.DateTime"));
                    DataListado.DataSource = DtDetalle;


                    DataListado.DataSource = EPago.MostrarProv(TxtCod_proveedor.Text);
                    OcultarColumnas();
                }
            }
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            MostrarDocProveedor();

            if (DataListado.Rows.Count == 0)
            {
                MensajeError("El Proveedor Seleccionado No posee Documentos Pendientes!");
            }
        }

        internal void Guardar()
        {
            try
            {
                string Rpta = "";
                bool registrar = true;

                if (TxtCod_proveedor.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_proveedor, "Campo Obligatorio");
                    registrar = false;
                }
                else if (registrar)
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        GenerarCod();
                        Rpta = EPago.Insertar(TxtCod_pago.Text.Trim(), TxtCod_proveedor.Text.Trim(), TxtDesc_pago.Text, Convert.ToBoolean(TxtAnulado.Text), TxtEstatus.Text, Convert.ToDecimal(TxtTotal.Text), Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        GuardarDetalle();
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EPago.Editar(TxtCod_pago.Text.Trim(), TxtCod_pagov.Text.Trim(), TxtCod_proveedor.Text.Trim(), TxtDesc_pago.Text, Convert.ToBoolean(TxtAnulado.Text), TxtEstatus.Text, Convert.ToDecimal(TxtTotal.Text), Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Nuevo";
            Limpiar();
            Botones();
            DataListado.DataSource = null;
            DataProcesar.DataSource = null;
            CrearTabla();
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

                    foreach (DataGridViewRow Row in DataProcesar.Rows)
                    {
                        Rpta = EPagoDetalle.Eliminar(
                            Convert.ToString(Row.Cells["cod_pago"].Value),
                            Convert.ToString(Row.Cells["cod_compra"].Value),
                            Convert.ToString(Row.Cells["optipo"].Value),
                            Convert.ToDecimal(Row.Cells["monto"].Value)
                            );
                    }


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
                TxtEstatus.Text = "Anulado";
                TxtAnulado.Text = true.ToString();
                if (Opcion == DialogResult.OK)
                {
                    Rpta = EPago.Anular
                        (TxtCod_pago.Text,
                        Convert.ToBoolean(TxtAnulado.Text),
                        TxtEstatus.Text,
                        TxtCod_usuario.Text);

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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            MensajeOk(MontoPagado.ToString());
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MensajeOk(MontoPagado.ToString());
        }
        #endregion

        #region LLAMAR REGISTROS
        internal void SetProveedor(string cod_proveedor, string desc_proveedor, string rif)
        {
            TxtCod_proveedor.Text = cod_proveedor;
            TxtDesc_proveedor.Text = desc_proveedor;
            TxtRif.Text = rif;
        }

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

        private void TxtCod_proveedor_DoubleClick(object sender, EventArgs e)
        {
            DataListado.DataSource = null;
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
        }

        private void TxtCod_proveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                DataListado.DataSource = null;
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
            }
        }
        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
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
                TxtTotal.Text = Ds.Tables[0].Rows[0]["Total"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalles();
                MostrarDetallesP();
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
                TxtTotal.Text = Ds.Tables[0].Rows[0]["Total"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalles();
                MostrarDetallesP();
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
                TxtTotal.Text = Ds.Tables[0].Rows[0]["Total"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalles();
                MostrarDetallesP();
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
                TxtTotal.Text = Ds.Tables[0].Rows[0]["Total"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["Cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalles();
                MostrarDetallesP();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }



        #endregion

        private void DataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TxtCod_proveedor.Text != String.Empty && TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                string cod_compra, numdocumento, optipo;
                decimal monto;

                FPagoDetalle mForm = FPagoDetalle.GetForm();
                mForm.Editar = TxtEditar.Text;
                mForm.Limpiar();
                String _Optipo = "";
                #region TIPO DOCUMENTO
                if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Factura"))
                {
                    _Optipo = "FCompra";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Pedido"))
                {
                    _Optipo = "PCompra";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Doc. de Compra"))
                {
                    _Optipo = "DCompra";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Retencion de IVA"))
                {
                    _Optipo = "RETIVA";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Retencion de ISLR"))
                {
                    _Optipo = "RETISLR";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Nota de Debito"))
                {
                    _Optipo = "ND";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Nota de Credito"))
                {
                    _Optipo = "NC";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Ajuste Negativo"))
                {
                    _Optipo = "AJNC";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Ajuste Positivo"))
                {
                    _Optipo = "AJPC";
                }
                else if (DataListado.CurrentRow.Cells["optipo"].Value.Equals("Adelanto de Pago"))
                {
                    _Optipo = "ADP";
                }
                #endregion
                cod_compra = Convert.ToString(DataListado.CurrentRow.Cells["cod_compra"].Value);
                optipo = _Optipo;
                numdocumento = Convert.ToString(DataListado.CurrentRow.Cells["numdocumento"].Value);
                monto = Convert.ToDecimal(DataListado.CurrentRow.Cells["saldo"].Value);
                mForm.SetPagoDetalle(cod_compra, optipo, numdocumento, monto);
                mForm.ShowDialog();
            }
        }

        private void OcultarColumnasPcr()
        {
            DataProcesar.Columns["reng"].Visible = false;
            DataProcesar.Columns["cod_pago"].Visible = false;
            DataProcesar.Columns["cod_compra"].Visible = false;
            DataProcesar.Columns["numdocumento"].Visible = true;
            DataProcesar.Columns["optipo"].Visible = false;
            DataProcesar.Columns["numdocpago"].Visible = true;
            DataProcesar.Columns["forma"].Visible = true;
            DataProcesar.Columns["cod_movbanco"].Visible = true;
            DataProcesar.Columns["desc_cuenta"].Visible = true;
            DataProcesar.Columns["cod_movcaja"].Visible = true;
            DataProcesar.Columns["desc_caja"].Visible = true;
            DataProcesar.Columns["monto"].Visible = true;
            DataProcesar.Columns["esretenislr"].Visible = false;
            DataProcesar.Columns["esreteniva"].Visible = false;
            DataProcesar.Columns["fecha_reg"].Visible = false;

            DataProcesar.Columns["numdocumento"].HeaderText = "N° Compra";
            DataProcesar.Columns["numdocpago"].HeaderText = "N° Pago";
            DataProcesar.Columns["forma"].HeaderText = "Forma";
            DataProcesar.Columns["cod_movbanco"].HeaderText = "Mov Banco";
            DataProcesar.Columns["cod_movcaja"].HeaderText = "Mov. Caja";
            DataProcesar.Columns["monto"].HeaderText = "Abono";
            DataProcesar.Columns["desc_cuenta"].HeaderText = "Cuenta";
            DataProcesar.Columns["desc_caja"].HeaderText = "Caja";

            DataProcesar.Columns["desc_cuenta"].Width = 150;
            DataProcesar.Columns["desc_caja"].Width = 150;
            DataProcesar.Columns["forma"].Width = 100;
            DataProcesar.Columns["numdocumento"].Width = 100;
            DataProcesar.Columns["numdocpago"].Width = 120;
            DataProcesar.Columns["monto"].Width = 150;

            DataProcesar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataProcesar.Columns["monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataProcesar.Columns["monto"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
        }

        internal void CrearTabla()
        {
            DtProceso = new DataTable("DtCCompraDetalle");
            DtProceso.Columns.Add("reng", Type.GetType("System.Int32"));
            DtProceso.Columns.Add("cod_pago", Type.GetType("System.String"));
            DtProceso.Columns.Add("cod_compra", Type.GetType("System.String"));
            DtProceso.Columns.Add("numdocumento", Type.GetType("System.String"));
            DtProceso.Columns.Add("optipo", Type.GetType("System.String"));
            DtProceso.Columns.Add("numdocpago", Type.GetType("System.String"));
            DtProceso.Columns.Add("forma", Type.GetType("System.String"));
            DtProceso.Columns.Add("cod_movbanco", Type.GetType("System.String"));
            DtProceso.Columns.Add("desc_cuenta", Type.GetType("System.String"));
            DtProceso.Columns.Add("cod_movcaja", Type.GetType("System.String"));
            DtProceso.Columns.Add("desc_caja", Type.GetType("System.String"));
            DtProceso.Columns.Add("monto", Type.GetType("System.Decimal"));
            DtProceso.Columns.Add("esretenislr", Type.GetType("System.Boolean"));
            DtProceso.Columns.Add("esreteniva", Type.GetType("System.Boolean"));
            DtProceso.Columns.Add("fecha_reg", Type.GetType("System.DateTime"));
            DataProcesar.DataSource = DtProceso;
            OcultarColumnasPcr();

        }

        public void AgregarColumnas(string reng, string cod_compra, string numdocumento, string optipo, string numdocpago, string forma, string cod_movbanco, string desc_cuenta, string cod_movcaja, string desc_caja, string monto, string esretenislr, string esreteniva, string fecha_reg)
        {
            try
            {
                DataRow Fila;
                Fila = DtProceso.NewRow();
                Fila["reng"] = Convert.ToInt32(reng);
                Fila["cod_pago"] = TxtCod_pago.Text;
                Fila["cod_compra"] = cod_compra;
                Fila["numdocumento"] = numdocumento;
                Fila["optipo"] = optipo;
                Fila["numdocpago"] = numdocpago;
                Fila["forma"] = forma;
                Fila["cod_movbanco"] = cod_movbanco;
                Fila["desc_cuenta"] = desc_cuenta;
                Fila["cod_movcaja"] = cod_movcaja;
                Fila["desc_caja"] = desc_caja;
                Fila["monto"] = Convert.ToDecimal(monto);     
                Fila["esretenislr"] = Convert.ToBoolean(esretenislr);
                Fila["esreteniva"] = Convert.ToBoolean(esreteniva);
                Fila["fecha_reg"] = Convert.ToDateTime(fecha_reg);
                DtProceso.Rows.Add(Fila);
                DataProcesar.DataSource = DtProceso;


            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        internal void CalcularDetalle()
        {
            

            foreach (DataGridViewRow Fila in DataProcesar.Rows)
            {
                decimal Monto = Convert.ToDecimal(Fila.Cells["monto"].Value);

                   MontoPagado += Monto;
            }

            TxtTotal.Text = MontoPagado.ToString();
        }

        public void GuardarDetalle()
        {
            try
            {

                string Rpta = "";
                string _cod_pago, _cod_compra, _numdocpago, _optipo, _forma, _cod_movbanco, _cod_movcaja;
                decimal _monto;
                bool _esretenislr, _esreteniva;
                DateTime _fecha_reg;

                foreach (DataGridViewRow row in DataProcesar.Rows)
                {
                    _cod_pago = TxtCod_pago.Text;
                    _cod_compra = Convert.ToString(row.Cells["cod_compra"].Value);
                    _numdocpago = Convert.ToString(row.Cells["numdocpago"].Value);
                    _optipo = Convert.ToString(row.Cells["optipo"].Value);
                    _forma = Convert.ToString(row.Cells["forma"].Value);
                    _monto = Convert.ToDecimal(row.Cells["monto"].Value);
                    _esretenislr = Convert.ToBoolean(row.Cells["esretenislr"].Value);
                    _esreteniva = Convert.ToBoolean(row.Cells["esreteniva"].Value);
                    _fecha_reg = Convert.ToDateTime(row.Cells["fecha_reg"].Value);
                    _cod_movbanco = Convert.ToString(row.Cells["cod_movbanco"].Value);
                    _cod_movcaja = Convert.ToString(row.Cells["cod_movcaja"].Value);
                    Rpta = EPagoDetalle.Insertar(_cod_pago, _cod_compra, _numdocpago, _optipo, _forma, _monto, _esretenislr, _esreteniva, _fecha_reg, _cod_movbanco, _cod_movcaja);
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }

        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
