
namespace SMESData.View
{
    partial class MessageWaitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWaitForm));
            this.lbWait = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressBar1 = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // lbWait
            // 
            this.lbWait.AllowParentOverrides = false;
            this.lbWait.AutoEllipsis = false;
            this.lbWait.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbWait.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbWait.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lbWait.Location = new System.Drawing.Point(74, 73);
            this.lbWait.Name = "lbWait";
            this.lbWait.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbWait.Size = new System.Drawing.Size(274, 21);
            this.lbWait.TabIndex = 0;
            this.lbWait.Text = "Application is running, please wait ...";
            this.lbWait.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbWait.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // progressBar1
            // 
            this.progressBar1.AllowAnimations = false;
            this.progressBar1.Animation = 0;
            this.progressBar1.AnimationSpeed = 220;
            this.progressBar1.AnimationStep = 10;
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar1.BackgroundImage")));
            this.progressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressBar1.BorderRadius = 9;
            this.progressBar1.BorderThickness = 1;
            this.progressBar1.Location = new System.Drawing.Point(53, 31);
            this.progressBar1.Maximum = 100;
            this.progressBar1.MaximumValue = 100;
            this.progressBar1.Minimum = 0;
            this.progressBar1.MinimumValue = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressBar1.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressBar1.ProgressColorRight = System.Drawing.Color.LimeGreen;
            this.progressBar1.Size = new System.Drawing.Size(320, 25);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 0;
            this.progressBar1.ValueByTransition = 0;
            // 
            // MessageWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(436, 127);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageWaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageWaitForm";
            this.Load += new System.EventHandler(this.MessageWaitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbWait;
        private Bunifu.UI.WinForms.BunifuProgressBar progressBar1;
    }
}