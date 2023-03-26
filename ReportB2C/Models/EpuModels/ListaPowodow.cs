using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReportB2C.Models.EpuModels
{
    [XmlRoot(ElementName = "ListaPowodow", Namespace = "http://www.currenda.pl/epu")]
    public class ListaPowodow
    {
        [XmlElement(ElementName = "Powod", Namespace = "http://www.currenda.pl/epu")]
        public Powod Powod { get; set; }
    }
}
