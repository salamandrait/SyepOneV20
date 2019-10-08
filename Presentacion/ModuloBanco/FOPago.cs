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
    public partial class FOPago : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FOPago _Instancia;

        public static FOPago GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FOPago();
            }
            return _Instancia;
        }

        public FOPago()
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
            Dt = EOPago.Mostrar();
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

        private void Habilitar(bool valor)
        {
            TxtCod_opago.Text = string.Empty;
            TxtCod_beneficiario.Text = string.Empty;
            TxtDesc_beneficiario.Text = string.Empty;
            TxtRif.Text = string.Empty;
            TxtCod_cuentasie.Text = string.Empty;
            TxtDesc_cuentasie.Text = string.Empty;
            TxtCod_caja.Text = string.Empty;
            TxtDesc_caja.Text = string.Empty;
            TxtCod_cuenta.Text = string.Empty;
            TxtDesc_cuenta.Text = string.Empty;
            TxtCod_moneda.Text = string.Empty;
            TxtDesc_moneda.Text = string.Empty;
            TxtDesc_opago.Text = string.Empty;
            TxtEstatus.Text = "Sin Procesar";
            TxtNumdocumento.Text = string.Empty;
            TxtForma.Text = "Efectivo";
            TxtAnulado.Text = false.ToString();
            TxtChequera.Text = false.ToString();
            TxtMontobase.Text = string.Empty;
            TxtMontoimp.Text = string.Empty;
            TxtDesc_impuesto.Text = "Tasa General";
            TxtTasaimp.Text = string.Empty;
            TxtMontototal.Text = string.Empty;
            TxtFecha_reg.Text = string.Empty;
            TxtFecha_pag.Text = string.Empty;
            TxtCampo1.Text = string.Empty;
            TxtCampo2.Text = string.Empty;
            TxtCampo3.Text = string.Empty;
            TxtCampo4.Text = string.Empty;
            TxtCampo5.Text = string.Empty;
            TxtCampo6.Text = string.Empty;
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
                BtnAnular.Enabled = false;

                BtnAnterior.Enabled = false;
                BtnPrimero.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnUltimo.Enabled = false;
                BtnAnular.Text = "Anular";
                BtnPagar.Enabled = false;
                BtnPagar.Text = "Pagar";
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;
                BtnAnular.Enabled = false;

                BtnAnterior.Enabled = false;
                BtnPrimero.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnUltimo.Enabled = false;
                BtnAnular.Text = "Anular";
                BtnPagar.Enabled = false;
                BtnPagar.Text = "Pagar";
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnImprimir.Enabled = true;
                BtnAnular.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnAnular.Text = "Anular";
                BtnPagar.Enabled = true;
                BtnPagar.Text = "Pagar";
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = true;
                BtnAnular.Enabled = false;
                BtnAnular.Text = "Anular";

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnPagar.Enabled = true;
                BtnPagar.Text = "Reversar";
                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Anulado")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;
                BtnAnular.Enabled = true;
                BtnAnular.Text = "Reactivar";

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnPagar.Enabled = false;
                BtnPagar.Text = "Pagar";
                Habilitar(false);
            }
        }

        private void PComboBox()
        {
            TxtForma.Items.AddRange(new object[] { "Efectivo", "Cheque", "Transferencia" });
        }

        private void EventoOptipo()
        {
            if (TxtForma.Text == "Efectivo")
            {
                TxtCod_caja.Enabled = true;
                TxtCod_cuenta.Enabled = false;

                DataTable DtCaja = ECaja.Mostrar();
                foreach(DataRow Row in DtCaja.Rows)
                {
                    if (TxtCod_caja.Text.Equals(Convert.ToString(Row["cod_caja"])))
                    {
                        TxtSaldoDisp.Text = (Convert.ToString(Row["saldoefectivo"]));
                    }
                }
                TxtNegativo.Value = TxtSaldoDisp.Value - TxtMontototal.Value;
            }
            else if (TxtForma.Text == "Cheque" || TxtForma.Text == "Transferencia")
            {
                TxtCod_caja.Enabled = false;
                TxtCod_cuenta.Enabled = true;

                DataTable DtCta = ECuenta.Mostrar();
                foreach (DataRow Row in DtCta.Rows)
                {
                    if (TxtCod_cuenta.Text.Equals(Convert.ToString(Row["cod_cuenta"])))
                    {
                        TxtSaldoDisp.Text = (Convert.ToString(Row["saldo"]));
                    }
                }
            }
            TxtNegativo.Value = TxtSaldoDisp.Value - TxtMontototal.Value;
        }

        private void Limpiar()
        {
            if (ChkCopiar.Checked == true)
            {
                TxtCod_opago.Text = String.Empty;
                ChkCopiar.Checked = false;
            }
            else
            {
                TxtCod_opago.Text = string.Empty;
                TxtCod_beneficiario.Text = string.Empty;
                TxtDesc_beneficiario.Text = string.Empty;
                TxtRif.Text = string.Empty;
                TxtCod_cuentasie.Text = string.Empty;
                TxtDesc_cuentasie.Text = string.Empty;
                TxtCod_caja.Text = string.Empty;
                TxtDesc_caja.Text = string.Empty;
                TxtCod_cuenta.Text = string.Empty;
                TxtDesc_cuenta.Text = string.Empty;
                TxtCod_moneda.Text = string.Empty;
                TxtDesc_moneda.Text = string.Empty;
                TxtDesc_opago.Text = string.Empty;
                TxtEstatus.Text = "Sin Procesar";
                TxtNumdocumento.Text = string.Empty;
                TxtForma.Text = "Efectivo";
                TxtAnulado.Text = false.ToString();
                TxtChequera.Text = false.ToString();
                TxtMontobase.Text = string.Empty;
                TxtMontoimp.Text = string.Empty;
                TxtDesc_impuesto.Text = "Tasa General";
                TxtTasaimp.Text = string.Empty;
                TxtMontototal.Text = string.Empty;
                TxtFecha_reg.Text = string.Empty;
                TxtFecha_pag.Text = string.Empty;
                TxtCampo1.Text = string.Empty;
                TxtCampo2.Text = string.Empty;
                TxtCampo3.Text = string.Empty;
                TxtCampo4.Text = string.Empty;
                TxtCampo5.Text = string.Empty;
                TxtCampo6.Text = string.Empty;
                //TxtCod_usuario.Text = string.Empty;
                TxtCod_movcaja.Text = string.Empty;
                TxtCod_movbanco.Text = string.Empty;
            }
            Top_serie();
        }

        private void CambiosTexBox()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
            }
            ErrorTexto.Dispose();
        }

        public void Listar()
        {
            try
            {
                Ds = EOPago.Listar();

                TxtCod_opago.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_opagov.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_opago.Text = Ds.Tables[0].Rows[0]["desc_opago"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtNumdocumento.Text = Ds.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtMontobase.Text = Ds.Tables[0].Rows[0]["montobase"].ToString();
                TxtMontoimp.Text = Ds.Tables[0].Rows[0]["montoimp"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();
                TxtTasaimp.Text = Ds.Tables[0].Rows[0]["tasaimp"].ToString();
                TxtMontototal.Text = Ds.Tables[0].Rows[0]["montototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_pag.Text = Ds.Tables[0].Rows[0]["fecha_pag"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Ex)
            {
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_opago.Focus();
                string rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                Show();
            }
        }

        private void Guardar()
        {
            //try
            //{
            //    string Rpta = "";

            //    if (TxtCod_opago.Text == string.Empty || TxtDesc_opago.Text == string.Empty || TxtComision.Text == string.Empty || TxtRecargo.Text == string.Empty || TxtComision.Text == string.Empty)
            //    {
            //        MensajeError("Falta ingresar algunos datos");
            //        ErrorTexto.SetError(TxtCod_opago, "Campo Obligatorio");
            //        ErrorTexto.SetError(TxtDesc_opago, "Campo Obligatorio");
            //    }
            //    else
            //    {
            //        if (TxtEditar.Text == "Nuevo")
            //        {
            //            Rpta = EOPago.Insertar(TxtCod_opago.Text.Trim().ToUpper(), TxtDesc_opago.Text.Trim(), Convert.ToDecimal(TxtComision.Text), Convert.ToDecimal(TxtRecargo.Text), Convert.ToDecimal(TxtImpuesto.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
            //        }
            //        else if (TxtEditar.Text == "Editar")
            //        {
            //            Rpta = EOPago.Editar(TxtCod_opago.Text.Trim().ToUpper(), TxtCod_opagov.Text.Trim().ToUpper(), TxtDesc_opago.Text.Trim(), Convert.ToDecimal(TxtComision.Text), Convert.ToDecimal(TxtRecargo.Text), Convert.ToDecimal(TxtImpuesto.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
            //        }

            //        if (Rpta.Equals("Y"))
            //        {
            //            if (TxtEditar.Text == "Nuevo")
            //            {
            //                MensajeOk("El Registro se Insertó Correctamente");
            //                TxtEditar.Text = "Listar";
            //                TxtCod_opagov.Text = TxtCod_opago.Text;
            //            }
            //            else if (TxtEditar.Text == "Editar")
            //            {
            //                MensajeOk("El Registro se Editó Correctamente");
            //                TxtEditar.Text = "Listar";
            //            }
            //        }
            //        else
            //        {
            //            MensajeError(Rpta);
            //        }
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MensajeError(Ex.Message);
            //}
        }

        private void GenerarCod()
        {
            try
            {
                int rpta = Convert.ToInt32(EOPago.GenerarCod(TxtCod_opago.Text));
                TxtCod_opago.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_opago.Focus();
            }
        }

        private void FOPago_Load(object sender, EventArgs e)
        {
            Text = "...::: Orden de Pago :::...";
            MostraUsuario();
            Listar();
            PComboBox();
        }

        private void FOPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FOPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo" && (TxtCod_opago.Text != string.Empty || TxtDesc_opago.Text != string.Empty || TxtComision.Text != string.Empty || TxtRecargo.Text != string.Empty || TxtComision.Text != string.Empty))
            //{
            //    Opcion = MessageBox.Show("Desea Guardar el Registro antes de Salir? ", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    if (Opcion == DialogResult.OK)
            //    {
            //        Guardar();
            //    }
            //}
        }

        #region PROCESOS PRINCIPALES
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
            TxtCod_opago.Focus();
            Botones();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Opcion = MessageBox.Show("Realmente desea Eliminar el Registro ?", "...::: Step One Ver 5.1:::...",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                string Rpta = "";

                if (Opcion == DialogResult.OK)
                {
                    Rpta = EOPago.Eliminar(TxtCod_opago.Text);

                    if (Rpta.Equals("Y"))
                    {
                        Botones();
                        MensajeOk("Registro Eliminado Correctamente!");
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
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FOPagoLista Listado = new FOPagoLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptOPago Reporte = new FRptOPago();
            //Reporte.ShowDialog();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCod();
        }

        #endregion

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EOPago.Primero();

                TxtCod_opago.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_opagov.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_opago.Text = Ds.Tables[0].Rows[0]["desc_opago"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtNumdocumento.Text = Ds.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtMontobase.Text = Ds.Tables[0].Rows[0]["montobase"].ToString();
                TxtMontoimp.Text = Ds.Tables[0].Rows[0]["montoimp"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();
                TxtTasaimp.Text = Ds.Tables[0].Rows[0]["tasaimp"].ToString();
                TxtMontototal.Text = Ds.Tables[0].Rows[0]["montototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_pag.Text = Ds.Tables[0].Rows[0]["fecha_pag"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EOPago.Anterior(TxtCod_opago.Text);

                TxtCod_opago.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_opagov.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_opago.Text = Ds.Tables[0].Rows[0]["desc_opago"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtNumdocumento.Text = Ds.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtMontobase.Text = Ds.Tables[0].Rows[0]["montobase"].ToString();
                TxtMontoimp.Text = Ds.Tables[0].Rows[0]["montoimp"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();
                TxtTasaimp.Text = Ds.Tables[0].Rows[0]["tasaimp"].ToString();
                TxtMontototal.Text = Ds.Tables[0].Rows[0]["montototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_pag.Text = Ds.Tables[0].Rows[0]["fecha_pag"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EOPago.Siguiente(TxtCod_opago.Text);

                TxtCod_opago.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_opagov.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_opago.Text = Ds.Tables[0].Rows[0]["desc_opago"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtNumdocumento.Text = Ds.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtMontobase.Text = Ds.Tables[0].Rows[0]["montobase"].ToString();
                TxtMontoimp.Text = Ds.Tables[0].Rows[0]["montoimp"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();
                TxtTasaimp.Text = Ds.Tables[0].Rows[0]["tasaimp"].ToString();
                TxtMontototal.Text = Ds.Tables[0].Rows[0]["montototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_pag.Text = Ds.Tables[0].Rows[0]["fecha_pag"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EOPago.Ultimo();

                TxtCod_opago.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_opagov.Text = Ds.Tables[0].Rows[0]["cod_opago"].ToString();
                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_opago.Text = Ds.Tables[0].Rows[0]["desc_opago"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtNumdocumento.Text = Ds.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtMontobase.Text = Ds.Tables[0].Rows[0]["montobase"].ToString();
                TxtMontoimp.Text = Ds.Tables[0].Rows[0]["montoimp"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();
                TxtTasaimp.Text = Ds.Tables[0].Rows[0]["tasaimp"].ToString();
                TxtMontototal.Text = Ds.Tables[0].Rows[0]["montototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_pag.Text = Ds.Tables[0].Rows[0]["fecha_pag"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtCod_opago_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_opago_TextChanged(object sender, EventArgs e)
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

        private void TxtCampo5_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo4_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCampo6_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }


        private void TxtComision_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtRecargo_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtImpuesto_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }
        #endregion

        #region LLAMAR REGISTROS
        internal void SetOPago(string cod_opago, string desc_opago, string recargo, string impuesto, string comision, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            //TxtCod_opago.Text = cod_opago;
            //TxtCod_opagov.Text = cod_opago;
            //TxtDesc_opago.Text = desc_opago;
            //TxtRecargo.Text = recargo;
            //TxtImpuesto.Text = impuesto;
            //TxtComision.Text = comision;
            //TxtCampo1.Text = campo1;
            //TxtCampo2.Text = campo2;
            //TxtCampo3.Text = campo3;
            //TxtCampo4.Text = campo4;
            //TxtCampo5.Text = campo5;
            //TxtCampo6.Text = campo6;
        }

        public void SetBeneficiario(string cod_beneficiario, string desc_beneficiario, string rif)
        {
            TxtCod_beneficiario.Text = cod_beneficiario;
            TxtDesc_beneficiario.Text = desc_beneficiario;
            TxtRif.Text = rif;
        }

        public void SetCaja(string cod_caja, string desc_caja, string cod_moneda, string desc_moneda)
        {
            TxtCod_caja.Text = cod_caja;
            TxtDesc_caja.Text = desc_caja;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;

            TxtCod_cuenta.Text = string.Empty;
            TxtDesc_cuenta.Text = string.Empty;
            TxtCod_banco.Text = string.Empty;
            TxtDesc_banco.Text = string.Empty;
            TxtChequera.Text = false.ToString();

            EventoOptipo();
        }

        public void SetCuenta(string cod_cuenta, string desc_cuenta, string chequera, string cod_banco, string desc_banco, string cod_moneda, string desc_moneda)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtChequera.Text = chequera;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;

            TxtCod_caja.Text = string.Empty;
            TxtDesc_caja.Text = string.Empty;

            EventoOptipo();

        }

        private void ChequeraOp()
        {

            //FChequeraLista Listado = new FChequeraLista();

            //if (TxtChequera.Text==true.ToString())
            //{
            //    DataTable DtCh = EChequera.MostrarCta(TxtCod_cuenta.Text);
            //    foreach (DataRow Fila in DtCh.Rows)
            //    {
            //        if (Fila["estatus"].ToString() == "Activa")
            //        {
            //            FChequeraSelec ListadoCh = new FChequeraSelec();
            //            ListadoCh.ShowDialog();
            //        }
            //    }
            //}

        }

        public void SetCuentasie(string cod_cuentasie, string desc_cuentasie)
        {
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
        }

        private void TxtCod_beneficiario_DoubleClick(object sender, EventArgs e)
        {
            FBeneficiarioLista Listado = new FBeneficiarioLista
            {
                TxtFlag = "OPago"
            };
            Dt = EBeneficiario.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_beneficiario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FBeneficiarioLista Listado = new FBeneficiarioLista
                {
                    TxtFlag = "OPago"
                };
                Dt = EBeneficiario.Mostrar();
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

        private void TxtCod_cuentasie_DoubleClick(object sender, EventArgs e)
        {
            FCuentasIELista Listado = new FCuentasIELista
            {
                TxtFlag = "OPago"
            };
            Dt = ECuentasIE.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_cuentasie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FCuentasIELista Listado = new FCuentasIELista
                {
                    TxtFlag = "OPago"
                };
                Dt = ECuentasIE.Mostrar();
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

        private void TxtCod_cuenta_DoubleClick(object sender, EventArgs e)
        {
            FCuentaLista Listado = new FCuentaLista
            {
                TxtFlag = "OPago"
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
                    TxtFlag = "OPago"
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

        private void TxtCod_caja_DoubleClick(object sender, EventArgs e)
        {
            FCajaLista Listado = new FCajaLista
            {
                TxtFlag = "OPago"
            };
            Dt = ECaja.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_caja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FCajaLista Listado = new FCajaLista
                {
                    TxtFlag = "OPago"
                };
                Dt = ECaja.Mostrar();
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

        private void TxtForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventoOptipo();
        }

        private void TxtForma_VisibleChanged(object sender, EventArgs e)
        {
            EventoOptipo();
        }
    }
}
