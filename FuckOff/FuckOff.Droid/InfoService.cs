using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(FuckOff.Droid.InfoService))]
namespace FuckOff.Droid
{
    public class InfoService : IInfoService
    {
        public string PackageName
        {
            get
            {
                return Forms.Context.PackageName;
            }
        }

        public string AppVersionName
        {
            get
            {
                var context = Forms.Context;
                return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
            }
        }

        public int AppVersionCode
        {
            get
            {
                var context = Forms.Context;
                return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionCode;
            }
        }

    }
}