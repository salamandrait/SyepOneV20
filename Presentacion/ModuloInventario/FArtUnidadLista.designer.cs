namespace Presentacion.ModuloInventario
{
    partial class FArtUnidadLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataListadoArt = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataListadoUnd = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TxtDesc_articulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_articulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCod_unidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDesc_unidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtCod_artunidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoUnd)).BeginInit();
            this.SuspendLayout();
            // 
            // DataListadoArt
            // 
            this.DataListadoArt.AllowUserToAddRows = false;
            this.DataListadoArt.AllowUserToDeleteRows = false;
            this.DataListadoArt.AllowUserToOrderColumns = true;
            this.DataListadoArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListadoArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListadoArt.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataListadoArt.EnableHeadersVisualStyles = false;
            this.DataListadoArt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListadoArt.Location = new System.Drawing.Point(12, 12);
            this.DataListadoArt.Name = "DataListadoArt";
            this.DataListadoArt.PaintEnhancedSelection = false;
            this.DataListadoArt.ReadOnly = true;
            this.DataListadoArt.RowHeadersWidth = 25;
            this.DataListadoArt.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListadoArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoArt.Size = new System.Drawing.Size(451, 160);
            this.DataListadoArt.TabIndex = 94;
            this.DataListadoArt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoArt_CellClick);
            // 
            // DataListadoUnd
            // 
            this.DataListadoUnd.AllowUserToAddRows = false;
            this.DataListadoUnd.AllowUserToDeleteRows = false;
            this.DataListadoUnd.AllowUserToOrderColumns = true;
            this.DataListadoUnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListadoUnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListadoUnd.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataListadoUnd.EnableHeadersVisualStyles = false;
            this.DataListadoUnd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataListadoUnd.Location = new System.Drawing.Point(467, 12);
            this.DataListadoUnd.Name = "DataListadoUnd";
            this.DataListadoUnd.PaintEnhancedSelection = false;
            this.DataListadoUnd.ReadOnly = true;
            this.DataListadoUnd.RowHeadersWidth = 25;
            this.DataListadoUnd.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.DataListadoUnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoUnd.Size = new System.Drawing.Size(338, 160);
            this.DataListadoUnd.TabIndex = 95;
            this.DataListadoUnd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoUnd_CellClick);
            // 
            // TxtDesc_articulo
            // 
            // 
            // 
            // 
            this.TxtDesc_articulo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.TxtDesc_articulo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_articulo.Border.Class = "TextBoxBorder";
            this.TxtDesc_articulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_articulo.FocusHighlightEnabled = true;
            this.TxtDesc_articulo.Location = new System.Drawing.Point(144, 187);
            this.TxtDesc_articulo.Name = "TxtDesc_articulo";
            this.TxtDesc_articulo.Size = new System.Drawing.Size(319, 22);
            this.TxtDesc_articulo.TabIndex = 97;
            // 
            // TxtCod_articulo
            // 
            // 
            // 
            // 
            this.TxtCod_articulo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.TxtCod_articulo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_articulo.Border.Class = "TextBoxBorder";
            this.TxtCod_articulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_articulo.FocusHighlightEnabled = true;
            this.TxtCod_articulo.Location = new System.Drawing.Point(11, 187);
            this.TxtCod_articulo.Name = "TxtCod_articulo";
            this.TxtCod_articulo.Size = new System.Drawing.Size(131, 22);
            this.TxtCod_articulo.TabIndex = 96;
            // 
            // TxtCod_unidad
            // 
            // 
            // 
            // 
            this.TxtCod_unidad.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.TxtCod_unidad.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_unidad.Border.Class = "TextBoxBorder";
            this.TxtCod_unidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_unidad.FocusHighlightEnabled = true;
            this.TxtCod_unidad.Location = new System.Drawing.Point(467, 187);
            this.TxtCod_unidad.Name = "TxtCod_unidad";
            this.TxtCod_unidad.Size = new System.Drawing.Size(131, 22);
            this.TxtCod_unidad.TabIndex = 98;
            // 
            // TxtDesc_unidad
            // 
            // 
            // 
            // 
            this.TxtDesc_unidad.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.TxtDesc_unidad.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_unidad.Border.Class = "TextBoxBorder";
            this.TxtDesc_unidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_unidad.FocusHighlightEnabled = true;
            this.TxtDesc_unidad.Location = new System.Drawing.Point(600, 187);
            this.TxtDesc_unidad.Name = "TxtDesc_unidad";
            this.TxtDesc_unidad.Size = new System.Drawing.Size(205, 22);
            this.TxtDesc_unidad.TabIndex = 99;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Image = global::Presentacion.Properties.Resources.Cancelar;
            this.BtnCancelar.Location = new System.Drawing.Point(763, 215);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.BtnCancelar.TabIndex = 101;
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
            this.BtnAceptar.Location = new System.Drawing.Point(711, 215);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(36, 36);
            this.BtnAceptar.TabIndex = 100;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtCod_artunidad
            // 
            // 
            // 
            // 
            this.TxtCod_artunidad.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_artunidad.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.TxtCod_artunidad.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_artunidad.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_artunidad.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_artunidad.Border.Class = "TextBoxBorder";
            this.TxtCod_artunidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_artunidad.FocusHighlightEnabled = true;
            this.TxtCod_artunidad.Location = new System.Drawing.Point(12, 286);
            this.TxtCod_artunidad.Name = "TxtCod_artunidad";
            this.TxtCod_artunidad.Size = new System.Drawing.Size(46, 22);
            this.TxtCod_artunidad.TabIndex = 102;
            // 
            // FArtUnidadLista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(815, 268);
            this.Controls.Add(this.TxtCod_artunidad);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtDesc_unidad);
            this.Controls.Add(this.TxtCod_unidad);
            this.Controls.Add(this.TxtDesc_articulo);
            this.Controls.Add(this.TxtCod_articulo);
            this.Controls.Add(this.DataListadoUnd);
            this.Controls.Add(this.DataListadoArt);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FArtUnidadLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArtUnidadLista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FArtUnidadLista_FormClosed);
            this.Load += new System.EventHandler(this.FArtUnidadLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoUnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DataListadoArt;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataListadoUnd;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_articulo;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_articulo;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_unidad;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_unidad;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_artunidad;
    }
}