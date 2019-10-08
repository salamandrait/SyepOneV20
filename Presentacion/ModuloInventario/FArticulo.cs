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
    public partial class FArticulo : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FArticulo _Instancia;

        public static FArticulo GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FArticulo();
            }
            return _Instancia;
        }

        public FArticulo()
        {
            InitializeComponent();
            Alicuotas();
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
            Dt = EArticulo.Mostrar();
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

        private void Alicuotas()
        {
            DataTable DtImp = EImpuesto.Mostrar();
            for (int i = 0; i <= Convert.ToInt32(DtImp.Rows.Count) - 1; i++)
            {
                TxtDesc_impuesto.Items.Add(DtImp.Rows[i]["desc_impuesto"].ToString());
            }
        }

        private void MostrarAlicuotas()
        {
            DataSet DsImp = EImpuesto.ListarTasa(TxtDesc_impuesto.Text);
            TxtCod_impuesto.Text = DsImp.Tables[0].Rows[0]["cod_impuesto"].ToString();
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
            if (ChkCopiar.Checked == true)
            {
                TxtCod_articulo.Text = string.Empty;
                ChkCopiar.Checked = false;
            }
            else
            {
                TxtCod_articulo.Text = string.Empty;
                TxtDesc_articulo.Text = string.Empty;
                TxtTipo.Text = "Venta";
                TxtOrigen.Text = "Nacional";
                TxtItem.Text = string.Empty;
                TxtReferencia.Text = string.Empty;
                TxtModelo.Text = string.Empty;
                TxtGarantia.Text = string.Empty;
                TxtPunto_min.Text = string.Empty;
                TxtPunto_max.Text = string.Empty;
                TxtPunto_ped.Text = string.Empty;
                TxtPeso.Text = string.Empty;
                TxtVolumen.Text = string.Empty;
                TxtAlto.Text = string.Empty;
                TxtAncho.Text = string.Empty;
                TxtPuntos.Text = string.Empty;
                TxtPorcentaje.Text = string.Empty;
                TxtFecha_reg.Text = string.Empty;
                TxtActivo.Text = true.ToString();
                TxtEsserial.Text = false.ToString();
                TxtEslote.Text = false.ToString();
                TxtCampo1.Text = string.Empty;
                TxtCampo2.Text = string.Empty;
                TxtCampo3.Text = string.Empty;
                TxtCampo4.Text = string.Empty;
                TxtCampo5.Text = string.Empty;
                TxtCampo6.Text = string.Empty;

                TxtCod_categoria.Text = string.Empty;
                TxtDesc_categoria.Text = string.Empty;
                TxtDesc_linea.Text = string.Empty;
                TxtCod_linea.Text = string.Empty;
                TxtCod_sublinea.Text = string.Empty;
                TxtDesc_sublinea.Text = string.Empty;
                TxtCod_color.Text = string.Empty;
                TxtDesc_color.Text = string.Empty;
                TxtCod_ubicacion.Text = string.Empty;
                TxtDesc_ubicacion.Text = string.Empty;
                TxtDesc_impuesto.Text = "Tasa General";
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

            if (ChkEsserial.Checked == true)
            {
                TxtEsserial.Text = true.ToString();
            }
            else
            {
                TxtEsserial.Text = false.ToString();
            }

            if (ChkEslote.Checked == true)
            {
                TxtEslote.Text = true.ToString();
            }
            else
            {
                TxtEslote.Text = false.ToString();
            }
        }

        private void EventosTexBox()
        {
            if (TxtActivo.Text == true.ToString())
            {
                ChkActivo.Checked = true;
            }
            else
            {
                ChkActivo.Checked = false;
            }

            if (TxtEsserial.Text == true.ToString())
            {
                ChkEsserial.Checked = true;
            }
            else
            {
                ChkEsserial.Checked = false;
            }

            if (TxtEslote.Text == true.ToString())
            {
                ChkEslote.Checked = true;
            }
            else
            {
                ChkEslote.Checked = false;
            }
        }

        private void EventoCombo()
        {
            TxtTipo.Items.AddRange(new string[] { "Venta", "Servicio", "Fabricacion", "Materia Prima", "Empaque", "Uso Interno" });
            TxtOrigen.Items.AddRange(new string[] { "Nacional", "Importado", "Otro" });
            TxtTipo.TabIndex = 1;
            TxtOrigen.TabIndex = 1;
        }

        public void Listar()
        {
            try
            {
                Ds = EArticulo.Listar();

                TxtCod_articulo.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtCod_articulov.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtDesc_articulo.Text = Ds.Tables[0].Rows[0]["desc_articulo"].ToString();
                TxtTipo.Text = Ds.Tables[0].Rows[0]["tipo"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtItem.Text = Ds.Tables[0].Rows[0]["item"].ToString();
                TxtReferencia.Text = Ds.Tables[0].Rows[0]["referencia"].ToString();
                TxtModelo.Text = Ds.Tables[0].Rows[0]["modelo"].ToString();
                TxtGarantia.Text = Ds.Tables[0].Rows[0]["garantia"].ToString();
                TxtPunto_min.Text = Ds.Tables[0].Rows[0]["punto_min"].ToString();
                TxtPunto_max.Text = Ds.Tables[0].Rows[0]["punto_max"].ToString();
                TxtPunto_ped.Text = Ds.Tables[0].Rows[0]["punto_ped"].ToString();
                TxtPeso.Text = Ds.Tables[0].Rows[0]["peso"].ToString();
                TxtVolumen.Text = Ds.Tables[0].Rows[0]["volumen"].ToString();
                TxtAlto.Text = Ds.Tables[0].Rows[0]["alto"].ToString();
                TxtAncho.Text = Ds.Tables[0].Rows[0]["ancho"].ToString();
                TxtPorcentaje.Text = Ds.Tables[0].Rows[0]["porcentaje"].ToString();
                TxtPuntos.Text = Ds.Tables[0].Rows[0]["puntos"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtEsserial.Text = Ds.Tables[0].Rows[0]["esserial"].ToString();
                TxtEslote.Text = Ds.Tables[0].Rows[0]["eslote"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_categoria.Text = Ds.Tables[0].Rows[0]["cod_categoria"].ToString();
                TxtDesc_categoria.Text = Ds.Tables[0].Rows[0]["desc_categoria"].ToString();
                TxtCod_linea.Text = Ds.Tables[0].Rows[0]["cod_linea"].ToString();
                TxtDesc_linea.Text = Ds.Tables[0].Rows[0]["desc_linea"].ToString();
                TxtCod_sublinea.Text = Ds.Tables[0].Rows[0]["cod_sublinea"].ToString();
                TxtDesc_sublinea.Text = Ds.Tables[0].Rows[0]["desc_sublinea"].ToString();
                TxtCod_color.Text = Ds.Tables[0].Rows[0]["cod_color"].ToString();
                TxtDesc_color.Text = Ds.Tables[0].Rows[0]["desc_color"].ToString();
                TxtCod_ubicacion.Text = Ds.Tables[0].Rows[0]["cod_ubicacion"].ToString();
                TxtDesc_ubicacion.Text = Ds.Tables[0].Rows[0]["desc_ubicacion"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();
                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Ex)
            {
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_articulo.Focus();
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

                if (TxtCod_articulo.Text == string.Empty || TxtDesc_articulo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_articulo, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_articulo, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EArticulo.Insertar(TxtCod_articulo.Text.Trim(), TxtCod_categoria.Text, TxtCod_linea.Text, TxtCod_sublinea.Text, TxtCod_color.Text, TxtCod_ubicacion.Text, TxtCod_impuesto.Text, TxtDesc_articulo.Text, TxtTipo.Text, TxtOrigen.Text, TxtItem.Text, TxtReferencia.Text, TxtModelo.Text, TxtGarantia.Text, Convert.ToDecimal(TxtPunto_min.Text), Convert.ToDecimal(TxtPunto_max.Text), Convert.ToDecimal(TxtPunto_ped.Text), Convert.ToDecimal(TxtPeso.Text), Convert.ToDecimal(TxtVolumen.Text), Convert.ToDecimal(TxtAlto.Text), Convert.ToDecimal(TxtAncho.Text), Convert.ToDecimal(TxtPorcentaje.Text), Convert.ToDecimal(TxtPuntos.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtActivo.Text), Convert.ToBoolean(TxtEsserial.Text), Convert.ToBoolean(TxtEslote.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EArticulo.Editar(TxtCod_articulo.Text.Trim(), TxtCod_articulov.Text.Trim(), TxtCod_categoria.Text, TxtCod_linea.Text, TxtCod_sublinea.Text, TxtCod_color.Text, TxtCod_ubicacion.Text, TxtCod_impuesto.Text, TxtDesc_articulo.Text, TxtTipo.Text, TxtOrigen.Text, TxtItem.Text, TxtReferencia.Text, TxtModelo.Text, TxtGarantia.Text, Convert.ToDecimal(TxtPunto_min.Text), Convert.ToDecimal(TxtPunto_max.Text), Convert.ToDecimal(TxtPunto_ped.Text), Convert.ToDecimal(TxtPeso.Text), Convert.ToDecimal(TxtVolumen.Text), Convert.ToDecimal(TxtAlto.Text), Convert.ToDecimal(TxtAncho.Text), Convert.ToDecimal(TxtPorcentaje.Text), Convert.ToDecimal(TxtPuntos.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToBoolean(TxtActivo.Text), Convert.ToBoolean(TxtEsserial.Text), Convert.ToBoolean(TxtEslote.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_articulov.Text = TxtCod_articulo.Text;
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
                int rpta = Convert.ToInt32(EArticulo.GenerarCod(TxtCod_articulo.Text));
                TxtCod_articulo.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_articulo.Focus();
            }
        }

        private void FArticulo_Load(object sender, EventArgs e)
        {
            Text = "...::: Articulos :::...";
            MostraUsuario();
            Listar();
            EventoCombo();
        }

        private void FArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                Opcion = MessageBox.Show("Desea Guardar el Registro antes de Salir? ", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
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
            TxtCod_articulo.Focus();
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
                    Rpta = EArticulo.Eliminar(TxtCod_articulo.Text);

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
            FArticuloLista Listado = new FArticuloLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptArticulo Reporte = new FRptArticulo();
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
                Ds = EArticulo.Primero();

                TxtCod_articulo.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtCod_articulov.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtDesc_articulo.Text = Ds.Tables[0].Rows[0]["desc_articulo"].ToString();
                TxtTipo.Text = Ds.Tables[0].Rows[0]["tipo"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtItem.Text = Ds.Tables[0].Rows[0]["item"].ToString();
                TxtReferencia.Text = Ds.Tables[0].Rows[0]["referencia"].ToString();
                TxtModelo.Text = Ds.Tables[0].Rows[0]["modelo"].ToString();
                TxtGarantia.Text = Ds.Tables[0].Rows[0]["garantia"].ToString();
                TxtPunto_min.Text = Ds.Tables[0].Rows[0]["punto_min"].ToString();
                TxtPunto_max.Text = Ds.Tables[0].Rows[0]["punto_max"].ToString();
                TxtPunto_ped.Text = Ds.Tables[0].Rows[0]["punto_ped"].ToString();
                TxtPeso.Text = Ds.Tables[0].Rows[0]["peso"].ToString();
                TxtVolumen.Text = Ds.Tables[0].Rows[0]["volumen"].ToString();
                TxtAlto.Text = Ds.Tables[0].Rows[0]["alto"].ToString();
                TxtAncho.Text = Ds.Tables[0].Rows[0]["ancho"].ToString();
                TxtPorcentaje.Text = Ds.Tables[0].Rows[0]["porcentaje"].ToString();
                TxtPuntos.Text = Ds.Tables[0].Rows[0]["puntos"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtEsserial.Text = Ds.Tables[0].Rows[0]["esserial"].ToString();
                TxtEslote.Text = Ds.Tables[0].Rows[0]["eslote"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_categoria.Text = Ds.Tables[0].Rows[0]["cod_categoria"].ToString();
                TxtDesc_categoria.Text = Ds.Tables[0].Rows[0]["desc_categoria"].ToString();
                TxtCod_linea.Text = Ds.Tables[0].Rows[0]["cod_linea"].ToString();
                TxtDesc_linea.Text = Ds.Tables[0].Rows[0]["desc_linea"].ToString();
                TxtCod_sublinea.Text = Ds.Tables[0].Rows[0]["cod_sublinea"].ToString();
                TxtDesc_sublinea.Text = Ds.Tables[0].Rows[0]["desc_sublinea"].ToString();
                TxtCod_color.Text = Ds.Tables[0].Rows[0]["cod_color"].ToString();
                TxtDesc_color.Text = Ds.Tables[0].Rows[0]["desc_color"].ToString();
                TxtCod_ubicacion.Text = Ds.Tables[0].Rows[0]["cod_ubicacion"].ToString();
                TxtDesc_ubicacion.Text = Ds.Tables[0].Rows[0]["desc_ubicacion"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();

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
                Ds = EArticulo.Anterior(TxtCod_articulo.Text);

                TxtCod_articulo.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtCod_articulov.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtDesc_articulo.Text = Ds.Tables[0].Rows[0]["desc_articulo"].ToString();
                TxtTipo.Text = Ds.Tables[0].Rows[0]["tipo"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtItem.Text = Ds.Tables[0].Rows[0]["item"].ToString();
                TxtReferencia.Text = Ds.Tables[0].Rows[0]["referencia"].ToString();
                TxtModelo.Text = Ds.Tables[0].Rows[0]["modelo"].ToString();
                TxtGarantia.Text = Ds.Tables[0].Rows[0]["garantia"].ToString();
                TxtPunto_min.Text = Ds.Tables[0].Rows[0]["punto_min"].ToString();
                TxtPunto_max.Text = Ds.Tables[0].Rows[0]["punto_max"].ToString();
                TxtPunto_ped.Text = Ds.Tables[0].Rows[0]["punto_ped"].ToString();
                TxtPeso.Text = Ds.Tables[0].Rows[0]["peso"].ToString();
                TxtVolumen.Text = Ds.Tables[0].Rows[0]["volumen"].ToString();
                TxtAlto.Text = Ds.Tables[0].Rows[0]["alto"].ToString();
                TxtAncho.Text = Ds.Tables[0].Rows[0]["ancho"].ToString();
                TxtPorcentaje.Text = Ds.Tables[0].Rows[0]["porcentaje"].ToString();
                TxtPuntos.Text = Ds.Tables[0].Rows[0]["puntos"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtEsserial.Text = Ds.Tables[0].Rows[0]["esserial"].ToString();
                TxtEslote.Text = Ds.Tables[0].Rows[0]["eslote"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_categoria.Text = Ds.Tables[0].Rows[0]["cod_categoria"].ToString();
                TxtDesc_categoria.Text = Ds.Tables[0].Rows[0]["desc_categoria"].ToString();
                TxtCod_linea.Text = Ds.Tables[0].Rows[0]["cod_linea"].ToString();
                TxtDesc_linea.Text = Ds.Tables[0].Rows[0]["desc_linea"].ToString();
                TxtCod_sublinea.Text = Ds.Tables[0].Rows[0]["cod_sublinea"].ToString();
                TxtDesc_sublinea.Text = Ds.Tables[0].Rows[0]["desc_sublinea"].ToString();
                TxtCod_color.Text = Ds.Tables[0].Rows[0]["cod_color"].ToString();
                TxtDesc_color.Text = Ds.Tables[0].Rows[0]["desc_color"].ToString();
                TxtCod_ubicacion.Text = Ds.Tables[0].Rows[0]["cod_ubicacion"].ToString();
                TxtDesc_ubicacion.Text = Ds.Tables[0].Rows[0]["desc_ubicacion"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();

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
                Ds = EArticulo.Siguiente(TxtCod_articulo.Text);

                TxtCod_articulo.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtCod_articulov.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtDesc_articulo.Text = Ds.Tables[0].Rows[0]["desc_articulo"].ToString();
                TxtTipo.Text = Ds.Tables[0].Rows[0]["tipo"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtItem.Text = Ds.Tables[0].Rows[0]["item"].ToString();
                TxtReferencia.Text = Ds.Tables[0].Rows[0]["referencia"].ToString();
                TxtModelo.Text = Ds.Tables[0].Rows[0]["modelo"].ToString();
                TxtGarantia.Text = Ds.Tables[0].Rows[0]["garantia"].ToString();
                TxtPunto_min.Text = Ds.Tables[0].Rows[0]["punto_min"].ToString();
                TxtPunto_max.Text = Ds.Tables[0].Rows[0]["punto_max"].ToString();
                TxtPunto_ped.Text = Ds.Tables[0].Rows[0]["punto_ped"].ToString();
                TxtPeso.Text = Ds.Tables[0].Rows[0]["peso"].ToString();
                TxtVolumen.Text = Ds.Tables[0].Rows[0]["volumen"].ToString();
                TxtAlto.Text = Ds.Tables[0].Rows[0]["alto"].ToString();
                TxtAncho.Text = Ds.Tables[0].Rows[0]["ancho"].ToString();
                TxtPorcentaje.Text = Ds.Tables[0].Rows[0]["porcentaje"].ToString();
                TxtPuntos.Text = Ds.Tables[0].Rows[0]["puntos"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtEsserial.Text = Ds.Tables[0].Rows[0]["esserial"].ToString();
                TxtEslote.Text = Ds.Tables[0].Rows[0]["eslote"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_categoria.Text = Ds.Tables[0].Rows[0]["cod_categoria"].ToString();
                TxtDesc_categoria.Text = Ds.Tables[0].Rows[0]["desc_categoria"].ToString();
                TxtCod_linea.Text = Ds.Tables[0].Rows[0]["cod_linea"].ToString();
                TxtDesc_linea.Text = Ds.Tables[0].Rows[0]["desc_linea"].ToString();
                TxtCod_sublinea.Text = Ds.Tables[0].Rows[0]["cod_sublinea"].ToString();
                TxtDesc_sublinea.Text = Ds.Tables[0].Rows[0]["desc_sublinea"].ToString();
                TxtCod_color.Text = Ds.Tables[0].Rows[0]["cod_color"].ToString();
                TxtDesc_color.Text = Ds.Tables[0].Rows[0]["desc_color"].ToString();
                TxtCod_ubicacion.Text = Ds.Tables[0].Rows[0]["cod_ubicacion"].ToString();
                TxtDesc_ubicacion.Text = Ds.Tables[0].Rows[0]["desc_ubicacion"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();

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
                Ds = EArticulo.Ultimo();

                TxtCod_articulo.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtCod_articulov.Text = Ds.Tables[0].Rows[0]["cod_articulo"].ToString();
                TxtDesc_articulo.Text = Ds.Tables[0].Rows[0]["desc_articulo"].ToString();
                TxtTipo.Text = Ds.Tables[0].Rows[0]["tipo"].ToString();
                TxtOrigen.Text = Ds.Tables[0].Rows[0]["origen"].ToString();
                TxtItem.Text = Ds.Tables[0].Rows[0]["item"].ToString();
                TxtReferencia.Text = Ds.Tables[0].Rows[0]["referencia"].ToString();
                TxtModelo.Text = Ds.Tables[0].Rows[0]["modelo"].ToString();
                TxtGarantia.Text = Ds.Tables[0].Rows[0]["garantia"].ToString();
                TxtPunto_min.Text = Ds.Tables[0].Rows[0]["punto_min"].ToString();
                TxtPunto_max.Text = Ds.Tables[0].Rows[0]["punto_max"].ToString();
                TxtPunto_ped.Text = Ds.Tables[0].Rows[0]["punto_ped"].ToString();
                TxtPeso.Text = Ds.Tables[0].Rows[0]["peso"].ToString();
                TxtVolumen.Text = Ds.Tables[0].Rows[0]["volumen"].ToString();
                TxtAlto.Text = Ds.Tables[0].Rows[0]["alto"].ToString();
                TxtAncho.Text = Ds.Tables[0].Rows[0]["ancho"].ToString();
                TxtPorcentaje.Text = Ds.Tables[0].Rows[0]["porcentaje"].ToString();
                TxtPuntos.Text = Ds.Tables[0].Rows[0]["puntos"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["activo"].ToString();
                TxtEsserial.Text = Ds.Tables[0].Rows[0]["esserial"].ToString();
                TxtEslote.Text = Ds.Tables[0].Rows[0]["eslote"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_categoria.Text = Ds.Tables[0].Rows[0]["cod_categoria"].ToString();
                TxtDesc_categoria.Text = Ds.Tables[0].Rows[0]["desc_categoria"].ToString();
                TxtCod_linea.Text = Ds.Tables[0].Rows[0]["cod_linea"].ToString();
                TxtDesc_linea.Text = Ds.Tables[0].Rows[0]["desc_linea"].ToString();
                TxtCod_sublinea.Text = Ds.Tables[0].Rows[0]["cod_sublinea"].ToString();
                TxtDesc_sublinea.Text = Ds.Tables[0].Rows[0]["desc_sublinea"].ToString();
                TxtCod_color.Text = Ds.Tables[0].Rows[0]["cod_color"].ToString();
                TxtDesc_color.Text = Ds.Tables[0].Rows[0]["desc_color"].ToString();
                TxtCod_ubicacion.Text = Ds.Tables[0].Rows[0]["cod_ubicacion"].ToString();
                TxtDesc_ubicacion.Text = Ds.Tables[0].Rows[0]["desc_ubicacion"].ToString();
                TxtCod_impuesto.Text = Ds.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtDesc_impuesto.Text = Ds.Tables[0].Rows[0]["desc_impuesto"].ToString();

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

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtTipo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtOrigen_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_impuesto_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_articulo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_articulo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_categoria_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void TxtDesc_categoria_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_linea_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_sublinea_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_color_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_ubicacion_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtItem_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtReferencia_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtModelo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPuntos_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtAlto_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPeso_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtAncho_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtVolumen_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtGarantia_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPunto_min_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPunto_max_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPunto_ped_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtActivo_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTexBox();
        }

        private void TxtEsserial_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
            CambiosTexBox();
        }

        private void TxtEslote_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
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

        private void ChkActivo_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkEsserial_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkEslote_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void TxtCod_impuesto_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_impuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarAlicuotas();
        }

        #endregion

        #region LLAMAR REGISTROS
        internal void SetArticulo(string cod_articulo, string desc_articulo, string tipo, string origen, string item, string referencia, string modelo, string garantia, string punto_min, string punto_max, string punto_ped, string peso, string volumen, string alto, string ancho, string porcentaje, string puntos, string fecha_reg, string activo, string esserial, string eslote, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_categoria, string desc_categoria, string cod_linea, string desc_linea, string cod_sublinea, string desc_sublinea, string cod_color, string desc_color, string cod_ubicacion, string desc_ubicacion, string cod_impuesto, string desc_impuesto)
        {
            TxtCod_articulo.Text = cod_articulo;
            TxtCod_articulov.Text = cod_articulo;
            TxtDesc_articulo.Text = desc_articulo;
            TxtTipo.Text = tipo;
            TxtOrigen.Text = origen;
            TxtItem.Text = item;
            TxtReferencia.Text = referencia;
            TxtModelo.Text = modelo;
            TxtGarantia.Text = garantia;
            TxtPunto_min.Text = punto_min;
            TxtPunto_max.Text = punto_max;
            TxtPunto_ped.Text = punto_ped;
            TxtPeso.Text = peso;
            TxtVolumen.Text = volumen;
            TxtAlto.Text = alto;
            TxtAncho.Text = ancho;
            TxtPorcentaje.Text = porcentaje;
            TxtPuntos.Text = puntos;
            TxtFecha_reg.Text = fecha_reg;
            TxtActivo.Text = activo;
            TxtEsserial.Text = esserial;
            TxtEslote.Text = eslote;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;

            TxtCod_categoria.Text = cod_categoria;
            TxtDesc_categoria.Text = desc_categoria;

            TxtCod_linea.Text = cod_linea;
            TxtDesc_linea.Text = desc_linea;

            TxtCod_sublinea.Text = cod_sublinea;
            TxtDesc_sublinea.Text = desc_sublinea;

            TxtCod_color.Text = cod_color;
            TxtDesc_color.Text = desc_color;

            TxtCod_ubicacion.Text = cod_ubicacion;
            TxtDesc_ubicacion.Text = desc_ubicacion;

            TxtCod_impuesto.Text = cod_impuesto;
            TxtDesc_impuesto.Text = desc_impuesto;
        }


        internal void SetCategoria(string cod_categoria, string desc_categoria)
        {
            TxtCod_categoria.Text = cod_categoria;
            TxtDesc_categoria.Text = desc_categoria;
        }

        internal void SetLinea(string cod_linea, string desc_linea)
        {
            TxtCod_linea.Text = cod_linea;
            TxtDesc_linea.Text = desc_linea;
        }

        internal void SetSubLinea(string cod_sublinea, string desc_sublinea)
        {
            TxtCod_sublinea.Text = cod_sublinea;
            TxtDesc_sublinea.Text = desc_sublinea;
        }

        internal void SetColor(string cod_color, string desc_color)
        {
            TxtCod_color.Text = cod_color;
            TxtDesc_color.Text = desc_color;
        }

        internal void SetUbicacion(string cod_ubicacion, string desc_ubicacion)
        {
            TxtCod_ubicacion.Text = cod_ubicacion;
            TxtDesc_ubicacion.Text = desc_ubicacion;
        }

        private void TxtCod_categoria_DoubleClick(object sender, EventArgs e)
        {
            FCategoriaLista Listado = new FCategoriaLista
            {
                TxtFlag = "Articulo"
            };
            Dt = ECategoria.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();

            };
        }

        private void TxtCod_categoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FCategoriaLista Listado = new FCategoriaLista
                {
                    TxtFlag = "Articulo"
                };
                Dt = ECategoria.Mostrar();
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

        private void TxtCod_linea_DoubleClick(object sender, EventArgs e)
        {
            FLineaLista Listado = new FLineaLista
            {
                TxtFlag = "Articulo"
            };
            Dt = ELinea.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
                TxtCod_sublinea.Text = string.Empty;
                TxtDesc_sublinea.Text = string.Empty;

            };
        }

        private void TxtCod_linea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FLineaLista Listado = new FLineaLista
                {
                    TxtFlag = "Articulo"
                };
                Dt = ELinea.Mostrar();
                if (Dt.Rows.Count == 0)
                {
                    MensajeError("No Existen Registros Disponibles!");
                }
                else if (Dt.Rows.Count != 0)
                {
                    Listado.ShowDialog();
                    TxtCod_sublinea.Text = string.Empty;
                    TxtDesc_sublinea.Text = string.Empty;

                };
            }
        }

        private void TxtCod_sublinea_DoubleClick(object sender, EventArgs e)
        {
            FSubLineaLista Listado = new FSubLineaLista
            {
                TxtFlag = "Articulo"
            };
            Listado.TxtCod_linea.Text = TxtCod_linea.Text;

            Dt = ESubLinea.MostrarOpc(TxtCod_linea.Text);
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
              
            };
        }

        private void TxtCod_sublinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FSubLineaLista Listado = new FSubLineaLista
                {
                    TxtFlag = "Articulo"
                };
                Listado.TxtCod_linea.Text = TxtCod_linea.Text;

                Dt = ESubLinea.MostrarOpc(TxtCod_linea.Text);
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

        private void TxtCod_color_DoubleClick(object sender, EventArgs e)
        {
            FColorLista Listado = new FColorLista
            {
                TxtFlag = "Articulo"
            };
            Dt = EColor.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();

            };
        }

        private void TxtCod_color_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FColorLista Listado = new FColorLista
                {
                    TxtFlag = "Articulo"
                };
                Dt = EColor.Mostrar();
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

        private void TxtCod_ubicacion_DoubleClick(object sender, EventArgs e)
        {
            FUbicacionLista Listado = new FUbicacionLista
            {
                TxtFlag = "Articulo"
            };
            Dt = EUbicacion.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();

            };
        }

        private void TxtCod_ubicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FUbicacionLista Listado = new FUbicacionLista
                {
                    TxtFlag = "Articulo"
                };
                Dt = EUbicacion.Mostrar();
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
    }
}
