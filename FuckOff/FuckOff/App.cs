using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FuckOff.Service;
namespace FuckOff
{
    public class App : Application
    {

        MainPage mainPage;
        FuckOffService fuckOffService;

        public App()
        {

            fuckOffService = new FuckOffService(new FuckOffSettings(), new FoaasAPI(new WebRequestWrapper(), "anja"));
            mainPage = new MainPage(new MainPageViewModel(fuckOffService));
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
            fuckOffService.Settings = PropertyHandler.RetrieveSettings(this.Properties);
        }
        
        protected override void OnResume()
        {
            fuckOffService.Settings = PropertyHandler.RetrieveSettings(this.Properties);
        }

        protected override void OnSleep()
        {
            PropertyHandler.SaveSettings(fuckOffService.Settings, this.Properties, SavePropertiesAsync);
        }

        
    }
}
