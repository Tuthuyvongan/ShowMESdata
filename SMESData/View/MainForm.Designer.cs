﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pnMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btPQC = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnCover = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMQC = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.DragMenuControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbName = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.pnCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackgroundColor = System.Drawing.Color.White;
            this.pnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenu.BackgroundImage")));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenu.BorderColor = System.Drawing.Color.Transparent;
            this.pnMenu.BorderRadius = 0;
            this.pnMenu.BorderThickness = 0;
            this.pnMenu.Controls.Add(this.btPQC);
            this.pnMenu.Controls.Add(this.btMQC);
            this.pnMenu.Controls.Add(this.pnCover);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShowBorders = true;
            this.pnMenu.Size = new System.Drawing.Size(1120, 71);
            this.pnMenu.TabIndex = 5;
            // 
            // btPQC
            // 
            this.btPQC.AllowAnimations = true;
            this.btPQC.AllowMouseEffects = true;
            this.btPQC.AllowToggling = false;
            this.btPQC.AnimationSpeed = 200;
            this.btPQC.AutoGenerateColors = false;
            this.btPQC.AutoRoundBorders = false;
            this.btPQC.AutoSizeLeftIcon = true;
            this.btPQC.AutoSizeRightIcon = true;
            this.btPQC.BackColor = System.Drawing.Color.Transparent;
            this.btPQC.BackColor1 = System.Drawing.Color.White;
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
            this.btPQC.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPQC.ForeColor = System.Drawing.Color.Black;
            this.btPQC.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPQC.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btPQC.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btPQC.IconMarginLeft = 11;
            this.btPQC.IconPadding = 10;
            this.btPQC.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPQC.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btPQC.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btPQC.IconSize = 25;
            this.btPQC.IdleBorderColor = System.Drawing.Color.White;
            this.btPQC.IdleBorderRadius = 1;
            this.btPQC.IdleBorderThickness = 1;
            this.btPQC.IdleFillColor = System.Drawing.Color.White;
            this.btPQC.IdleIconLeftImage = null;
            this.btPQC.IdleIconRightImage = null;
            this.btPQC.IndicateFocus = false;
            this.btPQC.Location = new System.Drawing.Point(532, 0);
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
            this.btPQC.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btPQC.OnIdleState.BorderRadius = 1;
            this.btPQC.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btPQC.OnIdleState.BorderThickness = 1;
            this.btPQC.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btPQC.OnIdleState.ForeColor = System.Drawing.Color.Black;
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
            this.btPQC.Size = new System.Drawing.Size(209, 71);
            this.btPQC.TabIndex = 5;
            this.btPQC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btPQC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btPQC.TextMarginLeft = 0;
            this.btPQC.TextPadding = new System.Windows.Forms.Padding(0);
            this.btPQC.UseDefaultRadiusAndThickness = true;
            this.btPQC.Click += new System.EventHandler(this.btPQC_Click_1);
            // 
            // pnCover
            // 
            this.pnCover.BackgroundColor = System.Drawing.Color.White;
            this.pnCover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCover.BackgroundImage")));
            this.pnCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnCover.BorderColor = System.Drawing.Color.Transparent;
            this.pnCover.BorderRadius = 0;
            this.pnCover.BorderThickness = 0;
            this.pnCover.Controls.Add(this.lbName);
            this.pnCover.Controls.Add(this.pictureBox1);
            this.pnCover.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCover.Location = new System.Drawing.Point(0, 0);
            this.pnCover.Name = "pnCover";
            this.pnCover.ShowBorders = false;
            this.pnCover.Size = new System.Drawing.Size(310, 71);
            this.pnCover.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btMQC
            // 
            this.btMQC.AllowAnimations = true;
            this.btMQC.AllowMouseEffects = true;
            this.btMQC.AllowToggling = false;
            this.btMQC.AnimationSpeed = 200;
            this.btMQC.AutoGenerateColors = false;
            this.btMQC.AutoRoundBorders = false;
            this.btMQC.AutoSizeLeftIcon = true;
            this.btMQC.AutoSizeRightIcon = true;
            this.btMQC.BackColor = System.Drawing.Color.Transparent;
            this.btMQC.BackColor1 = System.Drawing.Color.White;
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
            this.btMQC.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMQC.ForeColor = System.Drawing.Color.Black;
            this.btMQC.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMQC.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btMQC.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btMQC.IconMarginLeft = 11;
            this.btMQC.IconPadding = 10;
            this.btMQC.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMQC.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btMQC.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btMQC.IconSize = 25;
            this.btMQC.IdleBorderColor = System.Drawing.Color.White;
            this.btMQC.IdleBorderRadius = 1;
            this.btMQC.IdleBorderThickness = 1;
            this.btMQC.IdleFillColor = System.Drawing.Color.White;
            this.btMQC.IdleIconLeftImage = null;
            this.btMQC.IdleIconRightImage = null;
            this.btMQC.IndicateFocus = false;
            this.btMQC.Location = new System.Drawing.Point(317, 0);
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
            this.btMQC.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btMQC.OnIdleState.BorderRadius = 1;
            this.btMQC.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btMQC.OnIdleState.BorderThickness = 1;
            this.btMQC.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btMQC.OnIdleState.ForeColor = System.Drawing.Color.Black;
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
            this.btMQC.Size = new System.Drawing.Size(209, 71);
            this.btMQC.TabIndex = 3;
            this.btMQC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btMQC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btMQC.TextMarginLeft = 0;
            this.btMQC.TextPadding = new System.Windows.Forms.Padding(0);
            this.btMQC.UseDefaultRadiusAndThickness = true;
            this.btMQC.Click += new System.EventHandler(this.btMQC_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnMain.BorderRadius = 0;
            this.pnMain.BorderThickness = 0;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 71);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShowBorders = true;
            this.pnMain.Size = new System.Drawing.Size(1120, 489);
            this.pnMain.TabIndex = 6;
            // 
            // DragMenuControl
            // 
            this.DragMenuControl.Fixed = true;
            this.DragMenuControl.Horizontal = true;
            this.DragMenuControl.TargetControl = this.pnMenu;
            this.DragMenuControl.Vertical = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(80, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(218, 28);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tech-Link SIlicone";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 560);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnCover.ResumeLayout(false);
            this.pnCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel pnCover;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btMQC;
        private Bunifu.UI.WinForms.BunifuPanel pnMain;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btPQC;
        private Bunifu.Framework.UI.BunifuDragControl DragMenuControl;
        private System.Windows.Forms.Label lbName;
    }
}
