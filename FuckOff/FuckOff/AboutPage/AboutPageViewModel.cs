using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckOff
{
    public class AboutPageViewModel : ViewModelBase
    {
        public string ProjectName
        {
            private set { SetProperty(ref projectName, value); }
            get { return projectName; }
        }

        public string ProjectVersion
        {
            private set { SetProperty(ref projectVersion, value); }
            get { return projectVersion; }
        }

        public string APIName
        {
            private set { SetProperty(ref apiName, value); }
            get { return apiName; }
        }

        public string APIVersion
        {
            private set { SetProperty(ref apiVersion, value); }
            get { return apiVersion; }
        }

        public string NrOfFuckoffs
        {
            private set { SetProperty(ref nrOfFuckoffs, value); }
            get { return nrOfFuckoffs; }
        }

        string nrOfFuckoffs;
        string apiVersion;
        string apiName;
        string projectVersion;
        string projectName;
        private FuckOffService service;
                
        public AboutPageViewModel(FuckOffService service)
        {

            this.nrOfFuckoffs = service.FuckOffCounter.ToString();
            this.apiVersion = service.APIVersion;
            this.apiName = service.APIName;
            this.projectVersion = service.ProjectVersion;
            this.projectName = service.ProjectName;
        }
    }
}
