namespace Presentacion.ModuloBanco
{
    partial class FChequeraDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LbTotalReg = new DevComponents.DotNetBar.LabelItem();
            this.TxtEditar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ChkAnular = new System.Windows.Forms.CheckBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LbInexistente = new System.Windows.Forms.LinkLabel();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.RbAnul = new System.Windows.Forms.RadioButton();
            this.RbDisp = new System.Windows.Forms.RadioButton();
            this.RbEmitidos = new System.Windows.Forms.RadioButton();
            this.RbTodos = new System.Windows.Forms.RadioButton();
            this.TxtDesc_banco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_chequera = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_cuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnGenerarCheq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDesc_cuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumcheque = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_banco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCantidad = new DevComponents.Editors.DoubleInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumcuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
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
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 463);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(724, 22);
            this.metroStatusBar1.TabIndex = 65;
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
            this.LbTotalReg.Text = "0";
            // 
            // TxtEditar
            // 
            this.TxtEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.TxtEditar.Location = new System.Drawing.Point(391, 434);
            this.TxtEditar.Name = "TxtEditar";
            this.TxtEditar.Size = new System.Drawing.Size(72, 22);
            this.TxtEditar.TabIndex = 104;
            // 
            // ChkAnular
            // 
            this.ChkAnular.AutoSize = true;
            this.ChkAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkAnular.Location = new System.Drawing.Point(12, 436);
            this.ChkAnular.Name = "ChkAnular";
            this.ChkAnular.Size = new System.Drawing.Size(63, 18);
            this.ChkAnular.TabIndex = 103;
            this.ChkAnular.Text = "Anular";
            this.ChkAnular.UseVisualStyleBackColor = true;
            this.ChkAnular.CheckedChanged += new System.EventHandler(this.ChkAnular_CheckedChanged);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(559, 433);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 25);
            this.BtnAceptar.TabIndex = 101;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(640, 433);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 25);
            this.BtnCancelar.TabIndex = 100;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LbInexistente
            // 
            this.LbInexistente.AutoSize = true;
            this.LbInexistente.Location = new System.Drawing.Point(326, 282);
            this.LbInexistente.Name = "LbInexistente";
            this.LbInexistente.Size = new System.Drawing.Size(88, 14);
            this.LbInexistente.TabIndex = 102;
            this.LbInexistente.TabStop = true;
            this.LbInexistente.Text = "Sin Registros";
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnular.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnular.Location = new System.Drawing.Point(81, 433);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(75, 25);
            this.BtnAnular.TabIndex = 99;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 98;
            this.label5.Text = "Estatus:";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.TopToBottom;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.RbAnul);
            this.expandablePanel1.Controls.Add(this.RbDisp);
            this.expandablePanel1.Controls.Add(this.RbEmitidos);
            this.expandablePanel1.Controls.Add(this.RbTodos);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(77, 67);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(534, 30);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 97;
            this.expandablePanel1.TitleHeight = 0;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.expandablePanel1.TitleStyle.CornerDiameter = 20;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Title Bar";
            // 
            // RbAnul
            // 
            this.RbAnul.AutoSize = true;
            this.RbAnul.BackColor = System.Drawing.Color.Transparent;
            this.RbAnul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbAnul.Location = new System.Drawing.Point(450, 7);
            this.RbAnul.Name = "RbAnul";
            this.RbAnul.Size = new System.Drawing.Size(81, 18);
            this.RbAnul.TabIndex = 7;
            this.RbAnul.TabStop = true;
            this.RbAnul.Text = "Anulados";
            this.RbAnul.UseVisualStyleBackColor = false;
            this.RbAnul.CheckedChanged += new System.EventHandler(this.RbAnul_CheckedChanged);
            // 
            // RbDisp
            // 
            this.RbDisp.AutoSize = true;
            this.RbDisp.BackColor = System.Drawing.Color.Transparent;
            this.RbDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbDisp.Location = new System.Drawing.Point(139, 7);
            this.RbDisp.Name = "RbDisp";
            this.RbDisp.Size = new System.Drawing.Size(93, 18);
            this.RbDisp.TabIndex = 6;
            this.RbDisp.TabStop = true;
            this.RbDisp.Text = "Disponibles";
            this.RbDisp.UseVisualStyleBackColor = false;
            this.RbDisp.CheckedChanged += new System.EventHandler(this.RbDisp_CheckedChanged);
            // 
            // RbEmitidos
            // 
            this.RbEmitidos.AutoSize = true;
            this.RbEmitidos.BackColor = System.Drawing.Color.Transparent;
            this.RbEmitidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbEmitidos.Location = new System.Drawing.Point(303, 7);
            this.RbEmitidos.Name = "RbEmitidos";
            this.RbEmitidos.Size = new System.Drawing.Size(76, 18);
            this.RbEmitidos.TabIndex = 5;
            this.RbEmitidos.TabStop = true;
            this.RbEmitidos.Text = "Emitidos";
            this.RbEmitidos.UseVisualStyleBackColor = false;
            this.RbEmitidos.CheckedChanged += new System.EventHandler(this.RbEmitidos_CheckedChanged);
            // 
            // RbTodos
            // 
            this.RbTodos.AutoSize = true;
            this.RbTodos.BackColor = System.Drawing.Color.Transparent;
            this.RbTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbTodos.Location = new System.Drawing.Point(7, 7);
            this.RbTodos.Name = "RbTodos";
            this.RbTodos.Size = new System.Drawing.Size(61, 18);
            this.RbTodos.TabIndex = 4;
            this.RbTodos.TabStop = true;
            this.RbTodos.Text = "Todos";
            this.RbTodos.UseVisualStyleBackColor = false;
            this.RbTodos.CheckedChanged += new System.EventHandler(this.RbTodos_CheckedChanged);
            // 
            // TxtDesc_banco
            // 
            this.TxtDesc_banco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtDesc_banco.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_banco.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_banco.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_banco.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_banco.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_banco.Border.Class = "TextBoxBorder";
            this.TxtDesc_banco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_banco.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDesc_banco.Enabled = false;
            this.TxtDesc_banco.FocusHighlightEnabled = true;
            this.TxtDesc_banco.Location = new System.Drawing.Point(440, 4);
            this.TxtDesc_banco.Name = "TxtDesc_banco";
            this.TxtDesc_banco.Size = new System.Drawing.Size(275, 22);
            this.TxtDesc_banco.TabIndex = 87;
            // 
            // TxtCod_chequera
            // 
            this.TxtCod_chequera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtCod_chequera.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_chequera.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_chequera.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_chequera.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_chequera.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_chequera.Border.Class = "TextBoxBorder";
            this.TxtCod_chequera.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_chequera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_chequera.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_chequera.Enabled = false;
            this.TxtCod_chequera.FocusHighlightEnabled = true;
            this.TxtCod_chequera.Location = new System.Drawing.Point(77, 36);
            this.TxtCod_chequera.Name = "TxtCod_chequera";
            this.TxtCod_chequera.Size = new System.Drawing.Size(72, 22);
            this.TxtCod_chequera.TabIndex = 83;
            // 
            // TxtCod_cuenta
            // 
            this.TxtCod_cuenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtCod_cuenta.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_cuenta.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_cuenta.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_cuenta.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_cuenta.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_cuenta.Border.Class = "TextBoxBorder";
            this.TxtCod_cuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_cuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_cuenta.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_cuenta.Enabled = false;
            this.TxtCod_cuenta.FocusHighlightEnabled = true;
            this.TxtCod_cuenta.Location = new System.Drawing.Point(77, 4);
            this.TxtCod_cuenta.Name = "TxtCod_cuenta";
            this.TxtCod_cuenta.ReadOnly = true;
            this.TxtCod_cuenta.Size = new System.Drawing.Size(72, 22);
            this.TxtCod_cuenta.TabIndex = 84;
            // 
            // BtnGenerarCheq
            // 
            this.BtnGenerarCheq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnGenerarCheq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnGenerarCheq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarCheq.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BtnGenerarCheq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGenerarCheq.Location = new System.Drawing.Point(629, 70);
            this.BtnGenerarCheq.Name = "BtnGenerarCheq";
            this.BtnGenerarCheq.Size = new System.Drawing.Size(86, 25);
            this.BtnGenerarCheq.TabIndex = 96;
            this.BtnGenerarCheq.Text = "Generar";
            this.BtnGenerarCheq.UseVisualStyleBackColor = false;
            this.BtnGenerarCheq.Click += new System.EventHandler(this.BtnGenerarCheq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 94;
            this.label4.Text = "Primer Cheque:";
            // 
            // TxtDesc_cuenta
            // 
            this.TxtDesc_cuenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtDesc_cuenta.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_cuenta.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_cuenta.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_cuenta.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_cuenta.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_cuenta.Border.Class = "TextBoxBorder";
            this.TxtDesc_cuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_cuenta.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDesc_cuenta.Enabled = false;
            this.TxtDesc_cuenta.FocusHighlightEnabled = true;
            this.TxtDesc_cuenta.Location = new System.Drawing.Point(151, 4);
            this.TxtDesc_cuenta.Name = "TxtDesc_cuenta";
            this.TxtDesc_cuenta.Size = new System.Drawing.Size(201, 22);
            this.TxtDesc_cuenta.TabIndex = 85;
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListado.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListado.Location = new System.Drawing.Point(7, 106);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersWidth = 25;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(708, 321);
            this.DataListado.TabIndex = 82;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 93;
            this.label3.Text = "Chequera:";
            // 
            // TxtNumcheque
            // 
            this.TxtNumcheque.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtNumcheque.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcheque.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtNumcheque.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcheque.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcheque.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcheque.Border.Class = "TextBoxBorder";
            this.TxtNumcheque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNumcheque.DisabledBackColor = System.Drawing.Color.White;
            this.TxtNumcheque.FocusHighlightEnabled = true;
            this.TxtNumcheque.Location = new System.Drawing.Point(469, 36);
            this.TxtNumcheque.Name = "TxtNumcheque";
            this.TxtNumcheque.Size = new System.Drawing.Size(100, 22);
            this.TxtNumcheque.TabIndex = 90;
            // 
            // TxtCod_banco
            // 
            this.TxtCod_banco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtCod_banco.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_banco.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_banco.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_banco.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_banco.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_banco.Border.Class = "TextBoxBorder";
            this.TxtCod_banco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_banco.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCod_banco.Enabled = false;
            this.TxtCod_banco.FocusHighlightEnabled = true;
            this.TxtCod_banco.Location = new System.Drawing.Point(355, 4);
            this.TxtCod_banco.Name = "TxtCod_banco";
            this.TxtCod_banco.ReadOnly = true;
            this.TxtCod_banco.Size = new System.Drawing.Size(82, 22);
            this.TxtCod_banco.TabIndex = 86;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.AllowEmptyState = false;
            // 
            // 
            // 
            this.TxtCantidad.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCantidad.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCantidad.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCantidad.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCantidad.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCantidad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtCantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCantidad.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtCantidad.DisplayFormat = "N0";
            this.TxtCantidad.Increment = 1D;
            this.TxtCantidad.Location = new System.Drawing.Point(645, 36);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.ShowUpDown = true;
            this.TxtCantidad.Size = new System.Drawing.Size(70, 22);
            this.TxtCantidad.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 92;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 91;
            this.label1.Text = "Cuenta:";
            // 
            // TxtNumcuenta
            // 
            this.TxtNumcuenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.TxtNumcuenta.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcuenta.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtNumcuenta.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcuenta.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcuenta.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumcuenta.Border.Class = "TextBoxBorder";
            this.TxtNumcuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNumcuenta.DisabledBackColor = System.Drawing.Color.White;
            this.TxtNumcuenta.Enabled = false;
            this.TxtNumcuenta.FocusHighlightEnabled = true;
            this.TxtNumcuenta.Location = new System.Drawing.Point(151, 36);
            this.TxtNumcuenta.Name = "TxtNumcuenta";
            this.TxtNumcuenta.ReadOnly = true;
            this.TxtNumcuenta.Size = new System.Drawing.Size(201, 22);
            this.TxtNumcuenta.TabIndex = 88;
            // 
            // FChequeraDetalle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(724, 485);
            this.Controls.Add(this.TxtEditar);
            this.Controls.Add(this.ChkAnular);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LbInexistente);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.TxtDesc_banco);
            this.Controls.Add(this.TxtCod_chequera);
            this.Controls.Add(this.TxtCod_cuenta);
            this.Controls.Add(this.BtnGenerarCheq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDesc_cuenta);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNumcheque);
            this.Controls.Add(this.TxtCod_banco);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumcuenta);
            this.Controls.Add(this.metroStatusBar1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FChequeraDetalle";
            this.Text = "FChequeraDetalle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FChequeraDetalle_FormClosing);
            this.Load += new System.EventHandler(this.FChequeraDetalle_Load);
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem LbTotalReg;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtEditar;
        private System.Windows.Forms.CheckBox ChkAnular;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.LinkLabel LbInexistente;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.RadioButton RbAnul;
        private System.Windows.Forms.RadioButton RbDisp;
        private System.Windows.Forms.RadioButton RbEmitidos;
        private System.Windows.Forms.RadioButton RbTodos;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_banco;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_chequera;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_cuenta;
        private System.Windows.Forms.Button BtnGenerarCheq;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_cuenta;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtNumcheque;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_banco;
        internal DevComponents.Editors.DoubleInput TxtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtNumcuenta;
    }
}