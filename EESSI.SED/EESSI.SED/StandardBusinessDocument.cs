using System.Xml.Serialization;

namespace EESSI.SED
{
    [XmlRoot(Namespace = Namespaces.StandardBusinessDocumentHeader)]
    public class StandardBusinessDocument
    {
        [XmlAttribute(Namespace = Namespaces.XmlSchemaInstance)]
        public string SchemaLocation { get; set; }
        public StandardBusinessDocumentHeader StandardBusinessDocumentHeader { get; set; }
    }
}
