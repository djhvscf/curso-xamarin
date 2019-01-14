using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Text;

namespace Ejercicio1.Utils
{
    public class ResourceContainer : IResourceContainer
    {
        public static string ResourceId = "Ejercicio1.Utils.AppResources"; // The namespace and name of your Resources file
        private CultureInfo _cultureInfo;
        private ResourceManager _resourceManager;

        public ResourceContainer(ResourceManager manager, ILocalize localize)
        {
            _cultureInfo = localize.GetCurrentCultureInfo();
            _resourceManager = manager;
        }

        public string GetString(string key)
        {
            return _resourceManager.GetString(key, _cultureInfo);
        }
    }
}
