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
        MainPageViewModel viewModel;
        MainPage mainPage;
        IFuckOffSettings settings;
        IFuckOffService fuckOffService;

        public App()
        {
            settings = new FuckOffSettings();
            fuckOffService = new FuckOffService(settings);
            viewModel = new MainPageViewModel(fuckOffService);
            mainPage = new MainPage(viewModel);
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {

        }

        protected override void OnResume()
        {
        }
    }
}
