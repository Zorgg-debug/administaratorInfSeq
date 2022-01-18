using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace administaratorInfSeq
{
    public class AdministratorInfo : INotifyPropertyChanged
    {
        Control control;
        public SeriesCollection seriesCollectionStatusComputers { get; set;}
        public SeriesCollection seriesCollectionVirusActivity { get; set; }
        public Table tableInf { get { return _tableInf; } set { _tableInf = value; OnPropertyChanged("tableInf"); } }
        internal List<Tuple<string, string, string, string>> resultsVirusActivity { get { return _results; } set { _results = value; setInfo(); } }
        List<Tuple<string, string, string, string>> _results;
        private Table _tableInf;
        internal List<Tuple<string, double>> _chartsInfoStatusComputers;
        internal List<Tuple<string, double>> chartsInfoStatusComputers { get { return _chartsInfoStatusComputers; } set { _chartsInfoStatusComputers = value; SetSeriesCollection(); } }
        internal List<Tuple<string, double>> _chartsVirusActivity;
        internal List<Tuple<string, double>> chartsVirusActivity { get { return _chartsVirusActivity; } set { _chartsVirusActivity = value; SetSeriesCollectionVirusHistory(); } }
        public string[] labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        internal AdministratorInfo(Control control)
        {
            this.control = control;
        }
        private void setInfo()
        {
            TableRow tableRow;
            TableCell tableCell;
            _tableInf = new Table();
            _tableInf.TextAlignment = TextAlignment.Center;
            _tableInf.Foreground = Brushes.White;
            _tableInf.FontFamily = new FontFamily("Arial");
            SolidColorBrush brush = new BrushConverter().ConvertFromString("#16274a") as SolidColorBrush;
            brush.Opacity = 0.8;
            for (int i = 0; i < 4; i++)
            {
                _tableInf.Columns.Add(new TableColumn());
            }
            _tableInf.RowGroups.Add(new TableRowGroup());
            tableRow = new TableRow();
            _tableInf.RowGroups[0].Rows.Add(tableRow);
            tableCell = new TableCell(new Paragraph(new Run("Дата выявления угрозы")));
            tableCell.Background = new BrushConverter().ConvertFromString("#1066a4") as SolidColorBrush;
            _tableInf.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Файл")));
            tableCell.Background = new BrushConverter().ConvertFromString("#8c604c") as SolidColorBrush;
            _tableInf.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Угроза")));
            tableCell.Background = new BrushConverter().ConvertFromString("#FFD13B23") as SolidColorBrush;
            _tableInf.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Объект")));
            tableCell.Background = new BrushConverter().ConvertFromString("#0da186") as SolidColorBrush;
            _tableInf.RowGroups[0].Rows[0].Cells.Add(tableCell);
            for (int i = 0; i < resultsVirusActivity.Count(); i++)
            {
                this._tableInf.RowGroups[0].Rows.Add(new TableRow());
                tableRow = this._tableInf.RowGroups[0].Rows.Last();
                tableRow.Cells.Add(new TableCell(new Paragraph(new Run(resultsVirusActivity[i].Item1.ToString()))));
                tableRow.Cells.Add(new TableCell(new Paragraph(new Run(resultsVirusActivity[i].Item2.ToString()))));
                tableRow.Cells.Add(new TableCell(new Paragraph(new Run(resultsVirusActivity[i].Item3.ToString()))));
                tableRow.Cells.Add(new TableCell(new Paragraph(new Run(resultsVirusActivity[i].Item4.ToString()))));
                tableRow.Cells[0].Background = brush;
                tableRow.Cells[1].Background = brush;
                tableRow.Cells[2].Background = brush;
                tableRow.Cells[3].Background = brush;
            }

        }
        internal void SetSeriesCollection()
        {
            seriesCollectionStatusComputers = new SeriesCollection();
            foreach(var item in chartsInfoStatusComputers)
            {
                seriesCollectionStatusComputers.Add(new PieSeries { Title = item.Item1, Values = new ChartValues<ObservableValue> { new ObservableValue (item.Item2) }, DataLabels = true, Foreground = Brushes.White, FontSize = 20});
            }
            
        }
        internal void SetSeriesCollectionVirusHistory()
        {
            seriesCollectionVirusActivity = new SeriesCollection();
            labels = (from itm in chartsVirusActivity orderby itm.Item1 select itm.Item1.Replace("0:00:00","")).ToArray();
            Formatter = value => value.ToString("N");
            seriesCollectionVirusActivity.Add(new ColumnSeries { Values = new ChartValues<double>(from itm in chartsVirusActivity orderby itm.Item1 select Convert.ToDouble(itm.Item2)) } );
            
        }
        public void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}