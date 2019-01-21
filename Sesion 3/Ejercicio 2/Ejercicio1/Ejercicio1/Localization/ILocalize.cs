using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ejercicio2.Localization
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
