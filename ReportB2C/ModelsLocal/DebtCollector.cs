using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ModelsLocal
{
    public class DebtCollector
    {
        public string Name { get; set; }
        public bool Check { get; set; }
        public int Id { get; set; }
        public decimal? CesjaPayments { get; set; }
        public decimal? ZleceniaPayments { get; set; }
        public decimal? CyberPayments { get; set; }
        public decimal? TotalPayments { get; set; }
    }
}
