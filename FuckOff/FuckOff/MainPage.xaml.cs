using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FuckOff
{
    public partial class MainPage : ContentPage
    {
        private IFuckOffService service;

        
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            this.service = viewModel.AppService;
            BindingContext = viewModel;
        }

        public async void OnAboutToolbarItemClicked(object sender, EventArgs args)
        {

            AboutPageViewModel aboutViewModel = new AboutPageViewModel(this.service);
            AboutPage aboutPage = new AboutPage(aboutViewModel);
            await Navigation.PushAsync(aboutPage);
        }
    }
}
