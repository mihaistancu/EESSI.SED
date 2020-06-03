using System;

namespace EESSI.SED.SYN001
{
    public class Certificate
    {
        public string serialNumber { get; set; }
        public string subject { get; set; }
        public string issuer { get; set; }
        public DateTime validFrom { get; set; }
        public DateTime validTo { get; set; }
        public string thumbprint { get; set; }
        public string publicKey { get; set; }
    }
}