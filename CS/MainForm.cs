using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace SwiftPlotMarker {
    public partial class MainForm : Form {
        const int markerSize = 4;

        int x, y;

        SwiftPlotDiagram Diagram { get { return (SwiftPlotDiagram)chart.Diagram; } }
        AxisRange AxisXRange { get { return Diagram.AxisX.Range; } }
        AxisRange AxisYRange { get { return Diagram.AxisY.Range; } }

        public MainForm() {
            InitializeComponent();
            Random random = new Random();
            double value = 0;
            for (int i = 0; i < 10000; i++) {
                value += random.NextDouble() - 0.5;
                chart.Series[0].Points.Add(new SeriesPoint(i, value));
            }
        }
        void chartControl1_MouseMove(object sender, MouseEventArgs e) {
            x = e.X;
            y = e.Y;
            chart.Invalidate();
        }
        void chartControl1_CustomPaint(object sender, CustomPaintEventArgs e) {
            DiagramCoordinates coords = Diagram.PointToDiagram(new Point(x, y));
            if (coords.IsEmpty || chart.Series[0].Points.Count == 0)
                return;

            SeriesPoint nearestPoint = chart.Series[0].Points[0];
            foreach (SeriesPoint point in chart.Series[0].Points) {
                if (point.NumericalArgument == coords.NumericalArgument) {
                    nearestPoint = point;
                    break;
                }
                else if (Math.Abs(nearestPoint.NumericalArgument - coords.NumericalArgument) > Math.Abs(point.NumericalArgument - coords.NumericalArgument))
                    nearestPoint = point;
            }

            ControlCoordinates pointCoords = Diagram.DiagramToPoint(nearestPoint.NumericalArgument, nearestPoint.Values[0]);
            ControlCoordinates leftBottom = Diagram.DiagramToPoint(AxisXRange.MinValueInternal, AxisYRange.MinValueInternal);
            ControlCoordinates rightTop = Diagram.DiagramToPoint(AxisXRange.MaxValueInternal, AxisYRange.MaxValueInternal);
            e.Graphics.DrawLine(Pens.Black, new Point(leftBottom.Point.X, pointCoords.Point.Y), new Point(rightTop.Point.X, pointCoords.Point.Y));
            e.Graphics.DrawLine(Pens.Black, new Point(pointCoords.Point.X, rightTop.Point.Y), new Point(pointCoords.Point.X, leftBottom.Point.Y));
            Rectangle markerRect = new Rectangle(pointCoords.Point.X - markerSize, pointCoords.Point.Y - markerSize, 2 * markerSize, 2 * markerSize);
            e.Graphics.FillEllipse(Brushes.Red, markerRect);
            e.Graphics.DrawEllipse(Pens.Black, markerRect);

            string text = "(" + nearestPoint.NumericalArgument.ToString() + ", " + nearestPoint.Values[0].ToString() + ")";
            SizeF textSize = e.Graphics.MeasureString(text, Font);
            Rectangle rect = new Rectangle(pointCoords.Point.X + markerSize, pointCoords.Point.Y + markerSize, (int)Math.Ceiling(textSize.Width), (int)Math.Ceiling(textSize.Height));
            e.Graphics.FillRectangle(Brushes.White, rect);
            e.Graphics.DrawRectangle(Pens.Black, rect);
            e.Graphics.DrawString(text, Font, Brushes.Black, rect);
        }
    }
}
