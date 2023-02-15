using System;
namespace AsyncWeather
{
	public static  class CityReader
	{
		public static async Task ReadCityList()
		{
			await Task.Delay(20000);
			Console.WriteLine("Cidades lidas");
		}
	}
}

