namespace Presentacion.ModuloConfig
{
    partial class FImpuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataListado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Op = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtFecha_reg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCampo6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCampo5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCampo4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCampo3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCampo2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCampo1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtEditar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LbTotalReg = new DevComponents.DotNetBar.LabelItem();
            this.TxtCod_usuario = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.TxtDesc_usuario = new DevComponents.DotNetBar.LabelItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(526, 288);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DataListado);
            this.tabPage1.Controls.Add(this.TxtFecha_reg);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(518, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Op});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListado.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListado.Location = new System.Drawing.Point(7, 42);
            this.DataListado.Name = "DataListado";
            this.DataListado.PaintEnhancedSelection = false;
            this.DataListado.RowHeadersVisible = false;
            this.DataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataListado.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(504, 176);
            this.DataListado.TabIndex = 43;
            this.DataListado.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataListado_CellBeginEdit);
            this.DataListado.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellEndEdit);
            // 
            // Op
            // 
            this.Op.HeaderText = "Op";
            this.Op.Name = "Op";
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
            this.TxtFecha_reg.Location = new System.Drawing.Point(331, 6);
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
            this.TxtFecha_reg.Size = new System.Drawing.Size(179, 22);
            this.TxtFecha_reg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TxtFecha_reg.TabIndex = 42;
            this.TxtFecha_reg.Value = new System.DateTime(2018, 5, 24, 23, 49, 39, 0);
            this.TxtFecha_reg.ValueChanged += new System.EventHandler(this.TxtFecha_reg_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtCampo6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtCampo5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TxtCampo4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TxtCampo3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtCampo2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TxtCampo1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adicional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Campo 6:";
            // 
            // TxtCampo6
            // 
            // 
            // 
            // 
            this.TxtCampo6.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo6.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCampo6.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo6.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo6.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo6.Border.Class = "TextBoxBorder";
            this.TxtCampo6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCampo6.FocusHighlightEnabled = true;
            this.TxtCampo6.Location = new System.Drawing.Point(337, 120);
            this.TxtCampo6.Name = "TxtCampo6";
            this.TxtCampo6.Size = new System.Drawing.Size(174, 22);
            this.TxtCampo6.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Campo 5:";
            // 
            // TxtCampo5
            // 
            // 
            // 
            // 
            this.TxtCampo5.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo5.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCampo5.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo5.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo5.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo5.Border.Class = "TextBoxBorder";
            this.TxtCampo5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCampo5.FocusHighlightEnabled = true;
            this.TxtCampo5.Location = new System.Drawing.Point(79, 120);
            this.TxtCampo5.Name = "TxtCampo5";
            this.TxtCampo5.Size = new System.Drawing.Size(174, 22);
            this.TxtCampo5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Campo 4:";
            // 
            // TxtCampo4
            // 
            // 
            // 
            // 
            this.TxtCampo4.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo4.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCampo4.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo4.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo4.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo4.Border.Class = "TextBoxBorder";
            this.TxtCampo4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCampo4.FocusHighlightEnabled = true;
            this.TxtCampo4.Location = new System.Drawing.Point(337, 66);
            this.TxtCampo4.Name = "TxtCampo4";
            this.TxtCampo4.Size = new System.Drawing.Size(174, 22);
            this.TxtCampo4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Campo 3:";
            // 
            // TxtCampo3
            // 
            // 
            // 
            // 
            this.TxtCampo3.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo3.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCampo3.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo3.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo3.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo3.Border.Class = "TextBoxBorder";
            this.TxtCampo3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCampo3.FocusHighlightEnabled = true;
            this.TxtCampo3.Location = new System.Drawing.Point(79, 66);
            this.TxtCampo3.Name = "TxtCampo3";
            this.TxtCampo3.Size = new System.Drawing.Size(174, 22);
            this.TxtCampo3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Campo 2:";
            // 
            // TxtCampo2
            // 
            // 
            // 
            // 
            this.TxtCampo2.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo2.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCampo2.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo2.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo2.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo2.Border.Class = "TextBoxBorder";
            this.TxtCampo2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCampo2.FocusHighlightEnabled = true;
            this.TxtCampo2.Location = new System.Drawing.Point(337, 14);
            this.TxtCampo2.Name = "TxtCampo2";
            this.TxtCampo2.Size = new System.Drawing.Size(174, 22);
            this.TxtCampo2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Campo 1:";
            // 
            // TxtCampo1
            // 
            // 
            // 
            // 
            this.TxtCampo1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo1.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCampo1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCampo1.Border.Class = "TextBoxBorder";
            this.TxtCampo1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCampo1.FocusHighlightEnabled = true;
            this.TxtCampo1.Location = new System.Drawing.Point(79, 14);
            this.TxtCampo1.Name = "TxtCampo1";
            this.TxtCampo1.Size = new System.Drawing.Size(174, 22);
            this.TxtCampo1.TabIndex = 4;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.BtnImprimir.Location = new System.Drawing.Point(470, 12);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(44, 41);
            this.BtnImprimir.TabIndex = 32;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Image = global::Presentacion.Properties.Resources.Cancelar;
            this.BtnCancelar.Location = new System.Drawing.Point(97, 8);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(44, 41);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Image = global::Presentacion.Properties.Resources.Aceptar;
            this.BtnAceptar.Location = new System.Drawing.Point(27, 8);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(44, 41);
            this.BtnAceptar.TabIndex = 26;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.TxtEditar.Location = new System.Drawing.Point(258, 19);
            this.TxtEditar.Name = "TxtEditar";
            this.TxtEditar.Size = new System.Drawing.Size(82, 22);
            this.TxtEditar.TabIndex = 16;
            this.TxtEditar.Visible = false;
            this.TxtEditar.TextChanged += new System.EventHandler(this.TxtEditar_TextChanged);
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
            this.LbTotalReg,
            this.TxtCod_usuario,
            this.labelItem4,
            this.TxtDesc_usuario});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 347);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(526, 22);
            this.metroStatusBar1.TabIndex = 33;
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
            // TxtCod_usuario
            // 
            this.TxtCod_usuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod_usuario.ForeColor = System.Drawing.Color.White;
            this.TxtCod_usuario.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.TxtCod_usuario.Name = "TxtCod_usuario";
            this.TxtCod_usuario.Text = "0";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 14);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha de Aplicacion Fiscal:";
            // 
            // FImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.TxtEditar);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FImpuesto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FImpuesto_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FImpuesto_FormClosed);
            this.Load += new System.EventHandler(this.FImpuesto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCampo6;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCampo5;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCampo4;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCampo3;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCampo2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCampo1;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput TxtFecha_reg;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Op;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtEditar;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem LbTotalReg;
        private DevComponents.DotNetBar.LabelItem TxtCod_usuario;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem TxtDesc_usuario;
        private System.Windows.Forms.Label label1;
    }
}