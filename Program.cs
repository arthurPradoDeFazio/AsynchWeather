namespace AsyncWeather;
class Program
{
    static async Task Main(string[] args)
    {
        await WeatherService.GetWeatherAsync();
        await CityReader.ReadCityList();
    }
}

