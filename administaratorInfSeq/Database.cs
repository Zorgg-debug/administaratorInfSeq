using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace administaratorInfSeq
{
    /// <summary>
    /// выборка данных из базы sqlite
    /// </summary>
    internal class Database
    {
        SQLiteConnection conn;
       internal  Database()
        {
            conn = new SQLiteConnection("Data Source=Database.db");
            conn.Open();
        }
        /// <summary>
        /// информация по вирусной активности
        /// </summary>
        /// <returns></returns>
        internal List<Tuple<string, string, DateTime>> GetInformationMarks()
        {
            List<Tuple<string, string, DateTime>> res = new List<Tuple<string, string, DateTime>>();
            Tuple<string, string, DateTime> _res;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = "select * from Mark";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _res =new Tuple<string, string, DateTime>(rd["ServerName"].ToString(),
                            rd["Mark"].ToString(),
                            Convert.ToDateTime(rd["Time"]));
                        res.Add(_res);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// информация для синхронизации
        /// </summary>
        /// <param name="nameServer">имя сервера</param>
        /// <returns></returns>
        internal InformationSynhr GetInformationSynhronise(string nameServer)
        {
            InformationSynhr res = new InformationSynhr();
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from Synhonize where nameServer = '{nameServer}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res.cardnumber = Convert.ToInt32(rd["Cardnumber"]);
                        res.DateBirth = Convert.ToInt32(rd["DateBirth"]);
                        res.Rank = Convert.ToInt32(rd["Rank"]);
                        res.Class = Convert.ToInt32(rd["Class"]);
                        res.F = Convert.ToInt32(rd["F"]);
                        res.I = Convert.ToInt32(rd["I"]);
                        res.O = Convert.ToInt32(rd["O"]);
                        res.Sex = Convert.ToInt32(rd["Sex"]);
                        res.PlaceBirth = Convert.ToInt32(rd["PlaceBirth"]);
                        res.HomeAdress = Convert.ToInt32(rd["HomeAdress"]);
                        res.Nationality = Convert.ToInt32(rd["Nationality"]);
                        res.Tabelnumber = Convert.ToInt32(rd["Tabelnumber"]);
                        res.MaidenName = Convert.ToInt32(rd["MaidenName"]);
                        res.RegAdress = Convert.ToInt32(rd["RegAdress"]);
                        res.FamilyStatus = Convert.ToInt32(rd["FamilyStatus"]);
                        res.Institute = Convert.ToInt32(rd["Institute"]);
                        res.Periods = Convert.ToInt32(rd["Periods"]);
                        res.Militarydistrict = Convert.ToInt32(rd["Militarydistrict"]);
                        res.Bankdetails = Convert.ToInt32(rd["Bankdetails"]);
                        res.Inn = Convert.ToInt32(rd["Inn"]);
                        res.Family = Convert.ToInt32(rd["Family"]);
                        res.BD = Convert.ToInt32(rd["BD"]);
                        res.Passport = Convert.ToInt32(rd["Passport"]);
                        res.CardIden = Convert.ToInt32(rd["CardIden"]);
                        res.PrizivPlace = Convert.ToInt32(rd["PrizivPlace"]);
                        res.Nis = Convert.ToInt32(rd["Nis"]);
                        res.Nagr = Convert.ToInt32(rd["Nagr"]);
                        res.CardBd = Convert.ToInt32(rd["CardBd"]);
                        res.Vin = Convert.ToInt32(rd["Vin"]);
                        res.Pek = Convert.ToInt32(rd["Pek"]);
                    }
                }
            }
            return res;

        }
        /// <summary>
        /// информация по импорту 
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns></returns>
        internal InformationImport GetInformationImport(string nameField)
        {
            InformationImport _res = new InformationImport();
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from Import where NameField = '{nameField}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _res.nameField = rd["NameField"].ToString();
                        _res.countAll = Convert.ToInt32(rd["CountAll"]);
                        _res.insert = Convert.ToInt32(rd["Insert"]);
                        _res.update = Convert.ToInt32(rd["Update"]);
                        _res.mark = Convert.ToInt32(rd["Mark"]);
                    }
                }
            }
            return _res;
        }
        /// <summary>
        /// информация по отчетам
        /// </summary>
        /// <param name="name">наименование отчета</param>
        /// <returns></returns>
        internal InformationReport GetInformationReports(string name)
        {
            InformationReport res = new InformationReport();
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from Report where Name = '{name}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res.name = rd["Name"].ToString();
                        res.count = Convert.ToInt32(rd["Count"]);
                        res.oficers = Convert.ToInt32(rd["Oficers"]);
                        res.prapor = Convert.ToInt32(rd["Prapor"]);
                        res.solder = Convert.ToInt32(rd["Solder"]);
                        res.countColumn = rd["countColumn"].ToString();
                        res.queries = rd["idQuery"].ToString();
                    }
                }
            }
            return res;
       }
        /// <summary>
        /// информация по статистикам
        /// </summary>
        /// <param name="name">наименование статистики</param>
        /// <returns></returns>
        internal InformationAudit GetInformationAudit(string name)
        {
            InformationAudit res = new InformationAudit();
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from Audit where Name = '{name}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res.count = Convert.ToInt32(rd["Count"]);
                        res.countColumn = rd["countColumn"].ToString();
                        res.queries = rd["idquery"].ToString();
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// получение url-адреса из базы данных
        /// </summary>
        /// <param name="nameServer">наименование сервера</param>
        /// <returns></returns>
        internal string GetUrlServerZabbix(string nameServer)
        {
            string res = default;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from Urls where name = '{nameServer}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res = rd["url"].ToString();
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// получение ip для пинга
        /// </summary>
        /// <returns></returns>
        internal List<string> GetIpServers()
        {
            List<string> res = new List<string>();
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from ipServers";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res.Add(rd["ip"].ToString());
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// получение запроса
        /// </summary>
        /// <param name="nameQuery">id запроса</param>
        /// <returns></returns>
        internal string GetQuery(string nameQuery)
        {
            string res ="";
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $@"select * from queries where name = '{nameQuery}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res = rd["query"].ToString();
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// выполнение запросов
        /// </summary>
        /// <param name="query">сам запрос</param>
        /// <param name="countColums">количество колонок</param>
        /// <returns></returns>
        internal List<string[]> RunQueryAndReturnResult(string query, int countColums)
        {
            List<string[]> res = new List<string[]>();
            string[] _res;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = query;
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                         _res = new string[countColums];
                        for(int i=0;i<countColums;i++)
                        {
                            _res[i] = rd[i].ToString();
                        }
                        res.Add(_res);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// получение пути видео
        /// </summary>
        /// <param name="command">короткая команда</param>
        /// <param name="statusSex">пол</param>
        /// <returns></returns>
        internal string GetVideoPath(string command, string statusSex)
        {
            string res = "";
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = $"select pathVideos from PathVideos where sender ='{command}' and statusSex = '{statusSex}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        res = rd["pathVideos"].ToString();
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// Текст
        /// </summary>
        /// <param name="nameInformation">критерий выбора данных</param>
        /// <param name="nameServer">имя сервера, необязательный параметр</param>
        /// <returns></returns>
        internal List<string[]> GetPersonalInformation(string nameInformation, string nameServer = default)
        {
            List<string[]> res = new List<string[]>();
            string[] _res;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                if(nameServer != default)
                    com.CommandText = $"select * from PersonalSynhronise where  informationServer='{nameServer}' and nameInformation = '{nameInformation}'";
                else
                    com.CommandText = $"select * from PersonalImport where nameInformation = '{nameInformation}'";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _res = new string[7];
                        _res[0] = rd["tabelNumber"].ToString();
                        _res[1] = rd["cardnumber"].ToString();
                        _res[2] = rd["F"].ToString();
                        _res[3] = rd["I"].ToString();
                        _res[4] = rd["O"].ToString();
                        _res[5] = rd["dateBirth"].ToString();
                        _res[6] = rd["nameInformation"].ToString();
                        res.Add(_res);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// получение данных по вирусной активности
        /// </summary>
        /// <returns></returns>
        internal List<Tuple<string, string,string,string>> GetVirusActivity()
        {
            List<Tuple<string, string, string, string>> res = new List<Tuple<string, string, string, string>>();
            Tuple<string, string, string, string> _res;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = @"select * from VirusActivity";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        _res = new Tuple<string, string, string, string>(
                        rd["tmStore"].ToString(),
                        rd["wstrFileTitle"].ToString(),
                        rd["wstrVirusName"].ToString(),
                        rd["wstrDisplayName"].ToString()
                            );
                        res.Add(_res);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// выборка данных по статусам компьютеров в сети
        /// </summary>
        /// <returns></returns>
        internal List<Tuple<string, double>> GetStatusComputers()
        {
            List<Tuple<string, double>> res = new List<Tuple<string, double>>();
            Tuple<string, double> _res;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = @" select * from StatusComputers";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _res = new Tuple<string, double>(
                        rd["status"].ToString(),
                        Convert.ToDouble(rd["count"])
                            );
                        res.Add(_res);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// получение данных по истории вырусной активности
        /// </summary>
        /// <returns></returns>
        internal List<Tuple<string, double>> GetVirusHistory()
        {
            List<Tuple<string, double>> res = new List<Tuple<string, double>>();
            Tuple<string, double> _res;
            using (SQLiteCommand com = new SQLiteCommand())
            {
                com.Connection = conn;
                com.CommandText = @" select * from VirusHistory order by  date desc";
                using (SQLiteDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _res = new Tuple<string, double>(
                        rd["date"].ToString(),
                        Convert.ToDouble(rd["count"])
                            );
                        res.Add(_res);
                    }
                }
            }
            return res;
        }

    }
}
