namespace Presentacion.ModuloInventario
{
    partial class FArtPrecio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtDesc_articulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_articulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LbTotalReg = new DevComponents.DotNetBar.LabelItem();
            this.LbInexistente = new System.Windows.Forms.LinkLabel();
            this.TxtDesc_precio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_precio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDesc_deposito = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_deposito = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMonto = new DevComponents.Editors.DoubleInput();
            this.ChkVenc_precio = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFecha_reg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.ChkEliminar = new System.Windows.Forms.CheckBox();
            this.TxtVenc_precio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtEditar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ErrorTexto = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtFecha_venc = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.TxtCod_depositov = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_preciov = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_articulov = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_venc)).BeginInit();
            this.SuspendLayout();
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListado.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListado.Location = new System.Drawing.Point(8, 37);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersWidth = 25;
            this.DataListado.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(505, 203);
            this.DataListado.TabIndex = 7;
            this.DataListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellClick);
            this.DataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            // 
            // TxtDesc_articulo
            // 
            // 
            // 
            // 
            this.TxtDesc_articulo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_articulo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.Class = "TextBoxBorder";
            this.TxtDesc_articulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_articulo.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDesc_articulo.Enabled = false;
            this.TxtDesc_articulo.FocusHighlightEnabled = true;
            this.TxtDesc_articulo.Location = new System.Drawing.Point(136, 7);
            this.TxtDesc_articulo.Name = "TxtDesc_articulo";
            this.TxtDesc_articulo.Size = new System.Drawing.Size(377, 22);
            this.TxtDesc_articulo.TabIndex = 6;
            // 
            // TxtCod_articulo
            // 
            // 
            // 
            // 
            this.TxtCod_articulo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_articulo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.Class = "TextBoxBorder";
            this.TxtCod_articulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_articulo.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_articulo.Enabled = false;
            this.TxtCod_articulo.FocusHighlightEnabled = true;
            this.TxtCod_articulo.Location = new System.Drawing.Point(8, 7);
            this.TxtCod_articulo.Name = "TxtCod_articulo";
            this.TxtCod_articulo.Size = new System.Drawing.Size(126, 22);
            this.TxtCod_articulo.TabIndex = 5;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(208, 403);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(36, 36);
            this.BtnEditar.TabIndex = 67;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.BtnImprimir.Location = new System.Drawing.Point(336, 403);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(36, 36);
            this.BtnImprimir.TabIndex = 66;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.BtnEliminar.Location = new System.Drawing.Point(272, 403);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(36, 36);
            this.BtnEliminar.TabIndex = 64;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Image = global::Presentacion.Properties.Resources.Nuevo;
            this.BtnNuevo.Location = new System.Drawing.Point(144, 403);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(36, 36);
            this.BtnNuevo.TabIndex = 65;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Image = global::Presentacion.Properties.Resources.Cancelar;
            this.BtnCancelar.Location = new System.Drawing.Point(80, 403);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.BtnCancelar.TabIndex = 63;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Image = global::Presentacion.Properties.Resources.Aceptar;
            this.BtnAceptar.Location = new System.Drawing.Point(16, 403);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(36, 36);
            this.BtnAceptar.TabIndex = 62;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 444);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(521, 22);
            this.metroStatusBar1.TabIndex = 61;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem1.ForeColor = System.Drawing.Color.White;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Total Registros:|";
            // 
            // LbTotalReg
            // 
            this.LbTotalReg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalReg.ForeColor = System.Drawing.Color.White;
            this.LbTotalReg.Name = "LbTotalReg";
            this.LbTotalReg.Text = "0";
            // 
            // LbInexistente
            // 
            this.LbInexistente.AutoSize = true;
            this.LbInexistente.Location = new System.Drawing.Point(220, 122);
            this.LbInexistente.Name = "LbInexistente";
            this.LbInexistente.Size = new System.Drawing.Size(66, 14);
            this.LbInexistente.TabIndex = 68;
            this.LbInexistente.TabStop = true;
            this.LbInexistente.Text = "Sin Datos";
            // 
            // TxtDesc_precio
            // 
            // 
            // 
            // 
            this.TxtDesc_precio.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_precio.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_precio.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_precio.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_precio.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_precio.Border.Class = "TextBoxBorder";
            this.TxtDesc_precio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_precio.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDesc_precio.FocusHighlightEnabled = true;
            this.TxtDesc_precio.Location = new System.Drawing.Point(233, 312);
            this.TxtDesc_precio.Name = "TxtDesc_precio";
            this.TxtDesc_precio.Size = new System.Drawing.Size(280, 22);
            this.TxtDesc_precio.TabIndex = 70;
            // 
            // TxtCod_precio
            // 
            // 
            // 
            // 
            this.TxtCod_precio.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_precio.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_precio.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_precio.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_precio.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_precio.Border.Class = "TextBoxBorder";
            this.TxtCod_precio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_precio.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_precio.FocusHighlightEnabled = true;
            this.TxtCod_precio.Location = new System.Drawing.Point(115, 312);
            this.TxtCod_precio.Name = "TxtCod_precio";
            this.TxtCod_precio.Size = new System.Drawing.Size(115, 22);
            this.TxtCod_precio.TabIndex = 69;
            this.TxtCod_precio.DoubleClick += new System.EventHandler(this.TxtCod_precio_DoubleClick);
            this.TxtCod_precio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCod_precio_KeyDown);
            // 
            // TxtDesc_deposito
            // 
            // 
            // 
            // 
            this.TxtDesc_deposito.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_deposito.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_deposito.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_deposito.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_deposito.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_deposito.Border.Class = "TextBoxBorder";
            this.TxtDesc_deposito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_deposito.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDesc_deposito.FocusHighlightEnabled = true;
            this.TxtDesc_deposito.Location = new System.Drawing.Point(233, 285);
            this.TxtDesc_deposito.Name = "TxtDesc_deposito";
            this.TxtDesc_deposito.Size = new System.Drawing.Size(280, 22);
            this.TxtDesc_deposito.TabIndex = 72;
            // 
            // TxtCod_deposito
            // 
            // 
            // 
            // 
            this.TxtCod_deposito.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_deposito.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_deposito.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_deposito.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_deposito.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_deposito.Border.Class = "TextBoxBorder";
            this.TxtCod_deposito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_deposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_deposito.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_deposito.FocusHighlightEnabled = true;
            this.TxtCod_deposito.Location = new System.Drawing.Point(115, 285);
            this.TxtCod_deposito.Name = "TxtCod_deposito";
            this.TxtCod_deposito.Size = new System.Drawing.Size(115, 22);
            this.TxtCod_deposito.TabIndex = 71;
            this.TxtCod_deposito.DoubleClick += new System.EventHandler(this.TxtCod_deposito_DoubleClick);
            this.TxtCod_deposito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCod_deposito_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tipo de Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 74;
            this.label2.Text = "Deposito:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.AllowEmptyState = false;
            // 
            // 
            // 
            this.TxtMonto.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtMonto.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtMonto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtMonto.DisplayFormat = "N2";
            this.TxtMonto.Increment = 1D;
            this.TxtMonto.Location = new System.Drawing.Point(338, 339);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(175, 22);
            this.TxtMonto.TabIndex = 75;
            // 
            // ChkVenc_precio
            // 
            this.ChkVenc_precio.AutoSize = true;
            this.ChkVenc_precio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkVenc_precio.Location = new System.Drawing.Point(11, 341);
            this.ChkVenc_precio.Name = "ChkVenc_precio";
            this.ChkVenc_precio.Size = new System.Drawing.Size(198, 18);
            this.ChkVenc_precio.TabIndex = 76;
            this.ChkVenc_precio.Text = "Aplica Vencimineto de Precio";
            this.ChkVenc_precio.UseVisualStyleBackColor = true;
            this.ChkVenc_precio.CheckedChanged += new System.EventHandler(this.ChkVenc_precio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 77;
            this.label3.Text = "Precio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(287, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 14);
            this.label15.TabIndex = 78;
            this.label15.Text = "Vence:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 80;
            this.label4.Text = "Registro:";
            // 
            // TxtFecha_reg
            // 
            this.TxtFecha_reg.AllowEmptyState = false;
            this.TxtFecha_reg.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtFecha_reg.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_reg.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtFecha_reg.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_reg.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_reg.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_reg.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtFecha_reg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_reg.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.TxtFecha_reg.ButtonDropDown.Visible = true;
            this.TxtFecha_reg.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.TxtFecha_reg.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.TxtFecha_reg.IsPopupCalendarOpen = false;
            this.TxtFecha_reg.Location = new System.Drawing.Point(78, 367);
            // 
            // 
            // 
            // 
            // 
            // 
            this.TxtFecha_reg.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_reg.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.TxtFecha_reg.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.TxtFecha_reg.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_reg.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.TxtFecha_reg.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.TxtFecha_reg.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.TxtFecha_reg.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.TxtFecha_reg.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_reg.MonthCalendar.TodayButtonVisible = true;
            this.TxtFecha_reg.Name = "TxtFecha_reg";
            this.TxtFecha_reg.Size = new System.Drawing.Size(175, 22);
            this.TxtFecha_reg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TxtFecha_reg.TabIndex = 81;
            this.TxtFecha_reg.Value = new System.DateTime(2018, 5, 21, 21, 52, 18, 387);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(8, 266);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(505, 18);
            this.line1.StartLineCapSize = new System.Drawing.Size(10, 10);
            this.line1.TabIndex = 83;
            this.line1.Text = "line1";
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkEliminar.Location = new System.Drawing.Point(11, 251);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(70, 18);
            this.ChkEliminar.TabIndex = 82;
            this.ChkEliminar.Text = "Eliminar";
            this.ChkEliminar.UseVisualStyleBackColor = true;
            this.ChkEliminar.CheckedChanged += new System.EventHandler(this.ChkEliminar_CheckedChanged);
            // 
            // TxtVenc_precio
            // 
            // 
            // 
            // 
            this.TxtVenc_precio.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtVenc_precio.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtVenc_precio.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtVenc_precio.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtVenc_precio.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtVenc_precio.Border.Class = "TextBoxBorder";
            this.TxtVenc_precio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtVenc_precio.DisabledBackColor = System.Drawing.Color.White;
            this.TxtVenc_precio.FocusHighlightEnabled = true;
            this.TxtVenc_precio.Location = new System.Drawing.Point(554, 301);
            this.TxtVenc_precio.Name = "TxtVenc_precio";
            this.TxtVenc_precio.Size = new System.Drawing.Size(62, 22);
            this.TxtVenc_precio.TabIndex = 85;
            this.TxtVenc_precio.TextChanged += new System.EventHandler(this.TxtVenc_precio_TextChanged);
            // 
            // TxtEditar
            // 
            // 
            // 
            // 
            this.TxtEditar.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEditar.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtEditar.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEditar.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEditar.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEditar.Border.Class = "TextBoxBorder";
            this.TxtEditar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtEditar.DisabledBackColor = System.Drawing.Color.White;
            this.TxtEditar.FocusHighlightEnabled = true;
            this.TxtEditar.Location = new System.Drawing.Point(554, 344);
            this.TxtEditar.Name = "TxtEditar";
            this.TxtEditar.Size = new System.Drawing.Size(62, 22);
            this.TxtEditar.TabIndex = 86;
            this.TxtEditar.TextChanged += new System.EventHandler(this.TxtEditar_TextChanged);
            // 
            // ErrorTexto
            // 
            this.ErrorTexto.BlinkRate = 300;
            this.ErrorTexto.ContainerControl = this;
            // 
            // TxtFecha_venc
            // 
            this.TxtFecha_venc.AllowEmptyState = false;
            this.TxtFecha_venc.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtFecha_venc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_venc.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtFecha_venc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_venc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_venc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_venc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtFecha_venc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_venc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.TxtFecha_venc.ButtonDropDown.Visible = true;
            this.TxtFecha_venc.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.TxtFecha_venc.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.TxtFecha_venc.IsPopupCalendarOpen = false;
            this.TxtFecha_venc.Location = new System.Drawing.Point(338, 367);
            // 
            // 
            // 
            // 
            // 
            // 
            this.TxtFecha_venc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_venc.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.TxtFecha_venc.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.TxtFecha_venc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_venc.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.TxtFecha_venc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.TxtFecha_venc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.TxtFecha_venc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.TxtFecha_venc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFecha_venc.MonthCalendar.TodayButtonVisible = true;
            this.TxtFecha_venc.Name = "TxtFecha_venc";
            this.TxtFecha_venc.Size = new System.Drawing.Size(175, 22);
            this.TxtFecha_venc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TxtFecha_venc.TabIndex = 87;
            this.TxtFecha_venc.Value = new System.DateTime(2018, 5, 21, 21, 52, 18, 387);
            // 
            // TxtCod_depositov
            // 
            // 
            // 
            // 
            this.TxtCod_depositov.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_depositov.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_depositov.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_depositov.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_depositov.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_depositov.Border.Class = "TextBoxBorder";
            this.TxtCod_depositov.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_depositov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_depositov.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_depositov.FocusHighlightEnabled = true;
            this.TxtCod_depositov.Location = new System.Drawing.Point(554, 201);
            this.TxtCod_depositov.Name = "TxtCod_depositov";
            this.TxtCod_depositov.Size = new System.Drawing.Size(115, 22);
            this.TxtCod_depositov.TabIndex = 89;
            // 
            // TxtCod_preciov
            // 
            // 
            // 
            // 
            this.TxtCod_preciov.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_preciov.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_preciov.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_preciov.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_preciov.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_preciov.Border.Class = "TextBoxBorder";
            this.TxtCod_preciov.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_preciov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_preciov.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_preciov.FocusHighlightEnabled = true;
            this.TxtCod_preciov.Location = new System.Drawing.Point(554, 228);
            this.TxtCod_preciov.Name = "TxtCod_preciov";
            this.TxtCod_preciov.Size = new System.Drawing.Size(115, 22);
            this.TxtCod_preciov.TabIndex = 88;
            // 
            // TxtCod_articulov
            // 
            // 
            // 
            // 
            this.TxtCod_articulov.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulov.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_articulov.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulov.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulov.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulov.Border.Class = "TextBoxBorder";
            this.TxtCod_articulov.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_articulov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_articulov.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_articulov.Enabled = false;
            this.TxtCod_articulov.FocusHighlightEnabled = true;
            this.TxtCod_articulov.Location = new System.Drawing.Point(554, 173);
            this.TxtCod_articulov.Name = "TxtCod_articulov";
            this.TxtCod_articulov.Size = new System.Drawing.Size(115, 22);
            this.TxtCod_articulov.TabIndex = 90;
            // 
            // FArtPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(521, 466);
            this.Controls.Add(this.TxtCod_articulov);
            this.Controls.Add(this.TxtCod_depositov);
            this.Controls.Add(this.TxtCod_preciov);
            this.Controls.Add(this.TxtFecha_venc);
            this.Controls.Add(this.TxtEditar);
            this.Controls.Add(this.TxtVenc_precio);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFecha_reg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChkVenc_precio);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDesc_deposito);
            this.Controls.Add(this.TxtCod_deposito);
            this.Controls.Add(this.TxtDesc_precio);
            this.Controls.Add(this.TxtCod_precio);
            this.Controls.Add(this.LbInexistente);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.TxtDesc_articulo);
            this.Controls.Add(this.TxtCod_articulo);
            this.Controls.Add(this.ChkEliminar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FArtPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtPrecio";
            this.Load += new System.EventHandler(this.FArtPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_venc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_articulo;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_articulo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem LbTotalReg;
        private System.Windows.Forms.LinkLabel LbInexistente;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_precio;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_precio;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_deposito;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_deposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DoubleInput TxtMonto;
        private System.Windows.Forms.CheckBox ChkVenc_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput TxtFecha_reg;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.CheckBox ChkEliminar;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtVenc_precio;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtEditar;
        private System.Windows.Forms.ErrorProvider ErrorTexto;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput TxtFecha_venc;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_articulov;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_depositov;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_preciov;
    }
}