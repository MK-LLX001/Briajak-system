namespace MAI_PHADARN
{
    partial class Login
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtuser = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnclrar = new MaterialSkin.Controls.MaterialButton();
            this.txtpass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Noto Sans Lao", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(445, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ເຂົ້າສູ່ລະບົບ";
            // 
            // txtuser
            // 
            this.txtuser.AllowPromptAsInput = true;
            this.txtuser.AnimateReadOnly = false;
            this.txtuser.AsciiOnly = false;
            this.txtuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtuser.BeepOnError = false;
            this.txtuser.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtuser.Depth = 0;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtuser.HidePromptOnLeave = false;
            this.txtuser.HideSelection = true;
            this.txtuser.Hint = "User Name";
            this.txtuser.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtuser.LeadingIcon = null;
            this.txtuser.Location = new System.Drawing.Point(160, 174);
            this.txtuser.Mask = "";
            this.txtuser.MaxLength = 32767;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PrefixSuffixText = null;
            this.txtuser.PromptChar = '_';
            this.txtuser.ReadOnly = false;
            this.txtuser.RejectInputOnFirstFailure = false;
            this.txtuser.ResetOnPrompt = true;
            this.txtuser.ResetOnSpace = true;
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtuser.SelectedText = "";
            this.txtuser.SelectionLength = 0;
            this.txtuser.SelectionStart = 0;
            this.txtuser.ShortcutsEnabled = true;
            this.txtuser.Size = new System.Drawing.Size(657, 48);
            this.txtuser.SkipLiterals = true;
            this.txtuser.TabIndex = 4;
            this.txtuser.TabStop = false;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtuser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtuser.TrailingIcon = null;
            this.txtuser.UseSystemPasswordChar = false;
            this.txtuser.ValidatingType = null;
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Noto Sans Lao Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(429, 389);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 25);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Acreat Account";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(427, 364);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 21);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Dont Have Account";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(317, 301);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(158, 36);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnclrar
            // 
            this.btnclrar.AutoSize = false;
            this.btnclrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnclrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnclrar.Depth = 0;
            this.btnclrar.HighEmphasis = true;
            this.btnclrar.Icon = null;
            this.btnclrar.Location = new System.Drawing.Point(493, 301);
            this.btnclrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnclrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnclrar.Name = "btnclrar";
            this.btnclrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnclrar.Size = new System.Drawing.Size(158, 36);
            this.btnclrar.TabIndex = 14;
            this.btnclrar.Text = "CLEAR";
            this.btnclrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnclrar.UseAccentColor = false;
            this.btnclrar.UseVisualStyleBackColor = true;
            this.btnclrar.Click += new System.EventHandler(this.btnclrar_Click);
            // 
            // txtpass
            // 
            this.txtpass.AllowPromptAsInput = true;
            this.txtpass.AnimateReadOnly = false;
            this.txtpass.AsciiOnly = false;
            this.txtpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtpass.BeepOnError = false;
            this.txtpass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtpass.Depth = 0;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpass.HidePromptOnLeave = false;
            this.txtpass.HideSelection = true;
            this.txtpass.Hint = "Password";
            this.txtpass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtpass.LeadingIcon = null;
            this.txtpass.Location = new System.Drawing.Point(159, 233);
            this.txtpass.Mask = "";
            this.txtpass.MaxLength = 32767;
            this.txtpass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '●';
            this.txtpass.PrefixSuffixText = null;
            this.txtpass.PromptChar = '_';
            this.txtpass.ReadOnly = false;
            this.txtpass.RejectInputOnFirstFailure = false;
            this.txtpass.ResetOnPrompt = true;
            this.txtpass.ResetOnSpace = true;
            this.txtpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(659, 48);
            this.txtpass.SkipLiterals = true;
            this.txtpass.TabIndex = 18;
            this.txtpass.TabStop = false;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtpass.TrailingIcon = null;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.ValidatingType = null;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 449);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnclrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtuser);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtuser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnclrar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtpass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}