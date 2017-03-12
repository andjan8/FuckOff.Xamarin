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

            fuckOffService = new FuckOffService(new FuckOffSettings(), new FoaasAPI(new WebRequestWrapper()));
            mainPage = new MainPage(new MainPageViewModel(fuckOffService));
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
            fuckOffService.Settings = PropertyHandler.RetrieveSettings(this.Properties);
            if (fuckOffService.Settings.UserName == new FuckOffSettings().UserName)
            {
                App.Current.MainPage.DisplayAlert("First Use", "You need to configure a user name in order to get personalized fuck off messages. Go to the settings page and enter a name of your choosing.", "OK");
            }
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
