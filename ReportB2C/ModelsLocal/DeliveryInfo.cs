using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ModelsLocal
{
    public class DeliveryInfo
    {
        public decimal? Interest { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Due { get; set; }
        public decimal? AllCost { get; set; }
        public int? Quantity { get; set; }
        public string Client { get; set; }
    }
}
