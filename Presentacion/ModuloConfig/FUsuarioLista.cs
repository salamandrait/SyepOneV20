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
    public partial class FUsuarioLista : Form
    {
        public FUsuarioLista()
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
                DataListado.Columns["cod_usuario"].Visible = true;
                DataListado.Columns["desc_usuario"].Visible = true;
                DataListado.Columns["cod_mapa"].Visible = false;
                DataListado.Columns["desc_mapa"].Visible = true;
                DataListado.Columns["clave"].Visible = false;
                DataListado.Columns["estatus"].Visible = true;
                DataListado.Columns["campo1"].Visible = false;
                DataListado.Columns["campo2"].Visible = false;
                DataListado.Columns["campo3"].Visible = false;
                DataListado.Columns["campo4"].Visible = false;
                DataListado.Columns["campo5"].Visible = false;
                DataListado.Columns["campo6"].Visible = false;
                LbInexistente.Visible = false;

                LbTotalReg.Text = Convert.ToString(DataListado.Rows.Count);

            }
            else
            {
                FUsuario mForm = FUsuario.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_usuario"].HeaderText = "Codigo";
            DataListado.Columns["desc_usuario"].HeaderText = "Descripcion";
            DataListado.Columns["desc_mapa"].HeaderText = "Mapa";
            DataListado.Columns["estatus"].HeaderText = "Estatus";

            DataListado.Columns["cod_usuario"].Width = 120;
            DataListado.Columns["desc_usuario"].Width = 200;
            DataListado.Columns["desc_mapa"].Width = 150;
            DataListado.Columns["estatus"].Width = 100;

            DataListado.Columns["cod_usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns["estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void CbBtipo()
        {
            TxtBtipo.Items.Add("Codigo");
            TxtBtipo.Items.Add("Descripcion");
        }

        private void Mostrar()
        {
            try
            {
                DataListado.DataSource = EUsuario.Mostrar();
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
                DataListado.DataSource = EUsuario.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EUsuario.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FUsuarioLista_Load(object sender, EventArgs e)
        {
            Text = "...::: Listado :::...";
            Mostrar();
            CbBtipo();
            TxtBtipo.Text = "Codigo";
            BtnEliminar.Enabled = false;
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
                ((e.RowBounds.Height - size.Height) / 2));
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
                BtnEliminar.Enabled = false;
            }
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

                BtnEliminar.Enabled = true;

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;

                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros Seleccionados ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Codigo = Convert.ToString(row.Cells["cod_usuario"].Value);
                            Rpta = EUsuario.Eliminar(Codigo);
                        }
                    }


                    if (Rpta.Equals("Y"))
                    {
                        MensajeOk("Se Eliminó Correctamente el registro");
                        ChkEliminar.CheckState = CheckState.Unchecked;
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

        private void DataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TxtFlag.Text == 0.ToString())
            {
                FUsuario mForm = FUsuario.GetForm();
                string cod_usuario, desc_usuario, cod_mapa, desc_mapa, clave, estatus, campo1, campo2, campo3, campo4, campo5, campo6;
                cod_usuario = Convert.ToString(DataListado.CurrentRow.Cells["cod_usuario"].Value);
                desc_usuario = Convert.ToString(DataListado.CurrentRow.Cells["desc_usuario"].Value);
                cod_mapa = Convert.ToString(DataListado.CurrentRow.Cells["cod_mapa"].Value);
                desc_mapa = Convert.ToString(DataListado.CurrentRow.Cells["desc_mapa"].Value);
                clave = Convert.ToString(DataListado.CurrentRow.Cells["clave"].Value);
                estatus = Convert.ToString(DataListado.CurrentRow.Cells["estatus"].Value);
                campo1 = Convert.ToString(DataListado.CurrentRow.Cells["campo1"].Value);
                campo2 = Convert.ToString(DataListado.CurrentRow.Cells["campo2"].Value);
                campo3 = Convert.ToString(DataListado.CurrentRow.Cells["campo3"].Value);
                campo4 = Convert.ToString(DataListado.CurrentRow.Cells["campo4"].Value);
                campo5 = Convert.ToString(DataListado.CurrentRow.Cells["campo5"].Value);
                campo6 = Convert.ToString(DataListado.CurrentRow.Cells["campo6"].Value);
                mForm.SetUsuario(cod_usuario, desc_usuario, cod_mapa, desc_mapa, clave, estatus, campo1, campo2, campo3, campo4, campo5, campo6);
                mForm.TxtEditar.Text = "Listar";
            }         
            Close();
        }
    }
}
