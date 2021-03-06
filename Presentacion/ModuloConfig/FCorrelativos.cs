﻿using Entidades;
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
    public partial class FCorrelativos : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FCorrelativos _Instancia;

        public static FCorrelativos GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FCorrelativos();
            }
            return _Instancia;
        }

        public FCorrelativos()
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

        private void Top_serie_Actual()
        {
            try
            {
                Ds = ECorrelativos.GetCorrelativo(TxtTablaE.Text);

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
                int rpta = Convert.ToInt32(ECorrelativos.GenerarCod(TxtCod_correlativos.Text));
                TxtCod_correlativos.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_correlativos.Focus();
            }
        }

        private void Registros()
        {
            Dt = ECorrelativos.Mostrar();
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
                BtnMuestra.Enabled = false;

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
                BtnMuestra.Enabled = false;

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
                BtnMuestra.Enabled = true;
            }
        }

        private void Limpiar()
        {
            TxtCod_correlativos.Text = String.Empty;
            TxtDesc_correlativos.Text = String.Empty;
            TxtTablaE.Text = String.Empty;
            TxtPrecadena.Text = String.Empty;
            TxtCadenaE.Text = String.Empty;
            TxtCod_num.Text = String.Empty;
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
                Ds = ECorrelativos.Listar();

                TxtCod_correlativos.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtCod_correlativosv.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtDesc_correlativos.Text = Ds.Tables[0].Rows[0]["desc_correlativos"].ToString();
                TxtTablaE.Text = Ds.Tables[0].Rows[0]["tabla"].ToString();
                TxtCadenaE.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                TxtPrecadena.Text = Ds.Tables[0].Rows[0]["precadena"].ToString();
                TxtCod_num.Text = Ds.Tables[0].Rows[0]["cod_num"].ToString();
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
                TxtCod_correlativos.Focus();
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

                if (TxtCod_correlativos.Text == string.Empty || TxtDesc_correlativos.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_correlativos, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_correlativos, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = ECorrelativos.Insertar(TxtCod_correlativos.Text.Trim().ToUpper(), TxtDesc_correlativos.Text.Trim(), TxtTablaE.Text, TxtPrecadena.Text, TxtCadenaE.Text, Convert.ToInt32(TxtCod_num.Text),TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = ECorrelativos.Editar(TxtCod_correlativos.Text.Trim().ToUpper(), TxtCod_correlativosv.Text, TxtDesc_correlativos.Text.Trim(), TxtTablaE.Text, TxtPrecadena.Text, TxtCadenaE.Text, Convert.ToInt32(TxtCod_num.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            TxtCod_correlativosv.Text = TxtCod_correlativos.Text;
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


        internal void SetCorrelativos(string cod_correlativos, string desc_correlativos, string tabla, string precadena, /*string cadena,*/ string cod_num,  string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_correlativos.Text = cod_correlativos;
            TxtCod_correlativosv.Text = cod_correlativos;
            TxtDesc_correlativos.Text = desc_correlativos;
            TxtTablaE.Text = tabla;
            TxtPrecadena.Text = precadena;
            TxtCod_num.Text = cod_num;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        private void FCorrelativos_Load(object sender, EventArgs e)
        {
            Text = "...::: Correlativos :::...";
            MostraUsuario();
            Listar();
        }

        private void FCorrelativos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FCorrelativos_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_correlativos.Focus();
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
                    Rpta = ECorrelativos.Eliminar(TxtCod_correlativos.Text);

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
            FCorrelativosLista Listado = new FCorrelativosLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptCorrelativos Reporte = new FRptCorrelativos();
            //Reporte.ShowDialog();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCod();
        }

        private void Muestra()
        {
            string Rpta = "";
            try
            {
                Top_serie_Actual();

                int rpta = Convert.ToInt32(ECorrelativos.GenerarCodMuestra("", TxtTablaE.Text));
                TxtMuestra.Text = rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Exc)
            {
                Rpta = Exc.Message;
            }
        }

        private void BtnMuestra_Click(object sender, EventArgs e)
        {
            Muestra();
        }

        #endregion

        #region NAVEGAR REGISTROS
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            try
            {
                Ds = ECorrelativos.Primero();

                TxtCod_correlativos.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtCod_correlativosv.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtDesc_correlativos.Text = Ds.Tables[0].Rows[0]["desc_correlativos"].ToString();
                TxtTablaE.Text = Ds.Tables[0].Rows[0]["tabla"].ToString();
                TxtCadenaE.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                TxtPrecadena.Text = Ds.Tables[0].Rows[0]["precadena"].ToString();
                TxtCod_num.Text = Ds.Tables[0].Rows[0]["cod_num"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
                Ds = ECorrelativos.Anterior(TxtDesc_correlativos.Text);

                TxtCod_correlativos.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtCod_correlativosv.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtDesc_correlativos.Text = Ds.Tables[0].Rows[0]["desc_correlativos"].ToString();
                TxtTablaE.Text = Ds.Tables[0].Rows[0]["tabla"].ToString();
                TxtCadenaE.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                TxtPrecadena.Text = Ds.Tables[0].Rows[0]["precadena"].ToString();
                TxtCod_num.Text = Ds.Tables[0].Rows[0]["cod_num"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
                Ds = ECorrelativos.Siguiente(TxtDesc_correlativos.Text);

                TxtCod_correlativos.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtCod_correlativosv.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtDesc_correlativos.Text = Ds.Tables[0].Rows[0]["desc_correlativos"].ToString();
                TxtTablaE.Text = Ds.Tables[0].Rows[0]["tabla"].ToString();
                TxtCadenaE.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                TxtPrecadena.Text = Ds.Tables[0].Rows[0]["precadena"].ToString();
                TxtCod_num.Text = Ds.Tables[0].Rows[0]["cod_num"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
                Ds = ECorrelativos.Ultimo();

                TxtCod_correlativos.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtCod_correlativosv.Text = Ds.Tables[0].Rows[0]["cod_correlativos"].ToString();
                TxtDesc_correlativos.Text = Ds.Tables[0].Rows[0]["desc_correlativos"].ToString();
                TxtTablaE.Text = Ds.Tables[0].Rows[0]["tabla"].ToString();
                TxtCadenaE.Text = Ds.Tables[0].Rows[0]["cadena"].ToString();
                TxtPrecadena.Text = Ds.Tables[0].Rows[0]["precadena"].ToString();
                TxtCod_num.Text = Ds.Tables[0].Rows[0]["cod_num"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

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
        private void TxtTablaE_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtPrecadena_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_num_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCadenaE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtCod_correlativos_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_correlativos_TextChanged(object sender, EventArgs e)
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


    }
}
