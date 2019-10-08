using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloVenta
{
    public partial class FVOtros : Form
    {
        public FVOtros()
        {
            InitializeComponent();
        }

        private void FVOtros_Load(object sender, EventArgs e)
        {
            Text = "..:: Otros Recargos/Descuentos ::..";
            TxtTotalo.Value = TxtMonto.Value - TxtDescuento.Value;
        }

        private void TxtRecargo_ValueChanged(object sender, EventArgs e)
        {
            TxtTotalo.Value = TxtMonto.Value + TxtRecargo.Value;
        }

        private void TxtDescuento_ValueChanged(object sender, EventArgs e)
        {
            TxtTotalo.Value = TxtMonto.Value - TxtDescuento.Value;
        }


        private void TxtTotalo_ValueChanged(object sender, EventArgs e)
        {
            TxtTotalo.Value = (TxtMonto.Value + TxtRecargo.Value) - TxtDescuento.Value;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtFlag.Text == "DVenta")
            {
                //FDVenta mDVenta = FDVenta.GetForm();
                //mDVenta.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            else if (txtFlag.Text == "CVenta")
            {
                //FCVenta mCVenta = FCVenta.GetForm();
                //mCVenta.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            else if (txtFlag.Text == "PVenta")
            {
                //FPVenta mPVenta = FPVenta.GetForm();
                //mPVenta.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            else if (txtFlag.Text == "FVenta")
            {
                //FFVenta mFVenta = FFVenta.GetForm();
                //mFVenta.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            Close();
            Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (txtFlag.Text == "DVenta")
            {
                Close();
            }
            else if (txtFlag.Text == "CVenta")
            {
                Close();
            }
            else if (txtFlag.Text == "PVenta")
            {
                Close();
            }
            else if (txtFlag.Text == "FVenta")
            {
                Close();
            }
            Dispose();
        }
    }
}
