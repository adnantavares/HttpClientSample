using Newtonsoft.Json;

namespace HttpClientSample
{
    internal class WeatherResponse
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string? Summary { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine(
                $"Date: {Date} \n" +
                $"Temperature C: {TemperatureC} \n" +
                $"Temperatire F: {TemperatureF} \n" +
                $"Summary: {Summary}");
        }
    }
}
