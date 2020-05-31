using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace BlazorApp5.Grpc
{
    [ServiceContract(Name = "BlazorApp5.Weather")]
    public interface IWeatherService
    {
        public async Task<WeatherForecast[]> GetForecastsAsync()
        {
            await Task.Yield();
            return new[]
            {
                new WeatherForecast {Date = new DateTime(2018, 05, 06), Summary = "Freezing", TemperatureC = 1}, 
                new WeatherForecast {Date = new DateTime(2018, 05, 07), Summary = "Bracing", TemperatureC = 14}, 
                new WeatherForecast {Date = new DateTime(2018, 05, 08), Summary = "Freezing", TemperatureC = -13}, 
                new WeatherForecast {Date = new DateTime(2018, 05, 09), Summary = "Balmy", TemperatureC = -16}, 
                new WeatherForecast {Date = new DateTime(2018, 05, 10), Summary = "Chilly", TemperatureC = -2}
            };
        }
    }
}