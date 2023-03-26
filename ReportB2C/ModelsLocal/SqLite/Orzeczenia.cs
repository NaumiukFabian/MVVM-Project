using Microsoft.EntityFrameworkCore;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReportB2C.ModelsLocal.SqLite
{
    [SQLite.Table("Orzeczenia")]
    public class Orzeczenia
    {
        [SQLite.PrimaryKey]
        public int Id { get; set; }

        public DateTime? DataOrzeczenia { get; set; }

        public string XmlDocument { get; set; }

        public string? XmlDocumnetCon { get; set; }

        public int IdPowoda { get; set; }

        public string? NazwaDecyzji { get; set; }

        public string? SygnaturaSprawy { get; set; }

        public string? SygnaturaWgPowoda { get; set; }

        public DateTime DataAktualizacji { get; set; }

        public bool Done { get; set; } = false;
        public string? Comment { get; set; }



    }
}
