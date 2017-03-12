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
        private FuckOffService service;
        private enum Orientation { Landscape, Portrait }

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

        public async void OnSettingsToolbarItemClicked(object sender, EventArgs args)
        {
            await ShowSettingsPage();
        }

        private Task ShowSettingsPage()
        {
            SettingsPageViewModel settingsViewModel = new SettingsPageViewModel(this.service.Settings, Return);
            SettingsPage settingsPage = new SettingsPage(settingsViewModel);
            return Navigation.PushAsync(settingsPage);
        }

        public async void Return()
        {
            await Navigation.PopAsync();
            //this makes eventual changes go all the way down to wherevere they are needed, specifically to update the username in the api.
            //works but not very elegant:)
            this.service.Settings = this.service.Settings;
        }

        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height);
        //    Orientation orientation = width > height ? Orientation.Landscape : Orientation.Portrait;
        //    SetUpPage(orientation);
            
        //}

        //private void SetUpPage(Orientation orientation)
        //{
        //    verticalGrid.IsVisible = orientation == Orientation.Portrait;
        //    horizontalGrid.IsVisible = orientation == Orientation.Landscape;
        //    mainGrid.RowDefinitions[0].Height = orientation == Orientation.Portrait ? GridLength.Star : 0;
        //    mainGrid.RowDefinitions[1].Height = orientation == Orientation.Landscape ? GridLength.Star : 0;
        //    mainGrid.ColumnDefinitions[0].Width = GridLength.Star;


        //}
    }
}
