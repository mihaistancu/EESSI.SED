using System;

namespace EESSI.SED.Common
{
    public class DocumentIdentification
    {
        public DateTime CreationDateAndTime { get; set; }
        public string CaseAction { get; set; }
        public string Type { get; set; }
        public string InstanceIdentifier { get; set; }
        public string TypeVersion { get; set; }
    }
}