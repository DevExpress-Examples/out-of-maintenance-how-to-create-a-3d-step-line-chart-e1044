using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;
// ...

namespace Series_3DStepLineChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl StepLineChart3D = new ChartControl();

            // Add a step line series to it.
            Series series1 = new Series("Series 1", ViewType.StepLine3D);

            // Add points to the series.
            series1.Points.Add(new SeriesPoint("A", 12));
            series1.Points.Add(new SeriesPoint("B", 4));
            series1.Points.Add(new SeriesPoint("C", 17));
            series1.Points.Add(new SeriesPoint("D", 7));
            series1.Points.Add(new SeriesPoint("E", 12));
            series1.Points.Add(new SeriesPoint("F", 4));
            series1.Points.Add(new SeriesPoint("G", 17));
            series1.Points.Add(new SeriesPoint("H", 7));

            // Add the series to the chart.
            StepLineChart3D.Series.Add(series1);

            // Access labels of the series.
            series1.LabelsVisibility = DefaultBoolean.True;

            ((Line3DSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the series options.
            series1.Label.TextPattern = "{A}: {V}";

            // Customize the view-type-specific properties of the series.
            StepLine3DSeriesView myView = (StepLine3DSeriesView)series1.View;
            myView.LineWidth = 5;
            myView.LineThickness = 4;

            // Access the diagram's options.
            ((XYDiagram3D)StepLineChart3D.Diagram).RuntimeRotation = true;
            ((XYDiagram3D)StepLineChart3D.Diagram).RotationType = RotationType.UseMouseStandard;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Step Line Chart";
            StepLineChart3D.Titles.Add(chartTitle1);
            StepLineChart3D.Legend.Visible = false;

            // Add the chart to the form.
            StepLineChart3D.Dock = DockStyle.Fill;
            this.Controls.Add(StepLineChart3D);
        }

    }
}
