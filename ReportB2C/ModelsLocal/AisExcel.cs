using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ModelsLocal
{
    public class AisExcel
    {
        public string Name { get; set; }
        public int Stitching { get; set; }
        public decimal[] StitchingCost { get; set; }
        public int Scanning { get; set; }
        public decimal[] ScanningCost { get; set; }
        public int HumanOcr { get; set; }
        public decimal[] HumanOcrCost { get; set; }
        public int Conversion { get; set; }
        public decimal[] ConversionCost { get; set; }
        public int RecognitionTcr { get; set; }
        public decimal[] RecognitionTcrCost { get; set; }
        public int Google { get; set; }
        public decimal[] GoogleCost { get; set; }
        public decimal AllCost { get; set; }
        public bool Checked { get; set; }

    }
}
