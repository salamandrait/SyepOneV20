using Entidades;
using Presentacion.ModuloCompra;
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
    public partial class FCuentaLista : Form
    {
        public String TxtFlag;

        public FCuentaLista()
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
            if (DataListado.Rows.Count != 0)
            {
                DataListado.Columns["Eliminar"].Visible = false;
                DataListado.Columns["cod_cuenta"].Visible = true;
                DataListado.Columns["desc_cuenta"].Visible = true;
                DataListado.Columns["cod_banco"].Visible = false;
                DataListado.Columns["desc_banco"].Visible = true;
                DataListado.Columns["cod_moneda"].Visible = true;
                DataListado.Columns["desc_moneda"].Visible = false;
                DataListado.Columns["tipocuenta"].Visible = true;
                DataListado.Columns["numcuenta"].Visible = true;
                DataListado.Columns["responsable"].Visible = false;
                DataListado.Columns["agencia"].Visible = false;
                DataListado.Columns["ejecutivo"].Visible = false;
                DataListado.Columns["direccion"].Visible = false;
                DataListado.Columns["telefono"].Visible = false;
                DataListado.Columns["email"].Visible = false;
                DataListado.Columns["saldod"].Visible = false;
                DataListado.Columns["saldoh"].Visible = false;
                DataListado.Columns["saldo"].Visible = false;
                DataListado.Columns["fecha_reg"].Visible = false;
                DataListado.Columns["fecharegcheq"].Visible = false;
                DataListado.Columns["activa"].Visible = false;
                DataListado.Columns["chequera"].Visible = false;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                DataListado.Columns["cod_cuenta"].HeaderText = "Codigo";
                DataListado.Columns["desc_cuenta"].HeaderText = "Descripcion";
                DataListado.Columns["desc_banco"].HeaderText = "Banco";
                DataListado.Columns["cod_moneda"].HeaderText = "Moneda";
                DataListado.Columns["tipocuenta"].HeaderText = "Tipo";
                DataListado.Columns["numcuenta"].HeaderText = "Nro de Cuenta";

                DataListado.Columns["cod_cuenta"].Width = 80;
                DataListado.Columns["desc_cuenta"].Width = 200;
                DataListado.Columns["desc_banco"].Width = 200;
                DataListado.Columns["cod_moneda"].Width = 80;
                DataListado.Columns["tipocuenta"].Width = 100;
                DataListado.Columns["numcuenta"].Width = 200;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);
            }
            else
            {
                FCuenta mForm = FCuenta.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["tipocuenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["numcuenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["desc_moneda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CbBtipo()
        {
            TxtBtipo.Items.AddRange(new object[] { "Codigo", "Descripcion", "Banco", "Nro de Cuenta" });
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = ECuenta.Mostrar();
                OcultarColumnas();
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void Buscar()
        {
            if (TxtBtipo.Text == "Codigo")
            {
                DataListado.DataSource = ECuenta.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = ECuenta.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FCuentaListar_Load(object sender, EventArgs e)
        {
            Text = "...::: Listado :::...";
            Mostrar();
            CbBtipo();
            TxtBtipo.Text = "Codigo";
        }

        private void DataListado_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();

            SizeF size = e.Graphics.MeasureString(strRowNumber, Font);

            if (DataListado.RowHeadersWidth < Convert.ToInt32((size.Width + 10)))
            {
                DataListado.RowHeadersWidth = Convert.ToInt32((size.Width + 10));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString
                (strRowNumber, Font, b, e.RowBounds.Location.X
                + 10, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 5));
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

        private void DataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TxtFlag == 0.ToString())
            {
                FCuenta mForm = FCuenta.GetForm();
                String cod_cuenta, desc_cuenta, cod_banco, desc_banco, cod_moneda, desc_moneda, tipocuenta, numcuenta, responsable, agencia, ejecutivo, direccion, telefono, email, saldod, saldoh, saldo, fechareg, fecharegcheq, activa, chequera, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuenta"].Value);
                desc_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuenta"].Value);
                cod_banco = Convert.ToString(DataListado.CurrentRow.Cells["cod_banco"].Value);
                desc_banco = Convert.ToString(DataListado.CurrentRow.Cells["desc_banco"].Value);
                cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                tipocuenta = Convert.ToString(DataListado.CurrentRow.Cells["tipocuenta"].Value);
                numcuenta = Convert.ToString(DataListado.CurrentRow.Cells["numcuenta"].Value);
                responsable = Convert.ToString(DataListado.CurrentRow.Cells["responsable"].Value);
                agencia = Convert.ToString(DataListado.CurrentRow.Cells["agencia"].Value);
                ejecutivo = Convert.ToString(DataListado.CurrentRow.Cells["ejecutivo"].Value);
                direccion = Convert.ToString(DataListado.CurrentRow.Cells["direccion"].Value);
                telefono = Convert.ToString(DataListado.CurrentRow.Cells["telefono"].Value);
                email = Convert.ToString(DataListado.CurrentRow.Cells["email"].Value);
                saldod = Convert.ToString(DataListado.CurrentRow.Cells["saldod"].Value);
                saldoh = Convert.ToString(DataListado.CurrentRow.Cells["saldoh"].Value);
                saldo = Convert.ToString(DataListado.CurrentRow.Cells["saldo"].Value);
                fechareg = Convert.ToString(DataListado.CurrentRow.Cells["fecha_reg"].Value);
                fecharegcheq = Convert.ToString(DataListado.CurrentRow.Cells["fecharegcheq"].Value);
                activa = Convert.ToString(DataListado.CurrentRow.Cells["activa"].Value);
                chequera = Convert.ToString(DataListado.CurrentRow.Cells["chequera"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetCuenta(cod_cuenta, desc_cuenta, cod_banco, desc_banco, cod_moneda, desc_moneda, tipocuenta, numcuenta, responsable, agencia, ejecutivo, direccion, telefono, email, saldod, saldoh, saldo, fechareg, fecharegcheq, activa, chequera, campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
                Close();
            }
            else if (TxtFlag == "MovBanco")
            {
                if (Convert.ToBoolean(DataListado.CurrentRow.Cells["activa"].Value).Equals(true))
                {
                    FMovBanco mForm = FMovBanco.GetForm();
                    String cod_cuenta, desc_cuenta, cod_banco, desc_banco, cod_moneda, desc_moneda, numcuenta;
                    cod_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuenta"].Value);
                    desc_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuenta"].Value);
                    cod_banco = Convert.ToString(DataListado.CurrentRow.Cells["cod_banco"].Value);
                    desc_banco = Convert.ToString(DataListado.CurrentRow.Cells["desc_banco"].Value);
                    cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                    desc_moneda = Convert.ToString(DataListado.CurrentRow.Cells["desc_moneda"].Value);
                    numcuenta = Convert.ToString(DataListado.CurrentRow.Cells["numcuenta"].Value);
                    mForm.SetCuenta(cod_cuenta, desc_cuenta, cod_banco, desc_banco, cod_moneda, desc_moneda, numcuenta);
                    Close();
                }
                else
                {
                    MensajeError("La Cuenta Seleccionada no se Encuentra Activa! ");
                }
            }
            else if (TxtFlag == "Chequera")
            {
                if (Convert.ToBoolean(DataListado.CurrentRow.Cells["activa"].Value).Equals(true))
                {
                    FChequera mForm = FChequera.GetForm();
                    String cod_cuenta, desc_cuenta, cod_banco, desc_banco, numcuenta, responsable;
                    cod_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuenta"].Value);
                    desc_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuenta"].Value);
                    cod_banco = Convert.ToString(DataListado.CurrentRow.Cells["cod_banco"].Value);
                    desc_banco = Convert.ToString(DataListado.CurrentRow.Cells["desc_banco"].Value);
                    numcuenta = Convert.ToString(DataListado.CurrentRow.Cells["numcuenta"].Value);
                    responsable = Convert.ToString(DataListado.CurrentRow.Cells["responsable"].Value);
                    mForm.SetCuenta(cod_cuenta, desc_cuenta, cod_banco, desc_banco, numcuenta, responsable);
                    Close();
                }
                else
                {
                    MensajeError("La Cuenta Seleccionada no se Encuentra Activa! ");
                }
            }
            else if (TxtFlag == "Pago")
            {
                if (Convert.ToBoolean(DataListado.CurrentRow.Cells["activa"].Value).Equals(true))
                {
                    FPago mForm = FPago.GetForm();
                    String cod_cuenta, desc_cuenta, cod_moneda, saldo;
                    cod_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["cod_cuenta"].Value);
                    desc_cuenta = Convert.ToString(DataListado.CurrentRow.Cells["desc_cuenta"].Value);
                    cod_moneda = Convert.ToString(DataListado.CurrentRow.Cells["cod_moneda"].Value);
                    saldo = Convert.ToString(DataListado.CurrentRow.Cells["saldo"].Value);
                    mForm.SetCuenta(cod_cuenta, desc_cuenta, cod_moneda, saldo);
                    Close();
                }
                else
                {
                    MensajeError("La Cuenta Seleccionada no se Encuentra Activa! ");
                }
            }

        }

        private void TxtBtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros Seleccionados ?", "...::: Step One Ver 5.1:::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Rpta = ECuenta.Eliminar(Convert.ToString(row.Cells["cod_cuenta"].Value));
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
                        ChkEliminar.CheckState = CheckState.Unchecked;
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
            //FRptCuenta Reporte = new FRptCuenta();
            //Reporte.ShowDialog();
        }

    }
}
