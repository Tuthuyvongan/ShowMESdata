
namespace SMESData
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pnMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btPQC = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btMQC = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnMain.BorderRadius = 0;
            this.pnMain.BorderThickness = 0;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(135, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShowBorders = true;
            this.pnMain.Size = new System.Drawing.Size(1305, 804);
            this.pnMain.TabIndex = 10;
            // 
            // pnMenu
            // 
            this.pnMenu.BackgroundColor = System.Drawing.Color.Black;
            this.pnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenu.BackgroundImage")));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenu.BorderColor = System.Drawing.Color.Transparent;
            this.pnMenu.BorderRadius = 0;
            this.pnMenu.BorderThickness = 0;
            this.pnMenu.Controls.Add(this.btClose);
            this.pnMenu.Controls.Add(this.btPQC);
            this.pnMenu.Controls.Add(this.btMQC);
            this.pnMenu.Controls.Add(this.pbLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShowBorders = true;
            this.pnMenu.Size = new System.Drawing.Size(135, 804);
            this.pnMenu.TabIndex = 9;
            // 
            // btClose
            // 
            this.btClose.ActiveImage = null;
            this.btClose.AllowAnimations = true;
            this.btClose.AllowBuffering = false;
            this.btClose.AllowToggling = false;
            this.btClose.AllowZooming = true;
            this.btClose.AllowZoomingOnFocus = false;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btClose.ErrorImage")));
            this.btClose.FadeWhenInactive = false;
            this.btClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btClose.Image = global::SMESData.Properties.Resources.close;
            this.btClose.ImageActive = null;
            this.btClose.ImageLocation = null;
            this.btClose.ImageMargin = 20;
            this.btClose.ImageSize = new System.Drawing.Size(55, 61);
            this.btClose.ImageZoomSize = new System.Drawing.Size(75, 81);
            this.btClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btClose.InitialImage")));
            this.btClose.Location = new System.Drawing.Point(30, 773);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Rotation = 0;
            this.btClose.ShowActiveImage = true;
            this.btClose.ShowCursorChanges = true;
            this.btClose.ShowImageBorders = true;
            this.btClose.ShowSizeMarkers = false;
            this.btClose.Size = new System.Drawing.Size(75, 81);
            this.btClose.TabIndex = 6;
            this.btClose.ToolTipText = "";
            this.btClose.WaitOnLoad = false;
            this.btClose.Zoom = 20;
            this.btClose.ZoomSpeed = 10;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPQC
            // 
            this.btPQC.AllowAnimations = true;
            this.btPQC.AllowMouseEffects = true;
            this.btPQC.AllowToggling = true;
            this.btPQC.AnimationSpeed = 200;
            this.btPQC.AutoGenerateColors = false;
            this.btPQC.AutoRoundBorders = false;
            this.btPQC.AutoSizeLeftIcon = true;
            this.btPQC.AutoSizeRightIcon = true;
            this.btPQC.BackColor = System.Drawing.Color.Transparent;
            this.btPQC.BackColor1 = System.Drawing.Color.Black;
            this.btPQC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPQC.BackgroundImage")));
            this.btPQC.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btPQC.ButtonText = "PQC";
            this.btPQC.ButtonTextMarginLeft = 0;
            this.btPQC.ColorContrastOnClick = 45;
            this.btPQC.ColorContrastOnHover = 45;
            this.btPQC.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btPQC.CustomizableEdges = borderEdges1;
            this.btPQC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btPQC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btPQC.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btPQC.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btPQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btPQC.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPQC.ForeColor = System.Drawing.Color.White;
            this.btPQC.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPQC.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btPQC.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btPQC.IconMarginLeft = 11;
            this.btPQC.IconPadding = 10;
            this.btPQC.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPQC.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btPQC.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btPQC.IconSize = 25;
            this.btPQC.IdleBorderColor = System.Drawing.Color.Black;
            this.btPQC.IdleBorderRadius = 1;
            this.btPQC.IdleBorderThickness = 1;
            this.btPQC.IdleFillColor = System.Drawing.Color.Black;
            this.btPQC.IdleIconLeftImage = null;
            this.btPQC.IdleIconRightImage = null;
            this.btPQC.IndicateFocus = true;
            this.btPQC.Location = new System.Drawing.Point(0, 207);
            this.btPQC.Margin = new System.Windows.Forms.Padding(2);
            this.btPQC.Name = "btPQC";
            this.btPQC.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btPQC.OnDisabledState.BorderRadius = 1;
            this.btPQC.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btPQC.OnDisabledState.BorderThickness = 1;
            this.btPQC.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btPQC.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btPQC.OnDisabledState.IconLeftImage = null;
            this.btPQC.OnDisabledState.IconRightImage = null;
            this.btPQC.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btPQC.onHoverState.BorderRadius = 1;
            this.btPQC.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btPQC.onHoverState.BorderThickness = 1;
            this.btPQC.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btPQC.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btPQC.onHoverState.IconLeftImage = null;
            this.btPQC.onHoverState.IconRightImage = null;
            this.btPQC.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btPQC.OnIdleState.BorderRadius = 1;
            this.btPQC.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btPQC.OnIdleState.BorderThickness = 1;
            this.btPQC.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btPQC.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btPQC.OnIdleState.IconLeftImage = null;
            this.btPQC.OnIdleState.IconRightImage = null;
            this.btPQC.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btPQC.OnPressedState.BorderRadius = 1;
            this.btPQC.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btPQC.OnPressedState.BorderThickness = 1;
            this.btPQC.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btPQC.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btPQC.OnPressedState.IconLeftImage = null;
            this.btPQC.OnPressedState.IconRightImage = null;
            this.btPQC.Size = new System.Drawing.Size(135, 73);
            this.btPQC.TabIndex = 5;
            this.btPQC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btPQC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btPQC.TextMarginLeft = 0;
            this.btPQC.TextPadding = new System.Windows.Forms.Padding(0);
            this.btPQC.UseDefaultRadiusAndThickness = true;
            this.btPQC.Click += new System.EventHandler(this.btPQC_Click);
            // 
            // btMQC
            // 
            this.btMQC.AllowAnimations = true;
            this.btMQC.AllowMouseEffects = true;
            this.btMQC.AllowToggling = true;
            this.btMQC.AnimationSpeed = 200;
            this.btMQC.AutoGenerateColors = false;
            this.btMQC.AutoRoundBorders = false;
            this.btMQC.AutoSizeLeftIcon = true;
            this.btMQC.AutoSizeRightIcon = true;
            this.btMQC.BackColor = System.Drawing.Color.Transparent;
            this.btMQC.BackColor1 = System.Drawing.Color.Black;
            this.btMQC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMQC.BackgroundImage")));
            this.btMQC.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btMQC.ButtonText = "MQC";
            this.btMQC.ButtonTextMarginLeft = 0;
            this.btMQC.ColorContrastOnClick = 45;
            this.btMQC.ColorContrastOnHover = 45;
            this.btMQC.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btMQC.CustomizableEdges = borderEdges2;
            this.btMQC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btMQC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btMQC.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btMQC.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btMQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btMQC.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMQC.ForeColor = System.Drawing.Color.White;
            this.btMQC.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMQC.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btMQC.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btMQC.IconMarginLeft = 11;
            this.btMQC.IconPadding = 10;
            this.btMQC.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMQC.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btMQC.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btMQC.IconSize = 25;
            this.btMQC.IdleBorderColor = System.Drawing.Color.Black;
            this.btMQC.IdleBorderRadius = 1;
            this.btMQC.IdleBorderThickness = 1;
            this.btMQC.IdleFillColor = System.Drawing.Color.Black;
            this.btMQC.IdleIconLeftImage = null;
            this.btMQC.IdleIconRightImage = null;
            this.btMQC.IndicateFocus = true;
            this.btMQC.Location = new System.Drawing.Point(0, 112);
            this.btMQC.Margin = new System.Windows.Forms.Padding(2);
            this.btMQC.Name = "btMQC";
            this.btMQC.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btMQC.OnDisabledState.BorderRadius = 1;
            this.btMQC.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btMQC.OnDisabledState.BorderThickness = 1;
            this.btMQC.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btMQC.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btMQC.OnDisabledState.IconLeftImage = null;
            this.btMQC.OnDisabledState.IconRightImage = null;
            this.btMQC.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btMQC.onHoverState.BorderRadius = 1;
            this.btMQC.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btMQC.onHoverState.BorderThickness = 1;
            this.btMQC.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btMQC.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btMQC.onHoverState.IconLeftImage = null;
            this.btMQC.onHoverState.IconRightImage = null;
            this.btMQC.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btMQC.OnIdleState.BorderRadius = 1;
            this.btMQC.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btMQC.OnIdleState.BorderThickness = 1;
            this.btMQC.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btMQC.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btMQC.OnIdleState.IconLeftImage = null;
            this.btMQC.OnIdleState.IconRightImage = null;
            this.btMQC.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btMQC.OnPressedState.BorderRadius = 1;
            this.btMQC.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btMQC.OnPressedState.BorderThickness = 1;
            this.btMQC.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btMQC.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btMQC.OnPressedState.IconLeftImage = null;
            this.btMQC.OnPressedState.IconRightImage = null;
            this.btMQC.Size = new System.Drawing.Size(135, 73);
            this.btMQC.TabIndex = 3;
            this.btMQC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btMQC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btMQC.TextMarginLeft = 0;
            this.btMQC.TextPadding = new System.Windows.Forms.Padding(0);
            this.btMQC.UseDefaultRadiusAndThickness = true;
            this.btMQC.Click += new System.EventHandler(this.btMQC_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Black;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(135, 107);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 804);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnMain;
        private Bunifu.UI.WinForms.BunifuPanel pnMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btPQC;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btMQC;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.UI.WinForms.BunifuImageButton btClose;
    }
}

