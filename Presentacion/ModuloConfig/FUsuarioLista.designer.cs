namespace Presentacion.ModuloConfig
{
    partial class FUsuarioLista
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
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LbTotalReg = new DevComponents.DotNetBar.LabelItem();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ChkEliminar = new System.Windows.Forms.CheckBox();
            this.TxtBtipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TxtBuscar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.LbInexistente = new System.Windows.Forms.LinkLabel();
            this.TxtFlag = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
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
            this.labelItem1,
            this.LbTotalReg});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 312);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(536, 22);
            this.metroStatusBar1.TabIndex = 1;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem1.ForeColor = System.Drawing.Color.White;
            this.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Total Registros:|";
            // 
            // LbTotalReg
            // 
            this.LbTotalReg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalReg.ForeColor = System.Drawing.Color.White;
            this.LbTotalReg.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.LbTotalReg.Name = "LbTotalReg";
            this.LbTotalReg.Text = "000000";
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
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
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
            this.DataListado.Location = new System.Drawing.Point(6, 52);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersWidth = 25;
            this.DataListado.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(523, 222);
            this.DataListado.TabIndex = 2;
            this.DataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            this.DataListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellDoubleClick);
            this.DataListado.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataListado_RowPostPaint);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.BtnEliminar.Location = new System.Drawing.Point(88, 278);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(32, 32);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkEliminar.Location = new System.Drawing.Point(12, 283);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(70, 18);
            this.ChkEliminar.TabIndex = 22;
            this.ChkEliminar.Text = "Eliminar";
            this.ChkEliminar.UseVisualStyleBackColor = true;
            this.ChkEliminar.CheckedChanged += new System.EventHandler(this.ChkEliminar_CheckedChanged);
            // 
            // TxtBtipo
            // 
            this.TxtBtipo.DisplayMember = "Text";
            this.TxtBtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtBtipo.FormattingEnabled = true;
            this.TxtBtipo.ItemHeight = 16;
            this.TxtBtipo.Location = new System.Drawing.Point(12, 12);
            this.TxtBtipo.Name = "TxtBtipo";
            this.TxtBtipo.Size = new System.Drawing.Size(140, 22);
            this.TxtBtipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.TxtBtipo.TabIndex = 23;
            this.TxtBtipo.SelectedIndexChanged += new System.EventHandler(this.TxtBtipo_SelectedIndexChanged);
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
            this.TxtBuscar.Location = new System.Drawing.Point(155, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(282, 22);
            this.TxtBuscar.TabIndex = 24;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.BtnImprimir.Location = new System.Drawing.Point(482, 12);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(42, 28);
            this.BtnImprimir.TabIndex = 25;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // LbInexistente
            // 
            this.LbInexistente.AutoSize = true;
            this.LbInexistente.Location = new System.Drawing.Point(228, 158);
            this.LbInexistente.Name = "LbInexistente";
            this.LbInexistente.Size = new System.Drawing.Size(66, 14);
            this.LbInexistente.TabIndex = 26;
            this.LbInexistente.TabStop = true;
            this.LbInexistente.Text = "Sin Datos";
            // 
            // TxtFlag
            // 
            this.TxtFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtFlag.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFlag.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtFlag.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFlag.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFlag.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFlag.Border.Class = "TextBoxBorder";
            this.TxtFlag.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFlag.FocusHighlightEnabled = true;
            this.TxtFlag.Location = new System.Drawing.Point(165, 283);
            this.TxtFlag.Name = "TxtFlag";
            this.TxtFlag.Size = new System.Drawing.Size(23, 22);
            this.TxtFlag.TabIndex = 27;
            this.TxtFlag.Visible = false;
            // 
            // FUsuarioLista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(536, 334);
            this.Controls.Add(this.TxtFlag);
            this.Controls.Add(this.LbInexistente);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.TxtBtipo);
            this.Controls.Add(this.ChkEliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.metroStatusBar1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FUsuarioLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FUsuarioLista";
            this.Load += new System.EventHandler(this.FUsuarioLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem LbTotalReg;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkEliminar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TxtBtipo;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBuscar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.LinkLabel LbInexistente;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtFlag;
    }
}