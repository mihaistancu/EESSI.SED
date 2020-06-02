using System.Xml;
using System.Xml.Serialization;
using EESSI.SED.Common;

namespace EESSI.SED.Tests
{
    public class ObjectToXml
    {
        private static readonly XmlSerializerNamespaces SerializerNamespaces;

        static ObjectToXml()
        {
            SerializerNamespaces = new XmlSerializerNamespaces();
            SerializerNamespaces.Add("sbdh", Namespaces.StandardBusinessDocumentHeader);
            SerializerNamespaces.Add("xsi", Namespaces.XmlSchemaInstance);
        }

        public static XmlDocument Serialize<T>(T item)
        {
            var xml = new XmlDocument {PreserveWhitespace = true};
            var serializer = new XmlSerializer(item.GetType());
            using(var xmlWriter = xml.CreateNavigator().AppendChild())
            {
                serializer.Serialize(xmlWriter, item, SerializerNamespaces);
            }
            return xml;
        }
    }
}
