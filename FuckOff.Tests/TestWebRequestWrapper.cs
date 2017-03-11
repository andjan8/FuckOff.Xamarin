using FuckOff.Service;
using System.Net;
using System.Threading.Tasks;
using System;

namespace FuckOff.Tests
{
    internal class TestWebRequestWrapper : WebRequestWrapper 
    {


        protected override async Task<FuckOffMessage> _GetResponseAsync(string requestUri)
        {
            Request = requestUri;
            GetResponseCalled = true;
            return GetMessage(requestUri);
        }

        private FuckOffMessage GetMessage(string requestUri)
        {
            FuckOffMessage message = new FuckOffMessage();

            switch (requestUri)
            {
                case "http://foaas.com/version":
                    message.Message = "Version 1.1.0";
                    break;
                //case "":
                //    message.Message = "";
                //    break;
                default:
                    message.Message = "NOOO";
                    break;
            }
            return message;
        }

        public bool GetResponseCalled { get; internal set; }
        public string Request { get; private set; }
    }
}