﻿using System.Xml.Serialization;

namespace EESSI.SED.SYN001
{
    [XmlRoot(Namespace = "http://ec.europa.eu/eessi/ns/4_2/SYN001")]
    public class StandardElectronicDocument
    {
        public IRSync IRSync { get; set; }
    }
}
