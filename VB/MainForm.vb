Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace SwiftPlotMarker
	Partial Public Class MainForm
		Inherits Form
		Private Const markerSize As Integer = 4

		Private x, y As Integer

		Private ReadOnly Property Diagram() As SwiftPlotDiagram
			Get
				Return CType(chart.Diagram, SwiftPlotDiagram)
			End Get
		End Property
		Private ReadOnly Property AxisXRange() As AxisRange
			Get
				Return Diagram.AxisX.Range
			End Get
		End Property
		Private ReadOnly Property AxisYRange() As AxisRange
			Get
				Return Diagram.AxisY.Range
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim random As New Random()
			Dim value As Double = 0
			For i As Integer = 0 To 9999
				value += random.NextDouble() - 0.5
				chart.Series(0).Points.Add(New SeriesPoint(i, value))
			Next i
		End Sub
		Private Sub chartControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
			x = e.X
			y = e.Y
			chart.Invalidate()
		End Sub
		Private Sub chartControl1_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs) Handles chart.CustomPaint
			Dim coords As DiagramCoordinates = Diagram.PointToDiagram(New Point(x, y))
			If coords.IsEmpty OrElse chart.Series(0).Points.Count = 0 Then
				Return
			End If

			Dim nearestPoint As SeriesPoint = chart.Series(0).Points(0)
			For Each point As SeriesPoint In chart.Series(0).Points
				If point.NumericalArgument = coords.NumericalArgument Then
					nearestPoint = point
					Exit For
				ElseIf Math.Abs(nearestPoint.NumericalArgument - coords.NumericalArgument) > Math.Abs(point.NumericalArgument - coords.NumericalArgument) Then
					nearestPoint = point
				End If
			Next point

			Dim pointCoords As ControlCoordinates = Diagram.DiagramToPoint(nearestPoint.NumericalArgument, nearestPoint.Values(0))
			Dim leftBottom As ControlCoordinates = Diagram.DiagramToPoint(AxisXRange.MinValueInternal, AxisYRange.MinValueInternal)
			Dim rightTop As ControlCoordinates = Diagram.DiagramToPoint(AxisXRange.MaxValueInternal, AxisYRange.MaxValueInternal)
			e.Graphics.DrawLine(Pens.Black, New Point(leftBottom.Point.X, pointCoords.Point.Y), New Point(rightTop.Point.X, pointCoords.Point.Y))
			e.Graphics.DrawLine(Pens.Black, New Point(pointCoords.Point.X, rightTop.Point.Y), New Point(pointCoords.Point.X, leftBottom.Point.Y))
			Dim markerRect As New Rectangle(pointCoords.Point.X - markerSize, pointCoords.Point.Y - markerSize, 2 * markerSize, 2 * markerSize)
			e.Graphics.FillEllipse(Brushes.Red, markerRect)
			e.Graphics.DrawEllipse(Pens.Black, markerRect)

			Dim text As String = "(" & nearestPoint.NumericalArgument.ToString() & ", " & nearestPoint.Values(0).ToString() & ")"
			Dim textSize As SizeF = e.Graphics.MeasureString(text, Font)
			Dim rect As New Rectangle(pointCoords.Point.X + markerSize, pointCoords.Point.Y + markerSize, CInt(Fix(Math.Ceiling(textSize.Width))), CInt(Fix(Math.Ceiling(textSize.Height))))
			e.Graphics.FillRectangle(Brushes.White, rect)
			e.Graphics.DrawRectangle(Pens.Black, rect)
			e.Graphics.DrawString(text, Font, Brushes.Black, rect)
		End Sub
	End Class
End Namespace
