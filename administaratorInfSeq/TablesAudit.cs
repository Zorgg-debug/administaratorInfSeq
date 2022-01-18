using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace administaratorInfSeq
{
    /// <summary>
    /// Класс для отрисовки таблиц 
    /// </summary>
    class TablesAudit
    {
        SolidColorBrush brushHeader = new BrushConverter().ConvertFromString("#004084") as SolidColorBrush;
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetRankOutTableOne()
        {
            List<string> rowsName = new List<string>()
            {
                "","Текст","Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 4; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 2; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 4;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetRankTableTwo()
        {
            List<string> rowsName = new List<string>()
            {
                "","Текст","Текст", "Текст", "Текст", "Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 8; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 2; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 8;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetTableContract()
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст","Текст", "Текст", "Текст", "Текст","Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 8; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetInstituteTable()
        {
            List<string> rowsName = new List<string>()
            {
                "Проверено","Не проверено","Итого:", "Проверено", "Не проверено", "Итого:"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 7; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 3; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 7;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.RowSpan = 2;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 3;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 3;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[2].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetPeriodsTable()
        {
            List<string> rowsName = new List<string>()
            {
                "Проверено","Не проверено","Итого:", "Проверено", "Не проверено", "Итого:"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 7; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 3; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 7;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.RowSpan = 2;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 3;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 3;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[2].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetNotPkTable()
        {
            List<string> rowsName = new List<string>()
            {
                "№ п/п","Текст","Текст", "Текст", "Текст", "Текст", "Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 9; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 2; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 9;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetShtatTable()
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст","Текст", "Текст", "Текст", "Текст","Текст:"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 7; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 3; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 8;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);

            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Расхождение подчиненности
        /// </summary>
        /// <returns></returns>
        internal Table GetRaspor()
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст", "Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 7; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 3; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 6;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);

            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                if (i < 3)
                {
                    tableCell.RowSpan = 2;
                    tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
                }
                else
                    tbl.RowGroups[0].Rows[2].Cells.Add(tableCell);

            }
            
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 3;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetChangesPkVsKpu()
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст", "Текст", "Текст", "Текст","Текст","Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 11; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            for (int i = 0; i < 3; i++)
            {
                tableRow = new TableRow();
                tbl.RowGroups[0].Rows.Add(tableRow);
            }
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 11;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("№ п/п")));
            tableCell.Background = brushHeader;
            tableCell.RowSpan = 2;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 5;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 5;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);

            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[2].Cells.Add(tableCell);
            }
            
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetBezvz()
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 5; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            }
            return tbl;
        }

        /// <summary>
        /// Текст
        /// </summary>
        /// <param name="lastNameColumn">Имя последней колонки</param>
        /// <param name="statusLastCoulum">Отображение последней колонки</param>
        /// <returns></returns>
        internal Table  GetPersonalTable(string lastNameColumn = default, bool statusLastCoulum = true)
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст","Текст", "Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 6; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                if (i == rowsName.Count()- 1 && lastNameColumn !=default)
                    tableCell = new TableCell(new Paragraph(new Run(lastNameColumn)));
                else
                    tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = brushHeader;
                if (i != rowsName.Count() - 1)
                    tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
                else if (statusLastCoulum)
                    tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetTableCountMilitaryPeople()
        {
            List<string> rowsName = new List<string>()
            {
                "Текст","Текст","Текст","Текст", "Текст", "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 7; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 7;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = Brushes.White;
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            }
            return tbl;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <returns></returns>
        internal Table GetTableCountPek()
        {
            List<string> rowsName = new List<string>()
            {
                "№","Текст","Текст","Текст", "Текст", "Текст", "Текст","Текст", "Текст","Текст", "Текст","Текст",
                "Текст", "Текст"
            };
            TableRow tableRow;
            TableCell tableCell;
            Table tbl = new Table();
            tbl.TextAlignment = TextAlignment.Center;
            tbl.Foreground = Brushes.White;
            tbl.FontFamily = new FontFamily("Arial");
            for (int i = 0; i < 8; i++)
            {
                tbl.Columns.Add(new TableColumn());
            }
            tbl.RowGroups.Add(new TableRowGroup());
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 14;
            tbl.RowGroups[0].Rows[0].Cells.Add(tableCell);
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            tableCell = new TableCell(new Paragraph(new Run("")));
            tableCell.Background = brushHeader;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 5;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableCell = new TableCell(new Paragraph(new Run("Текст")));
            tableCell.Background = brushHeader;
            tableCell.ColumnSpan = 8;
            tbl.RowGroups[0].Rows[1].Cells.Add(tableCell);
            tableRow = new TableRow();
            tbl.RowGroups[0].Rows.Add(tableRow);
            for (int i = 0; i < rowsName.Count(); i++)
            {
                tableCell = new TableCell(new Paragraph(new Run(rowsName[i])));
                tableCell.Background = brushHeader;
                tbl.RowGroups[0].Rows[2].Cells.Add(tableCell);
            }
            return tbl;
        }
    }
}
