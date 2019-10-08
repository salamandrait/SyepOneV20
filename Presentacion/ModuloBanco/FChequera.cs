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
    public partial class FChequera : Form
    {

        DataSet Ds;
        DataTable Dt;
        string Pref = "";
        DialogResult Opcion;

        private static FChequera _Instancia;

        public static FChequera GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FChequera();
            }
            return _Instancia;
        }

        public FChequera()
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
            Dt = EChequera.Mostrar();
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
                BtnActivar.Enabled = false;
                BtnSuspender.Enabled = false;
                BtnGenerar.Enabled = true;
                BtnGenerarCheq.Enabled = false;
                Habilitar(true);

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
                BtnActivar.Enabled = false;
                BtnSuspender.Enabled = false;
                BtnGenerar.Enabled = false;
                BtnGenerarCheq.Enabled = false;
                Habilitar(true);

            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Activa")
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
                BtnGenerarCheq.Enabled = true;
                Habilitar(true);

                BtnActivar.Text = "Inactivar";
                BtnActivar.Enabled = true;
                BtnSuspender.Enabled = true;
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Inactiva")
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
                BtnGenerarCheq.Enabled = false;
                Habilitar(false);

                BtnActivar.Text = "Activar";
                BtnActivar.Enabled = true;
                BtnSuspender.Enabled = true;
            }
            else if (TxtEditar.Text == "Listar" && TxtEstatus.Text == "Suspendida")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnGenerar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = true;

                BtnAnterior.Enabled = true;
                BtnPrimero.Enabled = true;
                BtnSiguiente.Enabled = true;
                BtnUltimo.Enabled = true;
                BtnListar.Enabled = true;
                BtnGenerarCheq.Enabled = false;
                Habilitar(false);

                BtnActivar.Enabled = false;
                BtnSuspender.Enabled = false;
            }
        }

        private void Limpiar()
        {
            TxtCod_chequera.Text = String.Empty;
            TxtDesc_chequera.Text = String.Empty;
            TxtCod_cuenta.Text = String.Empty;
            TxtDesc_cuenta.Text = String.Empty;
            TxtCod_banco.Text = String.Empty;
            TxtDesc_banco.Text = String.Empty;
            TxtNumcuenta.Text = String.Empty;
            TxtResponsable.Text = String.Empty;
            TxtCantidad.Text = String.Empty;
            TxtEstatus.Text = "Activa";
            TxtFecha_reg.Text = String.Empty;
            TxtCampo1.Text = String.Empty;
            TxtCampo2.Text = String.Empty;
            TxtCampo3.Text = String.Empty;
            TxtCampo4.Text = String.Empty;
            TxtCampo5.Text = String.Empty;
            TxtCampo6.Text = String.Empty;
            Top_serie();
        }

        private void Habilitar(bool valor)
        {
            TxtCod_chequera.Enabled = valor;
            TxtCod_cuenta.Enabled = valor;
            TxtDesc_chequera.Enabled = valor;
            TxtResponsable.Enabled = valor;
            TxtCantidad.Enabled = valor;
            TxtFecha_reg.Enabled = valor;
            TxtCampo1.Enabled = valor;
            TxtCampo2.Enabled = valor;
            TxtCampo3.Enabled = valor;
            TxtCampo4.Enabled = valor;
            TxtCampo5.Enabled = valor;
            TxtCampo6.Enabled = valor;
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
                Ds = EChequera.Listar();

                TxtCod_chequera.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtCod_chequerav.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtDesc_chequera.Text = Ds.Tables[0].Rows[0]["desc_chequera"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtCantidad.Text = Ds.Tables[0].Rows[0]["cantidad"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
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
                TxtCod_chequera.Focus();
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

                if (TxtCod_chequera.Text == string.Empty || TxtDesc_chequera.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_chequera, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_chequera, "Campo Obligatorio");
                }
                else if (TxtCantidad.Value <= 0)
                {
                    MensajeError("No se puede Ingresar una Chequera con 0 Cheques");
                    ErrorTexto.SetError(TxtCantidad, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        EventoActivarGuardar();
                        Rpta = EChequera.Insertar(TxtCod_chequera.Text, TxtDesc_chequera.Text, TxtCod_cuenta.Text, Convert.ToDecimal(TxtCantidad.Text), TxtEstatus.Text, Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EChequera.Editar(TxtCod_chequera.Text, TxtCod_chequerav.Text, TxtDesc_chequera.Text, TxtCod_cuenta.Text, Convert.ToDecimal(TxtCantidad.Text), TxtEstatus.Text, Convert.ToDateTime(TxtFecha_reg.Text), TxtCampo1.Text, TxtCampo2.Text, TxtCampo3.Text, TxtCampo4.Text, TxtCampo5.Text, TxtCampo6.Text);
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

        private void GenerarCod()
        {
            try
            {
                int rpta = Convert.ToInt32(EChequera.GenerarCod(TxtCod_chequera.Text));
                TxtCod_chequera.Text = Pref + rpta.ToString(TxtCadena.Text);
            }
            catch (Exception Ex)
            {
                MensajeError(" Solo se puede Generar Codigos Numericos " + Ex.StackTrace);
                TxtCod_chequera.Focus();
            }
        }

        public void ConsultarListado()
        {

            Dt = EChequeraDetalle.Mostrar(TxtCod_chequera.Text, TxtCod_cuenta.Text, "NULL");
            if (Dt.Rows.Count == 0)
            {
                BtnGenerarCheq.Text = "Generar";
            }
            else if (Dt.Rows.Count != 0)
            {
                BtnGenerarCheq.Text = "Consultar";
            }
        }

        private void EventoActivarGuardar()
        {
            DataTable DtDet = EChequera.Mostrar();

            foreach (DataRow Fila in DtDet.Rows)
            {
                if (Convert.ToString(Fila["cod_cuenta"].ToString()).Equals(TxtCod_cuenta.Text))
                {
                    if (Convert.ToString(Fila["estatus"].ToString()).Equals("Activa"))
                    {
                        DialogResult Opcion = MessageBox.Show("La Cuenta Seleccionada ya posee una Chequera Activa, Desea registrar la Nueva Chequera Como Inactiva?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            TxtEstatus.Text = "Inactiva";
                        }
                        else
                        {
                            TxtEstatus.Text = "Activa";
                        }
                    }
                }
            }
        }

        private void FChequera_Load(object sender, EventArgs e)
        {
            Text = "...::: Chequeras :::...";
            MostraUsuario();
            ConsultarListado();
            Listar();
        }

        private void FChequera_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FChequera_FormClosing(object sender, FormClosingEventArgs e)
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
            TxtCod_chequerav.Text = TxtCod_chequera.Text;
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
            TxtCod_chequera.Focus();
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
                    Rpta = EChequera.Eliminar(TxtCod_chequera.Text);

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

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            DataTable DsT = EChequera.Mostrar();

            foreach (DataRow Row in DsT.Rows)
            {
                if (Convert.ToString(Row["cod_chequera"]).Equals(TxtCod_chequera.Text) && (Convert.ToString(TxtEstatus.Text).Equals("Activa") || Convert.ToString(TxtEstatus.Text).Equals("Inactiva")))
                {

                    Opcion = MessageBox.Show("Desea " + BtnActivar.Text + " esta Chequera!", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        if (Row["Estatus"].Equals("Activa"))
                        {
                            TxtEstatus.Text = "Inactiva";
                            BtnActivar.Text = "Activar";
                            Guardar();
                        }
                        else if (Row["Estatus"].Equals("Inactiva"))
                        {
                            TxtEstatus.Text = "Activa";
                            BtnActivar.Text = "Inactivar";
                            Guardar();
                        }
                    }
                }
            }
        }

        private void BtnSuspender_Click(object sender, EventArgs e)
        {
            DataTable DsT = EChequera.Mostrar();

            foreach (DataRow Row in DsT.Rows)
            {
                if (Convert.ToString(Row["cod_chequera"]).Equals(TxtCod_chequera.Text) && (Convert.ToString(TxtEstatus.Text).Equals("Activa") || Convert.ToString(TxtEstatus.Text).Equals("Inactiva")))
                {

                    Opcion = MessageBox.Show("Desea Suspender esta Chequera esta Chequera? Atencion! este proceso es Irreversible", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        if (Row["Estatus"].Equals("Activa"))
                        {
                            TxtEstatus.Text = "Suspendida";
                            Guardar();
                        }
                        else if (Row["Estatus"].Equals("Inactiva"))
                        {
                            TxtEstatus.Text = "Suspendida";
                            Guardar();
                        }
                    }
                }
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FChequeraLista Listado = new FChequeraLista
            {
                TxtFlag = 0.ToString()
            };
            Listado.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //FRptChequera Reporte = new FRptChequera();
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
                Ds = EChequera.Primero();

                TxtCod_chequera.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtCod_chequerav.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtDesc_chequera.Text = Ds.Tables[0].Rows[0]["desc_chequera"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtCantidad.Text = Ds.Tables[0].Rows[0]["cantidad"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
                ConsultarListado();
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
                Ds = EChequera.Anterior(TxtCod_chequera.Text);

                TxtCod_chequera.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtCod_chequerav.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtDesc_chequera.Text = Ds.Tables[0].Rows[0]["desc_chequera"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtCantidad.Text = Ds.Tables[0].Rows[0]["cantidad"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
                ConsultarListado();
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
                Ds = EChequera.Siguiente(TxtCod_chequera.Text);

                TxtCod_chequera.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtCod_chequerav.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtDesc_chequera.Text = Ds.Tables[0].Rows[0]["desc_chequera"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtCantidad.Text = Ds.Tables[0].Rows[0]["cantidad"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
                ConsultarListado();
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
                Ds = EChequera.Ultimo();

                TxtCod_chequera.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtCod_chequerav.Text = Ds.Tables[0].Rows[0]["cod_chequera"].ToString();
                TxtDesc_chequera.Text = Ds.Tables[0].Rows[0]["desc_chequera"].ToString();
                TxtCod_cuenta.Text = Ds.Tables[0].Rows[0]["cod_cuenta"].ToString();
                TxtDesc_cuenta.Text = Ds.Tables[0].Rows[0]["desc_cuenta"].ToString();
                TxtCod_banco.Text = Ds.Tables[0].Rows[0]["cod_banco"].ToString();
                TxtDesc_banco.Text = Ds.Tables[0].Rows[0]["desc_banco"].ToString();
                TxtNumcuenta.Text = Ds.Tables[0].Rows[0]["numcuenta"].ToString();
                TxtResponsable.Text = Ds.Tables[0].Rows[0]["responsable"].ToString();
                TxtCantidad.Text = Ds.Tables[0].Rows[0]["cantidad"].ToString();
                TxtEstatus.Text = Ds.Tables[0].Rows[0]["estatus"].ToString();
                TxtFecha_reg.Text = Ds.Tables[0].Rows[0]["fecha_reg"].ToString();
                TxtCampo1.Text = Ds.Tables[0].Rows[0]["campo1"].ToString();
                TxtCampo2.Text = Ds.Tables[0].Rows[0]["campo2"].ToString();
                TxtCampo3.Text = Ds.Tables[0].Rows[0]["campo3"].ToString();
                TxtCampo4.Text = Ds.Tables[0].Rows[0]["campo4"].ToString();
                TxtCampo5.Text = Ds.Tables[0].Rows[0]["campo5"].ToString();
                TxtCampo6.Text = Ds.Tables[0].Rows[0]["campo6"].ToString();

                TxtEditar.Text = "Listar";
                Registros();
                ConsultarListado();
            }
            catch (Exception Exc)
            {
                string Rpta = Exc.Message;
            }
        }

        #endregion

        #region CONTROL DE CAMBIOS
        private void TxtEstatus_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtCod_chequera_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtDesc_chequera_TextChanged(object sender, EventArgs e)
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

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }

        private void TxtNumcuenta_TextChanged(object sender, EventArgs e)
        {
            CambiosTexBox();
        }
        #endregion

        #region LLAMAR REGISTROS
        internal void SetChequera(string cod_chequera, string desc_chequera, string cod_cuenta, string desc_cuenta, string cod_banco, string desc_banco, string numcuenta, string responsable, string cantidad, string estatus, string fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            TxtCod_chequera.Text = cod_chequera;
            TxtDesc_chequera.Text = desc_chequera;
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtNumcuenta.Text = numcuenta;
            TxtResponsable.Text = responsable;
            TxtCantidad.Text = cantidad;
            TxtEstatus.Text = estatus;
            TxtFecha_reg.Text = fecha_reg;
            TxtCampo1.Text = campo1;
            TxtCampo2.Text = campo2;
            TxtCampo3.Text = campo3;
            TxtCampo4.Text = campo4;
            TxtCampo5.Text = campo5;
            TxtCampo6.Text = campo6;
        }

        internal void SetCuenta(string cod_cuenta, string desc_cuenta, string cod_banco, string desc_banco, string numcuenta, string responsable)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtCod_banco.Text = cod_banco;
            TxtDesc_banco.Text = desc_banco;
            TxtNumcuenta.Text = numcuenta;
            TxtResponsable.Text = responsable;
        }
        private void TxtCod_cuenta_DoubleClick(object sender, EventArgs e)
        {
            FCuentaLista Listado = new FCuentaLista
            {
                TxtFlag = "Chequera"
            };
            Dt = ECuenta.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();

            };
        }

        private void TxtCod_cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FCuentaLista Listado = new FCuentaLista
                {
                    TxtFlag = "Chequera"
                };
                Dt = ECuenta.Mostrar();
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

        private void BtnGenerarCheq_Click(object sender, EventArgs e)
        {
            FChequeraDetalle Listado = new FChequeraDetalle();
            Listado.TxtCod_cuenta.Text = TxtCod_cuenta.Text;
            Listado.TxtDesc_cuenta.Text = TxtDesc_cuenta.Text;
            Listado.TxtCod_banco.Text = TxtCod_banco.Text;
            Listado.TxtDesc_banco.Text = TxtDesc_banco.Text;
            Listado.TxtCod_chequera.Text = TxtCod_chequera.Text;
            Listado.TxtNumcuenta.Text = TxtNumcuenta.Text;
            Listado.TxtDesc_banco.Text = TxtCantidad.Text;
            Dt = EChequeraDetalle.Mostrar(TxtCod_chequera.Text, TxtCod_cuenta.Text, "NULL");

            if (Dt.Rows.Count == 0)
            {
                Listado.TxtEditar.Text = "Nuevo";
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.TxtEditar.Text = "Listar";
            }

            Listado.ShowDialog();
        }
    }
}

