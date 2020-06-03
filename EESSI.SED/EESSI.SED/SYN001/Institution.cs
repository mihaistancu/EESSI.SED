using System.Collections.Generic;

namespace EESSI.SED.SYN001
{
    public class Institution
    {
        public string officialID { get; set; }
        public string cLDId { get; set; }
        public StringValue countryCode { get; set; }
        public Indicator isPublicIndicator { get; set; }
        public Indicator isLiaisonBodyIndicator { get; set; }
        public List<Translation> Name { get; set; }
        public ValidityPeriod ValidityPeriod { get; set; }
        public List<PostalAddress> PostalAddresses { get; set; }
        public List<Relation> Relations { get; set; }
        public List<Competence> Competences { get; set; }
        public List<EbMSSignatureCertificate> EbMSSignatureCertificates { get; set; }
        public List<BusinessSignatureCertificate> BusinessSignatureCertificates { get; set; }
        public Endpoint BusinessMessageEndpoint { get; set; }
        public Endpoint SystemMessageEndpoint { get; set; }
    }
}