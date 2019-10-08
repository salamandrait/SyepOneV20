using Entidades;
using Presentacion.ModuloCompra;
using Presentacion.ModuloVenta;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FImportar : Form
    {
        public string FlagOpcion;

        public string Cod_proveedor;

        public FImportar()
        {
            InitializeComponent();
        }

        private void PImportar_Load(object sender, EventArgs e)
        {
            MostrarOpciones();
            Text = "Cornvertir a ...";
        }

        private void MostrarOpciones()
        {
            switch (FlagOpcion)
            {
                case "CVenta":
                    ItemCotizacion.Visible = true;
                    ItemFactura.Visible = true;
                    ItemPedido.Visible = true;
                    ItemNRecepcion.Visible = false;
                    ItemNEntrega.Visible = true;
                    break;
                case "PVenta":
                    ItemCotizacion.Visible = true;
                    ItemFactura.Visible = true;
                    ItemPedido.Visible = true;
                    ItemNRecepcion.Visible = false;
                    ItemNEntrega.Visible = true;
                    break;
                case "FVenta":
                    ItemCotizacion.Visible = true;
                    ItemFactura.Visible = true;
                    ItemPedido.Visible = true;
                    ItemNRecepcion.Visible = false;
                    ItemNEntrega.Visible = true;
                    break;
            }

            if(FlagOpcion=="PCompra")
            {
                ItemCotizacion.Visible = true;
                ItemFactura.Visible = true;
                ItemPedido.Visible = true;
                ItemNRecepcion.Visible = true;
                ItemNEntrega.Visible = false;
            }
            else if (FlagOpcion == "CCompra")
            {
                ItemCotizacion.Visible = true;
                ItemFactura.Visible = true;
                ItemPedido.Visible = true;
                ItemNRecepcion.Visible = true;
                ItemNEntrega.Visible = false;
            }
            else if (FlagOpcion == "FCompra")
            {
                ItemCotizacion.Visible = true;
                ItemFactura.Visible = true;
                ItemPedido.Visible = true;
                ItemNRecepcion.Visible = true;
                ItemNEntrega.Visible = false;
            }      
        }

        private void ItemCotizacion_Click(object sender, EventArgs e)
        {
            if(FlagOpcion=="CCompra")
            {
                FCCompra mForm = new FCCompra();
                FlagOpcion = "CCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "PCompra")
            {
                FCCompra mForm = new FCCompra();
                FlagOpcion = "PCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "FCompra")
            {
                FCCompra mForm = new FCCompra();
                FlagOpcion = "FCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "CVenta")
            {
                //FCVenta mForm = new FCVenta();
                //FlagOpcion = "CVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
            else if (FlagOpcion == "PVenta")
            {
                //FCVenta mForm = new FCVenta();
                //FlagOpcion = "PVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
            else if (FlagOpcion == "FVenta")
            {
                //FCVenta mForm = new FCVenta();
                //FlagOpcion = "FVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
        }

        private void ItemPedido_Click(object sender, EventArgs e)
        {
            if (FlagOpcion == "PCompra")
            {
                FPCompra mForm = new FPCompra();
                FlagOpcion = "PCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "CCompra")
            {
                FPCompra mForm = new FPCompra();
                FlagOpcion = "CCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "FCompra")
            {
                FPCompra mForm = new FPCompra();
                FlagOpcion = "FCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "CVenta")
            {
                //FPVenta mForm = new FPVenta();
                //FlagOpcion = "CVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
            else if (FlagOpcion == "PVenta")
            {
                //FPVenta mForm = new FPVenta();
                //FlagOpcion = "PVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
            else if (FlagOpcion == "FVenta")
            {
                //FPVenta mForm = new FPVenta();
                //FlagOpcion = "FVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
        }

        private void ItemFactura_Click(object sender, EventArgs e)
        {
            if (FlagOpcion == "PCompra")
            {
                FPCompra mForm = new FPCompra();
                FlagOpcion = "PCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "CCompra")
            {
                FCCompra mForm = new FCCompra();
                FlagOpcion = "CCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "FCompra")
            {
                FFCompra mForm = new FFCompra();
                FlagOpcion = "FCompra";
                mForm.TipoImp = FlagOpcion;
                mForm.Importar = true;
                mForm.ShowDialog();
                Close();
            }
            else if (FlagOpcion == "CVenta")
            {
                //FFVenta mForm = new FFVenta();
                //FlagOpcion = "CVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
            else if (FlagOpcion == "PVenta")
            {
                //FFVenta mForm = new FFVenta();
                //FlagOpcion = "PVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
            else if (FlagOpcion == "FVenta")
            {
                //FFVenta mForm = new FFVenta();
                //FlagOpcion = "FVenta";
                //mForm.TipoImp = FlagOpcion;
                //mForm.Importar = true;
                //mForm.ShowDialog();
                //Close();
            }
        }
    }
}
