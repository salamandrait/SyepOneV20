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
    public partial class FMovBanco : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FMovBanco _Instancia;

        public static FMovBanco GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FMovBanco();
            }
            return _Instancia;
        }

        public FMovBanco()
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
            Dt = EMovBanco.Mostrar();
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
            if (ChkCopiar.Checked == true)
            {
                TxtCod_movbanco.Text = String.Empty;
            }
            else
            {
                TxtCod_movbanco.Text = string.Empty;
                TxtDesc_movbanco.Text = string.Empty;
                TxtCod_cuenta.Text = string.Empty;
                TxtDesc_cuenta.Text = string.Empty;
                TxtNumcuenta.Text = string.Empty;
                TxtCod_banco.Text = string.Empty;
                TxtDesc_banco.Text = string.Empty;
                TxtCod_moneda.Text = string.Empty;
                TxtDesc_moneda.Text = string.Empty;
                TxtCod_cuentasie.Text = string.Empty;
                TxtDesc_cuentasie.Text = string.Empty;
                TxtTipomov.Text = "Nota de Credito";
                TxtOptipo.Text = "NC";
                TxtNumdoc.Text = string.Empty;
                TxtNumop.Text = string.Empty;
                TxtOrigen.Text = string.Empty;
                TxtEstatus.Text = "Sin Procesar";
                TxtDesc_movbanco.Text = string.Empty;
                TxtMontod.Text = string.Empty;
                TxtMontoh.Text = string.Empty;
                TxtFecha_reg.Text = string.Empty;
                TxtSaldoinicial.Text = false.ToString();
                TxtAnulado.Text = false.ToString();
                TxtCampo1.Text = string.Empty;
                TxtCampo2.Text = string.Empty;
                TxtCampo3.Text = string.Empty;
                TxtCampo4.Text = string.Empty;
                TxtCampo5.Text = string.Empty;
                TxtCampo6.Text = string.Empty;
                TxtSaldo.Text = string.Empty;
                TxtNegativo.Text = string.Empty;
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

        private void EventosComboBox()
        {
            TxtTipomov.Items.AddRange(new object[] { "Nota de Credito", "Nota de Debito", "Interes", "Deposito", "Cheque", "Transferencia (+)", "Transferencia (-)", "Imp TF" });
        }

        private void OpTipoMov()
        {
            switch (TxtTipomov.Text)
            {
                case "Nota de Credito":
                    TxtOptipo.Text = "NC";
                    TxtOrigen.Text = "Banco";
                    break;
                case "Nota de Debito":
                    TxtOptipo.Text = "ND";
                    TxtOrigen.Text = "Banco";
                    break;
                case "Interes":
                    TxtOptipo.Text = "INT";
                    TxtOrigen.Text = "Banco";
                    break;
                case "Deposito":
                    TxtOptipo.Text = "DEP";
                    TxtOrigen.Text = "Deposito";
                    break;
                case "Cheque":
                    TxtOptipo.Text = "CHQ";
                    TxtOrigen.Text = "Banco";
                    break;
                case "Transferencia (+)":
                    TxtOptipo.Text = "TPOS";
                    TxtOrigen.Text = "Transferencia";
                    break;
                case "Transferencia (-)":
                    TxtOptipo.Text = "TNEG";
                    TxtOrigen.Text = "Transferencia";
                    break;
                case "Imp TF":
                    TxtOptipo.Text = "ITF";
                    TxtOrigen.Text = "Banco";
                    break;
                case "Orden de Pago":
                    TxtOptipo.Text = "OD";
                    TxtOrigen.Text = "Orden de Pago";
                    break;
            }
        }

        private void CodigoCuenta()
        {
            DataTable Dtc = ECuenta.Mostrar();
            foreach (DataRow Row in Dtc.Rows)
            {
                if ((!String.IsNullOrWhiteSpace(TxtCod_cuenta.Text) || !String.IsNullOrEmpty(TxtCod_cuenta.Text)))
                {
                    if (Convert.ToString(Row["cod_cuenta"]).Equals(TxtCod_cuenta.Text))
                    {
                        TxtSaldo.Text = Convert.ToString(Row["saldo"]);
                        TxtNegativo.Value = TxtSaldo.Value - TxtMontoh.Value;
                    }
                }
            }
        }

        private void EventoOptipo()
        {
            if (TxtOptipo.Text == "NC" || TxtOptipo.Text == "INT" || TxtOptipo.Text == "TPOS" || TxtOptipo.Text == "DEP")
            {
                if (TxtMontoh.Value != 0)
                {
                    TxtMontod.Value = TxtMontoh.Value;
                }
                TxtMontoh.Value = 0;
                TxtMontod.Visible = true;
                TxtMontoh.Visible = false;

            }
            else if (TxtOptipo.Text == "ND" || TxtOptipo.Text == "ITF" || TxtOptipo.Text == "TNEG" || TxtOptipo.Text == "CHQ" || TxtOptipo.Text == "OD")
            {

                if (TxtMontod.Value != 0)
                {
                    TxtMontoh.Value = TxtMontod.Value;
                }
                TxtMontod.Value = 0;
                TxtMontod.Visible = false;
                TxtMontoh.Visible = true;

                CodigoCuenta();

            }
        }

        private void EventosCHK()
        {
            if (ChkSaldonicial.Checked == true)
            {
                TxtSaldoinicial.Text = true.ToString();
            }
            else
            {
                TxtSaldoinicial.Text = false.ToString();
            }
        }

        //private void EventosTextBox()
        //{
        //    if (TxtSaldoinicial.Text == true.ToString())
        //    {
        //        ChkSaldonicial.Checked = true;
        //    }
        //    else
        //    {
        //        ChkSaldonicial.Checked = false;
        //    }


        //    if (TxtAnulado.Text == true.ToString())
        //    {
        //        TxtCod_movbanco.Enabled = false;
        //        TxtDesc_movbanco.Enabled = false;
        //        TxtCod_cuenta.Enabled = false;
        //        TxtCod_cuentasie.Enabled = false;
        //        TxtTipomov.Enabled = false;
        //        TxtNumdoc.Enabled = false;
        //        TxtNumop.Enabled = false;
        //        TxtMontod.Enabled = false;
        //        TxtMontoh.Enabled = false;
        //        TxtFecha_reg.Enabled = false;
        //        TxtCampo1.Enabled = false;
        //        TxtCampo2.Enabled = false;
        //        TxtCampo3.Enabled = false;
        //        TxtCampo4.Enabled = false;
        //        TxtCampo5.Enabled = false;
        //        TxtCampo6.Enabled = false;
        //        ChkSaldonicial.Enabled = false;
        //        BtnEliminar.Enabled = false;
        //        BtnAnular.Text = "Reactivar";
        //        BtnAnular.Enabled = true;
        //    }
        //    else
        //    {
        //        TxtCod_movbanco.Enabled = true;
        //        TxtDesc_movbanco.Enabled = true;
        //        TxtCod_cuenta.Enabled = true;
        //        TxtCod_cuentasie.Enabled = true;
        //        TxtTipomov.Enabled = true;
        //        TxtNumdoc.Enabled = true;
        //        TxtNumop.Enabled = true;
        //        TxtMontod.Enabled = true;
        //        TxtMontoh.Enabled = true;
        //        TxtFecha_reg.Enabled = true;
        //        TxtCampo1.Enabled = true;
        //        TxtCampo2.Enabled = true;
        //        TxtCampo3.Enabled = true;
        //        TxtCampo4.Enabled = true;
        //        TxtCampo5.Enabled = true;
        //        TxtCampo6.Enabled = true;
        //        ChkSaldonicial.Enabled = true;
        //        BtnEliminar.Enabled = true;
        //        BtnAnular.Text = "Anular";
        //        BtnAnular.Enabled = true;
        //    }

        //    if (TxtEstatus.Text == "Sin Procesar")
        //    {
        //        BtnEliminar.Enabled = true;
        //        BtnAnular.Enabled = true;
        //        TxtCod_movbanco.Enabled = true;
        //        TxtDesc_movbanco.Enabled = true;
        //        TxtCod_cuenta.Enabled = true;
        //        TxtCod_cuentasie.Enabled = true;
        //        TxtTipomov.Enabled = true;
        //        TxtNumdoc.Enabled = true;
        //        TxtNumop.Enabled = true;
        //        TxtMontod.Enabled = true;
        //        TxtMontoh.Enabled = true;
        //        TxtFecha_reg.Enabled = true;
        //        TxtCampo1.Enabled = true;
        //        TxtCampo2.Enabled = true;
        //        TxtCampo3.Enabled = true;
        //        TxtCampo4.Enabled = true;
        //        TxtCampo5.Enabled = true;
        //        TxtCampo6.Enabled = true;
        //        ChkSaldonicial.Enabled = true;
        //    }
        //    else if (TxtEstatus.Text == "Procesado")
        //    {
        //        BtnEliminar.Enabled = false;
        //        BtnAnular.Enabled = false;

        //        TxtCod_movbanco.Enabled = false;
        //        TxtDesc_movbanco.Enabled = false;
        //        TxtCod_cuenta.Enabled = false;
        //        TxtCod_cuentasie.Enabled = false;
        //        TxtTipomov.Enabled = false;
        //        TxtNumdoc.Enabled = false;
        //        TxtNumop.Enabled = false;
        //        TxtMontod.Enabled = false;
        //        TxtMontoh.Enabled = false;
        //        TxtFecha_reg.Enabled = false;
        //        TxtCampo1.Enabled = false;
        //        TxtCampo2.Enabled = false;
        //        TxtCampo3.Enabled = false;
        //        TxtCampo4.Enabled = false;
        //        TxtCampo5.Enabled = false;
        //        TxtCampo6.Enabled = false;
        //        ChkSaldonicial.Enabled = false;
        //    }
        //}

        private void Habilitar(bool valor)
        {
            TxtCod_movbanco.Enabled = valor;
            TxtCod_cuenta.Enabled = valor;;
            TxtCod_banco.Enabled = valor;
            TxtCod_moneda.Enabled = valor;
            TxtCod_cuentasie.Enabled = valor;
            TxtTipomov.Enabled = valor;
            TxtNumdoc.Enabled = valor;
            TxtNumop.Enabled = valor;
            TxtDesc_movbanco.Enabled = valor;
            TxtMontod.Enabled = valor;
            TxtMontoh.Enabled = valor;
            TxtFecha_reg.Enabled = valor;
            TxtCampo1.Enabled = valor;
            TxtCampo2.Enabled = valor;
            TxtCampo3.Enabled = valor;
            TxtCampo4.Enabled = valor;
            TxtCampo5.Enabled = valor;
            TxtCampo6.Enabled = valor;
            TxtSaldo.Enabled = valor;
            TxtNegativo.Enabled = valor;
            ChkSaldonicial.Enabled = valor;
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
                BtnSaldo.Enabled = false;
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
                BtnSaldo.Enabled = false;
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
                BtnSaldo.Enabled = true;
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

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnSaldo.Enabled = true;
                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Anulado")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;
                BtnAnular.Enabled = false;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnSaldo.Enabled = true;
                Habilitar(false);
            }
        }

        private void GenerarCod()
        {
            try
            {
                int rpta = Convert.ToInt32(EMovBanco.GenerarCod(TxtCod_movbanco.Text));
                TxtCod_movbanco.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_movbanco.Focus();
            }
        }

        public void Listar()
        {
            try
            {
                Ds = EMovBanco.Listar();

                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();
                TxtCod_movbancov.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();
                TxtDesc_movbanco.Text = Ds.Tables[0].Rows[0]["desc_movbanco"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdoc.Text = Ds.Tables[0].Rows[0]["numdoc"].ToString();
                TxtNumop.Text = Ds.Tables[0].Rows[0]["numop"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtMontod.Text = Ds.Tables[0].Rows[0]["montod"].ToString();
                TxtMontoh.Text = Ds.Tables[0].Rows[0]["montoh"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtSaldoinicial.Text = Ds.Tables[0].Rows[0]["saldoinicial"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();


                TxtEditar.Text = "Listar";
                Registros();

            }
            catch (Exception Ex)
            {
                Show();
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_movbanco.Focus();
                string rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }

            OpTipoMov();
            EventoOptipo();
        }

        private void FMovBanco_Load(object sender, EventArgs e)
        {
            Text = "...::: Movimiento de Banco :::...";
            MostraUsuario();
            Listar();
            EventosComboBox();
        }

        #region PROCESOS PRINCIPALES

        //private void Egreso()
        //{
        //    if (TxtNegativo.Value < 0)
        //    {
        //        DialogResult Opcion = MessageBox.Show("Se generara un saldo Negativo en la Cuenta " + TxtCod_cuenta.Text + " " + " de " + TxtNegativo.Text + " Desea Continuar?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        //        if (Opcion == DialogResult.OK)
        //        {
        //            Registrar = true;
        //        }
        //        else
        //        {
        //            Registrar = false;
        //        }
        //    }
        //}

        private void MetodoGuardar()
        {
            String Rpta = "";
            if (TxtEditar.Text == "Nuevo")
            {
                GenerarCod();
                Rpta = EMovBanco.Insertar
                    (TxtCod_movbanco.Text, TxtCod_cuenta.Text, TxtCod_cuentasie.Text, TxtDesc_movbanco.Text, TxtTipomov.Text, TxtOptipo.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
            }
            else if (TxtEditar.Text == "Editar")
            {
                Rpta = EMovBanco.Editar
                    (TxtCod_movbanco.Text, TxtCod_movbancov.Text, TxtCod_cuenta.Text, TxtCod_cuentasie.Text, TxtDesc_movbanco.Text, TxtTipomov.Text, TxtOptipo.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
            }
        }

        private void Guardar()
        {
            try
            {
                String Rpta = "";
                if (TxtCod_cuenta.Text == string.Empty || TxtCod_cuentasie.Text == string.Empty || TxtNumop.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_cuenta, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_cuentasie, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtNumop, "Campo Obligatorio");
                }
                else if (TxtNegativo.Value < 0 && TxtEditar.Text=="Nuevo")
                {
                    DialogResult Opcion = MessageBox.Show("Se generara un saldo Negativo en la Cuenta " + TxtCod_cuenta.Text + " " + " de " + TxtNegativo.Text + " Desea Continuar?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (Opcion == DialogResult.OK)
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            GenerarCod();
                            Rpta = EMovBanco.Insertar
                                (TxtCod_movbanco.Text, TxtCod_cuenta.Text, TxtCod_cuentasie.Text, TxtDesc_movbanco.Text, TxtTipomov.Text, TxtOptipo.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        }
                        else if (TxtEditar.Text == "Editar")
                        {
                            Rpta = EMovBanco.Editar
                                (TxtCod_movbanco.Text, TxtCod_movbancov.Text, TxtCod_cuenta.Text, TxtCod_cuentasie.Text, TxtDesc_movbanco.Text, TxtTipomov.Text, TxtOptipo.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        }
                    }
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        GenerarCod();
                        Rpta = EMovBanco.Insertar
                            (TxtCod_movbanco.Text, TxtCod_cuenta.Text, TxtCod_cuentasie.Text, TxtDesc_movbanco.Text, TxtTipomov.Text, TxtOptipo.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EMovBanco.Editar
                            (TxtCod_movbanco.Text, TxtCod_movbancov.Text, TxtCod_cuenta.Text, TxtCod_cuentasie.Text, TxtDesc_movbanco.Text, TxtTipomov.Text, TxtOptipo.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            Listar();
                        }
                        else if (TxtEditar.Text == "Editar")
                        {
                            MensajeOk("El Registro se Editó Correctamente");
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
            TxtCod_movbanco.Focus();
            Botones();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente desea Eliminar el Registro ?", "...::: Step One Ver 1.0 :::...",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string Rpta = "";

                if (Opcion == DialogResult.OK)
                {
                    Rpta = EMovBanco.Eliminar(TxtCod_movbanco.Text, TxtCod_cuenta.Text, TxtOptipo.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text));

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
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnAnular.Text == "Anular")
                {
                    DialogResult Opcion = MessageBox.Show("Realmente desea Anular el Registro ?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    string Rpta = "";

                    if (Opcion == DialogResult.OK)
                    {
                        TxtEstatus.Text = "Anulado";
                        TxtAnulado.Text = true.ToString();

                        Rpta = EMovBanco.Anular(TxtCod_movbanco.Text, TxtCod_cuenta.Text, TxtOptipo.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCod_usuario.Text);

                        if (Rpta.Equals("Y"))
                        {
                            MensajeOk("Registro Anulado Correctamente!");
                            TxtEditar.Text = "Listar";
                            Botones();
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
                else if (BtnAnular.Text == "Reactivar")
                {
                    DialogResult Opcion = MessageBox.Show("Realmente desea Reactivar el Registro ?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    string Rpta = "";

                    if (Opcion == DialogResult.OK)
                    {
                        TxtEstatus.Text = "Sin Procesar";
                        TxtAnulado.Text = false.ToString();

                        Rpta = EMovBanco.Anular(TxtCod_movbanco.Text, TxtCod_cuenta.Text, TxtOptipo.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCod_usuario.Text);

                        if (Rpta.Equals("Y"))
                        {
                            MensajeOk("Registro Reactivado Correctamente!");
                            TxtEditar.Text = "Listar";
                            Botones();
                        }
                        else
                        {
                            MensajeError(Rpta);
                        }
                    }
                    else
                    {
                        MensajeError("Cancelando la Reactivacion de Registros!");
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FMovBancoLista Listado = new FMovBancoLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //RMovBanco Reporte = new RMovBanco();
            //Reporte.ShowDialog();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {

            GenerarCod();
        }

        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtCod_movbanco_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_movbanco_TextChanged(object sender, EventArgs e)
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

        private void TxtRecargo_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtImpuesto_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtComision_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void TxtOptipo_TextChanged(object sender, EventArgs e)
        {
            OpTipoMov();
            EventoOptipo();
            CambiosTexBox();
        }

        private void TxtTipomov_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpTipoMov();
            EventoOptipo();
            TxtSaldo.Value = TxtNegativo.Value - TxtMontoh.Value;
        }

        private void TxtMontoh_ValueChanged(object sender, EventArgs e)
        {
            OpTipoMov();
            EventoOptipo();
            CambiosTexBox();
            CodigoCuenta();
            TxtSaldo.Value = TxtNegativo.Value - TxtMontoh.Value;
        }

        private void TxtMontod_ValueChanged(object sender, EventArgs e)
        {
            OpTipoMov();
            EventoOptipo();
            CambiosTexBox();
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_cuenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_banco_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumdoc_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_cuentasie_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumop_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtSaldoinicial_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtAnulado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void ChkSaldonicial_CheckedChanged(object sender, EventArgs e)
        {
            EventosCHK();
        }
        #endregion

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EMovBanco.Primero();

                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();
                TxtDesc_movbanco.Text = Ds.Tables[0].Rows[0]["desc_movbanco"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdoc.Text = Ds.Tables[0].Rows[0]["numdoc"].ToString();
                TxtNumop.Text = Ds.Tables[0].Rows[0]["numop"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtMontod.Text = Ds.Tables[0].Rows[0]["montod"].ToString();
                TxtMontoh.Text = Ds.Tables[0].Rows[0]["montoh"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtSaldoinicial.Text = Ds.Tables[0].Rows[0]["saldoinicial"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movbancov.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

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
                Ds = EMovBanco.Anterior(TxtCod_movbanco.Text);

                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();
                TxtDesc_movbanco.Text = Ds.Tables[0].Rows[0]["desc_movbanco"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdoc.Text = Ds.Tables[0].Rows[0]["numdoc"].ToString();
                TxtNumop.Text = Ds.Tables[0].Rows[0]["numop"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtMontod.Text = Ds.Tables[0].Rows[0]["montod"].ToString();
                TxtMontoh.Text = Ds.Tables[0].Rows[0]["montoh"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtSaldoinicial.Text = Ds.Tables[0].Rows[0]["saldoinicial"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movbancov.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

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
                Ds = EMovBanco.Siguiente(TxtCod_movbanco.Text);

                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();
                TxtDesc_movbanco.Text = Ds.Tables[0].Rows[0]["desc_movbanco"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdoc.Text = Ds.Tables[0].Rows[0]["numdoc"].ToString();
                TxtNumop.Text = Ds.Tables[0].Rows[0]["numop"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtMontod.Text = Ds.Tables[0].Rows[0]["montod"].ToString();
                TxtMontoh.Text = Ds.Tables[0].Rows[0]["montoh"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtSaldoinicial.Text = Ds.Tables[0].Rows[0]["saldoinicial"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_movbancov.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

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
                Ds = EMovBanco.Ultimo();

                TxtCod_movbanco.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();
                TxtDesc_movbanco.Text = Ds.Tables[0].Rows[0]["desc_movbanco"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdoc.Text = Ds.Tables[0].Rows[0]["numdoc"].ToString();
                TxtNumop.Text = Ds.Tables[0].Rows[0]["numop"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtMontod.Text = Ds.Tables[0].Rows[0]["montod"].ToString();
                TxtMontoh.Text = Ds.Tables[0].Rows[0]["montoh"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtSaldoinicial.Text = Ds.Tables[0].Rows[0]["saldoinicial"].ToString();
                TxtAnulado.Text = Ds.Tables[0].Rows[0]["anulado"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();

                TxtCod_movbancov.Text = Ds.Tables[0].Rows[0]["cod_movbanco"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }



        #endregion

        #region LLAMAR REGISTROS
        internal void SetMovBanco(string cod_movbanco, string desc_movbanco, string cod_cuenta, string desc_cuenta, string numcuenta, string cod_banco, string desc_banco, string cod_moneda, string desc_moneda, string cod_cuentasie, string desc_cuentasie, string tipomov, string optipo, string numdoc, string numop, string origen, string estatus, string montod, string montoh, string fecha_reg, string saldoinicial, string anulado, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            TxtCod_movbanco.Text = cod_movbanco;
            TxtDesc_movbanco.Text = desc_movbanco;
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtNumcuenta.Text = numcuenta;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
            TxtTipomov.Text = tipomov;
            TxtOptipo.Text = optipo;
            TxtNumdoc.Text = numdoc;
            TxtNumop.Text = numop;
            TxtOrigen.Text = origen;
            TxtEstatus.Text = estatus;
            TxtMontod.Text = montod;
            TxtMontoh.Text = montoh;
            TxtFecha_reg.Text = fecha_reg;
            TxtSaldoinicial.Text = saldoinicial;
            TxtAnulado.Text = anulado;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
            TxtCod_usuario.Text = cod_usuario;
        }

        public void SetCuenta(string cod_cuenta, string desc_cuenta, string cod_banco, string desc_banco, string cod_moneda, string desc_moneda, string numcuenta)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtNumcuenta.Text = numcuenta;

            CodigoCuenta();
        }

        public void SetCuentasIE(string cod_cuentasie, string desc_cuentasie)
        {
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
        }

        private void TxtCod_cuenta_DoubleClick(object sender, EventArgs e)
        {
            FCuentaLista Listado = new FCuentaLista
            {
                TxtFlag = "MovBanco"
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
                    TxtFlag = "MovBanco"
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

        private void TxtCod_cuentasie_DoubleClick(object sender, EventArgs e)
        {
            FCuentasIELista Listado = new FCuentasIELista
            {
                TxtFlag = "MovBanco"
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
                    TxtFlag = "MovBanco"
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
        #endregion

        private void BtnSaldo_Click(object sender, EventArgs e)
        {
            DataTable Dtc = ECuenta.Mostrar();
            String Saldo = "";
            String Moneda = "";

            foreach (DataRow Row in Dtc.Rows)
            {
                if (!String.IsNullOrWhiteSpace(TxtCod_cuenta.Text) || !String.IsNullOrEmpty(TxtCod_cuenta.Text))
                {
                    if (Convert.ToString(Row["cod_cuenta"]).Equals(TxtCod_cuenta.Text) && (TxtEditar.Text != "Nuevo" || TxtEditar.Text != "Editar"))
                    {
                        Saldo = Convert.ToString(Row["saldo"]);
                        Moneda = Convert.ToString(Row["cod_moneda"]);
                    }
                }
            }
            TxtSaldo.Text = Saldo.ToString();
            TxtCod_moneda.Text = Moneda.ToString();

            MensajeOk(" " + TxtCod_moneda.Text.Trim() + " .: " + " " + TxtSaldo.Text.Trim() + "  !");
        }

        private void FMovBanco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FMovBanco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtEditar.Text == "Editar" || ((TxtEditar.Text == "Nuevo" && !String.IsNullOrEmpty(TxtCod_cuenta.Text) || !String.IsNullOrEmpty(TxtCod_cuentasie.Text) || !String.IsNullOrEmpty(TxtNumop.Text))))
            {
                Opcion = MessageBox.Show("Desea Guardar el Registro antes de Salir? ", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Guardar();
                }
            }
        }
    }
}


