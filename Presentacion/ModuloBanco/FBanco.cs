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
    public partial class FBanco : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FBanco _Instancia;

        public static FBanco GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FBanco();
            }
            return _Instancia;
        }

        public FBanco()
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
            Dt = EBanco.Mostrar();
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
            TxtCod_banco.Text = String.Empty;
            TxtDesc_banco.Text = String.Empty;
            TxtCod_moneda.Text = String.Empty;
            TxtDesc_moneda.Text = String.Empty;
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
                Ds = EBanco.Listar();

                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtCod_bancov.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtPlazo1.Text = Ds.Tables[0].Rows[0]["plazo1"].ToString();
                TxtPlazo2.Text = Ds.Tables[0].Rows[0]["plazo2"].ToString();
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
                TxtCod_banco.Focus();
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

                if (TxtCod_banco.Text == string.Empty || TxtDesc_banco.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_banco, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_banco, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EBanco.Insertar(TxtCod_banco.Text.Trim().ToUpper(), TxtDesc_banco.Text.Trim(), TxtCod_moneda.Text, TxtTelefono.Text, Convert.ToInt32(TxtPlazo1.Text), Convert.ToInt32(TxtPlazo2.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EBanco.Editar(TxtCod_banco.Text.Trim().ToUpper(), TxtCod_bancov.Text, TxtDesc_banco.Text.Trim(), TxtCod_moneda.Text, TxtTelefono.Text, Convert.ToInt32(TxtPlazo1.Text), Convert.ToInt32(TxtPlazo2.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_bancov.Text = TxtCod_banco.Text;
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
                int rpta = Convert.ToInt32(EBanco.GenerarCod(TxtCod_banco.Text));
                TxtCod_banco.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_banco.Focus();
            }
        }

        internal void SetBanco(string cod_banco, string desc_banco, string cod_moneda, string desc_moneda, string telefono, string plazo1, string plazo2,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_banco.Text = cod_banco;
            TxtCod_bancov.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtTelefono.Text = telefono;
            TxtPlazo1.Text = plazo1;
            TxtPlazo2.Text = plazo2;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetMoneda(string cod_moneda, string desc_moneda)
        {
            TxtCod_moneda.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
        }

        private void FBanco_Load(object sender, EventArgs e)
        {
            Text = "...::: Bancos :::...";
            MostraUsuario();
            Listar();
        }

        private void FBanco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FBanco_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_banco.Focus();
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
                    Rpta = EBanco.Eliminar(TxtCod_banco.Text);

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
            FBancoLista Listado = new FBancoLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptBanco Reporte = new FRptBanco();
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
                Ds = EBanco.Primero();

                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtPlazo1.Text = Ds.Tables[0].Rows[0]["plazo1"].ToString();
                TxtPlazo2.Text = Ds.Tables[0].Rows[0]["plazo2"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_bancov.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();

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
                Ds = EBanco.Anterior(TxtCod_banco.Text);

                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtPlazo1.Text = Ds.Tables[0].Rows[0]["plazo1"].ToString();
                TxtPlazo2.Text = Ds.Tables[0].Rows[0]["plazo2"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_bancov.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();

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
                Ds = EBanco.Siguiente(TxtCod_banco.Text);

                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtPlazo1.Text = Ds.Tables[0].Rows[0]["plazo1"].ToString();
                TxtPlazo2.Text = Ds.Tables[0].Rows[0]["plazo2"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_bancov.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();

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
                Ds = EBanco.Ultimo();

                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtTelefono.Text = Ds.Tables[0].Rows[0]["telefono"].ToString();
                TxtPlazo1.Text = Ds.Tables[0].Rows[0]["plazo1"].ToString();
                TxtPlazo2.Text = Ds.Tables[0].Rows[0]["plazo2"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_bancov.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();

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
        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPlazo1_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPlazo2_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_moneda_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_banco_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_banco_TextChanged(object sender, EventArgs e)
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
        #endregion

        private void TxtCod_moneda_DoubleClick(object sender, EventArgs e)
        {
            FMonedaLista Listado = new FMonedaLista
            {
                TxtFlag = "Banco"
            };
            Dt = EBanco.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            }
        }

        private void TxtCod_moneda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F12)
            {
                FMonedaLista Listado = new FMonedaLista
                {
                    TxtFlag = "Banco"
                };
                Dt = EBanco.Mostrar();
                if(Dt.Rows.Count==0)
                {
                    MensajeError("No Existen Registros Disponibles!");
                }
                else if (Dt.Rows.Count != 0)
                {
                    Listado.ShowDialog();
                }
            }
        }
    }
}
