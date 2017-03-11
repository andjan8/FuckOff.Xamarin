using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FuckOff
{
    public partial class SettingsPage : ContentPage
    {
        private SettingsPageViewModel settingsViewModel;


        public SettingsPage(SettingsPageViewModel settingsViewModel)
        {
            InitializeComponent();
            BindingContext = settingsViewModel;
        }
    }
}
