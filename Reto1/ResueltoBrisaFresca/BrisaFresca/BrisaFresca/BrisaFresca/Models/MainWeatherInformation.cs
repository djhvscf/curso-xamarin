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

        private string _pressure;
        public string Pressure
        {
            get { return this._pressure; }
            set { this.SetProperty(ref this._pressure, value); }
        }

        private string _humidity;
        public string Humidity
        {
            get { return this._humidity; }
            set { this.SetProperty(ref this._humidity, value); }
        }

        private string _temp_min;
        [JsonProperty("temp_min")]
        public string Temp_Min
        {
            get { return this._temp_min; }
            set { this.SetProperty(ref this._temp_min, value); }
        }

        private string _temp_max;
        [JsonProperty("temp_max")]
        public string Temp_Max {
            get { return this._temp_max; }
            set { this.SetProperty(ref this._temp_max, value); }
        }
    }
}
