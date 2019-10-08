namespace Presentacion.ModuloCompra
{
    partial class FCOtros
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMonto = new DevComponents.Editors.DoubleInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtTotalo = new DevComponents.Editors.DoubleInput();
            this.TxtDescuento = new DevComponents.Editors.DoubleInput();
            this.TxtRecargo = new DevComponents.Editors.DoubleInput();
            this.txtFlag = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRecargo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 154;
            this.label4.Text = "Monto";
            // 
            // TxtMonto
            // 
            this.TxtMonto.AllowEmptyState = false;
            this.TxtMonto.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtMonto.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.TxtMonto.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtMonto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtMonto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtMonto.DisabledBackColor = System.Drawing.Color.White;
            this.TxtMonto.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtMonto.DisplayFormat = "##,##0.00";
            this.TxtMonto.Enabled = false;
            this.TxtMonto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtMonto.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtMonto.Increment = 1D;
            this.TxtMonto.Location = new System.Drawing.Point(91, 12);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(139, 22);
            this.TxtMonto.TabIndex = 153;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 152;
            this.label3.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 151;
            this.label2.Text = "Descuento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 150;
            this.label1.Text = "Recargo";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(150, 129);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 26);
            this.BtnCancelar.TabIndex = 149;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(49, 129);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(80, 26);
            this.BtnAceptar.TabIndex = 148;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtTotalo
            // 
            this.TxtTotalo.AllowEmptyState = false;
            this.TxtTotalo.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtTotalo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtTotalo.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.TxtTotalo.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtTotalo.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtTotalo.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtTotalo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtTotalo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtTotalo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtTotalo.DisabledBackColor = System.Drawing.Color.White;
            this.TxtTotalo.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtTotalo.DisplayFormat = "##,##0.00";
            this.TxtTotalo.Enabled = false;
            this.TxtTotalo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTotalo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtTotalo.Increment = 1D;
            this.TxtTotalo.Location = new System.Drawing.Point(91, 93);
            this.TxtTotalo.Name = "TxtTotalo";
            this.TxtTotalo.Size = new System.Drawing.Size(139, 22);
            this.TxtTotalo.TabIndex = 147;
            this.TxtTotalo.ValueChanged += new System.EventHandler(this.TxtTotalo_ValueChanged);
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.AllowEmptyState = false;
            this.TxtDescuento.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtDescuento.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDescuento.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.TxtDescuento.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDescuento.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDescuento.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDescuento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtDescuento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDescuento.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtDescuento.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDescuento.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtDescuento.DisplayFormat = "##,##0.00";
            this.TxtDescuento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtDescuento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtDescuento.Increment = 1D;
            this.TxtDescuento.Location = new System.Drawing.Point(91, 66);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(139, 22);
            this.TxtDescuento.TabIndex = 146;
            this.TxtDescuento.ValueChanged += new System.EventHandler(this.TxtDescuento_ValueChanged);
            // 
            // TxtRecargo
            // 
            this.TxtRecargo.AllowEmptyState = false;
            this.TxtRecargo.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.TxtRecargo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtRecargo.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.TxtRecargo.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtRecargo.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtRecargo.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtRecargo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtRecargo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtRecargo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtRecargo.DisabledBackColor = System.Drawing.Color.White;
            this.TxtRecargo.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRecargo.DisplayFormat = "##,##0.00";
            this.TxtRecargo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtRecargo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtRecargo.Increment = 1D;
            this.TxtRecargo.Location = new System.Drawing.Point(91, 39);
            this.TxtRecargo.Name = "TxtRecargo";
            this.TxtRecargo.Size = new System.Drawing.Size(139, 22);
            this.TxtRecargo.TabIndex = 145;
            this.TxtRecargo.ValueChanged += new System.EventHandler(this.TxtRecargo_ValueChanged);
            // 
            // txtFlag
            // 
            this.txtFlag.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFlag.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(5)))), ((int)(((byte)(25)))));
            this.txtFlag.Border.Class = "TextBoxBorder";
            this.txtFlag.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFlag.DisabledBackColor = System.Drawing.Color.White;
            this.txtFlag.FocusHighlightEnabled = true;
            this.txtFlag.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlag.ForeColor = System.Drawing.Color.Black;
            this.txtFlag.Location = new System.Drawing.Point(320, 154);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.PreventEnterBeep = true;
            this.txtFlag.Size = new System.Drawing.Size(29, 22);
            this.txtFlag.TabIndex = 155;
            // 
            // FCompraOtros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(288, 165);
            this.Controls.Add(this.txtFlag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtTotalo);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.TxtRecargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCompraPOtros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CompraPOtros";
            this.Load += new System.EventHandler(this.FCOtros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRecargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        internal DevComponents.Editors.DoubleInput TxtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        internal DevComponents.Editors.DoubleInput TxtTotalo;
        internal DevComponents.Editors.DoubleInput TxtDescuento;
        internal DevComponents.Editors.DoubleInput TxtRecargo;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFlag;
    }
}