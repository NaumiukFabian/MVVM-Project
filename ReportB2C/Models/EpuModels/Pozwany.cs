using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReportB2C.Models.EpuModels
{
    [XmlRoot(ElementName = "Pozwany", Namespace = "http://www.currenda.pl/epu")]
    public class Pozwany
    {
        [XmlElement(ElementName = "Nazwa", Namespace = "http://www.currenda.pl/epu")]
        public string Nazwa { get; set; }
        [XmlElement(ElementName = "ID", Namespace = "http://www.currenda.pl/epu")]
        public string ID { get; set; }
    }
}
