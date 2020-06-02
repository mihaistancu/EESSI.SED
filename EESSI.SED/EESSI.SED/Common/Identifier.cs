using System.Xml.Serialization;

namespace EESSI.SED.Common
{
    public class Identifier
    {
        public string Authority { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}