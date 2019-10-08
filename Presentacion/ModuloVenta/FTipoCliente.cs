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
    public partial class FTipoCliente : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FTipoCliente _Instancia;

        public static FTipoCliente GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FTipoCliente();
            }
            return _Instancia;
        }

        public FTipoCliente()
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
            Dt = ETipoCliente.Mostrar();
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
            TxtCod_tipocliente.Text = String.Empty;
            TxtDesc_tipocliente.Text = String.Empty;
            TxtCod_precio.Text = String.Empty;
            TxtDesc_precio.Text = String.Empty;
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
                Ds = ETipoCliente.Listar();

                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();
                TxtCod_tipoclientev.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["desc_tipocliente"].ToString();
                TxtCod_precio.Text = Ds.Tables[0].Rows[0]["cod_precio"].ToString();
                TxtDesc_precio.Text = Ds.Tables[0].Rows[0]["desc_precio"].ToString();
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
                TxtCod_tipocliente.Focus();
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

                if (TxtCod_tipocliente.Text == string.Empty || TxtDesc_tipocliente.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_tipocliente, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_tipocliente, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = ETipoCliente.Insertar(TxtCod_tipocliente.Text.Trim().ToUpper(), TxtDesc_tipocliente.Text.Trim(), TxtCod_precio.Text,TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = ETipoCliente.Editar(TxtCod_tipocliente.Text.Trim().ToUpper(), TxtCod_tipoclientev.Text, TxtDesc_tipocliente.Text.Trim(),TxtCod_precio.Text, TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_tipoclientev.Text = TxtCod_tipocliente.Text;
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
                int rpta = Convert.ToInt32(ETipoCliente.GenerarCod(TxtCod_tipocliente.Text));
                TxtCod_tipocliente.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_tipocliente.Focus();
            }
        }

        internal void SetTipoCliente(string cod_tipocliente, string desc_tipocliente, string cod_precio, string desc_precio,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_tipocliente.Text = cod_tipocliente;
            TxtCod_tipoclientev.Text = cod_tipocliente;
            TxtDesc_tipocliente.Text = desc_tipocliente;
            TxtCod_precio.Text = cod_precio;
            TxtDesc_precio.Text = desc_precio;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetPrecio(string cod_precio, string desc_precio)
        {
            TxtCod_precio.Text = cod_precio;
            TxtDesc_precio.Text = desc_precio;
        }

        private void FTipoCliente_Load(object sender, EventArgs e)
        {
            Text = "...::: Tipos de Clientes :::...";
            MostraUsuario();
            Listar();
        }

        private void FTipoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FTipoCliente_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_tipocliente.Focus();
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
                    Rpta = ETipoCliente.Eliminar(TxtCod_tipocliente.Text);

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
            FTipoClienteLista Listado = new FTipoClienteLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptTipoCliente Reporte = new FRptTipoCliente();
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
                Ds = ETipoCliente.Primero();

                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["desc_tipocliente"].ToString();
                TxtCod_precio.Text = Ds.Tables[0].Rows[0]["cod_precio"].ToString();
                TxtDesc_precio.Text = Ds.Tables[0].Rows[0]["desc_precio"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_tipoclientev.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();

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
                Ds = ETipoCliente.Anterior(TxtCod_tipocliente.Text);

                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["desc_tipocliente"].ToString();
                TxtCod_precio.Text = Ds.Tables[0].Rows[0]["cod_precio"].ToString();
                TxtDesc_precio.Text = Ds.Tables[0].Rows[0]["desc_precio"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_tipoclientev.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();

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
                Ds = ETipoCliente.Siguiente(TxtCod_tipocliente.Text);

                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["desc_tipocliente"].ToString();
                TxtCod_precio.Text = Ds.Tables[0].Rows[0]["cod_precio"].ToString();
                TxtDesc_precio.Text = Ds.Tables[0].Rows[0]["desc_precio"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_tipoclientev.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();

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
                Ds = ETipoCliente.Ultimo();

                TxtCod_tipocliente.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();
                TxtDesc_tipocliente.Text = Ds.Tables[0].Rows[0]["desc_tipocliente"].ToString();
                TxtCod_precio.Text = Ds.Tables[0].Rows[0]["cod_precio"].ToString();
                TxtDesc_precio.Text = Ds.Tables[0].Rows[0]["desc_precio"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_tipoclientev.Text = Ds.Tables[0].Rows[0]["cod_tipocliente"].ToString();

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
        private void TxtCod_precio_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_tipocliente_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_tipocliente_TextChanged(object sender, EventArgs e)
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

        private void TxtCod_precio_DoubleClick(object sender, EventArgs e)
        {
            FPrecioLista Listado = new FPrecioLista();
            Dt = EPrecio.Mostrar();
            if(Dt.Rows.Count==0)
            {
                MensajeError("No Existen Registros!");
            }
            else
            {
                Listado.TxtFlag = "TipoCliente";
                Listado.ShowDialog();
            }
        }

        private void TxtCod_precio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F12)
            {
                FPrecioLista Listado = new FPrecioLista();
                Dt = EPrecio.Mostrar();
                if (Dt.Rows.Count == 0)
                {
                    MensajeError("No Existen Registros!");
                }
                else
                {
                    Listado.TxtFlag = "TipoCliente";
                    Listado.ShowDialog();
                }
            }
        }
    }
}
