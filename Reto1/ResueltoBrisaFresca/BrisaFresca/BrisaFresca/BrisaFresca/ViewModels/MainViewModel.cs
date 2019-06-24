using BrisaFresca.Common;
using BrisaFresca.Models;
using System;

namespace BrisaFresca.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        public MainViewModel()
        {
            this.IsBusy = true;
            this.NeedsRefresh = true;
            this.CityName = "San Jose";
            this.CountryCode = "CR";
            this.CurrentConditions = new WeatherInformation();
        }

        private string _cityName;
        public string CityName
        {
            get { return this._cityName; }
            set { this.SetProperty(ref this._cityName, value); }
        }

        private string _countryCode;
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this.SetProperty(ref this._countryCode, value); }
        }

        private WeatherInformation _currentConditions;
        public WeatherInformation CurrentConditions
        {
            get { return this._currentConditions; }
            set { this.SetProperty(ref this._currentConditions, value); }
        }

        private bool _needsRefresh;
        public bool NeedsRefresh
        {
            get { return true; }
            set { this.SetProperty(ref this._needsRefresh, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return this._isBusy; }
            set { this.SetProperty(ref this._isBusy, value); }
        }

        public async void RefreshCurrentConditionsAsync()
        {
            this.IsBusy = true;
            this.NeedsRefresh = false;

            WeatherInformation results = await Helpers.WeatherHelper.GetCurrentConditionsAsync(this.CityName, this.CountryCode);

            this.CurrentConditions.Id = results.Id;
            this.CurrentConditions.MainWeatherInformation.Temp_Max = results.MainWeatherInformation.Temp_Max;
            this.CurrentConditions.MainWeatherInformation.Temp_Min = results.MainWeatherInformation.Temp_Min;
            this.CurrentConditions.MainWeatherInformation.Temp = results.MainWeatherInformation.Temp;
            this.CurrentConditions.MainWeatherInformation.Humidity = results.MainWeatherInformation.Humidity;
            this.CurrentConditions.TimeStamp = DateTime.Now;

            this.IsBusy = false;
        }
    }
}
