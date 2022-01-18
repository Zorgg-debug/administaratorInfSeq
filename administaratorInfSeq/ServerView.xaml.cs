
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

namespace administaratorInfSeq
{
    /// <summary>
    /// Логика взаимодействия для ServerView.xaml
    /// </summary>
    public partial class ServerView : Page
    {

        public ServerView()
        {
            InitializeComponent();
            //System.IO.Path.Combine("MyApplication", "cache")
        }
        internal void GetNewTableRow(List<Tuple<string, string, DateTime>> info = default)
        {
            SolidColorBrush brush = new BrushConverter().ConvertFromString("#16274a") as SolidColorBrush;
            brush.Opacity = 0.8;
            TableRow newRow;
            if (info == default)
            {
                tb_infoServers.RowGroups[0].Rows.Add(new TableRow());
                newRow = tb_infoServers.RowGroups[0].Rows.Last();
                newRow.Cells.Add(new TableCell(new Paragraph(new Run("Ошибок не найдено"))));
                newRow.Cells[0].BorderThickness = new Thickness(0, 0, 0, 1);
                newRow.Cells[0].BorderBrush = Brushes.White;
            }
            else
            {
                for (int i = 0; i < info.Count(); i++)
                {
                    tb_infoServers.RowGroups[0].Rows.Add(new TableRow());
                    newRow = tb_infoServers.RowGroups[0].Rows.Last();
                    newRow.Cells.Add(new TableCell(new Paragraph(new Run(info[i].Item1))));
                    newRow.Cells.Add(new TableCell(new Paragraph(new Run(info[i].Item2))));
                    newRow.Cells.Add(new TableCell(new Paragraph(new Run(info[i].Item3.ToString()))));
                    newRow.Cells[0].Background = brush;
                    newRow.Cells[1].Background = brush;
                    newRow.Cells[2].Background = brush; 
                }
            }

        }
    }
}
