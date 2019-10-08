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
    public partial class FDCompra : Form
    {

        public bool Importar = false;
        public string TipoImp = "";
        string Pref = "";
        DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();
        DialogResult Opcion;

        private static FDCompra _Instancia;

        public static FDCompra GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FDCompra();
            }
            return _Instancia;
        }

        public FDCompra()
        {
            InitializeComponent();
            ListarImpuesto();
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
            Dt = EDCompra.Mostrar();
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

        private void CambiosTexBox()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
            }
            ErrorTexto.Dispose();
        }

        internal void Limpiar()
        {
            TxtCod_proveedor.Text = string.Empty;
            TxtCod_condicionpago.Text = string.Empty;
            TxtCod_dcompra.Text = string.Empty;
            TxtDesc_dcompra.Text = string.Empty;
            CbTipoDoc.Text = "DOC. DE COMPRA";
            TxtOptipo.Text = "DCompra";
            
            TxtNumserial.Text = string.Empty;
            TxtNumdocumento.Text = string.Empty;
            TxtNumcontrol.Text = string.Empty;
            TxtDoc_asociado.Text = string.Empty;
            TxtOrigen.Text = string.Empty;
            TxtEstatus.Text = "Sin Procesar";
            TxtAnulado.Text = false.ToString();
            TxtMonto_base.Text = string.Empty;
            TxtMonto_r.Text = string.Empty;
            TxtMonto_d.Text = string.Empty;
            TxtMonto_o.Text = string.Empty;
            TxtMonto_imp.Text = string.Empty;
            TxtSubtotal.Text = string.Empty;
            TxtTotal.Text = string.Empty;
            TxtFecha_reg.Text = string.Empty;
            TxtFecha_doc.Text = string.Empty;
            TxtFecha_ven.Text = string.Empty;
            TxtCampo1.Text = string.Empty;
            TxtCampo2.Text = string.Empty;
            TxtCampo3.Text = string.Empty;
            TxtCampo4.Text = string.Empty;
            TxtCampo5.Text = string.Empty;
            TxtCampo6.Text = string.Empty;
            TxtCod_proveedor.Text = string.Empty;
            TxtDesc_proveedor.Text = string.Empty;
            TxtRif.Text = string.Empty;
            TxtCod_condicionpago.Text = string.Empty;
            TxtDesc_condicionpago.Text = string.Empty;
            TxtDiascredito.Text = string.Empty;
            Top_serie();
        }

        private void Listar()
        {
            try
            {
                DataSet DsListar = EDCompra.Listar();

                TxtCod_dcompra.Text = DsListar.Tables[0].Rows[0]["Cod_dcompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_dcompra.Text = DsListar.Tables[0].Rows[0]["Desc_dcompra"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["Optipo"].ToString();
                TxtNumdocumento.Text = DsListar.Tables[0].Rows[0]["Numdocumento"].ToString();
                TxtNumcontrol.Text = DsListar.Tables[0].Rows[0]["Numcontrol"].ToString();
                TxtDoc_asociado.Text = DsListar.Tables[0].Rows[0]["Doc_asociado"].ToString();
                TxtOrigen.Text = DsListar.Tables[0].Rows[0]["Origen"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["Estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["Anulado"].ToString();
                TxtMonto_base.Text = DsListar.Tables[0].Rows[0]["Monto_base"].ToString();
                TxtMonto_r.Text = DsListar.Tables[0].Rows[0]["Monto_r"].ToString();
                TxtMonto_d.Text = DsListar.Tables[0].Rows[0]["Monto_d"].ToString();
                TxtMonto_o.Text = DsListar.Tables[0].Rows[0]["Monto_o"].ToString();
                TxtMonto_imp.Text = DsListar.Tables[0].Rows[0]["Monto_imp"].ToString();
                TxtSubtotal.Text = DsListar.Tables[0].Rows[0]["Subtotal"].ToString();
                TxtTotal.Text = DsListar.Tables[0].Rows[0]["Total"].ToString();
                TxtFecha_doc.Text = DsListar.Tables[0].Rows[0]["Fecha_doc"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtFecha_ven.Text = DsListar.Tables[0].Rows[0]["Fecha_ven"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_dcomprav.Text = DsListar.Tables[0].Rows[0]["Cod_dcompra"].ToString();

                TxtEditar.Text = "Listar";
            }
            catch (Exception Ex)
            {
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                TxtEditar.Text = "Nuevo";
                Limpiar();
                string rpta = Ex.Message;
                ListarTipoDoc();
            }
            DataListadoGen.DataSource = null;
            MostrarListado();
            Botones();
        }

        private void GenerarCod()
        {
            Top_serie();
            try
            {
                int rpta = Convert.ToInt32(EDCompra.GenerarCod(TxtCod_dcompra.Text));
                TxtCod_dcompra.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_dcompra.Focus();
            }
        }

        private void EventosTexBox()
        {
            if (TxtNacional.Text == true.ToString())
            {
                ChkNacional.Checked = true;
            }
            else
            {
                ChkNacional.Checked = false;
            }
        }

        private void EventosCheckBox()
        {
            if (ChkNacional.Checked == true)
            {
                TxtNacional.Text = true.ToString();
            }
            else
            {
                TxtNacional.Text = false.ToString();
            }
        }

        internal void Habilitar(bool valor)
        {
            TxtCod_dcompra.Enabled = valor;
            TxtDesc_dcompra.Enabled = valor;
            TxtCod_proveedor.Enabled = valor;
            TxtCod_condicionpago.Enabled = valor;
            TxtOptipo.Enabled = valor;
            TxtNumdocumento.Enabled = valor;
            TxtNumcontrol.Enabled = valor;
            TxtDoc_asociado.Enabled = valor;
            TxtMonto_base.Enabled = valor;
            TxtMonto_r.Enabled = valor;
            TxtMonto_d.Enabled = valor;
            TxtMonto_o.Enabled = valor;
            TxtMonto_imp.Enabled = valor;
            TxtSubtotal.Enabled = valor;
            TxtTotal.Enabled = valor;
            TxtFecha_reg.Enabled = valor;
            TxtFecha_doc.Enabled = valor;
            TxtFecha_ven.Enabled = valor;
            TxtCampo1.Enabled = valor;
            TxtCampo2.Enabled = valor;
            TxtCampo3.Enabled = valor;
            TxtCampo4.Enabled = valor;
            TxtCampo5.Enabled = valor;
            TxtCampo6.Enabled = valor;
            TxtCod_proveedor.Enabled = valor;
            TxtDesc_proveedor.Enabled = valor;
            TxtRif.Enabled = valor;
            TxtCod_condicionpago.Enabled = valor;
            TxtDesc_condicionpago.Enabled = valor;
            ChkNacional.Enabled = valor;
        }

        internal void HabilitarImp(bool valor)
        {
            TxtCod_dcompra.Enabled = valor;
            TxtDesc_dcompra.Enabled = valor;
            TxtCod_proveedor.Enabled = valor;
            TxtCod_condicionpago.Enabled = valor;
            TxtOptipo.Enabled = valor;
            TxtNumdocumento.Enabled = valor;
            TxtNumcontrol.Enabled = valor;
            TxtDoc_asociado.Enabled = valor;
            TxtMonto_base.Enabled = valor;
            TxtMonto_r.Enabled = valor;
            TxtMonto_d.Enabled = valor;
            TxtMonto_o.Enabled = valor;
            TxtMonto_imp.Enabled = valor;
            TxtSubtotal.Enabled = valor;
            TxtTotal.Enabled = valor;
            TxtFecha_reg.Enabled = valor;
            TxtFecha_doc.Enabled = valor;
            TxtFecha_ven.Enabled = valor;
            TxtCampo1.Enabled = valor;
            TxtCampo2.Enabled = valor;
            TxtCampo3.Enabled = valor;
            TxtCampo4.Enabled = valor;
            TxtCampo5.Enabled = valor;
            TxtCampo6.Enabled = valor;
            TxtCod_proveedor.Enabled = valor;
            TxtDesc_proveedor.Enabled = valor;
            TxtRif.Enabled = valor;
            TxtCod_condicionpago.Enabled = valor;
            TxtDesc_condicionpago.Enabled = valor;
            ChkNacional.Enabled = valor;
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

                BtnImportar.Enabled = true;
                BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                BtnOtros.Enabled = true;

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

                BtnImportar.Enabled = true;
                BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                BtnOtros.Enabled = true;
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar" && Importar == false)
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

                BtnImportar.Enabled = false;
                BtnPagar.Enabled = true;
                BtnAnular.Enabled = true;
                BtnOtros.Enabled = true;
                Habilitar(true);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado" && (Importar == true || Importar == false))
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

                BtnImportar.Enabled = false;
                BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                BtnOtros.Enabled = false;

                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Anulado" && (Importar == true || Importar == false))
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

                BtnImportar.Enabled = false;
                BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                BtnOtros.Enabled = false;

                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar" && Importar == true)
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

                BtnImportar.Enabled = false;
                BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;

                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado Parcial" && Importar == true)
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

                BtnImportar.Enabled = false;
                BtnPagar.Enabled = false;
                BtnAnular.Enabled = false;
                BtnOtros.Enabled = false;

                Habilitar(false);
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Procesado Parcial" && Importar == false)
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

                BtnImportar.Enabled = false;
                BtnPagar.Enabled = true;
                BtnAnular.Enabled = false;
                BtnOtros.Enabled = false;

                Habilitar(false);
            }
        }

        private void ListarTipoDoc()
        {
            CbTipoDoc.Items.AddRange(new object[] {"Doc. de Compra","Factura de Compra","Retencion de IVA","Retencion de ISLR","Nota de Credito","Nota de Debito","Ajuste Negativo","Ajuste Positivo","Adelanto de Pago"});
        }

        private void TipoDoc()
        {
            if (CbTipoDoc.Text == "Factura de Compra")
            {
                TxtOptipo.Text = "FCompra";
                TxtDesc_impuesto.Text = "Tasa General";
                TxtDesc_impuesto.Enabled = true;
            }
            else if (CbTipoDoc.Text == "Retencion de IVA")
            {
                TxtOptipo.Text = "RETIVA";
                TxtDesc_impuesto.Text = "Exentos";
                TxtDesc_impuesto.Enabled = false;
            }
            else if (CbTipoDoc.Text == "Retencion de ISLR")
            {
                TxtOptipo.Text = "RETISLR";
                TxtDesc_impuesto.Text = "Exentos";
                TxtDesc_impuesto.Enabled = false;
            }
            else if (CbTipoDoc.Text == "Nota de Debito")
            {
                TxtOptipo.Text = "ND";
                TxtDesc_impuesto.Text = "Tasa General";
                TxtDesc_impuesto.Enabled = true;
            }
            else if (CbTipoDoc.Text == "Nota de Credito")
            {
                TxtOptipo.Text = "NC";
                TxtDesc_impuesto.Text = "Tasa General";
                TxtDesc_impuesto.Enabled = true;
            }
            else if (CbTipoDoc.Text == "Ajuste Negativo")
            {
                TxtOptipo.Text = "AJNC";
                TxtDesc_impuesto.Text = "Exentos";
                TxtDesc_impuesto.Enabled = false;
            }
            else if (CbTipoDoc.Text == "Ajuste Positivo")
            {                
                TxtOptipo.Text = "AJPC";
                TxtDesc_impuesto.Text = "Exentos";
                TxtDesc_impuesto.Enabled = false;
            }
            if (CbTipoDoc.Text == "Doc. de Compra")
            {
                TxtOptipo.Text = "DCompra";
                TxtDesc_impuesto.Text = "Tasa General";
                TxtDesc_impuesto.Enabled = true;
            }
            else if (CbTipoDoc.Text == "Adelanto de Pago")
            {
                TxtOptipo.Text = "ADP";
                TxtDesc_impuesto.Text = "Exentos";
                TxtDesc_impuesto.Enabled = false;
            }
        }

        internal void ListarImpuesto()
        {
            DataTable DtImp = EImpuesto.Mostrar();

            for (int i = 0; i <= Convert.ToInt32(DtImp.Rows.Count) - 1; i++)
            {
                TxtDesc_impuesto.Items.Add(DtImp.Rows[i]["desc_impuesto"].ToString());
            }
        }

        private void SeleccionarImpuesto()
        {
            try
            {
                DataSet DsImp = EImpuesto.ListarTasa(TxtDesc_impuesto.Text);
                TxtCod_impuesto.Text = DsImp.Tables[0].Rows[0]["cod_impuesto"].ToString();
                TxtTasaImp.Text = DsImp.Tables[0].Rows[0]["tasaimp"].ToString();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }

        }

        private void FDCompra_Load(object sender, EventArgs e)
        {
            Text = "...::: Documento de Compra :::...";
            Listar();
            CbBtipo();
            CbBucar.Text = "Codigo";
        }

        private void FDCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FDCompra_FormClosing(object sender, FormClosingEventArgs e)
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

        #region BOTONES

        internal void Guardar()
        {
            try
            {
                string Rpta = "";
                bool registrar = true;

                if (TxtCod_proveedor.Text == string.Empty || TxtNumdocumento.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_proveedor, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtNumdocumento, "Campo Obligatorio");
                    registrar = false;
                }
                else if (registrar)
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        GenerarCod();
                        Rpta = EDCompra.Insertar
                            (TxtCod_dcompra.Text, TxtCod_proveedor.Text, TxtCod_condicionpago.Text, TxtDesc_dcompra.Text, TxtOptipo.Text, TxtNumdocumento.Text, TxtNumcontrol.Text, TxtNumserial.Text,TxtDoc_asociado.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), Convert.ToDecimal(TxtMonto_base.Text), Convert.ToDecimal(TxtMonto_r.Text), Convert.ToDecimal(TxtMonto_d.Text), Convert.ToDecimal(TxtMonto_o.Text), Convert.ToDecimal(TxtMonto_imp.Text), Convert.ToDecimal(TxtSubtotal.Text), Convert.ToDecimal(TxtTotal.Text), Convert.ToDateTime(TxtFecha_doc.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecha_ven.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        TxtCod_dcomprav.Text = TxtCod_dcompra.Text;
                        MostrarListado();
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EDCompra.Editar
                            (TxtCod_dcompra.Text, TxtCod_dcomprav.Text, TxtCod_proveedor.Text, TxtCod_condicionpago.Text, TxtDesc_dcompra.Text, TxtOptipo.Text, TxtNumdocumento.Text, TxtNumcontrol.Text, TxtNumserial.Text, TxtDoc_asociado.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), Convert.ToDecimal(TxtMonto_base.Text), Convert.ToDecimal(TxtMonto_r.Text), Convert.ToDecimal(TxtMonto_d.Text), Convert.ToDecimal(TxtMonto_o.Text), Convert.ToDecimal(TxtMonto_imp.Text), Convert.ToDecimal(TxtSubtotal.Text), Convert.ToDecimal(TxtTotal.Text), Convert.ToDateTime(TxtFecha_doc.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecha_ven.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        TxtCod_dcomprav.Text = TxtCod_dcompra.Text;
                        MostrarListado();
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
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Nuevo";
            Limpiar();
            Botones();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente desea Eliminar el Registro ?", "...::: Step One Ver 1.0 :::...",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string Rpta = "";
                if (Opcion == DialogResult.OK)
                {

                    Rpta = EDCompra.Eliminar(TxtCod_dcompra.Text);

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
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea Anular el Registro ?", "...::: Step One Ver 1.0 :::...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string Rpta = "";
                if (Opcion == DialogResult.OK)
                {
                    TxtEstatus.Text = "Anulado";
                    TxtAnulado.Text = true.ToString();

                    Rpta = EDCompra.Anular(TxtCod_dcompra.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), TxtCod_usuario.Text);

                    if (Rpta.Equals("Y"))
                    {
                        Habilitar(false);
                        Botones();
                        Listar();
                        MensajeOk("Registro Anulado Correctamente!");
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
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtCod_proveedor_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_condicionpago_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumdocumento_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumcontrol_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_dcompra_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_dcomprav_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_doc_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            TxtFecha_ven.Value = TxtFecha_doc.Value.AddDays(TxtDiascredito.Value);
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFecha_ven_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtOrigen_TextChanged(object sender, EventArgs e)
        {

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

        private void TxtDoc_asociado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNacional_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
        }

        private void TxtAnulado_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDiascredito_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            TxtFecha_ven.Value = TxtFecha_doc.Value.AddDays(TxtDiascredito.Value);
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void TxtCod_dcompra_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void ChkNacional_CheckedChanged(object sender, EventArgs e)
        {
            EventosCheckBox();
        }

        private void TxtOptipo_TextChanged(object sender, EventArgs e)
        {
            if (TxtOptipo.Text == "DCompra")
            {
                BtnPagar.Text = "Facturar";
            }
            else if (TxtOptipo.Text == "PCompra")
            {
                BtnPagar.Text = "Facturar";
            }
            else if (TxtOptipo.Text == "FCompra")
            {
                BtnPagar.Text = "Pagar";
            }
            TipoDoc();
        }

        private void TxtCod_proveedor_Validating(object sender, CancelEventArgs e)
        {
            DataTable Dt = EDCompra.Mostrar();
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                foreach (DataRow row in Dt.Rows)
                {
                    if (Convert.ToString(row["numdocumento"].ToString()).Equals(TxtNumdocumento.Text) &&
                        Convert.ToString(row["cod_proveedor"].ToString()).Equals(TxtCod_proveedor.Text))
                    {
                        MensajeError("Numero de Documento Duplicado para el Proveedor en Proceso");
                        ErrorTexto.SetError(TxtNumdocumento, "Verifique!");
                    }
                }
            }
        }

        private void TxtNumdocumento_Validating(object sender, CancelEventArgs e)
        {
            DataTable Dt = EDCompra.Mostrar();
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                foreach (DataRow row in Dt.Rows)
                {
                    if (Convert.ToString(row["numdocumento"].ToString()).Equals(TxtNumdocumento.Text) &&
                        Convert.ToString(row["cod_proveedor"].ToString()).Equals(TxtCod_proveedor.Text))
                    {
                        MensajeError("Numero de Documento Duplicado para el Proveedor en Proceso");
                        ErrorTexto.SetError(TxtNumdocumento, "Verifique!");
                    }
                }
            }
        }
        #endregion

        #region TOTALES GENERAL
        private void TxtSubtotal_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_base.Value = (TxtSubtotal.Value + TxtMonto_r.Value) - TxtMonto_d.Value;
        }

        private void TxtMonto_base_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_imp.Value = TxtTasaImp.Value * TxtMonto_base.Value / 100;
            TxtTotal.Value = TxtMonto_o.Value + TxtMonto_base.Value + TxtMonto_imp.Value;
        }

        private void TxtMonto_d_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_base.Value = (TxtSubtotal.Value + TxtMonto_r.Value) - TxtMonto_d.Value;
        }

        private void TxtMonto_r_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_base.Value = (TxtSubtotal.Value + TxtMonto_r.Value) - TxtMonto_d.Value;
        }

        private void TxtMonto_imp_ValueChanged(object sender, EventArgs e)
        {
            TxtTotal.Value = TxtMonto_o.Value + TxtMonto_base.Value + TxtMonto_imp.Value;
        }

        private void TxtMonto_o_ValueChanged(object sender, EventArgs e)
        {
            TxtTotal.Value = TxtMonto_o.Value + TxtMonto_base.Value + TxtMonto_imp.Value;
        }
        private void TxtTasaImp_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_imp.Value = TxtTasaImp.Value * TxtMonto_base.Value / 100;
        }
        #endregion

        #region LLAMAR REGISTROS
        internal void SetProveedor(string cod_proveedor, string desc_proveedor, string rif, string nacional, string cod_condicionpago, string desc_condicionpago, string diascredito)
        {
            TxtCod_proveedor.Text = cod_proveedor;
            TxtDesc_proveedor.Text = desc_proveedor;
            TxtRif.Text = rif;
            TxtNacional.Text = nacional;
            TxtCod_condicionpago.Text = cod_condicionpago;
            TxtDesc_condicionpago.Text = desc_condicionpago;
            TxtDiascredito.Text = diascredito;
            EventosTexBox();
        }

        internal void SetCondicionPago(string cod_condicionpago, string desc_condicionpago, string diascredito)
        {
            TxtCod_condicionpago.Text = cod_condicionpago;
            TxtDesc_condicionpago.Text = desc_condicionpago;
            TxtDiascredito.Text = diascredito;
        }

        private void TxtCod_proveedor_DoubleClick(object sender, EventArgs e)
        {
            FProveedorLista Listado = new FProveedorLista
            {
                TxtFlag = "DCompra"
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
        }

        private void TxtCod_proveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FProveedorLista Listado = new FProveedorLista
                {
                    TxtFlag = "DCompra"
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
            }
        }

        private void TxtCod_condicionpago_DoubleClick(object sender, EventArgs e)
        {
            FCondicionPagoLista Listado = new FCondicionPagoLista
            {
                TxtFlag = "DCompra"
            };
            Dt = ECondicionPago.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_condicionpago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FCondicionPagoLista Listado = new FCondicionPagoLista
                {
                    TxtFlag = "DCompra"
                };
                Dt = ECondicionPago.Mostrar();
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

        private void BtnOtros_Click(object sender, EventArgs e)
        {
            FCOtros FOtros = new FCOtros();
            FOtros.txtFlag.Text = "DCompra";
            FOtros.TxtMonto.Value = TxtTotal.Value;
            if (TxtMonto_o.Value > 0)
            {
                FOtros.TxtRecargo.Value = TxtMonto_o.Value;
                FOtros.TxtTotalo.Value = FOtros.TxtMonto.Value + FOtros.TxtRecargo.Value;
            }
            else if (TxtMonto_o.Value < 0)
            {
                FOtros.TxtDescuento.Value = TxtMonto_o.Value;
                FOtros.TxtTotalo.Value = FOtros.TxtMonto.Value - FOtros.TxtDescuento.Value;
            }
            FOtros.ShowDialog();
        }

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DsListar = EDCompra.Primero();

                TxtCod_dcompra.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_dcompra.Text = DsListar.Tables[0].Rows[0]["desc_dcompra"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdocumento.Text = DsListar.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtNumcontrol.Text = DsListar.Tables[0].Rows[0]["numcontrol"].ToString();
                TxtDoc_asociado.Text = DsListar.Tables[0].Rows[0]["doc_asociado"].ToString();
                TxtOrigen.Text = DsListar.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtMonto_base.Text = DsListar.Tables[0].Rows[0]["monto_base"].ToString();
                TxtMonto_r.Text = DsListar.Tables[0].Rows[0]["monto_r"].ToString();
                TxtMonto_d.Text = DsListar.Tables[0].Rows[0]["monto_d"].ToString();
                TxtMonto_o.Text = DsListar.Tables[0].Rows[0]["monto_o"].ToString();
                TxtMonto_imp.Text = DsListar.Tables[0].Rows[0]["monto_imp"].ToString();
                TxtSubtotal.Text = DsListar.Tables[0].Rows[0]["subtotal"].ToString();
                TxtTotal.Text = DsListar.Tables[0].Rows[0]["total"].ToString();
                TxtFecha_doc.Text = DsListar.Tables[0].Rows[0]["fecha_doc"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_ven.Text = DsListar.Tables[0].Rows[0]["fecha_ven"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_dcomprav.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarListado();
                Registros();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DsListar = EDCompra.Anterior(TxtCod_dcompra.Text);

                TxtCod_dcompra.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_dcompra.Text = DsListar.Tables[0].Rows[0]["desc_dcompra"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdocumento.Text = DsListar.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtNumcontrol.Text = DsListar.Tables[0].Rows[0]["numcontrol"].ToString();
                TxtDoc_asociado.Text = DsListar.Tables[0].Rows[0]["doc_asociado"].ToString();
                TxtOrigen.Text = DsListar.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtMonto_base.Text = DsListar.Tables[0].Rows[0]["monto_base"].ToString();
                TxtMonto_r.Text = DsListar.Tables[0].Rows[0]["monto_r"].ToString();
                TxtMonto_d.Text = DsListar.Tables[0].Rows[0]["monto_d"].ToString();
                TxtMonto_o.Text = DsListar.Tables[0].Rows[0]["monto_o"].ToString();
                TxtMonto_imp.Text = DsListar.Tables[0].Rows[0]["monto_imp"].ToString();
                TxtSubtotal.Text = DsListar.Tables[0].Rows[0]["subtotal"].ToString();
                TxtTotal.Text = DsListar.Tables[0].Rows[0]["total"].ToString();
                TxtFecha_doc.Text = DsListar.Tables[0].Rows[0]["fecha_doc"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_ven.Text = DsListar.Tables[0].Rows[0]["fecha_ven"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_dcomprav.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarListado();
                Registros();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DsListar = EDCompra.Siguiente(TxtCod_dcompra.Text);

                TxtCod_dcompra.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_dcompra.Text = DsListar.Tables[0].Rows[0]["desc_dcompra"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdocumento.Text = DsListar.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtNumcontrol.Text = DsListar.Tables[0].Rows[0]["numcontrol"].ToString();
                TxtDoc_asociado.Text = DsListar.Tables[0].Rows[0]["doc_asociado"].ToString();
                TxtOrigen.Text = DsListar.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtMonto_base.Text = DsListar.Tables[0].Rows[0]["monto_base"].ToString();
                TxtMonto_r.Text = DsListar.Tables[0].Rows[0]["monto_r"].ToString();
                TxtMonto_d.Text = DsListar.Tables[0].Rows[0]["monto_d"].ToString();
                TxtMonto_o.Text = DsListar.Tables[0].Rows[0]["monto_o"].ToString();
                TxtMonto_imp.Text = DsListar.Tables[0].Rows[0]["monto_imp"].ToString();
                TxtSubtotal.Text = DsListar.Tables[0].Rows[0]["subtotal"].ToString();
                TxtTotal.Text = DsListar.Tables[0].Rows[0]["total"].ToString();
                TxtFecha_doc.Text = DsListar.Tables[0].Rows[0]["fecha_doc"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_ven.Text = DsListar.Tables[0].Rows[0]["fecha_ven"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_dcomprav.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarListado();
                Registros();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DsListar = EDCompra.Ultimo();

                TxtCod_dcompra.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_dcompra.Text = DsListar.Tables[0].Rows[0]["desc_dcompra"].ToString();
                TxtOptipo.Text = DsListar.Tables[0].Rows[0]["optipo"].ToString();
                TxtNumdocumento.Text = DsListar.Tables[0].Rows[0]["numdocumento"].ToString();
                TxtNumcontrol.Text = DsListar.Tables[0].Rows[0]["numcontrol"].ToString();
                TxtDoc_asociado.Text = DsListar.Tables[0].Rows[0]["doc_asociado"].ToString();
                TxtOrigen.Text = DsListar.Tables[0].Rows[0]["origen"].ToString();
                TxtEstatus.Text = DsListar.Tables[0].Rows[0]["estatus"].ToString();
                TxtAnulado.Text = DsListar.Tables[0].Rows[0]["anulado"].ToString();
                TxtMonto_base.Text = DsListar.Tables[0].Rows[0]["monto_base"].ToString();
                TxtMonto_r.Text = DsListar.Tables[0].Rows[0]["monto_r"].ToString();
                TxtMonto_d.Text = DsListar.Tables[0].Rows[0]["monto_d"].ToString();
                TxtMonto_o.Text = DsListar.Tables[0].Rows[0]["monto_o"].ToString();
                TxtMonto_imp.Text = DsListar.Tables[0].Rows[0]["monto_imp"].ToString();
                TxtSubtotal.Text = DsListar.Tables[0].Rows[0]["subtotal"].ToString();
                TxtTotal.Text = DsListar.Tables[0].Rows[0]["total"].ToString();
                TxtFecha_doc.Text = DsListar.Tables[0].Rows[0]["fecha_doc"].ToString();
                TxtFecha_reg.Text = DsListar.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtFecha_ven.Text = DsListar.Tables[0].Rows[0]["fecha_ven"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuarioE.Text = DsListar.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_dcomprav.Text = DsListar.Tables[0].Rows[0]["cod_dcompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarListado();
                Registros();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }
        #endregion

        #region LISTADO GENERAL

        private void CbBtipo()
        {
            CbBucar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Rif", "Nro. Cotizacion" });
        }

        private void OcultarColuumnasGen()
        {
            DataListadoGen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataListadoGen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListadoGen.Columns["cod_proveedor"].Visible = false;
            DataListadoGen.Columns["desc_proveedor"].Visible = true;
            DataListadoGen.Columns["rif"].Visible = true;
            DataListadoGen.Columns["cod_condicionpago"].Visible = false;
            DataListadoGen.Columns["desc_condicionpago"].Visible = false;
            DataListadoGen.Columns["diascredito"].Visible = false;
            DataListadoGen.Columns["cod_dcompra"].Visible = true;
            DataListadoGen.Columns["desc_dcompra"].Visible = false;
            DataListadoGen.Columns["optipo"].Visible = false;
            DataListadoGen.Columns["nacional"].Visible = false;
            DataListadoGen.Columns["numdocumento"].Visible = true;
            DataListadoGen.Columns["numcontrol"].Visible = true;
            DataListadoGen.Columns["doc_asociado"].Visible = false;
            DataListadoGen.Columns["origen"].Visible = false;
            DataListadoGen.Columns["estatus"].Visible = true;
            DataListadoGen.Columns["anulado"].Visible = false;
            DataListadoGen.Columns["monto_base"].Visible = true;
            DataListadoGen.Columns["monto_r"].Visible = false;
            DataListadoGen.Columns["monto_d"].Visible = false;
            DataListadoGen.Columns["monto_o"].Visible = false;
            DataListadoGen.Columns["monto_imp"].Visible = true;
            DataListadoGen.Columns["subtotal"].Visible = false;
            DataListadoGen.Columns["total"].Visible = true;
            DataListadoGen.Columns["saldo"].Visible = true;
            DataListadoGen.Columns["fecha_doc"].Visible = true;
            DataListadoGen.Columns["fecha_reg"].Visible = true;
            DataListadoGen.Columns["fecha_ven"].Visible = true;
            DataListadoGen.Columns["Campo1"].Visible = false;
            DataListadoGen.Columns["Campo2"].Visible = false;
            DataListadoGen.Columns["Campo3"].Visible = false;
            DataListadoGen.Columns["Campo4"].Visible = false;
            DataListadoGen.Columns["Campo5"].Visible = false;
            DataListadoGen.Columns["Campo6"].Visible = false;
            DataListadoGen.Columns["cod_usuario"].Visible = false;

            DataListadoGen.Columns["cod_dcompra"].HeaderText = "Codigo";
            DataListadoGen.Columns["desc_proveedor"].HeaderText = "Proveedor";
            DataListadoGen.Columns["rif"].HeaderText = "Rif";
            DataListadoGen.Columns["numdocumento"].HeaderText = "N° COT";
            DataListadoGen.Columns["numcontrol"].HeaderText = "N° CTROL";
            DataListadoGen.Columns["estatus"].HeaderText = "Estatus";
            DataListadoGen.Columns["monto_base"].HeaderText = "Sub Total";
            DataListadoGen.Columns["monto_imp"].HeaderText = "IVA";
            DataListadoGen.Columns["total"].HeaderText = "Total";
            DataListadoGen.Columns["saldo"].HeaderText = "Saldo";
            DataListadoGen.Columns["fecha_doc"].HeaderText = " F. Doc.";
            DataListadoGen.Columns["fecha_reg"].HeaderText = "F. Reg";
            DataListadoGen.Columns["fecha_ven"].HeaderText = "F. Venc.";

            DataListadoGen.Columns["monto_base"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListadoGen.Columns["monto_imp"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListadoGen.Columns["subtotal"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListadoGen.Columns["total"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListadoGen.Columns["saldo"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

            DataListadoGen.Columns["fecha_doc"].DefaultCellStyle.Format = Convert.ToString("dd/MM/yyyy");
            DataListadoGen.Columns["fecha_reg"].DefaultCellStyle.Format = Convert.ToString("dd/MM/yyyy");
            DataListadoGen.Columns["fecha_ven"].DefaultCellStyle.Format = Convert.ToString("dd/MM/yyyy");

            DataListadoGen.Columns["desc_proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataListadoGen.Columns["rif"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListadoGen.Columns["fecha_doc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListadoGen.Columns["fecha_reg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListadoGen.Columns["fecha_ven"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListadoGen.Columns["estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataListadoGen.Columns["numdocumento"].Width = 120;
            DataListadoGen.Columns["numcontrol"].Width = 120;
            DataListadoGen.Columns["desc_proveedor"].Width = 250;
            DataListadoGen.Columns["monto_base"].Width = 120;
            DataListadoGen.Columns["monto_imp"].Width = 120;
            DataListadoGen.Columns["subtotal"].Width = 120;
            DataListadoGen.Columns["total"].Width = 120;
            DataListadoGen.Columns["fecha_doc"].Width = 100;
            DataListadoGen.Columns["fecha_reg"].Width = 100;
            DataListadoGen.Columns["fecha_ven"].Width = 100;
        }

        private void MostrarListado()
        {
            DataListadoGen.DataSource = EDCompra.Mostrar();
            OcultarColuumnasGen();
                                                                             
            decimal ResultMonto_imp = 0;
            decimal ResultSubtotal = 0;
            decimal ResultTotal = 0;

            foreach (DataGridViewRow Fila in DataListadoGen.Rows)
            {
                bool Eanulado = Convert.ToBoolean(Fila.Cells["Anulado"].Value);

                if (ChkIncAnulados.Checked)
                {
                    if (Eanulado == false || Eanulado == true)
                    {
                        decimal Monto_imp = Convert.ToDecimal(Fila.Cells["monto_imp"].Value);
                        decimal SubTotal = Convert.ToDecimal(Fila.Cells["subtotal"].Value);
                        decimal Total = Convert.ToDecimal(Fila.Cells["Total"].Value);
                        ResultMonto_imp += Monto_imp;
                        ResultSubtotal += SubTotal;
                        ResultTotal += Total;
                    }
                }
                else
                {
                    if (Eanulado == false)
                    {
                        decimal Monto_imp = Convert.ToDecimal(Fila.Cells["monto_imp"].Value);
                        decimal SubTotal = Convert.ToDecimal(Fila.Cells["subtotal"].Value);
                        decimal Total = Convert.ToDecimal(Fila.Cells["Total"].Value);
                        ResultMonto_imp += Monto_imp;
                        ResultSubtotal += SubTotal;
                        ResultTotal += Total;
                    }

                }
                TxtSubTotalOp.Text = ResultSubtotal.ToString();
                TxtImpOp.Text = ResultMonto_imp.ToString();
                TxtTotalOp.Text = ResultTotal.ToString();

            }
        }

        private void SetDCompra()
        {
            TxtNacional.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["nacional"].Value);
            TxtCod_proveedor.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_proveedor"].Value);
            TxtDesc_proveedor.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["desc_proveedor"].Value);
            TxtRif.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["rif"].Value);
            TxtCod_condicionpago.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_condicionpago"].Value);
            TxtDesc_condicionpago.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["desc_condicionpago"].Value);
            TxtDiascredito.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["diascredito"].Value);
            TxtCod_dcompra.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_dcompra"].Value);
            TxtDesc_dcompra.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["desc_dcompra"].Value);
            TxtOptipo.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["optipo"].Value);
            TxtNumdocumento.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["numdocumento"].Value);
            TxtNumcontrol.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["numcontrol"].Value);
            TxtDoc_asociado.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["doc_asociado"].Value);
            TxtOrigen.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["origen"].Value);
            TxtEstatus.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["estatus"].Value);
            TxtAnulado.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["anulado"].Value);
            TxtMonto_base.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["monto_base"].Value);
            TxtMonto_r.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["monto_r"].Value);
            TxtMonto_d.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["monto_d"].Value);
            TxtMonto_o.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["monto_o"].Value);
            TxtMonto_imp.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["monto_imp"].Value);
            TxtSubtotal.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["subtotal"].Value);
            TxtTotal.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["total"].Value);
            TxtFecha_doc.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["fecha_doc"].Value);
            TxtFecha_reg.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["fecha_reg"].Value);
            TxtFecha_ven.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["fecha_ven"].Value);
            TxtCampo1.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["Campo1"].Value);
            TxtCampo2.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["Campo2"].Value);
            TxtCampo3.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["Campo3"].Value);
            TxtCampo4.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["Campo4"].Value);
            TxtCampo5.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["Campo5"].Value);
            TxtCampo6.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["Campo6"].Value);
            TxtCod_usuarioE.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_usuario"].Value);
            TxtEditar.Text = "Listar";
            MostrarListado();
            tabControl1.SelectedIndex = 0;
        }

        private void DataListadoGen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetDCompra();
        }

        private void Buscar()
        {
            if (CbBucar.Text == "Codigo")
            {
                DataListadoGen.DataSource = EDCompra.Buscar(TxtBuscar.Text, "cod");
            }
            else if (CbBucar.Text == "Proveedor")
            {
                DataListadoGen.DataSource = EDCompra.Buscar(TxtBuscar.Text, "Desc");
            }
            else if (CbBucar.Text == "Rif")
            {
                DataListadoGen.DataSource = EDCompra.Buscar(TxtBuscar.Text, "rif");
            }
            else if (CbBucar.Text == "Nro. Cotizacion")
            {
                DataListadoGen.DataSource = EDCompra.Buscar(TxtBuscar.Text, "num");
            }
            OcultarColuumnasGen();
        }

        private void ChkIncAnulados_CheckedChanged(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CbBucar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        #endregion

        #region TABLA DETALLES

        //internal void CalcularDetalle()
        //{
        //    decimal Monto_imp = 0;
        //    decimal Monto_d = 0;
        //    decimal SubTotal = 0;

        //    foreach (DataGridViewRow Fila in DataListado.Rows)
        //    {
        //        decimal Imp = Convert.ToDecimal(Fila.Cells["montoimp"].Value);
        //        decimal Descuento = Convert.ToDecimal(Fila.Cells["descuento"].Value);
        //        decimal Cantidad = Convert.ToDecimal(Fila.Cells["cantidad"].Value);
        //        decimal Subtotalund = Convert.ToDecimal(Fila.Cells["subtotalund"].Value);

        //        Monto_imp += Imp;
        //        Monto_d += Descuento;
        //        SubTotal += Subtotalund;
        //    }

        //    TxtMonto_imp.Text = Monto_imp.ToString();
        //    TxtMonto_d.Text = Monto_d.ToString();
        //    TxtSubtotal.Text = SubTotal.ToString();
        //}

        #endregion

        private void BtnPagar_Click(object sender, EventArgs e)
        {

        }

        private void TxtOrigen_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void TxtDesc_impuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarImpuesto();
        }

        private void CbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoDoc();
        }

        private void TxtDesc_tipodoc_TextChanged(object sender, EventArgs e)
        {
            TipoDoc();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
