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

namespace Presentacion.ModuloVenta
{
    public partial class FVendedor : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FVendedor _Instancia;

        public static FVendedor GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FVendedor();
            }
            return _Instancia;
        }

        public FVendedor()
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
            Dt = EVendedor.Mostrar();
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
            TxtCod_vendedor.Text = String.Empty;
            TxtDesc_vendedor.Text = String.Empty;
            TxtRif.Text = String.Empty;
            TxtTelefono.Text = String.Empty;
            TxtDireccion.Text = String.Empty;
            TxtNivel.Text = "A";
            TxtComisionventa.Text = String.Empty;
            TxtComisioncobro.Text = String.Empty;
            TxtTventas_item.Text = String.Empty;
            TxtTventas_monto.Text = String.Empty;
            TxtFecha_reg.Text = String.Empty;
            TxtCobra.Text = false.ToString();
            TxtVenta.Text = false.ToString();
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
                Ds = EVendedor.Listar();

                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtCod_vendedorv.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["desc_vendedor"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtNivel.Text = Ds.Tables[0].Rows[0]["nivel"].ToString();
                TxtComisionventa.Text = Ds.Tables[0].Rows[0]["comisionventa"].ToString();
                TxtComisioncobro.Text = Ds.Tables[0].Rows[0]["comisioncobro"].ToString();
                TxtTventas_item.Text = Ds.Tables[0].Rows[0]["tventas_item"].ToString();
                TxtTventas_monto.Text = Ds.Tables[0].Rows[0]["tventas_monto"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCobra.Text = Ds.Tables[0].Rows[0]["cobra"].ToString();
                TxtVenta.Text = Ds.Tables[0].Rows[0]["venta"].ToString();
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
                TxtCod_vendedor.Focus();
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

                if (TxtCod_vendedor.Text == string.Empty || TxtDesc_vendedor.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_vendedor, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_vendedor, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EVendedor.Insertar(TxtCod_vendedor.Text.Trim().ToUpper(), TxtDesc_vendedor.Text.Trim(), TxtRif.Text.Trim(), TxtTelefono.Text.Trim(), TxtDireccion.Text.Trim(), TxtNivel.Text.Trim(), Convert.ToDecimal(TxtComisionventa.Text), Convert.ToDecimal(TxtComisioncobro.Text), Convert.ToDecimal(TxtTventas_item.Text), Convert.ToDecimal(TxtTventas_monto.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtCobra.Text), Convert.ToBoolean(TxtVenta.Text), Convert.ToBoolean(TxtActivo.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EVendedor.Editar(TxtCod_vendedor.Text.Trim().ToUpper(), TxtCod_vendedorv.Text, TxtDesc_vendedor.Text.Trim(), TxtRif.Text.Trim(), TxtTelefono.Text.Trim(), TxtDireccion.Text.Trim(), TxtNivel.Text.Trim(), Convert.ToDecimal(TxtComisionventa.Text), Convert.ToDecimal(TxtComisioncobro.Text), Convert.ToDecimal(TxtTventas_item.Text), Convert.ToDecimal(TxtTventas_monto.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtCobra.Text), Convert.ToBoolean(TxtVenta.Text), Convert.ToBoolean(TxtActivo.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_vendedorv.Text = TxtCod_vendedor.Text;
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
                int rpta = Convert.ToInt32(EVendedor.GenerarCod(TxtCod_vendedor.Text));
                TxtCod_vendedor.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_vendedor.Focus();
            }
        }

        internal void SetVendedor(string cod_vendedor, string desc_vendedor,string  rif, string telefono, string direccion, string nivel, string comisionventa, string comisioncobro, string tventas_item, string tventas_monto, string fecha_reg, string cobra, string venta, string activo, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_vendedor.Text = cod_vendedor;
            TxtCod_vendedorv.Text = cod_vendedor;
            TxtDesc_vendedor.Text = desc_vendedor;
            TxtRif.Text = rif;
            TxtTelefono.Text = telefono;
            TxtDireccion.Text = direccion;
            TxtNivel.Text = nivel;
            TxtComisionventa.Text = comisionventa;
            TxtComisioncobro.Text = comisioncobro;
            TxtTventas_item.Text = tventas_item;
            TxtTventas_monto.Text = tventas_monto;
            TxtFecha_reg.Text = fecha_reg;
            TxtCobra.Text = cobra;
            TxtVenta.Text = venta;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        private void EventoNivel()
        {
            TxtNivel.Items.AddRange(new object[] { "A", "B", "C", "D" });

        }

        private void EventoTexBox()
        {

            if (TxtCobra.Text == true.ToString())
            {
                ChkCobra.CheckState = CheckState.Checked;
            }
            else
            {
                ChkCobra.CheckState = CheckState.Unchecked;
            }


            if (TxtVenta.Text == true.ToString())
            {
                ChkVenta.CheckState = CheckState.Checked;
            }
            else
            {
                ChkVenta.CheckState = CheckState.Unchecked;
            }

            if (TxtActivo.Text == true.ToString())
            {
                ChkActivo.CheckState = CheckState.Checked;
            }
            else
            {
                ChkActivo.CheckState = CheckState.Unchecked;
            }
        }

        private void EventoChk()
        {
            if (ChkActivo.CheckState == CheckState.Checked)
            {
                TxtActivo.Text = true.ToString();
            }
            else
            {
                TxtActivo.Text = false.ToString();
            }


            if (ChkVenta.CheckState == CheckState.Checked)
            {
                TxtVenta.Text = true.ToString();
            }
            else
            {
                TxtVenta.Text = false.ToString();
            }

            if (ChkCobra.CheckState == CheckState.Checked)
            {
                TxtCobra.Text = true.ToString();
            }
            else
            {
                TxtCobra.Text = false.ToString();
            }

        }

        private void FVendedor_Load(object sender, EventArgs e)
        {
            Text = "...::: Vendedor :::...";
            MostraUsuario();
            EventoTexBox();
            EventoChk();
            Listar();
            EventoNivel();
        }

        private void FVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FVendedor_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_vendedor.Focus();
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
                    Rpta = EVendedor.Eliminar(TxtCod_vendedor.Text);

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
            FVendedorLista Listado = new FVendedorLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptVendedor Reporte = new FRptVendedor();
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
                Ds = EVendedor.Primero();

                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtCod_vendedorv.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["desc_vendedor"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtNivel.Text = Ds.Tables[0].Rows[0]["nivel"].ToString();
                TxtComisionventa.Text = Ds.Tables[0].Rows[0]["comisionventa"].ToString();
                TxtComisioncobro.Text = Ds.Tables[0].Rows[0]["comisioncobro"].ToString();
                TxtTventas_item.Text = Ds.Tables[0].Rows[0]["tventas_item"].ToString();
                TxtTventas_monto.Text = Ds.Tables[0].Rows[0]["tventas_monto"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCobra.Text = Ds.Tables[0].Rows[0]["cobra"].ToString();
                TxtVenta.Text = Ds.Tables[0].Rows[0]["venta"].ToString();
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
                Ds = EVendedor.Anterior(TxtCod_vendedor.Text);

                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtCod_vendedorv.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["desc_vendedor"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtNivel.Text = Ds.Tables[0].Rows[0]["nivel"].ToString();
                TxtComisionventa.Text = Ds.Tables[0].Rows[0]["comisionventa"].ToString();
                TxtComisioncobro.Text = Ds.Tables[0].Rows[0]["comisioncobro"].ToString();
                TxtTventas_item.Text = Ds.Tables[0].Rows[0]["tventas_item"].ToString();
                TxtTventas_monto.Text = Ds.Tables[0].Rows[0]["tventas_monto"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCobra.Text = Ds.Tables[0].Rows[0]["cobra"].ToString();
                TxtVenta.Text = Ds.Tables[0].Rows[0]["venta"].ToString();
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
                Ds = EVendedor.Siguiente(TxtCod_vendedor.Text);

                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtCod_vendedorv.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["desc_vendedor"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtNivel.Text = Ds.Tables[0].Rows[0]["nivel"].ToString();
                TxtComisionventa.Text = Ds.Tables[0].Rows[0]["comisionventa"].ToString();
                TxtComisioncobro.Text = Ds.Tables[0].Rows[0]["comisioncobro"].ToString();
                TxtTventas_item.Text = Ds.Tables[0].Rows[0]["tventas_item"].ToString();
                TxtTventas_monto.Text = Ds.Tables[0].Rows[0]["tventas_monto"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCobra.Text = Ds.Tables[0].Rows[0]["cobra"].ToString();
                TxtVenta.Text = Ds.Tables[0].Rows[0]["venta"].ToString();
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
                Ds = EVendedor.Ultimo();

                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtCod_vendedorv.Text = Ds.Tables[0].Rows[0]["cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["desc_vendedor"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["rif"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["direccion"].ToString();
                TxtNivel.Text = Ds.Tables[0].Rows[0]["nivel"].ToString();
                TxtComisionventa.Text = Ds.Tables[0].Rows[0]["comisionventa"].ToString();
                TxtComisioncobro.Text = Ds.Tables[0].Rows[0]["comisioncobro"].ToString();
                TxtTventas_item.Text = Ds.Tables[0].Rows[0]["tventas_item"].ToString();
                TxtTventas_monto.Text = Ds.Tables[0].Rows[0]["tventas_monto"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCobra.Text = Ds.Tables[0].Rows[0]["cobra"].ToString();
                TxtVenta.Text = Ds.Tables[0].Rows[0]["venta"].ToString();
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
        private void TxtCod_vendedor_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_vendedor_TextChanged(object sender, EventArgs e)
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
            EventoTexBox();
        }

        private void TxtRif_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtVenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventoTexBox();
        }

        private void TxtCobra_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventoTexBox();
        }

        private void TxtTventas_item_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtComisionventa_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtTventas_monto_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtComisioncobro_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void ChkCobra_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkVenta_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkActivo_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        #endregion


    }
}
