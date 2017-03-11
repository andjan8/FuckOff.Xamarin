using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckOff
{
    public interface IFuckOffSettings
    {
        int FuckOffCounter { get; set; }
        string UserName { get; set; }
    }

    public class FuckOffSettings : IFuckOffSettings
    {
        public string UserName { get; set; }
        public int FuckOffCounter { get; set; }
    }

}
