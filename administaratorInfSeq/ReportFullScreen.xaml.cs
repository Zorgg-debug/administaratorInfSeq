using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace administaratorInfSeq
{
    /// <summary>
    /// Логика взаимодействия для ReportFullScreen.xaml
    /// </summary>
    public partial class ReportFullScreen : Page, IHavePageBack
    {
        Control control;
        Page pageBack;
        string nameAnimation;
        public ReportFullScreen(InformationReport chartInfo, Page pageBack, Control control, string nameAnimation)
        {
            InitializeComponent();
            this.control = control;
            this.chartInfo = chartInfo;
            this.pageBack = pageBack;
            this.nameAnimation = nameAnimation;
            setValues();

        }
        public SeriesCollection chart { get; set; }
        public InformationReport chartInfo { get; set; }
        private void setValues()
        {
            chart = SetInfoOnDiagrem(chartInfo);
            this.DataContext = this;
        }
        private SeriesCollection SetInfoOnDiagrem(InformationReport info)
        {
            SeriesCollection res = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Офицеры",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(info.oficers) },
                    DataLabels = true, Fill = new BrushConverter().ConvertFromString("#8e83fd") as SolidColorBrush,
                    FontSize = 16,
                    StrokeThickness = 0
                },
                new PieSeries
                {
                    Title = "Прапорщики (мичманы)",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(info.prapor) },
                    DataLabels = true, Fill = new BrushConverter().ConvertFromString("#72a8fa") as SolidColorBrush,
                    FontSize = 16,
                    StrokeThickness = 0
                },
                new PieSeries
                {
                    Title = "Солдаты (сержанты)",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(info.solder) },
                    DataLabels = true,
                    Fill = new BrushConverter().ConvertFromString("#a4d479") as SolidColorBrush,
                    FontSize = 16,
                    StrokeThickness = 0
                }
            };
            return res;
        }

        internal void Image_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable(chartInfo.name, chartInfo.countColumn, chartInfo.queries, this);
            control.StartAnimation(nameAnimation);
        }

        internal void Img_back_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContext(pageBack);
            control.playSound("action");
        }

        public void ClickBackPage()
        {
            Img_back_MouseLeftButtonDown();
        }
    }
}
