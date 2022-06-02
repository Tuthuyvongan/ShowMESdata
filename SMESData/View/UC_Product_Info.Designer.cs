
namespace SMESData.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product_Info));
            this.dtgv_MQC_PD = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_PQC_PD = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMQC = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbNG1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbRW1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbOP1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.linePCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.lbWar1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbModel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MQCChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.PQCChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MQC_PD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PQC_PD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_MQC_PD
            // 
            this.dtgv_MQC_PD.AllowCustomTheming = true;
            this.dtgv_MQC_PD.AllowUserToAddRows = false;
            this.dtgv_MQC_PD.AllowUserToDeleteRows = false;
            this.dtgv_MQC_PD.AllowUserToResizeColumns = false;
            this.dtgv_MQC_PD.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            this.dtgv_MQC_PD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dtgv_MQC_PD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_MQC_PD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_MQC_PD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_MQC_PD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_MQC_PD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_MQC_PD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_MQC_PD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
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
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_MQC_PD.DefaultCellStyle = dataGridViewCellStyle33;
            this.dtgv_MQC_PD.EnableHeadersVisualStyles = false;
            this.dtgv_MQC_PD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_MQC_PD.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_MQC_PD.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv_MQC_PD.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_MQC_PD.Location = new System.Drawing.Point(23, 107);
            this.dtgv_MQC_PD.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_MQC_PD.MultiSelect = false;
            this.dtgv_MQC_PD.Name = "dtgv_MQC_PD";
            this.dtgv_MQC_PD.ReadOnly = true;
            this.dtgv_MQC_PD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgv_MQC_PD.RowHeadersVisible = false;
            this.dtgv_MQC_PD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgv_MQC_PD.RowTemplate.Height = 40;
            this.dtgv_MQC_PD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_MQC_PD.Size = new System.Drawing.Size(980, 332);
            this.dtgv_MQC_PD.TabIndex = 17;
            this.dtgv_MQC_PD.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgv_MQC_PD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MQC_PD_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtgv_MQC_PD);
            this.panel1.Location = new System.Drawing.Point(15, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 452);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtgv_PQC_PD);
            this.panel2.Location = new System.Drawing.Point(15, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 452);
            this.panel2.TabIndex = 19;
            // 
            // dtgv_PQC_PD
            // 
            this.dtgv_PQC_PD.AllowCustomTheming = true;
            this.dtgv_PQC_PD.AllowUserToAddRows = false;
            this.dtgv_PQC_PD.AllowUserToDeleteRows = false;
            this.dtgv_PQC_PD.AllowUserToResizeColumns = false;
            this.dtgv_PQC_PD.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            this.dtgv_PQC_PD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dtgv_PQC_PD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_PQC_PD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PQC_PD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_PQC_PD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_PQC_PD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_PQC_PD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_PQC_PD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dtgv_PQC_PD.ColumnHeadersHeight = 40;
            this.dtgv_PQC_PD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_PQC_PD.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgv_PQC_PD.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_PQC_PD.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_PQC_PD.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_PQC_PD.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_PQC_PD.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgv_PQC_PD.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_PQC_PD.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_PQC_PD.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_PQC_PD.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_PQC_PD.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgv_PQC_PD.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_PQC_PD.CurrentTheme.Name = null;
            this.dtgv_PQC_PD.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_PQC_PD.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_PQC_PD.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_PQC_PD.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_PQC_PD.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_PQC_PD.DefaultCellStyle = dataGridViewCellStyle36;
            this.dtgv_PQC_PD.EnableHeadersVisualStyles = false;
            this.dtgv_PQC_PD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_PQC_PD.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_PQC_PD.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv_PQC_PD.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_PQC_PD.Location = new System.Drawing.Point(23, 55);
            this.dtgv_PQC_PD.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_PQC_PD.MultiSelect = false;
            this.dtgv_PQC_PD.Name = "dtgv_PQC_PD";
            this.dtgv_PQC_PD.ReadOnly = true;
            this.dtgv_PQC_PD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgv_PQC_PD.RowHeadersVisible = false;
            this.dtgv_PQC_PD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv_PQC_PD.RowTemplate.Height = 40;
            this.dtgv_PQC_PD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_PQC_PD.Size = new System.Drawing.Size(980, 384);
            this.dtgv_PQC_PD.TabIndex = 17;
            this.dtgv_PQC_PD.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbModel);
            this.panel3.Controls.Add(this.lbWar1);
            this.panel3.Controls.Add(this.lbMQC);
            this.panel3.Controls.Add(this.lbNG1);
            this.panel3.Controls.Add(this.lbRW1);
            this.panel3.Controls.Add(this.lbOP1);
            this.panel3.Controls.Add(this.linePCanvas1);
            this.panel3.Location = new System.Drawing.Point(1007, 107);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 332);
            this.panel3.TabIndex = 18;
            // 
            // lbMQC
            // 
            this.lbMQC.AllowParentOverrides = false;
            this.lbMQC.AutoEllipsis = false;
            this.lbMQC.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMQC.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbMQC.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMQC.Location = new System.Drawing.Point(3, 3);
            this.lbMQC.Name = "lbMQC";
            this.lbMQC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMQC.Size = new System.Drawing.Size(92, 42);
            this.lbMQC.TabIndex = 38;
            this.lbMQC.Text = "MQC";
            this.lbMQC.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbMQC.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbNG1
            // 
            this.lbNG1.AllowParentOverrides = false;
            this.lbNG1.AutoEllipsis = false;
            this.lbNG1.CursorType = null;
            this.lbNG1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbNG1.Location = new System.Drawing.Point(265, 163);
            this.lbNG1.Margin = new System.Windows.Forms.Padding(2);
            this.lbNG1.Name = "lbNG1";
            this.lbNG1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNG1.Size = new System.Drawing.Size(69, 15);
            this.lbNG1.TabIndex = 37;
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
            this.lbRW1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbRW1.Location = new System.Drawing.Point(265, 131);
            this.lbRW1.Margin = new System.Windows.Forms.Padding(2);
            this.lbRW1.Name = "lbRW1";
            this.lbRW1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRW1.Size = new System.Drawing.Size(69, 15);
            this.lbRW1.TabIndex = 36;
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
            this.lbOP1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbOP1.Location = new System.Drawing.Point(265, 97);
            this.lbOP1.Margin = new System.Windows.Forms.Padding(2);
            this.lbOP1.Name = "lbOP1";
            this.lbOP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOP1.Size = new System.Drawing.Size(69, 15);
            this.lbOP1.TabIndex = 35;
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
            this.linePCanvas1.CanvasPadding = new System.Windows.Forms.Padding(6);
            this.linePCanvas1.Labels = new string[0];
            this.linePCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.start;
            this.linePCanvas1.LegendDisplay = false;
            this.linePCanvas1.LegendFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linePCanvas1.LegendForeColor = System.Drawing.Color.Black;
            this.linePCanvas1.LegendFullWidth = false;
            this.linePCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.linePCanvas1.LegendRevese = false;
            this.linePCanvas1.LegendRTL = false;
            this.linePCanvas1.Location = new System.Drawing.Point(4, 52);
            this.linePCanvas1.Margin = new System.Windows.Forms.Padding(4);
            this.linePCanvas1.Name = "linePCanvas1";
            this.linePCanvas1.ShowXAxis = true;
            this.linePCanvas1.ShowYAxis = true;
            this.linePCanvas1.Size = new System.Drawing.Size(255, 271);
            this.linePCanvas1.TabIndex = 34;
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
            // lbWar1
            // 
            this.lbWar1.AllowParentOverrides = false;
            this.lbWar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWar1.AutoEllipsis = false;
            this.lbWar1.CursorType = null;
            this.lbWar1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWar1.Location = new System.Drawing.Point(100, 120);
            this.lbWar1.Name = "lbWar1";
            this.lbWar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbWar1.Size = new System.Drawing.Size(155, 37);
            this.lbWar1.TabIndex = 40;
            this.lbWar1.Text = "bunifuLabel1";
            this.lbWar1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lbWar1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbModel
            // 
            this.lbModel.AllowParentOverrides = false;
            this.lbModel.AutoEllipsis = false;
            this.lbModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbModel.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbModel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(171, 23);
            this.lbModel.Name = "lbModel";
            this.lbModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbModel.Size = new System.Drawing.Size(127, 22);
            this.lbModel.TabIndex = 41;
            this.lbModel.Text = "BFFSTR3027P";
            this.lbModel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbModel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PQC_PD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtgv_MQC_PD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgv_PQC_PD;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuLabel lbMQC;
        private Bunifu.UI.WinForms.BunifuLabel lbNG1;
        private Bunifu.UI.WinForms.BunifuLabel lbRW1;
        private Bunifu.UI.WinForms.BunifuLabel lbOP1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas linePCanvas1;
        private Bunifu.UI.WinForms.BunifuLabel lbWar1;
        private Bunifu.UI.WinForms.BunifuLabel lbModel;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart MQCChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart PQCChart;
    }
}
