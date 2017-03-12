using FuckOff.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckOff.Tests
{
    [TestClass]
    public class RequestWrapperTests
    {
        WebRequestWrapper rest;
        [TestInitialize]
        public void Init()
        {
            rest = new WebRequestWrapper();
        }

        [ExpectedException(typeof(FuckOff.Service.EmptyUrlException))]
        [TestMethod]
        public async Task ThrowsExceptionOnEmptyRequestString()
        {
            FuckOffMessage result = await rest.GetResponseAsync("");
        }

        [TestMethod]
        public async Task CanGetResponse()
        {
            FuckOffMessage message = await rest.GetResponseAsync("http://foaas.com/version");
            Assert.AreEqual("Version 1.1.0", message.Message);
        }


        [TestMethod]
        public void CanParseJson()
        {
            FuckOffMessage message = rest.ParseJson("{\"message\":\"Version 1.1.0\",\"subtitle\":\"FOAAS\"}");
            Assert.AreEqual("Version 1.1.0", message.Message);
            Assert.AreEqual("FOAAS", message.Subtitle);

        }
    }
}
