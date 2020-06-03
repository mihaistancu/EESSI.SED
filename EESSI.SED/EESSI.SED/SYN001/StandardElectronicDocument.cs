using System.Xml.Serialization;

namespace EESSI.SED.SYN001
{
    public class StandardElectronicDocument
    {
        [XmlElement(Namespace = "")]
        public IRSync IRSync { get; set; }
    }
}
