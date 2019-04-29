using BrisaFresca.Common;
using Newtonsoft.Json;

namespace BrisaFresca.Models
{
    public class MainWeatherInformation : ObservableBase
    {
        private string _temp;
        public string Temp
        {
            get { return this._temp; }
            set { this.SetProperty(ref this._temp, value); }
        }
    }
}
