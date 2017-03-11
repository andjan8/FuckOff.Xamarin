using System.Windows.Input;
using Xamarin.Forms;

namespace FuckOff
{
    public class MainPageViewModel : ViewModelBase
    {
        private IFuckOffService fuckOffService;
        public IFuckOffService AppService { get { return this.fuckOffService; } }
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
                            fuckOffService.Settings.FuckOffCounter++;
                        },
                        canExecute: () => { return true; });

                }
                return fuckOffCommand;
            }
        }

        public MainPageViewModel(IFuckOffService fuckOffService)
        {
            this.fuckOffService = fuckOffService;
        }
    }
}