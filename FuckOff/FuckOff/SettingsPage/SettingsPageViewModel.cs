using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FuckOff
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private IFuckOffSettings settings;
        private string userName;
        private string fuckoffCounter;
        private Action Close;
        private Command saveAndCloseCommand;
        public ICommand SaveAndCloseCommand
        {
            get
            {
                if (saveAndCloseCommand == null)
                {
                    saveAndCloseCommand = new Command(
                        execute: () => { SaveAndClose(); },
                        canExecute: () => { return FormChanged(); }
                        );
                }
                return saveAndCloseCommand;
            }
        }
        private Command resetFuckoffCounterCommand;
        public ICommand ResetFuckoffCounterCommand
        {
            get
            {
                if (resetFuckoffCounterCommand == null)
                {
                    resetFuckoffCounterCommand = new Command(
                        execute: () => {
                            FuckoffCounter = "0";
                            settings.FuckOffCounter = 0;
                            RefreshCanExecutes(); },
                        canExecute: ()=> { return settings.FuckOffCounter > 0; }
                        );
                }
                return resetFuckoffCounterCommand;
            }
        }
        public string UserName
        {
            set
            {
                SetProperty(ref userName, value);
                RefreshCanExecutes();
            }
            get
            {
                return userName;
            }
        }
        public string FuckoffCounter
        {
            private set
            {
                SetProperty(ref fuckoffCounter, value);
                RefreshCanExecutes();
            }
            get
            {
                return fuckoffCounter;
            }
        }


        public SettingsPageViewModel(IFuckOffSettings settings, Action close)
        {
            this.settings = settings;
            this.userName = settings.UserName;
            this.UserName = settings.UserName;
            this.FuckoffCounter = settings.FuckOffCounter.ToString();
            this.Close = close;
        }
        
        private bool FormChanged()
        {
            return this.UserName != settings.UserName;
        }

        private void SaveAndClose()
        {
            Save();
            Close();
        }

        private void Save()
        {
            this.settings.UserName = this.UserName;
        }

        public void RefreshCanExecutes()
        {
            ((Command)SaveAndCloseCommand).ChangeCanExecute();
            ((Command)ResetFuckoffCounterCommand).ChangeCanExecute();
        }


    }
}