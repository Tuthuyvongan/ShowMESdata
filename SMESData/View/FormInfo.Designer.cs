
namespace SMESData
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.dtgv_Info = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.ActiveImage = null;
            this.btClose.AllowAnimations = true;
            this.btClose.AllowBuffering = false;
            this.btClose.AllowToggling = false;
            this.btClose.AllowZooming = true;
            this.btClose.AllowZoomingOnFocus = false;
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btClose.ErrorImage")));
            this.btClose.FadeWhenInactive = false;
            this.btClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btClose.Image = global::SMESData.Properties.Resources.close;
            this.btClose.ImageActive = null;
            this.btClose.ImageLocation = null;
            this.btClose.ImageMargin = 10;
            this.btClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btClose.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.btClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btClose.InitialImage")));
            this.btClose.Location = new System.Drawing.Point(1440, 0);
            this.btClose.Name = "btClose";
            this.btClose.Rotation = 0;
            this.btClose.ShowActiveImage = true;
            this.btClose.ShowCursorChanges = true;
            this.btClose.ShowImageBorders = true;
            this.btClose.ShowSizeMarkers = false;
            this.btClose.Size = new System.Drawing.Size(60, 60);
            this.btClose.TabIndex = 66;
            this.btClose.ToolTipText = "";
            this.btClose.WaitOnLoad = false;
            this.btClose.Zoom = 10;
            this.btClose.ZoomSpeed = 10;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dtgv_Info
            // 
            this.dtgv_Info.AllowCustomTheming = true;
            this.dtgv_Info.AllowUserToAddRows = false;
            this.dtgv_Info.AllowUserToDeleteRows = false;
            this.dtgv_Info.AllowUserToResizeColumns = false;
            this.dtgv_Info.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgv_Info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_Info.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgv_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_Info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_Info.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Info.ColumnHeadersHeight = 40;
            this.dtgv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_Info.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgv_Info.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_Info.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_Info.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_Info.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_Info.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgv_Info.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_Info.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_Info.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_Info.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_Info.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgv_Info.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_Info.CurrentTheme.Name = null;
            this.dtgv_Info.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_Info.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_Info.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_Info.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_Info.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Info.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Info.EnableHeadersVisualStyles = false;
            this.dtgv_Info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_Info.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_Info.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv_Info.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_Info.Location = new System.Drawing.Point(0, 65);
            this.dtgv_Info.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_Info.Name = "dtgv_Info";
            this.dtgv_Info.ReadOnly = true;
            this.dtgv_Info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Info.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_Info.RowHeadersVisible = false;
            this.dtgv_Info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_Info.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_Info.RowTemplate.Height = 40;
            this.dtgv_Info.RowTemplate.ReadOnly = true;
            this.dtgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_Info.ShowEditingIcon = false;
            this.dtgv_Info.Size = new System.Drawing.Size(1500, 536);
            this.dtgv_Info.TabIndex = 18;
            this.dtgv_Info.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1500, 600);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dtgv_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton btClose;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgv_Info;
    }
}