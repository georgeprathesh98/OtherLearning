using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ValidateJWTApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HttpClient httpClient1 = new HttpClient())
            {
                string AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiQWRtaW4iLCJiaXJ0aGRhdGUiOiI0LzI5LzE5OTUgNDoxMjoyNiBQTSIsIm5iZiI6MTU4ODE1Njk1MCwiZXhwIjoxNTg4NzYxNzUwLCJpYXQiOjE1ODgxNTY5NTB9.0kLotQgYTkHQkw3etX5XyLOGJXLtajbGFpXo41No4gk";
                httpClient1.BaseAddress = new Uri("https://localhost:44370/");
                httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", AccessToken);
                HttpResponseMessage response = httpClient1.GetAsync("users/GetAll").Result;
                if (response.IsSuccessStatusCode)
                {
                    System.Console.WriteLine("Success");
                }
                string message = response.Content.ReadAsStringAsync().Result;
                System.Console.WriteLine("URL responese : " + message);
            }
        }
    
    }
}
