namespace Presentacion
{
    partial class FLogin
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
            this.TxtCod_mapa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgresBarStep = new System.Windows.Forms.ProgressBar();
            this.TxtCod_usuario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TxtDesc_usuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            this.TxtClave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // TxtCod_mapa
            // 
            // 
            // 
            // 
            this.TxtCod_mapa.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_mapa.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtCod_mapa.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_mapa.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_mapa.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtCod_mapa.Border.Class = "TextBoxBorder";
            this.TxtCod_mapa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCod_mapa.FocusHighlightEnabled = true;
            this.TxtCod_mapa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod_mapa.Location = new System.Drawing.Point(123, 12);
            this.TxtCod_mapa.Name = "TxtCod_mapa";
            this.TxtCod_mapa.Size = new System.Drawing.Size(98, 22);
            this.TxtCod_mapa.TabIndex = 5;
            this.TxtCod_mapa.Visible = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(121, 202);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(80, 25);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(65, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Clave";
            // 
            // ProgresBarStep
            // 
            this.ProgresBarStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgresBarStep.Location = new System.Drawing.Point(0, 286);
            this.ProgresBarStep.Name = "ProgresBarStep";
            this.ProgresBarStep.Size = new System.Drawing.Size(409, 12);
            this.ProgresBarStep.TabIndex = 34;
            // 
            // TxtCod_usuario
            // 
            this.TxtCod_usuario.DisplayMember = "Text";
            this.TxtCod_usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtCod_usuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod_usuario.FormattingEnabled = true;
            this.TxtCod_usuario.ItemHeight = 16;
            this.TxtCod_usuario.Location = new System.Drawing.Point(121, 98);
            this.TxtCod_usuario.Name = "TxtCod_usuario";
            this.TxtCod_usuario.Size = new System.Drawing.Size(172, 22);
            this.TxtCod_usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.TxtCod_usuario.TabIndex = 0;
            this.TxtCod_usuario.SelectedIndexChanged += new System.EventHandler(this.TxtCod_usuario_SelectedIndexChanged);
            // 
            // TxtDesc_usuario
            // 
            // 
            // 
            // 
            this.TxtDesc_usuario.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_usuario.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtDesc_usuario.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_usuario.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_usuario.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDesc_usuario.Border.Class = "TextBoxBorder";
            this.TxtDesc_usuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDesc_usuario.Enabled = false;
            this.TxtDesc_usuario.FocusHighlightEnabled = true;
            this.TxtDesc_usuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesc_usuario.Location = new System.Drawing.Point(121, 126);
            this.TxtDesc_usuario.Name = "TxtDesc_usuario";
            this.TxtDesc_usuario.ReadOnly = true;
            this.TxtDesc_usuario.Size = new System.Drawing.Size(172, 22);
            this.TxtDesc_usuario.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(213, 202);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 25);
            this.BtnCancelar.TabIndex = 28;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.BtnCancelar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.BtnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar2.Location = new System.Drawing.Point(213, 202);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(80, 25);
            this.BtnCancelar2.TabIndex = 5;
            this.BtnCancelar2.Text = "&Cancelar";
            this.BtnCancelar2.UseVisualStyleBackColor = false;
            this.BtnCancelar2.Visible = false;
            this.BtnCancelar2.Click += new System.EventHandler(this.BtnCancelar2_Click);
            // 
            // TxtClave
            // 
            // 
            // 
            // 
            this.TxtClave.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtClave.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.TxtClave.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtClave.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtClave.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtClave.Border.Class = "TextBoxBorder";
            this.TxtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtClave.FocusHighlightEnabled = true;
            this.TxtClave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(121, 157);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(172, 22);
            this.TxtClave.TabIndex = 3;
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            this.TxtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtClave_KeyDown);
            // 
            // FLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 298);
            this.Controls.Add(this.ProgresBarStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.BtnCancelar2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtCod_mapa);
            this.Controls.Add(this.TxtDesc_usuario);
            this.Controls.Add(this.TxtCod_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FLogin_FormClosed);
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FLogin_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCod_mapa;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.ProgressBar ProgresBarStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnAceptar;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtClave;
        internal System.Windows.Forms.Button BtnCancelar2;
        internal System.Windows.Forms.Button BtnCancelar;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtDesc_usuario;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx TxtCod_usuario;
    }
}