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

namespace Presentacion.ModuloInventario
{
    public partial class FStockInventarioLista : Form
    {
        private static FStockInventarioLista _Instancia;

        public static FStockInventarioLista GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FStockInventarioLista();
            }
            return _Instancia;
        }

        public FStockInventarioLista()
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

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion", "Stock ACTUAL", "Stock PEDIDO", "Stock COMPROMETIDO" });
        }

        private void OcultarColumnas()
        {

            DataListado.Columns["cod_deposito"].Visible = false;
            DataListado.Columns["desc_deposito"].Visible = true;
            DataListado.Columns["cod_articulo"].Visible = true;
            DataListado.Columns["desc_articulo"].Visible = true;
            DataListado.Columns["cod_unidad"].Visible = false;
            DataListado.Columns["desc_unidad"].Visible = true;
            DataListado.Columns["cantidad"].Visible = true;
            DataListado.Columns["tipostock"].Visible = true;


            DataListado.Columns["cod_articulo"].Width = 120;
            DataListado.Columns["desc_articulo"].Width = 350;
            DataListado.Columns["cod_deposito"].Width = 100;
            DataListado.Columns["desc_deposito"].Width = 150;
            DataListado.Columns["desc_unidad"].Width = 100;
            DataListado.Columns["cantidad"].Width = 100;
            DataListado.Columns["tipostock"].Width = 80;


            DataListado.Columns["desc_deposito"].HeaderText = "Deposito";
            DataListado.Columns["cod_articulo"].HeaderText = "Codigo";
            DataListado.Columns["desc_articulo"].HeaderText = "Descripcion";
            DataListado.Columns["desc_unidad"].HeaderText = "Unidad";
            DataListado.Columns["cantidad"].HeaderText = "Cantidad";
            DataListado.Columns["tipostock"].HeaderText = "Tipo";

            DataListado.Columns["cantidad"].DefaultCellStyle.Format = Convert.ToString("N0");

            DataListado.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataListado.Columns["tipostock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["desc_unidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EStockInventario.Mostrar();
                OcultarColumnas();

                if (DataListado.Rows.Count == 0)
                {
                    LbInexistente.Visible = true;
                }

            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void MostraUsuario()
        {
            FLogin mFLogin = FLogin.GetForm();
            TxtCod_usuario.Text = mFLogin.TxtCod_usuario.Text;
            DataSet Ds = EUsuario.SelecUsuario(TxtCod_usuario.Text);
            TxtCod_usuario.Text = Ds.Tables[0].Rows[0]["cod_usuario"].ToString();
            TxtDesc_usuario.Text = Ds.Tables[0].Rows[0]["desc_usuario"].ToString();
        }

        private void FStockInventarioLista_Load(object sender, EventArgs e)
        {
            TxtBtipo.Text = "Codigo";
            Mostrar();
            MostraUsuario();
            CbBtipo();
        }

        private void FStockInventarioLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
