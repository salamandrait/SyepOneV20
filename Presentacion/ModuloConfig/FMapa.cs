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

namespace Presentacion.ModuloConfig
{
    public partial class FMapa : Form
    {
        string Pref = "";
        DialogResult Opcion;

        private static FMapa _Instancia;

        public static FMapa GetForm()
        {
            if(_Instancia==null)
            {
                _Instancia = new FMapa();
            }
            return _Instancia;
        }
        public FMapa()
        {
            InitializeComponent();
        }

        public void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            TxtCod_mapa.Text = String.Empty;
            TxtDesc_mapa.Text = String.Empty;
            //TxtAinventario.Text = "False";
            //TxtAcompras.Text = "False";
            //TxtAventas.Text = "False";
            //TxtAbanco.Text = "False";
            //TxtAconfig.Text = "False";
            //TxtTsioperaciones.Text = "False";
            //TxtTsitablas.Text = "False";
            //TxtTsireportes.Text = "False";
            //TxtTsctablas.Text = "False";
            //TxtTscreportes.Text = "False";
            //TxtTsvoperaciones.Text = "False";
            //TxtTsvtablas.Text = "False";
            //TxtTsvreportes.Text = "False";
            //TxtTsboperaciones.Text = "False";
            //TxtTsbtablas.Text = "False";
            //TxtTsbreportes.Text = "False";
            //TxtTscfoperaciones.Text = "False";
            //TxtTscftablas.Text = "False";
            //TxtTscfreportes.Text = "False";
        }

