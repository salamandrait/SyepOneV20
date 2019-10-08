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

namespace Presentacion.ModuloInventario
{
    public partial class FDeposito : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FDeposito _Instancia;

        public static FDeposito GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FDeposito();
            }
            return _Instancia;
        }

        public FDeposito()
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
            Dt = EDeposito.Mostrar();
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
            TxtCod_deposito.Text = String.Empty;
            TxtDesc_deposito.Text = String.Empty;
            TxtResp_deposito.Text = String.Empty;
            TxtUbicacion.Text = String.Empty;
            TxtFecha_reg.Text = String.Empty;
            TxtDireccion_adm.Text = String.Empty;
            TxtScompras.Text = false.ToString();
            TxtSventas.Text = false.ToString();
            TxtActivo.Text = true.ToString();
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
                Ds = EDeposito.Listar();

                TxtCod_deposito.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();
                TxtCod_depositov.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();
                TxtDesc_deposito.Text = Ds.Tables[0].Rows[0]["desc_deposito"].ToString();
                TxtResp_deposito.Text = Ds.Tables[0].Rows[0]["resp_deposito"].ToString();
                TxtUbicacion.Text = Ds.Tables[0].Rows[0]["ubicacion_deposito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtDireccion_adm.Text = Ds.Tables[0].Rows[0]["direccion_adm"].ToString();
                TxtScompras.Text = Ds.Tables[0].Rows[0]["scompras"].ToString();
                TxtSventas.Text = Ds.Tables[0].Rows[0]["sventas"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
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
                TxtCod_deposito.Focus();
                string rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                Show();
            }
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_deposito.Text == string.Empty || TxtDesc_deposito.Text == string.Empty || TxtResp_deposito.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_deposito, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_deposito, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtResp_deposito, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EDeposito.Insertar(TxtCod_deposito.Text.Trim().ToUpper(), TxtDesc_deposito.Text.Trim(), TxtResp_deposito.Text, TxtUbicacion.Text, Convert.ToDateTime(TxtFecha_reg.Text), TxtDireccion_adm.Text, Convert.ToBoolean(TxtScompras.Text), Convert.ToBoolean(TxtSventas.Text), Convert.ToBoolean(TxtActivo.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EDeposito.Editar(TxtCod_deposito.Text.Trim().ToUpper(), TxtCod_depositov.Text, TxtDesc_deposito.Text.Trim(), TxtResp_deposito.Text, TxtUbicacion.Text, Convert.ToDateTime(TxtFecha_reg.Text), TxtDireccion_adm.Text, Convert.ToBoolean(TxtScompras.Text), Convert.ToBoolean(TxtSventas.Text), Convert.ToBoolean(TxtActivo.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_depositov.Text = TxtCod_deposito.Text;
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
                int rpta = Convert.ToInt32(EDeposito.GenerarCod(TxtCod_deposito.Text));
                TxtCod_deposito.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_deposito.Focus();
            }
        }

        internal void SetDeposito(string cod_deposito, string desc_deposito, string resp_deposito, string ubicacion, string fecha_reg, string direccion_adm, string scompras, string sventas, string activo, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_deposito.Text = cod_deposito;
            TxtCod_depositov.Text = cod_deposito;
            TxtDesc_deposito.Text = desc_deposito;
            TxtResp_deposito.Text = resp_deposito;
            TxtUbicacion.Text = ubicacion;
            TxtFecha_reg.Text = fecha_reg;
            TxtDireccion_adm.Text = direccion_adm;
            TxtScompras.Text = scompras;
            TxtSventas.Text = sventas;
            TxtActivo.Text = activo;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        private void EventosTextBox()
        {
            if (TxtScompras.Text == true.ToString())
            {
                ChkScompras.Checked = true;
            }
            else
            {
                ChkScompras.Checked = false;
            }

            if (TxtSventas.Text == true.ToString())
            {
                ChkSventas.Checked = true;
            }
            else
            {
                ChkSventas.Checked = false;
            }

            if (TxtActivo.Text == true.ToString())
            {
                ChkActivo.Checked = true;
            }
            else
            {
                ChkActivo.Checked = false;
            }

        }

        private void EventosChk()
        {
            if (ChkActivo.Checked == true)
            {
                TxtActivo.Text = true.ToString();
            }
            else
            {
                TxtActivo.Text = false.ToString();
            }

            if (ChkSventas.Checked == true)
            {
                TxtSventas.Text = true.ToString();
            }
            else
            {
                TxtSventas.Text = false.ToString();
            }

            if (ChkScompras.Checked == true)
            {
                TxtScompras.Text = true.ToString();
            }
            else
            {
                TxtScompras.Text = false.ToString();
            }
        }

        private void FDeposito_Load(object sender, EventArgs e)
        {
            Text = "...::: Depositos :::...";
            MostraUsuario();
            Listar();
            EventosTextBox();
        }

        private void FDeposito_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FDeposito_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_deposito.Focus();
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
                    Rpta = EDeposito.Eliminar(TxtCod_deposito.Text);

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
            FDepositoLista Listado = new FDepositoLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptDeposito Reporte = new FRptDeposito();
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
                Ds = EDeposito.Primero();

                TxtCod_deposito.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();
                TxtDesc_deposito.Text = Ds.Tables[0].Rows[0]["desc_deposito"].ToString();
                TxtResp_deposito.Text = Ds.Tables[0].Rows[0]["resp_deposito"].ToString();
                TxtUbicacion.Text = Ds.Tables[0].Rows[0]["ubicacion_deposito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtDireccion_adm.Text = Ds.Tables[0].Rows[0]["direccion_adm"].ToString();
                TxtScompras.Text = Ds.Tables[0].Rows[0]["scompras"].ToString();
                TxtSventas.Text = Ds.Tables[0].Rows[0]["sventas"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_depositov.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();

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
                Ds = EDeposito.Anterior(TxtCod_deposito.Text);

                TxtCod_deposito.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();
                TxtDesc_deposito.Text = Ds.Tables[0].Rows[0]["desc_deposito"].ToString();
                TxtResp_deposito.Text = Ds.Tables[0].Rows[0]["resp_deposito"].ToString();
                TxtUbicacion.Text = Ds.Tables[0].Rows[0]["ubicacion_deposito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtDireccion_adm.Text = Ds.Tables[0].Rows[0]["direccion_adm"].ToString();
                TxtScompras.Text = Ds.Tables[0].Rows[0]["scompras"].ToString();
                TxtSventas.Text = Ds.Tables[0].Rows[0]["sventas"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_depositov.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();

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
                Ds = EDeposito.Siguiente(TxtCod_deposito.Text);

                TxtCod_deposito.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();
                TxtDesc_deposito.Text = Ds.Tables[0].Rows[0]["desc_deposito"].ToString();
                TxtResp_deposito.Text = Ds.Tables[0].Rows[0]["resp_deposito"].ToString();
                TxtUbicacion.Text = Ds.Tables[0].Rows[0]["ubicacion_deposito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtDireccion_adm.Text = Ds.Tables[0].Rows[0]["direccion_adm"].ToString();
                TxtScompras.Text = Ds.Tables[0].Rows[0]["scompras"].ToString();
                TxtSventas.Text = Ds.Tables[0].Rows[0]["sventas"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_depositov.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();

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
                Ds = EDeposito.Ultimo();

                TxtCod_deposito.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();
                TxtDesc_deposito.Text = Ds.Tables[0].Rows[0]["desc_deposito"].ToString();
                TxtResp_deposito.Text = Ds.Tables[0].Rows[0]["resp_deposito"].ToString();
                TxtUbicacion.Text = Ds.Tables[0].Rows[0]["ubicacion_deposito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtDireccion_adm.Text = Ds.Tables[0].Rows[0]["direccion_adm"].ToString();
                TxtScompras.Text = Ds.Tables[0].Rows[0]["scompras"].ToString();
                TxtSventas.Text = Ds.Tables[0].Rows[0]["sventas"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_depositov.Text = Ds.Tables[0].Rows[0]["cod_deposito"].ToString();

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
        private void TxtCod_deposito_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_deposito_TextChanged(object sender, EventArgs e)
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

        private void TxtActivo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTextBox();
        }

        private void TxtScompras_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTextBox();
        }

        private void TxtSventas_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTextBox();
        }

        private void ChkActivo_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkScompras_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkSventas_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void TxtResp_deposito_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDireccion_adm_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtUbicacion_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }
        #endregion


    }
}
