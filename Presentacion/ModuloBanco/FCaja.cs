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
    public partial class FCaja : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FCaja _Instancia;

        public static FCaja GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FCaja();
            }
            return _Instancia;
        }

        public FCaja()
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
            Dt = ECaja.Mostrar();
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
                BtnUltimo.Enabled = true;
                BtnListar.Enabled = true;
            }
        }

        private void Limpiar()
        {
            TxtCod_caja.Text = String.Empty;
            TxtDesc_caja.Text = String.Empty;
            TxtCod_moneda.Text = String.Empty;
            TxtDesc_moneda.Text = String.Empty;
            TxtActiva.Text = false.ToString();
            TxtResponsable.Text = String.Empty;
            TxtFecha_reg.Text = String.Empty;
            TxtSaldoefectivo.Text = String.Empty;
            TxtSaldodocumento.Text = String.Empty;
            TxtSaldototal.Text = String.Empty;
            TxtCampo1.Text = String.Empty;
            TxtCampo2.Text = String.Empty;
            TxtCampo3.Text = String.Empty;
            TxtCampo4.Text = String.Empty;
            TxtCampo5.Text = String.Empty;
            TxtCampo6.Text = String.Empty;
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
                Ds = ECaja.Listar();

                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtCod_cajav.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtSaldoefectivo.Text = Ds.Tables[0].Rows[0]["saldoefectivo"].ToString();
                TxtSaldodocumento.Text = Ds.Tables[0].Rows[0]["saldodocumento"].ToString();
                TxtSaldototal.Text = Ds.Tables[0].Rows[0]["saldototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                TxtCod_caja.Focus();
                string rpta = Ex.Message;
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }
        }

        private void EventosChk()
        {
            if (TxtActiva.Text == true.ToString())
            {
                ChkActiva.CheckState = CheckState.Checked;
            }
            else
            {
                ChkActiva.CheckState = CheckState.Unchecked;
            }
        }

        private void EventosTextBox()
        {
            if (ChkActiva.Checked == true)
            {
                TxtActiva.Text = true.ToString();
            }
            else
            {
                TxtActiva.Text = false.ToString();
            }
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_caja.Text == string.Empty || TxtDesc_caja.Text == string.Empty || TxtCod_moneda.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_caja, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_caja, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_moneda, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = ECaja.Insertar(TxtCod_caja.Text.Trim().ToUpper(), TxtDesc_caja.Text.Trim(), TxtCod_moneda.Text, TxtResponsable.Text, Convert.ToDecimal(TxtSaldoefectivo.Text), Convert.ToDecimal(TxtSaldodocumento.Text), Convert.ToDecimal(TxtSaldototal.Text), Convert.ToDateTime(TxtFecha_reg.Value), Convert.ToBoolean(TxtActiva.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = ECaja.Editar(TxtCod_caja.Text.Trim().ToUpper(), TxtCod_cajav.Text, TxtDesc_caja.Text.Trim(), TxtCod_moneda.Text, TxtResponsable.Text, Convert.ToDecimal(TxtSaldoefectivo.Text), Convert.ToDecimal(TxtSaldodocumento.Text), Convert.ToDecimal(TxtSaldototal.Text), Convert.ToDateTime(TxtFecha_reg.Value), Convert.ToBoolean(TxtActiva.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_cajav.Text = TxtCod_caja.Text;
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
                int rpta = Convert.ToInt32(ECaja.GenerarCod(TxtCod_caja.Text));
                TxtCod_caja.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_caja.Focus();
            }
        }

        internal void SetCaja(string cod_caja, string desc_caja, string cod_moneda, string desc_moneda,string responsable, string saldoefectivo,string saldodocumento,string saldototal,string fecha_reg, string activa, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_caja.Text = cod_caja;
            TxtCod_cajav.Text = cod_caja;
            TxtDesc_caja.Text = desc_caja;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtResponsable.Text = responsable;
            TxtSaldoefectivo.Text = saldoefectivo;
            TxtSaldodocumento.Text = saldodocumento;
            TxtSaldototal.Text = saldototal;
            TxtFecha_reg.Text = fecha_reg;
            TxtActiva.Text = activa;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetMoneda(string cod_moneda, string desc_moneda)
        {
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        private void FCaja_Load(object sender, EventArgs e)
        {
            Text = "...::: Cajas :::...";
            MostraUsuario();
            Listar();
        }

        private void FCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FCaja_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_caja.Focus();
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
                    Rpta = ECaja.Eliminar(TxtCod_caja.Text);

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
            FCajaLista Listado = new FCajaLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptCaja Reporte = new FRptCaja();
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
                Ds = ECaja.Primero();

                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtCod_cajav.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtSaldoefectivo.Text = Ds.Tables[0].Rows[0]["saldoefectivo"].ToString();
                TxtSaldodocumento.Text = Ds.Tables[0].Rows[0]["saldodocumento"].ToString();
                TxtSaldototal.Text = Ds.Tables[0].Rows[0]["saldototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                Ds = ECaja.Anterior(TxtCod_caja.Text);

                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtCod_cajav.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtSaldoefectivo.Text = Ds.Tables[0].Rows[0]["saldoefectivo"].ToString();
                TxtSaldodocumento.Text = Ds.Tables[0].Rows[0]["saldodocumento"].ToString();
                TxtSaldototal.Text = Ds.Tables[0].Rows[0]["saldototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                Ds = ECaja.Siguiente(TxtCod_caja.Text);

                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtCod_cajav.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtSaldoefectivo.Text = Ds.Tables[0].Rows[0]["saldoefectivo"].ToString();
                TxtSaldodocumento.Text = Ds.Tables[0].Rows[0]["saldodocumento"].ToString();
                TxtSaldototal.Text = Ds.Tables[0].Rows[0]["saldototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                Ds = ECaja.Ultimo();

                TxtCod_caja.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtCod_cajav.Text = Ds.Tables[0].Rows[0]["cod_caja"].ToString();
                TxtDesc_caja.Text = Ds.Tables[0].Rows[0]["desc_caja"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtSaldoefectivo.Text = Ds.Tables[0].Rows[0]["saldoefectivo"].ToString();
                TxtSaldodocumento.Text = Ds.Tables[0].Rows[0]["saldodocumento"].ToString();
                TxtSaldototal.Text = Ds.Tables[0].Rows[0]["saldototal"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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

        private void TxtActiva_TextChanged(object sender, EventArgs e)
        {
            EventosTextBox();
            CambiosTexBox();
        }

        private void TxtCod_caja_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_caja_TextChanged(object sender, EventArgs e)
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

        #endregion

        private void TxtCod_moneda_DoubleClick(object sender, EventArgs e)
        {
            FMonedaLista Listado = new FMonedaLista();
            Dt = EMoneda.Mostrar();
            if (Dt.Rows.Count > 0)
            {
                Listado.TxtFlag = "Caja";
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
                    Listado.TxtFlag = "Caja";
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
