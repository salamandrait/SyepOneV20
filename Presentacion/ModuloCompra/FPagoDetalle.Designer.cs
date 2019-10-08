namespace Presentacion.ModuloCompra
{
    partial class FPagoDetalle
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
            this.TxtForma = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TxtDesc_caja = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_movcaja = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_movbanco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtNumdocpago = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAbono = new DevComponents.Editors.DoubleInput();
            this.TxtMonto = new DevComponents.Editors.DoubleInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtReng = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_pago = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_compra = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtOptipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtSaldo = new DevComponents.Editors.DoubleInput();
            this.TxtEsreteniva = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtEsretenislr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtFecha_reg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.TxtCod_caja = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRetIslr = new System.Windows.Forms.Button();
            this.BtnRetIva = new System.Windows.Forms.Button();
            this.TxtNumdocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDesc_cuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_cuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ErrorTexto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAbono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtForma
            // 
            this.TxtForma.DisplayMember = "Text";
            this.TxtForma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtForma.FormattingEnabled = true;
            this.TxtForma.ItemHeight = 16;
            this.TxtForma.Location = new System.Drawing.Point(115, 12);
            this.TxtForma.Name = "TxtForma";
            this.TxtForma.Size = new System.Drawing.Size(133, 22);
            this.TxtForma.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.TxtForma.TabIndex = 157;
            this.TxtForma.SelectedIndexChanged += new System.EventHandler(this.TxtForma_SelectedIndexChanged);
            // 
            // TxtDesc_caja
            // 
            // 
            // 
            // 
            this.TxtDesc_caja.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_caja.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_caja.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_caja.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_caja.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_caja.Border.Class = "TextBoxBorder";
            this.TxtDesc_caja.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_caja.FocusHighlightEnabled = true;
            this.TxtDesc_caja.Location = new System.Drawing.Point(533, 12);
            this.TxtDesc_caja.Name = "TxtDesc_caja";
            this.TxtDesc_caja.Size = new System.Drawing.Size(249, 22);
            this.TxtDesc_caja.TabIndex = 161;
            // 
            // TxtCod_movcaja
            // 
            // 
            // 
            // 
            this.TxtCod_movcaja.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movcaja.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_movcaja.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movcaja.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movcaja.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movcaja.Border.Class = "TextBoxBorder";
            this.TxtCod_movcaja.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_movcaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_movcaja.FocusHighlightEnabled = true;
            this.TxtCod_movcaja.Location = new System.Drawing.Point(2, 225);
            this.TxtCod_movcaja.Name = "TxtCod_movcaja";
            this.TxtCod_movcaja.Size = new System.Drawing.Size(95, 22);
            this.TxtCod_movcaja.TabIndex = 162;
            // 
            // TxtCod_movbanco
            // 
            this.TxtCod_movbanco.BackColor = System.Drawing.Color.YellowGreen;
            // 
            // 
            // 
            this.TxtCod_movbanco.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movbanco.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_movbanco.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movbanco.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movbanco.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_movbanco.Border.Class = "TextBoxBorder";
            this.TxtCod_movbanco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_movbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod_movbanco.FocusHighlightEnabled = true;
            this.TxtCod_movbanco.Location = new System.Drawing.Point(2, 183);
            this.TxtCod_movbanco.Name = "TxtCod_movbanco";
            this.TxtCod_movbanco.Size = new System.Drawing.Size(95, 22);
            this.TxtCod_movbanco.TabIndex = 163;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 14);
            this.label24.TabIndex = 164;
            this.label24.Text = "Forma de Pago:";
            // 
            // TxtNumdocpago
            // 
            // 
            // 
            // 
            this.TxtNumdocpago.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocpago.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtNumdocpago.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocpago.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocpago.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocpago.Border.Class = "TextBoxBorder";
            this.TxtNumdocpago.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNumdocpago.FocusHighlightEnabled = true;
            this.TxtNumdocpago.Location = new System.Drawing.Point(115, 66);
            this.TxtNumdocpago.Name = "TxtNumdocpago";
            this.TxtNumdocpago.Size = new System.Drawing.Size(133, 22);
            this.TxtNumdocpago.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 166;
            this.label1.Text = "Cuenta/Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 167;
            this.label2.Text = "N° de Pago";
            // 
            // TxtAbono
            // 
            this.TxtAbono.AllowEmptyState = false;
            this.TxtAbono.AutoResolveFreeTextEntries = false;
            // 
            // 
            // 
            this.TxtAbono.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtAbono.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtAbono.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtAbono.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtAbono.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtAbono.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtAbono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtAbono.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtAbono.DisplayFormat = "N2";
            this.TxtAbono.Increment = 1D;
            this.TxtAbono.Location = new System.Drawing.Point(601, 66);
            this.TxtAbono.Name = "TxtAbono";
            this.TxtAbono.Size = new System.Drawing.Size(180, 22);
            this.TxtAbono.TabIndex = 171;
            this.TxtAbono.ValueChanged += new System.EventHandler(this.TxtAbono_ValueChanged);
            // 
            // TxtMonto
            // 
            this.TxtMonto.AllowEmptyState = false;
            this.TxtMonto.AutoOffFreeTextEntry = true;
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
            this.TxtMonto.DisabledForeColor = System.Drawing.Color.DimGray;
            this.TxtMonto.DisplayFormat = "N2";
            this.TxtMonto.Enabled = false;
            this.TxtMonto.Increment = 1D;
            this.TxtMonto.Location = new System.Drawing.Point(601, 39);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(180, 22);
            this.TxtMonto.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 173;
            this.label4.Text = "Total Doc.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 174;
            this.label5.Text = "Abono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 175;
            this.label6.Text = "Saldo:";
            // 
            // TxtReng
            // 
            // 
            // 
            // 
            this.TxtReng.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtReng.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtReng.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtReng.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtReng.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtReng.Border.Class = "TextBoxBorder";
            this.TxtReng.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtReng.FocusHighlightEnabled = true;
            this.TxtReng.Location = new System.Drawing.Point(207, 183);
            this.TxtReng.Name = "TxtReng";
            this.TxtReng.Size = new System.Drawing.Size(91, 22);
            this.TxtReng.TabIndex = 176;
            this.TxtReng.Text = "0";
            // 
            // TxtCod_pago
            // 
            // 
            // 
            // 
            this.TxtCod_pago.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_pago.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_pago.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_pago.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_pago.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_pago.Border.Class = "TextBoxBorder";
            this.TxtCod_pago.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_pago.FocusHighlightEnabled = true;
            this.TxtCod_pago.Location = new System.Drawing.Point(102, 183);
            this.TxtCod_pago.Name = "TxtCod_pago";
            this.TxtCod_pago.Size = new System.Drawing.Size(100, 22);
            this.TxtCod_pago.TabIndex = 177;
            this.TxtCod_pago.Text = "0";
            // 
            // TxtCod_compra
            // 
            // 
            // 
            // 
            this.TxtCod_compra.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_compra.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_compra.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_compra.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_compra.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_compra.Border.Class = "TextBoxBorder";
            this.TxtCod_compra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_compra.FocusHighlightEnabled = true;
            this.TxtCod_compra.Location = new System.Drawing.Point(303, 183);
            this.TxtCod_compra.Name = "TxtCod_compra";
            this.TxtCod_compra.Size = new System.Drawing.Size(91, 22);
            this.TxtCod_compra.TabIndex = 178;
            // 
            // TxtOptipo
            // 
            // 
            // 
            // 
            this.TxtOptipo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtOptipo.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtOptipo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtOptipo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtOptipo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtOptipo.Border.Class = "TextBoxBorder";
            this.TxtOptipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtOptipo.FocusHighlightEnabled = true;
            this.TxtOptipo.Location = new System.Drawing.Point(400, 183);
            this.TxtOptipo.Name = "TxtOptipo";
            this.TxtOptipo.Size = new System.Drawing.Size(91, 22);
            this.TxtOptipo.TabIndex = 180;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.AllowEmptyState = false;
            this.TxtSaldo.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtSaldo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtSaldo.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtSaldo.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtSaldo.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtSaldo.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtSaldo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtSaldo.DisabledForeColor = System.Drawing.Color.DimGray;
            this.TxtSaldo.DisplayFormat = "N2";
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Increment = 1D;
            this.TxtSaldo.Location = new System.Drawing.Point(601, 93);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(180, 22);
            this.TxtSaldo.TabIndex = 181;
            // 
            // TxtEsreteniva
            // 
            // 
            // 
            // 
            this.TxtEsreteniva.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsreteniva.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtEsreteniva.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsreteniva.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsreteniva.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsreteniva.Border.Class = "TextBoxBorder";
            this.TxtEsreteniva.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtEsreteniva.FocusHighlightEnabled = true;
            this.TxtEsreteniva.Location = new System.Drawing.Point(642, 183);
            this.TxtEsreteniva.Name = "TxtEsreteniva";
            this.TxtEsreteniva.Size = new System.Drawing.Size(91, 22);
            this.TxtEsreteniva.TabIndex = 183;
            // 
            // TxtEsretenislr
            // 
            // 
            // 
            // 
            this.TxtEsretenislr.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsretenislr.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtEsretenislr.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsretenislr.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsretenislr.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtEsretenislr.Border.Class = "TextBoxBorder";
            this.TxtEsretenislr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtEsretenislr.FocusHighlightEnabled = true;
            this.TxtEsretenislr.Location = new System.Drawing.Point(512, 183);
            this.TxtEsretenislr.Name = "TxtEsretenislr";
            this.TxtEsretenislr.Size = new System.Drawing.Size(91, 22);
            this.TxtEsretenislr.TabIndex = 184;
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
            this.TxtFecha_reg.CustomFormat = "dd/MM/yyyy";
            this.TxtFecha_reg.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.TxtFecha_reg.IsPopupCalendarOpen = false;
            this.TxtFecha_reg.Location = new System.Drawing.Point(115, 39);
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
            this.TxtFecha_reg.Size = new System.Drawing.Size(133, 22);
            this.TxtFecha_reg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TxtFecha_reg.TabIndex = 185;
            this.TxtFecha_reg.Value = new System.DateTime(2019, 5, 17, 23, 28, 7, 587);
            // 
            // TxtCod_caja
            // 
            this.TxtCod_caja.DisplayMember = "Text";
            this.TxtCod_caja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtCod_caja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxtCod_caja.FormattingEnabled = true;
            this.TxtCod_caja.ItemHeight = 16;
            this.TxtCod_caja.Location = new System.Drawing.Point(436, 12);
            this.TxtCod_caja.Name = "TxtCod_caja";
            this.TxtCod_caja.Size = new System.Drawing.Size(95, 22);
            this.TxtCod_caja.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.TxtCod_caja.TabIndex = 187;
            this.TxtCod_caja.SelectedIndexChanged += new System.EventHandler(this.TxtCod_caja_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 188;
            this.label7.Text = "Fecha de Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 189;
            this.label8.Text = "movbanco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 14);
            this.label9.TabIndex = 190;
            this.label9.Text = "movcaja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 14);
            this.label11.TabIndex = 192;
            this.label11.Text = "optipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(305, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 14);
            this.label13.TabIndex = 194;
            this.label13.Text = "cod_compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 14);
            this.label14.TabIndex = 195;
            this.label14.Text = "reng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 14);
            this.label15.TabIndex = 196;
            this.label15.Text = "cod_pago";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(649, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 14);
            this.label16.TabIndex = 197;
            this.label16.Text = "esreteniva";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(524, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 14);
            this.label17.TabIndex = 198;
            this.label17.Text = "esretenislr";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(602, 121);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(90, 25);
            this.BtnAceptar.TabIndex = 200;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(691, 121);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 25);
            this.BtnCancelar.TabIndex = 201;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRetIslr
            // 
            this.BtnRetIslr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnRetIslr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnRetIslr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetIslr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetIslr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRetIslr.Location = new System.Drawing.Point(174, 121);
            this.BtnRetIslr.Name = "BtnRetIslr";
            this.BtnRetIslr.Size = new System.Drawing.Size(160, 25);
            this.BtnRetIslr.TabIndex = 203;
            this.BtnRetIslr.Text = "Retencion I.S.L.R.";
            this.BtnRetIslr.UseVisualStyleBackColor = true;
            // 
            // BtnRetIva
            // 
            this.BtnRetIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnRetIva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnRetIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetIva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetIva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRetIva.Location = new System.Drawing.Point(15, 121);
            this.BtnRetIva.Name = "BtnRetIva";
            this.BtnRetIva.Size = new System.Drawing.Size(160, 25);
            this.BtnRetIva.TabIndex = 202;
            this.BtnRetIva.Text = "Retencion I.V.A.";
            this.BtnRetIva.UseVisualStyleBackColor = true;
            // 
            // TxtNumdocumento
            // 
            // 
            // 
            // 
            this.TxtNumdocumento.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocumento.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtNumdocumento.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocumento.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocumento.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtNumdocumento.Border.Class = "TextBoxBorder";
            this.TxtNumdocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNumdocumento.FocusHighlightEnabled = true;
            this.TxtNumdocumento.Location = new System.Drawing.Point(103, 225);
            this.TxtNumdocumento.Name = "TxtNumdocumento";
            this.TxtNumdocumento.Size = new System.Drawing.Size(99, 22);
            this.TxtNumdocumento.TabIndex = 204;
            // 
            // TxtDesc_cuenta
            // 
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
            this.TxtDesc_cuenta.FocusHighlightEnabled = true;
            this.TxtDesc_cuenta.Location = new System.Drawing.Point(533, 12);
            this.TxtDesc_cuenta.Name = "TxtDesc_cuenta";
            this.TxtDesc_cuenta.Size = new System.Drawing.Size(249, 22);
            this.TxtDesc_cuenta.TabIndex = 205;
            // 
            // TxtCod_cuenta
            // 
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
            this.TxtCod_cuenta.FocusHighlightEnabled = true;
            this.TxtCod_cuenta.Location = new System.Drawing.Point(436, 43);
            this.TxtCod_cuenta.Name = "TxtCod_cuenta";
            this.TxtCod_cuenta.Size = new System.Drawing.Size(95, 22);
            this.TxtCod_cuenta.TabIndex = 206;
            this.TxtCod_cuenta.DoubleClick += new System.EventHandler(this.TxtCod_cuenta_DoubleClick);
            // 
            // ErrorTexto
            // 
            this.ErrorTexto.BlinkRate = 300;
            this.ErrorTexto.ContainerControl = this;
            // 
            // FPagoDetalle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 269);
            this.Controls.Add(this.TxtCod_cuenta);
            this.Controls.Add(this.TxtDesc_cuenta);
            this.Controls.Add(this.TxtNumdocumento);
            this.Controls.Add(this.BtnRetIslr);
            this.Controls.Add(this.BtnRetIva);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtFecha_reg);
            this.Controls.Add(this.TxtEsretenislr);
            this.Controls.Add(this.TxtEsreteniva);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.TxtOptipo);
            this.Controls.Add(this.TxtCod_compra);
            this.Controls.Add(this.TxtCod_pago);
            this.Controls.Add(this.TxtReng);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtAbono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumdocpago);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TxtCod_movbanco);
            this.Controls.Add(this.TxtCod_movcaja);
            this.Controls.Add(this.TxtForma);
            this.Controls.Add(this.TxtCod_caja);
            this.Controls.Add(this.TxtDesc_caja);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FPagoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoDetalle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPagoDetalle_FormClosed);
            this.Load += new System.EventHandler(this.PagoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAbono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha_reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_caja;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_movcaja;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_movbanco;
        private System.Windows.Forms.Label label24;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtNumdocpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DoubleInput TxtAbono;
        private DevComponents.Editors.DoubleInput TxtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtReng;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_pago;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_compra;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtOptipo;
        private DevComponents.Editors.DoubleInput TxtSaldo;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtEsreteniva;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtEsretenislr;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput TxtFecha_reg;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx TxtForma;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx TxtCod_caja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRetIslr;
        private System.Windows.Forms.Button BtnRetIva;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtNumdocumento;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_cuenta;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtCod_cuenta;
        private System.Windows.Forms.ErrorProvider ErrorTexto;
    }
}