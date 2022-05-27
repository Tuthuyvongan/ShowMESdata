
namespace SMESData.View
{
    partial class UC_MQC_BarChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MQC_BarChart));
            this.lineBCCanvas = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.lineOPChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.lineRWChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.lineNGChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.dtpChart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.SuspendLayout();
            // 
            // lineBCCanvas
            // 
            this.lineBCCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineBCCanvas.AnimationDuration = 2000;
            this.lineBCCanvas.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.lineBCCanvas.BackColor = System.Drawing.Color.White;
            this.lineBCCanvas.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.lineBCCanvas.Labels = new string[0];
            this.lineBCCanvas.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.start;
            this.lineBCCanvas.LegendDisplay = true;
            this.lineBCCanvas.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBCCanvas.LegendForeColor = System.Drawing.Color.Black;
            this.lineBCCanvas.LegendFullWidth = false;
            this.lineBCCanvas.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.lineBCCanvas.LegendRevese = false;
            this.lineBCCanvas.LegendRTL = false;
            this.lineBCCanvas.Location = new System.Drawing.Point(0, 41);
            this.lineBCCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineBCCanvas.Name = "lineBCCanvas";
            this.lineBCCanvas.Padding = new System.Windows.Forms.Padding(0, 0, 290, 100);
            this.lineBCCanvas.ShowXAxis = true;
            this.lineBCCanvas.ShowYAxis = true;
            this.lineBCCanvas.Size = new System.Drawing.Size(1807, 992);
            this.lineBCCanvas.TabIndex = 5;
            this.lineBCCanvas.Title = "";
            this.lineBCCanvas.TitleLineHeight = 1.2D;
            this.lineBCCanvas.TitlePadding = 10;
            this.lineBCCanvas.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.lineBCCanvas.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineBCCanvas.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineBCCanvas.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.lineBCCanvas.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.lineBCCanvas.TooltipsEnabled = true;
            this.lineBCCanvas.XAxesBeginAtZero = true;
            this.lineBCCanvas.XAxesDrawTicks = true;
            this.lineBCCanvas.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineBCCanvas.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.lineBCCanvas.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineBCCanvas.XAxesGridLines = true;
            this.lineBCCanvas.XAxesLabel = "";
            this.lineBCCanvas.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineBCCanvas.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.lineBCCanvas.XAxesLineWidth = 1;
            this.lineBCCanvas.XAxesStacked = false;
            this.lineBCCanvas.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineBCCanvas.XAxesZeroLineWidth = 1;
            this.lineBCCanvas.YAxesBeginAtZero = true;
            this.lineBCCanvas.YAxesDrawTicks = true;
            this.lineBCCanvas.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineBCCanvas.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.lineBCCanvas.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineBCCanvas.YAxesGridLines = true;
            this.lineBCCanvas.YAxesLabel = "";
            this.lineBCCanvas.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineBCCanvas.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.lineBCCanvas.YAxesLineWidth = 1;
            this.lineBCCanvas.YAxesStacked = false;
            this.lineBCCanvas.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineBCCanvas.YAxesZeroLineWidth = 1;
            // 
            // lineOPChart
            // 
            this.lineOPChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("lineOPChart.BackgroundColor")));
            this.lineOPChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("lineOPChart.BorderColor")));
            this.lineOPChart.BorderSkipped = null;
            this.lineOPChart.BorderWidth = 0;
            this.lineOPChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("lineOPChart.Data")));
            this.lineOPChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.lineOPChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.lineOPChart.HoverBorderWidth = 0;
            this.lineOPChart.Label = "OUTPUT";
            this.lineOPChart.TargetCanvas = null;
            // 
            // lineRWChart
            // 
            this.lineRWChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("lineRWChart.BackgroundColor")));
            this.lineRWChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("lineRWChart.BorderColor")));
            this.lineRWChart.BorderSkipped = null;
            this.lineRWChart.BorderWidth = 0;
            this.lineRWChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("lineRWChart.Data")));
            this.lineRWChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.lineRWChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.lineRWChart.HoverBorderWidth = 0;
            this.lineRWChart.Label = "RE WORK";
            this.lineRWChart.TargetCanvas = null;
            // 
            // lineNGChart
            // 
            this.lineNGChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("lineNGChart.BackgroundColor")));
            this.lineNGChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("lineNGChart.BorderColor")));
            this.lineNGChart.BorderSkipped = null;
            this.lineNGChart.BorderWidth = 0;
            this.lineNGChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("lineNGChart.Data")));
            this.lineNGChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.lineNGChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.lineNGChart.HoverBorderWidth = 0;
            this.lineNGChart.Label = "NO GOOD";
            this.lineNGChart.TargetCanvas = null;
            // 
            // dtpChart
            // 
            this.dtpChart.BackColor = System.Drawing.Color.Transparent;
            this.dtpChart.BorderColor = System.Drawing.Color.Silver;
            this.dtpChart.BorderRadius = 1;
            this.dtpChart.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChart.Color = System.Drawing.Color.Silver;
            this.dtpChart.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpChart.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpChart.DisabledColor = System.Drawing.Color.Gray;
            this.dtpChart.DisplayWeekNumbers = false;
            this.dtpChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpChart.DPHeight = 0;
            this.dtpChart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpChart.FillDatePicker = false;
            this.dtpChart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpChart.ForeColor = System.Drawing.Color.Black;
            this.dtpChart.Icon = ((System.Drawing.Image)(resources.GetObject("dtpChart.Icon")));
            this.dtpChart.IconColor = System.Drawing.Color.DodgerBlue;
            this.dtpChart.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpChart.LeftTextMargin = 5;
            this.dtpChart.Location = new System.Drawing.Point(0, 0);
            this.dtpChart.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpChart.Name = "dtpChart";
            this.dtpChart.Size = new System.Drawing.Size(190, 34);
            this.dtpChart.TabIndex = 6;
            this.dtpChart.Value = new System.DateTime(2022, 5, 26, 11, 50, 30, 0);
            this.dtpChart.ValueChanged += new System.EventHandler(this.dtpChart_ValueChanged);
            // 
            // UC_MQC_BarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtpChart);
            this.Controls.Add(this.lineBCCanvas);
            this.Name = "UC_MQC_BarChart";
            this.Size = new System.Drawing.Size(1807, 1033);
            this.Load += new System.EventHandler(this.UC_MQC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Charts.WinForms.BunifuChartCanvas lineBCCanvas;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart lineOPChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart lineRWChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart lineNGChart;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpChart;
    }
}
