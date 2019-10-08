namespace Presentacion
{
    partial class FMonedaLista
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
            this.LbInexistente = new System.Windows.Forms.LinkLabel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtBuscar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtBtipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ChkEliminar = new System.Windows.Forms.CheckBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LbTotalReg = new DevComponents.DotNetBar.LabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // LbInexistente
            // 
            this.LbInexistente.AutoSize = true;
            this.LbInexistente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LbInexistente.Location = new System.Drawing.Point(244, 154);
            this.LbInexistente.Name = "LbInexistente";
            this.LbInexistente.Size = new System.Drawing.Size(66, 14);
            this.LbInexistente.TabIndex = 34;
            this.LbInexistente.TabStop = true;
            this.LbInexistente.Text = "Sin Datos";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.BtnImprimir.Location = new System.Drawing.Point(474, 8);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(42, 28);
            this.BtnImprimir.TabIndex = 33;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
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
            this.TxtBuscar.DisabledBackColor = System.Drawing.Color.White;
            this.TxtBuscar.FocusHighlightEnabled = true;
            this.TxtBuscar.ForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.Location = new System.Drawing.Point(151, 8);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(282, 22);
            this.TxtBuscar.TabIndex = 32;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // TxtBtipo
            // 
            this.TxtBtipo.DisplayMember = "Text";
            this.TxtBtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtBtipo.ForeColor = System.Drawing.Color.Black;
            this.TxtBtipo.FormattingEnabled = true;
            this.TxtBtipo.ItemHeight = 16;
            this.TxtBtipo.Location = new System.Drawing.Point(8, 8);
            this.TxtBtipo.Name = "TxtBtipo";
            this.TxtBtipo.Size = new System.Drawing.Size(140, 22);
            this.TxtBtipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.TxtBtipo.TabIndex = 31;
            this.TxtBtipo.SelectedIndexChanged += new System.EventHandler(this.TxtBtipo_SelectedIndexChanged);
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkEliminar.Location = new System.Drawing.Point(12, 286);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(70, 18);
            this.ChkEliminar.TabIndex = 30;
            this.ChkEliminar.Text = "Eliminar";
            this.ChkEliminar.UseVisualStyleBackColor = true;
            this.ChkEliminar.CheckedChanged += new System.EventHandler(this.ChkEliminar_CheckedChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.BtnEliminar.Location = new System.Drawing.Point(88, 279);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(32, 32);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListado.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.DataListado.Location = new System.Drawing.Point(6, 40);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersWidth = 25;
            this.DataListado.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(557, 237);
            this.DataListado.TabIndex = 28;
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
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.metroStatusBar1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.LbTotalReg});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 320);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(567, 22);
            this.metroStatusBar1.TabIndex = 35;
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
            this.LbTotalReg.Text = "0000";
            // 
            // FMonedaLista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(567, 342);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.LbInexistente);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.TxtBtipo);
            this.Controls.Add(this.ChkEliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DataListado);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FMonedaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonedaListar";
            this.Load += new System.EventHandler(this.FMonedaListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LbInexistente;
        private System.Windows.Forms.Button BtnImprimir;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBuscar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TxtBtipo;
        private System.Windows.Forms.CheckBox ChkEliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem LbTotalReg;
    }
}