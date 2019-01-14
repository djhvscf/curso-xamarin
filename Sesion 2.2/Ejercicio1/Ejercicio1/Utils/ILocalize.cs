using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ejercicio1.Utils
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
