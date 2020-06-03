using System.Collections.Generic;

namespace EESSI.SED.SYN001
{
    public class AccessPoint
    {
        public string officialID { get; set; }
        public StringValue countryCode { get; set; }
        public List<Translation> Name { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public List<PostalAddress> PostalAddresses { get; set; }
        public ValidityPeriod ValidityPeriod { get; set; }
        public List<EbMSSignatureCertificate> EbMSSignatureCertificates { get; set; }
        public List<ExternalTLSCertificate> ExternalTLSCertificates { get; set; }
        public List<InternalTLSCertificate> InternalTLSCertificates { get; set; }
        public Endpoint SystemMessageEndpoint { get; set; }
        public Endpoint BusinessMessageEndpoint { get; set; }
        public List<LinkedInstitution> LinkedInstitutions { get; set; }
    }
}