using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace Presentacion.ModuloConfig
{
    public partial class FEmpresa : Form
    {
        DataSet DsListar;
        DataTable Dt;

        private static FEmpresa _Instancia;

        public static FEmpresa GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FEmpresa();
            }
            return _Instancia;
        }

        public FEmpresa()
        {
            InitializeComponent();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            TxtCod_empresa.Text = string.Empty;
            TxtCod_pais.Text = string.Empty;
            TxtDesc_pais.Text = string.Empty;
            TxtCod_moneda.Text = string.Empty;
            TxtDesc_moneda.Text = string.Empty;
            TxtCod_islr.Text = "PJD";
            //TxtDesc_islr.Text = string.Empty;
            TxtDesc_empresa.Text = string.Empty;
            TxtRif.Text = string.Empty;
            TxtReplegal.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtMovil.Text = string.Empty;
            TxtCodigo_postal.Text = string.Empty;
            TxtWeb.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtFiscal.Text = false.ToString();
            TxtMontofiscal.Text = string.Empty;
            TxtCampo1.Text = string.Empty;
            TxtCampo2.Text = string.Empty;
            TxtCampo3.Text = string.Empty;
            TxtCampo4.Text = string.Empty;
            TxtCampo5.Text = string.Empty;
            TxtCampo6.Text = string.Empty;
            PbLogo1.Image = Properties.Resources.LIMPIA;
            PbLogo2.Image = Properties.Resources.LIMPIA;
            PbLogo3.Image = Properties.Resources.LIMPIA;
            Top_serie();
        }

        private void MostrarUsuario()
        {
            FLogin mFLogin = FLogin.GetForm();
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet Ds = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
            TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
        }

        private void Top_serie()
        {
            try
            {
                DsListar = ECorrelativos.GetCorrelativo(TxtTabla.Text);

                TxtCadena.Text = DsListar.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception Ex)
            {
                string rpta = "";
                rpta = Ex.Message;
            }
        }

        private void Botones()
        {
            if (TxtEditar.Text == "Nuevo")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
            }
            else if (TxtEditar.Text == "Listar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
            }
        }

        public void Listar()
        {
            try
            {
                DataSet DsListar = EEmpresa.Listar();

                TxtCod_empresa.Text = DsListar.Tables[0].Rows[0]["cod_empresa"].ToString();
                TxtDesc_empresa.Text = DsListar.Tables[0].Rows[0]["desc_empresa"].ToString();
                TxtCod_pais.Text = DsListar.Tables[0].Rows[0]["cod_pais"].ToString();
                TxtDesc_pais.Text = DsListar.Tables[0].Rows[0]["desc_pais"].ToString();
                TxtCod_moneda.Text = DsListar.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = DsListar.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtCod_islr.Text = DsListar.Tables[0].Rows[0]["cod_islr"].ToString();
                TxtDesc_islr.Text = DsListar.Tables[0].Rows[0]["desc_islr"].ToString();
                TxtRif.Text = DsListar.Tables[0].Rows[0]["rif"].ToString();
                TxtReplegal.Text = DsListar.Tables[0].Rows[0]["replegal"].ToString();
                TxtDireccion.Text = DsListar.Tables[0].Rows[0]["direccion"].ToString();
                TxtTelefono.Text = DsListar.Tables[0].Rows[0]["telefono"].ToString();
                TxtMovil.Text = DsListar.Tables[0].Rows[0]["movil"].ToString();
                TxtCodigo_postal.Text = DsListar.Tables[0].Rows[0]["codigo_postal"].ToString();
                TxtWeb.Text = DsListar.Tables[0].Rows[0]["web"].ToString();
                TxtEmail.Text = DsListar.Tables[0].Rows[0]["email"].ToString();
                TxtFiscal.Text = DsListar.Tables[0].Rows[0]["fiscal"].ToString();
                TxtMontofiscal.Text = DsListar.Tables[0].Rows[0]["montofiscal"].ToString();
                TxtCampo1.Text = DsListar.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = DsListar.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = DsListar.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = DsListar.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = DsListar.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = DsListar.Tables[0].Rows[0]["campo6"].ToString();

                TxtCod_empresav.Text = DsListar.Tables[0].Rows[0]["cod_empresa"].ToString();

                byte[] ImgBuffer1 = (byte[])DsListar.Tables[0].Rows[0]["logo1"];
                MemoryStream Ms1 = new MemoryStream(ImgBuffer1);
                PbLogo1.Image = Image.FromStream(Ms1);
                PbLogo1.SizeMode = PictureBoxSizeMode.Zoom;
                LbLogo1.Visible = false;

                byte[] ImgBuffer2 = (byte[])DsListar.Tables[0].Rows[0]["logo2"];
                MemoryStream Ms2 = new MemoryStream(ImgBuffer2);
                PbLogo2.Image = Image.FromStream(Ms2);
                PbLogo2.SizeMode = PictureBoxSizeMode.Zoom;
                LbLogo2.Visible = false;

                byte[] ImgBuffer3 = (byte[])DsListar.Tables[0].Rows[0]["logo3"];
                MemoryStream Ms3 = new MemoryStream(ImgBuffer3);
                PbLogo3.Image = Image.FromStream(Ms3);
                PbLogo3.SizeMode = PictureBoxSizeMode.Zoom;
                LbLogo3.Visible = false;

                TxtEditar.Text = "Listar";

        }
            catch (Exception Ex)
            {
                Show();
        TxtEditar.Text = "Nuevo";
                Limpiar();
        TxtCod_empresa.Focus();
                string rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
    }

}

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_empresa.Text == string.Empty || TxtDesc_empresa.Text == string.Empty || TxtRif.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_empresa, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_empresa, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtRif, "Campo Obligatorio");
                }
                else
                {
                    MemoryStream Ms1 = new MemoryStream();
                    PbLogo1.Image.Save(Ms1, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] RtImagen1 = Ms1.GetBuffer();

                    MemoryStream Ms2 = new MemoryStream();
                    PbLogo2.Image.Save(Ms2, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] RtImagen2 = Ms2.GetBuffer();

                    MemoryStream Ms3 = new MemoryStream();
                    PbLogo3.Image.Save(Ms3, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] RtImagen3 = Ms3.GetBuffer();


                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EEmpresa.Insertar
                            (TxtCod_empresa.Text, TxtCod_moneda.Text, TxtCod_pais.Text, TxtCod_islr.Text,TxtDesc_empresa.Text, TxtRif.Text, TxtReplegal.Text, TxtDireccion.Text,TxtTelefono.Text, TxtMovil.Text, TxtCodigo_postal.Text, TxtWeb.Text, TxtEmail.Text, Convert.ToBoolean(TxtFiscal.Text), Convert.ToDecimal(TxtMontofiscal.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, RtImagen1, RtImagen2, RtImagen3);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EEmpresa.Editar
                            (TxtCod_empresa.Text, TxtCod_empresav.Text,TxtCod_moneda.Text, TxtCod_pais.Text, TxtCod_islr.Text, TxtDesc_empresa.Text, TxtRif.Text, TxtReplegal.Text, TxtDireccion.Text, TxtTelefono.Text, TxtMovil.Text, TxtCodigo_postal.Text, TxtWeb.Text, TxtEmail.Text, Convert.ToBoolean(TxtFiscal.Text), Convert.ToDecimal(TxtMontofiscal.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text, RtImagen1, RtImagen2, RtImagen3);
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

        private void CambiosTexBox()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
            }
            ErrorTexto.Dispose();
        }

        private void MostrarIslr()
        {
            DataSet DsI = EIslr.MostrarCB(TxtCod_islr.Text);
            TxtDesc_islr.Text = DsI.Tables[0].Rows[0]["desc_islr"].ToString();
        }

        private void SeleccionarIslr()
        {
            Dt = EIslr.Mostrar();
            for (int i = 0; i <= Convert.ToInt32(Dt.Rows.Count) - 1; i++)
            {
                TxtCod_islr.Items.Add(Dt.Rows[i][0].ToString());
            }
        }

        private void EventosChk()
        {
            if (ChkFiscal.Checked == true)
            {
                TxtFiscal.Text = true.ToString();
                TxtMontofiscal.Enabled = true;
            }
            else
            {
                TxtFiscal.Text = false.ToString();
                TxtMontofiscal.Enabled = false;
            }
        }

        private void EventosTexBox()
        {
            if (TxtFiscal.Text == true.ToString())
            {
                ChkFiscal.Checked = true;
            }
            else
            {
                ChkFiscal.Checked = false;
            }
        }

        private void FEmpresa_Load(object sender, EventArgs e)
        {
            Text = "...::: Empresa :::...";
            MostrarUsuario();
            SeleccionarIslr();
            //MostrarIslr();
            EventosChk();
            Listar();
        }

        #region PROCESOS PRINCIPALES
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            Botones();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Listar();
            Botones();
        }

        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtCod_empresa_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_empresa_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void ChkFiscal_CheckedChanged(object sender, EventArgs e)
        {
            EventosChk();
        }

        private void TxtRif_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtReplegal_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_pais_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_moneda_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_islr_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarIslr();
            CambiosTexBox();
        }

        private void TxtFiscal_TextChanged(object sender, EventArgs e)
        {
            EventosTexBox();
            CambiosTexBox();
        }

        private void TxtMontofiscal_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
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

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtMovil_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCodigo_postal_TextChanged(object sender, EventArgs e)
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
        private void TxtEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_mapa_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        #endregion

        internal void SetPais(string cod_pais, string desc_pais, string cod_moneda, string desc_moneda)
        {
            TxtCod_pais.Text = cod_pais;
            TxtDesc_pais.Text = desc_pais;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        internal void SetMoneda(string cod_moneda, string desc_moneda)
        {
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        private void TxtCod_pais_DoubleClick(object sender, EventArgs e)
        {
            //FPaisLista Listado = new FPaisLista();
            //Listado.TxtFlag.Text = "Empresa";
            //Dt = EPais.Mostrar();
            //if (Dt.Rows.Count == 0)
            //{
            //    MensajeError("No Existen Registros Disponibles!");
            //}
            //else if (Dt.Rows.Count != 0)
            //{
            //    Listado.ShowDialog();

            //};
        }

        private void TxtCod_pais_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F12)
            //{
            //    FPaisLista Listado = new FPaisLista();
            //    Listado.TxtFlag.Text = "Empresa";
            //    Dt = EPais.Mostrar();
            //    if (Dt.Rows.Count == 0)
            //    {
            //        MensajeError("No Existen Registros Disponibles!");
            //    }
            //    else if (Dt.Rows.Count != 0)
            //    {
            //        Listado.ShowDialog();

            //    };
            //}
        }

        private void TxtCod_moneda_DoubleClick(object sender, EventArgs e)
        {
            //FMonedaLista Listado = new FMonedaLista();
            //Listado.TxtFlag.Text = "Empresa";
            //Dt = EMoneda.Mostrar();
            //if (Dt.Rows.Count == 0)
            //{
            //    MensajeError("No Existen Registros Disponibles!");
            //}
            //else if (Dt.Rows.Count != 0)
            //{
            //    Listado.ShowDialog();

            //};
        }

        private void TxtCod_moneda_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F12)
            //{
            //    FMonedaLista Listado = new FMonedaLista();
            //    Listado.TxtFlag.Text = "Empresa";
            //    Dt = EMoneda.Mostrar();
            //    if (Dt.Rows.Count == 0)
            //    {
            //        MensajeError("No Existen Registros Disponibles!");
            //    }
            //    else if (Dt.Rows.Count != 0)
            //    {
            //        Listado.ShowDialog();

            //    };
            //}
        }

        private void FEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtEditar.Text == "Editar" || TxtEditar.Text == "Nuevo")
            {
                DialogResult Resp = MessageBox.Show("Desea Guardar los Cambios antes de Salir?", "...::: Step One Ver 1.0 :::...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Resp == DialogResult.Yes)
                {
                    Guardar();
                }
            }
        }

        private void BtnCargarImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.bmp;*.gif;*.png;*.jpeg"
            };

            DialogResult Opcion = Abrir.ShowDialog();

            if (Opcion == DialogResult.OK)
            {
                LbLogo1.Visible = false;
                PbLogo1.SizeMode = PictureBoxSizeMode.Zoom;
                PbLogo1.Image = Properties.Resources.LIMPIA;
                PbLogo1.Image = Image.FromFile(Abrir.FileName);
            }
            CambiosTexBox();
        }

        private void BtnEliminarImg1_Click(object sender, EventArgs e)
        {
            PbLogo1.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogo1.Image = Properties.Resources.LIMPIA;
            LbLogo1.Visible = true;
            CambiosTexBox();
        }

        private void BtnCargarImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.bmp;*.gif;*.png;*.jpeg"
            };

            DialogResult Opcion = Abrir.ShowDialog();

            if (Opcion == DialogResult.OK)
            {
                LbLogo2.Visible = false;
                PbLogo2.SizeMode = PictureBoxSizeMode.Zoom;
                PbLogo2.Image = Properties.Resources.LIMPIA;
                PbLogo2.Image = Image.FromFile(Abrir.FileName);
            }
            CambiosTexBox();
        }

        private void BtnEliminarImg2_Click(object sender, EventArgs e)
        {
            PbLogo2.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogo2.Image = Properties.Resources.LIMPIA;
            LbLogo2.Visible = true;
            CambiosTexBox();
        }

        private void BtnCargarImg3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.bmp;*.gif;*.png;*.jpeg"
            };

            DialogResult Opcion = Abrir.ShowDialog();

            if (Opcion == DialogResult.OK)
            {
                LbLogo3.Visible = false;
                PbLogo3.SizeMode = PictureBoxSizeMode.Zoom;
                PbLogo3.Image = Properties.Resources.LIMPIA;
                PbLogo3.Image = Image.FromFile(Abrir.FileName);
            }
            CambiosTexBox();
        }

        private void BtnEliminarImg3_Click(object sender, EventArgs e)
        {
            PbLogo3.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogo3.Image = Properties.Resources.LIMPIA;
            LbLogo3.Visible = true;
            CambiosTexBox();
        }

    }
}