        private void ControlBotones()
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
                BtnGenerar.Enabled = true;
                BtnListar.Enabled = false;
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
                BtnGenerar.Enabled = true;
                BtnListar.Enabled = false;
            }
            else if (TxtEditar.Text == "Listar")
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
                BtnGenerar.Enabled = false;
                BtnListar.Enabled = true;
            }
        }

        private void ControlCambios()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
            }
        }

        private void Top_serie()
        {
            try
            {
                DataSet Ds = ECorrelativos.GetCorrelativo(TxtTabla.Text);

                TxtCadena.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                Pref = Ds.Tables[0].Rows[0]["precadena"].ToString();
            }
            catch (Exception Ex)
            {
                string rpta = "";
                rpta = Ex.Message;
            }
        }

        private void GenerarCod()
        {
            try
            {
                int rpta = Convert.ToInt32(EMapa.GenerarCod(TxtCod_mapa.Text));
                TxtCod_mapa.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos    " + Ex.StackTrace);
                TxtCod_mapa.Focus();
            }
        }

        private void Registros()
        {
            DataTable DtRegistros = EMapa.Mostrar();
            LbTotalRegistros.Text = Convert.ToString(DtRegistros.Rows.Count.ToString());
        }

        private void MostrarUsuario()
        {
            FLogin mFLogin = FLogin.GetForm();
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet Ds = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
            TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
        }

        internal void Listar()
        {
            try
            {
                DataSet Dslistar = EMapa.Listar();

                TxtCod_mapa.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtCod_mapav.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Dslistar.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtAinventario.Text = Dslistar.Tables[0].Rows[0]["ainventario"].ToString();
                TxtAcompras.Text = Dslistar.Tables[0].Rows[0]["acompras"].ToString();
                TxtAventas.Text = Dslistar.Tables[0].Rows[0]["aventas"].ToString();
                TxtAbanco.Text = Dslistar.Tables[0].Rows[0]["abanco"].ToString();
                TxtAconfig.Text = Dslistar.Tables[0].Rows[0]["aconfig"].ToString();

                TxtTsioperaciones.Text = Dslistar.Tables[0].Rows[0]["tsioperaciones"].ToString();
                TxtTsitablas.Text = Dslistar.Tables[0].Rows[0]["tsitablas"].ToString();
                TxtTsireportes.Text = Dslistar.Tables[0].Rows[0]["tsireportes"].ToString();

                TxtTscoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscoperaciones"].ToString();
                TxtTsctablas.Text = Dslistar.Tables[0].Rows[0]["tsctablas"].ToString();
                TxtTscreportes.Text = Dslistar.Tables[0].Rows[0]["tscreportes"].ToString();

                TxtTsvoperaciones.Text = Dslistar.Tables[0].Rows[0]["tsvoperaciones"].ToString();
                TxtTsvtablas.Text = Dslistar.Tables[0].Rows[0]["tsvtablas"].ToString();
                TxtTsvreportes.Text = Dslistar.Tables[0].Rows[0]["tsvreportes"].ToString();

                TxtTsboperaciones.Text = Dslistar.Tables[0].Rows[0]["tsboperaciones"].ToString();
                TxtTsbtablas.Text = Dslistar.Tables[0].Rows[0]["tsbtablas"].ToString();
                TxtTsbreportes.Text = Dslistar.Tables[0].Rows[0]["tsbreportes"].ToString();

                TxtTscfoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscfoperaciones"].ToString();
                TxtTscftablas.Text = Dslistar.Tables[0].Rows[0]["tscftablas"].ToString();
                TxtTscfreportes.Text = Dslistar.Tables[0].Rows[0]["tscfreportes"].ToString();

                TxtEditar.Text = "Listar";
                Registros();

            }
            catch (Exception Ex)
            {
                Show();
                TxtEditar.Text = "Nuevo";
                Limpiar();
                TxtCod_mapa.Focus();
                string rpta = "";
                rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }

        }

        private void Guardar()
        {
            try
            {
                string rpta = "";
                if (TxtCod_mapa.Text == string.Empty && TxtDesc_mapa.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        rpta = EMapa.Insertar(TxtCod_mapa.Text, TxtDesc_mapa.Text, Convert.ToBoolean(TxtAinventario.Text), Convert.ToBoolean(TxtAcompras.Text), Convert.ToBoolean(TxtAventas.Text), Convert.ToBoolean(TxtAbanco.Text), Convert.ToBoolean(TxtAconfig.Text), Convert.ToBoolean(TxtTsioperaciones.Text), Convert.ToBoolean(TxtTsitablas.Text), Convert.ToBoolean(TxtTsireportes.Text), Convert.ToBoolean(TxtTscoperaciones.Text), Convert.ToBoolean(TxtTsctablas.Text), Convert.ToBoolean(TxtTscreportes.Text), Convert.ToBoolean(TxtTsvoperaciones.Text), Convert.ToBoolean(TxtTsvtablas.Text), Convert.ToBoolean(TxtTsvreportes.Text), Convert.ToBoolean(TxtTsboperaciones.Text), Convert.ToBoolean(TxtTsbtablas.Text), Convert.ToBoolean(TxtTsbreportes.Text), Convert.ToBoolean(TxtTscfoperaciones.Text), Convert.ToBoolean(TxtTscftablas.Text), Convert.ToBoolean(TxtTscfreportes.Text));
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        rpta = EMapa.Editar(TxtCod_mapa.Text, TxtDesc_mapa.Text, Convert.ToBoolean(TxtAinventario.Text), Convert.ToBoolean(TxtAcompras.Text), Convert.ToBoolean(TxtAventas.Text), Convert.ToBoolean(TxtAbanco.Text), Convert.ToBoolean(TxtAconfig.Text), Convert.ToBoolean(TxtTsioperaciones.Text), Convert.ToBoolean(TxtTsitablas.Text), Convert.ToBoolean(TxtTsireportes.Text), Convert.ToBoolean(TxtTscoperaciones.Text), Convert.ToBoolean(TxtTsctablas.Text), Convert.ToBoolean(TxtTscreportes.Text), Convert.ToBoolean(TxtTsvoperaciones.Text), Convert.ToBoolean(TxtTsvtablas.Text), Convert.ToBoolean(TxtTsvreportes.Text), Convert.ToBoolean(TxtTsboperaciones.Text), Convert.ToBoolean(TxtTsbtablas.Text), Convert.ToBoolean(TxtTsbreportes.Text), Convert.ToBoolean(TxtTscfoperaciones.Text), Convert.ToBoolean(TxtTscftablas.Text), Convert.ToBoolean(TxtTscfreportes.Text));
                    }

                    if (rpta.Equals("Y"))
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
                        MensajeError(rpta);
                    }
                }
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message + "Aqui el Error");
            }
        }

        void EventoTextBox()
        {
            if(TxtAinventario.Text == false.ToString())
            {
                ChkInventario.Checked  = false;
                GBInventario.Enabled = true;
            }
            else
            {
                ChkInventario.Checked = true;
                GBInventario.Enabled = false;
            }

            if (TxtAcompras.Text  == false.ToString())
            {
                ChkCompras.Checked  = false;
                GBCompras.Enabled = true;
            }
            else
            {
                ChkCompras.Checked = true;
                GBCompras.Enabled = false;
            }

            if (TxtAventas.Text  == false.ToString())
            {
                ChkVentas.Checked  = false;
                GBVentas.Enabled = true;
            }
            else
            {
                ChkVentas.Checked = true;
                GBVentas.Enabled = false;
            }

            if (TxtAbanco.Text  == false.ToString())
            {
                ChkBanco.Checked  = false;
                GBBanca.Enabled = true;
            }
            else
            {
                ChkBanco.Checked = true;
                GBBanca.Enabled = false;
            }

            if (TxtAconfig.Text  == false.ToString())
            {
                ChkConfig.Checked  = false;
                GBConfig.Enabled = true;
            }
            else
            {
                ChkConfig.Checked = true;
                GBConfig.Enabled = false;
            }


            if (TxtTsioperaciones.Text == false.ToString())
            {
                ChkTsioperaciones.Checked = false;
            }
            else
            {
                ChkTsioperaciones.Checked = true;
            }

            if (TxtTsitablas.Text == false.ToString())
            {
                ChkTsitablas.Checked = false;
            }
            else
            {
                ChkTsitablas.Checked = true;
            }

            if (TxtTsireportes.Text == false.ToString())
            {
                ChkTsireportes.Checked = false;
            }
            else
            {
                ChkTsireportes.Checked = true;
            }


            if (TxtTscoperaciones.Text == false.ToString())
            {
                ChkTscoperaciones.Checked = false;
            }
            else
            {
                ChkTscoperaciones.Checked = true;
            }

            if (TxtTsctablas.Text == false.ToString())
            {
                ChkTsctablas.Checked = false;
            }
            else
            {
                ChkTsctablas.Checked = true;
            }

            if (TxtTscreportes.Text == false.ToString())
            {
                ChkTscreportes.Checked = false;
            }
            else
            {
                ChkTscreportes.Checked = true;
            }



            if (TxtTsvoperaciones.Text == false.ToString())
            {
                ChkTsvoperaciones.Checked = false;
            }
            else
            {
                ChkTsvoperaciones.Checked = true;
            }

            if (TxtTsvtablas.Text == false.ToString())
            {
                ChkTsvtablas.Checked = false;
            }
            else
            {
                ChkTsvtablas.Checked = true;
            }

            if (TxtTsvreportes.Text == false.ToString())
            {
                ChkTsvreportes.Checked = false;
            }
            else
            {
                ChkTsvreportes.Checked = true;
            }


            if (TxtTsboperaciones.Text == false.ToString())
            {
                ChkTsboperaciones.Checked = false;
            }
            else
            {
                ChkTsboperaciones.Checked = true;
            }

            if (TxtTsbtablas.Text == false.ToString())
            {
                ChkTsbtablas.Checked = false;
            }
            else
            {
                ChkTsbtablas.Checked = true;
            }

            if (TxtTsbreportes.Text == false.ToString())
            {
                ChkTsbreportes.Checked = false;
            }
            else
            {
                ChkTsbreportes.Checked = true;
            }


            if (TxtTscfoperaciones.Text == false.ToString())
            {
                ChkTscfoperaciones.Checked = false;
            }
            else
            {
                ChkTscfoperaciones.Checked = true;
            }

            if (TxtTscftablas.Text == false.ToString())
            {
                ChkTscftablas.Checked = false;
            }
            else
            {
                ChkTscftablas.Checked = true;
            }

            if (TxtTscfreportes.Text == false.ToString())
            {
                ChkTscfreportes.Checked = false;
            }
            else
            {
                ChkTscfreportes.Checked = true;
            }
        }

        void EventoChk()
        {
            if(ChkInventario.Checked  == false)
            {
                TxtAinventario.Text  = false.ToString();
            }
            else
            {
                TxtAinventario.Text = true.ToString();
            }

            if (ChkCompras.Checked  == false)
            {
                TxtAcompras.Text  = false.ToString();
            }
            else
            {
                TxtAcompras.Text = true.ToString();
            }

            if (ChkVentas.Checked  == false)
            {
                TxtAventas.Text  = false.ToString();
            }
            else
            {
                TxtAventas.Text = true.ToString();
            }

            if (ChkBanco.Checked  == false)
            {
                TxtAbanco.Text  = false.ToString();
            }
            else
            {
                TxtAbanco.Text = true.ToString();
            }

            if (ChkConfig.Checked  == false)
            {
                TxtAconfig.Text  = false.ToString();
            }
            else
            {
                TxtAconfig.Text = true.ToString();
            }




            if (ChkTsioperaciones.Checked == false)
            {
                TxtTsioperaciones.Text = false.ToString();
            }
            else
            {
                TxtTsioperaciones.Text = true.ToString();
            }

            if (ChkTsitablas.Checked == false)
            {
                TxtTsitablas.Text = false.ToString();
            }
            else
            {
                TxtTsitablas.Text = true.ToString();
            }

            if (ChkTsireportes.Checked == false)
            {
                TxtTsireportes.Text = false.ToString();
            }
            else
            {
                TxtTsireportes.Text = true.ToString();
            }



            if (ChkTscoperaciones.Checked == false)
            {
                TxtTscoperaciones.Text = false.ToString();
            }
            else
            {
                TxtTscoperaciones.Text = true.ToString();
            }

            if (ChkTsctablas.Checked == false)
            {
                TxtTsctablas.Text = false.ToString();
            }
            else
            {
                TxtTsctablas.Text = true.ToString();
            }

            if (ChkTscreportes.Checked == false)
            {
                TxtTscreportes.Text = false.ToString();
            }
            else
            {
                TxtTscreportes.Text = true.ToString();
            }


            if (ChkTsvoperaciones.Checked == false)
            {
                TxtTsvoperaciones.Text = false.ToString();
            }
            else
            {
                TxtTsvoperaciones.Text = true.ToString();
            }

            if (ChkTsvtablas.Checked == false)
            {
                TxtTsvtablas.Text = false.ToString();
            }
            else
            {
                TxtTsvtablas.Text = true.ToString();
            }

            if (ChkTsvreportes.Checked == false)
            {
                TxtTsvreportes.Text = false.ToString();
            }
            else
            {
                TxtTsvreportes.Text = true.ToString();
            }



            if (ChkTsboperaciones.Checked == false)
            {
                TxtTsboperaciones.Text = false.ToString();
            }
            else
            {
                TxtTsboperaciones.Text = true.ToString();
            }

            if (ChkTsbtablas.Checked == false)
            {
                TxtTsbtablas.Text = false.ToString();
            }
            else
            {
                TxtTsbtablas.Text = true.ToString();
            }

            if (ChkTsbreportes.Checked == false)
            {
                TxtTsbreportes.Text = false.ToString();
            }
            else
            {
                TxtTsbreportes.Text = true.ToString();
            }



            if (ChkTscfoperaciones.Checked == false)
            {
                TxtTscfoperaciones.Text = false.ToString();
            }
            else
            {
                TxtTscfoperaciones.Text = true.ToString();
            }

            if (ChkTscftablas.Checked == false)
            {
                TxtTscftablas.Text = false.ToString();
            }
            else
            {
                TxtTscftablas.Text = true.ToString();
            }

            if (ChkTscfreportes.Checked == false)
            {
                TxtTscfreportes.Text = false.ToString();
            }
            else
            {
                TxtTscfreportes.Text = true.ToString();
            }
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            Text = "····:::: Mapas de Usuarios ::::····";
            Top_serie();
            Listar();
            EventoChk();
            MostrarUsuario();
        }

        #region Control Cambios
        private void Mapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void TxtCod_mapa_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
        }

        private void TxtDesc_mapa_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void TxtAinventario_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtAcompras_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();

        }

        private void TxtAventas_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();

        }

        private void TxtAbanco_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();

        }

        private void TxtAconfig_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void ChkInventario_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkCompras_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();

        }

        private void ChkVentas_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkBanco_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkConfig_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void TxtTsioperaciones_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsitablas_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsireportes_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTscoperaciones_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsctablas_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTscreportes_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsvoperaciones_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsvtablas_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsvreportes_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsboperaciones_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsbtablas_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTsbreportes_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTscfoperaciones_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTscftablas_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }

        private void TxtTscfreportes_TextChanged(object sender, EventArgs e)
        {
            ControlCambios();
            EventoTextBox();
        }


        private void ChkTsitablas_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsioperaciones_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsireportes_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsctablas_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTscoperaciones_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTscreportes_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsvtablas_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsvoperaciones_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsvreportes_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsbtablas_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsboperaciones_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTsbreportes_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTscftablas_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTscfoperaciones_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void ChkTscfreportes_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }
        #endregion

        #region Procesos Principales


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            ControlBotones();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Listar();
            ControlBotones();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Nuevo";
            Limpiar();
            ControlBotones();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Editar";
            ControlBotones();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente desea Eliminar el Registro ?", "...::: Stage One V 0.1 :::...",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string Rpta = "";

                if (Opcion == DialogResult.OK)
                {
                    Rpta = EMapa.Eliminar(TxtCod_mapa.Text);

                    if (Rpta.Equals("Y"))
                    {

                        MensajeOk("Registro Eliminado Correctamente!");
                        ControlBotones();
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
            FMapaLista Listado = new FMapaLista();
            Listado.TxtBtipo.Text = "Codigo";
            Listado.TxtFlag.Text = 0.ToString();
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCod();
        }
        #endregion

        #region NavegarRegistros
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet Dslistar = EMapa.Primero();

                TxtCod_mapa.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtCod_mapav.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Dslistar.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtAinventario.Text = Dslistar.Tables[0].Rows[0]["ainventario"].ToString();
                TxtAcompras.Text = Dslistar.Tables[0].Rows[0]["acompras"].ToString();
                TxtAventas.Text = Dslistar.Tables[0].Rows[0]["aventas"].ToString();
                TxtAbanco.Text = Dslistar.Tables[0].Rows[0]["abanco"].ToString();
                TxtAconfig.Text = Dslistar.Tables[0].Rows[0]["aconfig"].ToString();

                TxtTsioperaciones.Text = Dslistar.Tables[0].Rows[0]["tsioperaciones"].ToString();
                TxtTsitablas.Text = Dslistar.Tables[0].Rows[0]["tsitablas"].ToString();
                TxtTsireportes.Text = Dslistar.Tables[0].Rows[0]["tsireportes"].ToString();

                TxtTscoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscoperaciones"].ToString();
                TxtTsctablas.Text = Dslistar.Tables[0].Rows[0]["tsctablas"].ToString();
                TxtTscreportes.Text = Dslistar.Tables[0].Rows[0]["tscreportes"].ToString();

                TxtTsvoperaciones.Text = Dslistar.Tables[0].Rows[0]["tsvoperaciones"].ToString();
                TxtTsvtablas.Text = Dslistar.Tables[0].Rows[0]["tsvtablas"].ToString();
                TxtTsvreportes.Text = Dslistar.Tables[0].Rows[0]["tsvreportes"].ToString();

                TxtTsboperaciones.Text = Dslistar.Tables[0].Rows[0]["tsboperaciones"].ToString();
                TxtTsbtablas.Text = Dslistar.Tables[0].Rows[0]["tsbtablas"].ToString();
                TxtTsbreportes.Text = Dslistar.Tables[0].Rows[0]["tsbreportes"].ToString();

                TxtTscfoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscfoperaciones"].ToString();
                TxtTscftablas.Text = Dslistar.Tables[0].Rows[0]["tscftablas"].ToString();
                TxtTscfreportes.Text = Dslistar.Tables[0].Rows[0]["tscfreportes"].ToString();

                TxtEditar.Text = "Listar";
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
                DataSet Dslistar = EMapa.Anterior(TxtCod_mapa.Text);

                TxtCod_mapa.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtCod_mapav.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Dslistar.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtAinventario.Text = Dslistar.Tables[0].Rows[0]["ainventario"].ToString();
                TxtAcompras.Text = Dslistar.Tables[0].Rows[0]["acompras"].ToString();
                TxtAventas.Text = Dslistar.Tables[0].Rows[0]["aventas"].ToString();
                TxtAbanco.Text = Dslistar.Tables[0].Rows[0]["abanco"].ToString();
                TxtAconfig.Text = Dslistar.Tables[0].Rows[0]["aconfig"].ToString();

                TxtTsioperaciones.Text = Dslistar.Tables[0].Rows[0]["tsioperaciones"].ToString();
                TxtTsitablas.Text = Dslistar.Tables[0].Rows[0]["tsitablas"].ToString();
                TxtTsireportes.Text = Dslistar.Tables[0].Rows[0]["tsireportes"].ToString();

                TxtTscoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscoperaciones"].ToString();
                TxtTsctablas.Text = Dslistar.Tables[0].Rows[0]["tsctablas"].ToString();
                TxtTscreportes.Text = Dslistar.Tables[0].Rows[0]["tscreportes"].ToString();

                TxtTsvoperaciones.Text = Dslistar.Tables[0].Rows[0]["tsvoperaciones"].ToString();
                TxtTsvtablas.Text = Dslistar.Tables[0].Rows[0]["tsvtablas"].ToString();
                TxtTsvreportes.Text = Dslistar.Tables[0].Rows[0]["tsvreportes"].ToString();

                TxtTsboperaciones.Text = Dslistar.Tables[0].Rows[0]["tsboperaciones"].ToString();
                TxtTsbtablas.Text = Dslistar.Tables[0].Rows[0]["tsbtablas"].ToString();
                TxtTsbreportes.Text = Dslistar.Tables[0].Rows[0]["tsbreportes"].ToString();

                TxtTscfoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscfoperaciones"].ToString();
                TxtTscftablas.Text = Dslistar.Tables[0].Rows[0]["tscftablas"].ToString();
                TxtTscfreportes.Text = Dslistar.Tables[0].Rows[0]["tscfreportes"].ToString();

                TxtEditar.Text = "Listar";
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
                DataSet Dslistar = EMapa.Siguiente(TxtCod_mapa.Text);

                TxtCod_mapa.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtCod_mapav.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Dslistar.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtAinventario.Text = Dslistar.Tables[0].Rows[0]["ainventario"].ToString();
                TxtAcompras.Text = Dslistar.Tables[0].Rows[0]["acompras"].ToString();
                TxtAventas.Text = Dslistar.Tables[0].Rows[0]["aventas"].ToString();
                TxtAbanco.Text = Dslistar.Tables[0].Rows[0]["abanco"].ToString();
                TxtAconfig.Text = Dslistar.Tables[0].Rows[0]["aconfig"].ToString();

                TxtTsioperaciones.Text = Dslistar.Tables[0].Rows[0]["tsioperaciones"].ToString();
                TxtTsitablas.Text = Dslistar.Tables[0].Rows[0]["tsitablas"].ToString();
                TxtTsireportes.Text = Dslistar.Tables[0].Rows[0]["tsireportes"].ToString();

                TxtTscoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscoperaciones"].ToString();
                TxtTsctablas.Text = Dslistar.Tables[0].Rows[0]["tsctablas"].ToString();
                TxtTscreportes.Text = Dslistar.Tables[0].Rows[0]["tscreportes"].ToString();

                TxtTsvoperaciones.Text = Dslistar.Tables[0].Rows[0]["tsvoperaciones"].ToString();
                TxtTsvtablas.Text = Dslistar.Tables[0].Rows[0]["tsvtablas"].ToString();
                TxtTsvreportes.Text = Dslistar.Tables[0].Rows[0]["tsvreportes"].ToString();

                TxtTsboperaciones.Text = Dslistar.Tables[0].Rows[0]["tsboperaciones"].ToString();
                TxtTsbtablas.Text = Dslistar.Tables[0].Rows[0]["tsbtablas"].ToString();
                TxtTsbreportes.Text = Dslistar.Tables[0].Rows[0]["tsbreportes"].ToString();

                TxtTscfoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscfoperaciones"].ToString();
                TxtTscftablas.Text = Dslistar.Tables[0].Rows[0]["tscftablas"].ToString();
                TxtTscfreportes.Text = Dslistar.Tables[0].Rows[0]["tscfreportes"].ToString();

                TxtEditar.Text = "Listar";
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
                DataSet Dslistar = EMapa.Ultimo();

                TxtCod_mapa.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtCod_mapav.Text = Dslistar.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Dslistar.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtAinventario.Text = Dslistar.Tables[0].Rows[0]["ainventario"].ToString();
                TxtAcompras.Text = Dslistar.Tables[0].Rows[0]["acompras"].ToString();
                TxtAventas.Text = Dslistar.Tables[0].Rows[0]["aventas"].ToString();
                TxtAbanco.Text = Dslistar.Tables[0].Rows[0]["abanco"].ToString();
                TxtAconfig.Text = Dslistar.Tables[0].Rows[0]["aconfig"].ToString();

                TxtTsioperaciones.Text = Dslistar.Tables[0].Rows[0]["tsioperaciones"].ToString();
                TxtTsitablas.Text = Dslistar.Tables[0].Rows[0]["tsitablas"].ToString();
                TxtTsireportes.Text = Dslistar.Tables[0].Rows[0]["tsireportes"].ToString();

                TxtTscoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscoperaciones"].ToString();
                TxtTsctablas.Text = Dslistar.Tables[0].Rows[0]["tsctablas"].ToString();
                TxtTscreportes.Text = Dslistar.Tables[0].Rows[0]["tscreportes"].ToString();

                TxtTsvoperaciones.Text = Dslistar.Tables[0].Rows[0]["tsvoperaciones"].ToString();
                TxtTsvtablas.Text = Dslistar.Tables[0].Rows[0]["tsvtablas"].ToString();
                TxtTsvreportes.Text = Dslistar.Tables[0].Rows[0]["tsvreportes"].ToString();

                TxtTsboperaciones.Text = Dslistar.Tables[0].Rows[0]["tsboperaciones"].ToString();
                TxtTsbtablas.Text = Dslistar.Tables[0].Rows[0]["tsbtablas"].ToString();
                TxtTsbreportes.Text = Dslistar.Tables[0].Rows[0]["tsbreportes"].ToString();

                TxtTscfoperaciones.Text = Dslistar.Tables[0].Rows[0]["tscfoperaciones"].ToString();
                TxtTscftablas.Text = Dslistar.Tables[0].Rows[0]["tscftablas"].ToString();
                TxtTscfreportes.Text = Dslistar.Tables[0].Rows[0]["tscfreportes"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }



        #endregion

        public void SetPmapa(string cod_mapa, string desc_mapa, string ainventario, string acompras, string aventas, string abanco, string aconfig, string tsioperaciones, string tsitablas, string tsireportes, string tscoperaciones, string tsctablas, string tscreportes, string tsvoperaciones, string tsvtablas, string tsvreportes, string tsboperaciones, string tsbtablas, string tsbreportes, string tscfoperaciones, string tscftablas, string tscfreportes)
        {
            TxtCod_mapa.Text = cod_mapa;
            TxtCod_mapav.Text = cod_mapa;
            TxtDesc_mapa.Text = desc_mapa;
            TxtAinventario.Text = ainventario;
            TxtAcompras.Text = acompras;
            TxtAventas.Text = aventas;
            TxtAbanco.Text = abanco;
            TxtAconfig.Text = aconfig;
            TxtTsioperaciones.Text = tsioperaciones;
            TxtTsitablas.Text = tsitablas;
            TxtTsireportes.Text = tsireportes;
            TxtTscoperaciones.Text = tscoperaciones;
            TxtTsctablas.Text = tsctablas;
            TxtTscreportes.Text = tscreportes;
            TxtTsvoperaciones.Text = tsvoperaciones;
            TxtTsvtablas.Text = tsvtablas;
            TxtTsvreportes.Text = tsvreportes;
            TxtTsboperaciones.Text = tsboperaciones;
            TxtTsbtablas.Text = tsbtablas;
            TxtTsbreportes.Text = tsbreportes;
            TxtTscfoperaciones.Text = tscfoperaciones;
            TxtTscftablas.Text = tscftablas;
            TxtTscfreportes.Text = tscfreportes;
        }

        private void FMapa_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
