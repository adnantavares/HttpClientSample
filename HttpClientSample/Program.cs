using System.Diagnostics;

namespace HttpClientSample
{

    class Program
    {

        static async Task Main()
        {
            try
            {
                var passwdResponse = await ApiHelper.PostPasswd(new PasswdRequest("minhasenhaestacorreta1"));
                passwdResponse.PrintToConsole();

                var weatherResponse = await ApiHelper.GetWeatherForecast();
                foreach (var weather in weatherResponse)
                {
                    weather.PrintToConsole();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}