namespace EESSI.SED.Common
{
    public class StandardBusinessDocumentHeader
    {
        public string HeaderVersion { get; set; }
        public Participant Sender { get; set; }
        public Participant Receiver { get; set; }
        public DocumentIdentification DocumentIdentification { get; set; }
        public BusinessScope BusinessScope { get; set; }
    }
}