using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FuckOff
{
    public class App : Application
    {

        MainPage mainPage;
        IFuckOffService fuckOffService;

        public App()
        {
            fuckOffService = new FuckOffService(new FuckOffSettings());
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
