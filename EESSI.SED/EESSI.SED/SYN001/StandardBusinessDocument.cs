using System.Xml.Serialization;

namespace EESSI.SED.SYN001
{
    public class StandardBusinessDocument: Common.StandardBusinessDocument
    {
        [XmlElement(Namespace = "http://ec.europa.eu/eessi/ns/4_2/SYN001")]
        public StandardElectronicDocument SYN001 { get; set; }
    }
}