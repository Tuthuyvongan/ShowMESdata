
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
            this.dtpChart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lineOPChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.lineCanvas = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.lineRWChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.lineNGChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpChart
            // 
            this.dtpChart.BackColor = System.Drawing.Color.Transparent;
            this.dtpChart.BorderColor = System.Drawing.Color.Silver;
            this.dtpChart.BorderRadius = 1;
            this.dtpChart.Color = System.Drawing.Color.Silver;
            this.dtpChart.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpChart.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpChart.DisabledColor = System.Drawing.Color.Gray;
            this.dtpChart.DisplayWeekNumbers = false;
            this.dtpChart.DPHeight = 0;
            this.dtpChart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpChart.FillDatePicker = false;
            this.dtpChart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpChart.ForeColor = System.Drawing.Color.Black;
            this.dtpChart.Icon = ((System.Drawing.Image)(resources.GetObject("dtpChart.Icon")));
            this.dtpChart.IconColor = System.Drawing.Color.DodgerBlue;
            this.dtpChart.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpChart.LeftTextMargin = 5;
            this.dtpChart.Location = new System.Drawing.Point(337, 21);
            this.dtpChart.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpChart.Name = "dtpChart";
            this.dtpChart.Size = new System.Drawing.Size(137, 32);
            this.dtpChart.TabIndex = 3;
            this.dtpChart.Value = new System.DateTime(2022, 5, 25, 14, 36, 0, 0);
            this.dtpChart.ValueChanged += new System.EventHandler(this.dtpChart_ValueChanged);
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
            this.lineOPChart.TargetCanvas = this.lineCanvas;
            // 
            // lineCanvas
            // 
            this.lineCanvas.AnimationDuration = 1000;
            this.lineCanvas.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.lineCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.lineCanvas.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.lineCanvas.Labels = new string[0];
            this.lineCanvas.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.start;
            this.lineCanvas.LegendDisplay = true;
            this.lineCanvas.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCanvas.LegendForeColor = System.Drawing.Color.Black;
            this.lineCanvas.LegendFullWidth = false;
            this.lineCanvas.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.lineCanvas.LegendRevese = false;
            this.lineCanvas.LegendRTL = false;
            this.lineCanvas.Location = new System.Drawing.Point(13, 60);
            this.lineCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineCanvas.Name = "lineCanvas";
            this.lineCanvas.Padding = new System.Windows.Forms.Padding(0, 0, 250, 100);
            this.lineCanvas.ShowXAxis = true;
            this.lineCanvas.ShowYAxis = true;
            this.lineCanvas.Size = new System.Drawing.Size(1059, 429);
            this.lineCanvas.TabIndex = 4;
            this.lineCanvas.Title = "";
            this.lineCanvas.TitleLineHeight = 1.2D;
            this.lineCanvas.TitlePadding = 10;
            this.lineCanvas.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.lineCanvas.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineCanvas.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineCanvas.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.lineCanvas.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.lineCanvas.TooltipsEnabled = true;
            this.lineCanvas.XAxesBeginAtZero = true;
            this.lineCanvas.XAxesDrawTicks = true;
            this.lineCanvas.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineCanvas.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.lineCanvas.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineCanvas.XAxesGridLines = true;
            this.lineCanvas.XAxesLabel = "";
            this.lineCanvas.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineCanvas.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.lineCanvas.XAxesLineWidth = 1;
            this.lineCanvas.XAxesStacked = false;
            this.lineCanvas.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineCanvas.XAxesZeroLineWidth = 1;
            this.lineCanvas.YAxesBeginAtZero = true;
            this.lineCanvas.YAxesDrawTicks = true;
            this.lineCanvas.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineCanvas.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.lineCanvas.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineCanvas.YAxesGridLines = true;
            this.lineCanvas.YAxesLabel = "";
            this.lineCanvas.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lineCanvas.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.lineCanvas.YAxesLineWidth = 1;
            this.lineCanvas.YAxesStacked = false;
            this.lineCanvas.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineCanvas.YAxesZeroLineWidth = 1;
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
            this.lineRWChart.TargetCanvas = this.lineCanvas;
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
            this.lineNGChart.TargetCanvas = this.lineCanvas;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(823, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 556);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lineCanvas);
            this.Controls.Add(this.dtpChart);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDatePicker dtpChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart lineOPChart;
        private Bunifu.Charts.WinForms.BunifuChartCanvas lineCanvas;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart lineRWChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart lineNGChart;
        private System.Windows.Forms.TextBox textBox1;
    }
}

