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
    public partial class FMapaLista : Form
    {
        public FMapaLista()
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
                DataListado.Columns["cod_mapa"].Visible = true;
                DataListado.Columns["desc_mapa"].Visible = true;
                DataListado.Columns["ainventario"].Visible = false;
                DataListado.Columns["acompras"].Visible = false;
                DataListado.Columns["aventas"].Visible = false;
                DataListado.Columns["abanco"].Visible = false;
                DataListado.Columns["aconfig"].Visible = false;

                DataListado.Columns["tsioperaciones"].Visible = false;
                DataListado.Columns["tsitablas"].Visible = false;
                DataListado.Columns["tsireportes"].Visible = false;
                DataListado.Columns["tscoperaciones"].Visible = false;
                DataListado.Columns["tsctablas"].Visible = false;
                DataListado.Columns["tscreportes"].Visible = false;
                DataListado.Columns["tsvoperaciones"].Visible = false;
                DataListado.Columns["tsvtablas"].Visible = false;
                DataListado.Columns["tsvreportes"].Visible = false;
                DataListado.Columns["tsboperaciones"].Visible = false;
                DataListado.Columns["tsbtablas"].Visible = false;
                DataListado.Columns["tsbreportes"].Visible = false;
                DataListado.Columns["tscfoperaciones"].Visible = false;
                DataListado.Columns["tscftablas"].Visible = false;
                DataListado.Columns["tscfreportes"].Visible = false;

                LbInexistente.Visible = false;
            }
            else
            {
                FUsuario mForm = FUsuario.GetForm();
                mForm.Listar();
                Close();
            }

            DataListado.Columns["cod_mapa"].HeaderText = "Codigo";
            DataListado.Columns["desc_mapa"].HeaderText = "Descripcion";

            DataListado.Columns["cod_mapa"].Width = 100;
            DataListado.Columns["desc_mapa"].Width = 250;

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
                DataListado.DataSource = EMapa.Mostrar();
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
                DataListado.DataSource = EMapa.Buscar(TxtBuscar.Text, "cod");
            }
            else if (TxtBtipo.Text == "Descripcion")
            {
                DataListado.DataSource = EMapa.Buscar(TxtBuscar.Text, "Desc");
            }
        }

        private void FMapaLista_Load(object sender, EventArgs e)
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
                            Codigo = Convert.ToString(row.Cells["cod_mapa"].Value);
                            Rpta = EMapa.Eliminar(Codigo);
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
                FMapa mForm = FMapa.GetForm();
                string cod_mapa, desc_mapa, ainventario, acompras, aventas, abanco, aconfig, tsioperaciones, tsitablas, tsireportes, tscoperaciones, tsctablas, tscreportes, tsvoperaciones, tsvtablas, tsvreportes, tsboperaciones, tsbtablas, tsbreportes, tscfoperaciones, tscftablas, tscfreportes;

                cod_mapa = Convert.ToString(DataListado.CurrentRow.Cells["cod_mapa"].Value);
                desc_mapa = Convert.ToString(DataListado.CurrentRow.Cells["desc_mapa"].Value);
                ainventario = Convert.ToString(DataListado.CurrentRow.Cells["ainventario"].Value);
                acompras = Convert.ToString(DataListado.CurrentRow.Cells["acompras"].Value);
                aventas = Convert.ToString(DataListado.CurrentRow.Cells["aventas"].Value);
                abanco = Convert.ToString(DataListado.CurrentRow.Cells["abanco"].Value);
                aconfig = Convert.ToString(DataListado.CurrentRow.Cells["aconfig"].Value);
                tsioperaciones = Convert.ToString(DataListado.CurrentRow.Cells["tsioperaciones"].Value);
                tsitablas = Convert.ToString(DataListado.CurrentRow.Cells["tsitablas"].Value);
                tsireportes = Convert.ToString(DataListado.CurrentRow.Cells["tsireportes"].Value);
                tscoperaciones = Convert.ToString(DataListado.CurrentRow.Cells["tscoperaciones"].Value);
                tsctablas = Convert.ToString(DataListado.CurrentRow.Cells["tsctablas"].Value);
                tscreportes = Convert.ToString(DataListado.CurrentRow.Cells["tscreportes"].Value);
                tsvoperaciones = Convert.ToString(DataListado.CurrentRow.Cells["tsvoperaciones"].Value);
                tsvtablas = Convert.ToString(DataListado.CurrentRow.Cells["tsvtablas"].Value);
                tsvreportes = Convert.ToString(DataListado.CurrentRow.Cells["tsvreportes"].Value);
                tsboperaciones = Convert.ToString(DataListado.CurrentRow.Cells["tsboperaciones"].Value);
                tsbtablas = Convert.ToString(DataListado.CurrentRow.Cells["tsbtablas"].Value);
                tsbreportes = Convert.ToString(DataListado.CurrentRow.Cells["tsbreportes"].Value);
                tscfoperaciones = Convert.ToString(DataListado.CurrentRow.Cells["tscfoperaciones"].Value);
                tscftablas = Convert.ToString(DataListado.CurrentRow.Cells["tscftablas"].Value);
                tscfreportes = Convert.ToString(DataListado.CurrentRow.Cells["tscfreportes"].Value);
                mForm.SetPmapa(cod_mapa, desc_mapa, ainventario, acompras, aventas, abanco, aconfig, tsioperaciones, tsitablas, tsireportes, tscoperaciones, tsctablas, tscreportes, tsvoperaciones, tsvtablas, tsvreportes, tsboperaciones, tsbtablas, tsbreportes, tscfoperaciones, tscftablas, tscfreportes);
                mForm.TxtEditar.Text = "Listar";
            }
            else if (TxtFlag.Text == "Usuario")
            {
                FUsuario mForm = FUsuario.GetForm();
                string cod_mapa, desc_mapa;
                cod_mapa = Convert.ToString(DataListado.CurrentRow.Cells["cod_mapa"].Value);
                desc_mapa = Convert.ToString(DataListado.CurrentRow.Cells["desc_mapa"].Value);
                mForm.SetMapa(cod_mapa, desc_mapa);
            }
            Close();
        }
    }
}
