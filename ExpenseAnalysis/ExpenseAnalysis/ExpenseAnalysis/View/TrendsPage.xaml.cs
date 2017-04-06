using Syncfusion.SfChart.XForms;
using System;

namespace ExpenseAnalysis
{
    public partial class TrendsPage
    {
        public TrendsPage()
        {
            InitializeComponent();
            FastLineSeries.StrokeDashArray = new double[] { 20, 5 };
        }

        private void Axis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            DateTime date = new DateTime();
            date = date.AddDays(e.Position);
            e.LabelContent = date.ToString("MMM") + "\n" + date.ToString(" yy");
        }
    }
}
