using Entidades;
using Presentacion.ModuloBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloCompra
{
    public partial class FPagoDetalle : Form
    {
        public string Editar = "";
        string TxtCod_moneda = "";
        decimal Saldocuenta = 0;
        bool Registrar = true;
        DataTable Dt;

        private static FPagoDetalle _Instancia;

        public static FPagoDetalle GetForm()
        {
            if (_Instancia == null)
            {
                _Instancia = new FPagoDetalle();
            }
            return _Instancia;
        }

        public FPagoDetalle()
        {
            InitializeComponent();
            ListarCaja();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "...::: Stage One V 0.1 :::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void Limpiar()
        {
            TxtReng.Text = String.Empty;
            TxtCod_pago.Text = String.Empty;
            TxtCod_cuenta.Text = String.Empty;
            TxtCod_caja.Text = String.Empty;
            TxtCod_compra.Text = String.Empty;
            TxtNumdocpago.Text = String.Empty;
            TxtOptipo.Text = String.Empty;
            TxtForma.Text = "Transferencia";
            TxtCod_movbanco.Text = String.Empty;
            TxtCod_movcaja.Text = String.Empty;
            TxtAbono.Text = String.Empty;
            TxtEsretenislr.Text = false.ToString();
            TxtEsreteniva.Text = false.ToString();
            TxtFecha_reg.Text = String.Empty;
            TxtCod_caja.Visible = false;
            TxtDesc_caja.Visible = false;
            TxtCod_movcaja.Visible = false;
        }

        internal void ListarCaja()
        {
            DataTable Dt = ECaja.Mostrar();

            for (int i = 0; i <= Convert.ToInt32(Dt.Rows.Count) - 1; i++)
            {
                TxtCod_caja.Items.Add(Dt.Rows[i]["cod_caja"].ToString());
            }
        }

        private void FormaPago()
        {
            TxtForma.Items.AddRange(new object[] { "Transferencia", "Cheque", "Deposito", "Efectivo" });
        }

        internal void SetPagoDetalle(string cod_compra, string optipo, string numdocumento, decimal total)
        {
            TxtCod_compra.Text = cod_compra;
            TxtOptipo.Text = optipo;
            TxtMonto.Text = Convert.ToString(total);
            TxtNumdocumento.Text = numdocumento;

            if (TxtMonto.Value > 0)
            {
                TxtSaldo.Value = TxtMonto.Value - TxtAbono.Value;
            }
            else if (TxtMonto.Value < 0)
            {
                TxtSaldo.Value = TxtMonto.Value + TxtAbono.Value;
            }
        }

        private void PagoDetalle_Load(object sender, EventArgs e)
        {
            Text = "...::: Detalle de Pago :::...";
            FormaPago();
        }

        private void TxtForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtForma.Text == "Transferencia" || TxtForma.Text == "Cheque")
            {
                TxtCod_cuenta.Visible = true;
                TxtDesc_cuenta.Visible = true;
                TxtCod_movbanco.Visible = true;
                TxtCod_caja.Visible = false;
                TxtDesc_caja.Visible = false;
                TxtCod_movcaja.Visible = false;
                TxtCod_caja.Text = "";
                TxtDesc_caja.Text = "";
                TxtCod_movcaja.Text = "";
            }
            else if (TxtForma.Text == "Deposito" || TxtForma.Text == "Efectivo")
            {
                TxtCod_cuenta.Visible = false;
                TxtDesc_cuenta.Visible = false;
                TxtCod_movbanco.Visible = false;
                TxtCod_caja.Visible = true;
                TxtDesc_caja.Visible = true;
                TxtCod_movcaja.Visible = true;
                TxtCod_cuenta.Text = "";
                TxtDesc_cuenta.Text = "";
                TxtCod_movbanco.Text = "";
            }
        }

        private void TxtAbono_ValueChanged(object sender, EventArgs e)
        {
            if (TxtMonto.Value > 0)
            {
                TxtSaldo.Value = TxtMonto.Value - TxtAbono.Value;
            }
            else if (TxtMonto.Value < 0)
            {
                TxtSaldo.Value = TxtMonto.Value + TxtAbono.Value;
            }
        }

        internal void InsertarNuevo()
        {
            string reng, cod_compra, numdocumento, optipo, numdocpago, forma, cod_movbanco, desc_cuenta, cod_movcaja, desc_caja, monto, esretenislr, esreteniva, fecha_reg;

            reng = 0.ToString();
            cod_compra = TxtCod_compra.Text;
            numdocumento = TxtNumdocumento.Text;
            optipo = TxtOptipo.Text;
            numdocpago = TxtNumdocpago.Text;
            forma = TxtForma.Text;
            cod_movbanco = TxtCod_movbanco.Text;
            desc_cuenta = TxtDesc_cuenta.Text;
            cod_movcaja = TxtCod_movcaja.Text;
            desc_caja = TxtDesc_caja.Text;
            monto = TxtAbono.Text;
            esretenislr = TxtEsretenislr.Text;
            esreteniva = TxtEsreteniva.Text;
            fecha_reg = TxtFecha_reg.Text;

            try
            {
                FPago mForm = FPago.GetForm();

                if (TxtNumdocpago.Text == string.Empty && (TxtCod_caja.Text == string.Empty || TxtCod_cuenta.Text == string.Empty))
                {
                    MensajeError("Falta Ingresar algunos Datos");
                    ErrorTexto.SetError(TxtNumdocpago, "Numero de Documento");
                    Registrar = false;
                }
                else if (
                    (TxtForma.Text=="Transferencia" && TxtCod_cuenta.Text==string.Empty || 
                    TxtForma.Text == "Cheque" && TxtCod_cuenta.Text == string.Empty) || 
                    (TxtForma.Text == "Deposito" && TxtCod_caja.Text == string.Empty|| 
                    TxtForma.Text == "Efectivo" && TxtCod_caja.Text == string.Empty))
                {
                    ErrorTexto.SetError(TxtCod_caja, "Caja");
                    ErrorTexto.SetError(TxtCod_cuenta, "Cuenta Bancaria");
                    Registrar = false;
                }
                else if (TxtAbono.Value == 0)
                {
                    MensajeError("No se Puede procesar Opreacion en 0");
                    TxtAbono.Focus();
                    Registrar = false;
                }
                //else if (Convert.ToDecimal(monto) > Convert.ToDecimal(TxtMonto.Value))
                //{

                //    MensajeError("Monto de la Operacion es Mayor al saldo del Documento");
                //    TxtAbono.Focus();

                //}
                else if (Registrar)
                {
                    mForm.AgregarColumnas(reng, cod_compra, numdocumento, optipo, numdocpago, forma, cod_movbanco, desc_cuenta, cod_movcaja, desc_caja, monto, esretenislr, esreteniva, fecha_reg);
                    Limpiar();
                    Close();
                    mForm.CalcularDetalle();
                    
                }
            }
            catch (Exception Exc)
            {
                MensajeError(Exc.Message);
            }
        }

        private void TxtCod_caja_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt = ECaja.Mostrar();

            foreach (DataRow Row in Dt.Rows)
            {
                if (Convert.ToString(Row["cod_caja"]).Equals(TxtCod_caja.Text))
                {
                    TxtDesc_caja.Text = Convert.ToString(Row["desc_caja"]);
                }
            }
        }

        internal void SetCuenta(string cod_cuenta, string desc_cuenta, string cod_moneda, string saldo)
        {
            TxtCod_cuenta.Text = cod_cuenta;
            TxtDesc_cuenta.Text = desc_cuenta;
            TxtCod_moneda = cod_moneda;
            Saldocuenta = Convert.ToDecimal(saldo);
        }

        private void TxtCod_cuenta_DoubleClick(object sender, EventArgs e)
        {
            FCuentaLista Listado = new FCuentaLista
            {
                TxtFlag = "Pago"
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
                    TxtFlag = "Pago"
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Editar == "Nuevo")
            {
                InsertarNuevo();
            }
            else if (Editar == "Editar")
            {

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }

        private void TxtCod_cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDesc_cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void FPagoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
