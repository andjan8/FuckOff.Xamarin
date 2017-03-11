using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FuckOff
{
    public class FuckOffService 
    {
        private FuckOffSettings settings;
        private FoaasAPI foaas;

        public FuckOffSettings Settings { get { return this.settings; } set { this.settings = value; } }

        public string APIName
        {
            get
            {
                return foaas.BaseUrl;
            }
        }

        public string APIVersion { get; private set; }
         

        public int FuckOffCounter
        {
            get
            {
                return this.Settings.FuckOffCounter;
            }
        }

        public string ProjectName
        {
            get
            {


                return DependencyService.Get<IInfoService>().PackageName;
            }
        }

        public string ProjectVersion
        {
            get
            {
                return DependencyService.Get<IInfoService>().AppVersionName;
            }
        }

        public async Task<string> GetRandomFuckOff()
        {
            return await foaas.GetRandomFuckOffMessage();
        }

        

        public FuckOffService(FuckOffSettings settings, FoaasAPI foaas)
        {
            this.settings = settings;
            this.foaas = foaas;
           // Task<string> t = foaas.GetVersionNumber();
           // this.APIVersion = t.Result;
        }
    }

}
