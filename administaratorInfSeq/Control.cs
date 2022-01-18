using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;
using CefSharp;
using CefSharp.Wpf;
using OfficeOpenXml;

namespace administaratorInfSeq
{
    /// <summary>
    /// класс управления всем 
    /// </summary>
    public class Control
    {
        Database db;
        ServerView sv;
        ChromiumWebBrowser browser;
        MainWindow mw;
        TablesAudit tablesAudit;
        SolidColorBrush brush = new BrushConverter().ConvertFromString("#16274a") as SolidColorBrush;
        internal SolidColorBrush red = new BrushConverter().ConvertFromString("#FFFD4040") as SolidColorBrush;
        internal SolidColorBrush green = new BrushConverter().ConvertFromString("#5ab563") as SolidColorBrush;
        internal Control(MainWindow mw)
        {
            this.mw = mw;
            db = new Database();
            sv = new ServerView();
            tablesAudit = new TablesAudit();
            brush.Opacity = 0.8;
            InitialiseBrowser();
        }

        /// <summary>
        /// выборка и установка данных для SynhroseView
        /// </summary>
        /// <param name="sv">страница SynhroseView</param>
        internal void SetSynhronizationValues(SynhroseView sv)
        {
            sv.csZvo = db.GetInformationSynhronise("Текст");
            sv.Zvo = db.GetInformationSynhronise("Текст");
            sv.csVvo = db.GetInformationSynhronise("Текст");
            sv.Vvo = db.GetInformationSynhronise("Текст");
            sv.csSf = db.GetInformationSynhronise("Текст");
            sv.Sf = db.GetInformationSynhronise("Текст");
            sv.csCvo = db.GetInformationSynhronise("Текст");
            sv.Cvo = db.GetInformationSynhronise("Текст");
            sv.csUvo = db.GetInformationSynhronise("Текст");
            sv.Uvo = db.GetInformationSynhronise("Текст");
            sv.statusServers();
            sv.SetValue(sv.csZvo, sv.Zvo);
        }
        /// <summary>
        /// выборка и установка данных для ImportView
        /// </summary>
        /// <param name="iv">страница ImportView</param>
        internal void SetImportValues(ImportView iv)
        {
            iv.info.bankDetails = db.GetInformationImport("Текст");
            iv.info.inn = db.GetInformationImport("Текст");
            iv.info.F = db.GetInformationImport("Текст");
            iv.info.familyStatus = db.GetInformationImport("Текст");
            iv.info.family = db.GetInformationImport("Текст");
            iv.info.adress = db.GetInformationImport("Текст");
            iv.info.cardIden = db.GetInformationImport("Текст");
            iv.info.institute = db.GetInformationImport("Текст");
            iv.info.maidenName = db.GetInformationImport("Текст");
            iv.info.nationality = db.GetInformationImport("Текст");
            iv.info.pasport = db.GetInformationImport("Текст");
            iv.info.placeBirth = db.GetInformationImport("Текст");
            iv.info.rank = db.GetInformationImport("Текст");
            iv.info.regAdress = db.GetInformationImport("Текст");
            iv.info.persIden = db.GetInformationImport("Текст");
            iv.info.tabelNumber = db.GetInformationImport("Текст");
            iv.info.BD = db.GetInformationImport("Текст");
            iv.info.cardBD = db.GetInformationImport("Текст");
            iv.info.snils = db.GetInformationImport("Текст");
            iv.info.markers = db.GetInformationImport("Текст");
            iv.DataContext = iv.info;
        }
        /// <summary>
        /// выборка и установка данных для ReportView
        /// </summary>
        /// <param name="rv">страница ReportView</param>
        internal void SetReportValues(ReportView rv)
        {
            rv.RankCategoryInfo = db.GetInformationReports("Текст");
            rv.UvolInThisYearInfo = db.GetInformationReports("Текст");
            rv.PekInfo = db.GetInformationReports("Текст");
            rv.RasporInfo = db.GetInformationReports("Текст");
            rv.SetInfo();
            rv.control = this;
        }
        /// <summary>
        /// выборка и установка данных для AuditView
        /// </summary>
        /// <param name="av">страница AuditView</param>
        internal void SetAuditValues(AuditView av)
        {
            av.audit.rankOut = db.GetInformationAudit("Текст");
            av.audit.contr = db.GetInformationAudit("Текст");
            av.audit.institute = db.GetInformationAudit("Текст");
            av.audit.periods = db.GetInformationAudit("Текст");
            av.audit.pk = db.GetInformationAudit("Текст");
            av.audit.militarydistrict = db.GetInformationAudit("Текст");
            av.audit.pkVSkpu = db.GetInformationAudit("Текст");
            av.audit.shtat = db.GetInformationAudit("Текст");
            av.audit.bezvz = db.GetInformationAudit("Текст");
        }
        /// <summary>
        /// выборка и установка данных для таблицы из ServerView
        /// </summary>
        /// <param name="sv">страница ServerView</param>
        internal void SetMarksServersInfo(ServerView sv)
        {
            var res = db.GetInformationMarks();
            sv.GetNewTableRow(res);
        }
        /// <summary>
        /// обновление браузера при переходе на разные сервера
        /// </summary>
        /// <param name="nameServer"></param>
        internal void SetserverViev(string nameServer)
        {
            string url = db.GetUrlServerZabbix(nameServer);
            browser.Load(url);
            if (mw.main.DataContext is  ServerView)
            {
            }
            else
            {
                mw.main.DataContext = sv;
            }
        }
        /// <summary>
        /// инициализация браузера с указанием использования кэша
        /// </summary>
        internal void InitialiseBrowser()
        {
            var cache = System.IO.Path.Combine(Environment.CurrentDirectory, "cache");
            if (!System.IO.Directory.Exists(cache))
                System.IO.Directory.CreateDirectory(cache);
            var settings = new CefSettings() { CachePath = cache };
            Cef.Initialize(settings);
            browser = new ChromiumWebBrowser(db.GetUrlServerZabbix("Текст"))
            {
                BrowserSettings =
                {
                    DefaultEncoding = "UTF-8"
                }
            };
            browser.RequestHandler = new BearerAuthRequestHandler("eyJrIjoiVjc3SGZMeElxbHJBWXRzTlFRdVllMFdCRks2eTZodlkiLCJuIjoidGVzdCIsImlkIjoxfQ==");
            sv.Wbs.Children.Add(browser);
            SetMarksServersInfo(sv);
        }
        /// <summary>
        /// смена страниц во фрейме
        /// </summary>
        /// <param name="page"></param>
        internal void SetValueDataContext(Page page)
        {
            mw.main.DataContext = null;
            mw.main.DataContext = page;
        }
        internal void StartGcContext()
        {
            GC.Collect();
        }
        /// <summary>
        /// установка контекста в центральный фрейм
        /// </summary>
        /// <param name="name">имя запроса</param>
        /// <param name="colums">количество колонок</param>
        /// <param name="query">запросы</param>
        /// <param name="pageBack">страница для привязки кнопки назад</param>
        /// <param name="filePath"></param>
        internal void SetValueDataContextTable(string name, string colums, string query, Page pageBack)
        {
            ShowTable shwTable = new ShowTable(this);
            var tables = ShowTable(name, colums, query);
            shwTable.page = pageBack;
            foreach (var e in tables)
                shwTable.TableShowler.Blocks.Add(e);
            SetValueDataContext(shwTable);
        }
        /// <summary>
        /// выборка и установка данных в administartionView
        /// </summary>
        /// <param name="administartionView">страница administartionView</param>
        internal void SetAdministratorInfo(administartionView administartionView)
        {
            administartionView.administratorInfo = new AdministratorInfo(this);
            administartionView.administratorInfo.resultsVirusActivity = db.GetVirusActivity();
            administartionView.administratorInfo.chartsInfoStatusComputers = db.GetStatusComputers();
            administartionView.administratorInfo.chartsVirusActivity = db.GetVirusHistory();
            administartionView.fd_virusActivity.Blocks.Add(administartionView.administratorInfo.tableInf);
        }
        /// <summary>
        /// Отработка главных кнопок на форме и подгрузка соответствующей информации
        /// </summary>
        /// <param name="namePage">имя страницы</param>
        internal void SetValueIntoFrameFromLeftPanel(string namePage)
        {
            Page newPage = default;
            switch(namePage)
            {
                case "import":
                    newPage = new ImportView(this);
                    SetImportValues(newPage as ImportView);
                    break;
                case "report":
                    newPage = new ReportView(this);
                    SetReportValues(newPage as ReportView);
                    break;
                case "audit":
                    newPage = new AuditView(this);
                    SetAuditValues(newPage as AuditView);
                    break;
                case "synhronise":
                    newPage = new SynhroseView(this);
                    SetSynhronizationValues(newPage as SynhroseView);
                    break;
                case "administration":
                    newPage = new administartionView();
                    SetAdministratorInfo(newPage as administartionView);
                    break;
            }

            SetValueDataContext(newPage);
            StartGcContext();
        }

