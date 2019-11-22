using Base64;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Base64Test
{
    [TestClass]
    public class Base64Tests
    {
        [TestMethod]
        public void Base64Test1()
        {
            string risposta = LibreriaBase64.Base64();
            Assert.AreEqual("THVjYQ==", risposta);
        }
    }
}

