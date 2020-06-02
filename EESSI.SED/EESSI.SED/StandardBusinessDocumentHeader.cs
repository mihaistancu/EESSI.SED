using System;
using System.Xml.Serialization;

namespace EESSI.SED
{
    public class StandardBusinessDocumentHeader
    {
        public string HeaderVersion { get; set; }
        public Participant Sender { get; set; }
        public Participant Receiver { get; set; }
        public DocumentIdentification DocumentIdentification { get; set; }
        public BusinessScope BusinessScope { get; set; }
    }
    
    public class Participant
    {
        public Identifier Identifier { get; set; }
        public string ContactTypeIdentifier { get; set; }
    }
    
    public class Identifier
    {
        public string Authority { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class DocumentIdentification
    {
        public DateTime CreationDateAndTime { get; set; }
        public string CaseAction { get; set; }
        public string Type { get; set; }
        public string InstanceIdentifier { get; set; }
        public string TypeVersion { get; set; }
    }

    public class BusinessScope
    {
        public string DocumentVersion { get; set; }
        public string SetId { get; set; }
        public CaseId CaseId { get; set; }
    }

    public class CaseId
    {
        public string InstanceIdentifier { get; set; }
        public string BusinessServiceName { get; set; }
    }
}