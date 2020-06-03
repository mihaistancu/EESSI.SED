namespace EESSI.SED.SYN001
{
    public class Competence
    {
        public string id { get; set; }
        public string applicationRole { get; set; }
        public ValidityPeriod ValidityPeriod { get; set; }
        public BUCType BUCType { get; set; }
        public bool isEESSIReady { get; set; }
    }
}