using System.Collections.Generic;

namespace EESSI.SED.SYN001
{
    public class ContactInfo
    {
        public List<URL> URLs { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }
        public List<FaxNumber> FaxNumbers { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}