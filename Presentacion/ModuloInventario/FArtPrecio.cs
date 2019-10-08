using Entidades;
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

namespace Presentacion.ModuloInventario
{
    public partial class FArtPrecio : Form
    {
        DataTable Dt = new DataTable();
        private static FArtPrecio _Instancia;

        public static FArtPrecio GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FArtPrecio();
            }
            return _Instancia;
        }

        public FArtPrecio()
        {
            InitializeComponent();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            TxtCod_precio.Text = string.Empty;
            TxtDesc_precio.Text = string.Empty;
            TxtCod_deposito.Text = string.Empty;
            TxtDesc_deposito.Text = string.Empty;
            TxtMonto.Text = string.Empty;
            TxtFecha_reg.Text = string.Empty;
            TxtFecha_venc.Text = string.Empty;
            TxtVenc_precio.Text = false.ToString();
        }

        private void Botones()
        {
            if (TxtEditar.Text == "Nuevo")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;
                BtnEditar.Enabled = false;
                TxtCod_precio.Enabled = true;
                TxtDesc_precio.Enabled = true;
                TxtCod_deposito.Enabled = true;
                TxtDesc_deposito.Enabled = true;
                TxtMonto.Enabled = true;
                TxtFecha_reg.Enabled = true;
                TxtFecha_venc.Enabled = true;
                TxtVenc_precio.Enabled = true;
                ChkVenc_precio.Enabled = true;

            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnImprimir.Enabled = false;
                BtnEditar.Enabled = false;
                TxtCod_precio.Enabled = true;
                TxtDesc_precio.Enabled = true;
                TxtCod_deposito.Enabled = true;
                TxtDesc_deposito.Enabled = true;
                TxtMonto.Enabled = true;
                TxtFecha_reg.Enabled = true;
                TxtFecha_venc.Enabled = true;
                TxtVenc_precio.Enabled = true;
                ChkVenc_precio.Enabled = true;
            }
            else if (TxtEditar.Text == "Listar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnImprimir.Enabled = true;
                BtnEditar.Enabled = true;
                TxtCod_precio.Enabled = false;
                TxtDesc_precio.Enabled = false;
                TxtCod_deposito.Enabled = false;
                TxtDesc_deposito.Enabled = false;
                TxtMonto.Enabled = false;
                TxtFecha_reg.Enabled = false;
                TxtFecha_venc.Enabled = false;
                TxtVenc_precio.Enabled = false;
                ChkVenc_precio.Enabled = false;
            }
        }

        private void OcultarColumnas()
        {
            DataListado.Columns["Eliminar"].Visible = false;
            DataListado.Columns["cod_articulo"].Visible = false; 
            DataListado.Columns["cod_deposito"].Visible = false;
            DataListado.Columns["desc_deposito"].Visible = true;
            DataListado.Columns["cod_precio"].Visible = false;
            DataListado.Columns["desc_precio"].Visible = true;
            DataListado.Columns["monto"].Visible = true;
            DataListado.Columns["fecha_reg"].Visible = true;
            DataListado.Columns["fecha_venc"].Visible = true;
            DataListado.Columns["venc_precio"].Visible = true;

            LbInexistente.Visible = false;

            LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);

            DataListado.Columns["desc_deposito"].HeaderText = "Deposito";
            DataListado.Columns["desc_precio"].HeaderText = "Precio";
            DataListado.Columns["monto"].HeaderText = "Monto";
            DataListado.Columns["fecha_reg"].HeaderText = "Desde";
            DataListado.Columns["fecha_venc"].HeaderText = "Hasta";
            DataListado.Columns["venc_precio"].HeaderText = "Vence";

            DataListado.Columns["monto"].DefaultCellStyle.Format = string.Format("N2");
            DataListado.Columns["fecha_venc"].DefaultCellStyle.Format = string.Format("dd/MM/yyyy");
            DataListado.Columns["fecha_reg"].DefaultCellStyle.Format = string.Format("dd/MM/yyyy");

            DataListado.Columns["desc_deposito"].Width = 150;
            DataListado.Columns["desc_precio"].Width = 150;
            DataListado.Columns["fecha_reg"].Width = 100;
            DataListado.Columns["fecha_venc"].Width = 100;
            DataListado.Columns["venc_precio"].Width = 80;
            DataListado.Columns["monto"].Width = 150;

            DataListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataListado.Columns["desc_deposito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataListado.Columns["desc_precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        internal void Mostrar()
        {
            try
            {
                DataListado.DataSource = EArtPrecio.Mostrar(TxtCod_articulo.Text);
                OcultarColumnas();
                TxtEditar.Text = "Listar";


                if (DataListado.Rows.Count == 0)
                {
                    Show();
                    TxtEditar.Text = "Nuevo";
                    Limpiar();
                    Botones();
                    MensajeOk("Tabla Vacia, Esta en Modo Ingreso");
                    LbInexistente.Visible = true;
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void EventoChk()
        {
            if (ChkVenc_precio.Checked == true)
            {
                TxtVenc_precio.Text = true.ToString();
            }
            else
            {
                TxtVenc_precio.Text = false.ToString();
            }
        }

        private void EventoTexBox()
        {
            if (TxtVenc_precio.Text == true.ToString())
            {
                ChkVenc_precio.Checked = true;
            }
            else
            {
                ChkVenc_precio.Checked = false;
            }
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_precio.Text == string.Empty || TxtCod_deposito.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_precio, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtCod_deposito, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EArtPrecio.Insertar
                            (TxtCod_articulo.Text, TxtCod_precio.Text, TxtCod_deposito.Text,Convert.ToDecimal(TxtMonto.Text),Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecha_venc.Text), Convert.ToBoolean(TxtVenc_precio.Text));
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EArtPrecio.Editar
                           (TxtCod_articulo.Text, TxtCod_articulov.Text, TxtCod_precio.Text, TxtCod_preciov.Text, TxtCod_deposito.Text, TxtCod_depositov.Text, Convert.ToDecimal(TxtMonto.Text), Convert.ToDateTime(TxtFecha_reg.Text), Convert.ToDateTime(TxtFecha_venc.Text), Convert.ToBoolean(TxtVenc_precio.Text));
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                            Mostrar();
                        }
                        else if (TxtEditar.Text == "Editar")
                        {
                            MensajeOk("El Registro se Editó Correctamente");
                            TxtEditar.Text = "Listar";
                            Mostrar();
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

        private void FArtPrecio_Load(object sender, EventArgs e)
        {
            Text = "...::: Precios :::...";
            Mostrar();
            EventoChk();
            BtnEliminar.Enabled = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            Botones();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar();
            Botones();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Nuevo";
            Limpiar();
            Botones();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Editar";
            Botones();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;

                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros Seleccionados ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Rpta = EArtPrecio.Eliminar(
                                Convert.ToString(row.Cells["cod_articulo"].Value),
                                Convert.ToString(row.Cells["cod_precio"].Value),
                                Convert.ToString(row.Cells["cod_deposito"].Value)
                                );
                        }
                    }

                    if (Rpta.Equals("Y"))
                    {
                        ChkEliminar.CheckState = CheckState.Unchecked;
                        MensajeOk("Se Eliminó Correctamente el registro");
                        Mostrar();
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
                else
                {
                    MensajeError("Cancelando la Eliminacon de Registros!");
                    ChkEliminar.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ChkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEliminar.Checked)
            {
                DataListado.Columns["Eliminar"].Visible = true;
                DataListado.Columns["Eliminar"].Width = 80;
            }
            else
            {
                DataListado.Columns["Eliminar"].Visible = false;
                DataListado.Columns["Eliminar"].Width = 80;
            }
        }

        private void DataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCod_articulo.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_articulo"].Value);
            TxtCod_deposito.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_deposito"].Value);
            TxtDesc_deposito.Text = Convert.ToString(DataListado.CurrentRow.Cells["desc_deposito"].Value);

            TxtCod_articulov.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_articulo"].Value);
            TxtCod_depositov.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_deposito"].Value);
            TxtCod_preciov.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_precio"].Value);

            TxtCod_precio.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_precio"].Value);
            TxtDesc_precio.Text = Convert.ToString(DataListado.CurrentRow.Cells["desc_precio"].Value);
            TxtMonto.Text = Convert.ToString(DataListado.CurrentRow.Cells["monto"].Value);
            TxtFecha_reg.Text = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
            TxtFecha_venc.Text = Convert.ToString(DataListado.CurrentRow.Cells["fecha_venc"].Value);
            TxtVenc_precio.Text = Convert.ToString(DataListado.CurrentRow.Cells["venc_precio"].Value);
            TxtEditar.Text = "Listar";
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

                BtnEliminar.Enabled = Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void TxtVenc_precio_TextChanged(object sender, EventArgs e)
        {
            EventoTexBox();
            if (ChkVenc_precio.Checked == true)
            {
                if (Convert.ToDateTime(TxtFecha_venc.Text) <= Convert.ToDateTime(TxtFecha_reg.Text))
                {
                    MensajeError("La Fecha de Vencimiento debe ser Mayor a la Fecha de Registro");
                    ChkVenc_precio.Checked = false;
                }
            }
        }

        private void ChkVenc_precio_CheckedChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        internal void SetDeposito(string cod_deposito, string desc_deposito)
        {
            TxtCod_deposito.Text = cod_deposito;
            TxtDesc_deposito.Text = desc_deposito;
        }

        internal void SetPrecio(string cod_precio, string desc_precio)
        {
            TxtCod_precio.Text = cod_precio;
            TxtDesc_precio.Text = desc_precio;
        }

        private void TxtCod_deposito_DoubleClick(object sender, EventArgs e)
        {
            FDepositoLista Listado = new FDepositoLista
            {
                TxtFlag = "ArtPrecio"
            };
            Dt = EDeposito.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            }
        }

        private void TxtCod_deposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FDepositoLista Listado = new FDepositoLista
                {
                    TxtFlag = "ArtPrecio"
                };
                Dt = EDeposito.Mostrar();
                if (Dt.Rows.Count == 0)
                {
                    MensajeError("No Existen Registros Disponibles!");
                }
                else if (Dt.Rows.Count != 0)
                {
                    Listado.ShowDialog();
                }
            }
        }

        private void TxtCod_precio_DoubleClick(object sender, EventArgs e)
        {
            FPrecioLista Listado = new FPrecioLista
            {
                TxtFlag = "ArtPrecio"
            };
            Dt = EPrecio.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            }
        }

        private void TxtCod_precio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FPrecioLista Listado = new FPrecioLista
                {
                    TxtFlag = "ArtPrecio"
                };
                Dt = EPrecio.Mostrar();
                if (Dt.Rows.Count == 0)
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
