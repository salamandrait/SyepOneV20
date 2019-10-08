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
    public partial class FCOtros : Form
    {
        public FCOtros()
        {
            InitializeComponent();
        }

        private void FCOtros_Load(object sender, EventArgs e)
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
            if (txtFlag.Text == "DCompra")
            {
                FDCompra mDCompra = FDCompra.GetForm();
                mDCompra.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            else if (txtFlag.Text == "CCompra")
            {
                FCCompra mCCompra = FCCompra.GetForm();
                mCCompra.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            else if (txtFlag.Text == "PCompra")
            {
                FPCompra mPCompra = FPCompra.GetForm();
                mPCompra.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            else if (txtFlag.Text == "FCompra")
            {
                FFCompra mFCompra = FFCompra.GetForm();
                mFCompra.TxtMonto_o.Value = TxtTotalo.Value - TxtMonto.Value;
            }
            Close();
            Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (txtFlag.Text == "DCompra")
            {
                Close();
            }
            else if (txtFlag.Text == "CCompra")
            {
                Close();
            }
            else if (txtFlag.Text == "PCompra")
            {
                Close();
            }
            else if (txtFlag.Text == "FCompra")
            {
                Close();
            }
            Dispose();
        }
    }
}
