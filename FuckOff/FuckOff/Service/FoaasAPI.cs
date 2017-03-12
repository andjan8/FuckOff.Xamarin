using FuckOff.Service;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace FuckOff
{
    public class FoaasAPI
    {
        private WebRequestWrapper requestWrapper;
        private Dictionary<string, string> requestDictionary;
        private string fuckOffRecipient;
        public string FuckOffRecipient
        {
            get
            {
                return fuckOffRecipient;
            }
            set
            {
                fuckOffRecipient = value;
                SetUpRequestDictionary();
            }
        }

        public string BaseUrl { get { return "http://foaas.com"; } }

        public FoaasAPI(WebRequestWrapper requestWrapper)
        {
            this.requestWrapper = requestWrapper;

        }

        private void SetUpRequestDictionary()
        {
            requestDictionary = new Dictionary<string, string>();
            requestDictionary.Add("awesome", BuildRequest("awesome", fuckOffRecipient));
            requestDictionary.Add("anyway", BuildRequest("anyway", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("eatABagOfDicks", BuildRequest("bag", fuckOffRecipient));
            requestDictionary.Add("ballmer", BuildRequest("ballmer", fuckOffRecipient, fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("bday", BuildRequest("bday", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("because", BuildRequest("because", fuckOffRecipient));
            requestDictionary.Add("blackadder", BuildRequest("blackadder", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("bm", BuildRequest("bm", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("bucket", BuildRequest("bucket", fuckOffRecipient));
            requestDictionary.Add("bus", BuildRequest("bus", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("bye", BuildRequest("bye", fuckOffRecipient));
            requestDictionary.Add("caniuse", BuildRequest("caniuse", "computer", fuckOffRecipient));
            requestDictionary.Add("chainsaw", BuildRequest("chainsaw", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("cocksplat", BuildRequest("cocksplat", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("cool", BuildRequest("cool", fuckOffRecipient));
            requestDictionary.Add("dalton", BuildRequest("dalton", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("deraadt", BuildRequest("deraadt", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("diabetes", BuildRequest("diabetes", fuckOffRecipient));
            requestDictionary.Add("donut", BuildRequest("donut", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("dosomething", BuildRequest("dosomething", "Just", "thing", fuckOffRecipient));
            requestDictionary.Add("everyone", BuildRequest("everyone", fuckOffRecipient));
            requestDictionary.Add("everything", BuildRequest("everything", fuckOffRecipient));
            requestDictionary.Add("family", BuildRequest("family", fuckOffRecipient));
            requestDictionary.Add("fascinating", BuildRequest("fascinating", fuckOffRecipient));
            requestDictionary.Add("flying", BuildRequest("flying", fuckOffRecipient));
            requestDictionary.Add("gfy", BuildRequest("gfy", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("give", BuildRequest("give", fuckOffRecipient));
            requestDictionary.Add("greed", BuildRequest("greed", "derp", fuckOffRecipient));
            requestDictionary.Add("horse", BuildRequest("horse", fuckOffRecipient));
            requestDictionary.Add("ing", BuildRequest("ing", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("keep", BuildRequest("keep", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("keepcalm", BuildRequest("keepcalm", "estimate", fuckOffRecipient));
            requestDictionary.Add("king", BuildRequest("king", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("life", BuildRequest("life", fuckOffRecipient));
            requestDictionary.Add("linus", BuildRequest("linus", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("look", BuildRequest("look", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("looking", BuildRequest("looking", fuckOffRecipient));
            requestDictionary.Add("madison", BuildRequest("madison", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("maybe", BuildRequest("maybe", fuckOffRecipient));
            requestDictionary.Add("me", BuildRequest("me", fuckOffRecipient));
            requestDictionary.Add("mornin", BuildRequest("mornin", fuckOffRecipient));
            requestDictionary.Add("no", BuildRequest("no", fuckOffRecipient));
            requestDictionary.Add("nugget", BuildRequest("nugget", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("off", BuildRequest("off", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("offWith", BuildRequest("off-with", "påhållning", fuckOffRecipient));
            requestDictionary.Add("outside", BuildRequest("outside", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("particular", BuildRequest("particular", "computer", fuckOffRecipient));
            requestDictionary.Add("pink", BuildRequest("pink", fuckOffRecipient));
            requestDictionary.Add("problem", BuildRequest("problem", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("pulp", BuildRequest("pulp", "Programming", fuckOffRecipient));
            requestDictionary.Add("retard", BuildRequest("retard", fuckOffRecipient));
            requestDictionary.Add("ridiculous", BuildRequest("ridiculous", fuckOffRecipient));
            requestDictionary.Add("rtfm", BuildRequest("rtfm", fuckOffRecipient));
            requestDictionary.Add("sake", BuildRequest("sake", fuckOffRecipient));
            requestDictionary.Add("shakespeare", BuildRequest("shakespeare", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("shit", BuildRequest("shit", fuckOffRecipient));
            requestDictionary.Add("shutup", BuildRequest("shutup", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("single", BuildRequest("single", fuckOffRecipient));
            requestDictionary.Add("thanks", BuildRequest("thanks", fuckOffRecipient));
            requestDictionary.Add("that", BuildRequest("that", fuckOffRecipient));
            requestDictionary.Add("think", BuildRequest("think", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("thinking", BuildRequest("thinking", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("this", BuildRequest("this", fuckOffRecipient));
            requestDictionary.Add("thumbs", BuildRequest("thumbs", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("too", BuildRequest("too", fuckOffRecipient));
            requestDictionary.Add("tucker", BuildRequest("tucker", fuckOffRecipient));
            requestDictionary.Add("version", BuildRequest("version"));
            requestDictionary.Add("what", BuildRequest("what", fuckOffRecipient));
            requestDictionary.Add("xmas", BuildRequest("xmas", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("yoda", BuildRequest("yoda", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("you", BuildRequest("you", fuckOffRecipient, fuckOffRecipient));
            requestDictionary.Add("zayn", BuildRequest("zayn", fuckOffRecipient));
            requestDictionary.Add("zero", BuildRequest("zero", fuckOffRecipient));
        }

        internal async Task<string> GetRandomFuckOffMessage()
        {
            string[] keys = requestDictionary.AsEnumerable().Select(kvp => kvp.Key).ToArray();
            int index = new Random().Next(0, keys.Length);
            return await GetMessage(keys[index]);
        }

        public async Task<string> GetVersionNumber()
        {
            string request = BuildRequest("version");
            FuckOffMessage message = await requestWrapper.GetResponseAsync(request);
            return message.Message;
            
        }

        private string BuildRequest(params string[] parameters)
        {
            StringBuilder sb = new StringBuilder(BaseUrl);
            sb.Append("/");
            sb.Append(string.Join("/", parameters));
            return sb.ToString();
        }

        public async Task<string> GetFuckinAwesome()
        {
            return await GetMessage("awesome");
        }
        
        public async Task<string> GetWhoAreYouAnyway()
        {
            return await GetMessage("anyway");
        }

        public async Task<string> GetMessage(string key)
        {
            FuckOffMessage message = await requestWrapper.GetResponseAsync(requestDictionary[key]);
            return message.Message;
        }

        public async Task<string> GetEatABagOfDicks()
        {
            return await GetMessage("eatABagOfDicks");
        }

        public async Task<string> Getballmer() { return await GetMessage("ballmer"); }
        public async Task<string> Getbday() { return await GetMessage("bday"); }
        public async Task<string> Getbecause() { return await GetMessage("because"); }
        public async Task<string> Getblackadder() { return await GetMessage("blackadder"); }
        public async Task<string> Getbm() { return await GetMessage("bm"); }
        public async Task<string> Getbucket() { return await GetMessage("bucket"); }
        public async Task<string> Getbus() { return await GetMessage("bus"); }
        public async Task<string> Getbye() { return await GetMessage("bye"); }
        public async Task<string> Getcaniuse() { return await GetMessage("caniuse"); }
        public async Task<string> Getchainsaw() { return await GetMessage("chainsaw"); }
        public async Task<string> Getcocksplat() { return await GetMessage("cocksplat"); }
        public async Task<string> Getcool() { return await GetMessage("cool"); }
        public async Task<string> Getdalton() { return await GetMessage("dalton"); }
        public async Task<string> Getderaadt() { return await GetMessage("deraadt"); }
        public async Task<string> Getdiabetes() { return await GetMessage("diabetes"); }
        public async Task<string> Getdonut() { return await GetMessage("donut"); }
        public async Task<string> Getdosomething() { return await GetMessage("dosomething"); }
        public async Task<string> Geteveryone() { return await GetMessage("everyone"); }
        public async Task<string> Geteverything() { return await GetMessage("everything"); }
        public async Task<string> Getfamily() { return await GetMessage("family"); }
        public async Task<string> Getfascinating() { return await GetMessage("fascinating"); }
        public async Task<string> Getfield() { return await GetMessage("field"); }
        public async Task<string> Getflying() { return await GetMessage("flying"); }
        public async Task<string> Getgfy() { return await GetMessage("gfy"); }
        public async Task<string> Getgive() { return await GetMessage("give"); }
        public async Task<string> Getgreed() { return await GetMessage("greed"); }
        public async Task<string> Gethorse() { return await GetMessage("horse"); }
        public async Task<string> Geting() { return await GetMessage("ing"); }
        public async Task<string> Getkeep() { return await GetMessage("keep"); }
        public async Task<string> Getkeepcalm() { return await GetMessage("keepcalm"); }
        public async Task<string> Getking() { return await GetMessage("king"); }
        public async Task<string> Getlife() { return await GetMessage("life"); }
        public async Task<string> Getlinus() { return await GetMessage("linus"); }
        public async Task<string> Getlook() { return await GetMessage("look"); }
        public async Task<string> Getlooking() { return await GetMessage("looking"); }
        public async Task<string> Getmadison() { return await GetMessage("madison"); }
        public async Task<string> Getmaybe() { return await GetMessage("maybe"); }
        public async Task<string> Getme() { return await GetMessage("me"); }
        public async Task<string> Getmornin() { return await GetMessage("mornin"); }
        public async Task<string> Getno() { return await GetMessage("no"); }
        public async Task<string> Getnugget() { return await GetMessage("nugget"); }
        public async Task<string> Getoff() { return await GetMessage("off"); }
        public async Task<string> GetoffWith() { return await GetMessage("offWith"); }
        public async Task<string> Getoutside() { return await GetMessage("outside"); }
        public async Task<string> Getparticular() { return await GetMessage("particular"); }
        public async Task<string> Getpink() { return await GetMessage("pink"); }
        public async Task<string> Getproblem() { return await GetMessage("problem"); }
        public async Task<string> Getpulp() { return await GetMessage("pulp"); }
        public async Task<string> Getretard() { return await GetMessage("retard"); }
        public async Task<string> Getridiculous() { return await GetMessage("ridiculous"); }
        public async Task<string> Getrtfm() { return await GetMessage("rtfm"); }
        public async Task<string> Getsake() { return await GetMessage("sake"); }
        public async Task<string> Getshakespeare() { return await GetMessage("shakespeare"); }
        public async Task<string> Getshit() { return await GetMessage("shit"); }
        public async Task<string> Getshutup() { return await GetMessage("shutup"); }
        public async Task<string> Getsingle() { return await GetMessage("single"); }
        public async Task<string> Getthanks() { return await GetMessage("thanks"); }
        public async Task<string> Getthat() { return await GetMessage("that"); }
        public async Task<string> Getthink() { return await GetMessage("think"); }
        public async Task<string> Getthinking() { return await GetMessage("thinking"); }
        public async Task<string> Getthis() { return await GetMessage("this"); }
        public async Task<string> Getthumbs() { return await GetMessage("thumbs"); }
        public async Task<string> Gettoo() { return await GetMessage("too"); }
        public async Task<string> Gettucker() { return await GetMessage("tucker"); }
        public async Task<string> Getversion() { return await GetMessage("version"); }
        public async Task<string> Getwhat() { return await GetMessage("what"); }
        public async Task<string> Getxmas() { return await GetMessage("xmas"); }
        public async Task<string> Getyoda() { return await GetMessage("yoda"); }
        public async Task<string> Getyou() { return await GetMessage("you"); }
        public async Task<string> Getzayn() { return await GetMessage("zayn"); }
        public async Task<string> Getzero() { return await GetMessage("zero"); }
    }
}
