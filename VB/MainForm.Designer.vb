Imports Microsoft.VisualBasic
Imports System
Namespace SwiftPlotMarker
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim swiftPlotDiagram1 As New DevExpress.XtraCharts.SwiftPlotDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim swiftPlotSeriesView1 As New DevExpress.XtraCharts.SwiftPlotSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chart
			' 
			swiftPlotDiagram1.AxisX.GridLines.MinorVisible = True
			swiftPlotDiagram1.AxisX.GridLines.Visible = True
			swiftPlotDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			swiftPlotDiagram1.AxisX.Range.SideMarginsEnabled = True
			swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram1.AxisY.GridLines.MinorVisible = True
			swiftPlotDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			swiftPlotDiagram1.AxisY.Range.SideMarginsEnabled = True
			swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = swiftPlotDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Visible = False
			Me.chart.Location = New System.Drawing.Point(0, 0)
			Me.chart.Name = "chart"
			Me.chart.PaletteName = "Black and White"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series1.Name = "Series 1"
			series1.View = swiftPlotSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(769, 520)
			Me.chart.TabIndex = 0
'			Me.chart.CustomPaint += New DevExpress.XtraCharts.CustomPaintEventHandler(Me.chartControl1_CustomPaint);
'			Me.chart.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseMove);
			' 
			' frmSwiftPlotMarker
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(769, 520)
			Me.Controls.Add(Me.chart)
			Me.Name = "frmSwiftPlotMarker"
			Me.Text = "SwiftPlot Marker"
			CType(swiftPlotDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

