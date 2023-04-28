using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ComunicationLayer.Model.api
{
    public class OpenWeatherMapService
    {
        private static readonly string URL_BASE = "https://api.openweathermap.org/data/2.5/";
        private static readonly string APP_ID = "f31871678b3b4658645f14a6fa76da53"; //

        public static async Task<CurrentWeatherResponse> GetOneDayWeather(string city)
        {
            CurrentWeatherResponse currentWeatherResponse = new CurrentWeatherResponse();

            using (var httpClient = new HttpClient())
            {

                HttpRequestMessage request;
                HttpResponseMessage response;
                try
                {
                    string url = string.Format("{0}weather?q={1}&appid={2}&lang=es&units=metric", URL_BASE, city, APP_ID);

                    request = new HttpRequestMessage(HttpMethod.Get, url);
                    response = await httpClient.SendAsync(request);

                    if (response != null)
                    {
                        if (response.IsSuccessStatusCode)
                        {                            
                            string jsonContent = await response.Content.ReadAsStringAsync();
                            currentWeatherResponse = JsonConvert.DeserializeObject<CurrentWeatherResponse>(jsonContent);
                        }
                        else
                        {
                            Console.WriteLine(String.Format("Error: {0} - {1}",
                            (int)response.StatusCode, response.StatusCode));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error con el servicio");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                return currentWeatherResponse;
            }
        }

        public static async Task<NearbyWeatherResponse> GetForestWeather(string city)
        {
            NearbyWeatherResponse nearbyWeatherResponse = new NearbyWeatherResponse();

            using (var httpClient = new HttpClient())
            {

                HttpRequestMessage request;
                HttpResponseMessage response;
                try
                {
                    string url = string.Format("{0}forecast?q={1}&appid={2}&lang=es&units=metric", URL_BASE, city, APP_ID);

                    request = new HttpRequestMessage(HttpMethod.Get, url);
                    response = await httpClient.SendAsync(request);

                    if (response != null)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            nearbyWeatherResponse = JsonConvert.DeserializeObject<NearbyWeatherResponse>(json);
                        }
                        else
                        {                            
                            Console.WriteLine(String.Format("Error: {0} - {1}",
                            (int)response.StatusCode, response.StatusCode));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error con el servicio");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                return nearbyWeatherResponse;
            }
        }
    }
}
