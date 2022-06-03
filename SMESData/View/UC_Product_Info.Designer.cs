
namespace SMESData
{
    partial class UC_Product_Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product_Info));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dtgv_MQC_PD = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTimeControl = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lbBox = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbS = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbM = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbH = new Bunifu.UI.WinForms.BunifuLabel();
            this.nbS = new System.Windows.Forms.NumericUpDown();
            this.nbM = new System.Windows.Forms.NumericUpDown();
            this.nbH = new System.Windows.Forms.NumericUpDown();
            this.btStart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btStop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpChart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbWar1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbModel = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbMQC = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbNG1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbRW1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbOP1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.linePCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MQCChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.PQCChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MQC_PD)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnTimeControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_MQC_PD
            // 
            this.dtgv_MQC_PD.AllowCustomTheming = true;
            this.dtgv_MQC_PD.AllowUserToAddRows = false;
            this.dtgv_MQC_PD.AllowUserToDeleteRows = false;
            this.dtgv_MQC_PD.AllowUserToResizeColumns = false;
            this.dtgv_MQC_PD.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dtgv_MQC_PD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_MQC_PD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_MQC_PD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_MQC_PD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_MQC_PD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_MQC_PD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_MQC_PD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_MQC_PD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_MQC_PD.ColumnHeadersHeight = 40;
            this.dtgv_MQC_PD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_MQC_PD.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgv_MQC_PD.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_MQC_PD.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_MQC_PD.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_MQC_PD.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_MQC_PD.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgv_MQC_PD.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_MQC_PD.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_MQC_PD.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_MQC_PD.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_MQC_PD.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgv_MQC_PD.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_MQC_PD.CurrentTheme.Name = null;
            this.dtgv_MQC_PD.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MQC_PD.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_MQC_PD.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_MQC_PD.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_MQC_PD.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_MQC_PD.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_MQC_PD.EnableHeadersVisualStyles = false;
            this.dtgv_MQC_PD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_MQC_PD.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_MQC_PD.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv_MQC_PD.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_MQC_PD.Location = new System.Drawing.Point(2, -2);
            this.dtgv_MQC_PD.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_MQC_PD.MultiSelect = false;
            this.dtgv_MQC_PD.Name = "dtgv_MQC_PD";
            this.dtgv_MQC_PD.ReadOnly = true;
            this.dtgv_MQC_PD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgv_MQC_PD.RowHeadersVisible = false;
            this.dtgv_MQC_PD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgv_MQC_PD.RowTemplate.Height = 40;
            this.dtgv_MQC_PD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_MQC_PD.Size = new System.Drawing.Size(1404, 448);
            this.dtgv_MQC_PD.TabIndex = 17;
            this.dtgv_MQC_PD.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgv_MQC_PD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MQC_PD_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnTimeControl);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.dtpChart);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(15, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 452);
            this.panel1.TabIndex = 18;
            // 
            // pnTimeControl
            // 
            this.pnTimeControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnTimeControl.BackColor = System.Drawing.Color.Transparent;
            this.pnTimeControl.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnTimeControl.BorderRadius = 1;
            this.pnTimeControl.BorderThickness = 1;
            this.pnTimeControl.Controls.Add(this.lbBox);
            this.pnTimeControl.Controls.Add(this.lbS);
            this.pnTimeControl.Controls.Add(this.lbM);
            this.pnTimeControl.Controls.Add(this.lbH);
            this.pnTimeControl.Controls.Add(this.nbS);
            this.pnTimeControl.Controls.Add(this.nbM);
            this.pnTimeControl.Controls.Add(this.nbH);
            this.pnTimeControl.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnTimeControl.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnTimeControl.Location = new System.Drawing.Point(1063, 225);
            this.pnTimeControl.Name = "pnTimeControl";
            this.pnTimeControl.PanelColor = System.Drawing.Color.White;
            this.pnTimeControl.PanelColor2 = System.Drawing.Color.White;
            this.pnTimeControl.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnTimeControl.ShadowDept = 2;
            this.pnTimeControl.ShadowDepth = 5;
            this.pnTimeControl.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnTimeControl.ShadowTopLeftVisible = false;
            this.pnTimeControl.Size = new System.Drawing.Size(165, 210);
            this.pnTimeControl.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnTimeControl.TabIndex = 37;
            // 
            // lbBox
            // 
            this.lbBox.AllowParentOverrides = false;
            this.lbBox.AutoEllipsis = true;
            this.lbBox.CursorType = null;
            this.lbBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBox.Location = new System.Drawing.Point(24, 15);
            this.lbBox.Name = "lbBox";
            this.lbBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBox.Size = new System.Drawing.Size(106, 44);
            this.lbBox.TabIndex = 6;
            this.lbBox.Text = "Choose Data \r\nUpdate Time \r\n";
            this.lbBox.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lbBox.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbS
            // 
            this.lbS.AllowParentOverrides = false;
            this.lbS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbS.AutoEllipsis = false;
            this.lbS.CursorType = null;
            this.lbS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(83, 172);
            this.lbS.Name = "lbS";
            this.lbS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbS.Size = new System.Drawing.Size(55, 19);
            this.lbS.TabIndex = 5;
            this.lbS.Text = "Seconds";
            this.lbS.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbS.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbM
            // 
            this.lbM.AllowParentOverrides = false;
            this.lbM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbM.AutoEllipsis = false;
            this.lbM.CursorType = null;
            this.lbM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.Location = new System.Drawing.Point(83, 129);
            this.lbM.Name = "lbM";
            this.lbM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbM.Size = new System.Drawing.Size(56, 19);
            this.lbM.TabIndex = 4;
            this.lbM.Text = "Minutes";
            this.lbM.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbM.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbH
            // 
            this.lbH.AllowParentOverrides = false;
            this.lbH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbH.AutoEllipsis = false;
            this.lbH.CursorType = null;
            this.lbH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH.Location = new System.Drawing.Point(83, 83);
            this.lbH.Name = "lbH";
            this.lbH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbH.Size = new System.Drawing.Size(41, 19);
            this.lbH.TabIndex = 3;
            this.lbH.Text = "Hours";
            this.lbH.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbH.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // nbS
            // 
            this.nbS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nbS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbS.Location = new System.Drawing.Point(19, 165);
            this.nbS.Name = "nbS";
            this.nbS.Size = new System.Drawing.Size(58, 26);
            this.nbS.TabIndex = 2;
            this.nbS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbS.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nbS.ValueChanged += new System.EventHandler(this.nbS_ValueChanged);
            // 
            // nbM
            // 
            this.nbM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nbM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbM.Location = new System.Drawing.Point(19, 122);
            this.nbM.Name = "nbM";
            this.nbM.Size = new System.Drawing.Size(58, 26);
            this.nbM.TabIndex = 1;
            this.nbM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbM.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nbM.ValueChanged += new System.EventHandler(this.nbM_ValueChanged);
            // 
            // nbH
            // 
            this.nbH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nbH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbH.Location = new System.Drawing.Point(19, 80);
            this.nbH.Name = "nbH";
            this.nbH.Size = new System.Drawing.Size(58, 26);
            this.nbH.TabIndex = 0;
            this.nbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbH.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nbH.ValueChanged += new System.EventHandler(this.nbH_ValueChanged);
            // 
            // btStart
            // 
            this.btStart.AllowAnimations = true;
            this.btStart.AllowMouseEffects = true;
            this.btStart.AllowToggling = false;
            this.btStart.AnimationSpeed = 200;
            this.btStart.AutoGenerateColors = false;
            this.btStart.AutoRoundBorders = false;
            this.btStart.AutoSizeLeftIcon = true;
            this.btStart.AutoSizeRightIcon = true;
            this.btStart.BackColor = System.Drawing.Color.Transparent;
            this.btStart.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStart.BackgroundImage")));
            this.btStart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStart.ButtonText = "Start Auto \r\nUpdate Product \r\nData";
            this.btStart.ButtonTextMarginLeft = 0;
            this.btStart.ColorContrastOnClick = 45;
            this.btStart.ColorContrastOnHover = 45;
            this.btStart.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btStart.CustomizableEdges = borderEdges5;
            this.btStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btStart.DisabledFillColor = System.Drawing.Color.Empty;
            this.btStart.DisabledForecolor = System.Drawing.Color.Empty;
            this.btStart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.IconLeft = null;
            this.btStart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btStart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btStart.IconMarginLeft = 11;
            this.btStart.IconPadding = 10;
            this.btStart.IconRight = null;
            this.btStart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btStart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btStart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btStart.IconSize = 25;
            this.btStart.IdleBorderColor = System.Drawing.Color.Empty;
            this.btStart.IdleBorderRadius = 0;
            this.btStart.IdleBorderThickness = 0;
            this.btStart.IdleFillColor = System.Drawing.Color.Empty;
            this.btStart.IdleIconLeftImage = null;
            this.btStart.IdleIconRightImage = null;
            this.btStart.IndicateFocus = false;
            this.btStart.Location = new System.Drawing.Point(1249, 340);
            this.btStart.Name = "btStart";
            this.btStart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btStart.OnDisabledState.BorderRadius = 1;
            this.btStart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStart.OnDisabledState.BorderThickness = 1;
            this.btStart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btStart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btStart.OnDisabledState.IconLeftImage = null;
            this.btStart.OnDisabledState.IconRightImage = null;
            this.btStart.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btStart.onHoverState.BorderRadius = 1;
            this.btStart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStart.onHoverState.BorderThickness = 1;
            this.btStart.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btStart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btStart.onHoverState.IconLeftImage = null;
            this.btStart.onHoverState.IconRightImage = null;
            this.btStart.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btStart.OnIdleState.BorderRadius = 1;
            this.btStart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStart.OnIdleState.BorderThickness = 1;
            this.btStart.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btStart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btStart.OnIdleState.IconLeftImage = null;
            this.btStart.OnIdleState.IconRightImage = null;
            this.btStart.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btStart.OnPressedState.BorderRadius = 1;
            this.btStart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStart.OnPressedState.BorderThickness = 1;
            this.btStart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btStart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btStart.OnPressedState.IconLeftImage = null;
            this.btStart.OnPressedState.IconRightImage = null;
            this.btStart.Size = new System.Drawing.Size(138, 68);
            this.btStart.TabIndex = 36;
            this.btStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btStart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btStart.TextMarginLeft = 0;
            this.btStart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btStart.UseDefaultRadiusAndThickness = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.AllowAnimations = true;
            this.btStop.AllowMouseEffects = true;
            this.btStop.AllowToggling = false;
            this.btStop.AnimationSpeed = 200;
            this.btStop.AutoGenerateColors = false;
            this.btStop.AutoRoundBorders = false;
            this.btStop.AutoSizeLeftIcon = true;
            this.btStop.AutoSizeRightIcon = true;
            this.btStop.BackColor = System.Drawing.Color.Transparent;
            this.btStop.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStop.BackgroundImage")));
            this.btStop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStop.ButtonText = "Stop Auto \r\nUpdate Product \r\nData";
            this.btStop.ButtonTextMarginLeft = 0;
            this.btStop.ColorContrastOnClick = 45;
            this.btStop.ColorContrastOnHover = 45;
            this.btStop.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btStop.CustomizableEdges = borderEdges6;
            this.btStop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btStop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btStop.DisabledFillColor = System.Drawing.Color.Empty;
            this.btStop.DisabledForecolor = System.Drawing.Color.Empty;
            this.btStop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btStop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.ForeColor = System.Drawing.Color.White;
            this.btStop.IconLeft = null;
            this.btStop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btStop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btStop.IconMarginLeft = 11;
            this.btStop.IconPadding = 10;
            this.btStop.IconRight = null;
            this.btStop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btStop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btStop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btStop.IconSize = 25;
            this.btStop.IdleBorderColor = System.Drawing.Color.Empty;
            this.btStop.IdleBorderRadius = 0;
            this.btStop.IdleBorderThickness = 0;
            this.btStop.IdleFillColor = System.Drawing.Color.Empty;
            this.btStop.IdleIconLeftImage = null;
            this.btStop.IdleIconRightImage = null;
            this.btStop.IndicateFocus = false;
            this.btStop.Location = new System.Drawing.Point(1249, 247);
            this.btStop.Name = "btStop";
            this.btStop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btStop.OnDisabledState.BorderRadius = 1;
            this.btStop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStop.OnDisabledState.BorderThickness = 1;
            this.btStop.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btStop.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btStop.OnDisabledState.IconLeftImage = null;
            this.btStop.OnDisabledState.IconRightImage = null;
            this.btStop.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btStop.onHoverState.BorderRadius = 1;
            this.btStop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStop.onHoverState.BorderThickness = 1;
            this.btStop.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btStop.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btStop.onHoverState.IconLeftImage = null;
            this.btStop.onHoverState.IconRightImage = null;
            this.btStop.OnIdleState.BorderColor = System.Drawing.Color.Orange;
            this.btStop.OnIdleState.BorderRadius = 1;
            this.btStop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStop.OnIdleState.BorderThickness = 1;
            this.btStop.OnIdleState.FillColor = System.Drawing.Color.Orange;
            this.btStop.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btStop.OnIdleState.IconLeftImage = null;
            this.btStop.OnIdleState.IconRightImage = null;
            this.btStop.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btStop.OnPressedState.BorderRadius = 1;
            this.btStop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btStop.OnPressedState.BorderThickness = 1;
            this.btStop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btStop.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btStop.OnPressedState.IconLeftImage = null;
            this.btStop.OnPressedState.IconRightImage = null;
            this.btStop.Size = new System.Drawing.Size(138, 68);
            this.btStop.TabIndex = 35;
            this.btStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btStop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btStop.TextMarginLeft = 0;
            this.btStop.TextPadding = new System.Windows.Forms.Padding(0);
            this.btStop.UseDefaultRadiusAndThickness = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.AutoEllipsis = false;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(1213, 62);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(15, 20);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "...";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpChart
            // 
            this.dtpChart.BackColor = System.Drawing.Color.Transparent;
            this.dtpChart.BorderColor = System.Drawing.Color.Silver;
            this.dtpChart.BorderRadius = 1;
            this.dtpChart.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChart.Color = System.Drawing.Color.Silver;
            this.dtpChart.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpChart.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpChart.DisabledColor = System.Drawing.Color.Gray;
            this.dtpChart.DisplayWeekNumbers = false;
            this.dtpChart.DPHeight = 0;
            this.dtpChart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpChart.FillDatePicker = false;
            this.dtpChart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpChart.ForeColor = System.Drawing.Color.Black;
            this.dtpChart.Icon = ((System.Drawing.Image)(resources.GetObject("dtpChart.Icon")));
            this.dtpChart.IconColor = System.Drawing.Color.DodgerBlue;
            this.dtpChart.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpChart.LeftTextMargin = 5;
            this.dtpChart.Location = new System.Drawing.Point(483, 50);
            this.dtpChart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChart.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpChart.Name = "dtpChart";
            this.dtpChart.Size = new System.Drawing.Size(150, 32);
            this.dtpChart.TabIndex = 33;
            this.dtpChart.Value = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            this.dtpChart.ValueChanged += new System.EventHandler(this.dtpChart_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbWar1);
            this.panel3.Controls.Add(this.bunifuLabel1);
            this.panel3.Controls.Add(this.lbModel);
            this.panel3.Controls.Add(this.lbMQC);
            this.panel3.Controls.Add(this.lbNG1);
            this.panel3.Controls.Add(this.lbRW1);
            this.panel3.Controls.Add(this.lbOP1);
            this.panel3.Controls.Add(this.linePCanvas1);
            this.panel3.Location = new System.Drawing.Point(2, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 400);
            this.panel3.TabIndex = 18;
            // 
            // lbWar1
            // 
            this.lbWar1.AllowParentOverrides = false;
            this.lbWar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWar1.AutoEllipsis = false;
            this.lbWar1.CursorType = null;
            this.lbWar1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWar1.Location = new System.Drawing.Point(120, 170);
            this.lbWar1.Name = "lbWar1";
            this.lbWar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbWar1.Size = new System.Drawing.Size(170, 55);
            this.lbWar1.TabIndex = 51;
            this.lbWar1.Text = "No Data";
            this.lbWar1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lbWar1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(3, 14);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(90, 31);
            this.bunifuLabel1.TabIndex = 50;
            this.bunifuLabel1.Text = "Model :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbModel
            // 
            this.lbModel.AllowParentOverrides = false;
            this.lbModel.AutoEllipsis = false;
            this.lbModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbModel.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbModel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(99, 14);
            this.lbModel.Name = "lbModel";
            this.lbModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbModel.Size = new System.Drawing.Size(178, 31);
            this.lbModel.TabIndex = 49;
            this.lbModel.Text = "BFFSTR3027P";
            this.lbModel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbModel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbMQC
            // 
            this.lbMQC.AllowParentOverrides = false;
            this.lbMQC.AutoEllipsis = false;
            this.lbMQC.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMQC.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbMQC.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMQC.Location = new System.Drawing.Point(350, 325);
            this.lbMQC.Name = "lbMQC";
            this.lbMQC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMQC.Size = new System.Drawing.Size(98, 45);
            this.lbMQC.TabIndex = 47;
            this.lbMQC.Text = "MQC";
            this.lbMQC.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbMQC.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbNG1
            // 
            this.lbNG1.AllowParentOverrides = false;
            this.lbNG1.AutoEllipsis = false;
            this.lbNG1.CursorType = null;
            this.lbNG1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNG1.Location = new System.Drawing.Point(350, 180);
            this.lbNG1.Margin = new System.Windows.Forms.Padding(2);
            this.lbNG1.Name = "lbNG1";
            this.lbNG1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNG1.Size = new System.Drawing.Size(87, 19);
            this.lbNG1.TabIndex = 46;
            this.lbNG1.Text = "bunifuLabel3";
            this.lbNG1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbNG1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbRW1
            // 
            this.lbRW1.AllowParentOverrides = false;
            this.lbRW1.AutoEllipsis = false;
            this.lbRW1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRW1.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbRW1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRW1.Location = new System.Drawing.Point(350, 148);
            this.lbRW1.Margin = new System.Windows.Forms.Padding(2);
            this.lbRW1.Name = "lbRW1";
            this.lbRW1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRW1.Size = new System.Drawing.Size(87, 19);
            this.lbRW1.TabIndex = 45;
            this.lbRW1.Text = "bunifuLabel2";
            this.lbRW1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbRW1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbOP1
            // 
            this.lbOP1.AllowParentOverrides = false;
            this.lbOP1.AutoEllipsis = false;
            this.lbOP1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbOP1.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbOP1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOP1.Location = new System.Drawing.Point(350, 114);
            this.lbOP1.Margin = new System.Windows.Forms.Padding(2);
            this.lbOP1.Name = "lbOP1";
            this.lbOP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOP1.Size = new System.Drawing.Size(87, 19);
            this.lbOP1.TabIndex = 44;
            this.lbOP1.Text = "bunifuLabel1";
            this.lbOP1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbOP1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // linePCanvas1
            // 
            this.linePCanvas1.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.linePCanvas1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linePCanvas1.AnimationDuration = 2000;
            this.linePCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.linePCanvas1.BackColor = System.Drawing.Color.White;
            this.linePCanvas1.CanvasPadding = new System.Windows.Forms.Padding(10, -20, 10, 30);
            this.linePCanvas1.Labels = new string[0];
            this.linePCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.start;
            this.linePCanvas1.LegendDisplay = false;
            this.linePCanvas1.LegendFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linePCanvas1.LegendForeColor = System.Drawing.Color.Black;
            this.linePCanvas1.LegendFullWidth = false;
            this.linePCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.linePCanvas1.LegendRevese = false;
            this.linePCanvas1.LegendRTL = false;
            this.linePCanvas1.Location = new System.Drawing.Point(3, 52);
            this.linePCanvas1.Margin = new System.Windows.Forms.Padding(4);
            this.linePCanvas1.Name = "linePCanvas1";
            this.linePCanvas1.ShowXAxis = true;
            this.linePCanvas1.ShowYAxis = true;
            this.linePCanvas1.Size = new System.Drawing.Size(340, 340);
            this.linePCanvas1.TabIndex = 43;
            this.linePCanvas1.Title = "";
            this.linePCanvas1.TitleLineHeight = 2D;
            this.linePCanvas1.TitlePadding = 10;
            this.linePCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.linePCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linePCanvas1.TooltipFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linePCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.linePCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.linePCanvas1.TooltipsEnabled = true;
            this.linePCanvas1.XAxesBeginAtZero = true;
            this.linePCanvas1.XAxesDrawTicks = true;
            this.linePCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linePCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.linePCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linePCanvas1.XAxesGridLines = true;
            this.linePCanvas1.XAxesLabel = "";
            this.linePCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linePCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.linePCanvas1.XAxesLineWidth = 1;
            this.linePCanvas1.XAxesStacked = false;
            this.linePCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linePCanvas1.XAxesZeroLineWidth = 1;
            this.linePCanvas1.YAxesBeginAtZero = true;
            this.linePCanvas1.YAxesDrawTicks = true;
            this.linePCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linePCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.linePCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linePCanvas1.YAxesGridLines = true;
            this.linePCanvas1.YAxesLabel = "";
            this.linePCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linePCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.linePCanvas1.YAxesLineWidth = 1;
            this.linePCanvas1.YAxesStacked = false;
            this.linePCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linePCanvas1.YAxesZeroLineWidth = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtgv_MQC_PD);
            this.panel2.Location = new System.Drawing.Point(15, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 452);
            this.panel2.TabIndex = 19;
            // 
            // MQCChart
            // 
            this.MQCChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("MQCChart.BackgroundColor")));
            this.MQCChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("MQCChart.BorderColor")));
            this.MQCChart.BorderWidth = 0;
            this.MQCChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("MQCChart.Data")));
            this.MQCChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.MQCChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.MQCChart.HoverBorderWidth = 0;
            this.MQCChart.Label = "Label here";
            this.MQCChart.TargetCanvas = null;
            // 
            // PQCChart
            // 
            this.PQCChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("PQCChart.BackgroundColor")));
            this.PQCChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("PQCChart.BorderColor")));
            this.PQCChart.BorderWidth = 0;
            this.PQCChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("PQCChart.Data")));
            this.PQCChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.PQCChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.PQCChart.HoverBorderWidth = 0;
            this.PQCChart.Label = "Label here";
            this.PQCChart.TargetCanvas = null;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Product_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Product_Info";
            this.Size = new System.Drawing.Size(1440, 946);
            this.Load += new System.EventHandler(this.UC_Product_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MQC_PD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnTimeControl.ResumeLayout(false);
            this.pnTimeControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtgv_MQC_PD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart MQCChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart PQCChart;
        private Bunifu.UI.WinForms.BunifuLabel lbWar1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lbModel;
        private Bunifu.UI.WinForms.BunifuLabel lbMQC;
        private Bunifu.UI.WinForms.BunifuLabel lbNG1;
        private Bunifu.UI.WinForms.BunifuLabel lbRW1;
        private Bunifu.UI.WinForms.BunifuLabel lbOP1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas linePCanvas1;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnTimeControl;
        private Bunifu.UI.WinForms.BunifuLabel lbBox;
        private Bunifu.UI.WinForms.BunifuLabel lbS;
        private Bunifu.UI.WinForms.BunifuLabel lbM;
        private Bunifu.UI.WinForms.BunifuLabel lbH;
        private System.Windows.Forms.NumericUpDown nbS;
        private System.Windows.Forms.NumericUpDown nbM;
        private System.Windows.Forms.NumericUpDown nbH;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btStart;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btStop;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpChart;
        private System.Windows.Forms.Timer timer1;
    }
}
