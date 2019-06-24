using BrisaFresca.Common;
using Newtonsoft.Json;
using System;

namespace BrisaFresca.Models
{
    public class WeatherInformation : ObservableBase
    {
        public WeatherInformation()
        {
            MainWeatherInformation = new MainWeatherInformation();
        }

        private int _id;
        public int Id
        {
            get { return this._id; }
            set { this.SetProperty(ref this._id, value); }
        }

        private DateTime _timestamp;
        public DateTime TimeStamp
        {
            get { return this._timestamp; }
            set { this.SetProperty(ref this._timestamp, value); }
        }

        [JsonProperty("main")]
        public MainWeatherInformation MainWeatherInformation { get; set; }
    }
}
