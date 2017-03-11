using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FuckOff
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private IFuckOffSettings settings;
        private string userName;
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

        public SettingsPageViewModel(IFuckOffSettings settings, Action close)
        {
            this.settings = settings;
            this.userName = settings.UserName;
            this.UserName = settings.UserName;
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
        }


    }
}