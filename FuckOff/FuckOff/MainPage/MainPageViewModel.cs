using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FuckOff
{
    public class MainPageViewModel : ViewModelBase
    {
        private FuckOffService fuckOffService;
        public FuckOffService AppService { get { return this.fuckOffService; } }
        private Command fuckOffCommand;
        public ICommand FuckOffCommand
        {
            get
            {
                if (fuckOffCommand == null)
                {
                    fuckOffCommand = new Command(
                        execute: () =>
                        {
                            OnFuckOffCommandClick();
                            
                        },
                        canExecute: () => { return true; });

                }
                return fuckOffCommand;
            }
        }

        private async void OnFuckOffCommandClick()
        {
            FuckOffText = await AppService.GetRandomFuckOff();
            fuckOffService.Settings.FuckOffCounter++;
        }

        private string fuckOffText;
        public string FuckOffText
        {
            private set
            {
                SetProperty(ref fuckOffText, value);
            }
            get
            {
                return fuckOffText;
            }
        }
        public MainPageViewModel(FuckOffService fuckOffService)
        {
            this.fuckOffService = fuckOffService;
        }
    }
}