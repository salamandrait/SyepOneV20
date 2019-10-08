namespace Presentacion.ModuloInventario
{
    partial class FArtUnidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LbTotalReg = new DevComponents.DotNetBar.LabelItem();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtDesc_articulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_articulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ChkEliminar = new System.Windows.Forms.CheckBox();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.TxtEditar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtEsprincipal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtEquivalencia = new DevComponents.Editors.DoubleInput();
            this.ChkEsprincipal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtFecha_reg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.TxtDesc_unidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_unidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbInexistente = new System.Windows.Forms.LinkLabel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.ErrorTexto = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtCod_unidadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_articulov = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEquivalencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTexto)).BeginInit();
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
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 364);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(455, 22);
            this.metroStatusBar1.TabIndex = 2;
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
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.BtnEliminar.Location = new System.Drawing.Point(305, 315);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(35, 35);
            this.BtnEliminar.TabIndex = 24;
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
            this.BtnNuevo.Location = new System.Drawing.Point(158, 315);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(35, 35);
            this.BtnNuevo.TabIndex = 25;
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
            this.BtnCancelar.Location = new System.Drawing.Point(85, 315);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(35, 35);
            this.BtnCancelar.TabIndex = 23;
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
            this.BtnAceptar.Location = new System.Drawing.Point(12, 315);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(35, 35);
            this.BtnAceptar.TabIndex = 22;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtDesc_articulo
            // 
            this.TxtDesc_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
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
            this.TxtDesc_articulo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TxtDesc_articulo.Enabled = false;
            this.TxtDesc_articulo.FocusHighlightEnabled = true;
            this.TxtDesc_articulo.Location = new System.Drawing.Point(132, 8);
            this.TxtDesc_articulo.Name = "TxtDesc_articulo";
            this.TxtDesc_articulo.ReadOnly = true;
            this.TxtDesc_articulo.Size = new System.Drawing.Size(316, 22);
            this.TxtDesc_articulo.TabIndex = 27;
            // 
            // TxtCod_articulo
            // 
            this.TxtCod_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
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
            this.TxtCod_articulo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TxtCod_articulo.Enabled = false;
            this.TxtCod_articulo.FocusHighlightEnabled = true;
            this.TxtCod_articulo.Location = new System.Drawing.Point(7, 8);
            this.TxtCod_articulo.Name = "TxtCod_articulo";
            this.TxtCod_articulo.ReadOnly = true;
            this.TxtCod_articulo.Size = new System.Drawing.Size(123, 22);
            this.TxtCod_articulo.TabIndex = 26;
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkEliminar.Location = new System.Drawing.Point(9, 226);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(70, 18);
            this.ChkEliminar.TabIndex = 58;
            this.ChkEliminar.Text = "Eliminar";
            this.ChkEliminar.UseVisualStyleBackColor = true;
            this.ChkEliminar.CheckedChanged += new System.EventHandler(this.ChkEliminar_CheckedChanged);
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListado.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListado.Location = new System.Drawing.Point(7, 36);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersWidth = 25;
            this.DataListado.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(441, 183);
            this.DataListado.TabIndex = 57;
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
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(7, 240);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(441, 10);
            this.line1.TabIndex = 70;
            this.line1.Text = "line1";
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
            this.TxtEditar.FocusHighlightEnabled = true;
            this.TxtEditar.Location = new System.Drawing.Point(520, 328);
            this.TxtEditar.Name = "TxtEditar";
            this.TxtEditar.Size = new System.Drawing.Size(102, 22);
            this.TxtEditar.TabIndex = 68;
            this.TxtEditar.TextChanged += new System.EventHandler(this.TxtEditar_TextChanged);
            // 
            // TxtEsprincipal
            // 
            // 
            // 
            // 
            this.TxtEsprincipal.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsprincipal.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtEsprincipal.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsprincipal.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsprincipal.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsprincipal.Border.Class = "TextBoxBorder";
            this.TxtEsprincipal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtEsprincipal.FocusHighlightEnabled = true;
            this.TxtEsprincipal.Location = new System.Drawing.Point(520, 284);
            this.TxtEsprincipal.Name = "TxtEsprincipal";
            this.TxtEsprincipal.Size = new System.Drawing.Size(34, 22);
            this.TxtEsprincipal.TabIndex = 67;
            this.TxtEsprincipal.TextChanged += new System.EventHandler(this.TxtEsprincipal_TextChanged);
            // 
            // TxtEquivalencia
            // 
            this.TxtEquivalencia.AllowEmptyState = false;
            // 
            // 
            // 
            this.TxtEquivalencia.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEquivalencia.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtEquivalencia.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEquivalencia.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEquivalencia.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEquivalencia.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtEquivalencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtEquivalencia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtEquivalencia.DisplayFormat = "N2";
            this.TxtEquivalencia.Increment = 1D;
            this.TxtEquivalencia.Location = new System.Drawing.Point(383, 256);
            this.TxtEquivalencia.Name = "TxtEquivalencia";
            this.TxtEquivalencia.Size = new System.Drawing.Size(65, 22);
            this.TxtEquivalencia.TabIndex = 66;
            // 
            // ChkEsprincipal
            // 
            this.ChkEsprincipal.AutoSize = true;
            this.ChkEsprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkEsprincipal.Location = new System.Drawing.Point(9, 284);
            this.ChkEsprincipal.Name = "ChkEsprincipal";
            this.ChkEsprincipal.Size = new System.Drawing.Size(118, 18);
            this.ChkEsprincipal.TabIndex = 65;
            this.ChkEsprincipal.Text = "Unidad Primaria";
            this.ChkEsprincipal.UseVisualStyleBackColor = true;
            this.ChkEsprincipal.CheckedChanged += new System.EventHandler(this.ChkEsprincipal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 64;
            this.label1.Text = "Unidad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(196, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 14);
            this.label15.TabIndex = 62;
            this.label15.Text = "Registro:";
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
            this.TxtFecha_reg.Location = new System.Drawing.Point(273, 282);
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
            this.TxtFecha_reg.TabIndex = 63;
            this.TxtFecha_reg.Value = new System.DateTime(2018, 5, 21, 21, 52, 18, 387);
            // 
            // TxtDesc_unidad
            // 
            // 
            // 
            // 
            this.TxtDesc_unidad.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_unidad.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.Class = "TextBoxBorder";
            this.TxtDesc_unidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_unidad.FocusHighlightEnabled = true;
            this.TxtDesc_unidad.Location = new System.Drawing.Point(177, 256);
            this.TxtDesc_unidad.Name = "TxtDesc_unidad";
            this.TxtDesc_unidad.Size = new System.Drawing.Size(203, 22);
            this.TxtDesc_unidad.TabIndex = 61;
            // 
            // TxtCod_unidad
            // 
            // 
            // 
            // 
            this.TxtCod_unidad.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_unidad.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.Class = "TextBoxBorder";
            this.TxtCod_unidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_unidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_unidad.FocusHighlightEnabled = true;
            this.TxtCod_unidad.Location = new System.Drawing.Point(68, 256);
            this.TxtCod_unidad.Name = "TxtCod_unidad";
            this.TxtCod_unidad.Size = new System.Drawing.Size(107, 22);
            this.TxtCod_unidad.TabIndex = 60;
            this.TxtCod_unidad.DoubleClick += new System.EventHandler(this.TxtCod_unidad_DoubleClick);
            this.TxtCod_unidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCod_unidad_KeyDown);
            // 
            // LbInexistente
            // 
            this.LbInexistente.AutoSize = true;
            this.LbInexistente.BackColor = System.Drawing.Color.DarkGray;
            this.LbInexistente.Location = new System.Drawing.Point(213, 117);
            this.LbInexistente.Name = "LbInexistente";
            this.LbInexistente.Size = new System.Drawing.Size(66, 14);
            this.LbInexistente.TabIndex = 71;
            this.LbInexistente.TabStop = true;
            this.LbInexistente.Text = "Sin Datos";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(231, 314);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(36, 36);
            this.BtnEditar.TabIndex = 72;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ErrorTexto
            // 
            this.ErrorTexto.BlinkRate = 300;
            this.ErrorTexto.ContainerControl = this;
            // 
            // TxtCod_unidadv
            // 
            // 
            // 
            // 
            this.TxtCod_unidadv.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidadv.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_unidadv.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidadv.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidadv.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidadv.Border.Class = "TextBoxBorder";
            this.TxtCod_unidadv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_unidadv.FocusHighlightEnabled = true;
            this.TxtCod_unidadv.Location = new System.Drawing.Point(494, 210);
            this.TxtCod_unidadv.Name = "TxtCod_unidadv";
            this.TxtCod_unidadv.Size = new System.Drawing.Size(102, 22);
            this.TxtCod_unidadv.TabIndex = 73;
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
            this.TxtCod_articulov.FocusHighlightEnabled = true;
            this.TxtCod_articulov.Location = new System.Drawing.Point(494, 182);
            this.TxtCod_articulov.Name = "TxtCod_articulov";
            this.TxtCod_articulov.Size = new System.Drawing.Size(102, 22);
            this.TxtCod_articulov.TabIndex = 74;
            // 
            // FArtUnidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(455, 386);
            this.Controls.Add(this.TxtCod_articulov);
            this.Controls.Add(this.TxtCod_unidadv);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.LbInexistente);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.TxtEditar);
            this.Controls.Add(this.TxtEsprincipal);
            this.Controls.Add(this.TxtEquivalencia);
            this.Controls.Add(this.ChkEsprincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtFecha_reg);
            this.Controls.Add(this.TxtDesc_unidad);
            this.Controls.Add(this.TxtCod_unidad);
            this.Controls.Add(this.ChkEliminar);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.TxtDesc_articulo);
            this.Controls.Add(this.TxtCod_articulo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.metroStatusBar1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FArtUnidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FArtUnidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FArtUnidad_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FArtUnidad_FormClosed);
            this.Load += new System.EventHandler(this.FArtUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEquivalencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem LbTotalReg;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_articulo;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_articulo;
        private System.Windows.Forms.CheckBox ChkEliminar;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtEditar;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtEsprincipal;
        private DevComponents.Editors.DoubleInput TxtEquivalencia;
        private System.Windows.Forms.CheckBox ChkEsprincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput TxtFecha_reg;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_unidad;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_unidad;
        private System.Windows.Forms.LinkLabel LbInexistente;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.ErrorProvider ErrorTexto;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_articulov;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_unidadv;
    }
}