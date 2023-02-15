namespace AsyncWeather;
class Program
{
    static async Task Main(string[] args)
    {
        Task pegarTempo = WeatherService.GetWeatherAsync();
        Task lerCidades = CityReader.ReadCityList();
        await pegarTempo;
        await lerCidades;
        _ = Task.WhenAll(new Task[] { pegarTempo, lerCidades });
    }
}

