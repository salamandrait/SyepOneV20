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
    public partial class FCCompra : Form
    {

        public bool Importar = false;
        public string TipoImp = "";
        internal DataTable DtDetalle;
        string Pref = "";
        DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();
        DialogResult Opcion;

        private static FCCompra _Instancia;

        public static FCCompra GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FCCompra();
            }
            return _Instancia;
        }

        public FCCompra()
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
            Dt = ECCompra.Mostrar();
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
            TxtCod_ccompra.Text = string.Empty;
            TxtDesc_ccompra.Text = string.Empty;
            TxtOptipo.Text = "CCompra";
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
                DataSet DsListar = ECCompra.Listar();

                TxtCod_ccompra.Text = DsListar.Tables[0].Rows[0]["Cod_ccompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_ccompra.Text = DsListar.Tables[0].Rows[0]["Desc_ccompra"].ToString();
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

                TxtCod_ccomprav.Text = DsListar.Tables[0].Rows[0]["Cod_ccompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalle();
            }
            catch (Exception Ex)
            {
                CrearTabla();
                Show();
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
                TxtEditar.Text = "Nuevo";
                Limpiar();
                string rpta = Ex.Message;
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
                int rpta = Convert.ToInt32(ECCompra.GenerarCod(TxtCod_ccompra.Text));
                TxtCod_ccompra.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_ccompra.Focus();
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
            TxtCod_ccompra.Enabled = valor;
            TxtDesc_ccompra.Enabled = valor;
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
            TxtCod_ccompra.Enabled = valor;
            TxtDesc_ccompra.Enabled = valor;
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
                BtnEliminarReng.Enabled = true;
                BtnOtros.Enabled = true;
                BtnArtCargar.Enabled = true;
                ChkEliminarReng.Enabled = true;

                ImportarChk.Visible = false;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Enabled = true;
                BtnOtros.Enabled = true;
                BtnArtCargar.Enabled = true;
                ChkEliminarReng.Enabled = true;

                ImportarChk.Visible = false;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Enabled = true;
                BtnOtros.Enabled = true;
                BtnArtCargar.Enabled = true;
                ChkEliminarReng.Enabled = true;

                ImportarChk.Visible = false;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Enabled = false;
                BtnOtros.Enabled = false;
                BtnArtCargar.Enabled = false;
                ChkEliminarReng.Enabled = false;

                ImportarChk.Visible = false;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Enabled = false;
                BtnOtros.Enabled = false;
                BtnArtCargar.Enabled = false;
                ChkEliminarReng.Enabled = false;

                ImportarChk.Visible = false;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Visible = false;
                BtnOtros.Enabled = false;
                BtnArtCargar.Visible = false;
                ChkEliminarReng.Visible = false;

                ImportarChk.Visible = true;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Visible = false;
                BtnOtros.Enabled = false;
                BtnArtCargar.Visible = false;
                ChkEliminarReng.Visible = false;

                ImportarChk.Visible = true;
                BtnAceptarImp.Visible = false;
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
                BtnEliminarReng.Visible = false;
                BtnOtros.Enabled = false;
                BtnArtCargar.Visible = false;
                ChkEliminarReng.Visible = false;

                ImportarChk.Visible = true;
                BtnAceptarImp.Visible = false;
                Habilitar(false);
            }
        }

        private void FCCompra_Load(object sender, EventArgs e)
        {
            Text = "...::: Cotizacion de Compra :::...";
            Listar();
            CbBtipo();
            CbBucar.Text = "Codigo";
        }

        private void FCCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FCCompra_FormClosing(object sender, FormClosingEventArgs e)
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
                else if (DataListado.Rows.Count == 0)
                {
                    MensajeError("No se Puede Guardar el Registro sin Reglones");
                    registrar = false;
                }
                else if (registrar)
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        GenerarCod();
                        Rpta = ECCompra.Insertar
                            (TxtCod_ccompra.Text, TxtCod_proveedor.Text, TxtCod_condicionpago.Text, TxtDesc_ccompra.Text, TxtOptipo.Text, TxtNumdocumento.Text, TxtNumcontrol.Text, TxtDoc_asociado.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), Convert.ToDecimal(TxtMonto_base.Text), Convert.ToDecimal(TxtMonto_r.Text), Convert.ToDecimal(TxtMonto_d.Text), Convert.ToDecimal(TxtMonto_o.Text), Convert.ToDecimal(TxtMonto_imp.Text), Convert.ToDecimal(TxtSubtotal.Text), Convert.ToDecimal(TxtTotal.Text), Convert.ToDateTime(TxtFecha_doc.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecha_ven.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        GuardarDetalle();
                        TxtCod_ccomprav.Text = TxtCod_ccompra.Text;
                        MostrarDetalle();
                        MostrarListado();
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = ECCompra.Editar
                            (TxtCod_ccompra.Text, TxtCod_ccomprav.Text, TxtCod_proveedor.Text, TxtCod_condicionpago.Text, TxtDesc_ccompra.Text, TxtOptipo.Text, TxtNumdocumento.Text, TxtNumcontrol.Text, TxtDoc_asociado.Text, TxtOrigen.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), Convert.ToDecimal(TxtMonto_base.Text), Convert.ToDecimal(TxtMonto_r.Text), Convert.ToDecimal(TxtMonto_d.Text), Convert.ToDecimal(TxtMonto_o.Text), Convert.ToDecimal(TxtMonto_imp.Text), Convert.ToDecimal(TxtSubtotal.Text), Convert.ToDecimal(TxtTotal.Text), Convert.ToDateTime(TxtFecha_doc.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecha_ven.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_usuario.Text);
                        TxtCod_ccomprav.Text = TxtCod_ccompra.Text;
                        MostrarDetalle();
                        MostrarListado();
                    }

                    if (TxtDoc_asociado.Text == "CCompra")
                    {
                        DialogResult Opcion = MessageBox.Show("Desesea Procesar la Cotizacion de Origen Nro  " + TxtOrigen.Text + " ?", "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            foreach (DataGridViewRow Row in DataListado.Rows)
                            {
                                Rpta = ECCompraDetalle.Importar(Convert.ToInt32(Row.Cells["rorigen"].Value));

                                DataTable DtD = ECCompraDetalle.Mostrar(TxtOrigen.Text);

                                Int32 Validar1 = 0;
                                Int32 Validar2 = Convert.ToInt32(DtD.Rows.Count);

                                foreach (DataRow RowT in DtD.Rows)
                                {
                                    if (Convert.ToString(RowT["estatus"]) == Convert.ToString("IMP"))
                                    {
                                        Int32 Validar0 = 1;
                                        Validar1 += Validar0;
                                    }
                                }

                                if (Validar2 == Validar1)
                                {
                                    Rpta = ECCompra.Procesar(TxtOrigen.Text, "Procesado", TxtCod_usuario.Text);
                                }
                                else if (Validar1 < Validar2)
                                {
                                    Rpta = ECCompra.Procesar(TxtOrigen.Text, "Procesado Parcial", TxtCod_usuario.Text);
                                }
                            }
                        }

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
            CrearTabla();
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
                string tipostock = "PED";
                if (Opcion == DialogResult.OK)
                {

                    foreach (DataGridViewRow Row in DataListado.Rows)
                    {
                        DataTable DtStock = EStockInventario.VerificarStock(Convert.ToString(Row.Cells["cod_deposito"].Value), Convert.ToString(Row.Cells["cod_articulo"].Value), tipostock);
                        foreach (DataRow RowS in DtStock.Rows)
                        {
                            decimal stockactual = Convert.ToDecimal(RowS["cantidad"]);
                        }
                    }

                    if (TxtDoc_asociado.Text == "CCompra")
                    {
                        foreach (DataGridViewRow Row in DataListado.Rows)
                        {
                            Rpta = ECCompraDetalle.EliminarImportar(Convert.ToInt32(Row.Cells["rorigen"].Value));

                            DataTable DtD = ECCompraDetalle.Mostrar(TxtOrigen.Text);

                            Int32 Validar1 = 0;
                            Int32 Validar2 = Convert.ToInt32(DtD.Rows.Count);

                            foreach (DataRow RowT in DtD.Rows)
                            {
                                if (Convert.ToString(RowT["estatus"]) == Convert.ToString("N"))
                                {
                                    Int32 Validar0 = 1;
                                    Validar1 += Validar0;
                                }
                            }

                            if (Validar2 == Validar1)
                            {
                                Rpta = ECCompra.Procesar(TxtOrigen.Text, "Sin Procesar", TxtCod_usuario.Text);
                            }
                            else if (Validar1 < Validar2)
                            {
                                Rpta = ECCompra.Procesar(TxtOrigen.Text, "Procesado Parcial", TxtCod_usuario.Text);
                            }
                        }
                    }

                    EliminarRenglon();
                    Rpta = ECCompra.Eliminar(TxtCod_ccompra.Text);

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
                    if (TxtDoc_asociado.Text == "CCompra")
                    {
                        foreach (DataGridViewRow Row in DataListado.Rows)
                        {
                            Rpta = ECCompraDetalle.EliminarImportar(Convert.ToInt32(Row.Cells["rorigen"].Value));

                            DataTable DtD = ECCompraDetalle.Mostrar(TxtOrigen.Text);

                            Int32 Validar1 = 0;
                            Int32 Validar2 = Convert.ToInt32(DtD.Rows.Count);

                            foreach (DataRow RowT in DtD.Rows)
                            {
                                if (Convert.ToString(RowT["estatus"]) == Convert.ToString("N"))
                                {
                                    Int32 Validar0 = 1;
                                    Validar1 += Validar0;
                                }
                            }

                            if (Validar2 == Validar1)
                            {
                                Rpta = ECCompra.Procesar(TxtOrigen.Text, "Sin Procesar", TxtCod_usuario.Text);
                            }
                            else if (Validar1 < Validar2)
                            {
                                Rpta = ECCompra.Procesar(TxtOrigen.Text, "Procesado Parcial", TxtCod_usuario.Text);
                            }
                        }
                    }

                    TxtEstatus.Text = "Anulado";
                    TxtAnulado.Text = true.ToString();

                    foreach (DataGridViewRow Row in DataListado.Rows)
                    {
                        Row.Cells["Anular"].Value = true.ToString();

                        if (Convert.ToBoolean(Row.Cells["Anular"].Value).Equals(true))
                        {
                            Rpta = ECCompraDetalle.Anular(Convert.ToString(Row.Cells["cod_ccompra"].Value));
                        }
                    }

                    Rpta = ECCompra.Anular(TxtCod_ccompra.Text, TxtEstatus.Text, Convert.ToBoolean(TxtAnulado.Text), TxtCod_usuario.Text);

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

        private void TxtDesc_ccompra_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_ccomprav_TextChanged(object sender, EventArgs e)
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
            if (TxtOrigen.Text != String.Empty)
            {
                ChkEliminarReng.Visible = false;
                BtnArtCargar.Visible = false;
            }
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

        private void TxtCod_ccompra_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void ChkNacional_CheckedChanged(object sender, EventArgs e)
        {
            EventosCheckBox();
        }

        private void TxtOptipo_TextChanged(object sender, EventArgs e)
        {
            if (TxtOptipo.Text == "CCompra")
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
        }

        private void TxtCod_proveedor_Validating(object sender, CancelEventArgs e)
        {
            DataTable Dt = ECCompra.Mostrar();
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
            DataTable Dt = ECCompra.Mostrar();
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
        private void TxtMonto_base_ValueChanged(object sender, EventArgs e)
        {
            TxtTotal.Value = TxtMonto_base.Value + TxtMonto_o.Value + TxtMonto_imp.Value;
        }

        private void TxtSubtotal_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_base.Value = (TxtSubtotal.Value + TxtMonto_r.Value) - TxtMonto_d.Value;
            CambiosTexBox();
        }

        private void TxtMonto_d_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_base.Value = (TxtSubtotal.Value + TxtMonto_r.Value) - TxtMonto_d.Value;
            CambiosTexBox();
        }

        private void TxtMonto_r_ValueChanged(object sender, EventArgs e)
        {
            TxtMonto_base.Value = (TxtSubtotal.Value + TxtMonto_r.Value) - TxtMonto_d.Value;
            CambiosTexBox();
        }

        private void TxtMonto_imp_ValueChanged(object sender, EventArgs e)
        {
            TxtTotal.Value = TxtMonto_base.Value + TxtMonto_o.Value + TxtMonto_imp.Value;
        }

        private void TxtMonto_o_ValueChanged(object sender, EventArgs e)
        {
            TxtTotal.Value = TxtMonto_base.Value + TxtMonto_o.Value + TxtMonto_imp.Value;
            CambiosTexBox();
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
                TxtFlag = "CCompra"
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
                    TxtFlag = "CCompra"
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
                TxtFlag = "CCompra"
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
                    TxtFlag = "CCompra"
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
            FOtros.txtFlag.Text = "CCompra";
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
                DataSet DsListar = ECCompra.Primero();

                TxtCod_ccompra.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_ccompra.Text = DsListar.Tables[0].Rows[0]["desc_ccompra"].ToString();
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
                TxtCod_ccomprav.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                DataSet DsListar = ECCompra.Anterior(TxtCod_ccompra.Text);

                TxtCod_ccompra.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_ccompra.Text = DsListar.Tables[0].Rows[0]["desc_ccompra"].ToString();
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
                TxtCod_ccomprav.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                DataSet DsListar = ECCompra.Siguiente(TxtCod_ccompra.Text);

                TxtCod_ccompra.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_ccompra.Text = DsListar.Tables[0].Rows[0]["desc_ccompra"].ToString();
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
                TxtCod_ccomprav.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
                DataSet DsListar = ECCompra.Ultimo();

                TxtCod_ccompra.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();
                TxtCod_proveedor.Text = DsListar.Tables[0].Rows[0]["cod_proveedor"].ToString();
                TxtDesc_proveedor.Text = DsListar.Tables[0].Rows[0]["desc_proveedor"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtNacional.Text = DsListar.Tables[0].Rows[0]["nacional"].ToString();
                TxtCod_condicionpago.Text = DsListar.Tables[0].Rows[0]["cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = DsListar.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = DsListar.Tables[0].Rows[0]["diascredito"].ToString();
                TxtDesc_ccompra.Text = DsListar.Tables[0].Rows[0]["desc_ccompra"].ToString();
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
                TxtCod_ccomprav.Text = DsListar.Tables[0].Rows[0]["cod_ccompra"].ToString();

                TxtEditar.Text = "Listar";
                MostrarDetalle();
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
            DataListadoGen.Columns["cod_ccompra"].Visible = true;
            DataListadoGen.Columns["desc_ccompra"].Visible = false;
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

            DataListadoGen.Columns["cod_ccompra"].HeaderText = "Codigo";
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
            DataListadoGen.DataSource = ECCompra.Mostrar();
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

        private void SetCCompra()
        {
            TxtNacional.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["nacional"].Value);
            TxtCod_proveedor.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_proveedor"].Value);
            TxtDesc_proveedor.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["desc_proveedor"].Value);
            TxtRif.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["rif"].Value);
            TxtCod_condicionpago.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_condicionpago"].Value);
            TxtDesc_condicionpago.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["desc_condicionpago"].Value);
            TxtDiascredito.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["diascredito"].Value);
            TxtCod_ccompra.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["cod_ccompra"].Value);
            TxtDesc_ccompra.Text = Convert.ToString(DataListadoGen.CurrentRow.Cells["desc_ccompra"].Value);
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
            MostrarDetalle();
            MostrarListado();
            tabControl1.SelectedIndex = 0;
        }

        private void DataListadoGen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCCompra();
        }

        private void Buscar()
        {
            if (CbBucar.Text == "Codigo")
            {
                DataListadoGen.DataSource = ECCompra.Buscar(TxtBuscar.Text, "cod");
            }
            else if (CbBucar.Text == "Proveedor")
            {
                DataListadoGen.DataSource = ECCompra.Buscar(TxtBuscar.Text, "Desc");
            }
            else if (CbBucar.Text == "Rif")
            {
                DataListadoGen.DataSource = ECCompra.Buscar(TxtBuscar.Text, "rif");
            }
            else if (CbBucar.Text == "Nro. Cotizacion")
            {
                DataListadoGen.DataSource = ECCompra.Buscar(TxtBuscar.Text, "num");
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
        internal void MostrarDetalle()
        {
            DataListado.DataSource = ECCompraDetalle.Mostrar(TxtCod_ccompra.Text);
            OcultarColumnas();
        }

        internal void OcultarColumnas()
        {
            DataListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataListado.Columns["Eliminar"].Visible = false;
            DataListado.Columns["Anular"].Visible = false;
            DataListado.Columns["Imp"].Visible = false;
            DataListado.Columns["reng"].Visible = false;
            DataListado.Columns["cod_ccompra"].Visible = false;
            DataListado.Columns["cod_impuesto"].Visible = false;
            DataListado.Columns["cod_deposito"].Visible = false;
            DataListado.Columns["cod_unidad"].Visible = false;
            DataListado.Columns["optipo"].Visible = false;
            DataListado.Columns["cod_articulo"].Visible = true;
            DataListado.Columns["desc_articulo"].Visible = true;
            DataListado.Columns["desc_deposito"].Visible = false;
            DataListado.Columns["desc_unidad"].Visible = true;
            DataListado.Columns["cantidad"].Visible = true;
            DataListado.Columns["equivalencia"].Visible = false;
            DataListado.Columns["montound"].Visible = true;
            DataListado.Columns["descuento"].Visible = true;
            DataListado.Columns["descuentop"].Visible = true;
            DataListado.Columns["subtotalund"].Visible = true;
            DataListado.Columns["desc_impuesto"].Visible = true;
            DataListado.Columns["tasaimp"].Visible = true;
            DataListado.Columns["montoimp"].Visible = true;
            DataListado.Columns["totalund"].Visible = true;
            DataListado.Columns["estatus"].Visible = false;
            DataListado.Columns["rorigen"].Visible = false;

            DataListado.Columns["cantidad"].DefaultCellStyle.Format = Convert.ToString("##0");
            DataListado.Columns["montound"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListado.Columns["descuento"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListado.Columns["descuentop"].DefaultCellStyle.Format = Convert.ToString("##0");
            DataListado.Columns["tasaimp"].DefaultCellStyle.Format = Convert.ToString("0");
            DataListado.Columns["montoimp"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListado.Columns["subtotalund"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListado.Columns["totalund"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");

            DataListado.Columns["cod_articulo"].HeaderText = "Codigo";
            DataListado.Columns["desc_articulo"].HeaderText = "Descripcion";
            DataListado.Columns["desc_unidad"].HeaderText = "Unidad";

            DataListado.Columns["cantidad"].HeaderText = "Cantidad";
            DataListado.Columns["montound"].HeaderText = "Costo. U";
            DataListado.Columns["descuento"].HeaderText = "Descuento";
            DataListado.Columns["descuentop"].HeaderText = "  % ";
            DataListado.Columns["desc_impuesto"].HeaderText = "Impuesto";
            DataListado.Columns["tasaimp"].HeaderText = "Tasa";
            DataListado.Columns["montoimp"].HeaderText = "IVA";
            DataListado.Columns["subtotalund"].HeaderText = "Sub Total";
            DataListado.Columns["totalund"].HeaderText = "Total";

            DataListado.Columns["cod_articulo"].Width = 120;
            DataListado.Columns["desc_articulo"].Width = 350;
            DataListado.Columns["desc_unidad"].Width = 100;
            DataListado.Columns["cantidad"].Width = 80;
            DataListado.Columns["montound"].Width = 120;
            DataListado.Columns["descuento"].Width = 100;
            DataListado.Columns["descuentop"].Width = 80;
            DataListado.Columns["desc_impuesto"].Width = 80;
            DataListado.Columns["tasaimp"].Width = 80;
            DataListado.Columns["montoimp"].Width = 120;
            DataListado.Columns["subtotalund"].Width = 120;
            DataListado.Columns["totalund"].Width = 120;

            DataListado.Columns["cod_articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["desc_articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataListado.Columns["desc_unidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["descuentop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["desc_impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["tasaimp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (ChkMasDetalles.CheckState == CheckState.Checked)
            {
                DataListado.Columns["descuentop"].Visible = true;
                DataListado.Columns["desc_impuesto"].Visible = true;
                DataListado.Columns["tasaimp"].Visible = true;
                DataListado.Columns["descuento"].Visible = true;
            }
            else if (ChkMasDetalles.CheckState == CheckState.Unchecked)
            {
                DataListado.Columns["descuentop"].Visible = false;
                DataListado.Columns["desc_impuesto"].Visible = false;
                DataListado.Columns["tasaimp"].Visible = false;
                DataListado.Columns["descuento"].Visible = false;
            }
        }

        internal void CrearTabla()
        {
            DtDetalle = new DataTable("DtCCompraDetalle");

            DtDetalle.Columns.Add("reng", Type.GetType("System.Int32"));
            DtDetalle.Columns.Add("cod_ccompra", Type.GetType("System.String"));
            DtDetalle.Columns.Add("cod_impuesto", Type.GetType("System.String"));
            DtDetalle.Columns.Add("cod_deposito", Type.GetType("System.String"));
            DtDetalle.Columns.Add("cod_unidad", Type.GetType("System.String"));
            DtDetalle.Columns.Add("optipo", Type.GetType("System.String"));
            DtDetalle.Columns.Add("cod_articulo", Type.GetType("System.String"));
            DtDetalle.Columns.Add("desc_articulo", Type.GetType("System.String"));
            DtDetalle.Columns.Add("desc_deposito", Type.GetType("System.String"));
            DtDetalle.Columns.Add("desc_unidad", Type.GetType("System.String"));
            DtDetalle.Columns.Add("cantidad", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("equivalencia", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("montound", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("descuento", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("descuentop", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("subtotalund", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("desc_impuesto", Type.GetType("System.String"));
            DtDetalle.Columns.Add("tasaimp", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("montoimp", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("totalund", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("estatus", Type.GetType("System.String"));
            DtDetalle.Columns.Add("rorigen", Type.GetType("System.Int32"));
            DataListado.DataSource = DtDetalle;
            OcultarColumnas();
            BtnArtCargar.Visible = true;
        }

        internal void CalcularDetalle()
        {
            decimal Monto_imp = 0;
            decimal Monto_d = 0;
            decimal SubTotal = 0;

            foreach (DataGridViewRow Fila in DataListado.Rows)
            {
                decimal Imp = Convert.ToDecimal(Fila.Cells["montoimp"].Value);
                decimal Descuento = Convert.ToDecimal(Fila.Cells["descuento"].Value);
                decimal Cantidad = Convert.ToDecimal(Fila.Cells["cantidad"].Value);
                decimal Subtotalund = Convert.ToDecimal(Fila.Cells["subtotalund"].Value);

                Monto_imp += Imp;
                Monto_d += Descuento;
                SubTotal += Subtotalund;
            }

            TxtMonto_imp.Text = Monto_imp.ToString();
            TxtMonto_d.Text = Monto_d.ToString();
            TxtSubtotal.Text = SubTotal.ToString();
        }

        private void ChkMasDetalles_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMasDetalles.CheckState == CheckState.Checked)
            {
                DataListado.Columns["descuentop"].Visible = true;
                DataListado.Columns["desc_impuesto"].Visible = true;
                DataListado.Columns["tasaimp"].Visible = true;
                DataListado.Columns["descuento"].Visible = true;
            }
            else if (ChkMasDetalles.CheckState == CheckState.Unchecked)
            {
                DataListado.Columns["descuentop"].Visible = false;
                DataListado.Columns["desc_impuesto"].Visible = false;
                DataListado.Columns["tasaimp"].Visible = false;
                DataListado.Columns["descuento"].Visible = false;
            }
        }

        public void AgregarColumnas(string reng, string cod_impuesto, string cod_deposito, string cod_unidad, string cod_articulo, string desc_articulo, string desc_deposito, string desc_unidad, string cantidad, string equivalencia, string montound, string descuento, string descuentop, string subtotalund, string desc_impuesto, string tasaimp, string montoimp, string totalund, string estatus, string rorigen)
        {
            try
            {
                DataRow Fila;
                Fila = DtDetalle.NewRow();
                Fila["reng"] = Convert.ToInt32(reng);
                Fila["cod_impuesto"] = cod_impuesto;
                Fila["cod_deposito"] = cod_deposito;
                Fila["cod_unidad"] = cod_unidad;
                Fila["optipo"] = TxtOptipo.Text;
                Fila["cod_articulo"] = cod_articulo;
                Fila["desc_articulo"] = desc_articulo;
                Fila["desc_deposito"] = desc_deposito;
                Fila["desc_unidad"] = desc_unidad;
                Fila["cantidad"] = Convert.ToDecimal(cantidad);
                Fila["equivalencia"] = Convert.ToDecimal(equivalencia);
                Fila["montound"] = Convert.ToDecimal(montound);
                Fila["descuento"] = Convert.ToDecimal(descuento);
                Fila["descuentop"] = Convert.ToDecimal(descuentop);
                Fila["subtotalund"] = Convert.ToDecimal(subtotalund);
                Fila["desc_impuesto"] = desc_impuesto;
                Fila["tasaimp"] = Convert.ToDecimal(tasaimp);
                Fila["montoimp"] = Convert.ToDecimal(montoimp);
                Fila["totalund"] = Convert.ToDecimal(totalund);
                Fila["estatus"] = estatus;
                Fila["rorigen"] = Convert.ToInt32(rorigen);
                DtDetalle.Rows.Add(Fila);
                DataListado.DataSource = DtDetalle;
                CalcularDetalle();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        private void QuitarRenglon()
        {
            int Fila = DataListado.CurrentCell.RowIndex;
            DataRow FilaDt = DtDetalle.Rows[Fila];
            DtDetalle.Rows.Remove(FilaDt);
            CalcularDetalle();
        }

        internal void EliminarRenglon()
        {
            foreach (DataGridViewRow Row in DataListado.Rows)
            {
                string Rpta = ECCompraDetalle.Eliminar(Convert.ToInt32(Row.Cells["reng"].Value));
            }
        }

        private void ChkEliminarReng_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEliminarReng.Checked)
            {
                DataListado.Columns["Eliminar"].Visible = true;
            }
            else
            {
                DataListado.Columns["Eliminar"].Visible = false;
            }
        }

        public void GuardarDetalle()
        {
            try
            {
                string Rpta = "";
                Int32 _rorigen;
                string _cod_ccompra, _cod_deposito, _cod_articulo, _cod_unidad, _cod_impuesto, _optipo;
                decimal _cantidad, _equivalencia, _montound, _descuento, _descuentop, _subtotalund, _montoimp, _totalund;

                foreach (DataGridViewRow row in DataListado.Rows)
                {
                    _cod_ccompra = TxtCod_ccompra.Text;
                    _cod_deposito = Convert.ToString(row.Cells["cod_deposito"].Value);
                    _cod_articulo = Convert.ToString(row.Cells["cod_articulo"].Value);
                    _cod_unidad = Convert.ToString(row.Cells["cod_unidad"].Value);
                    _cod_impuesto = Convert.ToString(row.Cells["cod_impuesto"].Value);
                    _optipo = TxtOptipo.Text;
                    _cantidad = Convert.ToDecimal(row.Cells["cantidad"].Value);
                    _equivalencia = Convert.ToDecimal(row.Cells["equivalencia"].Value);
                    _montound = Convert.ToDecimal(row.Cells["montound"].Value);
                    _descuento = Convert.ToDecimal(row.Cells["descuento"].Value);
                    _descuentop = Convert.ToDecimal(row.Cells["descuentop"].Value);
                    _subtotalund = Convert.ToDecimal(row.Cells["subtotalund"].Value);
                    _montoimp = Convert.ToDecimal(row.Cells["montoimp"].Value);
                    _totalund = Convert.ToDecimal(row.Cells["totalund"].Value);
                    _rorigen = Convert.ToInt32(row.Cells["rorigen"].Value);
                    Rpta = ECCompraDetalle.Insertar(_cod_ccompra, _cod_deposito, _cod_articulo, _cod_unidad, _cod_impuesto, _optipo, _cantidad, _equivalencia, _montound, _descuento, _descuentop, _subtotalund, _montoimp, _totalund, _rorigen);
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }

        }

        private void BtnEliminarReng_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            DialogResult Opcion;
            try
            {
                if (TxtEditar.Text == "Listar")
                {
                    if (DataListado.Rows.Count == 1)
                    {
                        Opcion = MessageBox.Show("El Documento contiene un solo registro, Desea Eliminar el Documento Completamente?", "Step One", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            EliminarRenglon();
                            Rpta = ECCompra.Eliminar(TxtCod_ccompra.Text);

                            if (Rpta.Equals("Y"))
                            {
                                MensajeOk("Registro Eliminado Correctamente!");
                            }
                            else
                            {
                                MensajeError(Rpta);
                            }
                            Botones();
                            Listar();
                        }
                    }
                    else if (DataListado.Rows.Count > 1)
                    {
                        Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "One Stage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {

                            foreach (DataGridViewRow Row in DataListado.Rows)
                            {
                                if (Convert.ToBoolean(Row.Cells["Eliminar"].Value).Equals(true))
                                {
                                    Rpta = ECCompraDetalle.Eliminar(Convert.ToInt32(Row.Cells["reng"].Value));
                                }
                            }

                            if (Rpta.Equals("Y"))
                            {
                                Botones();
                                Listar();
                                ChkEliminarReng.Checked = false;
                                MensajeOk("Registro Eliminado Correctamente!");
                            }
                            else
                            {
                                MensajeError(Rpta);
                            }

                        }
                        else
                        {
                            MensajeError("Cancelando Eliminacion de Registros");
                        }
                    }
                }
                else if (TxtEditar.Text == "Nuevo")
                {
                    QuitarRenglon();
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void DataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string reng, cod_ccompra, cod_deposito, cod_impuesto, optipo, cod_articulo, desc_articulo, desc_deposito, cod_unidad, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund;

                if (TxtEditar.Text == "Nuevo" && TxtEstatus.Text == "Sin Procesar" && Importar == false)
                {
                    FArtCargarC mForm = FArtCargarC.GetArtCargarC();
                    mForm.TxtFlag.Text = "CCompra";
                    mForm.TxtEditar.Text = "Nuevo";
                    reng = Convert.ToString(DataListado.CurrentRow.Cells["reng"].Value);
                    cod_ccompra = Convert.ToString(DataListado.CurrentRow.Cells["cod_ccompra"].Value);
                    cod_deposito = Convert.ToString(DataListado.CurrentRow.Cells["cod_deposito"].Value);
                    cod_impuesto = Convert.ToString(DataListado.CurrentRow.Cells["cod_impuesto"].Value);
                    optipo = Convert.ToString(DataListado.CurrentRow.Cells["optipo"].Value);
                    cod_articulo = Convert.ToString(DataListado.CurrentRow.Cells["cod_articulo"].Value);
                    desc_articulo = Convert.ToString(DataListado.CurrentRow.Cells["desc_articulo"].Value);
                    desc_deposito = Convert.ToString(DataListado.CurrentRow.Cells["desc_deposito"].Value);
                    cod_unidad = Convert.ToString(DataListado.CurrentRow.Cells["cod_unidad"].Value);
                    desc_unidad = Convert.ToString(DataListado.CurrentRow.Cells["desc_unidad"].Value);
                    cantidad = Convert.ToString(DataListado.CurrentRow.Cells["cantidad"].Value);
                    equivalencia = Convert.ToString(DataListado.CurrentRow.Cells["equivalencia"].Value);
                    montound = Convert.ToString(DataListado.CurrentRow.Cells["montound"].Value);
                    descuento = Convert.ToString(DataListado.CurrentRow.Cells["descuento"].Value);
                    descuentop = Convert.ToString(DataListado.CurrentRow.Cells["descuentop"].Value);
                    subtotalund = Convert.ToString(DataListado.CurrentRow.Cells["subtotalund"].Value);
                    desc_impuesto = Convert.ToString(DataListado.CurrentRow.Cells["desc_impuesto"].Value);
                    tasaimp = Convert.ToString(DataListado.CurrentRow.Cells["tasaimp"].Value);
                    montoimp = Convert.ToString(DataListado.CurrentRow.Cells["montoimp"].Value);
                    totalund = Convert.ToString(DataListado.CurrentRow.Cells["totalund"].Value);
                    QuitarRenglon();
                    mForm.SetColumnas(reng, cod_ccompra, cod_deposito, cod_impuesto, optipo, cod_articulo, desc_articulo, desc_deposito, cod_unidad, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund);
                    mForm.ShowDialog();
                }
                else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Sin Procesar" && Importar == false)
                {
                    FArtCargarC mForm = FArtCargarC.GetArtCargarC();
                    mForm.TxtFlag.Text = "CCompra";
                    mForm.TxtEditar.Text = "Editar";
                    mForm.TxtCod_compra.Text = TxtCod_ccompra.Text;
                    mForm.TxtOptipo.Text = TxtOptipo.Text;
                    reng = Convert.ToString(DataListado.CurrentRow.Cells["reng"].Value);
                    cod_ccompra = Convert.ToString(DataListado.CurrentRow.Cells["cod_ccompra"].Value);
                    cod_deposito = Convert.ToString(DataListado.CurrentRow.Cells["cod_deposito"].Value);
                    cod_impuesto = Convert.ToString(DataListado.CurrentRow.Cells["cod_impuesto"].Value);
                    optipo = Convert.ToString(DataListado.CurrentRow.Cells["optipo"].Value);
                    cod_articulo = Convert.ToString(DataListado.CurrentRow.Cells["cod_articulo"].Value);
                    desc_articulo = Convert.ToString(DataListado.CurrentRow.Cells["desc_articulo"].Value);
                    desc_deposito = Convert.ToString(DataListado.CurrentRow.Cells["desc_deposito"].Value);
                    cod_unidad = Convert.ToString(DataListado.CurrentRow.Cells["cod_unidad"].Value);
                    desc_unidad = Convert.ToString(DataListado.CurrentRow.Cells["desc_unidad"].Value);
                    cantidad = Convert.ToString(DataListado.CurrentRow.Cells["cantidad"].Value);
                    equivalencia = Convert.ToString(DataListado.CurrentRow.Cells["equivalencia"].Value);
                    montound = Convert.ToString(DataListado.CurrentRow.Cells["montound"].Value);
                    descuento = Convert.ToString(DataListado.CurrentRow.Cells["descuento"].Value);
                    descuentop = Convert.ToString(DataListado.CurrentRow.Cells["descuentop"].Value);
                    subtotalund = Convert.ToString(DataListado.CurrentRow.Cells["subtotalund"].Value);
                    desc_impuesto = Convert.ToString(DataListado.CurrentRow.Cells["desc_impuesto"].Value);
                    tasaimp = Convert.ToString(DataListado.CurrentRow.Cells["tasaimp"].Value);
                    montoimp = Convert.ToString(DataListado.CurrentRow.Cells["montoimp"].Value);
                    totalund = Convert.ToString(DataListado.CurrentRow.Cells["totalund"].Value);

                    string Rpta = ECCompraDetalle.Eliminar(Convert.ToInt32(DataListado.CurrentRow.Cells["reng"].Value));
                    MostrarDetalle();
                    CalcularDetalle();
                    mForm.SetColumnas(reng, cod_ccompra, cod_deposito, cod_impuesto, optipo, cod_articulo, desc_articulo, desc_deposito, cod_unidad, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund);
                    mForm.ShowDialog();
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void DataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataListado.Columns["Eliminar"].Index && TxtEstatus.Text == "Sin Procesar")
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

                BtnArtCargar.Visible = !Convert.ToBoolean(ChkEliminar.Value);
                BtnEliminarReng.Visible = Convert.ToBoolean(ChkEliminar.Value);
            }

            if (e.ColumnIndex == DataListado.Columns["Anular"].Index && TxtEstatus.Text == "Sin Procesar")
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }

            if (e.ColumnIndex == DataListado.Columns["Imp"].Index)
            {
                DataGridViewCheckBoxCell ChkImportar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Imp"];
                ChkImportar.Value = !Convert.ToBoolean(ChkImportar.Value);
                BtnAceptarImp.Visible = Convert.ToBoolean(ChkImportar.Value);
            }
        }

        private void BtnArtCargar_Click(object sender, EventArgs e)
        {
            if (TxtEditar.Text == "Nuevo")
            {
                FArtCargarC Cargar = FArtCargarC.GetArtCargarC();
                Cargar.TxtFlag.Text = "CCompra";
                Cargar.TxtEditar.Text = TxtEditar.Text;
                Cargar.ShowDialog();
            }
            else if (TxtEditar.Text == "Listar")
            {
                FArtCargarC Cargar = FArtCargarC.GetArtCargarC();
                Cargar.TxtFlag.Text = "CCompra";
                Cargar.TxtEditar.Text = "Editar";
                Cargar.TxtCod_compra.Text = TxtCod_ccompra.Text;
                Cargar.TxtOptipo.Text = TxtOptipo.Text;
                Cargar.ShowDialog();
            }
        }
        #endregion

        #region IMPORTAR
        internal void SetImportar(string cod_proveedor, string desc_proveedor, string rif, string cod_condicionpago, string desc_condicionpago, string diascredito, string desc_ccompra, string nacional, string doc_asociado, string cod_ccompra, string fecha_doc, string fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_proveedor.Text = cod_proveedor;
            TxtDesc_proveedor.Text = desc_proveedor;
            TxtRif.Text = rif;
            TxtCod_condicionpago.Text = cod_condicionpago;
            TxtDesc_condicionpago.Text = desc_condicionpago;
            TxtDiascredito.Text = diascredito;
            TxtDesc_ccompra.Text = desc_ccompra;
            TxtNacional.Text = nacional;
            TxtDoc_asociado.Text = doc_asociado;
            TxtOrigen.Text = cod_ccompra;
            TxtFecha_doc.Text = fecha_doc;
            TxtFecha_ven.Text = fecha_ven;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }


        private void BtnImportar_Click(object sender, EventArgs e)
        {
            FImportar mFrom = new FImportar
            {
                FlagOpcion = TxtOptipo.Text,
            };
            mFrom.ShowDialog();
        }

        private void BtnAceptarImp_Click(object sender, EventArgs e)
        {
            try
            {
                #region PARAMETROS
                string cod_proveedor, desc_proveedor, rif, cod_condicionpago, desc_condicionpago, diascredito, desc_compra, nacional, doc_asociado, origen, monto_base, monto_r, monto_d, monto_o, monto_imp, subtotal, total, fecha_doc, fecha_ven, campo1, campo2, campo3, campo4, campo5, campo6;

                string reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, estatus, rorigen;

                cod_proveedor = TxtCod_proveedor.Text;
                desc_proveedor = TxtDesc_proveedor.Text;
                rif = TxtRif.Text;
                cod_condicionpago = TxtCod_condicionpago.Text;
                desc_condicionpago = TxtDesc_condicionpago.Text;
                diascredito = TxtDiascredito.Text;
                desc_compra = TxtDesc_ccompra.Text;
                nacional = TxtNacional.Text;
                doc_asociado = TxtOptipo.Text;
                origen = TxtCod_ccompra.Text;
                monto_base = TxtMonto_base.Text;
                monto_r = TxtMonto_r.Text;
                monto_d = TxtMonto_d.Text;
                monto_o = TxtMonto_o.Text;
                monto_imp = TxtMonto_imp.Text;
                subtotal = TxtSubtotal.Text;
                total = TxtTotal.Text;
                fecha_doc = TxtFecha_doc.Text;
                fecha_ven = TxtFecha_ven.Text;
                campo1 = TxtCampo1.Text;
                campo2 = TxtCampo2.Text;
                campo3 = TxtCampo3.Text;
                campo4 = TxtCampo4.Text;
                campo5 = TxtCampo5.Text;
                campo6 = TxtCampo6.Text;
                #endregion

                FCCompra ImpC = GetForm();
                FPCompra ImpP = FPCompra.GetForm();
                FFCompra ImpF = FFCompra.GetForm();

                if (TipoImp == "FCompra" && Importar == true)
                {
                    if (ImpF.TxtCod_proveedor.Text == String.Empty)
                    {
                        ImpF.SetImportar(cod_proveedor, desc_proveedor, rif, cod_condicionpago, desc_condicionpago, diascredito, desc_compra, nacional, doc_asociado, origen, fecha_doc, fecha_ven, campo1, campo2, campo3, campo4, campo5, campo6);
                    }

                    foreach (DataGridViewRow Row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells["Imp"].Value).Equals(true))
                        {
                            if (Convert.ToString(Row.Cells["estatus"].Value).Equals("N"))
                            {
                                reng = Convert.ToString(Row.Cells["reng"].Value);
                                cod_impuesto = Convert.ToString(Row.Cells["cod_impuesto"].Value);
                                cod_deposito = Convert.ToString(Row.Cells["cod_deposito"].Value);
                                cod_unidad = Convert.ToString(Row.Cells["cod_unidad"].Value);
                                cod_articulo = Convert.ToString(Row.Cells["cod_articulo"].Value);
                                desc_articulo = Convert.ToString(Row.Cells["desc_articulo"].Value);
                                desc_deposito = Convert.ToString(Row.Cells["desc_deposito"].Value);
                                desc_unidad = Convert.ToString(Row.Cells["desc_unidad"].Value);
                                cantidad = Convert.ToString(Row.Cells["cantidad"].Value);
                                equivalencia = Convert.ToString(Row.Cells["equivalencia"].Value);
                                montound = Convert.ToString(Row.Cells["montound"].Value);
                                descuento = Convert.ToString(Row.Cells["descuento"].Value);
                                descuentop = Convert.ToString(Row.Cells["descuentop"].Value);
                                subtotalund = Convert.ToString(Row.Cells["subtotalund"].Value);
                                desc_impuesto = Convert.ToString(Row.Cells["desc_impuesto"].Value);
                                tasaimp = Convert.ToString(Row.Cells["tasaimp"].Value);
                                montoimp = Convert.ToString(Row.Cells["montoimp"].Value);
                                totalund = Convert.ToString(Row.Cells["totalund"].Value);
                                estatus = Convert.ToString(Row.Cells["estatus"].Value);
                                rorigen = Convert.ToString(Row.Cells["reng"].Value);

                                ImpF.AgregarColumnas(reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, estatus, rorigen);
                            }
                            else if (Convert.ToString(Row.Cells["estatus"].Value).Equals("IMP"))
                            {
                                MensajeError("El Renglon del Articulo Codigo = " + Convert.ToString(Row.Cells["cod_articulo"].Value) + " ya Fue Procesado y no puede Importarse");
                            }
                        }
                    }
                    ImpF.BtnArtCargar.Enabled = false;
                    ImpF.BtnImportar.Enabled = false;
                    Close();
                }
                else if (TipoImp == "CCompra" && Importar == true)
                {
                    if (ImpC.TxtCod_proveedor.Text == String.Empty)
                    {
                        ImpC.SetImportar(cod_proveedor, desc_proveedor, rif, cod_condicionpago, desc_condicionpago, diascredito, desc_compra, nacional, doc_asociado, origen, fecha_doc, fecha_ven, campo1, campo2, campo3, campo4, campo5, campo6);
                    }

                    foreach (DataGridViewRow Row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells["Imp"].Value).Equals(true))
                        {
                            reng = Convert.ToString(Row.Cells["reng"].Value);
                            cod_impuesto = Convert.ToString(Row.Cells["cod_impuesto"].Value);
                            cod_deposito = Convert.ToString(Row.Cells["cod_deposito"].Value);
                            cod_unidad = Convert.ToString(Row.Cells["cod_unidad"].Value);
                            cod_articulo = Convert.ToString(Row.Cells["cod_articulo"].Value);
                            desc_articulo = Convert.ToString(Row.Cells["desc_articulo"].Value);
                            desc_deposito = Convert.ToString(Row.Cells["desc_deposito"].Value);
                            desc_unidad = Convert.ToString(Row.Cells["desc_unidad"].Value);
                            cantidad = Convert.ToString(Row.Cells["cantidad"].Value);
                            equivalencia = Convert.ToString(Row.Cells["equivalencia"].Value);
                            montound = Convert.ToString(Row.Cells["montound"].Value);
                            descuento = Convert.ToString(Row.Cells["descuento"].Value);
                            descuentop = Convert.ToString(Row.Cells["descuentop"].Value);
                            subtotalund = Convert.ToString(Row.Cells["subtotalund"].Value);
                            desc_impuesto = Convert.ToString(Row.Cells["desc_impuesto"].Value);
                            tasaimp = Convert.ToString(Row.Cells["tasaimp"].Value);
                            montoimp = Convert.ToString(Row.Cells["montoimp"].Value);
                            totalund = Convert.ToString(Row.Cells["totalund"].Value);
                            estatus = Convert.ToString(Row.Cells["estatus"].Value);
                            rorigen = Convert.ToString(Row.Cells["reng"].Value);

                            ImpC.AgregarColumnas(reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, estatus, rorigen);
                        }
                    }
                    ImpC.BtnArtCargar.Enabled = false;
                    ImpC.BtnImportar.Enabled = false;
                    Close();
                }
                else if (TipoImp == "PCompra" && Importar == true)
                {
                    if (ImpP.TxtCod_proveedor.Text == String.Empty)
                    {
                        ImpP.SetImportar(cod_proveedor, desc_proveedor, rif, cod_condicionpago, desc_condicionpago, diascredito, desc_compra, nacional, doc_asociado, origen, fecha_doc, fecha_ven, campo1, campo2, campo3, campo4, campo5, campo6);
                    }

                    foreach (DataGridViewRow Row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells["Imp"].Value).Equals(true))
                        {
                            if (Convert.ToString(Row.Cells["estatus"].Value).Equals("N"))
                            {
                                reng = Convert.ToString(Row.Cells["reng"].Value);
                                cod_impuesto = Convert.ToString(Row.Cells["cod_impuesto"].Value);
                                cod_deposito = Convert.ToString(Row.Cells["cod_deposito"].Value);
                                cod_unidad = Convert.ToString(Row.Cells["cod_unidad"].Value);
                                cod_articulo = Convert.ToString(Row.Cells["cod_articulo"].Value);
                                desc_articulo = Convert.ToString(Row.Cells["desc_articulo"].Value);
                                desc_deposito = Convert.ToString(Row.Cells["desc_deposito"].Value);
                                desc_unidad = Convert.ToString(Row.Cells["desc_unidad"].Value);
                                cantidad = Convert.ToString(Row.Cells["cantidad"].Value);
                                equivalencia = Convert.ToString(Row.Cells["equivalencia"].Value);
                                montound = Convert.ToString(Row.Cells["montound"].Value);
                                descuento = Convert.ToString(Row.Cells["descuento"].Value);
                                descuentop = Convert.ToString(Row.Cells["descuentop"].Value);
                                subtotalund = Convert.ToString(Row.Cells["subtotalund"].Value);
                                desc_impuesto = Convert.ToString(Row.Cells["desc_impuesto"].Value);
                                tasaimp = Convert.ToString(Row.Cells["tasaimp"].Value);
                                montoimp = Convert.ToString(Row.Cells["montoimp"].Value);
                                totalund = Convert.ToString(Row.Cells["totalund"].Value);
                                estatus = Convert.ToString(Row.Cells["estatus"].Value);
                                rorigen = Convert.ToString(Row.Cells["reng"].Value);

                                ImpP.AgregarColumnas(reng, cod_impuesto, cod_deposito, cod_unidad, cod_articulo, desc_articulo, desc_deposito, desc_unidad, cantidad, equivalencia, montound, descuento, descuentop, subtotalund, desc_impuesto, tasaimp, montoimp, totalund, estatus, rorigen);
                            }
                            else if (Convert.ToString(Row.Cells["estatus"].Value).Equals("IMP"))
                            {
                                MensajeError("El Renglon del Articulo Codigo = " + Convert.ToString(Row.Cells["cod_articulo"].Value) + " ya Fue Procesado y no puede Importarse");
                            }
                        }
                    }
                    ImpP.BtnArtCargar.Enabled = false;
                    ImpP.BtnImportar.Enabled = false;
                    Close();
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void ImportarChk_CheckedChanged(object sender, EventArgs e)
        {
            if (ImportarChk.Checked == true)
            {
                DataListado.Columns["Imp"].Visible = true;
                DataListado.Columns["Imp"].Width = 50;
            }
            else if (ImportarChk.Checked == false)
            {
                DataListado.Columns["Imp"].Visible = false;
                DataListado.Columns["Imp"].Width = 50;
            }
        }

        #endregion

        private void BtnPagar_Click(object sender, EventArgs e)
        {

        }

        private void TxtOrigen_VisibleChanged(object sender, EventArgs e)
        {
            if (TxtOrigen.Text != String.Empty)
            {
                ChkEliminarReng.Visible = false;
                BtnArtCargar.Visible = false;
            }
        }
    }
}
