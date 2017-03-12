using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuckOff;
using System.Threading.Tasks;

namespace FuckOff.Tests
{
    [TestClass]
    public class APITests
    {
        FoaasAPI foaas;
        FuckOffSettings settings;
        FuckOffService service;
        TestWebRequestWrapper requestWrapper;

        [TestInitialize]
        public void Init()
        {
            settings = new FuckOffSettings();
            requestWrapper = new TestWebRequestWrapper();
            foaas = new FoaasAPI(requestWrapper);
            foaas.FuckOffRecipient = "anja";
            service = new FuckOffService(settings, foaas);
        }

        [TestMethod]
        public async Task CanGetRandomFuckOff()
        {
            for (int i = 0; i < 500; i++)
            {
                try
                {
                    string message = await service.GetRandomFuckOff();
                    Assert.IsFalse(string.IsNullOrWhiteSpace(message));
                }
                catch(Exception e)
                {
                    Assert.Fail(e.Message);
                }
            }
        }

        [TestMethod]
        public void CanGetVersionNumber()
        {
            string versionNumber = service.APIVersion;
            Assert.AreEqual("Version 1.1.0", versionNumber);
        }

        [TestMethod]
        public void CanGetAPIBaseURL()
        {
            string apiUrl = service.APIName;
            Assert.AreEqual("http://foaas.com", apiUrl);
        }

        [TestMethod]
        public void CallsAPIWhenRetrievingVersionNumber()
        {
            foaas.GetVersionNumber();
            Assert.AreEqual("http://foaas.com/version", ((TestWebRequestWrapper)requestWrapper).Request);
        }

        [TestMethod]
        public async Task CanGetFuckinAwesome()
        {
            string message = await foaas.GetFuckinAwesome();
            Assert.AreEqual("http://foaas.com/awesome/anja", ((TestWebRequestWrapper)requestWrapper).Request);
        }

