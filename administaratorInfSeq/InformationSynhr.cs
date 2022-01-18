using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administaratorInfSeq
{
    /// <summary>
    /// интерфейс для страниц, которые имеют кнопку назад
    /// </summary>
    internal interface IHavePageBack
    {
        void ClickBackPage();
    };
   internal struct InformationSynhr
    {
        internal int cardnumber,
            DateBirth,
            Rank,
            Class,
            F,
            I,
            O,
            Sex,
            PlaceBirth,
            HomeAdress,
            Nationality,
            Tabelnumber,
            MaidenName,
            RegAdress,
            FamilyStatus,
            Institute,
            Periods,
            Militarydistrict,
            Bankdetails,
            Inn,
            Family,
            BD,
            Passport,
            CardIden,
            PrizivPlace,
            Nis,
            Nagr,
            CardBd,
            Vin,
            Pek;
        public List<int> ToList()
        {
            List<int> res = new List<int>()
            {cardnumber,
            DateBirth,
            Rank,
            Class,
            F,
            I,
            O,
            Sex,
            PlaceBirth,
            HomeAdress,
            Nationality,
            Tabelnumber,
            MaidenName,
            RegAdress,
            FamilyStatus,
            Institute,
            Periods,
            Militarydistrict,
            Bankdetails,
            Inn,
            Family,
            BD,
            Passport,
            CardIden,
            PrizivPlace,
            Nis,
            Nagr,
            CardBd,
            Vin,
            Pek};
            return res;
        }
    }

    public struct InformationImport
    {
        public string nameField;
        public int countAll { get; set; }
        public int insert { get; set; }
        public int update { get; set; }
        public int mark { get; set; }

    }
    public struct InformationReport
    {
        public string name { get; set; }
        public int count { get; set; }
        internal int oficers,
            prapor,
            solder;
        internal string countColumn;
        internal string queries;

    }

    public struct InformationAudit
    {
        public int count { get; set; }
        internal string countColumn;
        internal string queries;
    }

}
