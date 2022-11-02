using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWeatherData
{
    internal class DailyWeather
    {
        public string DisplayData { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
        public bool Sunny { get; set; }
        public double WindSpeed { get; set; }
        public double Temperature { get; set; }
        public DailyWeather()
        {

        }
        public DailyWeather(bool sunny, double windSpeed, double temperature)
        {
            Sunny = sunny;
            WindSpeed = windSpeed;
            Temperature = temperature;
            if (sunny)
            {
                DisplayData = $"Date: {dateTime.ToString("yy/MM/dd")} is sunny, wind speed is {windSpeed} m/s and temperature is {temperature}";
            }
            else
            {
                DisplayData = $"Date: {dateTime.ToString("yy/MM/dd")} is not sunny, wind speed is {windSpeed} m/s and temperature is {temperature}";
            }
            
        }    
    }
    
}