        /// <summary>
        /// выбор таблиц
        /// </summary>
        /// <param name="name">наименование таблицы</param>
        /// <param name="colums">количество колонок</param>
        /// <param name="query">запрос для базы данных</param>
        /// <returns></returns>
        private List<Table> ShowTable(string name, string colums, string query)
        {
            List<Table> tables = new List<Table>();
            string[] idQuery = query.Split(';');
            string[] idColums = colums.Split(';');
            switch(name)
            {
                case "Текст":
                    tables.Add(tablesAudit.GetRankOutTableOne());
                    tables.Add(tablesAudit.GetRankTableTwo());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetTableContract());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetInstituteTable());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetPeriodsTable());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetNotPkTable());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetRaspor());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetChangesPkVsKpu());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetShtatTable());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetBezvz());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetTableCountMilitaryPeople());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetBezvz());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetTableCountPek());
                    break;
                case "Текст":
                    tables.Add(tablesAudit.GetBezvz());
                    break;
            }
            
            for (int i =0; i<idQuery.Count();i++)
            {
                var tableInfo = db.RunQueryAndReturnResult(db.GetQuery(idQuery[i]), Convert.ToInt32(idColums[i]));
                SetInformationIntoTable(tables[i], tableInfo);
            }
            return tables;
        }
    
        /// <summary>
        /// запись данных в таблицу из базы данных
        /// </summary>
        /// <param name="table">таблица</param>
        /// <param name="info">информация</param>
        /// <param name="statusLastColumn">статус, по отображению последней колонки</param>
        private void SetInformationIntoTable(Table table, List<string[]> info, bool statusLastColumn = true)
        {
            TableRow tblRow;
            TableCell tblCell;
            for(int i=0;i<info.Count();i++)
            {
                tblRow = new TableRow();
                for(int j=0;j<info[i].Count();j++)
                {
                    tblCell = new TableCell(new Paragraph(new Run(info[i][j])));
                    tblCell.Background = brush;
                    if (j != info[i].Count() - 1)
                        tblRow.Cells.Add(tblCell);
                    else if (statusLastColumn)
                        tblRow.Cells.Add(tblCell);
                }
                table.RowGroups[0].Rows.Add(tblRow);
            }
            if (((Run)(((Paragraph)table.RowGroups[0].Rows[0].Cells[0].Blocks.FirstOrDefault()).Inlines.FirstInline)).Text == "Текст")
            {
                for (int i = 0; i < table.RowGroups[0].Rows.Count(); i++)
                {
                    if (i >= 3)
                    {
                        for (int j = 1; j < 6; j++)
                        {
                            if (((Run)(((Paragraph)table.RowGroups[0].Rows[i].Cells[j].Blocks.FirstOrDefault()).Inlines.FirstInline)).Text !=
                                ((Run)(((Paragraph)table.RowGroups[0].Rows[i].Cells[j + 5].Blocks.FirstOrDefault()).Inlines.FirstInline)).Text)
                            {
                                table.RowGroups[0].Rows[i].Cells[j].Foreground = green;
                                table.RowGroups[0].Rows[i].Cells[j + 5].Foreground = red;
                            }
                        }

                    }
                }
            }
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <param name="nameInformation">имя таблицы</param>
        /// <param name="pageBack">ссылка на предыдущее окно</param>
        /// <param name="nameServer">имя сервера</param>
        /// <param name="lastNameColumn">имя последней колонки</param>
        /// <param name="statuslastcolumn">отображение последней колонки</param>
        internal void ShowTablePersonal( string nameInformation, Page pageBack, string nameServer = default, string lastNameColumn = default, bool statuslastcolumn = true)
        {
            List<string[]> tableInfo;
            ShowTable shwTable = new ShowTable(this);
            Table personalTable = tablesAudit.GetPersonalTable(lastNameColumn, statuslastcolumn);
            tableInfo = db.GetPersonalInformation(nameInformation, nameServer);
            SetInformationIntoTable(personalTable, tableInfo, statuslastcolumn);
            shwTable.page = pageBack;
            shwTable.TableShowler.Blocks.Add(personalTable);
            SetValueDataContext(shwTable);
        }

        /// <summary>
        /// выборка и установка данных по пингу сервверов в StatusServers
        /// </summary>
        /// <param name="sv">страница StatusServers</param>
        internal void SetIpServers(StatusServers sv)
        {
            sv.ipServers = db.GetIpServers();
        }
        /// <summary>
        /// выборка данных по пути видеоролика
        /// </summary>
        /// <param name="commandText">имя команды</param>
        /// <param name="statusSex">выбранный голос</param>
        /// <returns></returns>
        internal string GetVideoPath(string commandText, string statusSex)
        {
            return db.GetVideoPath(commandText, statusSex);
        }
        /// <summary>
        /// активация модуля
        /// </summary>
        /// <param name="status"></param>
        internal void ActiveModule(int status)
        {
            if(status == 1)
            {
                mw.img_statusProgram.Height = 87;
                mw.img_statusProgram.Width = 88;
                mw.img_statusProgram.Margin = new Thickness(0, -25, 0, 0);
                mw.img_statusProgram.Source = new BitmapImage( new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, @"resources\FaceOn.png")));
                mw.tb_Header.Foreground = new SolidColorBrush(Colors.LightGreen);
                playSound("activeForm");
            }
            else
            {
                mw.img_statusProgram.Height = 50;
                mw.img_statusProgram.Width = 45;
                mw.img_statusProgram.Margin = new Thickness(0, 0, 0, 0);
                mw.img_statusProgram.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, @"resources\Face.png")));
                mw.tb_Header.Foreground = new SolidColorBrush(Colors.White);
            }
        }
        /// <summary>
        /// запуск анимации 
        /// </summary>
        /// <param name="nameControl">имя команды</param>
        internal void StartAnimation(string nameControl)
        {
            mw.startAnimation(GetVideoPath(nameControl, StatusSex.status));
        }
        /// <summary>
        /// проигрываание звуков
        /// </summary>
        /// <param name="action">вариант звука - activeform активация формы иначе проигрывается щелчок</param>
        internal void playSound(string action)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            if(action == "activeForm")
                mediaPlayer.Open(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, @"resources\music\openForm.mp3")));
            else
                mediaPlayer.Open(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, @"resources\music\soundAction.mp3")));
            mediaPlayer.Volume = 2;
            mediaPlayer.Play();
        }
    }
}
