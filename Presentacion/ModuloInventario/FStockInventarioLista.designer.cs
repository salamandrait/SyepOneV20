namespace Presentacion.ModuloInventario
{
    partial class FStockInventarioLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.TxtCod_usuario = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.TxtDesc_usuario = new DevComponents.DotNetBar.LabelItem();
            this.TxtBtipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TxtBuscar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbInexistente = new System.Windows.Forms.LinkLabel();
            this.BtnActualizar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListado.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListado.Location = new System.Drawing.Point(7, 50);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersWidth = 25;
            this.DataListado.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(880, 383);
            this.DataListado.TabIndex = 3;
            // 
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.metroStatusBar1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TxtCod_usuario,
            this.labelItem4,
            this.TxtDesc_usuario});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 477);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(892, 22);
            this.metroStatusBar1.TabIndex = 4;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // TxtCod_usuario
            // 
            this.TxtCod_usuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod_usuario.ForeColor = System.Drawing.Color.White;
            this.TxtCod_usuario.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.TxtCod_usuario.Name = "TxtCod_usuario";
            this.TxtCod_usuario.Text = "000000";
            // 
            // labelItem4
            // 
            this.labelItem4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem4.ForeColor = System.Drawing.Color.White;
            this.labelItem4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "|";
            // 
            // TxtDesc_usuario
            // 
            this.TxtDesc_usuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesc_usuario.ForeColor = System.Drawing.Color.White;
            this.TxtDesc_usuario.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.TxtDesc_usuario.Name = "TxtDesc_usuario";
            this.TxtDesc_usuario.Text = "Usuario AAA";
            // 
            // TxtBtipo
            // 
            this.TxtBtipo.DisplayMember = "Text";
            this.TxtBtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtBtipo.FormattingEnabled = true;
            this.TxtBtipo.ItemHeight = 16;
            this.TxtBtipo.Location = new System.Drawing.Point(8, 12);
            this.TxtBtipo.Name = "TxtBtipo";
            this.TxtBtipo.Size = new System.Drawing.Size(169, 22);
            this.TxtBtipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.TxtBtipo.TabIndex = 24;
            // 
            // TxtBuscar
            // 
            // 
            // 
            // 
            this.TxtBuscar.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtBuscar.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtBuscar.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtBuscar.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtBuscar.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtBuscar.Border.Class = "TextBoxBorder";
            this.TxtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtBuscar.FocusHighlightEnabled = true;
            this.TxtBuscar.Location = new System.Drawing.Point(180, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(387, 22);
            this.TxtBuscar.TabIndex = 25;
            // 
            // LbInexistente
            // 
            this.LbInexistente.AutoSize = true;
            this.LbInexistente.Location = new System.Drawing.Point(412, 234);
            this.LbInexistente.Name = "LbInexistente";
            this.LbInexistente.Size = new System.Drawing.Size(66, 14);
            this.LbInexistente.TabIndex = 27;
            this.LbInexistente.TabStop = true;
            this.LbInexistente.Text = "Sin Datos";
            this.LbInexistente.Visible = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnActualizar.Location = new System.Drawing.Point(818, 9);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(62, 32);
            this.BtnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnActualizar.Symbol = "";
            this.BtnActualizar.TabIndex = 28;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FStockInventarioLista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.LbInexistente);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.TxtBtipo);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.DataListado);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FStockInventarioLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStockInventarioLista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStockInventarioLista_FormClosed);
            this.Load += new System.EventHandler(this.FStockInventarioLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem TxtCod_usuario;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem TxtDesc_usuario;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TxtBtipo;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBuscar;
        private System.Windows.Forms.LinkLabel LbInexistente;
        private DevComponents.DotNetBar.ButtonX BtnActualizar;
    }
}