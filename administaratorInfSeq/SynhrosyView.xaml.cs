using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace administaratorInfSeq
{
    /// <summary>
    /// Логика взаимодействия для SynhrosyView.xaml
    /// </summary>
    public partial class SynhroseView : Page, INotifyPropertyChanged
    {
        internal SolidColorBrush red = new BrushConverter().ConvertFromString("#fe6c3f") as SolidColorBrush;
        internal SolidColorBrush green = new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush;
        internal Control control;
        public int cardnumberOsk { get; set; }
        public int cardnumberCs { get; set; }
        public int dateBirthOsk { get; set; }
        public int dateBirthCs { get; set; }
        public int rankOsk { get; set; }
        public int rankCs { get; set; }
        public int classOsk { get; set; }
        public int ClassCs { get; set; }
        public int FOsk { get; set; }
        public int FCS { get; set; }
        public int IOsk { get; set; }
        public int ICs { get; set; }
        public int OOsk { get; set; }
        public int OCs { get; set; }
        public int sexOsk { get; set; }
        public int sexCs { get; set; }
        public int placeBirthOsk { get; set; }
        public int placeBirthCs { get; set; }
        public int homeAdressOsk { get; set; }
        public int homeAdressCs { get; set; }
        public int nationalityOsk { get; set; }
        public int nationalityCs { get; set; }
        public int tabelNumberOsk { get; set; }
        public int tabelNumberCs { get; set; }
        public int maidenNameOsk { get; set; }
        public int maidenNameCs { get; set; }
        public int regAdressOsk { get; set; }
        public int regAdressCs { get; set; }
        public int familyStatusOsk { get; set; }
        public int familyStatusCs { get; set; }
        public int instituteOsk { get; set; }
        public int instituteCs { get; set; }
        public int periodsOsk { get; set; }
        public int periodsCs { get; set; }
        public int militarydistrictOsk { get; set; }
        public int militarydistrictCs { get; set; }
        public int bankDetailsOsk { get; set; }
        public int bankdetailsCs { get; set; }
        public int innOsk { get; set; }
        public int innCs { get; set; }
        public int familyOsk { get; set; }
        public int familyCs { get; set; }
        public int BDOsk { get; set; }
        public int BDCs { get; set; }
        public int passportOsk { get; set; }
        public int passportCs { get; set; }
        public int cardIdenOsk { get; set; }
        public int cardIdenCs { get; set; }
        public int prizivPlaceOsk { get; set; }
        public int prizivPlaceCs { get; set; }
        public int nisOsk { get; set; }
        public int nisCs { get; set; }
        public int nagrOsk { get; set; }
        public int nagrCs { get; set; }
        public int cardBDOsk { get; set; }
        public int cardBDCs { get; set; }
        public int vinOsk { get; set; }
        public int vinCs { get; set; }
        public int pekOsk { get; set; }
        public int pekCs { get; set; }

        public int changesLn { get { return cardnumberCs - cardnumberOsk; } set { } }
        public int changesDateBirth { get { return dateBirthCs - dateBirthOsk; } set { } }
        public int changesRank { get { return rankCs - rankOsk; } set { } }
        public int changesClass { get { return ClassCs - classOsk; } set { } }
        public int changesF { get { return FCS - FOsk; } set { } }
        public int changesI { get { return ICs - IOsk; } set { } }
        public int changesO { get { return ICs - IOsk; } set { } }
        public int changesSex { get { return sexCs - sexOsk; } set { } }
        public int changesPlaceBirth { get { return placeBirthCs - placeBirthOsk; } set { } }
        public int changesHomeAdress { get { return homeAdressCs - homeAdressOsk; } set { } }
        public int changesNationality { get { return nationalityCs - nationalityOsk; } set { } }
        public int changesTabelnumber { get { return tabelNumberCs - tabelNumberOsk; } set { } }
        public int changesMaidenName { get { return maidenNameCs - maidenNameOsk; } set { } }
        public int changesRegAdress { get { return regAdressCs - regAdressOsk; } set { } }
        public int changesFamilyStatus { get { return familyStatusCs - familyStatusOsk; } set { } }
        public int changesInstitute { get { return instituteCs - instituteOsk; } set { } }
        public int changesPeriods { get { return periodsCs - periodsOsk; } set { } }
        public int changesMilitarydistrict { get { return militarydistrictCs - militarydistrictOsk; } set { } }
        public int changesBankDetails { get { return bankdetailsCs - bankDetailsOsk; } set { } }
        public int changesInn { get { return innCs - innOsk; } set { } }
        public int changesFamily { get { return familyCs - familyOsk; } set { } }
        public int changesBD { get { return BDCs - BDOsk; } set { } }
        public int changesPassport { get { return passportCs - passportOsk; } set { } }
        public int changesCardIden { get { return cardIdenCs - cardIdenOsk; } set { } }
        public int changesPrizivPlace { get { return prizivPlaceCs - prizivPlaceOsk; } set { } }
        public int changesNis { get { return nisCs - nisOsk; } set { } }
        public int changesNagr { get { return nagrCs - nagrOsk; } set { } }
        public int changesCardBD { get { return cardBDCs - cardBDOsk; } set { } }
        public int changesVin { get { return vinCs - vinOsk; } set { } }
        public int changesPek { get { return pekCs - pekOsk; } set { } }


        public Brush statusServerZvo { get; set; }
        public Brush statusServerCvo { get; set; }
        public Brush statusServerVvo { get; set; }
        public Brush statusServerUvo { get; set; }
        public Brush statusServerSf { get; set; }


        internal InformationSynhr csZvo;
        internal InformationSynhr Zvo;
        internal InformationSynhr csUvo;
        internal InformationSynhr Uvo;
        internal InformationSynhr csCvo;
        internal InformationSynhr Cvo;
        internal InformationSynhr csVvo;
        internal InformationSynhr Vvo;
        internal InformationSynhr csSf;
        internal InformationSynhr Sf;

        internal string changeServer = "ЗВО";
        public event PropertyChangedEventHandler PropertyChanged;


        public SynhroseView(Control control)
        {
            InitializeComponent();
            this.DataContext = this;
            this.control = control;
        }

        public void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        private void ChangeClick(object sender)
        {
            br_cvo.Background.Opacity = 0.35;
            br_sf.Background.Opacity = 0.35;
            br_Uvo.Background.Opacity = 0.35;
            br_vvo.Background.Opacity = 0.35;
            br_zvo.Background.Opacity = 0.35;
            ((Grid)sender).Children.OfType<Border>().FirstOrDefault().Background.Opacity = 0.7;
        }

        internal void SetValue(InformationSynhr cs, InformationSynhr osk)
        {
            List<string> _changed = new List<string>()
            {
                "cardnumberOsk","cardnumberCs",
                "dateBirthOsk", "dateBirthCs",
                "rankOsk","rankCs",
                "classOsk","ClassCs",
                "FOsk","FCS",
                "IOsk", "ICs",
                "OOsk","OCs",
                "sexOsk", "sexCs",
                "placeBirthOsk","placeBirthCs",
                "homeAdressOsk","homeAdressCs",
                "nationalityOsk", "nationalityCs",
                "tabelNumberOsk","tabelNumberCs",
                "maidenNameOsk","maidenNameCs",
                "regAdressOsk","regAdressCs",
                "familyStatusOsk", "familyStatusCs",
                "instituteOsk","instituteCs",
                "periodsOsk", "periodsCs",
                "militarydistrictOsk","militarydistrictCs",
                "bankDetailsOsk","bankdetailsCs",
                "innOsk","innCs",
                "familyOsk","familyCs",
                "BDOsk", "BDCs",
                "passportOsk", "passportCs",
                "cardIdenOsk", "cardIdenCs",
                "prizivPlaceOsk","prizivPlaceCs",
                "nisOsk","nisCs",
                "nagrOsk","nagrCs",
                "cardBDOsk","cardBDCs",
                "vinOsk", "vinCs",
                "pekOsk", "pekCs",
               "changesLn",
                "changesDateBirth",
                "changesRank",
                "changesClass",
                "changesF",
                "changesI",
                "changesO",
                "changesSex",
                "changesPlaceBirth",
                "changesHomeAdress",
                "changesNationality",
                "changesTabelnumber",
                "changesMaidenName",
                "changesRegAdress",
                "changesFamilyStatus",
                "changesInstitute",
                "changesPeriods",
                "changesMilitarydistrict",
                "changesBankDetails",
                "changesInn",
                "changesFamily",
                "changesBD",
                "changesPassport",
                "changesCardIden",
                "changesPrizivPlace",
                "changesNis",
                "changesNagr",
                "changesCardBD",
                "changesVin",
                "changesPek"
        };
            cardnumberOsk = osk.cardnumber;
            cardnumberCs = cs.cardnumber;
            dateBirthOsk = osk.DateBirth;
            dateBirthCs = cs.DateBirth;
            rankOsk = osk.Rank;
            rankCs = cs.Rank;
            classOsk = osk.Class;
            ClassCs = cs.Class;
            FOsk = osk.F;
            FCS = cs.F;
            IOsk = osk.I;
            ICs = cs.I;
            OOsk = osk.O;
            OCs = cs.O;
            sexOsk = osk.Sex;
            sexCs = cs.Sex;
            placeBirthOsk = osk.PlaceBirth;
            placeBirthCs = cs.PlaceBirth;
            homeAdressOsk = osk.HomeAdress;
            homeAdressCs = cs.HomeAdress;
            nationalityOsk = osk.Nationality;
            nationalityCs = cs.Nationality;
            tabelNumberOsk = osk.Tabelnumber;
            tabelNumberCs = cs.Tabelnumber;
            maidenNameOsk = osk.MaidenName;
            maidenNameCs = cs.MaidenName;
            regAdressOsk = osk.RegAdress;
            regAdressCs = cs.RegAdress;
            familyStatusOsk = osk.FamilyStatus;
            familyStatusCs = cs.FamilyStatus;
            instituteOsk = osk.Institute;
            instituteCs = cs.Institute;
            periodsOsk = osk.Periods;
            periodsCs = cs.Periods;
            militarydistrictOsk = osk.Militarydistrict;
            militarydistrictCs = cs.Militarydistrict;
            bankDetailsOsk = osk.Bankdetails;
            bankdetailsCs = cs.Bankdetails;
            innOsk = osk.Inn;
            innCs = cs.Inn;
            familyOsk = osk.Family;
            familyCs = cs.Family;
            BDOsk = osk.BD;
            BDCs = cs.BD;
            passportOsk = osk.Passport;
            passportCs = cs.Passport;
            cardIdenOsk = osk.CardIden;
            cardIdenCs = cs.CardIden;
            prizivPlaceOsk = osk.PrizivPlace;
            prizivPlaceCs = cs.PrizivPlace;
            nisOsk = osk.Nis;
            nisCs = cs.Nis;
            nagrOsk = osk.Nagr;
            nagrCs = cs.Nagr;
            cardBDOsk = osk.CardBd;
            cardBDCs = cs.CardBd;
            vinOsk = osk.Vin;
            vinCs = cs.Vin;
            pekOsk = osk.Pek;
            pekCs = cs.Pek;
            foreach (var e in _changed)
                OnPropertyChanged(e);
        }

        internal void statusServers()
        {
            if (CheckChanges(csZvo.ToList(), Zvo.ToList()))
                statusServerZvo = green;
            else
                statusServerZvo = red;
            OnPropertyChanged("statusServerZvo");
            if (CheckChanges(csVvo.ToList(), Vvo.ToList()))
                statusServerVvo = green;
            else
                statusServerVvo = red;
            OnPropertyChanged("statusServerVvo");
            if (CheckChanges(csUvo.ToList(), Uvo.ToList()))
                statusServerUvo = green;
            else
                statusServerUvo = red;
            OnPropertyChanged("statusServerUvo");
            if (CheckChanges(csCvo.ToList(), Cvo.ToList()))
                statusServerCvo = green;
            else
                statusServerCvo = red;
            OnPropertyChanged("statusServerCvo");
            if (CheckChanges(csSf.ToList(), Sf.ToList()))
                statusServerSf = green;
            else
                statusServerSf = red;
            OnPropertyChanged("statusServerSf");
        }
        private bool CheckChanges(List<int> cs, List<int> osk)
        {
            for (int i = 0; i < cs.Count(); i++)
            {
                if (cs[i] != osk[i])
                    return false;
            }
            return true;
        }
        internal void gr_zvo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            SetValue(csZvo, Zvo);
            ChangeClick(sender);
            changeServer = "ЗВО";
            control.StartAnimation("MainSynhrZvo");
        }

        internal void gr_uvo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            SetValue(csUvo, Uvo);
            ChangeClick(sender);
            changeServer = "ЮВО";
            control.StartAnimation("MainSynhrUvo");
        }

        internal void gr_cvo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            SetValue(csCvo, Cvo);
            ChangeClick(sender);
            changeServer = "ЦВО";
            control.StartAnimation("MainSynhrCvo");
        }

        internal void gr_vvo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            SetValue(csVvo, Vvo);
            ChangeClick(sender);
            changeServer = "ВВО";
            control.StartAnimation("MainSynhrVvo");
        }

        internal void gr_sf_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            SetValue(csSf, Sf);
            ChangeClick(sender);
            changeServer = "СФ";
            control.StartAnimation("MainSynhrSf");
        }
        internal void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            string nameInformation;
            int checkMark = ((Grid)sender).Children.OfType<TextBlock>().Select(b => Convert.ToInt32(b.Text)).FirstOrDefault();
            if (checkMark > 0)
            {
                nameInformation = ((Grid)sender).Children.OfType<TextBlock>().Where(a => a.Name == string.Empty).Select(b => b.Text).FirstOrDefault();
                control.ShowTablePersonal(nameInformation, this, changeServer, statuslastcolumn:false);
                control.StartAnimation(((Grid)sender).Tag.ToString()); 
            }

        }

    }
    public class StatusConverter : IValueConverter
    {
        internal SolidColorBrush red = new BrushConverter().ConvertFromString("#fe6c3f") as SolidColorBrush;
        internal SolidColorBrush green = new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if ((int)value != 0)
                if (targetType == typeof(Cursor))
                    return Cursors.Hand;
                else
                    return red;
            else
                if (targetType == typeof(Cursor))
                return null;
            else
                return
                    green;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

    }
}
