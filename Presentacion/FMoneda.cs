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

namespace Presentacion
{
    public partial class FMoneda : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FMoneda _Instancia;

        public static FMoneda GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FMoneda();
            }
            return _Instancia;
        }

        public FMoneda()
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
            Dt = EMoneda.Mostrar();
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
            TxtCod_moneda.Text = String.Empty;
            TxtDesc_moneda.Text = String.Empty;
            TxtMonebase.Text = false.ToString();
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
                Ds = EMoneda.Listar();

                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtCod_monedav.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtMonebase.Text = Ds.Tables[0].Rows[0]["monebase"].ToString();
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
                TxtCod_moneda.Focus();
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

                if (TxtCod_moneda.Text == string.Empty || TxtDesc_moneda.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_moneda, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_moneda, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EMoneda.Insertar(TxtCod_moneda.Text.Trim().ToUpper(), TxtDesc_moneda.Text.Trim(), Convert.ToBoolean(TxtMonebase.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EMoneda.Editar(TxtCod_moneda.Text.Trim().ToUpper(), TxtCod_monedav.Text, TxtDesc_moneda.Text.Trim(), Convert.ToBoolean(TxtMonebase.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_monedav.Text = TxtCod_moneda.Text;
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
                int rpta = Convert.ToInt32(EMoneda.GenerarCod(TxtCod_moneda.Text));
                TxtCod_moneda.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_moneda.Focus();
            }
        }

        internal void SetMoneda(string cod_moneda, string desc_moneda, string monebase, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_moneda.Text = cod_moneda;
            TxtCod_monedav.Text = cod_moneda;
            TxtDesc_moneda.Text = desc_moneda;
            TxtMonebase.Text = monebase;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        private void EventosTextBox()
        {
            if (TxtMonebase.Text == true.ToString())
            {
                ChkMonebase.Checked = true;
            }
            else
            {
                ChkMonebase.Checked = false;
            }
        }

        private void EventosChk()
        {
            if (ChkMonebase.Checked == true)
            {
                TxtMonebase.Text = true.ToString();
            }
            else
            {
                TxtMonebase.Text = false.ToString();
            }
        }

        //private void ReemplazarMoneda()
        //{
        //    String Rpta = "";

        //    if (TxtEditar.Text=="Editar")
        //    {
        //        DialogResult Opcion = MessageBox.Show("Desea Actualizar la Moneda Base? Esto puede Generar Inconsistencias en Documentos  que esten en Estatus = Procesado Parcial", "...::: Step One Ver 5.1 :::...",
        //       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //        foreach (DataRow Row in Dt.Rows)
        //        {
        //            if (Convert.ToBoolean(Row["monebase"]) == true)
        //            {
        //                try
        //                {
        //                    if (Opcion == DialogResult.OK)
        //                    {
        //                        Rpta = EMoneda.EditarBase(TxtCod_moneda.Text);
        //                    }
        //                    else
        //                    {
        //                        MensajeError("Cancelando la Edicion de Moneda");
        //                    }
        //                }
        //                catch (Exception Exc)
        //                {
        //                    MensajeError(Exc.Message);
        //                }
        //            }
        //        }
        //    }
        //}


        private void FMoneda_Load(object sender, EventArgs e)
        {

            Text = "...::: Monedas :::...";
            MostraUsuario();
            Listar();
        }

        private void FMoneda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FMoneda_FormClosing(object sender, FormClosingEventArgs e)
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
            EventosChk();
            EventosTextBox();
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
            TxtCod_moneda.Focus();
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
                    Rpta = EMoneda.Eliminar(TxtCod_moneda.Text);

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
            FMonedaLista Listado = new FMonedaLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptMoneda Reporte = new FRptMoneda();
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
                Ds = EMoneda.Primero();

                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtMonebase.Text = Ds.Tables[0].Rows[0]["monebase"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_monedav.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();

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
                Ds = EMoneda.Anterior(TxtCod_moneda.Text);

                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtMonebase.Text = Ds.Tables[0].Rows[0]["monebase"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_monedav.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();

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
                Ds = EMoneda.Siguiente(TxtCod_moneda.Text);

                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtMonebase.Text = Ds.Tables[0].Rows[0]["monebase"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_monedav.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();

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
                Ds = EMoneda.Ultimo();

                TxtCod_moneda.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();
                TxtDesc_moneda.Text = Ds.Tables[0].Rows[0]["desc_moneda"].ToString();
                TxtMonebase.Text = Ds.Tables[0].Rows[0]["monebase"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();
                TxtCod_monedav.Text = Ds.Tables[0].Rows[0]["cod_moneda"].ToString();

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
        private void ChkMonebase_CheckedChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosChk();
        }

        private void TxtMonebase_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
            EventosTextBox();
        }

        private void TxtCod_moneda_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_moneda_TextChanged(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
