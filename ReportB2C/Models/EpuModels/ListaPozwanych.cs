using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReportB2C.Models.EpuModels
{
    [XmlRoot(ElementName = "ListaPozwanych", Namespace = "http://www.currenda.pl/epu")]
    public class ListaPozwanych
    {
        [XmlElement(ElementName = "Pozwany", Namespace = "http://www.currenda.pl/epu")]
        public Pozwany Pozwany { get; set; }
    }
}
