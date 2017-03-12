using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FuckOff
{
    public class MainPageViewModel : ViewModelBase
    {
        private FuckOffService fuckOffService;
        public FuckOffService AppService { get { return this.fuckOffService; } }

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

        private Command shareCommand;
        public ICommand ShareCommand
        {
            get
            {
                if (shareCommand == null)
                {
                    shareCommand = new Command(
                        execute: () =>
                        {

                        },
                        canExecute: () => { return false; });

                }
                return shareCommand;
            }
        }
        
        public MainPageViewModel(FuckOffService fuckOffService)
        {
            this.fuckOffService = fuckOffService;
            RefreshCanExecutes();
        }

        private async void OnFuckOffCommandClick()
        {
            FuckOffText = await AppService.GetRandomFuckOff();
            fuckOffService.Settings.FuckOffCounter++;
        }

        public void RefreshCanExecutes()
        {
            ((Command)FuckOffCommand).ChangeCanExecute();
            ((Command)ShareCommand).ChangeCanExecute();
        }
    }
}