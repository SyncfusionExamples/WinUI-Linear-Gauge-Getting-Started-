
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LinearGaugeGettingStartedDesktop
{
    using Microsoft.UI.Xaml;
    using Microsoft.UI;
    using Microsoft.UI.Xaml.Controls;
    using Microsoft.UI.Xaml.Media;
    using Syncfusion.UI.Xaml.Gauges;
    using Windows.Foundation;

    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //SfLinearGauge sfLinearGauge = new SfLinearGauge();
            //sfLinearGauge.Axis.Maximum = 140;
            //sfLinearGauge.Axis.Interval = 10;

            //LinearGaugeRange gaugeRange1 = new LinearGaugeRange();
            //gaugeRange1.StartValue = 0;
            //gaugeRange1.EndValue = 50;
            //gaugeRange1.Background = new SolidColorBrush(Colors.Red);
            //sfLinearGauge.Axis.Ranges.Add(gaugeRange1);

            //LinearGaugeRange gaugeRange2 = new LinearGaugeRange();
            //gaugeRange2.StartValue = 50;
            //gaugeRange2.EndValue = 100;
            //gaugeRange2.Background = new SolidColorBrush(Colors.Orange);
            //sfLinearGauge.Axis.Ranges.Add(gaugeRange2);

            //LinearGaugeRange gaugeRange3 = new LinearGaugeRange();
            //gaugeRange3.StartValue = 100;
            //gaugeRange3.EndValue = 150;
            //gaugeRange3.Background = new SolidColorBrush(Colors.Green);
            //sfLinearGauge.Axis.Ranges.Add(gaugeRange3);

            //BarPointer barPointer1 = new BarPointer();
            //barPointer1.Value = 90;
            //sfLinearGauge.Axis.BarPointers.Add(barPointer1);

            //ShapePointer shapePointer1 = new ShapePointer();
            //shapePointer1.Value = 90;
            //shapePointer1.VerticalAnchor = GaugeAnchor.End;
            //shapePointer1.OffsetPoint = new Point(0, -8);
            //sfLinearGauge.Axis.MarkerPointers.Add(shapePointer1);

            //ContentPointer contentPointer1 = new ContentPointer();
            //contentPointer1.Value = 90;
            //contentPointer1.VerticalAnchor = GaugeAnchor.End;
            //contentPointer1.OffsetPoint = new Point(0, -28);
            //contentPointer1.Content = new TextBlock { Text = "90%" };
            //sfLinearGauge.Axis.MarkerPointers.Add(contentPointer1);

            //this.Content = sfLinearGauge;
        }
    }
}