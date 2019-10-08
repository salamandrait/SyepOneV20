namespace Presentacion
{
    partial class FImportar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.ItemCotizacion = new DevComponents.DotNetBar.ButtonItem();
            this.ItemPedido = new DevComponents.DotNetBar.ButtonItem();
            this.ItemFactura = new DevComponents.DotNetBar.ButtonItem();
            this.ItemNRecepcion = new DevComponents.DotNetBar.ButtonItem();
            this.ItemNEntrega = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.itemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.itemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ItemCotizacion,
            this.ItemPedido,
            this.ItemFactura,
            this.ItemNRecepcion,
            this.ItemNEntrega});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(150, 152);
            this.itemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.itemPanel1.TabIndex = 0;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // ItemCotizacion
            // 
            this.ItemCotizacion.Name = "ItemCotizacion";
            this.ItemCotizacion.Text = "Cotizacion";
            this.ItemCotizacion.Click += new System.EventHandler(this.ItemCotizacion_Click);
            // 
            // ItemPedido
            // 
            this.ItemPedido.Name = "ItemPedido";
            this.ItemPedido.Text = "Pedido";
            this.ItemPedido.Click += new System.EventHandler(this.ItemPedido_Click);
            // 
            // ItemFactura
            // 
            this.ItemFactura.Name = "ItemFactura";
            this.ItemFactura.Text = "Factura";
            this.ItemFactura.Click += new System.EventHandler(this.ItemFactura_Click);
            // 
            // ItemNRecepcion
            // 
            this.ItemNRecepcion.Name = "ItemNRecepcion";
            this.ItemNRecepcion.Text = "Nota de Recepcion";
            // 
            // ItemNEntrega
            // 
            this.ItemNEntrega.Name = "ItemNEntrega";
            this.ItemNEntrega.Text = "Nota de Entrega";
            // 
            // PImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 152);
            this.Controls.Add(this.itemPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PImportar";
            this.Load += new System.EventHandler(this.PImportar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ButtonItem ItemCotizacion;
        private DevComponents.DotNetBar.ButtonItem ItemPedido;
        private DevComponents.DotNetBar.ButtonItem ItemFactura;
        private DevComponents.DotNetBar.ButtonItem ItemNRecepcion;
        private DevComponents.DotNetBar.ButtonItem ItemNEntrega;
    }
}