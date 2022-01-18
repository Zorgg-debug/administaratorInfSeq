using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace administaratorInfSeq
{
    /// <summary>
    /// Логика взаимодействия для ReportView.xaml
    /// </summary>
    public partial class ReportView : Page
    {
        public Control control;
        public ReportView(Control control)
        {
            InitializeComponent();
            DataContext = this;
            this.control = control;
        }

        public SeriesCollection RankCategory { get; set; }
        public SeriesCollection UvolInThisYear { get; set; }
        public SeriesCollection Pek { get; set; }
        public SeriesCollection Raspor { get; set; }

        public InformationReport RankCategoryInfo { get; set; }
        public InformationReport UvolInThisYearInfo { get; set; }
        public InformationReport PekInfo { get; set; }
        public InformationReport RasporInfo { get; set; }

        internal void SetInfo()
        {
            RankCategory = SetInfoOnDiagrem(RankCategoryInfo);
            UvolInThisYear = SetInfoOnDiagrem( UvolInThisYearInfo);
            Pek = SetInfoOnDiagrem(PekInfo);
            Raspor =  SetInfoOnDiagrem(RasporInfo);
        }
        private SeriesCollection SetInfoOnDiagrem( InformationReport info)
        {
            SeriesCollection res = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Офицеры",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(info.oficers) },
                    DataLabels = true, Fill = new BrushConverter().ConvertFromString("#8e83fd") as SolidColorBrush,
                    FontSize = 16,
                    StrokeThickness = 0,
                    Stroke = null

                },
                new PieSeries
                {
                    Title = "Прапорщики (мичманы)",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(info.prapor) },
                    DataLabels = true, Fill = new BrushConverter().ConvertFromString("#72a8fa") as SolidColorBrush,
                    FontSize = 16,
                    StrokeThickness = 0,
                    Stroke = null
                },
                new PieSeries
                {
                    Title = "Солдаты (сержанты)",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(info.solder) },
                    DataLabels = true,
                    Fill = new BrushConverter().ConvertFromString("#a4d479") as SolidColorBrush,
                    FontSize = 16,
                    StrokeThickness = 0,
                    Stroke = null

                }
            };
            return res;
        }

        internal void Rank_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContext(new ReportFullScreen(RankCategoryInfo,this, control, "MainReportFullRank"));
            control.StartAnimation("MainReportRank");
        }

        internal void Pekel_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContext(new ReportFullScreen(PekInfo, this, control, "MainReportFullPek"));
            control.StartAnimation("MainReportPek");
        }

        internal void Uvol_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContext(new ReportFullScreen(UvolInThisYearInfo, this, control, "MainReportFullUvol"));
            control.StartAnimation("MainReportUvol");
        }

        internal void Rasporel_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContext(new ReportFullScreen(RasporInfo, this, control, "MainReportFullRaspor"));
            control.StartAnimation("MainReportRaspor");
        }
    }
}
