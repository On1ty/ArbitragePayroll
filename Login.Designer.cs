
namespace UI_payroll
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.title = new Bunifu.UI.WinForms.BunifuLabel();
            this.loading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtAdmin = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSignin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoEllipsis = false;
            this.title.AutoSize = false;
            this.title.CursorType = null;
            this.title.Font = new System.Drawing.Font("Lucida Sans", 26.25F);
            this.title.Location = new System.Drawing.Point(536, 102);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(124, 42);
            this.title.TabIndex = 4;
            this.title.Text = "Sign In";
            this.title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // loading
            // 
            this.loading.animated = true;
            this.loading.animationIterval = 10;
            this.loading.animationSpeed = 1;
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loading.BackgroundImage")));
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.loading.ForeColor = System.Drawing.Color.SeaGreen;
            this.loading.LabelVisible = false;
            this.loading.LineProgressThickness = 3;
            this.loading.LineThickness = 2;
            this.loading.Location = new System.Drawing.Point(580, 347);
            this.loading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.loading.MaxValue = 100;
            this.loading.Name = "loading";
            this.loading.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.loading.Size = new System.Drawing.Size(37, 37);
            this.loading.TabIndex = 5;
            this.loading.Value = 50;
            this.loading.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(436, 230);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties12;
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(324, 45);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtField_Enter);
            // 
            // txtAdmin
            // 
            this.txtAdmin.AcceptsReturn = false;
            this.txtAdmin.AcceptsTab = false;
            this.txtAdmin.AnimationSpeed = 200;
            this.txtAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAdmin.BackColor = System.Drawing.Color.White;
            this.txtAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAdmin.BackgroundImage")));
            this.txtAdmin.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.txtAdmin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAdmin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.txtAdmin.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAdmin.BorderRadius = 1;
            this.txtAdmin.BorderThickness = 3;
            this.txtAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdmin.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtAdmin.DefaultText = "";
            this.txtAdmin.FillColor = System.Drawing.Color.White;
            this.txtAdmin.HideSelection = true;
            this.txtAdmin.IconLeft = null;
            this.txtAdmin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdmin.IconPadding = 10;
            this.txtAdmin.IconRight = null;
            this.txtAdmin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdmin.Lines = new string[0];
            this.txtAdmin.Location = new System.Drawing.Point(436, 171);
            this.txtAdmin.MaxLength = 32767;
            this.txtAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAdmin.Modified = false;
            this.txtAdmin.Multiline = false;
            this.txtAdmin.Name = "txtAdmin";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdmin.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAdmin.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdmin.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdmin.OnIdleState = stateProperties16;
            this.txtAdmin.PasswordChar = '\0';
            this.txtAdmin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAdmin.PlaceholderText = "Admin";
            this.txtAdmin.ReadOnly = false;
            this.txtAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdmin.SelectedText = "";
            this.txtAdmin.SelectionLength = 0;
            this.txtAdmin.SelectionStart = 0;
            this.txtAdmin.ShortcutsEnabled = true;
            this.txtAdmin.Size = new System.Drawing.Size(324, 45);
            this.txtAdmin.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtAdmin.TabIndex = 0;
            this.txtAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdmin.TextMarginBottom = 0;
            this.txtAdmin.TextMarginLeft = 5;
            this.txtAdmin.TextMarginTop = 0;
            this.txtAdmin.TextPlaceholder = "Admin";
            this.txtAdmin.UseSystemPasswordChar = false;
            this.txtAdmin.WordWrap = true;
            this.txtAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtField_Enter);
            // 
            // btnSignin
            // 
            this.btnSignin.AllowToggling = false;
            this.btnSignin.AnimationSpeed = 200;
            this.btnSignin.AutoGenerateColors = false;
            this.btnSignin.BackColor = System.Drawing.Color.Transparent;
            this.btnSignin.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnSignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignin.BackgroundImage")));
            this.btnSignin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignin.ButtonText = "Sign In";
            this.btnSignin.ButtonTextMarginLeft = 0;
            this.btnSignin.ColorContrastOnClick = 45;
            this.btnSignin.ColorContrastOnHover = 45;
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSignin.CustomizableEdges = borderEdges2;
            this.btnSignin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignin.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSignin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.IconMarginLeft = 11;
            this.btnSignin.IconPadding = 10;
            this.btnSignin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSignin.IdleBorderRadius = 50;
            this.btnSignin.IdleBorderThickness = 2;
            this.btnSignin.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignin.IdleIconLeftImage = null;
            this.btnSignin.IdleIconRightImage = null;
            this.btnSignin.IndicateFocus = false;
            this.btnSignin.Location = new System.Drawing.Point(436, 290);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSignin.onHoverState.BorderRadius = 50;
            this.btnSignin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignin.onHoverState.BorderThickness = 2;
            this.btnSignin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSignin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignin.onHoverState.IconLeftImage = null;
            this.btnSignin.onHoverState.IconRightImage = null;
            this.btnSignin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSignin.OnIdleState.BorderRadius = 50;
            this.btnSignin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignin.OnIdleState.BorderThickness = 2;
            this.btnSignin.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignin.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignin.OnIdleState.IconLeftImage = null;
            this.btnSignin.OnIdleState.IconRightImage = null;
            this.btnSignin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSignin.OnPressedState.BorderRadius = 50;
            this.btnSignin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignin.OnPressedState.BorderThickness = 2;
            this.btnSignin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSignin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSignin.OnPressedState.IconLeftImage = null;
            this.btnSignin.OnPressedState.IconRightImage = null;
            this.btnSignin.Size = new System.Drawing.Size(324, 55);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignin.TextMarginLeft = 0;
            this.btnSignin.UseDefaultRadiusAndThickness = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 421);
            this.panel1.TabIndex = 6;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = global::ArbitragePayroll.Properties.Resources.arb_white;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(34, 70);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(293, 293);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.btnSignin);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignin;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAdmin;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuLabel title;
        private Bunifu.Framework.UI.BunifuCircleProgressbar loading;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}

