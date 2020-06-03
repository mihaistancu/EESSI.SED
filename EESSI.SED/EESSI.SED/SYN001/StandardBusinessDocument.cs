using System.Xml.Serialization;
using EESSI.SED.Common;

namespace EESSI.SED.SYN001
{
    [XmlRoot(Namespace = Namespaces.StandardBusinessDocumentHeader)]
    public class StandardBusinessDocument
    {
        [XmlAttribute(Namespace = Namespaces.XmlSchemaInstance)]
        public string SchemaLocation { get; set; }
        public StandardBusinessDocumentHeader StandardBusinessDocumentHeader { get; set; }

        [XmlElement(Namespace = "http://ec.europa.eu/eessi/ns/4_2/SYN001")]
        public StandardElectronicDocument SYN001 { get; set; }
    }
}