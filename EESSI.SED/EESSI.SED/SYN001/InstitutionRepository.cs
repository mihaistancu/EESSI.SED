using System.Collections.Generic;

namespace EESSI.SED.SYN001
{
    public class InstitutionRepository
    {
        public CentralServicesNode CentralServicesNode { get; set; }
        public List<Institution> Institutions { get; set; }
        public List<AccessPoint> AccessPoints { get; set; }
        public List<Certificate> Certificates { get; set; }
    }
}