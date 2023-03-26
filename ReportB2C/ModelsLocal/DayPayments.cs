using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ModelsLocal
{
    public class DayPayments
    {
        public decimal? CesjaPay { get; set; }
        public decimal? CyberPay { get; set; }
        public decimal? ZlecPay { get; set; }
        public decimal? StanderSkPay { get; set; }
        public decimal? StanderCzPay { get; set; }
        public decimal? CyberTotalPay { get; set; }
        public DateTime DayPaid { get; set; }
    }
}
