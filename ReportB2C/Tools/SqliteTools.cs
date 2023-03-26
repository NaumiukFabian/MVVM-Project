using SQLite;
using ReportB2C.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using ReportB2C.ModelsLocal.SqLite;
using EpuServices;

namespace ReportB2C.Tools
{
    public class SqliteTools : ISqliteTools
    {
        public string FullPath { get; set; }
        public List<OrzeczenieOutputElement> OrzeczenieOutputElement { get; set; }
        public DateTime UpdateDate { get; set; }

        private readonly IApiTools _apiTools;
        public SqliteTools(IApiTools apiTools)
        {
            _apiTools = apiTools;
            string dbName = "epuDb.db";
            string path = Directory.GetCurrentDirectory();
            FullPath = System.IO.Path.Combine(path, dbName);
            _apiTools = apiTools;
            //GetOrzeczenia().GetAwaiter();
        }

        public async Task<List<OrzeczenieOutputElement>> GetOrzeczenia()
        {
            OrzeczenieOutputElement = await _apiTools.GetJudgments(UpdateDate);
            if (OrzeczenieOutputElement == null)
                return null;

            return OrzeczenieOutputElement.ToList();
        }

        public async void CreateConnect()
        {
            using (SQLiteConnection conn = new SQLiteConnection(FullPath))
            {
                SQLiteCommand command = new SQLiteCommand(conn);

                foreach (var x in OrzeczenieOutputElement)
                {
                    try
                    {
                        Orzeczenia orzeczenia = new Orzeczenia()
                        {
                            DataOrzeczenia = x.dataOrzeczenia,
                            XmlDocument = x.dokumentXml,
                            Id = x.id,
                            IdPowoda = x.idPowoda,
                            NazwaDecyzji = x.nazwaDecyzji,
                            SygnaturaSprawy = x.sygnaturaSprawy,
                            SygnaturaWgPowoda = x.sygnaturaWgPowoda,
                            DataAktualizacji = DateTime.Now
                        };

                        conn.Insert(orzeczenia);
                    }

                    catch (Exception ex)
                    {
                        continue;
                    }
                    
                }
            }
        }

        public DateTime LoadDate()
        {
            using (SQLiteConnection conn = new SQLiteConnection(FullPath))
            {
                UpdateDate = conn.Table<Orzeczenia>().Max(x => Convert.ToDateTime(x.DataOrzeczenia));
                return UpdateDate;
            }
        }

        public List<Orzeczenia> AllOrzeczenia()
        {
            using (SQLiteConnection conn = new SQLiteConnection(FullPath))
            {
                List<Orzeczenia> aa = conn.Table<Orzeczenia>().ToList();
                return conn.Table<Orzeczenia>().ToList();
            }
        }  
        public void ChangeStateData(Orzeczenia orzeczenia)
        {
            using (SQLiteConnection conn = new SQLiteConnection(FullPath))
            {
                SQLiteCommand command = new SQLiteCommand(conn);

                command.CommandText = "UPDATE Orzeczenia SET Done =" + true + " WHERE ID = " + orzeczenia.Id + "";

                command.ExecuteNonQuery();
            }
        }

        public void AddColumn()
        {
            using (SQLiteConnection conn = new SQLiteConnection(FullPath))
            {
                SQLiteCommand command = new SQLiteCommand(conn);

                command.CommandText = "ALTER TABLE Orzeczenia ADD Comment VARCHAR;";

                command.ExecuteNonQuery();
            }
        }

        public void UpdateComment(Orzeczenia orzeczenia)
        {
            using (SQLiteConnection conn = new SQLiteConnection(FullPath))
            {
                SQLiteCommand command = new SQLiteCommand(conn);

                command.CommandText = String.Format("UPDATE Orzeczenia SET Comment =" + "'{0}'" + " WHERE ID = {1}" + "", orzeczenia.Comment, orzeczenia.Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
