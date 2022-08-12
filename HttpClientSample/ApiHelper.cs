using System.Net.Http.Headers;

namespace HttpClientSample
{
    internal static class ApiHelper
    {
        public static readonly String JsonHeader = "application/json";
        public static readonly String BaseUrl = "http://eroidemoapi.gtbub5hra2bfe5ec.westus3.azurecontainer.io/";
        public static readonly String WeatherPath = "WeatherForecast";
        public static readonly String PasswdPath = "passwdtestapi";


        private static HttpClient? ApiClient { get; set; }

        public static HttpClient GetClient()
        {
            if (ApiClient == null)
            {
                ApiClient = new HttpClient();
                ApiClient.BaseAddress = new Uri(BaseUrl);
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(JsonHeader));
            }
            return ApiClient;
        }

        public static async Task<List<WeatherResponse>> GetWeatherForecast()
        {
            List<WeatherResponse> weatherResponse = new List<WeatherResponse>();
            HttpResponseMessage response = await GetClient().GetAsync(WeatherPath);
            if (response.IsSuccessStatusCode)
            {
                weatherResponse = await response.Content.ReadAsAsync<List<WeatherResponse>>();
            }
            return weatherResponse;
        }

        public static async Task<PasswdResponse> PostPasswd(PasswdRequest passwdRequest)
        {
            PasswdResponse passwdResponse = new PasswdResponse();
            HttpResponseMessage response = await GetClient().PostAsJsonAsync(PasswdPath, passwdRequest);
            if (response.IsSuccessStatusCode)
            {
                passwdResponse = await response.Content.ReadAsAsync<PasswdResponse>();
            }
            return passwdResponse;
        }
    }
}
