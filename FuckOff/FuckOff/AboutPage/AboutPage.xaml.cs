using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FuckOff
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage(AboutPageViewModel aboutViewModel)
        {
            InitializeComponent();
            BindingContext = aboutViewModel;
        }
    }
}
