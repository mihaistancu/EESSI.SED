using System.Collections.Generic;

namespace EESSI.SED.SYN001
{
    public class CentralServicesNode
    {
        public string officialID { get; set; }
        public List<EbMSSignatureCertificate> EbMSSignatureCertificates { get; set; }
        public List<TLSCertificate> TLSCertificates { get; set; }
        public Endpoint SystemMessageEndpoint { get; set; }
    }
}