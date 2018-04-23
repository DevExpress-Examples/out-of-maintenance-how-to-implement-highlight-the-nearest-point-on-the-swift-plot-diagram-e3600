namespace SwiftPlotMarker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            swiftPlotDiagram1.AxisX.GridLines.MinorVisible = true;
            swiftPlotDiagram1.AxisX.GridLines.Visible = true;
            swiftPlotDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            swiftPlotDiagram1.AxisX.Range.SideMarginsEnabled = true;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.GridLines.MinorVisible = true;
            swiftPlotDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            swiftPlotDiagram1.AxisY.Range.SideMarginsEnabled = true;
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = swiftPlotDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Visible = false;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Black and White";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series1.Name = "Series 1";
            series1.View = swiftPlotSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.Size = new System.Drawing.Size(769, 520);
            this.chart.TabIndex = 0;
            this.chart.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.chartControl1_CustomPaint);
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartControl1_MouseMove);
            // 
            // frmSwiftPlotMarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 520);
            this.Controls.Add(this.chart);
            this.Name = "frmSwiftPlotMarker";
            this.Text = "SwiftPlot Marker";
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chart;
    }
}

