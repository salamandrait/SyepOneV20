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
    public partial class FCliente : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        string Tiposeg = "P";
        DialogResult Opcion;

        private static FCliente _Instancia;

        public static FCliente GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FCliente();
            }
            return _Instancia;
        }

        public FCliente()
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
            Dt = ECliente.Mostrar();
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
            if (ChkCopiar.Checked == true)
            {
                TxtCod_cliente.Text = string.Empty;
                ChkCopiar.Checked = false;
            }
            else
            {
                TxtCod_cliente.Text = string.Empty;
                TxtDesc_cliente.Text = string.Empty;
                TxtActivo.Text = true.ToString();
                TxtNacional.Text = true.ToString();
                TxtAplica_credito.Text = false.ToString();
                TxtClasificacion.Text = "Principal";
                TxtRif.Text = string.Empty;
                TxtContacto.Text = string.Empty;
                TxtDireccion.Text = string.Empty;
                TxtDireccion_alterna.Text = string.Empty;
                TxtCiudad.Text = string.Empty;
                TxtTelefono.Text = string.Empty;
                TxtMovil.Text = string.Empty;
                TxtCod_postal.Text = string.Empty;
                TxtWeb.Text = string.Empty;
                TxtEmail.Text = string.Empty;
                TxtMontofiscal.Text = string.Empty;
                TxtDescuentopp.Text = string.Empty;
                TxtDescuentogb.Text = string.Empty;
                TxtLimite_cred.Text = string.Empty;
                TxtFecha_reg.Text = string.Empty;
                TxtCampo1.Text = string.Empty;
                TxtCampo2.Text = string.Empty;
                TxtCampo3.Text = string.Empty;
                TxtCampo4.Text = string.Empty;
                TxtCampo5.Text = string.Empty;
                TxtCampo6.Text = string.Empty;

                TxtCod_tipocliente.Text = string.Empty;
                TxtDesc_tipocliente.Text = string.Empty;
                TxtCod_segmento.Text = string.Empty;
                TxtDesc_segmento.Text = string.Empty;
                TxtCod_condicionpago.Text = string.Empty;
                TxtDesc_condicionpago.Text = string.Empty;
                TxtDiascredito.Text = string.Empty;
                TxtCod_zona.Text = string.Empty;
                TxtDesc_zona.Text = string.Empty;
                TxtCod_pais.Text = string.Empty;
                TxtDesc_pais.Text = string.Empty;
                TxtCod_moneda.Text = string.Empty;
                TxtDesc_moneda.Text = string.Empty;
                TxtCod_cuentasie.Text = string.Empty;
                TxtDesc_cuentasie.Text = string.Empty;
                TxtCod_islr.Text = "PJD";
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

        private void EventoClasificar()
        {
            if (RbPrincipal.Checked == true)
            {
                TxtClasificacion.Text = "Principal";
            }
            else if (RbSucursal.Checked == true)
            {
                TxtClasificacion.Text = "Sucursal";
            }

            if (TxtClasificacion.Text == "Principal")
            {
                RbPrincipal.Checked = true;
            }
            else if (TxtClasificacion.Text == "Sucursal")
            {
                RbSucursal.Checked = true;
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

            if (ChkNacional.Checked == true)
            {
                TxtNacional.Text = true.ToString();
            }
            else
            {
                TxtNacional.Text = false.ToString();
            }

            if (ChkCredito.Checked == true)
            {
                TxtAplica_credito.Text = true.ToString();
            }
            else
            {
                TxtAplica_credito.Text = false.ToString();
            }

            if (ChkFiscal.Checked == true)
            {
                TxtFiscal.Text = true.ToString();
            }
            else
            {
                TxtFiscal.Text = false.ToString();
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

            if (TxtNacional.Text == true.ToString())
            {
                ChkNacional.Checked = true;
            }
            else
            {
                ChkNacional.Checked = false;
            }

            if (TxtAplica_credito.Text == true.ToString())
            {
                ChkCredito.Checked = true;
            }
            else
            {
                ChkCredito.Checked = false;
            }

            if (TxtFiscal.Text == true.ToString())
            {
                ChkFiscal.Checked = true;
            }
            else
            {
                ChkFiscal.Checked = false;
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

        public void Listar()
        {
            try
            {
                Ds = ECliente.Listar();

                TxtCod_cliente.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtCod_clientev.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtDesc_cliente.Text = Ds.Tables[0].Rows[0]["Desc_cliente"].ToString();
                TxtClasificacion.Text = Ds.Tables[0].Rows[0]["Clasificacion"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["Rif"].ToString();
                TxtContacto.Text = Ds.Tables[0].Rows[0]["Contacto"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["Direccion"].ToString();
                TxtDireccion_alterna.Text = Ds.Tables[0].Rows[0]["Direccion_alterna"].ToString();
                TxtCiudad.Text = Ds.Tables[0].Rows[0]["Ciudad"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["Telefono"].ToString();
                TxtMovil.Text = Ds.Tables[0].Rows[0]["Movil"].ToString();
                TxtCod_postal.Text = Ds.Tables[0].Rows[0]["Cod_postal"].ToString();
                TxtWeb.Text = Ds.Tables[0].Rows[0]["Web"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["Email"].ToString();
                TxtMontofiscal.Text = Ds.Tables[0].Rows[0]["Montofiscal"].ToString();
                TxtDescuentopp.Text = Ds.Tables[0].Rows[0]["Descuentopp"].ToString();
                TxtDescuentogb.Text = Ds.Tables[0].Rows[0]["Descuentogb"].ToString();
                TxtLimite_cred.Text = Ds.Tables[0].Rows[0]["Limite_cred"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["Activo"].ToString();
                TxtNacional.Text = Ds.Tables[0].Rows[0]["Nacional"].ToString();
                TxtFiscal.Text = Ds.Tables[0].Rows[0]["Fiscal"].ToString();
                TxtAplica_credito.Text = Ds.Tables[0].Rows[0]["Aplica_credito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["Cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["Desc_vendedor"].ToString();
                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["Cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["Desc_tipocliente"].ToString();
                TxtCod_segmento.Text = Ds.Tables[0].Rows[0]["Cod_segmento"].ToString();
                TxtDesc_segmento.Text = Ds.Tables[0].Rows[0]["desc_segmento"].ToString();
                TxtCod_condicionpago.Text = Ds.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = Ds.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = Ds.Tables[0].Rows[0]["diascredito"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["Cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["Cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtCod_pais.Text = Ds.Tables[0].Rows[0]["Cod_pais"].ToString();
                TxtDesc_pais.Text = Ds.Tables[0].Rows[0]["desc_pais"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["Cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_zona.Text = Ds.Tables[0].Rows[0]["Cod_zona"].ToString();
                TxtDesc_zona.Text = Ds.Tables[0].Rows[0]["desc_zona"].ToString();
                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Ex)
            {
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_cliente.Focus();
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

                if (TxtCod_cliente.Text == string.Empty || TxtDesc_cliente.Text == string.Empty || TxtCod_tipocliente.Text == string.Empty || TxtCod_segmento.Text == string.Empty || TxtCod_condicionpago.Text == string.Empty || TxtCod_zona.Text == string.Empty || TxtCod_pais.Text == string.Empty || TxtCod_moneda.Text == string.Empty || TxtCod_cuentasie.Text == string.Empty || TxtCod_vendedor.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_cliente, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_cliente, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_tipocliente, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_segmento, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_zona, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_pais, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_condicionpago, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_cuentasie, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_vendedor, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = ECliente.Insertar(TxtCod_cliente.Text.Trim(), TxtDesc_cliente.Text, TxtClasificacion.Text, TxtRif.Text, TxtContacto.Text, TxtDireccion.Text, TxtDireccion_alterna.Text, TxtCiudad.Text, TxtTelefono.Text, TxtMovil.Text, TxtCod_postal.Text, TxtWeb.Text, TxtEmail.Text, Convert.ToDecimal(TxtMontofiscal.Text), Convert.ToDecimal(TxtDescuentopp.Text), Convert.ToDecimal(TxtDescuentogb.Text), Convert.ToDecimal(TxtLimite_cred.Text), Convert.ToBoolean(TxtActivo.Text), Convert.ToBoolean(TxtNacional.Text), Convert.ToBoolean(TxtFiscal.Text), Convert.ToBoolean(TxtAplica_credito.Text), Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_vendedor.Text,TxtCod_tipocliente.Text, TxtCod_segmento.Text, TxtCod_condicionpago.Text, TxtCod_cuentasie.Text, TxtCod_islr.Text, TxtCod_pais.Text, TxtCod_zona.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = ECliente.Editar(TxtCod_cliente.Text.Trim(), TxtCod_clientev.Text.Trim(), TxtDesc_cliente.Text, TxtClasificacion.Text, TxtRif.Text, TxtContacto.Text, TxtDireccion.Text, TxtDireccion_alterna.Text, TxtCiudad.Text, TxtTelefono.Text, TxtMovil.Text, TxtCod_postal.Text, TxtWeb.Text, TxtEmail.Text, Convert.ToDecimal(TxtMontofiscal.Text), Convert.ToDecimal(TxtDescuentopp.Text), Convert.ToDecimal(TxtDescuentogb.Text), Convert.ToDecimal(TxtLimite_cred.Text), Convert.ToBoolean(TxtActivo.Text), Convert.ToBoolean(TxtNacional.Text), Convert.ToBoolean(TxtFiscal.Text), Convert.ToBoolean(TxtAplica_credito.Text), Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, TxtCod_vendedor.Text, TxtCod_tipocliente.Text, TxtCod_segmento.Text, TxtCod_condicionpago.Text, TxtCod_cuentasie.Text, TxtCod_islr.Text, TxtCod_pais.Text, TxtCod_zona.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_clientev.Text = TxtCod_cliente.Text;
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
                int rpta = Convert.ToInt32(ECliente.GenerarCod(TxtCod_cliente.Text));
                TxtCod_cliente.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_cliente.Focus();
            }
        }

        internal void SetCliente(string cod_cliente, string desc_cliente, string clasificacion, string rif, string contacto, string direccion, string direccion_alterna, string ciudad, string telefono, string movil, string cod_postal, string web, string email, string montofiscal, string descuentopp, string descuentogb, string limite_cred, string activo, string nacional, string fiscal, string aplica_credito, string fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_vendedor, string desc_vendedor,string cod_tipocliente, string desc_tipocliente, string cod_segmento, string desc_segmento, string cod_condicionpago, string desc_condicionpago, string diascredito, string cod_cuentasie, string desc_cuentasie, string cod_islr, string desc_islr, string cod_pais, string desc_pais, string cod_moneda, string desc_moneda, string cod_zona, string desc_zona)
        {
            TxtCod_cliente.Text = cod_cliente;
            TxtCod_clientev.Text = cod_cliente;
            TxtDesc_cliente.Text = desc_cliente;
            TxtClasificacion.Text = clasificacion;
            TxtRif.Text = rif;
            TxtContacto.Text = contacto;
            TxtDireccion.Text = direccion;
            TxtDireccion_alterna.Text = direccion_alterna;
            TxtCiudad.Text = ciudad;
            TxtTelefono.Text = telefono;
            TxtMovil.Text = movil;
            TxtCod_postal.Text = cod_postal;
            TxtWeb.Text = web;
            TxtEmail.Text = email;
            TxtMontofiscal.Text = montofiscal;
            TxtDescuentopp.Text = descuentopp;
            TxtDescuentogb.Text = descuentogb;
            TxtLimite_cred.Text = limite_cred;
            TxtActivo.Text = activo;
            TxtNacional.Text = nacional;
            TxtFiscal.Text = fiscal;
            TxtAplica_credito.Text = aplica_credito;
            TxtFecha_reg.Text = fecha_reg;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
            TxtCod_vendedor.Text = cod_vendedor;
            TxtDesc_vendedor.Text = desc_vendedor;
            TxtCod_tipocliente.Text = cod_tipocliente;
            TxtDesc_tipocliente.Text = desc_tipocliente;
            TxtCod_segmento.Text = cod_segmento;
            TxtDesc_segmento.Text = desc_segmento;
            TxtCod_condicionpago.Text = cod_condicionpago;
            TxtDesc_condicionpago.Text = desc_condicionpago;
            TxtDiascredito.Text = diascredito;
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
            TxtCod_islr.Text = cod_islr;
            TxtDesc_islr.Text = desc_islr;
            TxtCod_pais.Text = cod_pais;
            TxtDesc_pais.Text = desc_pais;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtCod_zona.Text = cod_zona;
            TxtDesc_zona.Text = desc_zona;
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            Text = "...::: Clientes :::...";
            MostraUsuario();
            Listar();
            EventoClasificar();
            EventosChk();
            EventoComboBOX();
        }

        private void FCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FCliente_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_cliente.Focus();
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
                    Rpta = ECliente.Eliminar(TxtCod_cliente.Text);

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
            FClienteLista Listado = new FClienteLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptCliente Reporte = new FRptCliente();
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
                Ds = ECliente.Primero();

                TxtCod_cliente.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtCod_clientev.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtDesc_cliente.Text = Ds.Tables[0].Rows[0]["Desc_cliente"].ToString();
                TxtClasificacion.Text = Ds.Tables[0].Rows[0]["Clasificacion"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["Rif"].ToString();
                TxtContacto.Text = Ds.Tables[0].Rows[0]["Contacto"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["Direccion"].ToString();
                TxtDireccion_alterna.Text = Ds.Tables[0].Rows[0]["Direccion_alterna"].ToString();
                TxtCiudad.Text = Ds.Tables[0].Rows[0]["Ciudad"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["Telefono"].ToString();
                TxtMovil.Text = Ds.Tables[0].Rows[0]["Movil"].ToString();
                TxtCod_postal.Text = Ds.Tables[0].Rows[0]["Cod_postal"].ToString();
                TxtWeb.Text = Ds.Tables[0].Rows[0]["Web"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["Email"].ToString();
                TxtMontofiscal.Text = Ds.Tables[0].Rows[0]["Montofiscal"].ToString();
                TxtDescuentopp.Text = Ds.Tables[0].Rows[0]["Descuentopp"].ToString();
                TxtDescuentogb.Text = Ds.Tables[0].Rows[0]["Descuentogb"].ToString();
                TxtLimite_cred.Text = Ds.Tables[0].Rows[0]["Limite_cred"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["Activo"].ToString();
                TxtNacional.Text = Ds.Tables[0].Rows[0]["Nacional"].ToString();
                TxtFiscal.Text = Ds.Tables[0].Rows[0]["Fiscal"].ToString();
                TxtAplica_credito.Text = Ds.Tables[0].Rows[0]["Aplica_credito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["Cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["Desc_vendedor"].ToString();
                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["Cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["Desc_tipocliente"].ToString();
                TxtCod_segmento.Text = Ds.Tables[0].Rows[0]["Cod_segmento"].ToString();
                TxtDesc_segmento.Text = Ds.Tables[0].Rows[0]["desc_segmento"].ToString();
                TxtCod_condicionpago.Text = Ds.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = Ds.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = Ds.Tables[0].Rows[0]["diascredito"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["Cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["Cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtCod_pais.Text = Ds.Tables[0].Rows[0]["Cod_pais"].ToString();
                TxtDesc_pais.Text = Ds.Tables[0].Rows[0]["desc_pais"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["Cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_zona.Text = Ds.Tables[0].Rows[0]["Cod_zona"].ToString();
                TxtDesc_zona.Text = Ds.Tables[0].Rows[0]["desc_zona"].ToString();

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
                Ds = ECliente.Anterior(TxtCod_cliente.Text);

                TxtCod_cliente.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtCod_clientev.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtDesc_cliente.Text = Ds.Tables[0].Rows[0]["Desc_cliente"].ToString();
                TxtClasificacion.Text = Ds.Tables[0].Rows[0]["Clasificacion"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["Rif"].ToString();
                TxtContacto.Text = Ds.Tables[0].Rows[0]["Contacto"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["Direccion"].ToString();
                TxtDireccion_alterna.Text = Ds.Tables[0].Rows[0]["Direccion_alterna"].ToString();
                TxtCiudad.Text = Ds.Tables[0].Rows[0]["Ciudad"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["Telefono"].ToString();
                TxtMovil.Text = Ds.Tables[0].Rows[0]["Movil"].ToString();
                TxtCod_postal.Text = Ds.Tables[0].Rows[0]["Cod_postal"].ToString();
                TxtWeb.Text = Ds.Tables[0].Rows[0]["Web"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["Email"].ToString();
                TxtMontofiscal.Text = Ds.Tables[0].Rows[0]["Montofiscal"].ToString();
                TxtDescuentopp.Text = Ds.Tables[0].Rows[0]["Descuentopp"].ToString();
                TxtDescuentogb.Text = Ds.Tables[0].Rows[0]["Descuentogb"].ToString();
                TxtLimite_cred.Text = Ds.Tables[0].Rows[0]["Limite_cred"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["Activo"].ToString();
                TxtNacional.Text = Ds.Tables[0].Rows[0]["Nacional"].ToString();
                TxtFiscal.Text = Ds.Tables[0].Rows[0]["Fiscal"].ToString();
                TxtAplica_credito.Text = Ds.Tables[0].Rows[0]["Aplica_credito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["Cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["Desc_vendedor"].ToString();
                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["Cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["Desc_tipocliente"].ToString();
                TxtCod_segmento.Text = Ds.Tables[0].Rows[0]["Cod_segmento"].ToString();
                TxtDesc_segmento.Text = Ds.Tables[0].Rows[0]["desc_segmento"].ToString();
                TxtCod_condicionpago.Text = Ds.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = Ds.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = Ds.Tables[0].Rows[0]["diascredito"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["Cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["Cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtCod_pais.Text = Ds.Tables[0].Rows[0]["Cod_pais"].ToString();
                TxtDesc_pais.Text = Ds.Tables[0].Rows[0]["desc_pais"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["Cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_zona.Text = Ds.Tables[0].Rows[0]["Cod_zona"].ToString();
                TxtDesc_zona.Text = Ds.Tables[0].Rows[0]["desc_zona"].ToString();

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
                Ds = ECliente.Siguiente(TxtCod_cliente.Text);

                TxtCod_cliente.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtCod_clientev.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtDesc_cliente.Text = Ds.Tables[0].Rows[0]["Desc_cliente"].ToString();
                TxtClasificacion.Text = Ds.Tables[0].Rows[0]["Clasificacion"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["Rif"].ToString();
                TxtContacto.Text = Ds.Tables[0].Rows[0]["Contacto"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["Direccion"].ToString();
                TxtDireccion_alterna.Text = Ds.Tables[0].Rows[0]["Direccion_alterna"].ToString();
                TxtCiudad.Text = Ds.Tables[0].Rows[0]["Ciudad"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["Telefono"].ToString();
                TxtMovil.Text = Ds.Tables[0].Rows[0]["Movil"].ToString();
                TxtCod_postal.Text = Ds.Tables[0].Rows[0]["Cod_postal"].ToString();
                TxtWeb.Text = Ds.Tables[0].Rows[0]["Web"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["Email"].ToString();
                TxtMontofiscal.Text = Ds.Tables[0].Rows[0]["Montofiscal"].ToString();
                TxtDescuentopp.Text = Ds.Tables[0].Rows[0]["Descuentopp"].ToString();
                TxtDescuentogb.Text = Ds.Tables[0].Rows[0]["Descuentogb"].ToString();
                TxtLimite_cred.Text = Ds.Tables[0].Rows[0]["Limite_cred"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["Activo"].ToString();
                TxtNacional.Text = Ds.Tables[0].Rows[0]["Nacional"].ToString();
                TxtFiscal.Text = Ds.Tables[0].Rows[0]["Fiscal"].ToString();
                TxtAplica_credito.Text = Ds.Tables[0].Rows[0]["Aplica_credito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["Cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["Desc_vendedor"].ToString();
                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["Cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["Desc_tipocliente"].ToString();
                TxtCod_segmento.Text = Ds.Tables[0].Rows[0]["Cod_segmento"].ToString();
                TxtDesc_segmento.Text = Ds.Tables[0].Rows[0]["desc_segmento"].ToString();
                TxtCod_condicionpago.Text = Ds.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = Ds.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = Ds.Tables[0].Rows[0]["diascredito"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["Cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["Cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtCod_pais.Text = Ds.Tables[0].Rows[0]["Cod_pais"].ToString();
                TxtDesc_pais.Text = Ds.Tables[0].Rows[0]["desc_pais"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["Cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_zona.Text = Ds.Tables[0].Rows[0]["Cod_zona"].ToString();
                TxtDesc_zona.Text = Ds.Tables[0].Rows[0]["desc_zona"].ToString();

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
                Ds = ECliente.Ultimo();

                TxtCod_cliente.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtCod_clientev.Text = Ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                TxtDesc_cliente.Text = Ds.Tables[0].Rows[0]["Desc_cliente"].ToString();
                TxtClasificacion.Text = Ds.Tables[0].Rows[0]["Clasificacion"].ToString();
                TxtRif.Text = Ds.Tables[0].Rows[0]["Rif"].ToString();
                TxtContacto.Text = Ds.Tables[0].Rows[0]["Contacto"].ToString();
                TxtDireccion.Text = Ds.Tables[0].Rows[0]["Direccion"].ToString();
                TxtDireccion_alterna.Text = Ds.Tables[0].Rows[0]["Direccion_alterna"].ToString();
                TxtCiudad.Text = Ds.Tables[0].Rows[0]["Ciudad"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["Telefono"].ToString();
                TxtMovil.Text = Ds.Tables[0].Rows[0]["Movil"].ToString();
                TxtCod_postal.Text = Ds.Tables[0].Rows[0]["Cod_postal"].ToString();
                TxtWeb.Text = Ds.Tables[0].Rows[0]["Web"].ToString();
                TxtEmail.Text = Ds.Tables[0].Rows[0]["Email"].ToString();
                TxtMontofiscal.Text = Ds.Tables[0].Rows[0]["Montofiscal"].ToString();
                TxtDescuentopp.Text = Ds.Tables[0].Rows[0]["Descuentopp"].ToString();
                TxtDescuentogb.Text = Ds.Tables[0].Rows[0]["Descuentogb"].ToString();
                TxtLimite_cred.Text = Ds.Tables[0].Rows[0]["Limite_cred"].ToString();
                TxtActivo.Text = Ds.Tables[0].Rows[0]["Activo"].ToString();
                TxtNacional.Text = Ds.Tables[0].Rows[0]["Nacional"].ToString();
                TxtFiscal.Text = Ds.Tables[0].Rows[0]["Fiscal"].ToString();
                TxtAplica_credito.Text = Ds.Tables[0].Rows[0]["Aplica_credito"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["Fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["Campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["Campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["Campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["Campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["Campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["Campo6"].ToString();
                TxtCod_vendedor.Text = Ds.Tables[0].Rows[0]["Cod_vendedor"].ToString();
                TxtDesc_vendedor.Text = Ds.Tables[0].Rows[0]["Desc_vendedor"].ToString();
                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["Cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["Desc_tipocliente"].ToString();
                TxtCod_segmento.Text = Ds.Tables[0].Rows[0]["Cod_segmento"].ToString();
                TxtDesc_segmento.Text = Ds.Tables[0].Rows[0]["desc_segmento"].ToString();
                TxtCod_condicionpago.Text = Ds.Tables[0].Rows[0]["Cod_condicionpago"].ToString();
                TxtDesc_condicionpago.Text = Ds.Tables[0].Rows[0]["desc_condicionpago"].ToString();
                TxtDiascredito.Text = Ds.Tables[0].Rows[0]["diascredito"].ToString();
                TxtCod_cuentasie.Text = Ds.Tables[0].Rows[0]["Cod_cuentasie"].ToString();
                TxtDesc_cuentasie.Text = Ds.Tables[0].Rows[0]["desc_cuentasie"].ToString();
                TxtCod_islr.Text = Ds.Tables[0].Rows[0]["Cod_islr"].ToString();
                TxtDesc_islr.Text = Ds.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtCod_pais.Text = Ds.Tables[0].Rows[0]["Cod_pais"].ToString();
                TxtDesc_pais.Text = Ds.Tables[0].Rows[0]["desc_pais"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["Cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_zona.Text = Ds.Tables[0].Rows[0]["Cod_zona"].ToString();
                TxtDesc_zona.Text = Ds.Tables[0].Rows[0]["desc_zona"].ToString();

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
        private void ChkNacional_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkActivo_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkFiscal_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void ChkCredito_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void TxtActivo_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
            CambiosTexBox();
        }

        private void TxtAplica_credito_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
            CambiosTexBox();
        }

        private void RbPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            EventoClasificar();
        }

        private void RbSucursal_CheckedChanged(object sender, EventArgs e)
        {
            EventoClasificar();
        }

        private void TxtClasificacion_TextChanged(object sender, EventArgs e)
        {
            EventoClasificar();
            CambiosTexBox();
        }

        private void TxtCod_cliente_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtRif_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNacional_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTexBox();
        }

        private void TxtCod_segmento_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_pais_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_zona_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_tipocliente_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtContacto_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_postal_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtWeb_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtMovil_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_condicionpago_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_cuentasie_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtLimite_cred_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDescuentopp_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDescuentogb_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_islr_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            SelectDB();
        }

        private void TxtMontofiscal_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtFiscal_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTexBox();
        }

        private void TxtDireccion_alterna_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_cliente_TextChanged(object sender, EventArgs e)
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

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        #endregion

        #region LLAMAR REGISTROS

        internal void SetSegmento(string cod_segmento, string desc_segmento)
        {
            TxtCod_segmento.Text = cod_segmento;
            TxtDesc_segmento.Text = desc_segmento;
        }

        internal void SetTipoCliente(string cod_tipocliente, string desc_tipocliente)
        {
            TxtCod_tipocliente.Text = cod_tipocliente;
            TxtDesc_tipocliente.Text = desc_tipocliente;
        }

        internal void SetCuentasIE(string cod_cuentasie, string desc_cuentasie)
        {
            TxtCod_cuentasie.Text = cod_cuentasie;
            TxtDesc_cuentasie.Text = desc_cuentasie;
        }

        internal void SetCondicionPago(string cod_condicionpago, string desc_condicionpago, string diascredito)
        {
            TxtCod_condicionpago.Text = cod_condicionpago;
            TxtDesc_condicionpago.Text = desc_condicionpago;
            TxtDiascredito.Text = diascredito;
        }

        internal void SetPais(string cod_pais, string desc_pais, string cod_moneda, string desc_moneda)
        {
            TxtCod_pais.Text = cod_pais;
            TxtDesc_pais.Text = desc_pais;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        internal void SetZona(string cod_zona, string desc_zona)
        {
            TxtCod_zona.Text = cod_zona;
            TxtDesc_zona.Text = desc_zona;
        }

        private void TxtCod_vendedor_DoubleClick(object sender, EventArgs e)
        {
            FTipoClienteLista Listado = new FTipoClienteLista
            {
                TxtFlag = "Prov",
            };
            Dt = ETipoCliente.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_vendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F12)
            {
                FTipoClienteLista Listado = new FTipoClienteLista
                {
                    TxtFlag = "Prov",
                };
                Dt = ETipoCliente.Mostrar();
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

        private void TxtCod_segmento_DoubleClick(object sender, EventArgs e)
        {
            FSegmentoLista Listado = new FSegmentoLista
            {
                TxtFlag = "Prov",
                TxtTiposeg = Tiposeg
            };
            Dt = ESegmento.Mostrar(Tiposeg);
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_segmento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FSegmentoLista Listado = new FSegmentoLista
                {
                    TxtFlag = "Prov",
                    TxtTiposeg = Tiposeg
                };
                Dt = ESegmento.Mostrar(Tiposeg);
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

        private void TxtCod_tipocliente_DoubleClick(object sender, EventArgs e)
        {
            FTipoClienteLista Listado = new FTipoClienteLista
            {
                TxtFlag = "Prov"
            };
            Dt = ETipoCliente.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");        
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_tipocliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FTipoClienteLista Listado = new FTipoClienteLista
                {
                    TxtFlag = "Prov"
                };
                Dt = ETipoCliente.Mostrar();
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
                TxtFlag = "Prov"
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
                    TxtFlag = "Prov"
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

        private void TxtCod_condicionpago_DoubleClick(object sender, EventArgs e)
        {
            FCondicionPagoLista Listado = new FCondicionPagoLista
            {
                TxtFlag = "Prov"
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
                    TxtFlag = "Prov"
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

        private void TxtCod_pais_DoubleClick(object sender, EventArgs e)
        {
            FPaisLista Listado = new FPaisLista
            {
                TxtFlag = "Prov"
            };
            Dt = EPais.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_pais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FPaisLista Listado = new FPaisLista
                {
                    TxtFlag = "Prov"
                };
                Dt = EPais.Mostrar();
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

        private void TxtCod_zona_DoubleClick(object sender, EventArgs e)
        {
            FZonaLista Listado = new FZonaLista
            {
                TxtFlag = "Prov"
            };
            Dt = EZona.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            };
        }

        private void TxtCod_zona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FZonaLista Listado = new FZonaLista
                {
                    TxtFlag = "Prov"
                };
                Dt = EZona.Mostrar();
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
