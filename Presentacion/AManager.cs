using Entidades;
using Presentacion.ModuloBanco;
using Presentacion.ModuloCompra;
using Presentacion.ModuloConfig;
using Presentacion.ModuloInventario;
using Presentacion.ModuloVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class AManager : Form
    {

        private static AManager _Instancia;

        public static AManager GetAManager()
        {
            if (_Instancia == null)
            {
                _Instancia = new AManager();
            }
            return _Instancia;
        }

        public AManager()
        {
            InitializeComponent();
        }

        FLogin mFLogin = FLogin.GetForm();

        public void UsuarioLog()
        {
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet Ds = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
            TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();

            LbHora.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy h:mm tt");
        }

        public void ValidadAcceso()
        {
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet DsUsuario = EUsuario.UsiarioAcceso(TxtCod_usuario.Text);

            if (DsUsuario.Tables[0].Rows[0]["ainventario"].Equals(false))
            {
                SPInventario.Visible = true;
            }
            else
            {
                SPInventario.Visible = false;
            }

            if (DsUsuario.Tables[0].Rows[0]["acompras"].Equals(false))
            {
                SPCompras.Visible = true;
            }
            else
            {
                SPCompras.Visible = false;
            }

            if (DsUsuario.Tables[0].Rows[0]["aventas"].Equals(false))
            {
                SPVentas.Visible = true;
            }
            else
            {
                SPVentas.Visible = false;
            }

            if (DsUsuario.Tables[0].Rows[0]["abanco"].Equals(false))
            {
                SPBancos.Visible = true;
            }
            else
            {
                SPBancos.Visible = false;
            }

            if (DsUsuario.Tables[0].Rows[0]["aconfig"].Equals(false))
            {
                SPConfig.Visible = true;
            }
            else
            {
                SPConfig.Visible = false;
            }


            //    if (DsUsuario.Tables[0].Rows[0]["tsioperaciones"].Equals(false))
            //    {
            //        TsIOperaciones.Enabled = true;
            //    }
            //    else
            //    {
            //        TsIOperaciones.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["tsiTablas"].Equals(false))
            //    {
            //        TsITablas.Enabled = true;
            //    }
            //    else
            //    {
            //        TsITablas.Enabled = false;
            //    }

            //    if (DsUsuario.Tables[0].Rows[0]["tsiReportes"].Equals(false))
            //    {
            //        TsIReportes.Enabled = true;
            //    }
            //    else
            //    {
            //        TsIReportes.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsCoperaciones"].Equals(false))
            //    {
            //        TsCOperaciones.Enabled = true;
            //    }
            //    else
            //    {
            //        TsCOperaciones.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsCTablas"].Equals(false))
            //    {
            //        TsCTablas.Enabled = true;
            //    }
            //    else
            //    {
            //        TsCTablas.Enabled = false;
            //    }

            //    if (DsUsuario.Tables[0].Rows[0]["TsCReportes"].Equals(false))
            //    {
            //        TsCReportes.Enabled = true;
            //    }
            //    else
            //    {
            //        TsCReportes.Enabled = false;
            //    }

            //    if (DsUsuario.Tables[0].Rows[0]["TsVoperaciones"].Equals(false))
            //    {
            //        TsVOperaciones.Enabled = true;
            //    }
            //    else
            //    {
            //        TsVOperaciones.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsVTablas"].Equals(false))
            //    {
            //        TsVTablas.Enabled = true;
            //    }
            //    else
            //    {
            //        TsVTablas.Enabled = false;
            //    }

            //    if (DsUsuario.Tables[0].Rows[0]["TsVReportes"].Equals(false))
            //    {
            //        TsVReportes.Enabled = true;
            //    }
            //    else
            //    {
            //        TsVReportes.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsBoperaciones"].Equals(false))
            //    {
            //        TsBOperaciones.Enabled = true;
            //    }
            //    else
            //    {
            //        TsBOperaciones.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsBTablas"].Equals(false))
            //    {
            //        TsBTablas.Enabled = true;
            //    }
            //    else
            //    {
            //        TsBTablas.Enabled = false;
            //    }

            //    if (DsUsuario.Tables[0].Rows[0]["TsBReportes"].Equals(false))
            //    {
            //        TsBReportes.Enabled = true;
            //    }
            //    else
            //    {
            //        TsBReportes.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsCFoperaciones"].Equals(false))
            //    {
            //        TsCFOperaciones.Enabled = true;
            //    }
            //    else
            //    {
            //        TsCFOperaciones.Enabled = false;
            //    }


            //    if (DsUsuario.Tables[0].Rows[0]["TsCFTablas"].Equals(false))
            //    {
            //        TsCFTablas.Enabled = true;
            //    }
            //    else
            //    {
            //        TsCFTablas.Enabled = false;
            //    }

            //    if (DsUsuario.Tables[0].Rows[0]["TsCFReportes"].Equals(false))
            //    {
            //        TsCFReportes.Enabled = true;
            //    }
            //    else
            //    {
            //        TsCFReportes.Enabled = false;
            //    }
        }

        private void AManager_Load(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab=SPInventario;
            Text = "····:::: Step One Ver 1.0 ::::····";
            LbHora.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy h:mm tt");
        }

        #region TABLAS MODULO BANCOS
        private void TSTarjetas_Click(object sender, EventArgs e)
        {
            //FTarjeta mTarjeta = FTarjeta.GetFTarjeta();
            //mTarjeta.MdiParent = this;
            //mTarjeta.Show();
        }

        private void TSBancos_Click(object sender, EventArgs e)
        {
            FBanco mBanco = FBanco.GetForm();
            mBanco.MdiParent = this;
            mBanco.Show();
        }

        private void TSCaja_Click(object sender, EventArgs e)
        {
            FCaja mCaja = FCaja.GetForm();
            mCaja.MdiParent = this;
            mCaja.Show();
        }

        private void TSCuentas_Click(object sender, EventArgs e)
        {
            FCuenta mBCuenta = FCuenta.GetForm();
            mBCuenta.MdiParent = this;
            mBCuenta.Show();
        }

        private void TSChequeras_Click(object sender, EventArgs e)
        {
            FChequera mBChequera = FChequera.GetForm();
            mBChequera.MdiParent = this;
            mBChequera.Show();
        }

        private void TSBeneficiario_Click(object sender, EventArgs e)
        {
            FBeneficiario mBeneficiario = FBeneficiario.GetForm();
            mBeneficiario.MdiParent = this;
            mBeneficiario.Show();
        }

        private void TSBMoneda_Click(object sender, EventArgs e)
        {
            FMoneda mMoneda = FMoneda.GetForm();
            mMoneda.MdiParent = this;
            mMoneda.Show();
        }

        private void TSBPais_Click(object sender, EventArgs e)
        {
            FPais mBPais = FPais.GetForm();
            mBPais.MdiParent = this;
            mBPais.Show();
        }
        #endregion

        #region OPERACIONES MODULO BANCOS
        private void TSMovCaja_Click(object sender, EventArgs e)
        {
            FMovCaja mMovCaja = FMovCaja.GetForm();
            mMovCaja.MdiParent = this;
            mMovCaja.Show();
        }

        private void TSMovBanco_Click(object sender, EventArgs e)
        {
            FMovBanco mMovBanco = FMovBanco.GetForm();
            mMovBanco.MdiParent = this;
            mMovBanco.Show();
        }

        private void TSOPago_Click(object sender, EventArgs e)
        {
            FOPago mOPago = FOPago.GetForm();
            mOPago.MdiParent = this;
            mOPago.Show();
        }

        private void TSBCuentasIE_Click(object sender, EventArgs e)
        {
            FCuentasIE fCuentasIE = FCuentasIE.GetForm();
            fCuentasIE.MdiParent = this;
            fCuentasIE.Show();
        }

        private void TSBCondicionPago_Click(object sender, EventArgs e)
        {
            FCondicionPago fCondicionPago = FCondicionPago.GetForm();
            fCondicionPago.MdiParent = this;
            fCondicionPago.Show();
        }
        #endregion

        #region TABLAS MODULO INVENTARIO
        private void TSArticulo_Click(object sender, EventArgs e)
        {
            FArticulo fArticulo = FArticulo.GetForm();
            fArticulo.MdiParent = this;
            fArticulo.Show();
        }

        private void TSCategoria_Click(object sender, EventArgs e)
        {
            FCategoria fCategoria = FCategoria.GetForm();
            fCategoria.MdiParent = this;
            fCategoria.Show();
        }

        private void TSLinea_Click(object sender, EventArgs e)
        {
            FLinea fLinea = FLinea.GetForm();
            fLinea.MdiParent = this;
            fLinea.Show();
        }

        private void TSSublinea_Click(object sender, EventArgs e)
        {
            FSubLinea fSubLinea = FSubLinea.GetForm();
            fSubLinea.MdiParent = this;
            fSubLinea.Show();
        }

        private void TSColor_Click(object sender, EventArgs e)
        {
            FColor fColor = FColor.GetForm();
            fColor.MdiParent = this;
            fColor.Show();
        }

        private void TSUbicacion_Click(object sender, EventArgs e)
        {
            FUbicacion fUbicacion = FUbicacion.GetForm();
            fUbicacion.MdiParent = this;
            fUbicacion.Show();
        }

        private void TSUnidad_Click(object sender, EventArgs e)
        {
            FUnidad fUnidad = FUnidad.GetForm();
            fUnidad.MdiParent = this;
            fUnidad.Show();
        }

        private void TSDeposito_Click(object sender, EventArgs e)
        {
            FDeposito fDeposito = FDeposito.GetForm();
            fDeposito.MdiParent = this;
            fDeposito.Show();
        }

        private void TSInventario_Click(object sender, EventArgs e)
        {
            FStockInventarioLista fSInvioLista = FStockInventarioLista.GetForm();
            fSInvioLista.MdiParent = this;
            fSInvioLista.Show();
        }
        #endregion

        #region TABLAS MODULO COMPRAS
        private void TSProveedor_Click(object sender, EventArgs e)
        {
            FProveedor fProveedor = FProveedor.GetForm();
            fProveedor.MdiParent = this;
            fProveedor.Show();
        }
         
        private void TSTipoProveedor_Click(object sender, EventArgs e)
        {
            FTipoProveedor fTipoProveedor = FTipoProveedor.GetForm();
            fTipoProveedor.MdiParent = this;
            fTipoProveedor.Show();
        }

        private void TSCSegmento_Click(object sender, EventArgs e)
        {
            FSegmento fSegmento = FSegmento.GetForm();
            fSegmento.MdiParent = this;
            fSegmento.TxtTiposeg = "P";
            fSegmento.Show();
        }

        private void TSCCondicionPago_Click(object sender, EventArgs e)
        {
            FCondicionPago fCondicionPago = FCondicionPago.GetForm();
            fCondicionPago.MdiParent = this;
            fCondicionPago.Show();
        }

        private void TSCCuentasIE_Click(object sender, EventArgs e)
        {
            FCuentasIE fCuentasIE = FCuentasIE.GetForm();
            fCuentasIE.MdiParent = this;
            fCuentasIE.Show();
        }

        private void TSCZona_Click(object sender, EventArgs e)
        {
            FZona fZona = FZona.GetForm();
            fZona.MdiParent = this;
            fZona.Show();
        }

        private void TSCPais_Click(object sender, EventArgs e)
        {
            FPais fPais = FPais.GetForm();
            fPais.MdiParent = this;
            fPais.Show();
        }
        #endregion

        #region OPERACIONES MOULO COMPRAS
        private void TSDCompra_Click(object sender, EventArgs e)
        {
            FDCompra fDCompra = FDCompra.GetForm();
            fDCompra.MdiParent = this;
            fDCompra.Show();
        }

        private void TSCCompra_Click(object sender, EventArgs e)
        {
            FCCompra fCCompra = FCCompra.GetForm();
            fCCompra.MdiParent = this;
            fCCompra.Show();
        }

        private void TSPCompra_Click(object sender, EventArgs e)
        {
            FPCompra fPCompra = FPCompra.GetForm();
            fPCompra.MdiParent = this;
            fPCompra.Show();
        }

        private void TSFCompra_Click(object sender, EventArgs e)
        {
            FFCompra fPCompra = FFCompra.GetForm();
            fPCompra.MdiParent = this;
            fPCompra.Show();
        }

        private void TSRCompra_Click(object sender, EventArgs e)
        {
            //FDCompra fDCompra = FDCompra.GetDCompra();
            //fDCompra.MdiParent = this;
            //fDCompra.Show();
        }

        private void TSPago_Click(object sender, EventArgs e)
        {
            FPago fPago = FPago.GetForm();
            fPago.MdiParent = this;
            fPago.Show();
        }

        #endregion

        #region TABLAS MODULO CONFIGURACION
        private void TSCambiarUsuario_Click(object sender, EventArgs e)
        {
            FLogin mLogin = FLogin.GetForm();
            mLogin.BtnCancelar2.Visible = true;
            mLogin.BtnCancelar.Visible = false;
            mLogin.Show();
        }

        private void TSCorrelativos_Click(object sender, EventArgs e)
        {
            FCorrelativos fCorrelativos = FCorrelativos.GetForm();
            fCorrelativos.MdiParent = this;
            fCorrelativos.Show();
        }

        private void TSConfMoneda_Click(object sender, EventArgs e)
        {
            FMoneda mMoneda = FMoneda.GetForm();
            mMoneda.MdiParent = this;
            mMoneda.Show();
        }

        private void TSImpuestos_Click(object sender, EventArgs e)
        {
            FImpuesto fImpuesto = FImpuesto.GetForm();
            fImpuesto.MdiParent = this;
            fImpuesto.Show();
        }

        private void TSEmpresa_Click(object sender, EventArgs e)
        {
            FEmpresa fEmpresa = FEmpresa.GetForm();
            fEmpresa.MdiParent = this;
            fEmpresa.Show();
        }

        private void TSIslr_Click(object sender, EventArgs e)
        {
            FIslr fIslr = FIslr.GetForm();
            fIslr.MdiParent = this;
            fIslr.Show();
        }

        private void TSConfPais_Click(object sender, EventArgs e)
        {
            FPais fPais = FPais.GetForm();
            fPais.MdiParent = this;
            fPais.Show();
        }

        private void TSMapas_Click(object sender, EventArgs e)
        {
            FMapa fMapa = FMapa.GetForm();
            fMapa.MdiParent = this;
            fMapa.Show();
        }

        private void TSUsuario_Click(object sender, EventArgs e)
        {
            FUsuario fUsuario = FUsuario.GetForm();
            fUsuario.MdiParent = this;
            fUsuario.Show();
        }
        #endregion

        #region TABLAS MODULO VENTAS
        private void TSCliente_Click(object sender, EventArgs e)
        {
            FCliente fCliente = FCliente.GetForm();
            fCliente.MdiParent = this;
            fCliente.Show();
        }

        private void TSSegmento_Click(object sender, EventArgs e)
        {
            FSegmento fSegmento = FSegmento.GetForm();
            fSegmento.MdiParent = this;
            fSegmento.TxtTiposeg = "C";
            fSegmento.Show();
        }

        private void TSTipoCliente_Click(object sender, EventArgs e)
        {
            FTipoCliente fTipoCliente = FTipoCliente.GetForm();
            fTipoCliente.MdiParent = this;
            fTipoCliente.Show();
        }

        private void TSTipoPrecio_Click(object sender, EventArgs e)
        {
            FPrecio fPrecio = FPrecio.GetForm();
            fPrecio.MdiParent = this;
            fPrecio.Show();
        }

        private void TSCondicionPago_Click(object sender, EventArgs e)
        {
            FCondicionPago fCondicionPago = FCondicionPago.GetForm();
            fCondicionPago.MdiParent = this;
            fCondicionPago.Show();
        }

        private void TSCuentasIE_Click(object sender, EventArgs e)
        {
            FCuentasIE fCuentasIE = FCuentasIE.GetForm();
            fCuentasIE.MdiParent = this;
            fCuentasIE.Show();
        }

        private void TSVendedor_Click(object sender, EventArgs e)
        {
            FVendedor fVendedor = FVendedor.GetForm();
            fVendedor.MdiParent = this;
            fVendedor.Show();
        }

        private void TSZona_Click(object sender, EventArgs e)
        {
            FZona fZona = FZona.GetForm();
            fZona.MdiParent = this;
            fZona.Show();
        }

        private void TSPais_Click(object sender, EventArgs e)
        {
            FPais fPais = FPais.GetForm();
            fPais.MdiParent = this;
            fPais.Show();
        }
        #endregion

        #region OOPERACIONES MOULO VENTAS
        private void TSCVenta_Click(object sender, EventArgs e)
        {
            //FCVenta fCVenta = FCVenta.GetFCVenta();
            //fCVenta.MdiParent = this;
            //fCVenta.Show();
        }

        private void TSPVenta_Click(object sender, EventArgs e)
        {
            //FPVenta fPVenta = FPVenta.GetFPVenta();
            //fPVenta.MdiParent = this;
            //fPVenta.Show();
        }

        private void TSFVenta_Click(object sender, EventArgs e)
        {
            //FFVenta fFVenta = FFVenta.GetFFVenta();
            //fFVenta.MdiParent = this;
            //fFVenta.Show();
        }

        private void TSNEntrega_Click(object sender, EventArgs e)
        {

        }

        private void TSCobros_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void HoraTick_Tick(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy h:mm tt");
        }

        private void ToolStrippExitMenu(object sender, EventArgs e)
        {
            Close();
        }

        private void AManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            _Instancia = null;
        }

        private void SuperTabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void AManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TSDVenta_Click(object sender, EventArgs e)
        {

        }

        private void TSEInventario_Click(object sender, EventArgs e)
        {
            //FMovInventario fEntrada = FMovInventario.GetFMovInventario();
            //fEntrada.MdiParent = this;
            //fEntrada.TxtTipo.Text = "Entrada";
            //fEntrada.TxtTipo.ForeColor = Color.Blue;
            //fEntrada.Show();
        }

        private void TSSInventario_Click(object sender, EventArgs e)
        {
            //FMovInventario fSalida = FMovInventario.GetFMovInventario();
            //fSalida.MdiParent = this;
            //fSalida.TxtTipo.Text = "Salida";
            //fSalida.TxtTipo.ForeColor = Color.Red;
            //fSalida.Show();
        }
    }
}
