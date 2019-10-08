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
using Presentacion.ModuloCompra;
using Presentacion.ModuloVenta;

namespace Presentacion.ModuloInventario
{
    public partial class FArtUnidadLista : Form
    {
        private static FArtUnidadLista _Instancia;
        public string Flag = "";

        public static FArtUnidadLista GetArtUnidadLista()
        {
            if (_Instancia == null)
            {
                _Instancia = new FArtUnidadLista();
            }
            return _Instancia;
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 1.1:::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ColumnasArt()
        {
                DataListadoArt.Columns["Cod_articulo"].HeaderText = "Codigo";
                DataListadoArt.Columns["desc_articulo"].HeaderText = "Descripcion";
                DataListadoArt.Columns["Cod_articulo"].Width = 120;
                DataListadoArt.Columns["desc_articulo"].Width = 300;
        }

        private void ColumnasUnd()
        {
            DataListadoUnd.Columns["cod_articulo"].Visible = false;
            DataListadoUnd.Columns["Cod_unidad"].Visible = true;
            DataListadoUnd.Columns["desc_unidad"].Visible = true;
            DataListadoUnd.Columns["equivalencia"].Visible = false;
            DataListadoUnd.Columns["esprincipal"].Visible = false;
            DataListadoUnd.Columns["fecha_reg"].Visible = false;

            DataListadoUnd.Columns["Cod_unidad"].HeaderText = "Codigo";
            DataListadoUnd.Columns["desc_unidad"].HeaderText = "Unidad";

            DataListadoUnd.Columns["Cod_unidad"].Width = 80;
           DataListadoUnd.Columns["desc_unidad"].Width = 150;
        }

        private void ColumnasDep()
        {
            DataListadoUnd.Columns["Cod_deposito"].Visible = true;
            DataListadoUnd.Columns["desc_deposito"].Visible = true;
            DataListadoUnd.Columns["ubicacion_deposito"].Visible = false;
            DataListadoUnd.Columns["resp_deposito"].Visible = false;
            DataListadoUnd.Columns["fecha_reg"].Visible = false;
            DataListadoUnd.Columns["direccion_adm"].Visible = false;
            DataListadoUnd.Columns["scompras"].Visible = false;
            DataListadoUnd.Columns["sventas"].Visible = false;
            DataListadoUnd.Columns["activo"].Visible = false;
            DataListadoUnd.Columns["campo1"].Visible = false;
            DataListadoUnd.Columns["campo2"].Visible = false;
            DataListadoUnd.Columns["campo3"].Visible = false;
            DataListadoUnd.Columns["campo4"].Visible = false;
            DataListadoUnd.Columns["campo5"].Visible = false;
            DataListadoUnd.Columns["campo6"].Visible = false;

            if (DataListadoUnd.Rows.Count != 0)
            {
                DataListadoUnd.Columns["Cod_deposito"].HeaderText = "Codigo";
                DataListadoUnd.Columns["desc_deposito"].HeaderText = "Unidad";

                DataListadoUnd.Columns["Cod_deposito"].Width = 80;
                DataListadoUnd.Columns["desc_deposito"].Width = 150;
            }
        }

        public FArtUnidadLista()
        {
            InitializeComponent();
        }

        public void MostrarArt()
        {
            DataListadoArt.DataSource = EArtUnidad.Listar();
            ColumnasArt();
        }

        public void MostrarUnd()
        {
            if (Flag == "Comp" || Flag == "Inv")
            {
                DataListadoUnd.DataSource = EArtUnidad.Mostrar(TxtCod_articulo.Text);
                ColumnasUnd();
            }
            if (Flag == "Venta")
            {
                DataListadoUnd.DataSource = EDeposito.Mostrar();
                ColumnasDep();
            }
        }

        private void MetodoValidad()
        {
            if (TxtCod_unidad.Text == string.Empty || TxtDesc_unidad.Text == string.Empty)
            {
                BtnAceptar.Enabled = false;
            }
            else
            {
                BtnAceptar.Enabled = true;
            }
        }

        private void FArtUnidadLista_Load(object sender, EventArgs e)
        {
            MostrarArt();
        }

        private void DataListadoArt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCod_unidad.Text = string.Empty;
            TxtDesc_unidad.Text = string.Empty;

            TxtCod_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["cod_articulo"].Value);
            TxtDesc_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["desc_articulo"].Value);
            MostrarUnd();
            MetodoValidad();
        }

        private void DataListadoUnd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Flag == "Comp" || Flag == "Inv")
            {
                TxtCod_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["cod_unidad"].Value);
                TxtDesc_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["desc_unidad"].Value);
            }
            if (Flag == "Venta")
            {
                if (Convert.ToBoolean(DataListadoUnd.CurrentRow.Cells["sventas"].Value) == true)
                {
                    MensajeError("Deposito Seleccionado no esta Habilitado para Operaciones de Ventas");
                }
                else
                {
                    TxtCod_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["cod_deposito"].Value);
                    TxtDesc_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["desc_deposito"].Value);
                }

            }
            MetodoValidad();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Flag == "Comp")
            {
                FArtCargarC Listado = FArtCargarC.GetArtCargarC();
                Listado.TxtCod_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["cod_articulo"].Value);
                Listado.TxtDesc_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["desc_articulo"].Value);
                Listado.TxtCod_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["cod_unidad"].Value);
                Listado.TxtDesc_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["desc_unidad"].Value);
                Listado.TxtContador.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["equivalencia"].Value);
                Close();
            }
            else if (Flag == "Inv")
            {
                //FArtCargar Listado = FArtCargar.GetFArtCargar();
                //Listado.TxtCod_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["cod_articulo"].Value);
                //Listado.TxtDesc_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["desc_articulo"].Value);
                //Listado.TxtCod_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["cod_unidad"].Value);
                //Listado.TxtDesc_unidad.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["desc_unidad"].Value);
                //Close();
            }
            else if (Flag == "Venta")
            {
                //FArtCargarV Listado = FArtCargarV.GetArtCargarV();
                //Listado.TxtCod_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["cod_articulo"].Value);
                //Listado.TxtDesc_articulo.Text = Convert.ToString(DataListadoArt.CurrentRow.Cells["desc_articulo"].Value);
                //Listado.TxtCod_deposito.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["cod_deposito"].Value);
                //Listado.TxtDesc_deposito.Text = Convert.ToString(DataListadoUnd.CurrentRow.Cells["desc_deposito"].Value);
                //Listado.ListarArtUnidad();
                //Close();
                //Listado.TxtDesc_unidad.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FArtUnidadLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
