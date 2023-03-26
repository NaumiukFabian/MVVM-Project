using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReportB2C.Models.EpuModels
{
    [XmlRoot(ElementName = "SadEPU", Namespace = "http://www.currenda.pl/epu")]
    public class SadEPU
    {
        [XmlElement(ElementName = "Nazwa", Namespace = "http://www.currenda.pl/epu")]
        public string Nazwa { get; set; }
        [XmlElement(ElementName = "Wydzial", Namespace = "http://www.currenda.pl/epu")]
        public string Wydzial { get; set; }
    }
}
