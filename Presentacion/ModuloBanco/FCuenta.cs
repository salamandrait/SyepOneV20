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
    public partial class FCuenta : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FCuenta _Instancia;

        public static FCuenta GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FCuenta();
            }
            return _Instancia;
        }

        public FCuenta()
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
            Dt = ECuenta.Mostrar();
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

        private void Botones()
        {
            if (TxtEditar.Text == "Nuevo")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnGenerar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;

                BtnAnterior.Enabled = false;
                BtnPrimero.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnUltimo.Enabled = false;
                BtnListar.Enabled = false;

            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnGenerar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;

                BtnAnterior.Enabled = false;
                BtnPrimero.Enabled = false;
                BtnSiguiente.Enabled = false;
                BtnUltimo.Enabled = false;
                BtnListar.Enabled = false;

            }
            else if (TxtEditar.Text == "Listar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnGenerar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnImprimir.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true ;
                BtnListar.Enabled = true;
            }
        }

        private void Limpiar()
        {
            if (ChkCopiar.Checked == true)
            {
                TxtCod_cuenta.Text = String.Empty;
                ChkCopiar.Checked = false;
            }
            else
            {
                TxtCod_cuenta.Text = String.Empty;
                TxtDesc_cuenta.Text = String.Empty;
                TxtTipocuenta.Text = "Corriente";
                TxtNumcuenta.Text = String.Empty;
                TxtCod_banco.Text = String.Empty;
                TxtDesc_banco.Text = String.Empty;
                TxtCod_moneda.Text = String.Empty;
                TxtDesc_moneda.Text = String.Empty;
                TxtResponsable.Text = String.Empty;
                TxtAgencia.Text = String.Empty;
                TxtEjecutivo.Text = String.Empty;
                TxtDireccion.Text = String.Empty;
                TxtTelefono.Text = String.Empty;
                TxtEmail.Text = String.Empty;
                TxtSaldod.Text = String.Empty;
                TxtSaldoh.Text = String.Empty;
                TxtSaldo.Text = String.Empty;
                TxtFecha_reg.Text = String.Empty;
                TxtFecharegcheq.Text = String.Empty;
                TxtActiva.Text = true.ToString();
                TxtChequera.Text = false.ToString();
                TxtCampo1.Text = String.Empty;
                TxtCampo2.Text = String.Empty;
                TxtCampo3.Text = String.Empty;
                TxtCampo4.Text = String.Empty;
                TxtCampo5.Text = String.Empty;
                TxtCampo6.Text = String.Empty;
                Top_serie(); 
            }
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
                Ds = ECuenta.Listar();

                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtCod_cuentav.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTipocuenta.Text = Ds.Tables[0].Rows[0]["tipocuenta"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtAgencia.Text = Ds.Tables[0].Rows[0]["agencia"].ToString();
                TxtEjecutivo.Text = Ds.Tables[0].Rows[0]["ejecutivo"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                TxtSaldod.Text = Ds.Tables[0].Rows[0]["saldod"].ToString();
                TxtSaldoh.Text = Ds.Tables[0].Rows[0]["saldoh"].ToString();
                TxtSaldo.Text = Ds.Tables[0].Rows[0]["saldo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecharegcheq.Text = Ds.Tables[0].Rows[0]["fecharegcheq"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Ex)
            {
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_cuenta.Focus();
                string rpta = Ex.Message;
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }
        }

        private void EventosTextBox()
        {
            if (TxtActiva.Text == true.ToString())
            {
                ChkActiva.CheckState = CheckState.Checked;
            }
            else
            {
                ChkActiva.CheckState = CheckState.Unchecked;
            }

            if (TxtChequera.Text == true.ToString())
            {
                ChkChequera.CheckState = CheckState.Checked;
                TxtFecharegcheq.Enabled = true;
                BtnDetCheq.Enabled = true;
            }
            else
            {
                ChkChequera.CheckState = CheckState.Unchecked;
                TxtFecharegcheq.Enabled = false;
                BtnDetCheq.Enabled = false;
            }
        }

        private void EventosChk()
        {
            if (ChkActiva.Checked == true)
            {
                TxtActiva.Text = true.ToString();
            }
            else
            {
                TxtActiva.Text = false.ToString();
            }

            if(ChkChequera.Checked==true)
            {
                TxtChequera.Text = true.ToString();
            }
            else
            {
                TxtChequera.Text = false.ToString();
            }
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_cuenta.Text == string.Empty || TxtDesc_cuenta.Text == string.Empty || TxtCod_moneda.Text == string.Empty || TxtCod_banco.Text == string.Empty || TxtNumcuenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_cuenta, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_cuenta, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_moneda, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_banco, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtNumcuenta, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = ECuenta.Insertar(TxtCod_cuenta.Text.Trim(), TxtDesc_cuenta.Text.Trim(), TxtCod_banco.Text.Trim(), TxtCod_moneda.Text.Trim(), TxtTipocuenta.Text.Trim(), TxtNumcuenta.Text.Trim(), TxtResponsable.Text.Trim(), TxtAgencia.Text.Trim(), TxtEjecutivo.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim(), Convert.ToDecimal(TxtSaldod.Text), Convert.ToDecimal(TxtSaldoh.Text), Convert.ToDecimal(TxtSaldo.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecharegcheq.Text), Convert.ToBoolean(TxtActiva.Text), Convert.ToBoolean(TxtChequera.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = ECuenta.Editar(TxtCod_cuenta.Text.Trim(), TxtCod_cuentav.Text.Trim(), TxtDesc_cuenta.Text.Trim(), TxtCod_banco.Text.Trim(), TxtCod_moneda.Text.Trim(), TxtTipocuenta.Text.Trim(), TxtNumcuenta.Text.Trim(), TxtResponsable.Text.Trim(), TxtAgencia.Text.Trim(), TxtEjecutivo.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim(), Convert.ToDecimal(TxtSaldod.Text), Convert.ToDecimal(TxtSaldoh.Text), Convert.ToDecimal(TxtSaldo.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecharegcheq.Text), Convert.ToBoolean(TxtActiva.Text), Convert.ToBoolean(TxtChequera.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_cuentav.Text = TxtCod_cuenta.Text;
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
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void GenerarCod()
        {
            try
            {
                int rpta = Convert.ToInt32(ECuenta.GenerarCod(TxtCod_cuenta.Text));
                TxtCod_cuenta.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_cuenta.Focus();
            }
        }

        internal void SetCuenta(string cod_cuenta, string desc_cuenta, string cod_banco, string desc_banco, string cod_moneda, string desc_moneda, string tipocuenta, string numcuenta, string responsable, string agencia, string ejecutivo, string direccion, string telefono, string email, string saldod, string saldoh, string saldo, string fechareg, string fecharegcheq, string activa, string chequera, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtCod_cuentav.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtTipocuenta.Text = tipocuenta;
            TxtNumcuenta.Text = numcuenta;
            TxtResponsable.Text = responsable;
            TxtAgencia.Text = agencia;
            TxtEjecutivo.Text = ejecutivo;
            TxtDireccion.Text = direccion;
            TxtTelefono.Text = telefono;
            TxtEmail.Text = email;
            TxtSaldod.Text = saldod;
            TxtSaldoh.Text = saldoh;
            TxtSaldo.Text = saldo;
            TxtFecha_reg.Text = fechareg;
            TxtFecharegcheq.Text = fecharegcheq;
            TxtActiva.Text = activa;
            TxtChequera.Text = chequera;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetBanco(string cod_banco, string desc_banco, string cod_moneda, string desc_moneda)
        {
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        internal void SetMoneda(string cod_moneda, string desc_moneda)
        {
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        private void FCuenta_Load(object sender, EventArgs e)
        {
            Text = "...::: Cuentas :::...";
            MostraUsuario();
            Listar();
            EventosTextBox();
            EventosChk();
            TxtTipocuenta.Items.AddRange(new object[] { "Corriente", "Ahorro", "Inversiones", "Otros" });
        }

        private void FCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo" && (TxtCod_cuenta.Text!=String.Empty || TxtDesc_cuenta.Text != String.Empty))
            {
                Opcion = MessageBox.Show("Desea Guardar el Registro antes de Salir? ", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Guardar();
                }
            }
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
            TxtCod_cuenta.Focus();
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
                    Rpta = ECuenta.Eliminar(TxtCod_cuenta.Text);

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
            FCuentaLista Listado = new FCuentaLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptCuenta Reporte = new FRptCuenta();
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
                Ds = ECuenta.Primero();

                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtCod_cuentav.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTipocuenta.Text = Ds.Tables[0].Rows[0]["tipocuenta"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtAgencia.Text = Ds.Tables[0].Rows[0]["agencia"].ToString();
                TxtEjecutivo.Text = Ds.Tables[0].Rows[0]["ejecutivo"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                TxtSaldod.Text = Ds.Tables[0].Rows[0]["saldod"].ToString();
                TxtSaldoh.Text = Ds.Tables[0].Rows[0]["saldoh"].ToString();
                TxtSaldo.Text = Ds.Tables[0].Rows[0]["saldo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecharegcheq.Text = Ds.Tables[0].Rows[0]["fecharegcheq"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
                Ds = ECuenta.Anterior(TxtCod_cuenta.Text);

                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtCod_cuentav.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTipocuenta.Text = Ds.Tables[0].Rows[0]["tipocuenta"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtAgencia.Text = Ds.Tables[0].Rows[0]["agencia"].ToString();
                TxtEjecutivo.Text = Ds.Tables[0].Rows[0]["ejecutivo"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                TxtSaldod.Text = Ds.Tables[0].Rows[0]["saldod"].ToString();
                TxtSaldoh.Text = Ds.Tables[0].Rows[0]["saldoh"].ToString();
                TxtSaldo.Text = Ds.Tables[0].Rows[0]["saldo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecharegcheq.Text = Ds.Tables[0].Rows[0]["fecharegcheq"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
                Ds = ECuenta.Siguiente(TxtCod_cuenta.Text);

                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtCod_cuentav.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTipocuenta.Text = Ds.Tables[0].Rows[0]["tipocuenta"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtAgencia.Text = Ds.Tables[0].Rows[0]["agencia"].ToString();
                TxtEjecutivo.Text = Ds.Tables[0].Rows[0]["ejecutivo"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                TxtSaldod.Text = Ds.Tables[0].Rows[0]["saldod"].ToString();
                TxtSaldoh.Text = Ds.Tables[0].Rows[0]["saldoh"].ToString();
                TxtSaldo.Text = Ds.Tables[0].Rows[0]["saldo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecharegcheq.Text = Ds.Tables[0].Rows[0]["fecharegcheq"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
                Ds = ECuenta.Ultimo();

                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtCod_cuentav.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTipocuenta.Text = Ds.Tables[0].Rows[0]["tipocuenta"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtAgencia.Text = Ds.Tables[0].Rows[0]["agencia"].ToString();
                TxtEjecutivo.Text = Ds.Tables[0].Rows[0]["ejecutivo"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                TxtSaldod.Text = Ds.Tables[0].Rows[0]["saldod"].ToString();
                TxtSaldoh.Text = Ds.Tables[0].Rows[0]["saldoh"].ToString();
                TxtSaldo.Text = Ds.Tables[0].Rows[0]["saldo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecharegcheq.Text = Ds.Tables[0].Rows[0]["fecharegcheq"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtChequera.Text = Ds.Tables[0].Rows[0]["chequera"].ToString();
                TxtActiva.Text = Ds.Tables[0].Rows[0]["activa"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
        private void TxtCod_moneda_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtResponsable_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtSaldoefectivo_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtSaldodocumento_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtSaldototal_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void ChkActiva_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }


        private void ChkChequera_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void TxtActiva_TextChanged(object sender, EventArgs e)
        {
            EventosTextBox();
            CambiosTexBox();
        }

        private void TxtChequera_TextChanged(object sender, EventArgs e)
        {
            EventosTextBox();
            CambiosTexBox();
        }

        private void TxtCod_cuenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_cuenta_TextChanged(object sender, EventArgs e)
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

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void TxtTipocuenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_banco_Validating(object sender, CancelEventArgs e)
        {
            DataTable Dt = ECuenta.Mostrar();
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                foreach (DataRow row in Dt.Rows)
                {
                    if (Convert.ToString(row["numcuenta"].ToString()).Equals(TxtNumcuenta.Text) &&
                        Convert.ToString(row["cod_banco"].ToString()).Equals(TxtCod_banco.Text))
                    {
                        MensajeError("Numero de Cuenta Duplicado para el Banco a Registrar");
                        ErrorTexto.SetError(TxtNumcuenta, "Verifique!");
                    }
                }
            }
        }

        private void TxtNumcuenta_Validating(object sender, CancelEventArgs e)
        {
            DataTable Dt = ECuenta.Mostrar();
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                foreach (DataRow row in Dt.Rows)
                {
                    if (Convert.ToString(row["numcuenta"].ToString()).Equals(TxtNumcuenta.Text) &&
                        Convert.ToString(row["cod_banco"].ToString()).Equals(TxtCod_banco.Text))
                    {
                        MensajeError("Numero de Cuenta Duplicado para el Banco a Registrar");
                        ErrorTexto.SetError(TxtNumcuenta, "Verifique!");
                    }
                }
            }
        }

        private void TxtNumcuenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_banco_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecharegcheq_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtAgencia_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEjecutivo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }


        #endregion

        private void TxtCod_moneda_DoubleClick(object sender, EventArgs e)
        {
            FMonedaLista Listado = new FMonedaLista();
            Dt = EMoneda.Mostrar();
            if (Dt.Rows.Count > 0)
            {
                Listado.TxtFlag = "Cuenta";
                Listado.ShowDialog();
            }
            else if (Dt.Rows.Count == 0)
            {
                MensajeError("No existen Registros Disponibles!");
            }
        }

        private void TxtCod_moneda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F12)
            {
                FMonedaLista Listado = new FMonedaLista();
                Dt = EMoneda.Mostrar();
                if (Dt.Rows.Count > 0)
                {
                    Listado.TxtFlag = "Cuenta";
                    Listado.ShowDialog();
                }
                else if (Dt.Rows.Count == 0)
                {
                    MensajeError("No existen Registros Disponibles!");
                }
            }
        }

        private void TxtCod_banco_DoubleClick(object sender, EventArgs e)
        {
            FBancoLista Listado = new FBancoLista();
            Dt = EBanco.Mostrar();
            if (Dt.Rows.Count > 0)
            {
                Listado.TxtFlag = "Cuenta";
                Listado.ShowDialog();
            }
            else if (Dt.Rows.Count == 0)
            {
                MensajeError("No existen Registros Disponibles!");
            }
        }

        private void TxtCod_banco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FBancoLista Listado = new FBancoLista();
                Dt = EBanco.Mostrar();
                if (Dt.Rows.Count > 0)
                {
                    Listado.TxtFlag = "Cuenta";
                    Listado.ShowDialog();
                }
                else if (Dt.Rows.Count == 0)
                {
                    MensajeError("No existen Registros Disponibles!");
                }
            }
        }
    }
}
