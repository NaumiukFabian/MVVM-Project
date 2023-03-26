using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReportB2C.Models.EpuModels
{
    [XmlRoot(ElementName = "OrzeczenieEPU", Namespace = "http://www.currenda.pl/epu")]
    public class OrzeczenieEPU
    {
        [XmlElement(ElementName = "SadEPU", Namespace = "http://www.currenda.pl/epu")]
        public SadEPU SadEPU { get; set; }
        [XmlElement(ElementName = "Sygnatura", Namespace = "http://www.currenda.pl/epu")]
        public string Sygnatura { get; set; }
        [XmlElement(ElementName = "DataWplywu", Namespace = "http://www.currenda.pl/epu")]
        public string DataWplywu { get; set; }
        [XmlElement(ElementName = "WSkladzie", Namespace = "http://www.currenda.pl/epu")]
        public string WSkladzie { get; set; }
        [XmlElement(ElementName = "Sedzia", Namespace = "http://www.currenda.pl/epu")]
        public string Sedzia { get; set; }
        [XmlElement(ElementName = "NaPosiedzeniu", Namespace = "http://www.currenda.pl/epu")]
        public string NaPosiedzeniu { get; set; }
        [XmlElement(ElementName = "Przez", Namespace = "http://www.currenda.pl/epu")]
        public string Przez { get; set; }
        [XmlElement(ElementName = "ListaPowodow", Namespace = "http://www.currenda.pl/epu")]
        public ListaPowodow ListaPowodow { get; set; }
        [XmlElement(ElementName = "NakazujeAby", Namespace = "http://www.currenda.pl/epu")]
        public string NakazujeAby { get; set; }
        [XmlElement(ElementName = "ListaPozwanych", Namespace = "http://www.currenda.pl/epu")]
        public ListaPozwanych ListaPozwanych { get; set; }
        [XmlElement(ElementName = "Postanawia", Namespace = "http://www.currenda.pl/epu")]
        public string Postanawia { get; set; }
        [XmlElement(ElementName = "Tresc", Namespace = "http://www.currenda.pl/epu")]
        public string Tresc { get; set; }
        [XmlElement(ElementName = "TempPrzekazanieTresc", Namespace = "http://www.currenda.pl/epu")]
        public string TempPrzekazanieTresc { get; set; }
        [XmlElement(ElementName = "TempPrzekazanieID", Namespace = "http://www.currenda.pl/epu")]
        public string TempPrzekazanieID { get; set; }
        [XmlElement(ElementName = "Uzasadnienie", Namespace = "http://www.currenda.pl/epu")]
        public string Uzasadnienie { get; set; }
        [XmlElement(ElementName = "SprawaWgPowoda", Namespace = "http://www.currenda.pl/epu")]
        public string SprawaWgPowoda { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "curr", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Curr { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "KOD")]
        public string KOD { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "dataOrzeczenia")]
        public string DataOrzeczenia { get; set; }
        [XmlAttribute(AttributeName = "kodDecyzji")]
        public string KodDecyzji { get; set; }
        [XmlAttribute(AttributeName = "nazwaOrzeczenia")]
        public string NazwaOrzeczenia { get; set; }
    }
}
