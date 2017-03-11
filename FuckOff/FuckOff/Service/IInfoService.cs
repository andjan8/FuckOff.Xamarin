using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckOff
{
    public interface IInfoService
    {
        
        string PackageName { get; }
        string AppVersionName { get; }
        int AppVersionCode { get; }
        
    }
}
