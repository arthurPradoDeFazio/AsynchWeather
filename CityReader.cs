using System;
namespace AsyncWeather
{
	public static  class CityReader
	{
		public static async Task ReadCityList()
		{
			await Task.Delay(100000);
			Console.WriteLine("Cidades lidas");
		}
	}
}

