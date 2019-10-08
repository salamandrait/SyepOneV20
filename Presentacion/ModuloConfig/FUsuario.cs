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

namespace Presentacion.ModuloConfig
{
    public partial class FUsuario : Form
    {
        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FUsuario _Instancia;

        public static FUsuario GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FUsuario();
            }
            return _Instancia;
        }

        public FUsuario()
        {
            InitializeComponent();
            ComboEstatus();
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
            TxtCod_usuario.Text = string.Empty;
            TxtDesc_usuario.Text = string.Empty;
            TxtCod_mapa.Text = string.Empty;
            TxtDesc_mapa.Text = string.Empty;
            TxtClave.Text = string.Empty;
            TxtConfirmar.Text = string.Empty;
            TxtEstatus.Text = "Activo";
            TxtCampo1.Text = string.Empty;
            TxtCampo2.Text = string.Empty;
            TxtCampo3.Text = string.Empty;
            TxtCampo4.Text = string.Empty;
            TxtCampo5.Text = string.Empty;
            TxtCampo6.Text = string.Empty;
            Top_serie();
        }

        private void Registros()
        {
            Dt = EUsuario.Mostrar();
            LbTotalReg.Text = Convert.ToString(Dt.Rows.Count.ToString());
        }

        private void MostrarUsuario()
        {
            FLogin mFLogin = FLogin.GetForm();
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet Ds = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuarioE.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
            txtDesc_usuarioE.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
        }

        private void Top_serie()
        {
            try
            {
                Ds = ECorrelativos.GetCorrelativo(TxtTabla.Text);

                TxtCadena.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                Pref= Ds.Tables[0].Rows[0]["precadena"].ToString();
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
                int rpta = Convert.ToInt32(EUsuario.GenerarCod(TxtCod_usuario.Text));
                TxtCod_usuario.Text = rpta.ToString(Pref+TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_usuario.Focus();
            }
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
                TxtCod_usuario.Enabled = true;
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
                TxtCod_usuario.Enabled = false;
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
                TxtCod_usuario.Enabled = false;
            }
        }

        private void CambiosTexBox()
        {
            if (TxtEditar.Text == "Listar")
            {
                TxtEditar.Text = "Editar";
                TxtConfirmar.Visible = true;
                LbConfirmar.Visible = true;
            }
            ErrorTexto.Dispose();
        }

        public void Listar()
        {
            try
            {
                Ds = EUsuario.Listar();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtCod_usuariov.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
                TxtCod_mapa.Text = Ds.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Ds.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtClave.Text = Ds.Tables[0].Rows[0]["clave"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
                TxtConfirmar.Visible = false;
                LbConfirmar.Visible = false;

            }
            catch (Exception Ex)
            {
                Show();
                TxtEditar.Text = "Nuevo";
                TxtConfirmar.Visible = true;
                LbConfirmar.Visible = true;
                Limpiar();
                TxtCod_usuario.Focus();
                string rpta = Ex.Message;
                MensajeOk("Tabla Vacia, esta en modo Ingreso");
            }

        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_usuario.Text == string.Empty || TxtDesc_usuario.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_usuario, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_usuario, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EUsuario.Insertar
                            (TxtCod_usuario.Text.Trim().ToUpper(), TxtDesc_usuario.Text.Trim(),TxtCod_mapa.Text,TxtClave.Text,TxtEstatus.Text,TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EUsuario.Editar
                            (TxtCod_usuario.Text.Trim().ToUpper(), TxtCod_usuariov.Text.Trim().ToUpper(),TxtDesc_usuario.Text.Trim(), TxtCod_mapa.Text, TxtClave.Text, TxtEstatus.Text, TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
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

        private void ComboEstatus()
        {
            TxtEstatus.Items.AddRange(new string[] { "Activo", "Bloqueado", "Inactivo" });
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            Text = "...::: Usuarios :::...";
            MostrarUsuario();
            Listar();
        }

        #region PROCESOS PRINCIPALES
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            Botones();
            TxtConfirmar.Visible = false;
            LbConfirmar.Visible = false;
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
            TxtConfirmar.Visible = true;
            LbConfirmar.Visible = true;
            Limpiar();
            TxtCod_usuario.Focus();
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
                    Rpta = EUsuario.Eliminar(TxtCod_usuario.Text);

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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FUsuarioLista Listado = new FUsuarioLista();
            Listado.TxtFlag.Text = 0.ToString();
            Listado.ShowDialog();

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //RUsuario Reporte = new RUsuario();
            //Reporte.ShowDialog();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            
            GenerarCod();
        }

        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtCod_usuario_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_usuario_TextChanged(object sender, EventArgs e)
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

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = EUsuario.Primero();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
                TxtCod_mapa.Text = Ds.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Ds.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtClave.Text = Ds.Tables[0].Rows[0]["clave"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuariov.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();

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
                Ds = EUsuario.Anterior(TxtCod_usuario.Text);

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
                TxtCod_mapa.Text = Ds.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Ds.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtClave.Text = Ds.Tables[0].Rows[0]["clave"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuariov.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();

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
                Ds = EUsuario.Siguiente(TxtCod_usuario.Text);

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
                TxtCod_mapa.Text = Ds.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Ds.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtClave.Text = Ds.Tables[0].Rows[0]["clave"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuariov.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();

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
                Ds = EUsuario.Ultimo();

                TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
                TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
                TxtCod_mapa.Text = Ds.Tables[0].Rows[0]["cod_mapa"].ToString();
                TxtDesc_mapa.Text = Ds.Tables[0].Rows[0]["desc_mapa"].ToString();
                TxtClave.Text = Ds.Tables[0].Rows[0]["clave"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_usuariov.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        #endregion

        internal void SetUsuario(string cod_usuario, string desc_usuario, string cod_mapa, string desc_mapa, string clave, string estatus,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_usuario.Text = cod_usuario;
            TxtCod_usuariov.Text = cod_usuario;
            TxtDesc_usuario.Text = desc_usuario;
            TxtCod_mapa.Text = cod_mapa;
            TxtDesc_mapa.Text = desc_mapa;
            TxtClave.Text = clave;
            TxtEstatus.Text = estatus;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetMapa(string cod_mapa, string desc_mapa)
        {
            TxtCod_mapa.Text = cod_mapa;
            TxtDesc_mapa.Text = desc_mapa;
        }

        private void TxtCod_mapa_DoubleClick(object sender, EventArgs e)
        {
            FMapaLista Listado = new FMapaLista();
            Listado.TxtFlag.Text = "Usuario";
            Dt = EMapa.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();

            };
        }

        private void TxtCod_mapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FMapaLista Listado = new FMapaLista();
                Listado.TxtFlag.Text = "Usuario";
                Dt = EMapa.Mostrar();
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

        private void FUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FUsuario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TxtConfirmar_Validated(object sender, EventArgs e)
        {
            if (TxtClave.Text != TxtConfirmar.Text)
            {
                MensajeError("La Clave de Confirmacion no Coincide con la Clave Ingresada");
                ErrorTexto.SetError(TxtClave, "Campo Obligatorio");
                ErrorTexto.SetError(TxtConfirmar, "Verifique!");
            }
        }


    }
}
