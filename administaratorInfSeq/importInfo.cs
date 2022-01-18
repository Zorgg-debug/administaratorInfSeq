using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace administaratorInfSeq
{
    /// <summary>
    /// класс для привязки к странице импорта. 
    /// </summary>
    public class importInfo
    {
        internal SolidColorBrush red = new BrushConverter().ConvertFromString("#fe6c3f") as SolidColorBrush;
        internal SolidColorBrush green = new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush;
        public InformationImport bankDetails { get; set; }
        public InformationImport inn { get; set; }
        public InformationImport F { get; set; }
        public InformationImport familyStatus { get; set; }
        public InformationImport family { get; set; }
        public InformationImport adress { get; set; }
        public InformationImport cardIden { get; set; }
        public InformationImport institute { get; set; }
        public InformationImport maidenName { get; set; }
        public InformationImport nationality { get; set; }
        public InformationImport pasport { get; set; }
        public InformationImport placeBirth { get; set; }
        public InformationImport rank { get; set; }
        public InformationImport regAdress { get; set; }
        public InformationImport persIden { get; set; }
        public InformationImport tabelNumber { get; set; }
        public InformationImport BD { get; set; }
        public InformationImport cardBD { get; set; }
        public InformationImport snils { get; set; }
        public InformationImport markers { get; set; }
        public Brush statusBankDetails { get { if (bankDetails.mark == 0) return green; else return red; } }
        public Brush statusInn { get { if (inn.mark == 0) return green; else return red; } }
        public Brush statusF { get { if (F.mark == 0) return green; else return red; } }
        public Brush statusFamilyStatus { get { if (familyStatus.mark == 0) return green; else return red; } }
        public Brush statusFamily { get { if (family.mark == 0) return green; else return red; } }
        public Brush statusAdress { get { if (adress.mark == 0) return green; else return red; } }
        public Brush statuscardIden { get { if (cardIden.mark == 0) return green; else return red; } }
        public Brush statusInstitute { get { if (institute.mark == 0) return green; else return red; } }
        public Brush statusMaidenName { get { if (maidenName.mark == 0) return green; else return red; } }
        public Brush statusNationality { get { if (nationality.mark == 0) return green; else return red; } }
        public Brush statusPasport { get { if (pasport.mark == 0) return green; else return red; } }
        public Brush statusPlaceBirh { get { if (placeBirth.mark == 0) return green; else return red; } }
        public Brush statusRank { get { if (rank.mark == 0) return green; else return red; } }
        public Brush statusRegAdress { get { if (regAdress.mark == 0) return green; else return red; } }
        public Brush statusPersIden { get { if (persIden.mark == 0) return green; else return red; } }
        public Brush statusTabelNumber { get { if (tabelNumber.mark == 0) return green; else return red; } }
        public Brush statusBD { get { if (BD.mark == 0) return green; else return red; } }
        public Brush statusCardBD { get { if (cardBD.mark == 0) return green; else return red; } }
        public Brush statusSnils { get { if (snils.mark == 0) return green; else return red; } }
        public Brush statusMarkers { get { if (markers.mark == 0) return green; else return red; } }

    }
}
