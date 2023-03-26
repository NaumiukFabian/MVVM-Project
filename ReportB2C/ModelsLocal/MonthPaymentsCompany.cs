using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ModelsLocal
{
    public class MonthPaymentsCompany
    {
        public decimal? TotalPayments { get; set; }
        public decimal? CesjaPayments { get; set; }
        public decimal? CyberPayments { get; set; }
        public decimal? ZlecPayments { get; set; }
        public decimal? ActuallyDeliveryPayments { get; set; }
        public decimal? Przelewy24Payments { get; set; }
        public decimal? SelfPayments { get; set; }
    }
}
