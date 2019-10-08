using System;
using Entidades;
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
    public partial class FArtUnidad : Form
    {
        DataTable Dt;
        private static FArtUnidad _Instancia;

        public static FArtUnidad GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FArtUnidad();
            }
            return _Instancia;
        }

        public FArtUnidad()
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

        private void OcultarColumnas()
        {

            DataListado.Columns["Eliminar"].Visible = false;
            DataListado.Columns["cod_articulo"].Visible = false;
            DataListado.Columns["cod_unidad"].Visible = false;
            DataListado.Columns["desc_unidad"].Visible = true;
            DataListado.Columns["esprincipal"].Visible = true;
            DataListado.Columns["equivalencia"].Visible = true;
            DataListado.Columns["fecha_reg"].Visible = true;


            LbInexistente.Visible = false;

            LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);

            DataListado.Columns["equivalencia"].DefaultCellStyle.Format = string.Format("N2");
            DataListado.Columns["fecha_reg"].DefaultCellStyle.Format = string.Format("dd/MM/yyyy");


            DataListado.Columns["cod_unidad"].Width = 100;
            DataListado.Columns["desc_unidad"].Width = 120;
            DataListado.Columns["esprincipal"].Width = 80;
            DataListado.Columns["equivalencia"].Width = 80;
            DataListado.Columns["fecha_reg"].Width = 100;

            DataListado.Columns["cod_unidad"].HeaderText = "Codigo";
            DataListado.Columns["desc_unidad"].HeaderText = "Unidad";
            DataListado.Columns["esprincipal"].HeaderText = "Primaria";
            DataListado.Columns["equivalencia"].HeaderText = "Equiv.";
            DataListado.Columns["fecha_reg"].HeaderText = "Fecha";

            DataListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void Mostrar()
        {
            try
            {
                DataListado.DataSource = EArtUnidad.Mostrar(TxtCod_articulo.Text);
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

        private void Botones()
        {
            if (TxtEditar.Text == "Nuevo")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
                TxtCod_unidad.Enabled = true;
                TxtDesc_unidad.Enabled = true;
                TxtEquivalencia.Enabled = true;
                ChkEsprincipal.Enabled = true;
            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
                TxtCod_unidad.Enabled = true;
                TxtDesc_unidad.Enabled = true;
                TxtEquivalencia.Enabled = true;
                ChkEsprincipal.Enabled = true;
            }
            else if (TxtEditar.Text == "Listar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnEditar.Enabled = true;
                TxtCod_unidad.Enabled = false;
                TxtDesc_unidad.Enabled = false;
                TxtEquivalencia.Enabled = false;
                ChkEsprincipal.Enabled = false;
            }
        }

        private void Limpiar()
        {
            TxtCod_unidad.Text = string.Empty;
            TxtDesc_unidad.Text = string.Empty;
            TxtEquivalencia.Text = string.Empty;
            TxtFecha_reg.Text = string.Empty;
            TxtEsprincipal.Text = false.ToString();
        }

        private void ValidarUnidadPrimaria()
        {
            DataTable Dtt = EArtUnidad.Mostrar(TxtCod_articulo.Text);
            foreach (DataRow Row in Dtt.Rows)
            {
                if (Convert.ToBoolean(Row["esprincipal"]) == true && TxtEditar.Text != "Listar")
                {
                    MensajeError("Ya este Artuculo posee una Unidad Primaria Registrada");
                    ChkEsprincipal.Checked = false;
                    TxtEquivalencia.Value = 0;
                }
            }
        }

        private void EventoTexBox()
        {
            if (ChkEsprincipal.Checked == true)
            {
                TxtEsprincipal.Text = true.ToString();
                TxtEquivalencia.Value = 1;
                ValidarUnidadPrimaria();
            }
            else
            {
                TxtEsprincipal.Text = false.ToString();
            }
        }

        private void EventoChk()
        {
            if (TxtEsprincipal.Text == true.ToString())
            {
                ChkEsprincipal.Checked = true;

            }
            else
            {
                ChkEsprincipal.Checked = false;
            }
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (TxtCod_unidad.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    ErrorTexto.SetError(TxtCod_unidad, "Campo Obligatorio");
                    ErrorTexto.SetError(TxtDesc_unidad, "Campo Obligatorio");
                }
                else
                {
                    if (TxtEditar.Text == "Nuevo")
                    {
                        Rpta = EArtUnidad.Insertar
                            (TxtCod_articulo.Text, TxtCod_unidad.Text, Convert.ToDecimal(TxtEquivalencia.Text), Convert.ToBoolean(TxtEsprincipal.Text), Convert.ToDateTime(TxtFecha_reg.Text));
                    }
                    else if (TxtEditar.Text == "Editar")
                    {
                        Rpta = EArtUnidad.Editar
                            (TxtCod_articulo.Text, TxtCod_articulov.Text,TxtCod_unidad.Text, TxtCod_unidadv.Text, Convert.ToDecimal(TxtEquivalencia.Text), Convert.ToBoolean(TxtEsprincipal.Text), Convert.ToDateTime(TxtFecha_reg.Text));
                    }

                    if (Rpta.Equals("Y"))
                    {
                        if (TxtEditar.Text == "Nuevo")
                        {
                            Mostrar();
                            MensajeOk("El Registro se Insertó Correctamente");
                            TxtEditar.Text = "Listar";
                        }
                        else if (TxtEditar.Text == "Editar")
                        {
                            Mostrar();
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

        private void FArtUnidad_Load(object sender, EventArgs e)
        {
            Text = "...::: Unidades :::...";
            Mostrar();
            EventoChk();
            BtnEliminar.Enabled = false;
        }

        private void FArtUnidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
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
                BtnEliminar.Enabled = false;
            }
        }

        private void DataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCod_unidadv.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_unidad"].Value);
            TxtCod_unidad.Text = Convert.ToString(DataListado.CurrentRow.Cells["cod_unidad"].Value);
            TxtDesc_unidad.Text = Convert.ToString(DataListado.CurrentRow.Cells["desc_unidad"].Value);
            TxtEquivalencia.Text = Convert.ToString(DataListado.CurrentRow.Cells["equivalencia"].Value);
            TxtEsprincipal.Text = Convert.ToString(DataListado.CurrentRow.Cells["esprincipal"].Value);
            TxtFecha_reg.Text = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
            TxtCod_articulov.Text = TxtCod_articulo.Text;
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

        private void ChkEsprincipal_CheckedChanged(object sender, EventArgs e)
        {
            EventoTexBox();
        }

        private void TxtEsprincipal_TextChanged(object sender, EventArgs e)
        {
            EventoChk();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void FArtUnidad_FormClosing(object sender, FormClosingEventArgs e)
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

        #region BOTONES
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
                DialogResult Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros Seleccionados ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string cod_unidad, cod_articulo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            if(row.Cells["esprincipal"].Value.Equals(true))
                            {
                                MensajeError(" La Unidad Principal no Puede ser eliminada!");
                                ChkEliminar.CheckState = CheckState.Unchecked;
                                Mostrar();
                            }
                            else
                            {
                                cod_articulo = Convert.ToString(row.Cells["cod_articulo"].Value);
                                cod_unidad = Convert.ToString(row.Cells["cod_unidad"].Value);
                                Rpta = EArtUnidad.Eliminar(cod_articulo, cod_unidad);
                            }
                        }
                    }

                    if (Rpta.Equals("Y"))
                    {

                        ChkEliminar.CheckState = CheckState.Unchecked;
                        Mostrar();
                        MensajeOk("Se Eliminó Correctamente el registro");
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
        #endregion

        #region LLAMAR REGISTROS
        private void TxtCod_unidad_DoubleClick(object sender, EventArgs e)
        {
            FUnidadLista Listado = new FUnidadLista
            {
                TxtFlag = "ArtUnidad"
            };
            Dt = EUnidad.Mostrar();
            if (Dt.Rows.Count == 0)
            {
                MensajeError("No Existen Registros Disponibles!");
            }
            else if (Dt.Rows.Count != 0)
            {
                Listado.ShowDialog();
            }
        }

        private void TxtCod_unidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FUnidadLista Listado = new FUnidadLista
                {
                    TxtFlag = "ArtUnidad"
                };
                Dt = EUnidad.Mostrar();
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

        public void SetUnidad(string cod_unidad, string desc_unidad)
        {
            TxtCod_unidad.Text = cod_unidad;
            TxtDesc_unidad.Text = desc_unidad;

            foreach (DataGridViewRow row in DataListado.Rows)
            {
                if (Convert.ToString(row.Cells["cod_unidad"].Value) == Convert.ToString(TxtCod_unidad.Text))
                {
                    MensajeError("La Unidad **" + TxtDesc_unidad.Text + "** ya se encuentra Registrada, No es Posible Ingresar Unidades Duplicadas");
                    Limpiar();
                    TxtCod_unidad.Text = string.Empty;
                    TxtDesc_unidad.Text = string.Empty;
                }
            }
        }
        #endregion

    }
}
