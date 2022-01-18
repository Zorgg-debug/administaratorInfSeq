using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administaratorInfSeq
{
    /// <summary>
    /// класс управления глосом
    /// </summary>
    public class Speaker
    {
        MainWindow mw;
        Control control;
        internal ServerNamePipe namePipe;
        string controlCommand;
        string _command = "";
        public string command { get { return _command; } set { if (value != null) { _command = value; GetCommand(); } } }
        public Speaker(MainWindow mw, Control control)
        {
            this.mw = mw;
            this.control = control;
            namePipe = new ServerNamePipe(this, mw.Dispatcher);
        }
        /// <summary>
        /// получение команды и выбор действия
        /// </summary>
        private void GetCommand()
        {
            var _command = command.Split('|');
            if (_command.Count() > 1)
            {
                controlCommand = _command[1];
                StatusSex.status = _command[0];
            }
            else
                controlCommand = _command[0];
                
            switch(controlCommand)
            {
                case "StatusServer1":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridCenter1);
                    break;
                case "StatusServer2":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridCenter2);
                    break;
                case "StatusZvo":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridZvo);
                    break;
                case "StatusUvo":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridUvo);
                    break;
                case "StatusCvo":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridCvo);
                    break;
                case "StatusVvo":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridVvo);
                    break;
                case "StatusSf":
                    mw.GridserversInfo_MouseLeftButtonDown(mw.GridSf);
                    break;
                case "MainSynhr":
                    mw.tb_synchoze_MouseLeftButtonDown(mw.GridSynhronize);
                    break;
                case "MainSynhrVvo":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).gr_vvo_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_vvo);
                    }
                    break;
                case "MainSynhrZvo":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).gr_zvo_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_zvo);
                    }
                    break;
                case "MainSynhrUvo":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).gr_uvo_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_uvo);
                    }
                    break;
                case "MainSynhrCvo":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).gr_cvo_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_cvo);
                    }
                    break;
                case "MainSynhrSf":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).gr_sf_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_sf);
                    }
                    break;
                case "MainSynhrTabelnumber":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).Grid_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_tabelNumber);
                    }
                    break;
                case "MainSynhrPlaceBirth":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).Grid_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_placeBirth);
                    }
                    break;
                case "MainSynhrRegAdress":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).Grid_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_regAdress);
                    }
                    break;
                case "MainSynhrFamilyStatus":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).Grid_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_familyStatus);
                    }
                    break;
                case "MainSynhrFamily":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).Grid_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_family);
                    }
                    break;
                case "MainSynhrVinPass":
                    if (mw.main.DataContext is SynhroseView)
                    {
                        ((SynhroseView)mw.main.DataContext).Grid_MouseLeftButtonDown(((SynhroseView)mw.main.DataContext).gr_vinPas);
                    }
                    break;
                case "MainAudit":
                    mw.tb_audite_MouseLeftButtonDown(mw.GridAudit);
                    break;
                case "AuditRankOut":
                    if(mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgRankOut_MouseLeftButtonDown();
                    }
                    break;
                case "AuditPodch":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgPodch_MouseLeftButtonDown();
                    }
                    break;
                case "AuditContract":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgContract_MouseLeftButtonDown();
                    }
                    break;
                case "AuditInstitute":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgInstitute_MouseLeftButtonDown();
                    }
                    break;
                case "AuditPeriods":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgPeriods_MouseLeftButtonDown();
                    }
                    break;
                case "AuditPk":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgPk_MouseLeftButtonDown();
                    }
                    break;
                case "AuditPkVsKpu":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgPkVsKpu_MouseLeftButtonDown();
                    }
                    break;
                case "AuditShtat":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgShtat_MouseLeftButtonDown();
                    }
                    break;
                case "AuditBzv":
                    if (mw.main.DataContext is AuditView)
                    {
                        ((AuditView)mw.main.DataContext).ImgBzv_MouseLeftButtonDown();
                    }
                    break;
                case "MainReport":
                    mw.tb_Reports_MouseLeftButtonDown(mw.GridReport);
                    break;
                case "MainReportRank":
                    if (mw.main.DataContext is ReportView)
                    {
                        ((ReportView)mw.main.DataContext).Rank_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportPek":
                    if (mw.main.DataContext is ReportView)
                    {
                        ((ReportView)mw.main.DataContext).Pekel_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportUvol":
                    if (mw.main.DataContext is ReportView)
                    {
                        ((ReportView)mw.main.DataContext).Uvol_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportRaspor":
                    if (mw.main.DataContext is ReportView)
                    {
                        ((ReportView)mw.main.DataContext).Rasporel_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportFullRank":
                    if (mw.main.DataContext is ReportFullScreen)
                    {
                        ((ReportFullScreen)mw.main.DataContext).Image_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportFullUvol":
                    if (mw.main.DataContext is ReportFullScreen)
                    {
                        ((ReportFullScreen)mw.main.DataContext).Image_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportFullPek":
                    if (mw.main.DataContext is ReportFullScreen)
                    {
                        ((ReportFullScreen)mw.main.DataContext).Image_MouseLeftButtonDown();
                    }
                    break;
                case "MainReportFullRaspor":
                    if (mw.main.DataContext is ReportFullScreen)
                    {
                        ((ReportFullScreen)mw.main.DataContext).Image_MouseLeftButtonDown();
                    }
                    break;
                case "MainImport":
                    mw.tb_import_MouseLeftButtonDown(mw.GridImport);
                    break;
                case "MainImportInn":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_Inn);
                    }
                    break;
                case "MainImportF":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_F);
                    }
                    break;
                case "MainImportInstitute":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_Institute);
                    }
                    break;
                case "MainImportNationality":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_Nationality);
                    }
                    break;
                case "MainImportpasport":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_pasport);
                    }
                    break;
                case "MainImportplacebirth":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_placebirth);
                    }
                    break;
                case "MainImportpersIden":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_persIden);
                    }
                    break;
                case "MainImporttabelNumber":
                    if (mw.main.DataContext is ImportView)
                    {
                        ((ImportView)mw.main.DataContext).Grid_MouseLeftButtonDown(((ImportView)mw.main.DataContext).gr_tabelNumber);
                    }
                    break;
                case "Administration":
                    mw.GridAdministration_MouseLeftButtonDown(mw.GridAdministration);
                    break;
                case "HelloEva":
                    mw.startAnimation(control.GetVideoPath("HelloEva","1"));
                    StatusSex.status = "0";
                    break;
                case "HelloIvan":
                    mw.startAnimation(control.GetVideoPath("HelloIvan", "0"));
                    StatusSex.status = "1";
                    break;
                case "HEAD_ON":
                    control.ActiveModule(1);
                    break;
                case "HEAD_OFF":
                    control.ActiveModule(0);
                    break;
                case "Back":
                    if(mw.main.DataContext is IHavePageBack)
                    {
                        ((IHavePageBack)mw.main.DataContext).ClickBackPage();
                    }
                    break;
                case "Назад":
                    if (mw.main.DataContext is IHavePageBack)
                    {
                        ((IHavePageBack)mw.main.DataContext).ClickBackPage();
                    }
                    break;



            }
        }

    }
}
