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
    public partial class FChequeraDetalle : Form
    {
        Int32 Reng = 1;
        DataTable DtDetalle;
        DialogResult Opcion;

        public FChequeraDetalle()
        {
            InitializeComponent();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 5.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Step One Ver 5.0 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OcultarColumnas()
        {
            DataListado.Columns["Anular"].Visible = false;
            DataListado.Columns["rengchequera"].Visible = false;
            DataListado.Columns["cod_chequera"].Visible = false;
            DataListado.Columns["cod_cuenta"].Visible = false;
            DataListado.Columns["numcheque"].Visible = true;
            DataListado.Columns["estatus"].Visible = true;
            DataListado.Columns["fechaemision"].Visible = true;
            DataListado.Columns["monto"].Visible = true;
            DataListado.Columns["descripcion"].Visible = true;
            DataListado.Columns["monto"].DefaultCellStyle.Format = Convert.ToString("##,##0.00");
            DataListado.Columns["fechaemision"].DefaultCellStyle.Format = Convert.ToString("dd/MM/yyyy");

            DataListado.Columns["numcheque"].HeaderText = "N° de Cheque";
            DataListado.Columns["estatus"].HeaderText = "Estatus";
            DataListado.Columns["fechaemision"].HeaderText = "Fecha de Emision";
            DataListado.Columns["monto"].HeaderText = "Monto";
            DataListado.Columns["descripcion"].HeaderText = "Descripcion";

            DataListado.Columns["numcheque"].Width = 100;
            DataListado.Columns["estatus"].Width = 80;
            DataListado.Columns["fechaemision"].Width = 120;
            DataListado.Columns["monto"].Width = 120;
            DataListado.Columns["descripcion"].Width = 250;

            DataListado.Columns["monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataListado.Columns["descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Botones()
        {

            if (TxtEditar.Text == "Listar")
            {
                BtnAnular.Enabled = true;
                BtnGenerarCheq.Enabled = false;
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = true;
                TxtNumcheque.Enabled = false;
            }
            else if (TxtEditar.Text == "Editar")
            {
                BtnAnular.Enabled = false;
                BtnGenerarCheq.Enabled = true;
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                TxtNumcheque.Enabled = true;
            }
            else if (TxtEditar.Text == "Nuevo")
            {
                BtnAnular.Enabled = false;
                BtnGenerarCheq.Enabled = true;
                BtnAceptar.Enabled = true;
                BtnCancelar.Enabled = true;
                TxtNumcheque.Enabled = true;
            }
        }

        internal void CrearTabla()
        {
            DtDetalle = new DataTable();

            DtDetalle.Columns.Add("rengchequera", Type.GetType("System.Int32"));
            DtDetalle.Columns.Add("cod_chequera", Type.GetType("System.String"));
            DtDetalle.Columns.Add("numcheque", Type.GetType("System.Int32"));
            DtDetalle.Columns.Add("estatus", Type.GetType("System.String"));
            DtDetalle.Columns.Add("fechaemision", Type.GetType("System.String"));
            DtDetalle.Columns.Add("monto", Type.GetType("System.Decimal"));
            DtDetalle.Columns.Add("descripcion", Type.GetType("System.String"));
            DtDetalle.Columns.Add("cod_cuenta", Type.GetType("System.String"));
            DataListado.DataSource = DtDetalle;
            OcultarColumnas();
            LbInexistente.Visible = true;

        }

        public void AgregarColumnas()
        {
            try
            {
                int contador = Convert.ToInt32(TxtNumcheque.Text);
                DataRow Fila;

                for (contador = 0; contador < TxtCantidad.Value; contador = contador + 1)
                {
                    Fila = DtDetalle.NewRow();
                    Fila["rengchequera"] = Convert.ToInt32(Reng) + contador;
                    Fila["cod_chequera"] = TxtCod_chequera.Text;
                    Fila["numcheque"] = Convert.ToInt32(TxtNumcheque.Text) + contador;
                    Fila["estatus"] = Convert.ToString("Disponible");
                    Fila["fechaemision"] = Convert.ToString("NULL");
                    Fila["monto"] = Convert.ToDecimal("0,00");
                    Fila["descripcion"] = Convert.ToString("NULL");
                    DtDetalle.Rows.Add(Fila);
                    DataListado.DataSource = DtDetalle;
                    OcultarColumnas();
                    LbInexistente.Visible = false;

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(50);

                }
                MensajeOk("Chequera Generada Correctamente");
                BtnGenerarCheq.Text = "Regenerar";
            }
            catch (Exception Ex)
            {
                MensajeError(Ex.Message);
            }
        }

        internal void Mostrar()
        {
            try
            {
                if (RbTodos.Checked == true)
                {
                    DataListado.DataSource = EChequeraDetalle.Mostrar(TxtCod_chequera.Text, TxtCod_cuenta.Text, ("NULL"));
                    OcultarColumnas();
                }
                else if (RbDisp.Checked == true)
                {
                    DataListado.DataSource = EChequeraDetalle.Mostrar(TxtCod_chequera.Text, TxtCod_cuenta.Text, ("Disponible"));
                    OcultarColumnas();
                }
                else if (RbAnul.Checked == true)
                {
                    DataListado.DataSource = EChequeraDetalle.Mostrar(TxtCod_chequera.Text, TxtCod_cuenta.Text, ("Anulado"));
                    OcultarColumnas();
                }
                else if (RbEmitidos.Checked == true)
                {
                    DataListado.DataSource = EChequeraDetalle.Mostrar(TxtCod_chequera.Text, TxtCod_cuenta.Text, ("Emitido"));
                    OcultarColumnas();
                }
                BtnAnular.Enabled = true;
                BtnGenerarCheq.Enabled = false;
                BtnAceptar.Enabled = false;
                BtnCancelar.Enabled = false;
                TxtNumcheque.Enabled = false;
                LbInexistente.Visible = false;
            }
            catch (Exception Exc)
            {
                MensajeOk(Exc.Message);
            }
        }

        private void GuardarChequera()
        {
            int rengchequera = 0;
            string cod_chequera = "";
            string numcheque = "";
            string estatus = "";
            decimal monto = 0;
            string Rpta = "";

            try
            {
                foreach (DataGridViewRow Fila in DataListado.Rows)
                {

                    rengchequera = Convert.ToInt32(Fila.Cells["rengchequera"].Value);
                    cod_chequera = Convert.ToString(Fila.Cells["cod_chequera"].Value);
                    numcheque = Convert.ToString(Fila.Cells["numcheque"].Value);
                    estatus = Convert.ToString(Fila.Cells["estatus"].Value);
                    monto = Convert.ToDecimal(Fila.Cells["monto"].Value);

                    Rpta = EChequeraDetalle.Insertar(rengchequera, cod_chequera, numcheque, estatus, monto);

                }
                if (Rpta == "Y")
                {
                    MensajeOk("Chequera Registrada Correctamente");
                }
                else
                {
                    MensajeError(Rpta);
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void FChequeraDetalle_Load(object sender, EventArgs e)
        {
            Text = "...::: Listado Chequera :::...";
            RbTodos.Checked = true;
            if (TxtEditar.Text == "Listar")
            {
                Mostrar();
                Botones();
                BtnCancelar.Text = "Cerrar";
            }
            else if (TxtEditar.Text == "Nuevo")
            {
                CrearTabla();
                Botones();
                BtnCancelar.Text = "Cancelar";
            }
        }

        private void BtnGenerarCheq_Click(object sender, EventArgs e)
        {
            if (BtnGenerarCheq.Text == "Generar")
            {
                AgregarColumnas();
                BtnGenerarCheq.Text = "Regenerar";
            }
            else if (BtnGenerarCheq.Text == "Regenerar")
            {
                CrearTabla();
                BtnGenerarCheq.Text = "Generar";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            GuardarChequera();
            TxtEditar.Text = "Listar";
            Botones();
            Mostrar();
            //FChequera Cheq = FChequera.GetFChequera();
            //Cheq.ConsultarListado();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (TxtEditar.Text == "Listar")
            {
                Close();
            }
            if (TxtEditar.Text == "Nuevo")
            {
                if(DataListado.Rows.Count==0)
                {
                    Close();
                }
                else if (DataListado.Rows.Count > 0)
                {
                    Opcion = MessageBox.Show("Desea Guardar antes de Salir", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if(Opcion==DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            if (TxtEditar.Text == "Editar")
            {

            }
        }

        private void ChkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAnular.Checked)
            {
                DataListado.Columns["Anular"].Visible = true;
                DataListado.Columns["Anular"].Width = 80;

            }
            else
            {
                DataListado.Columns["Anular"].Visible = false;
                DataListado.Columns["Anular"].Width = 80;
                BtnAnular.Enabled = false;
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;

                Opcion = MessageBox.Show("Realmente Desea Anular los Registros Seleccionados ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string _Estatus = "Anulado";
                    string _numcheque;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Anular"].Value))
                        {

                            _numcheque = Convert.ToString(row.Cells["numcheque"].Value);
                            Rpta = EChequeraDetalle.EstatusChequera(_numcheque, _Estatus);
                        }
                    }


                    if (Rpta.Equals("Y"))
                    {
                        MensajeOk("Se Anularon Correctamente los Registros Seleccionados");
                        ChkAnular.CheckState = CheckState.Unchecked;
                        Mostrar();
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
                else
                {
                    MensajeError("Cancelando la Anulacion de Registros!");
                    ChkAnular.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void FChequeraDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DtDetalle.Rows.Count < 0)
            {
                Opcion = MessageBox.Show("Desea Guardar Antes de Salir?", "...::: Step One Ver 5.0 :::...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    GuardarChequera();
                }
            }
        }

        private void RbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void RbDisp_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void RbEmitidos_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void RbAnul_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
