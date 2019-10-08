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
    public partial class FMovCaja : Form
    {
        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FMovCaja _Instancia;

        public static FMovCaja GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FMovCaja();
            }
            return _Instancia;
        }

        public FMovCaja()
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
            Dt = EMovCaja.Mostrar();
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
                TxtCod_movcaja.Text = string.Empty;
            }
            else
            {
                TxtCod_movcaja.Text = string.Empty;
                TxtDesc_movcaja.Text = string.Empty;
                TxtCod_caja.Text = string.Empty;
                TxtDesc_caja.Text = string.Empty;
                TxtCod_moneda.Text = string.Empty;
                TxtDesc_moneda.Text = string.Empty;
                TxtCod_banco.Text = string.Empty;
                TxtDesc_banco.Text = string.Empty;
                TxtCod_tarjeta.Text = string.Empty;
                TxtDesc_tarjeta.Text = string.Empty;
                TxtCod_cuentasie.Text = string.Empty;
                TxtDesc_cuentasie.Text = string.Empty;
                TxtTipomov.Text = "Egreso";
                TxtOptipo.Text = "E";
                TxtForma.Text = "Efectivo";
                TxtNumdoc.Text = string.Empty;
                TxtNumop.Text = string.Empty;
                TxtOrigen.Text = string.Empty;
                TxtEstatus.Text = "Sin Procesar";
                TxtMontoh.Text = string.Empty;
                TxtMontod.Text = string.Empty;
                TxtFecha_reg.Text = string.Empty;
                TxtSaldoinicial.Text = false.ToString();
                TxtAnulado.Text = false.ToString();
                TxtCampo1.Text = string.Empty;
                TxtCampo2.Text = string.Empty;
                TxtCampo3.Text = string.Empty;
                TxtCampo4.Text = string.Empty;
                TxtCampo5.Text = string.Empty;
                TxtCampo6.Text = string.Empty;
                TxtSaldototal.Text = string.Empty;
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

        private void PComboBox()
        {
            TxtForma.Items.AddRange(new object[] { "Efectivo", "Cheque", "Tarjeta" });

            TxtTipomov.Items.AddRange(new object[] { "Ingreso", "Egreso" });
        }

        private void TipoMov()
        {
            if (TxtTipomov.Text == "Ingreso")
            {
                TxtForma.Enabled = true;
                TxtOptipo.Text = "I";
                if (TxtMontoh.Value != 0)
                {
                    TxtMontod.Value = TxtMontoh.Value;
                }
                TxtMontoh.Value = 0;
                TxtMontoh.Visible = false;
                TxtMontod.Visible = true;

            }
            else if (TxtTipomov.Text == "Egreso")
            {
                TxtForma.Text = "Efectivo";
                TxtForma.Enabled = false;
                TxtOptipo.Text = "E";
                if (TxtMontod.Value != 0)
                {
                    TxtMontoh.Value = TxtMontod.Value;
                }
                TxtMontod.Value = 0;
                TxtMontod.Visible = false;
                TxtMontoh.Visible = true;
            }
        }

        private void Forma()
        {
            if (TxtForma.Text == "Efectivo")
            {
                TxtCod_tarjeta.Enabled = false;
                TxtDesc_tarjeta.Enabled = false;
                TxtCod_banco.Enabled = false;
                TxtDesc_banco.Enabled = false;

                TxtCod_banco.Text = string.Empty;
                TxtDesc_banco.Text = string.Empty;
                TxtCod_tarjeta.Text = string.Empty;
                TxtDesc_tarjeta.Text = string.Empty;
            }
            else if (TxtForma.Text == "Cheque")
            {

                TxtCod_tarjeta.Enabled = false;
                TxtDesc_tarjeta.Enabled = false;
                TxtCod_banco.Enabled = true;
                TxtDesc_banco.Enabled = true;

                TxtCod_banco.Text = string.Empty;
                TxtDesc_banco.Text = string.Empty;
                TxtCod_tarjeta.Text = string.Empty;
                TxtDesc_tarjeta.Text = string.Empty;
            }
            else if (TxtForma.Text == "Tarjeta")
            {
                TxtCod_tarjeta.Enabled = true;
                TxtDesc_tarjeta.Enabled = true;
                TxtCod_banco.Enabled = true;
                TxtDesc_banco.Enabled = true;

                TxtCod_banco.Text = string.Empty;
                TxtDesc_banco.Text = string.Empty;
                TxtCod_tarjeta.Text = string.Empty;
                TxtDesc_tarjeta.Text = string.Empty;
            }
        }

        private void EventosTextBox()
        {
            if (TxtSaldoinicial.Text == true.ToString())
            {
                ChkSaldonicial.Checked = true;
            }
            else
            {
                ChkSaldonicial.Checked = false;
            }

            if(TxtAnulado.Text==true.ToString())
            {
                BtnAnular.Text = "Reactivar";
            }
            else
            {
                BtnAnular.Text = "Anular";
            }
        }

        private void EventosChk()
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

        public void GenerarCod()
        {
            try
            {
                int rpta = Convert.ToInt32(EMovCaja.GenerarCod(TxtCod_movcaja.Text));
                TxtCod_movcaja.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_movcaja.Focus();
            }
        }

        private void Habilitar(bool valor)
        {
            TxtCod_movcaja.Enabled = valor;
            TxtDesc_movcaja.Enabled = valor;
            TxtCod_caja.Enabled = valor;
            //TxtCod_banco.Enabled = valor;
            //TxtCod_tarjeta.Enabled = valor;
            TxtCod_cuentasie.Enabled = valor;
            TxtTipomov.Enabled = valor;
            //TxtForma.Enabled = valor;
            TxtNumdoc.Enabled = valor;
            TxtNumop.Enabled = valor;
            TxtMontoh.Enabled = valor;
            TxtMontod.Enabled = valor;
            TxtFecha_reg.Enabled = valor;
            TxtCampo1.Enabled = valor;
            TxtCampo2.Enabled = valor;
            TxtCampo3.Enabled = valor;
            TxtCampo4.Enabled = valor;
            TxtCampo5.Enabled = valor;
            TxtCampo6.Enabled = valor;
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
                BtnAnular.Text = "Anular";
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
                BtnAnular.Text = "Anular";
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
                BtnAnular.Text = "Anular";
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
                BtnAnular.Text = "Anular";

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
                BtnAnular.Enabled = true;
                BtnAnular.Text = "Reactivar";

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnSaldo.Enabled = true;
                Habilitar(false);
            }
        }

        public void Listar()
        {
            try
            {
                Ds = EMovCaja.Listar();

                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movcajav.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtDesc_movcaja.Text = Ds.Tables[0].Rows[0]["desc_movcaja"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_tarjeta.Text = Ds.Tables[0].Rows[0]["cod_tarjeta"].ToString();
                TxtDesc_tarjeta.Text = Ds.Tables[0].Rows[0]["desc_tarjeta"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
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
                EventosTextBox();

            }
            catch (Exception Ex)
            {
                Show();
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_caja.Focus();
                string rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }

        }

        internal void ProcesoGuardar()
        {
            string Rpta = "";

            if (TxtEditar.Text == "Nuevo")
            {
                GenerarCod();
                Rpta = EMovCaja.Insertar
                    (TxtCod_movcaja.Text, TxtCod_caja.Text, TxtCod_banco.Text, TxtCod_tarjeta.Text, TxtCod_cuentasie.Text, TxtDesc_movcaja.Text, TxtTipomov.Text, TxtOptipo.Text, TxtForma.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
            }
            else if (TxtEditar.Text == "Editar")
            {
                Rpta = EMovCaja.Editar
                    (TxtCod_movcaja.Text, TxtCod_movcajav.Text, TxtCod_caja.Text, TxtCod_banco.Text, TxtCod_tarjeta.Text, TxtCod_cuentasie.Text, TxtDesc_movcaja.Text, TxtTipomov.Text, TxtOptipo.Text, TxtForma.Text, TxtNumdoc.Text, TxtNumop.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtSaldoinicial.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
            }

            if (Rpta.Equals("Y"))
            {
                if (TxtEditar.Text == "Nuevo")
                {
                    MensajeOk("El Registro se Insertó Correctamente");
                    TxtEditar.Text = "Listar";
                }
                else if (TxtEditar.Text == "Editar")
                {
                    MensajeOk("El Registro se Editó Correctamente");
                    TxtEditar.Text = "Listar";
                }
            }
            else
            {
                MensajeError(Rpta);
            }
        }

        private void Guardar()
        {
            try
            {
                DialogResult Opcion;

                if (TxtCod_caja.Text == string.Empty || TxtCod_cuentasie.Text == string.Empty || TxtNumop.Text == string.Empty && TxtForma.Text == "Efectivo")
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_caja, "Debe LLamar a una caja");
                    ErrorTexto.SetError(TxtNumop, "Ingrese el Numero de Operacion");
                    ErrorTexto.SetError(TxtCod_cuentasie, "Debe LLamar a la Cuenta de I/E");
                }
                else if (TxtCod_caja.Text == string.Empty || TxtCod_cuentasie.Text == string.Empty || TxtNumop.Text == string.Empty || TxtNumdoc.Text == string.Empty || TxtCod_banco.Text == string.Empty && TxtForma.Text == "Cheque")
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_caja, "Debe LLamar a una caja");
                    ErrorTexto.SetError(TxtNumdoc, "Ingrese el Numero de Operacion");
                    ErrorTexto.SetError(TxtNumop, "Ingrese el Numero de Operacion");
                    ErrorTexto.SetError(TxtCod_cuentasie, "Debe LLamar a la Cuenta de I/E");
                    ErrorTexto.SetError(TxtCod_banco, "Debe LLamar un Banco");
                }
                else if (TxtCod_caja.Text == string.Empty || TxtCod_cuentasie.Text == string.Empty || TxtNumop.Text == string.Empty || TxtCod_tarjeta.Text == string.Empty && TxtForma.Text == "Tarjeta")
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_caja, "Debe LLamar a una caja");
                    ErrorTexto.SetError(TxtNumop, "Ingrese el Numero de Operacion");
                    ErrorTexto.SetError(TxtCod_cuentasie, "Debe LLamar a la Cuenta de I/E");
                    ErrorTexto.SetError(TxtCod_tarjeta, "Debe LLamar una Tarjeta");
                }
                else
                {
                    if (TxtSaldoefectivo.Value < TxtMontoh.Value && TxtTipomov.Text=="Egreso" && TxtEditar.Text=="Nuevo")
                    {
                        Opcion = MessageBox.Show(
                            "El Movimiento de la Caja  " + TxtCod_caja.Text + "   " + TxtDesc_caja.Text + "   es Mayor al saldo Efectivo El Saldo Final en Caja sera =  " + Convert.ToDecimal(TxtSaldoefectivo.Value - TxtMontoh.Value).ToString("N2"), "  Desea Continuar ? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            ProcesoGuardar();
                        }
                        else
                        {
                            MensajeError("Verifique el Monto Para Continuar");
                            TxtMontoh.Focus();
                            ErrorTexto.SetError(TxtMontoh, " ");
                        }
                    }
                    else if (TxtSaldodocumento.Value < TxtMontoh.Value && TxtTipomov.Text == "Egreso" && TxtEditar.Text == "Nuevo")
                    {
                        Opcion = MessageBox.Show(
                           "El Movimiento de la Caja  " + TxtCod_caja.Text + "  " + TxtDesc_caja.Text + "   es Mayor al saldo en Documentos, El Saldo Final en Caja sera =  " + Convert.ToDecimal(TxtSaldodocumento.Value - TxtMontoh.Value).ToString("N2"), " Desea Continuar ? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            ProcesoGuardar();
                        }
                        else
                        {
                            MensajeError("Verifique el Monto Para Continuar");
                            TxtMontoh.Focus();
                            ErrorTexto.SetError(TxtMontoh, " ");
                        }
                    }
                    else
                    {
                        ProcesoGuardar();
                    }
                }
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void FMovCaja_Load(object sender, EventArgs e)
        {
            Text = "...::: Movimiento de Caja :::...";
            MostraUsuario();
            PComboBox();
            Forma();
            TipoMov();
            Listar();
        }
        #region PROCESOS PRINCIPALES
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            TxtCod_movcajav.Text = TxtCod_movcaja.Text;
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
            TxtCod_movcaja.Focus();
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
                    Rpta = EMovCaja.Eliminar(TxtCod_movcaja.Text, TxtCod_caja.Text, TxtOptipo.Text, TxtForma.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text));

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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FMovCajaLista Listado = new FMovCajaLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //RMovCaja Reporte = new RMovCaja();
            //Reporte.ShowDialog();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCod();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnAnular.Text == "Anular")
                {
                    DialogResult Opcion = MessageBox.Show("Realmente desea " + BtnAnular.Text + " el Registro ?", "...::: Step One Ver 1.0 :::...",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    string Rpta = "";

                    if (Opcion == DialogResult.OK)
                    {

                        TxtAnulado.Text = true.ToString();
                        TxtEstatus.Text = "Anulado";
                        Rpta = EMovCaja.Anular(TxtCod_movcaja.Text, TxtCod_caja.Text, TxtOptipo.Text, TxtForma.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCod_usuario.Text);

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
                    DialogResult Opcion = MessageBox.Show("Realmente desea " + BtnAnular.Text + " el Registro ?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    string Rpta = "";

                    if (Opcion == DialogResult.OK)
                    {
                        TxtAnulado.Text = false.ToString();
                        TxtEstatus.Text = "Sin Procesar";
                        Rpta = EMovCaja.Anular(TxtCod_movcaja.Text, TxtCod_caja.Text, TxtOptipo.Text, TxtForma.Text, TxtEstatus.Text, Convert.ToDecimal(TxtMontod.Text), Convert.ToDecimal(TxtMontoh.Text), Convert.ToBoolean(TxtAnulado.Text), TxtCod_usuario.Text);

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

        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtForma_VisibleChanged(object sender, EventArgs e)
        {
            Forma();
        }

        private void TxtCod_movcaja_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_movcaja_TextChanged(object sender, EventArgs e)
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

        private void TxtTipomov_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoMov();
            CambiosTexBox();
        }

        private void TxtOptipo_TextChanged(object sender, EventArgs e)
        {
            TipoMov();
            CambiosTexBox();
        }

        private void TxtForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Forma();
            CambiosTexBox();
        }

        private void TxtMontoh_ValueChanged(object sender, EventArgs e)
        {
            TipoMov();
            CambiosTexBox();
        }

        private void TxtMontod_ValueChanged(object sender, EventArgs e)
        {
            TipoMov();
            CambiosTexBox();
        }

        private void TxtCod_caja_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_banco_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            //Forma();
        }

        private void TxtCod_tarjeta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            //Forma();
        }

        private void TxtCod_cuentasie_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumop_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumdoc_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtOrigen_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNummovimiento_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtSaldoinicial_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTextBox();
        }

        private void TxtAnulado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTextBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }
        #endregion

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EMovCaja.Primero();

                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movcajav.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtDesc_movcaja.Text = Ds.Tables[0].Rows[0]["desc_movcaja"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_tarjeta.Text = Ds.Tables[0].Rows[0]["cod_tarjeta"].ToString();
                TxtDesc_tarjeta.Text = Ds.Tables[0].Rows[0]["desc_tarjeta"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
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
                EventosTextBox();
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
                Ds = EMovCaja.Anterior(TxtCod_movcaja.Text);

                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movcajav.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtDesc_movcaja.Text = Ds.Tables[0].Rows[0]["desc_movcaja"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_tarjeta.Text = Ds.Tables[0].Rows[0]["cod_tarjeta"].ToString();
                TxtDesc_tarjeta.Text = Ds.Tables[0].Rows[0]["desc_tarjeta"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
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
                EventosTextBox();
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
                Ds = EMovCaja.Siguiente(TxtCod_movcaja.Text);

                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movcajav.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtDesc_movcaja.Text = Ds.Tables[0].Rows[0]["desc_movcaja"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_tarjeta.Text = Ds.Tables[0].Rows[0]["cod_tarjeta"].ToString();
                TxtDesc_tarjeta.Text = Ds.Tables[0].Rows[0]["desc_tarjeta"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
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
                EventosTextBox();
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
                Ds = EMovCaja.Ultimo();

                TxtCod_movcaja.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtCod_movcajav.Text = Ds.Tables[0].Rows[0]["cod_movcaja"].ToString();
                TxtDesc_movcaja.Text = Ds.Tables[0].Rows[0]["desc_movcaja"].ToString();
                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_tarjeta.Text = Ds.Tables[0].Rows[0]["cod_tarjeta"].ToString();
                TxtDesc_tarjeta.Text = Ds.Tables[0].Rows[0]["desc_tarjeta"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtTipomov.Text = Ds.Tables[0].Rows[0]["tipomov"].ToString();
                TxtOptipo.Text = Ds.Tables[0].Rows[0]["optipo"].ToString();
                TxtForma.Text = Ds.Tables[0].Rows[0]["forma"].ToString();
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
                EventosTextBox();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        #endregion

        #region LLAMAR REGISTROS

        internal void SetMovCaja(string cod_movcaja, string desc_movcaja, string cod_caja, string desc_caja, string cod_moneda, string desc_moneda, string cod_banco, string desc_banco, string cod_tarjeta, string desc_tarjeta, string cod_cuentasie, string desc_cuentasie, string tipomov, string optipo, string forma, string numdoc, string numop, string origen, string estatus, string montod, string montoh, string fecha_reg, string saldoinicial, string anulado, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            TxtCod_movcaja.Text = cod_movcaja;
            TxtCod_movcajav.Text = cod_movcaja;
            TxtDesc_movcaja.Text = desc_movcaja;
            TxtCod_caja.Text = cod_caja;
            TxtDesc_caja.Text = desc_caja;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_tarjeta.Text = cod_tarjeta;
            TxtDesc_tarjeta.Text = desc_tarjeta;
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
            TxtTipomov.Text = tipomov;
            TxtOptipo.Text = optipo;
            TxtForma.Text = forma;
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

        public void SetCaja(string cod_caja, string desc_caja, string cod_moneda, string desc_moneda)
        {
            TxtCod_caja.Text = cod_caja;
            TxtDesc_caja.Text = desc_caja;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;

            DataTable Dtc = ECaja.Mostrar();
            foreach (DataRow Row in Dtc.Rows)
            {
                if (Convert.ToString(Row["cod_caja"]).Equals(TxtCod_caja.Text))
                {
                    TxtSaldoefectivo.Text = Convert.ToString(Row["saldoefectivo"]);
                    TxtSaldodocumento.Text = Convert.ToString(Row["saldodocumento"]);
                }
            }
        }

        public void SetCuentasIE(string cod_cuentasie, string desc_cuentasie)
        {
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
        }

        public void SetTarjeta(string cod_tarjeta, string desc_tarjeta)
        {
            TxtCod_tarjeta.Text = cod_tarjeta;
            TxtDesc_tarjeta.Text = desc_tarjeta;
        }

        public void SetBanco(string cod_banco, string desc_banco)
        {
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
        }

        private void TxtCod_caja_DoubleClick(object sender, EventArgs e)
        {
            FCajaLista Listado = new FCajaLista
            {
                TxtFlag = "MovCaja"
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
                    TxtFlag = "MovCaja"
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

        private void TxtCod_banco_DoubleClick(object sender, EventArgs e)
        {
            FBancoLista Listado = new FBancoLista
            {
                TxtFlag = "MovCaja"
            };
            Dt = EBanco.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_banco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FBancoLista Listado = new FBancoLista
                {
                    TxtFlag = "MovCaja"
                };
                Dt = EBanco.Mostrar();
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

        private void TxtCod_tarjeta_DoubleClick(object sender, EventArgs e)
        {
            FTarjetaLista Listado = new FTarjetaLista
            {
                TxtFlag = "MovCaja"
            };
            Dt = ETarjeta.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_tarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FTarjetaLista Listado = new FTarjetaLista
                {
                    TxtFlag = "MovCaja"
                };
                Dt = ETarjeta.Mostrar();
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
                TxtFlag = "MovCaja"
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
                    TxtFlag = "MovCaja"
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

        private void ChkSaldonicial_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void FMovCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FMovCaja_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnSaldo_Click(object sender, EventArgs e)
        {
            DataTable Dtc = ECaja.Mostrar();
            String Saldo = "";
            String Moneda = "";

            foreach (DataRow Row in Dtc.Rows)
            {
                if (!String.IsNullOrWhiteSpace(TxtCod_caja.Text) || !String.IsNullOrEmpty(TxtCod_caja.Text))
                {
                    if (Convert.ToString(Row["cod_caja"]).Equals(TxtCod_caja.Text) && (TxtEditar.Text != "Nuevo" || TxtEditar.Text != "Editar"))
                    {
                        Saldo = Convert.ToString(Row["saldototal"]);
                        Moneda = Convert.ToString(Row["cod_moneda"]);
                    }
                }
            }
            TxtSaldototal.Text = Saldo.ToString();
            TxtCod_moneda.Text = Moneda.ToString();

            MensajeOk(" " + TxtCod_moneda.Text.Trim() + " .: " + " " + TxtSaldototal.Text.Trim() + "  !");
        }
    }
}
