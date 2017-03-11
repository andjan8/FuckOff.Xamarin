using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FuckOff
{
    internal class PropertyHandler
    {
        const string userName = "UserName";
        const string fuckOffCounter = "FuckOffCounter";

        internal static FuckOffSettings RetrieveSettings(IDictionary<string, object> properties)
        {
            FuckOffSettings settings = new FuckOffSettings();
            settings.UserName = GetStringProperty(properties, userName);
            settings.FuckOffCounter = GetIntProperty(properties, fuckOffCounter);
            return settings;
        }

        private static int GetIntProperty(IDictionary<string, object> properties, string propertyName)
        {
            return properties.ContainsKey(propertyName) ? (int)properties[propertyName] : 0;
        }

        private static string GetStringProperty(IDictionary<string, object> properties, string propertyName)
        {
            return properties.ContainsKey(propertyName) && !string.IsNullOrEmpty((string)properties[propertyName]) ? (string)properties[propertyName] : string.Empty;
        }

        internal static void SaveSettings(FuckOffSettings settings, IDictionary<string, object> properties, Func<Task> savePropertiesAsync)
        {
            properties[userName] = settings.UserName;
            properties[fuckOffCounter] = settings.FuckOffCounter;
            savePropertiesAsync();
         
        }
    }
}