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
                SchemaLocation = "Schema-Location"
            };
            var xml = ObjectToXml.Serialize(sed);
            Assert.IsNotNull(xml);
        }
    }
}