        [TestMethod]
        public async Task CanGetAnyway()
        {
            string message = await foaas.GetWhoAreYouAnyway();
            Assert.AreEqual("http://foaas.com/anyway/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request);
        }

        [TestMethod]
        public async Task CanGetEatABagOfDicks()
        {
            string message = await foaas.GetEatABagOfDicks();
            Assert.AreEqual("http://foaas.com/bag/anja", ((TestWebRequestWrapper)requestWrapper).Request);
        }

        [TestMethod]
        public async Task CanGetballmer() { string message = await foaas.Getballmer(); Assert.AreEqual("http://foaas.com/ballmer/anja/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetbday() { string message = await foaas.Getbday(); Assert.AreEqual("http://foaas.com/bday/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetbecause() { string message = await foaas.Getbecause(); Assert.AreEqual("http://foaas.com/because/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetblackadder() { string message = await foaas.Getblackadder(); Assert.AreEqual("http://foaas.com/blackadder/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetbm() { string message = await foaas.Getbm(); Assert.AreEqual("http://foaas.com/bm/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetbucket() { string message = await foaas.Getbucket(); Assert.AreEqual("http://foaas.com/bucket/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetbus() { string message = await foaas.Getbus(); Assert.AreEqual("http://foaas.com/bus/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetbye() { string message = await foaas.Getbye(); Assert.AreEqual("http://foaas.com/bye/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetcaniuse() { string message = await foaas.Getcaniuse(); Assert.AreEqual("http://foaas.com/caniuse/computer/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetchainsaw() { string message = await foaas.Getchainsaw(); Assert.AreEqual("http://foaas.com/chainsaw/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetcocksplat() { string message = await foaas.Getcocksplat(); Assert.AreEqual("http://foaas.com/cocksplat/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetcool() { string message = await foaas.Getcool(); Assert.AreEqual("http://foaas.com/cool/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetdalton() { string message = await foaas.Getdalton(); Assert.AreEqual("http://foaas.com/dalton/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetderaadt() { string message = await foaas.Getderaadt(); Assert.AreEqual("http://foaas.com/deraadt/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetdiabetes() { string message = await foaas.Getdiabetes(); Assert.AreEqual("http://foaas.com/diabetes/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetdonut() { string message = await foaas.Getdonut(); Assert.AreEqual("http://foaas.com/donut/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetdosomething() { string message = await foaas.Getdosomething(); Assert.AreEqual("http://foaas.com/dosomething/Just/thing/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGeteveryone() { string message = await foaas.Geteveryone(); Assert.AreEqual("http://foaas.com/everyone/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGeteverything() { string message = await foaas.Geteverything(); Assert.AreEqual("http://foaas.com/everything/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetfamily() { string message = await foaas.Getfamily(); Assert.AreEqual("http://foaas.com/family/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetfascinating() { string message = await foaas.Getfascinating(); Assert.AreEqual("http://foaas.com/fascinating/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetflying() { string message = await foaas.Getflying(); Assert.AreEqual("http://foaas.com/flying/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetgfy() { string message = await foaas.Getgfy(); Assert.AreEqual("http://foaas.com/gfy/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetgive() { string message = await foaas.Getgive(); Assert.AreEqual("http://foaas.com/give/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetgreed() { string message = await foaas.Getgreed(); Assert.AreEqual("http://foaas.com/greed/derp/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGethorse() { string message = await foaas.Gethorse(); Assert.AreEqual("http://foaas.com/horse/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGeting() { string message = await foaas.Geting(); Assert.AreEqual("http://foaas.com/ing/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetkeep() { string message = await foaas.Getkeep(); Assert.AreEqual("http://foaas.com/keep/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetkeepcalm() { string message = await foaas.Getkeepcalm(); Assert.AreEqual("http://foaas.com/keepcalm/estimate/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetking() { string message = await foaas.Getking(); Assert.AreEqual("http://foaas.com/king/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetlife() { string message = await foaas.Getlife(); Assert.AreEqual("http://foaas.com/life/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetlinus() { string message = await foaas.Getlinus(); Assert.AreEqual("http://foaas.com/linus/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetlook() { string message = await foaas.Getlook(); Assert.AreEqual("http://foaas.com/look/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetlooking() { string message = await foaas.Getlooking(); Assert.AreEqual("http://foaas.com/looking/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetmadison() { string message = await foaas.Getmadison(); Assert.AreEqual("http://foaas.com/madison/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetmaybe() { string message = await foaas.Getmaybe(); Assert.AreEqual("http://foaas.com/maybe/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetme() { string message = await foaas.Getme(); Assert.AreEqual("http://foaas.com/me/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetmornin() { string message = await foaas.Getmornin(); Assert.AreEqual("http://foaas.com/mornin/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetno() { string message = await foaas.Getno(); Assert.AreEqual("http://foaas.com/no/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetnugget() { string message = await foaas.Getnugget(); Assert.AreEqual("http://foaas.com/nugget/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetoff() { string message = await foaas.Getoff(); Assert.AreEqual("http://foaas.com/off/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetoffWith() { string message = await foaas.GetoffWith(); Assert.AreEqual("http://foaas.com/off-with/påhållning/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetoutside() { string message = await foaas.Getoutside(); Assert.AreEqual("http://foaas.com/outside/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetparticular() { string message = await foaas.Getparticular(); Assert.AreEqual("http://foaas.com/particular/computer/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetpink() { string message = await foaas.Getpink(); Assert.AreEqual("http://foaas.com/pink/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetproblem() { string message = await foaas.Getproblem(); Assert.AreEqual("http://foaas.com/problem/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetpulp() { string message = await foaas.Getpulp(); Assert.AreEqual("http://foaas.com/pulp/Programming/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetretard() { string message = await foaas.Getretard(); Assert.AreEqual("http://foaas.com/retard/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetridiculous() { string message = await foaas.Getridiculous(); Assert.AreEqual("http://foaas.com/ridiculous/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetrtfm() { string message = await foaas.Getrtfm(); Assert.AreEqual("http://foaas.com/rtfm/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetsake() { string message = await foaas.Getsake(); Assert.AreEqual("http://foaas.com/sake/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetshakespeare() { string message = await foaas.Getshakespeare(); Assert.AreEqual("http://foaas.com/shakespeare/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetshit() { string message = await foaas.Getshit(); Assert.AreEqual("http://foaas.com/shit/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetshutup() { string message = await foaas.Getshutup(); Assert.AreEqual("http://foaas.com/shutup/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetsingle() { string message = await foaas.Getsingle(); Assert.AreEqual("http://foaas.com/single/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetthanks() { string message = await foaas.Getthanks(); Assert.AreEqual("http://foaas.com/thanks/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetthat() { string message = await foaas.Getthat(); Assert.AreEqual("http://foaas.com/that/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetthink() { string message = await foaas.Getthink(); Assert.AreEqual("http://foaas.com/think/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetthinking() { string message = await foaas.Getthinking(); Assert.AreEqual("http://foaas.com/thinking/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetthis() { string message = await foaas.Getthis(); Assert.AreEqual("http://foaas.com/this/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetthumbs() { string message = await foaas.Getthumbs(); Assert.AreEqual("http://foaas.com/thumbs/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGettoo() { string message = await foaas.Gettoo(); Assert.AreEqual("http://foaas.com/too/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGettucker() { string message = await foaas.Gettucker(); Assert.AreEqual("http://foaas.com/tucker/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetversion() { string message = await foaas.Getversion(); Assert.AreEqual("http://foaas.com/version", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetwhat() { string message = await foaas.Getwhat(); Assert.AreEqual("http://foaas.com/what/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetxmas() { string message = await foaas.Getxmas(); Assert.AreEqual("http://foaas.com/xmas/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetyoda() { string message = await foaas.Getyoda(); Assert.AreEqual("http://foaas.com/yoda/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetyou() { string message = await foaas.Getyou(); Assert.AreEqual("http://foaas.com/you/anja/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetzayn() { string message = await foaas.Getzayn(); Assert.AreEqual("http://foaas.com/zayn/anja", ((TestWebRequestWrapper)requestWrapper).Request); }
        [TestMethod]
        public async Task CanGetzero() { string message = await foaas.Getzero(); Assert.AreEqual("http://foaas.com/zero/anja", ((TestWebRequestWrapper)requestWrapper).Request); }



    }
}
