using System;
using System.Collections.Generic;
using System.Xml;
using EESSI.SED.Common;
using EESSI.SED.SYN001;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EESSI.SED.Tests
{
    [TestClass]
    public class Syn001Tests
    {
        [TestMethod]
        public void SerializationIsSuccessful()
        {
            var sed = new SYN001.StandardBusinessDocument
            {
                SchemaLocation = "Schema-Location",
                StandardBusinessDocumentHeader = new StandardBusinessDocumentHeader
                {
                    HeaderVersion = "1.1",
                    Sender = new Participant
                    {
                        Identifier = new Identifier
                        {
                            Authority = "urn:eu:europa:ec:dgempl:eessi:ir",
                            Value = "EU:CSN01"
                        },
                        ContactTypeIdentifier = "DataSource"
                    },
                    Receiver = new Participant
                    {
                        Identifier = new Identifier
                        {
                            Authority = "urn:eu:europa:ec:dgempl:eessi:ir",
                            Value = "UK:APUK01"
                        },
                        ContactTypeIdentifier = "DataDestination"
                    },
                    DocumentIdentification = new DocumentIdentification
                    {
                        CreationDateAndTime = new DateTime(2020,06,02,12,53,13),
                        CaseAction = "Start",
                        Type = "SYN001",
                        InstanceIdentifier = "a50bcf13-56a0-452d-b246-8c61a1d500d0",
                        TypeVersion = "4.2"
                    },
                    BusinessScope = new BusinessScope
                    {
                        DocumentVersion = "1",
                        SetId = "ebf48b3a-9dc8-4e02-b295-008d19aa6f9d",
                        CaseId = new CaseId
                        {
                            InstanceIdentifier = "57db29bd-8bbd-4206-ac65-284a88c02c5d",
                            BusinessServiceName = "SYNC_SUC_01:4.2"
                        }
                    }
                },
                SYN001 = new StandardElectronicDocument
                {
                    IRSync = new IRSync
                    {
                        version = "4.1.2",
                        InstitutionRepository = new InstitutionRepository
                        {
                            CentralServicesNode = new CentralServicesNode
                            {
                                officialID = "EU:CSN01",
                                EbMsSignatureCertificates = new List<EbMSSignatureCertificate>
                                {
                                    new EbMSSignatureCertificate
                                    {
                                        CertificateIdentification = new CertificateIdentification
                                        {
                                            thumbprint = "DE1FA39A3BA20440F12162B887E22735A7F33EEC"
                                        }
                                    }
                                },
                                TLSCertificates = new List<TLSCertificate>
                                {
                                    new TLSCertificate
                                    {
                                        CertificateIdentification = new CertificateIdentification
                                        {
                                            thumbprint = "79BA43BD53EE6ED07A719498B0DD7356285D39C2"
                                        }
                                    }
                                },
                                SystemMessageEndpoint = new SystemMessageEndpoint
                                {
                                    channel = "https://eessidev24.eessi.be/EESSI/",
                                    messageExchangePattern = "PUSH"
                                }
                            },
                            Institutions = new List<Institution>
                            {

                            },
                            AccessPoints = new List<AccessPoint>
                            {

                            },
                            Certificates = new List<Certificate>()
                        }
                    }
                }
            };
            
            var xml = ObjectToXml.Serialize(sed);
            Assert.IsNotNull(xml);
        }

        [TestMethod]
        public void DeserializationIsSuccessful()
        {
            var xml = new XmlDocument();
            xml.Load("SYN001.xml");
            var doc = XmlToObject.Deserialize<StandardBusinessDocument>(xml);
        }
    }
}
