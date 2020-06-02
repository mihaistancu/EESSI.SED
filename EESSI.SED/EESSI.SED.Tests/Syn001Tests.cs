using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EESSI.SED.Tests
{
    [TestClass]
    public class Syn001Tests
    {
        [TestMethod]
        public void Syn001IsCreatedSuccessfully()
        {
            var sed = new StandardBusinessDocument
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
                }
            };
            var xml = ObjectToXml.Serialize(sed);
            Assert.IsNotNull(xml);
        }
    }
}
