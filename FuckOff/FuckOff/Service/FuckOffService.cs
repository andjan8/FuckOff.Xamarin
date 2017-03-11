using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FuckOff
{
    public interface IFuckOffService
    {
        string APIName { get; }
        string APIVersion { get; }
        int FuckOffCounter { get; }
        string ProjectName { get; }
        string ProjectVersion { get; }
        IFuckOffSettings Settings { get; set; }
    }

    public class FuckOffService : IFuckOffService
    {
        private IFuckOffSettings settings;
        public IFuckOffSettings Settings { get { return this.settings; } set { this.settings = value; } }

        public string APIName
        {
            get
            {
                return "THIS IS THE NAME OF THE API";
            }
        }

        public string APIVersion
        {
            get
            {
                return "This is the api version";
            }
        }

        public int FuckOffCounter
        {
            get
            {
                return this.Settings.FuckOffCounter;
            }
        }

        public string ProjectName
        {
            get
            {


                return DependencyService.Get<IInfoService>().PackageName;
            }
        }

        public string ProjectVersion
        {
            get
            {
                return DependencyService.Get<IInfoService>().AppVersionName;
            }
        }

        public FuckOffService(IFuckOffSettings settings)
        {
            this.settings = settings;
        }
    }

}
