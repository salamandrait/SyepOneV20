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
    public partial class FBeneficiario : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FBeneficiario _Instancia;

        public static FBeneficiario GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FBeneficiario();
            }
            return _Instancia;
        }

        public FBeneficiario()
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
            Dt = EBeneficiario.Mostrar();
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
            TxtCod_beneficiario.Text = string.Empty;
            TxtDesc_beneficiario.Text = string.Empty;
            TxtCod_islr.Text = "PJD";
            TxtRif.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtActivo.Text = true.ToString();
            TxtFecha_reg.Text = string.Empty;
            TxtCampo1.Text = string.Empty;
            TxtCampo2.Text = string.Empty;
            TxtCampo3.Text = string.Empty;
            TxtCampo4.Text = string.Empty;
            TxtCampo5.Text = string.Empty;
            TxtCampo6.Text = string.Empty;
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
                Ds = EBeneficiario.Listar();

                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtCod_beneficiariov.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                TxtCod_beneficiario.Focus();
                string rpta = Ex.Message;
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }
        }

        private void EventosChk()
        {
            if (TxtActivo.Text == true.ToString())
            {
                ChkActivo.CheckState = CheckState.Checked;
            }
            else
            {
                ChkActivo.CheckState = CheckState.Unchecked;
            }
        }

        private void EventosTextBox()
        {
            if (ChkActivo.Checked == true)
            {
                TxtActivo.Text = true.ToString();
            }
            else
            {
                TxtActivo.Text = false.ToString();
            }
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_beneficiario.Text == string.Empty || TxtDesc_beneficiario.Text == string.Empty || TxtCod_islr.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_beneficiario, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_beneficiario, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_islr, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EBeneficiario.Insertar(TxtCod_beneficiario.Text.Trim().ToUpper(),TxtCod_islr.Text.Trim().ToUpper(), TxtDesc_beneficiario.Text.Trim(), TxtRif.Text, TxtDireccion.Text, TxtTelefono.Text, Convert.ToBoolean(TxtActivo.Text), Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EBeneficiario.Editar(TxtCod_beneficiario.Text.Trim().ToUpper(), TxtCod_beneficiario.Text.Trim().ToUpper(), TxtCod_islr.Text.Trim().ToUpper(), TxtDesc_beneficiario.Text.Trim(), TxtRif.Text, TxtDireccion.Text, TxtTelefono.Text, Convert.ToBoolean(TxtActivo.Text), Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_beneficiariov.Text = TxtCod_beneficiario.Text;
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
                int rpta = Convert.ToInt32(EBeneficiario.GenerarCod(TxtCod_beneficiario.Text));
                TxtCod_beneficiario.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_beneficiario.Focus();
            }
        }

        private void EventoCHK()
        {
            if (ChkActivo.Checked == true)
            {
                TxtActivo.Text = true.ToString();
            }
            else
            {
                TxtActivo.Text = false.ToString();
            }
        }

        private void EventoTextBox()
        {
            if (TxtActivo.Text == true.ToString())
            {
                ChkActivo.Checked = true;
            }
            else
            {
                ChkActivo.Checked = false;
            }
        }

        private void SelectDB()
        {
            DataSet DsI = EIslr.MostrarCB(TxtCod_islr.Text);
            TxtDesc_islr.Text = DsI.Tables[0].Rows[0]["desc_islr"].ToString();
        }

        private void EventoComboBOX()
        {
            Dt = EIslr.Mostrar();
            for (int i = 0; i <= Convert.ToInt32(Dt.Rows.Count) - 1; i++)
            {
                TxtCod_islr.Items.Add(Dt.Rows[i][0].ToString());
            }
        }

        internal void SetBeneficiario(string cod_beneficiario, string desc_beneficiario, string cod_islr, string desc_islr, string rif, string direccion, string telefono, string activo, string fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_beneficiario.Text = cod_beneficiario;
            TxtCod_beneficiariov.Text = cod_beneficiario;
            TxtDesc_beneficiario.Text = desc_beneficiario;
            TxtCod_islr.Text = cod_islr;
            TxtDesc_islr.Text = desc_islr;
            TxtRif.Text = rif;
            TxtDireccion.Text = direccion;
            TxtTelefono.Text = telefono;
            TxtActivo.Text = activo;
            TxtFecha_reg.Text = fecha_reg;
            TxtActivo.Text = activo;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetIslr(string cod_islr, string desc_islr)
        {
            TxtCod_islr.Text = cod_islr;
            TxtDesc_islr.Text = desc_islr;
        }

        private void FBeneficiario_Load(object sender, EventArgs e)
        {
            Text = "...::: Beneficiarios :::...";
            MostraUsuario();
            Listar();
            EventoCHK();
            EventoTextBox();
            EventoComboBOX();
        }

        private void FBeneficiario_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FBeneficiario_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_beneficiario.Focus();
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
                    Rpta = EBeneficiario.Eliminar(TxtCod_beneficiario.Text);

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
            FBeneficiarioLista Listado = new FBeneficiarioLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptBeneficiario Reporte = new FRptBeneficiario();
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
                Ds = EBeneficiario.Primero();

                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtCod_beneficiariov.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                Ds = EBeneficiario.Anterior(TxtCod_beneficiario.Text);

                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtCod_beneficiariov.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                Ds = EBeneficiario.Siguiente(TxtCod_beneficiario.Text);

                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtCod_beneficiariov.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                Ds = EBeneficiario.Ultimo();

                TxtCod_beneficiario.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtCod_beneficiariov.Text = Ds.Tables[0].Rows[0]["cod_beneficiario"].ToString();
                TxtDesc_beneficiario.Text = Ds.Tables[0].Rows[0]["desc_beneficiario"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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

        private void TxtCod_beneficiario_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_beneficiario_TextChanged(object sender, EventArgs e)
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

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_islr_TextChanged(object sender, EventArgs e)
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
                Listado.TxtFlag = "Beneficiario";
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
                    Listado.TxtFlag = "Beneficiario";
                    Listado.ShowDialog();
                }
                else if (Dt.Rows.Count == 0)
                {
                    MensajeError("No existen Registros Disponibles!");
                }
            }
        }

        private void TxtCod_islr_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDB();
        }


    }
}
