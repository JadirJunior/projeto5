namespace projeto4
{
    partial class FormRelatorioCurso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtDt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.txtDt);
            this.groupBox1.Location = new System.Drawing.Point(21, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cboTipo
            // 
            this.cboTipo.AutoResize = false;
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTipo.Depth = 0;
            this.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipo.DropDownHeight = 174;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DropDownWidth = 121;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Hint = "Tipo";
            this.cboTipo.IntegralHeight = false;
            this.cboTipo.ItemHeight = 43;
            this.cboTipo.Items.AddRange(new object[] {
            "Selecione um tipo",
            "Técnico",
            "Tecnólogo",
            "Bacharelado",
            "Licenciatura"});
            this.cboTipo.Location = new System.Drawing.Point(6, 35);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(282, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 5;
            // 
            // txtDt
            // 
            this.txtDt.AllowPromptAsInput = true;
            this.txtDt.AnimateReadOnly = false;
            this.txtDt.AsciiOnly = false;
            this.txtDt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDt.BeepOnError = false;
            this.txtDt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDt.Depth = 0;
            this.txtDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDt.HidePromptOnLeave = false;
            this.txtDt.HideSelection = true;
            this.txtDt.Hint = "Ano";
            this.txtDt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDt.LeadingIcon = null;
            this.txtDt.Location = new System.Drawing.Point(307, 35);
            this.txtDt.Mask = "9999";
            this.txtDt.MaxLength = 32767;
            this.txtDt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDt.Name = "txtDt";
            this.txtDt.PasswordChar = '\0';
            this.txtDt.PrefixSuffixText = null;
            this.txtDt.PromptChar = '_';
            this.txtDt.ReadOnly = false;
            this.txtDt.RejectInputOnFirstFailure = false;
            this.txtDt.ResetOnPrompt = true;
            this.txtDt.ResetOnSpace = true;
            this.txtDt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDt.SelectedText = "";
            this.txtDt.SelectionLength = 0;
            this.txtDt.SelectionStart = 0;
            this.txtDt.ShortcutsEnabled = true;
            this.txtDt.Size = new System.Drawing.Size(135, 48);
            this.txtDt.SkipLiterals = true;
            this.txtDt.TabIndex = 10;
            this.txtDt.TabStop = false;
            this.txtDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDt.TrailingIcon = null;
            this.txtDt.UseSystemPasswordChar = false;
            this.txtDt.ValidatingType = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(21, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboImpressora);
            this.groupBox3.Location = new System.Drawing.Point(21, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            this.cboImpressora.AutoResize = false;
            this.cboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboImpressora.Depth = 0;
            this.cboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboImpressora.DropDownHeight = 174;
            this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpressora.DropDownWidth = 121;
            this.cboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Hint = "Impressora";
            this.cboImpressora.IntegralHeight = false;
            this.cboImpressora.ItemHeight = 43;
            this.cboImpressora.Location = new System.Drawing.Point(37, 33);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(376, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 7;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(147, 474);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(97, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "&IMPRIMIR";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(252, 474);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(112, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "&VISUALIZAR";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // FormRelatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 563);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorioCurso";
            this.Text = "FormRelatorioCurso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRelatorioCurso_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDt;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
    }
}