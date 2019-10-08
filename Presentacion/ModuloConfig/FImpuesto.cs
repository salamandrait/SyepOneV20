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

namespace Presentacion.ModuloConfig
{
    public partial class FImpuesto : Form
    {

        private static FImpuesto _Instancia;

        public static FImpuesto GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FImpuesto();
            }
            return _Instancia;
        }

        public FImpuesto()
        {
            InitializeComponent();
        }

        public void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (TxtEditar.Text == "Editar")
            {
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnImprimir.Enabled = false;
            }
            else if (TxtEditar.Text == "Listar")
            {
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnImprimir.Enabled = true;
            }
        }

        private void OcultarColumnas()
        {
            DataListado.Columns["cod_impuesto"].Visible = true;
            DataListado.Columns["desc_impuesto"].Visible = true;
            DataListado.Columns["compras"].Visible = true;
            DataListado.Columns["ventas"].Visible = true;
            DataListado.Columns["tasaimp"].Visible = true;
            DataListado.Columns["fecha_reg"].Visible = false;
            DataListado.Columns["campo1"].Visible = false;
            DataListado.Columns["campo2"].Visible = false;
            DataListado.Columns["campo3"].Visible = false;
            DataListado.Columns["campo4"].Visible = false;
            DataListado.Columns["campo5"].Visible = false;
            DataListado.Columns["campo6"].Visible = false;
            DataListado.Columns["Op"].Visible = false;

            DataListado.Columns["cod_impuesto"].HeaderText = "Reng";
            DataListado.Columns["desc_impuesto"].HeaderText = "Descripcion";
            DataListado.Columns["compras"].HeaderText = "Compras";
            DataListado.Columns["ventas"].HeaderText = "Ventas";
            DataListado.Columns["tasaimp"].HeaderText = "Tasa %";

            DataListado.Columns["cod_impuesto"].Width = 80;
            DataListado.Columns["desc_impuesto"].Width = 150;
            DataListado.Columns["compras"].Width = 80;
            DataListado.Columns["ventas"].Width = 80;
            DataListado.Columns["tasaimp"].Width = 100;
            DataListado.Columns["fecha_reg"].Width = 150;


            DataListado.Columns["cod_impuesto"].ReadOnly=true;
            DataListado.Columns["desc_impuesto"].ReadOnly = true;

            DataListado.Columns["tasaimp"].DefaultCellStyle.Format = string.Format("N0");
            DataListado.Columns["fecha_reg"].DefaultCellStyle.Format = string.Format("dd/MM/yyyy");

            DataListado.Columns["tasaimp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["cod_impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            TxtFecha_reg.Value = Convert.ToDateTime(DataListado.Rows[0].Cells["fecha_reg"].Value);

            LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EImpuesto.Mostrar();           
                OcultarColumnas();
                TxtEditar.Text = "Listar";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FImpuesto_Load(object sender, EventArgs e)
        {
            Mostrar();
            MostraUsuario();
        }

        private void TxtEditar_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataListado.Rows)
            {
                if (TxtEditar.Text == "Editar")
                {

                    row.Cells["Op"].Value = true.ToString();
                }
                else if (TxtEditar.Text == "Listar")
                {

                    row.Cells["Op"].Value = false.ToString();
                }
            }
            Botones();
        }

        private void Guardar()
        {
            try
            {
                if (TxtEditar.Text == "Editar")
                {
                    string _cod_impuesto;
                    bool _compras;
                    bool _ventas;
                    decimal _tasaimp;
                    DateTime _fecha_reg;
                    string _campo1;
                    string _campo2;
                    string _campo3;
                    string _campo4;
                    string _campo5;
                    string _campo6;

                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Op"].Value))
                        {
                            _cod_impuesto = Convert.ToString(row.Cells["cod_impuesto"].Value);
                            _compras = Convert.ToBoolean(row.Cells["compras"].Value);
                            _ventas = Convert.ToBoolean(row.Cells["ventas"].Value);
                            _tasaimp = Convert.ToDecimal(row.Cells["tasaimp"].Value);
                            _fecha_reg = Convert.ToDateTime(row.Cells["fecha_reg"].Value);
                            _campo1 = Convert.ToString(row.Cells["campo1"].Value);
                            _campo2 = Convert.ToString(row.Cells["campo2"].Value);
                            _campo3 = Convert.ToString(row.Cells["campo3"].Value);
                            _campo4 = Convert.ToString(row.Cells["campo4"].Value);
                            _campo5 = Convert.ToString(row.Cells["campo5"].Value);
                            _campo6 = Convert.ToString(row.Cells["campo6"].Value);

                            Rpta = EImpuesto.Editar(_cod_impuesto, _compras, _ventas, _tasaimp, TxtFecha_reg.Value, _campo1, _campo2, _campo3, _campo4, _campo5, _campo6);
                        }
                    }

                    if (Rpta.Equals("Y"))
                    {
                        MensajeOk("Se Edito Correctamente el registro");
                        TxtEditar.Text = "Listar";
                        Mostrar();
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            Botones();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtEditar.Text = "Listar";
            Botones();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }


        private void DataListado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TxtEditar.Text = "Editar";

            if (e.ColumnIndex == DataListado.Columns["Op"].Index)
            {
                DataGridViewCheckBoxCell ChkCargar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Op"];
                ChkCargar.Value = !Convert.ToBoolean(ChkCargar.Value);
            }
        }

        private void DataListado_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            TxtEditar.Text = "Editar";

            if (e.ColumnIndex == DataListado.Columns["Op"].Index)
            {
                DataGridViewCheckBoxCell ChkCargar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Op"];
                ChkCargar.Value = !Convert.ToBoolean(ChkCargar.Value);
            }
        }

        private void FImpuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FImpuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    if (TxtEditar.Text == "Editar")
            //    {
            //        DialogResult Resp = MessageBox.Show("Desea Guardar los Cambios antes de Salir?", "...::: Step One Ver 1.0 :::...",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //        if (Resp == DialogResult.Yes)
            //        {
            //            Guardar();
            //            Botones();
            //        }
            //    }
            //}
            //catch (Exception Exec)
            //{

            //    MensajeError(Exec.Message + Exec.StackTrace);
            //}
        }

        private void TxtFecha_reg_ValueChanged(object sender, EventArgs e)
        {
            TxtEditar.Text = "Editar";
            Botones();
        }
    }
}
