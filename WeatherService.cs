using System;
namespace AsyncWeather
{
	public static class WeatherService
	{
		public static async Task GetWeatherAsync()
		{
            await Task.Delay(10000);
			Console.WriteLine($"Faz {new Random().Next(0, 40)}, {(new Random().Next(0,2) == 0 ? "" : "não")} está chovendo e {(new Random().Next(0, 2) == 0 ? "" : "não")} está ventando");
		}
	}
}

