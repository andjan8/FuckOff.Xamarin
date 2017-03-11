namespace FuckOff
{
    public class MainPageViewModel : ViewModelBase
    {
        private IFuckOffService fuckOffService;
        public IFuckOffService AppService { get { return this.fuckOffService; } }

        public MainPageViewModel(IFuckOffService fuckOffService)
        {
            this.fuckOffService = fuckOffService;
        }
    }
}